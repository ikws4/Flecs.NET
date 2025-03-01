using System.Collections.Generic;
using System.Linq;
using Flecs.NET.Codegen.Helpers;

namespace Flecs.NET.Codegen.Generators;

public class Entity : GeneratorBase
{
    public override void Generate()
    {
        for (int i = 0; i < Generator.GenericCount; i++)
        {
            AddSource($"Entity.Id.g.cs", Id.GenerateExtensions(Type.Entity));
            AddSource($"Entity.ComponentCallbacks/T{i + 1}.g.cs", GenerateComponentCallbacks(Type.Entity, i));
        }
    }

    public static string GenerateComponentCallbacks(Type type, int i)
    {
        IEnumerable<string> readAndWrite = Generator.CallbacksReadAndWrite.Select((Callback callback) => $$"""
                /// <summary>
                ///     {{Generator.GetInvokerName(callback)}} {{i + 1}} components using the provided callback. <br/><br/>
                /// 
                ///     This operation accepts a callback with as arguments the components to
                ///     retrieve. The callback will only be invoked when the entity has all
                ///     the components. <br/><br/>
                ///     
                ///     This operation is faster than individually calling get for each component
                ///     as it only obtains entity metadata once.  <br/><br/>
                ///     
                ///     While the callback is invoked the table in which the components are
                ///     stored is locked, which prevents mutations that could cause invalidation
                ///     of the component references. Note that this is not an actual lock: 
                ///     invalid access causes a runtime panic and so it is still up to the 
                ///     application to ensure access is protected.  <br/><br/>
                /// </summary>
                /// <param name="callback">The callback.</param>
                /// {{Generator.XmlTypeParameters[i]}}
                /// <returns>True if the entity has the specified components.</returns>
                public bool {{Generator.GetInvokerName(callback)}}<{{Generator.TypeParameters[i]}}>({{Generator.GetCallbackType(callback, i)}} callback)
                {
                    return Invoker.{{Generator.GetInvokerName(callback)}}(World, Id, callback);
                }
            """);

        IEnumerable<string> insert = Generator.CallbacksInsert.Select((Callback callback) => $$"""
                /// <summary>
                ///     Ensures {{i + 1}} components using the provided callback.<br/><br/>
                /// 
                ///     This operation accepts a callback with as arguments the components to
                ///     set. If the entity does not have all of the provided components, they
                ///     will be added. <br/><br/>
                ///
                ///     This operation is faster than individually calling ensure for each component
                ///     as it only obtains entity metadata once. When this operation is called
                ///     while deferred, its performance is equivalent to that of calling ensure
                ///     for each component separately. <br/><br/>
                ///
                ///     The operation will invoke modified for each component after the callback
                ///     has been invoked.
                /// </summary>
                /// <param name="callback">The callback.</param>
                /// {{Generator.XmlTypeParameters[i]}}
                /// <returns>Reference to self.</returns>
                public ref {{type}} {{Generator.GetInvokerName(callback)}}<{{Generator.TypeParameters[i]}}>({{Generator.GetCallbackType(callback, i)}} callback)
                {
                    Invoker.{{Generator.GetInvokerName(callback)}}(World, Id, callback);
                    return ref this;
                }
            """);

        return $$"""
            using System;

            namespace Flecs.NET.Core;

            public unsafe partial struct {{type}}
            {
            {{string.Join(Separator.DoubleNewLine, readAndWrite.Concat(insert))}}
            }
            """;
    }

    public static string GenerateExtensions(Type type, int i = -1)
    {
        string typeName = Generator.GetTypeName(type, i);

        return $$"""
            using System;
            using static Flecs.NET.Bindings.flecs;
            
            namespace Flecs.NET.Core;
            
            public unsafe partial struct {{typeName}}
            {
                /// <inheritdoc cref="Entity.IsValid()"/>
                public bool IsValid()
                {
                    return Entity.IsValid();
                }
            
                /// <inheritdoc cref="Entity.IsAlive()"/>
                public bool IsAlive()
                {
                    return Entity.IsAlive();
                }
            
                /// <inheritdoc cref="Entity.Name()"/>
                public string Name()
                {
                    return Entity.Name();
                }
            
                /// <inheritdoc cref="Entity.Symbol()"/>
                public string Symbol()
                {
                    return Entity.Symbol();
                }
            
                /// <inheritdoc cref="Entity.Path(string, string)"/>
                public string Path(string sep = Ecs.DefaultSeparator, string initSep = Ecs.DefaultSeparator)
                {
                    return Entity.Path(sep, initSep);
                }
            
                /// <inheritdoc cref="Entity.PathFrom(ulong, string, string)"/>
                public string PathFrom(ulong parent, string sep = Ecs.DefaultSeparator, string initSep = Ecs.DefaultSeparator)
                {
                    return Entity.PathFrom(parent, sep, initSep);
                }
            
                /// <inheritdoc cref="Entity.PathFrom{TParent}(string, string)"/>
                public string PathFrom<TParent>(string sep = Ecs.DefaultSeparator, string initSep = Ecs.DefaultSeparator)
                {
                    return Entity.PathFrom<TParent>(sep, initSep);
                }
            
                /// <inheritdoc cref="Entity.Enabled()"/>
                public bool Enabled()
                {
                    return Entity.Enabled();
                }
            
                /// <inheritdoc cref="Entity.Enabled(ulong)"/>
                public bool Enabled(ulong id)
                {
                    return Entity.Enabled(id);
                }
            
                /// <inheritdoc cref="Entity.Enabled(ulong, ulong)"/>
                public bool Enabled(ulong first, ulong second)
                {
                    return Entity.Enabled(first, second);
                }
            
                /// <inheritdoc cref="Entity.Enabled{T}()"/>
                public bool Enabled<T>()
                {
                    return Entity.Enabled<T>();
                }
            
                /// <inheritdoc cref="Entity.Enabled{T}(T)"/>
                public bool Enabled<T>(T value) where T : Enum
                {
                    return Entity.Enabled(value);
                }
            
                /// <inheritdoc cref="Entity.Enabled{TFirst}(ulong)"/>
                public bool Enabled<TFirst>(ulong second)
                {
                    return Entity.Enabled<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.Enabled{TFirst, TSecond}()"/>
                public bool Enabled<TFirst, TSecond>()
                {
                    return Entity.Enabled<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.Enabled{TFirst, TSecond}(TSecond)"/>
                public bool Enabled<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    return Entity.Enabled<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.Enabled{TFirst, TSecond}(TFirst)"/>
                public bool Enabled<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    return Entity.Enabled<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.EnabledSecond{TSecond}(ulong)"/>
                public bool EnabledSecond<TSecond>(ulong first)
                {
                    return Entity.EnabledSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Type()"/>
                public Types Type()
                {
                    return Entity.Type();
                }
            
                /// <inheritdoc cref="Entity.Table()"/>
                public Table Table()
                {
                    return Entity.Table();
                }
            
                /// <inheritdoc cref="Entity.Range()"/>
                public Table Range()
                {
                    return Entity.Range();
                }
            
                /// <inheritdoc cref="Entity.Each(Ecs.EachIdCallback)"/>
                public void Each(Ecs.EachIdCallback func)
                {
                    Entity.Each(func);
                }
            
                /// <inheritdoc cref="Entity.Each(ulong, ulong, Ecs.EachIdCallback)"/>
                public void Each(ulong first, ulong second, Ecs.EachIdCallback func)
                {
                    Entity.Each(first, second, func);
                }
            
                /// <inheritdoc cref="Entity.Each(ulong, Ecs.EachEntityCallback)"/>
                public void Each(ulong relation, Ecs.EachEntityCallback func)
                {
                    Entity.Each(relation, func);
                }
            
                /// <inheritdoc cref="Entity.Each{TFirst}(Ecs.EachEntityCallback)"/>
                public void Each<TFirst>(Ecs.EachEntityCallback func)
                {
                    Entity.Each<TFirst>(func);
                }
            
                /// <inheritdoc cref="Entity.Each{TFirst}(TFirst, Ecs.EachEntityCallback)"/>
                public void Each<TFirst>(TFirst relation, Ecs.EachEntityCallback callback) where TFirst : Enum
                {
                    Entity.Each(relation, callback);
                }
            
                /// <inheritdoc cref="Entity.Children(ulong, Ecs.EachEntityCallback)"/>
                public void Children(ulong relation, Ecs.EachEntityCallback callback)
                {
                    Entity.Children(relation, callback);
                }
            
                /// <inheritdoc cref="Entity.Children{TRel}(Ecs.EachEntityCallback)"/>
                public void Children<TRel>(Ecs.EachEntityCallback callback)
                {
                    Entity.Children<TRel>(callback);
                }
            
                /// <inheritdoc cref="Entity.Children{TFirst}(TFirst, Ecs.EachEntityCallback)"/>
                public void Children<TFirst>(TFirst relation, Ecs.EachEntityCallback callback) where TFirst : Enum
                {
                    Entity.Children(relation, callback);
                }
            
                /// <inheritdoc cref="Entity.Children(Ecs.EachEntityCallback)"/>
                public void Children(Ecs.EachEntityCallback callback)
                {
                    Entity.Children(callback);
                }
            
                /// <inheritdoc cref="Entity.GetPtr(ulong)"/>
                public void* GetPtr(ulong compId)
                {
                    return Entity.GetPtr(compId);
                }
            
                /// <inheritdoc cref="Entity.GetPtr(ulong, ulong)"/>
                public void* GetPtr(ulong first, ulong second)
                {
                    return Entity.GetPtr(first, second);
                }
            
                /// <inheritdoc cref="Entity.GetPtr{T}()"/>
                public T* GetPtr<T>() where T : unmanaged
                {
                    return Entity.GetPtr<T>();
                }
            
                /// <inheritdoc cref="Entity.GetPtr{TFirst}(ulong)"/>
                public TFirst* GetPtr<TFirst>(ulong second) where TFirst : unmanaged
                {
                    return Entity.GetPtr<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.GetPtr{TFirst, TSecond}(TSecond)"/>
                public TFirst* GetPtr<TFirst, TSecond>(TSecond second) where TFirst : unmanaged
                    where TSecond : Enum
                {
                    return Entity.GetPtr<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.GetPtr{TFirst, TSecond}(TFirst)"/>
                public TSecond* GetPtr<TFirst, TSecond>(TFirst first) where TFirst : Enum
                    where TSecond : unmanaged
                {
                    return Entity.GetPtr<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetFirstPtr{TFirst, TSecond}()"/>
                public TFirst* GetFirstPtr<TFirst, TSecond>() where TFirst : unmanaged
                {
                    return Entity.GetFirstPtr<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetSecondPtr{TFirst, TSecond}()"/>
                public TSecond* GetSecondPtr<TFirst, TSecond>() where TSecond : unmanaged
                {
                    return Entity.GetSecondPtr<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetSecondPtr{TSecond}(ulong)"/>
                public TSecond* GetSecondPtr<TSecond>(ulong first) where TSecond : unmanaged
                {
                    return Entity.GetSecondPtr<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Get{T}()"/>
                public ref readonly T Get<T>()
                {
                    return ref Entity.Get<T>();
                }
            
                /// <inheritdoc cref="Entity.Get{TFirst}(ulong)"/>
                public ref readonly TFirst Get<TFirst>(ulong second)
                {
                    return ref Entity.Get<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.Get{TFirst, TSecond}(TSecond)"/>
                public ref readonly TFirst Get<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    return ref Entity.Get<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.Get{TFirst, TSecond}(TFirst)"/>
                public ref readonly TSecond Get<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    return ref Entity.Get<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetFirst{TFirst, TSecond}()"/>
                public ref readonly TFirst GetFirst<TFirst, TSecond>()
                {
                    return ref Entity.GetFirst<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetSecond{TFirst, TSecond}()"/>
                public ref readonly TSecond GetSecond<TFirst, TSecond>()
                {
                    return ref Entity.GetSecond<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetSecond{TSecond}(ulong)"/>
                public ref readonly TSecond GetSecond<TSecond>(ulong first)
                {
                    return ref Entity.GetSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetMutPtr(ulong)"/>
                public void* GetMutPtr(ulong id)
                {
                    return Entity.GetMutPtr(id);
                }
            
                /// <inheritdoc cref="Entity.GetMutPtr(ulong, ulong)"/>
                public void* GetMutPtr(ulong first, ulong second)
                {
                    return Entity.GetMutPtr(first, second);
                }
            
                /// <inheritdoc cref="Entity.GetMutPtr{T}()"/>
                public T* GetMutPtr<T>() where T : unmanaged
                {
                    return Entity.GetMutPtr<T>();
                }
            
                /// <inheritdoc cref="Entity.GetMutPtr{TFirst}(ulong)"/>
                public TFirst* GetMutPtr<TFirst>(ulong second) where TFirst : unmanaged
                {
                    return Entity.GetMutPtr<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.GetMutPtr{TFirst, TSecond}(TSecond)"/>
                public TFirst* GetMutPtr<TFirst, TSecond>(TSecond second) where TFirst : unmanaged
                    where TSecond : Enum
                {
                    return Entity.GetMutPtr<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.GetMutPtr{TFirst, TSecond}(TFirst)"/>
                public TSecond* GetMutPtr<TFirst, TSecond>(TFirst first) where TFirst : Enum
                    where TSecond : unmanaged
                {
                    return Entity.GetMutPtr<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetMutFirstPtr{TFirst, TSecond}()"/>
                public TFirst* GetMutFirstPtr<TFirst, TSecond>() where TFirst : unmanaged
                {
                    return Entity.GetMutFirstPtr<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetMutSecondPtr{TFirst, TSecond}()"/>
                public TSecond* GetMutSecondPtr<TFirst, TSecond>() where TSecond : unmanaged
                {
                    return Entity.GetMutSecondPtr<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetMutSecondPtr{TSecond}(ulong)"/>
                public TSecond* GetMutSecondPtr<TSecond>(ulong first) where TSecond : unmanaged
                {
                    return Entity.GetMutSecondPtr<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetMut{T}()"/>
                public ref T GetMut<T>()
                {
                    return ref Entity.GetMut<T>();
                }
            
                /// <inheritdoc cref="Entity.GetMut{TFirst}(ulong)"/>
                public ref TFirst GetMut<TFirst>(ulong second)
                {
                    return ref Entity.GetMut<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.GetMut{TFirst, TSecond}(TSecond)"/>
                public ref TFirst GetMut<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    return ref Entity.GetMut<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.GetMut{TFirst, TSecond}(TFirst)"/>
                public ref TSecond GetMut<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    return ref Entity.GetMut<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetMutFirst{TFirst, TSecond}()"/>
                public ref TFirst GetMutFirst<TFirst, TSecond>()
                {
                    return ref Entity.GetMutFirst<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetMutSecond{TFirst, TSecond}()"/>
                public ref TSecond GetMutSecond<TFirst, TSecond>()
                {
                    return ref Entity.GetMutSecond<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetMutSecond{TSecond}(ulong)"/>
                public ref TSecond GetMutSecond<TSecond>(ulong first)
                {
                    return ref Entity.GetMutSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Target(ulong, int)"/>
                public Entity Target(ulong relation, int index = 0)
                {
                    return Entity.Target(relation, index);
                }
            
                /// <inheritdoc cref="Entity.Target{T}(int)"/>
                public Entity Target<T>(int index = 0)
                {
                    return Entity.Target<T>(index);
                }
            
                /// <inheritdoc cref="Entity.TargetFor(ulong, ulong)"/>
                public Entity TargetFor(ulong relation, ulong id)
                {
                    return Entity.TargetFor(relation, id);
                }
            
                /// <inheritdoc cref="Entity.TargetFor{T}(ulong)"/>
                public Entity TargetFor<T>(ulong relation)
                {
                    return Entity.TargetFor<T>(relation);
                }
            
                /// <inheritdoc cref="Entity.TargetFor{TFirst, TSecond}(ulong)"/>
                public Entity TargetFor<TFirst, TSecond>(ulong relation)
                {
                    return Entity.TargetFor<TFirst, TSecond>(relation);
                }
            
                /// <inheritdoc cref="Entity.Depth(ulong)"/>
                public int Depth(ulong rel)
                {
                    return Entity.Depth(rel);
                }
            
                /// <inheritdoc cref="Entity.Depth{T}()"/>
                public int Depth<T>()
                {
                    return Entity.Depth<T>();
                }
            
                /// <inheritdoc cref="Entity.Depth{T}(T)"/>
                public int Depth<T>(T value) where T : Enum
                {
                    return Entity.Depth(value);
                }
            
                /// <inheritdoc cref="Entity.Parent()"/>
                public Entity Parent()
                {
                    return Entity.Parent();
                }
            
                /// <inheritdoc cref="Entity.Lookup(string, bool)"/>
                public Entity Lookup(string path, bool recursive = false)
                {
                    return Entity.Lookup(path, recursive);
                }
            
                /// <inheritdoc cref="Entity.TryLookup(string, out Core.Entity)"/>
                public bool TryLookup(string path, out Entity entity)
                {
                    return Entity.TryLookup(path, out entity);
                }
            
                /// <inheritdoc cref="Entity.TryLookup(string, bool, out Core.Entity)"/>
                public bool TryLookup(string path, bool recursive, out Entity entity)
                {
                    return Entity.TryLookup(path, recursive, out entity);
                }
            
                /// <inheritdoc cref="Entity.TryLookup(string, out ulong)"/>
                public bool TryLookup(string path, out ulong entity)
                {
                    return Entity.TryLookup(path, out entity);
                }
            
                /// <inheritdoc cref="Entity.TryLookup(string, bool, out ulong)"/>
                public bool TryLookup(string path, bool recursive, out ulong entity)
                {
                    return Entity.TryLookup(path, recursive, out entity);
                }
            
                /// <inheritdoc cref="Entity.Has(ulong)"/>
                public bool Has(ulong id)
                {
                    return Entity.Has(id);
                }
            
                /// <inheritdoc cref="Entity.Has(ulong, ulong)"/>
                public bool Has(ulong first, ulong second)
                {
                    return Entity.Has(first, second);
                }
            
                /// <inheritdoc cref="Entity.Has{T}()"/>
                public bool Has<T>()
                {
                    return Entity.Has<T>();
                }
            
                /// <inheritdoc cref="Entity.Has{T}(T)"/>
                public bool Has<T>(T value) where T : Enum
                {
                    return Entity.Has(value);
                }
            
                /// <inheritdoc cref="Entity.Has{TFirst}(ulong)"/>
                public bool Has<TFirst>(ulong second)
                {
                    return Entity.Has<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.Has{TFirst, TSecond}()"/>
                public bool Has<TFirst, TSecond>()
                {
                    return Entity.Has<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.Has{TFirst, TSecond}(TSecond)"/>
                public bool Has<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    return Entity.Has<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.Has{TFirst, TSecond}(TFirst)"/>
                public bool Has<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    return Entity.Has<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.HasSecond{TSecond}(ulong)"/>
                public bool HasSecond<TSecond>(ulong first)
                {
                    return Entity.HasSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Owns(ulong)"/>
                public bool Owns(ulong id)
                {
                    return Entity.Owns(id);
                }
            
                /// <inheritdoc cref="Entity.Owns(ulong, ulong)"/>
                public bool Owns(ulong first, ulong second)
                {
                    return Entity.Owns(first, second);
                }
            
                /// <inheritdoc cref="Entity.Owns{T}()"/>
                public bool Owns<T>()
                {
                    return Entity.Owns<T>();
                }
            
                /// <inheritdoc cref="Entity.Owns{T}(T)"/>
                public bool Owns<T>(T value) where T : Enum
                {
                    return Entity.Owns(value);
                }
            
                /// <inheritdoc cref="Entity.Owns{TFirst}(ulong)"/>
                public bool Owns<TFirst>(ulong second)
                {
                    return Entity.Owns<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.Owns{TFirst, TSecond}()"/>
                public bool Owns<TFirst, TSecond>()
                {
                    return Entity.Owns<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.Owns{TFirst, TSecond}(TSecond)"/>
                public bool Owns<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    return Entity.Owns<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.Owns{TFirst, TSecond}(TFirst)"/>
                public bool Owns<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    return Entity.Owns<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.OwnsSecond{TSecond}(ulong)"/>
                public bool OwnsSecond<TSecond>(ulong first)
                {
                    return Entity.OwnsSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Clone(bool, ulong)"/>
                public Entity Clone(bool cloneValue = true, ulong dstId = 0)
                {
                    return Entity.Clone(cloneValue, dstId);
                }
            
                /// <inheritdoc cref="Entity.Mut(ref Core.World)"/>
                public Entity Mut(ref World stage)
                {
                    return Entity.Mut(ref stage);
                }
            
                /// <inheritdoc cref="Entity.Mut(ref Iter)"/>
                public Entity Mut(ref Iter it)
                {
                    return Entity.Mut(ref it);
                }
            
                /// <inheritdoc cref="Entity.Mut(ref Core.Entity)"/>
                public Entity Mut(ref Entity entity)
                {
                    return Entity.Mut(ref entity);
                }
            
                /// <inheritdoc cref="Entity.Mut(Core.World)"/>
                public Entity Mut(World stage)
                {
                    return Entity.Mut(stage);
                }
            
                /// <inheritdoc cref="Entity.Mut(Iter)"/>
                public Entity Mut(Iter it)
                {
                    return Entity.Mut(it);
                }
            
                /// <inheritdoc cref="Entity.Mut(Core.Entity)"/>
                public Entity Mut(Entity entity)
                {
                    return Entity.Mut(entity);
                }
            
                /// <inheritdoc cref="Entity.ToJson(in EntityToJsonDesc)"/>
                public string ToJson(in EntityToJsonDesc desc)
                {
                    return Entity.ToJson(in desc);
                }
                
                /// <inheritdoc cref="Entity.ToJson()"/>
                public string ToJson()
                {
                    return Entity.ToJson();
                }
            
                /// <inheritdoc cref="Entity.DocName()"/>
                public string DocName()
                {
                    return Entity.DocName();
                }
            
                /// <inheritdoc cref="Entity.DocBrief()"/>
                public string DocBrief()
                {
                    return Entity.DocBrief();
                }
            
                /// <inheritdoc cref="Entity.DocDetail()"/>
                public string DocDetail()
                {
                    return Entity.DocDetail();
                }
            
                /// <inheritdoc cref="Entity.DocLink()"/>
                public string DocLink()
                {
                    return Entity.DocLink();
                }
            
                /// <inheritdoc cref="Entity.DocColor()"/>
                public string DocColor()
                {
                    return Entity.DocColor();
                }
            
                /// <inheritdoc cref="Entity.DocUuid()"/>
                public string DocUuid()
                {
                    return Entity.DocUuid();
                }
            
                /// <inheritdoc cref="Entity.AlertCount(ulong)"/>
                public int AlertCount(ulong alert = 0)
                {
                    return Entity.AlertCount(alert);
                }
            
                /// <inheritdoc cref="Entity.ToConstant{T}()"/>
                public T ToConstant<T>() where T : unmanaged, Enum
                {
                    return Entity.ToConstant<T>();
                }
            
                /// <inheritdoc cref="Entity.Emit(ulong)"/>
                public void Emit(ulong eventId)
                {
                    Entity.Emit(eventId);
                }
            
                /// <inheritdoc cref="Entity.Emit(Core.Entity)"/>
                public void Emit(Entity eventId)
                {
                    Entity.Emit(eventId);
                }
            
                /// <inheritdoc cref="Entity.Emit{T}()"/>
                public void Emit<T>()
                {
                    Entity.Emit<T>();
                }
            
                /// <inheritdoc cref="Entity.Emit{T}(T)"/>
                public void Emit<T>(T payload) where T : unmanaged
                {
                    Entity.Emit(payload);
                }
            
                /// <inheritdoc cref="Entity.Emit{T}(ref T)"/>
                public void Emit<T>(ref T payload)
                {
                    Entity.Emit(ref payload);
                }
            
                /// <inheritdoc cref="Entity.Enqueue(ulong)"/>
                public void Enqueue(ulong eventId)
                {
                    Entity.Enqueue(eventId);
                }
            
                /// <inheritdoc cref="Entity.Enqueue(Core.Entity)"/>
                public void Enqueue(Entity eventId)
                {
                    Entity.Enqueue(eventId);
                }
            
                /// <inheritdoc cref="Entity.Enqueue{T}()"/>
                public void Enqueue<T>()
                {
                    Entity.Enqueue<T>();
                }
            
                /// <inheritdoc cref="Entity.Enqueue{T}(T)"/>
                public void Enqueue<T>(T payload) where T : unmanaged
                {
                    Entity.Enqueue(payload);
                }
            
                /// <inheritdoc cref="Entity.Enqueue{T}(ref T)"/>
                public void Enqueue<T>(ref T payload)
                {
                    Entity.Enqueue(ref payload);
                }
            
                /// <inheritdoc cref="Entity.IsChildOf(ulong)"/>
                public bool IsChildOf(ulong entity)
                {
                    return Entity.IsChildOf(entity);
                }
            
                /// <inheritdoc cref="Entity.IsChildOf{T}()"/>
                public bool IsChildOf<T>()
                {
                    return Entity.IsChildOf<T>();
                }
            
                /// <inheritdoc cref="Entity.IsChildOf{T}(T)"/>
                public bool IsChildOf<T>(T value) where T : Enum
                {
                    return Entity.IsChildOf(value);
                }
            
                /// <inheritdoc cref="Entity.Add(ulong)"/>
                public ref {{typeName}} Add(ulong id)
                {
                    Entity.Add(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Add(ulong, ulong)"/>
                public ref {{typeName}} Add(ulong first, ulong second)
                {
                    Entity.Add(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Add{T}()"/>
                public ref {{typeName}} Add<T>()
                {
                    Entity.Add<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Add{TFirst}(ulong)"/>
                public ref {{typeName}} Add<TFirst>(ulong second)
                {
                    Entity.Add<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Add{T}(T)"/>
                public ref {{typeName}} Add<T>(T value) where T : Enum
                {
                    Entity.Add(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Add{TFirst, TSecond}()"/>
                public ref {{typeName}} Add<TFirst, TSecond>()
                {
                    Entity.Add<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Add{TFirst, TSecond}(TSecond)"/>
                public ref {{typeName}} Add<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Entity.Add<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Add{TFirst, TSecond}(TFirst)"/>
                public ref {{typeName}} Add<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Entity.Add<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddSecond{TSecond}(ulong)"/>
                public ref {{typeName}} AddSecond<TSecond>(ulong first)
                {
                    Entity.AddSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf(bool, ulong)"/>
                public ref {{typeName}} AddIf(bool cond, ulong id)
                {
                    Entity.AddIf(cond, id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf(bool, ulong, ulong)"/>
                public ref {{typeName}} AddIf(bool cond, ulong first, ulong second)
                {
                    Entity.AddIf(cond, first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf{T}(bool)"/>
                public ref {{typeName}} AddIf<T>(bool cond)
                {
                    Entity.AddIf<T>(cond);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf{T}(bool, T)"/>
                public ref {{typeName}} AddIf<T>(bool cond, T value) where T : Enum
                {
                    Entity.AddIf(cond, value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf{TFirst}(bool, ulong)"/>
                public ref {{typeName}} AddIf<TFirst>(bool cond, ulong second)
                {
                    Entity.AddIf<TFirst>(cond, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf{TFirst, TSecond}(bool)"/>
                public ref {{typeName}} AddIf<TFirst, TSecond>(bool cond)
                {
                    Entity.AddIf<TFirst, TSecond>(cond);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf{TFirst, TSecond}(bool, TSecond)"/>
                public ref {{typeName}} AddIf<TFirst, TSecond>(bool cond, TSecond second) where TSecond : Enum
                {
                    Entity.AddIf<TFirst, TSecond>(cond, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIf{TFirst, TSecond}(bool, TFirst)"/>
                public ref {{typeName}} AddIf<TFirst, TSecond>(bool cond, TFirst first) where TFirst : Enum
                {
                    Entity.AddIf<TFirst, TSecond>(cond, first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AddIfSecond{TSecond}(bool, ulong)"/>
                public ref {{typeName}} AddIfSecond<TSecond>(bool cond, ulong first)
                {
                    Entity.AddIfSecond<TSecond>(cond, first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.IsA(ulong)"/>
                public ref {{typeName}} IsA(ulong id)
                {
                    Entity.IsA(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.IsA{T}()"/>
                public ref {{typeName}} IsA<T>()
                {
                    Entity.IsA<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.IsA{T}(T)"/>
                public ref {{typeName}} IsA<T>(T value) where T : Enum
                {
                    Entity.IsA(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.ChildOf(ulong)"/>
                public ref {{typeName}} ChildOf(ulong second)
                {
                    Entity.ChildOf(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.ChildOf{T}()"/>
                public ref {{typeName}} ChildOf<T>()
                {
                    Entity.ChildOf<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.ChildOf{T}(T)"/>
                public ref {{typeName}} ChildOf<T>(T value) where T : Enum
                {
                    Entity.ChildOf(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.DependsOn(ulong)"/>
                public ref {{typeName}} DependsOn(ulong second)
                {
                    Entity.DependsOn(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.DependsOn{T}()"/>
                public ref {{typeName}} DependsOn<T>()
                {
                    Entity.DependsOn<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.DependsOn{T}(T)"/>
                public ref {{typeName}} DependsOn<T>(T value) where T : Enum
                {
                    Entity.DependsOn(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SlotOf(ulong)"/>
                public ref {{typeName}} SlotOf(ulong id)
                {
                    Entity.SlotOf(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SlotOf{T}()"/>
                public ref {{typeName}} SlotOf<T>()
                {
                    Entity.SlotOf<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SlotOf{T}(T)"/>
                public ref {{typeName}} SlotOf<T>(T value) where T : Enum
                {
                    Entity.SlotOf(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Slot()"/>
                public ref {{typeName}} Slot()
                {
                    Entity.Slot();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove(ulong)"/>
                public ref {{typeName}} Remove(ulong id)
                {
                    Entity.Remove(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove(ulong, ulong)"/>
                public ref {{typeName}} Remove(ulong first, ulong second)
                {
                    Entity.Remove(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove{T}()"/>
                public ref {{typeName}} Remove<T>()
                {
                    Entity.Remove<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove{T}(T)"/>
                public ref {{typeName}} Remove<T>(T value) where T : Enum
                {
                    Entity.Remove(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove{TFirst}(ulong)"/>
                public ref {{typeName}} Remove<TFirst>(ulong second)
                {
                    Entity.Remove<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove{TFirst, TSecond}()"/>
                public ref {{typeName}} Remove<TFirst, TSecond>()
                {
                    Entity.Remove<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove{TFirst, TSecond}(TSecond)"/>
                public ref {{typeName}} Remove<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Entity.Remove<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Remove{TFirst, TSecond}(TFirst)"/>
                public ref {{typeName}} Remove<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Entity.Remove<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.RemoveSecond{TSecond}(ulong)"/>
                public ref {{typeName}} RemoveSecond<TSecond>(ulong first)
                {
                    Entity.RemoveSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride(ulong)"/>
                public ref {{typeName}} AutoOverride(ulong id)
                {
                    Entity.AutoOverride(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride(ulong, ulong)"/>
                public ref {{typeName}} AutoOverride(ulong first, ulong second)
                {
                    Entity.AutoOverride(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride{T}()"/>
                public ref {{typeName}} AutoOverride<T>()
                {
                    Entity.AutoOverride<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride{T}(T)"/>
                public ref {{typeName}} AutoOverride<T>(T value) where T : Enum
                {
                    Entity.AutoOverride(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride{TFirst}(ulong)"/>
                public ref {{typeName}} AutoOverride<TFirst>(ulong second)
                {
                    Entity.AutoOverride<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride{TFirst, TSecond}()"/>
                public ref {{typeName}} AutoOverride<TFirst, TSecond>()
                {
                    Entity.AutoOverride<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride{TFirst, TSecond}(TSecond)"/>
                public ref {{typeName}} AutoOverride<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Entity.AutoOverride<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverride{TFirst, TSecond}(TFirst)"/>
                public ref {{typeName}} AutoOverride<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Entity.AutoOverride<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.AutoOverrideSecond{TSecond}(ulong)"/>
                public ref {{typeName}} AutoOverrideSecond<TSecond>(ulong first)
                {
                    Entity.AutoOverrideSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{T}(T)"/>
                public ref {{typeName}} SetAutoOverride<T>(T component)
                {
                    Entity.SetAutoOverride(component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{T}(ref T)"/>
                public ref {{typeName}} SetAutoOverride<T>(ref T component)
                {
                    Entity.SetAutoOverride(ref component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst}(ulong, TFirst)"/>
                public ref {{typeName}} SetAutoOverride<TFirst>(ulong second, TFirst component)
                {
                    Entity.SetAutoOverride(second, component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst}(ulong, ref TFirst)"/>
                public ref {{typeName}} SetAutoOverride<TFirst>(ulong second, ref TFirst component)
                {
                    Entity.SetAutoOverride(second, ref component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(TFirst)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(TFirst component)
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(ref TFirst)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(ref TFirst component)
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(ref component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(TSecond)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(TSecond component)
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(ref TSecond)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(ref TSecond component)
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(ref component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(TSecond, TFirst)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(TSecond second, TFirst component) where TSecond : Enum
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(second, component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(TSecond, ref TFirst)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(TSecond second, ref TFirst component) where TSecond : Enum
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(second, ref component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(TFirst, TSecond)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(TFirst first, TSecond component) where TFirst : Enum
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(first, component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverride{TFirst, TSecond}(TFirst, ref TSecond)"/>
                public ref {{typeName}} SetAutoOverride<TFirst, TSecond>(TFirst first, ref TSecond component) where TFirst : Enum
                {
                    Entity.SetAutoOverride<TFirst, TSecond>(first, ref component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverrideSecond{TSecond}(ulong, TSecond)"/>
                public ref {{typeName}} SetAutoOverrideSecond<TSecond>(ulong first, TSecond component)
                {
                    Entity.SetAutoOverrideSecond(first, component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAutoOverrideSecond{TSecond}(ulong, ref TSecond)"/>
                public ref {{typeName}} SetAutoOverrideSecond<TSecond>(ulong first, ref TSecond component)
                {
                    Entity.SetAutoOverrideSecond(first, ref component);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable()"/>
                public ref {{typeName}} Enable()
                {
                    Entity.Enable();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable(ulong)"/>
                public ref {{typeName}} Enable(ulong id)
                {
                    Entity.Enable(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable(ulong, ulong)"/>
                public ref {{typeName}} Enable(ulong first, ulong second)
                {
                    Entity.Enable(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable{T}()"/>
                public ref {{typeName}} Enable<T>()
                {
                    Entity.Enable<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable{T}(T)"/>
                public ref {{typeName}} Enable<T>(T value) where T : Enum
                {
                    Entity.Enable(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable{TFirst}(ulong)"/>
                public ref {{typeName}} Enable<TFirst>(ulong second)
                {
                    Entity.Enable<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable{TFirst, TSecond}()"/>
                public ref {{typeName}} Enable<TFirst, TSecond>()
                {
                    Entity.Enable<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable{TFirst, TSecond}(TSecond)"/>
                public ref {{typeName}} Enable<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Entity.Enable<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Enable{TFirst, TSecond}(TFirst)"/>
                public ref {{typeName}} Enable<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Entity.Enable<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.EnableSecond{TSecond}(ulong)"/>
                public ref {{typeName}} EnableSecond<TSecond>(ulong first)
                {
                    Entity.EnableSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable()"/>
                public ref {{typeName}} Disable()
                {
                    Entity.Disable();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable(ulong)"/>
                public ref {{typeName}} Disable(ulong id)
                {
                    Entity.Disable(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable(ulong, ulong)"/>
                public ref {{typeName}} Disable(ulong first, ulong second)
                {
                    Entity.Disable(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable{T}()"/>
                public ref {{typeName}} Disable<T>()
                {
                    Entity.Disable<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable{T}(T)"/>
                public ref {{typeName}} Disable<T>(T value) where T : Enum
                {
                    Entity.Disable(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable{TFirst}(ulong)"/>
                public ref {{typeName}} Disable<TFirst>(ulong second)
                {
                    Entity.Disable<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable{TFirst, TSecond}()"/>
                public ref {{typeName}} Disable<TFirst, TSecond>()
                {
                    Entity.Disable<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable{TFirst, TSecond}(TSecond)"/>
                public ref {{typeName}} Disable<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Entity.Disable<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Disable{TFirst, TSecond}(TFirst)"/>
                public ref {{typeName}} Disable<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Entity.Disable<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.DisableSecond{TSecond}(ulong)"/>
                public ref {{typeName}} DisableSecond<TSecond>(ulong first)
                {
                    Entity.DisableSecond<TSecond>(first);
                    return ref this;
                }
            
                ///
                public ref {{typeName}} SetUntyped(ulong id, int size, void* data)
                {
                    Entity.SetUntyped(id, size, data);
                    return ref this;
                }
            
                ///
                public ref {{typeName}} SetUntyped(ulong id, void* data)
                {
                    Entity.SetUntyped(id, data);
                    return ref this;
                }
            
                ///
                public ref {{typeName}} SetUntyped(ulong first, ulong second, int size, void* data)
                {
                    Entity.SetUntyped(first, second, size, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetPtr{T}(T*)"/>
                public ref {{typeName}} SetPtr<T>(T* data)
                {
                    Entity.SetPtr(data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetPtr{TFirst}(ulong, TFirst*)"/>
                public ref {{typeName}} SetPtr<TFirst>(ulong second, TFirst* data)
                {
                    Entity.SetPtr(second, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetPtr{TFirst, TSecond}(TSecond*)"/>
                public ref {{typeName}} SetPtr<TFirst, TSecond>(TSecond* data)
                {
                    Entity.SetPtr<TFirst, TSecond>(data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetPtr{TFirst, TSecond}(TFirst*)"/>
                public ref {{typeName}} SetPtr<TFirst, TSecond>(TFirst* data)
                {
                    Entity.SetPtr<TFirst, TSecond>(data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetPtr{TFirst, TSecond}(TSecond, TFirst*)"/>
                public ref {{typeName}} SetPtr<TFirst, TSecond>(TSecond second, TFirst* data) where TSecond : Enum
                {
                    Entity.SetPtr<TFirst, TSecond>(second, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetPtr{TFirst, TSecond}(TFirst, TSecond*)"/>
                public ref {{typeName}} SetPtr<TFirst, TSecond>(TFirst first, TSecond* data) where TFirst : Enum
                {
                    Entity.SetPtr<TFirst, TSecond>(first, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetPtrSecond{TSecond}(ulong, TSecond*)"/>
                public ref {{typeName}} SetPtrSecond<TSecond>(ulong first, TSecond* data)
                {
                    Entity.SetPtrSecond(first, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{T}(T)"/>
                public ref {{typeName}} Set<T>(T data)
                {
                    Entity.Set(data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst}(ulong, TFirst)"/>
                public ref {{typeName}} Set<TFirst>(ulong second, TFirst data)
                {
                    Entity.Set(second, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(TSecond)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(TSecond data)
                {
                    Entity.Set<TFirst, TSecond>(data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(TFirst)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(TFirst data)
                {
                    Entity.Set<TFirst, TSecond>(data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(TSecond, TFirst)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(TSecond second, TFirst data) where TSecond : Enum
                {
                    Entity.Set<TFirst, TSecond>(second, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(TFirst, TSecond)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(TFirst first, TSecond data) where TFirst : Enum
                {
                    Entity.Set<TFirst, TSecond>(first, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetSecond{TSecond}(ulong, TSecond)"/>
                public ref {{typeName}} SetSecond<TSecond>(ulong first, TSecond data)
                {
                    Entity.SetSecond(first, data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{T}(ref T)"/>
                public ref {{typeName}} Set<T>(ref T data)
                {
                    Entity.Set(ref data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst}(ulong, ref TFirst)"/>
                public ref {{typeName}} Set<TFirst>(ulong second, ref TFirst data)
                {
                    Entity.Set(second, ref data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(ref TSecond)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(ref TSecond data)
                {
                    Entity.Set<TFirst, TSecond>(ref data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(ref TFirst)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(ref TFirst data)
                {
                    Entity.Set<TFirst, TSecond>(ref data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(TSecond, ref TFirst)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(TSecond second, ref TFirst data) where TSecond : Enum
                {
                    Entity.Set<TFirst, TSecond>(second, ref data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Set{TFirst, TSecond}(TFirst, ref TSecond)"/>
                public ref {{typeName}} Set<TFirst, TSecond>(TFirst first, ref TSecond data) where TFirst : Enum
                {
                    Entity.Set<TFirst, TSecond>(first, ref data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetSecond{TSecond}(ulong, ref TSecond)"/>
                public ref {{typeName}} SetSecond<TSecond>(ulong first, ref TSecond data)
                {
                    Entity.SetSecond(first, ref data);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.With(Action)"/>
                public ref {{typeName}} With(Action callback)
                {
                    Entity.With(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.With(ulong, Action)"/>
                public ref {{typeName}} With(ulong first, Action callback)
                {
                    Entity.With(first, callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.With{TFirst}(Action)"/>
                public ref {{typeName}} With<TFirst>(Action callback)
                {
                    Entity.With<TFirst>(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.With(Ecs.WorldCallback)"/>
                public ref {{typeName}} With(Ecs.WorldCallback callback)
                {
                    Entity.With(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.With(ulong, Ecs.WorldCallback)"/>
                public ref {{typeName}} With(ulong first, Ecs.WorldCallback callback)
                {
                    Entity.With(first, callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.With{TFirst}(Ecs.WorldCallback)"/>
                public ref {{typeName}} With<TFirst>(Ecs.WorldCallback callback)
                {
                    Entity.With<TFirst>(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Scope(Action)"/>
                public ref {{typeName}} Scope(Action callback)
                {
                    Entity.Scope(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Scope(Ecs.WorldCallback)"/>
                public ref {{typeName}} Scope(Ecs.WorldCallback callback)
                {
                    Entity.Scope(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetName(string)"/>
                public ref {{typeName}} SetName(string name)
                {
                    Entity.SetName(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetAlias(string)"/>
                public ref {{typeName}} SetAlias(string alias)
                {
                    Entity.SetAlias(alias);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetDocName(string)"/>
                public ref {{typeName}} SetDocName(string name)
                {
                    Entity.SetDocName(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetDocBrief(string)"/>
                public ref {{typeName}} SetDocBrief(string brief)
                {
                    Entity.SetDocBrief(brief);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetDocDetail(string)"/>
                public ref {{typeName}} SetDocDetail(string detail)
                {
                    Entity.SetDocDetail(detail);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetDocLink(string)"/>
                public ref {{typeName}} SetDocLink(string link)
                {
                    Entity.SetDocLink(link);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetDocColor(string)"/>
                public ref {{typeName}} SetDocColor(string color)
                {
                    Entity.SetDocColor(color);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetDocUuid(string)"/>
                public ref {{typeName}} SetDocUuid(string uuid)
                {
                    Entity.SetDocUuid(uuid);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Unit(string, ulong, ulong, ulong, int, int)"/>
                public ref {{typeName}} Unit(
                    string symbol,
                    ulong prefix = 0,
                    ulong @base = 0,
                    ulong over = 0,
                    int factor = 0,
                    int power = 0)
                {
                    Entity.Unit(symbol, prefix, @base, over, factor, power);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Unit(ulong, ulong, ulong, int, int)"/>
                public ref {{typeName}} Unit(
                    ulong prefix = 0,
                    ulong @base = 0,
                    ulong over = 0,
                    int factor = 0,
                    int power = 0)
                {
                    Entity.Unit(prefix, @base, over, factor, power);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.UnitPrefix(string, int, int)"/>
                public ref {{typeName}} UnitPrefix(string symbol, int factor = 0, int power = 0)
                {
                    Entity.UnitPrefix(symbol, factor, power);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Quantity(ulong)"/>
                public ref {{typeName}} Quantity(ulong quantity)
                {
                    Entity.Quantity(quantity);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Quantity{T}()"/>
                public ref {{typeName}} Quantity<T>()
                {
                    Entity.Quantity<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Quantity()"/>
                public ref {{typeName}} Quantity()
                {
                    Entity.Quantity();
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJson(ulong, string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJson(ulong e, string json, ecs_from_json_desc_t* desc = null)
                {
                    Entity.SetJson(e, json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJson(ulong, ulong, string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJson(ulong first, ulong second, string json, ecs_from_json_desc_t* desc = null)
                {
                    Entity.SetJson(first, second, json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJson{T}(string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJson<T>(string json, ecs_from_json_desc_t* desc = null)
                {
                    Entity.SetJson<T>(json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJson{TFirst}(ulong, string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJson<TFirst>(ulong second, string json, ecs_from_json_desc_t* desc = null)
                {
                    Entity.SetJson<TFirst>(second, json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJson{TFirst, TSecond}(string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJson<TFirst, TSecond>(string json, ecs_from_json_desc_t* desc = null)
                {
                    Entity.SetJson<TFirst, TSecond>(json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJson{TFirst, TSecond}(TSecond, string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJson<TFirst, TSecond>(TSecond second, string json, ecs_from_json_desc_t* desc = null) where TSecond : Enum
                {
                    Entity.SetJson<TFirst, TSecond>(second, json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJson{TFirst, TSecond}(TFirst, string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJson<TFirst, TSecond>(TFirst first, string json, ecs_from_json_desc_t* desc = null) where TFirst : Enum
                {
                    Entity.SetJson<TFirst, TSecond>(first, json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.SetJsonSecond{TSecond}(ulong, string, ecs_from_json_desc_t*)"/>
                public ref {{typeName}} SetJsonSecond<TSecond>(ulong first, string json, ecs_from_json_desc_t* desc = null)
                {
                    Entity.SetJsonSecond<TSecond>(first, json, desc);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Observe(ulong, Action)"/>
                public ref {{typeName}} Observe(ulong eventId, Action callback)
                {
                    Entity.Observe(eventId, callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Observe(ulong, Ecs.ObserveEntityCallback)"/>
                public ref {{typeName}} Observe(ulong eventId, Ecs.ObserveEntityCallback callback)
                {
                    Entity.Observe(eventId, callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Observe{T}(Action)"/>
                public ref {{typeName}} Observe<T>(Action callback)
                {
                    Entity.Observe<T>(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Observe{T}(Ecs.ObserveEntityCallback)"/>
                public ref {{typeName}} Observe<T>(Ecs.ObserveEntityCallback callback)
                {
                    Entity.Observe<T>(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Observe{T}(Ecs.ObserveRefCallback{T})"/>
                public ref {{typeName}} Observe<T>(Ecs.ObserveRefCallback<T> callback)
                {
                    Entity.Observe(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.Observe{T}(Ecs.ObserveEntityRefCallback{T})"/>
                public ref {{typeName}} Observe<T>(Ecs.ObserveEntityRefCallback<T> callback)
                {
                    Entity.Observe(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Entity.EnsurePtr(ulong)"/>
                public void* EnsurePtr(ulong id)
                {
                    return Entity.EnsurePtr(id);
                }
            
                /// <inheritdoc cref="Entity.EnsurePtr(ulong, ulong)"/>
                public void* EnsurePtr(ulong first, ulong second)
                {
                    return Entity.EnsurePtr(first, second);
                }
            
                /// <inheritdoc cref="Entity.EnsurePtr{T}()"/>
                public T* EnsurePtr<T>() where T : unmanaged
                {
                    return Entity.EnsurePtr<T>();
                }
            
                /// <inheritdoc cref="Entity.EnsurePtr{TFirst}(ulong)"/>
                public TFirst* EnsurePtr<TFirst>(ulong second) where TFirst : unmanaged
                {
                    return Entity.EnsurePtr<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.EnsurePtr{TFirst, TSecond}(TSecond)"/>
                public TFirst* EnsurePtr<TFirst, TSecond>(TSecond second) where TFirst : unmanaged
                    where TSecond : Enum
                {
                    return Entity.EnsurePtr<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.EnsurePtr{TFirst, TSecond}(TFirst)"/>
                public TSecond* EnsurePtr<TFirst, TSecond>(TFirst first) where TFirst : Enum
                    where TSecond : unmanaged
                {
                    return Entity.EnsurePtr<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.EnsureFirstPtr{TFirst, TSecond}()"/>
                public TFirst* EnsureFirstPtr<TFirst, TSecond>() where TFirst : unmanaged
                {
                    return Entity.EnsureFirstPtr<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.EnsureSecondPtr{TFirst, TSecond}()"/>
                public TSecond* EnsureSecondPtr<TFirst, TSecond>() where TSecond : unmanaged
                {
                    return Entity.EnsureSecondPtr<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.EnsureSecondPtr{TSecond}(ulong)"/>
                public TSecond* EnsureSecondPtr<TSecond>(ulong first) where TSecond : unmanaged
                {
                    return Entity.EnsureSecondPtr<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Ensure{T}()"/>
                public ref T Ensure<T>()
                {
                    return ref Entity.Ensure<T>();
                }
            
                /// <inheritdoc cref="Entity.Ensure{TFirst}(ulong)"/>
                public ref TFirst Ensure<TFirst>(ulong second)
                {
                    return ref Entity.Ensure<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.Ensure{TFirst, TSecond}(TSecond)"/>
                public ref TFirst Ensure<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    return ref Entity.Ensure<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.Ensure{TFirst, TSecond}(TFirst)"/>
                public ref TSecond Ensure<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    return ref Entity.Ensure<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.EnsureFirst{TFirst, TSecond}()"/>
                public ref TFirst EnsureFirst<TFirst, TSecond>()
                {
                    return ref Entity.EnsureFirst<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.EnsureSecond{TFirst, TSecond}()"/>
                public ref TSecond EnsureSecond<TFirst, TSecond>()
                {
                    return ref Entity.EnsureSecond<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.EnsureSecond{TSecond}(ulong)"/>
                public ref TSecond EnsureSecond<TSecond>(ulong first)
                {
                    return ref Entity.EnsureSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Modified(ulong)"/>
                public void Modified(ulong id)
                {
                    Entity.Modified(id);
                }
            
                /// <inheritdoc cref="Entity.Modified(ulong, ulong)"/>
                public void Modified(ulong first, ulong second)
                {
                    Entity.Modified(first, second);
                }
            
                /// <inheritdoc cref="Entity.Modified{T}()"/>
                public void Modified<T>()
                {
                    Entity.Modified<T>();
                }
            
                /// <inheritdoc cref="Entity.Modified{T}(T)"/>
                public void Modified<T>(T value) where T : Enum
                {
                    Entity.Modified(value);
                }
            
                /// <inheritdoc cref="Entity.Modified{TFirst}(ulong)"/>
                public void Modified<TFirst>(ulong second)
                {
                    Entity.Modified<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.Modified{TFirst, TSecond}()"/>
                public void Modified<TFirst, TSecond>()
                {
                    Entity.Modified<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.Modified{TFirst, TSecond}(TSecond)"/>
                public void Modified<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Entity.Modified<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.Modified{TFirst, TSecond}(TFirst)"/>
                public void Modified<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Entity.Modified<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.ModifiedSecond{TSecond}(ulong)"/>
                public void ModifiedSecond<TSecond>(ulong first)
                {
                    Entity.ModifiedSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetRef{T}()"/>
                public Ref<T> GetRef<T>()
                {
                    return Entity.GetRef<T>();
                }
            
                /// <inheritdoc cref="Entity.GetRef{TFirst}(ulong)"/>
                public Ref<TFirst> GetRef<TFirst>(ulong second)
                {
                    return Entity.GetRef<TFirst>(second);
                }
            
                /// <inheritdoc cref="Entity.GetRef{TFirst, TSecond}(TSecond)"/>
                public Ref<TFirst> GetRef<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    return Entity.GetRef<TFirst, TSecond>(second);
                }
            
                /// <inheritdoc cref="Entity.GetRef{TFirst, TSecond}(TFirst)"/>
                public Ref<TSecond> GetRef<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    return Entity.GetRef<TFirst, TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.GetRefFirst{TFirst, TSecond}()"/>
                public Ref<TFirst> GetRefFirst<TFirst, TSecond>()
                {
                    return Entity.GetRefFirst<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetRefSecond{TFirst, TSecond}()"/>
                public Ref<TSecond> GetRefSecond<TFirst, TSecond>()
                {
                    return Entity.GetRefSecond<TFirst, TSecond>();
                }
            
                /// <inheritdoc cref="Entity.GetRefSecond{TSecond}(ulong)"/>
                public Ref<TSecond> GetRefSecond<TSecond>(ulong first)
                {
                    return Entity.GetRefSecond<TSecond>(first);
                }
            
                /// <inheritdoc cref="Entity.Clear()"/>
                public void Clear()
                {
                    Entity.Clear();
                }
            
                /// <inheritdoc cref="Entity.Destruct()"/>
                public void Destruct()
                {
                    Entity.Destruct();
                }
            
                /// <inheritdoc cref="Entity.FromJson(string)"/>
                public string FromJson(string json)
                {
                    return Entity.FromJson(json);
                }
            }
            """;
    }
}
