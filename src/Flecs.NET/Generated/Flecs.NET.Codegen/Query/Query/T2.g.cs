﻿// Query/T2.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Query.cs
#nullable enable

using System;
using System.Runtime.CompilerServices;

using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A type-safe wrapper around <see cref="Query"/> that takes 2 type arguments.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
public unsafe partial struct Query<T0, T1> : IDisposable, IEquatable<Query<T0, T1>>
{
    private Query _query;

    /// <inheritdoc cref="Query.Handle"/>
    public ref ecs_query_t* Handle => ref _query.Handle;

    /// <inheritdoc cref="Query(ecs_query_t*)"/>
    public Query(ecs_query_t* query)
    {
        TypeHelper<T0, T1>.AssertNoTags();
        _query = new Query(query);
    }

    /// <inheritdoc cref="Query(ecs_world_t*, ulong)"/>
    public Query(ecs_world_t* world, ulong entity)
    {
        TypeHelper<T0, T1>.AssertNoTags();
        _query = new Query(world, entity);
    }

    /// <inheritdoc cref="Query(Core.Entity)"/>
    public Query(Entity entity)
    {
        TypeHelper<T0, T1>.AssertNoTags();
        _query = new Query(entity);
    }

    /// <inheritdoc cref="Query.Dispose()"/>
    public void Dispose()
    {
        _query.Dispose();
    }

    /// <inheritdoc cref="Query.Destruct()"/>
    public void Destruct()
    {
        _query.Destruct();
    }

    /// <inheritdoc cref="Query.Entity()"/>
    public Entity Entity()
    {
        return _query.Entity();
    }

    /// <inheritdoc cref="Query.CPtr()"/>
    public ecs_query_t* CPtr()
    {
        return _query.CPtr();
    }

    /// <inheritdoc cref="Query.Changed()"/>
    public bool Changed()
    {
        return _query.Changed();
    }

    /// <inheritdoc cref="Query.GroupInfo(ulong)"/>
    public ecs_query_group_info_t* GroupInfo(ulong groupId)
    {
        return _query.GroupInfo(groupId);
    }

    /// <inheritdoc cref="Query.GroupCtx(ulong)"/>
    public void* GroupCtx(ulong groupId)
    {
        return _query.GroupCtx(groupId);
    }

    /// <inheritdoc cref="Query.EachTerm(Ecs.TermCallback)"/>
    public void EachTerm(Ecs.TermCallback callback)
    {
        _query.EachTerm(callback);
    }

    /// <inheritdoc cref="Query.Term(int)"/>
    public Term Term(int index)
    {
        return _query.Term(index);
    }

    /// <inheritdoc cref="Query.TermCount()"/>
    public int TermCount()
    {
        return _query.TermCount();
    }

    /// <inheritdoc cref="Query.FieldCount()"/>
    public int FieldCount()
    {
        return _query.FieldCount();
    }

    /// <inheritdoc cref="Query.FindVar(string)"/>
    public int FindVar(string name)
    {
        return _query.FindVar(name);
    }

    /// <inheritdoc cref="Query.Str()"/>
    public string Str()
    {
        return _query.Str();
    }

    /// <inheritdoc cref="Query.Plan()"/>
    public string Plan()
    {
        return _query.Plan();
    }

    /// <inheritdoc cref="Query.To(Query)"/>
    public static ecs_query_t* To(Query<T0, T1> query)
    {
        return query.Handle;
    }

    /// <inheritdoc cref="Query.ToBoolean(Query)"/>
    public static bool ToBoolean(Query<T0, T1> query)
    {
        return query.Handle != null;
    }

    /// <inheritdoc cref="Query.To(Query)"/>
    public static implicit operator ecs_query_t*(Query<T0, T1> query)
    {
        return To(query);
    }

    /// <inheritdoc cref="Query.ToBoolean(Query)"/>
    public static implicit operator bool(Query<T0, T1> query)
    {
        return ToBoolean(query);
    }

    /// <inheritdoc cref="Query.Equals(Query)"/>
    public bool Equals(Query<T0, T1> other)
    {
        return _query.Equals(other._query);
    }

    /// <inheritdoc cref="Query.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is Query<T0, T1> other && Equals(other);
    }

    /// <inheritdoc cref="Query.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _query.GetHashCode();
    }

    /// <inheritdoc cref="Query.op_Equality"/>
    public static bool operator ==(Query<T0, T1> left, Query<T0, T1> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="Query.op_Inequality"/>
    public static bool operator !=(Query<T0, T1> left, Query<T0, T1> right)
    {
        return !(left == right);
    }
}

// Flecs.NET Extensions
public unsafe partial struct Query<T0, T1>
{
    /// <inheritdoc cref="Query.World()"/>
    public World World()
    {
        return _query.World();
    }

    /// <inheritdoc cref="Query.RealWorld()"/>
    public World RealWorld()
    {
        return _query.RealWorld();
    }
}

// IIterableBase Interface
public unsafe partial struct Query<T0, T1> : IIterableBase
{
    /// <inheritdoc cref="Query.GetIter(ecs_world_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ecs_iter_t GetIter(ecs_world_t* world = null)
    {
        return _query.GetIter();
    }
    
    /// <inheritdoc cref="Query.GetNext(ecs_iter_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool GetNext(ecs_iter_t* it)
    {
        return _query.GetNext(it);
    }
}

// IIterable<T0, T1> Interface
public unsafe partial struct Query<T0, T1> : IIterable<T0, T1>
{
    /// <inheritdoc cref="Query.Page(int, int)"/>
    public PageIterable<T0, T1> Page(int offset, int limit)
    {
        return new PageIterable<T0, T1>(_query.Page(offset, limit));
    }
    
    /// <inheritdoc cref="Query.Worker(int, int)"/>
    public WorkerIterable<T0, T1> Worker(int index, int count)
    {
        return new WorkerIterable<T0, T1>(_query.Worker(index, count));
    }

    /// <inheritdoc cref="Query.Iter(Flecs.NET.Core.World)"/>
    public IterIterable<T0, T1> Iter(World world = default)
    {
        return new IterIterable<T0, T1>(_query.Iter(world));
    }
    
    /// <inheritdoc cref="Query.Iter(Flecs.NET.Core.Iter)"/>
    public IterIterable<T0, T1> Iter(Iter it)
    {
        return new IterIterable<T0, T1>(_query.Iter(it));
    }
    
    /// <inheritdoc cref="Query.Iter(Flecs.NET.Core.Entity)"/>
    public IterIterable<T0, T1> Iter(Entity entity)
    {
        return new IterIterable<T0, T1>(_query.Iter(entity));
    }
    
    /// <inheritdoc cref="Query.Count()"/>
    public int Count()
    {
        return _query.Count();
    }
    
    /// <inheritdoc cref="Query.IsTrue()"/>
    public bool IsTrue()
    {
        return _query.IsTrue();
    }
    
    /// <inheritdoc cref="Query.First()"/>
    public Entity First()
    {
        return _query.First();
    }
    
    /// <inheritdoc cref="Query.SetVar(int, ulong)"/>
    public IterIterable<T0, T1> SetVar(int varId, ulong value)
    {
        return new IterIterable<T0, T1>(_query.SetVar(varId, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, ulong)"/>
    public IterIterable<T0, T1> SetVar(string name, ulong value)
    {
        return new IterIterable<T0, T1>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, ecs_table_t*)"/>
    public IterIterable<T0, T1> SetVar(string name, ecs_table_t* value)
    {
        return new IterIterable<T0, T1>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, ecs_table_range_t)"/>
    public IterIterable<T0, T1> SetVar(string name, ecs_table_range_t value)
    {
        return new IterIterable<T0, T1>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, Table)"/>
    public IterIterable<T0, T1> SetVar(string name, Table value)
    {
        return new IterIterable<T0, T1>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetGroup(ulong)"/>
    public IterIterable<T0, T1> SetGroup(ulong groupId)
    {
        return new IterIterable<T0, T1>(_query.SetGroup(groupId));
    }
    
    /// <inheritdoc cref="Query.SetGroup{T}()"/>
    public IterIterable<T0, T1> SetGroup<T>()
    {
        return new IterIterable<T0, T1>(_query.SetGroup<T>());
    }
}