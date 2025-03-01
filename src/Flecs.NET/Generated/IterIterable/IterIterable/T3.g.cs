// /_/src/Flecs.NET/Generated/IterIterable/IterIterable/T3.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/IterIterable.cs
#nullable enable

using System;
using System.Runtime.CompilerServices;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <inheritdoc cref="IterIterable"/>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
public unsafe partial struct IterIterable<T0, T1, T2> : IEquatable<IterIterable<T0, T1, T2>>
{
    private IterIterable _iterIterable;
    
    internal IterIterable(IterIterable iterIterable)
    {
        _iterIterable = iterIterable;
    }

    /// <inheritdoc cref="IterIterable(ecs_iter_t, IterableType)"/>
    public IterIterable(ecs_iter_t iter, IterableType iterableType)
    {
        _iterIterable = new IterIterable(iter, iterableType);
    }

    /// <inheritdoc cref="IterIterable.SetVar(int, ulong)"/>
    public ref IterIterable<T0, T1, T2> SetVar(int varId, ulong value)
    {
        _iterIterable.SetVar(varId, value);
        return ref this;
    }

    /// <inheritdoc cref="IterIterable.SetVar(string, ulong)"/>
    public ref IterIterable<T0, T1, T2> SetVar(string name, ulong value)
    {
        _iterIterable.SetVar(name, value);
        return ref this;
    }

    /// <inheritdoc cref="IterIterable.SetVar(string, ecs_table_t*)"/>
    public ref IterIterable<T0, T1, T2> SetVar(string name, ecs_table_t* value)
    {
        _iterIterable.SetVar(name, value);
        return ref this;
    }

    /// <inheritdoc cref="IterIterable.SetVar(string, ecs_table_range_t)"/>
    public ref IterIterable<T0, T1, T2> SetVar(string name, ecs_table_range_t value)
    {
        _iterIterable.SetVar(name, value);
        return ref this;
    }

    /// <inheritdoc cref="IterIterable.SetVar(string, Table)"/>
    public ref IterIterable<T0, T1, T2> SetVar(string name, Table value)
    {
        _iterIterable.SetVar(name, value);
        return ref this;
    }

    /// <inheritdoc cref="IterIterable.ToJson(in IterToJsonDesc)"/>
    public string ToJson(in IterToJsonDesc desc)
    {
        return _iterIterable.ToJson(in desc);
    }
    
    /// <inheritdoc cref="IterIterable.ToJson()"/>
    public string ToJson()
    {
        return _iterIterable.ToJson();
    }

    /// <inheritdoc cref="IterIterable.Count()"/>
    public int Count()
    {
        return _iterIterable.Count();
    }

    /// <inheritdoc cref="IterIterable.IsTrue()"/>
    public bool IsTrue()
    {
        return _iterIterable.IsTrue();
    }

    /// <inheritdoc cref="IterIterable.First()"/>
    public Entity First()
    {
        return _iterIterable.First();
    }

    /// <inheritdoc cref="IterIterable.SetGroup(ulong)"/>
    public ref IterIterable<T0, T1, T2> SetGroup(ulong groupId)
    {
        _iterIterable.SetGroup(groupId);
        return ref this;
    }

    /// <inheritdoc cref="IterIterable.SetGroup{T}()"/>
    public ref IterIterable<T0, T1, T2> SetGroup<T>()
    {
        _iterIterable.SetGroup<T>();
        return ref this;
    }

    /// <inheritdoc cref="IterIterable.Equals(IterIterable)"/>
    public bool Equals(IterIterable<T0, T1, T2> other)
    {
        return _iterIterable.Equals(other._iterIterable);
    }

    /// <inheritdoc cref="IterIterable.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is IterIterable<T0, T1, T2> other && Equals(other);
    }

    /// <inheritdoc cref="IterIterable.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _iterIterable.GetHashCode();
    }

    /// <inheritdoc cref="IterIterable.op_Equality"/>
    public static bool operator ==(IterIterable<T0, T1, T2> left, IterIterable<T0, T1, T2> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="IterIterable.op_Inequality"/>
    public static bool operator !=(IterIterable<T0, T1, T2> left, IterIterable<T0, T1, T2> right)
    {
        return !(left == right);
    }
}

// IIterableBase Interface
public unsafe partial struct IterIterable<T0, T1, T2> : IIterableBase
{
    /// <inheritdoc cref="IterIterable.World"/>
    public ref ecs_world_t* World => ref _iterIterable.World;
    
    /// <inheritdoc cref="IterIterable.GetIter(ecs_world_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ecs_iter_t GetIter(ecs_world_t* world = null)
    {
        return _iterIterable.GetIter(world);
    }
    
    /// <inheritdoc cref="IterIterable.GetNext(ecs_iter_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool GetNext(ecs_iter_t* it)
    {
        return _iterIterable.GetNext(it);
    }
}

// IIterable<T0, T1, T2> Interface
public unsafe partial struct IterIterable<T0, T1, T2> : IIterable<T0, T1, T2>
{
    /// <inheritdoc cref="IterIterable.Page(int, int)"/>
    public PageIterable<T0, T1, T2> Page(int offset, int limit)
    {
        return new PageIterable<T0, T1, T2>(_iterIterable.Page(offset, limit));
    }
    
    /// <inheritdoc cref="IterIterable.Worker(int, int)"/>
    public WorkerIterable<T0, T1, T2> Worker(int index, int count)
    {
        return new WorkerIterable<T0, T1, T2>(_iterIterable.Worker(index, count));
    }

    /// <inheritdoc cref="IterIterable.Iter(Flecs.NET.Core.World)"/>
    public IterIterable<T0, T1, T2> Iter(World world = default)
    {
        return new(_iterIterable.Iter(world));
    }
    
    /// <inheritdoc cref="IterIterable.Iter(Flecs.NET.Core.Iter)"/>
    public IterIterable<T0, T1, T2> Iter(Iter it)
    {
        return new(_iterIterable.Iter(it));
    }
    
    /// <inheritdoc cref="IterIterable.Iter(Flecs.NET.Core.Entity)"/>
    public IterIterable<T0, T1, T2> Iter(Entity entity)
    {
        return new(_iterIterable.Iter(entity));
    }
    
    /// <inheritdoc cref="IterIterable.SetVar(int, ulong)"/>
    IterIterable<T0, T1, T2> IIterable<T0, T1, T2>.SetVar(int varId, ulong value)
    {
        return new(_iterIterable.SetVar(varId, value));
    }
    
    /// <inheritdoc cref="IterIterable.SetVar(string, ulong)"/>
    IterIterable<T0, T1, T2> IIterable<T0, T1, T2>.SetVar(string name, ulong value)
    {
        return new(_iterIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="IterIterable.SetVar(string, ecs_table_t*)"/>
    IterIterable<T0, T1, T2> IIterable<T0, T1, T2>.SetVar(string name, ecs_table_t* value)
    {
        return new(_iterIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="IterIterable.SetVar(string, ecs_table_range_t)"/>
    IterIterable<T0, T1, T2> IIterable<T0, T1, T2>.SetVar(string name, ecs_table_range_t value)
    {
        return new(_iterIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="IterIterable.SetVar(string, Table)"/>
    IterIterable<T0, T1, T2> IIterable<T0, T1, T2>.SetVar(string name, Table value)
    {
        return new(_iterIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="IterIterable.SetGroup(ulong)"/>
    IterIterable<T0, T1, T2> IIterable<T0, T1, T2>.SetGroup(ulong groupId)
    {
        return new(_iterIterable.SetGroup(groupId));
    }
    
    /// <inheritdoc cref="IterIterable.SetGroup{T}()"/>
    IterIterable<T0, T1, T2> IIterable<T0, T1, T2>.SetGroup<T>()
    {
        return new(_iterIterable.SetGroup<T>()); 
    }
}