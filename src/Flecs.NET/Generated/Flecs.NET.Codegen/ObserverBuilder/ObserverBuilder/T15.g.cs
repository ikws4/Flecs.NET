﻿// ObserverBuilder/T15.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/ObserverBuilder.cs
#nullable enable

using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A type-safe wrapper around <see cref="ObserverBuilder"/> that takes 15 type arguments.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam> <typeparam name="T13">The T13 component type.</typeparam> <typeparam name="T14">The T14 component type.</typeparam>
public unsafe partial struct ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IDisposable, IEquatable<ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, IQueryBuilder<ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
{
    private ObserverBuilder _observerBuilder;

    /// <inheritdoc cref="ObserverBuilder.World"/>
    public ref ecs_world_t* World => ref _observerBuilder.World;

    /// <inheritdoc cref="ObserverBuilder.Desc"/>
    public ref ecs_observer_desc_t Desc => ref _observerBuilder.Desc;

    /// <inheritdoc cref="ObserverBuilder.QueryBuilder"/>
    public ref QueryBuilder QueryBuilder => ref _observerBuilder.QueryBuilder;

    /// <summary>
    ///     Creates an observer builder with the provided observer builder.
    /// </summary>
    /// <param name="observerBuilder">The observer builder.</param>
    public ObserverBuilder(ObserverBuilder observerBuilder)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AssertNoTags();
        _observerBuilder = observerBuilder;
    }

    /// <inheritdoc cref="ObserverBuilder(ecs_world_t*)"/>
    public ObserverBuilder(ecs_world_t* world)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AssertNoTags();
        _observerBuilder = new ObserverBuilder(world).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>().With<T11>().With<T12>().With<T13>().With<T14>();
    }

    /// <inheritdoc cref="ObserverBuilder(ecs_world_t*, string)"/>
    public ObserverBuilder(ecs_world_t* world, string name)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AssertNoTags();
        _observerBuilder = new ObserverBuilder(world, name).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>().With<T11>().With<T12>().With<T13>().With<T14>();
    }

    /// <inheritdoc cref="ObserverBuilder.Dispose()"/>
    public void Dispose()
    {
        _observerBuilder.Dispose();
    }

    /// <inheritdoc cref="ObserverBuilder.Event(ulong)"/>
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Event(ulong @event)
    {
        _observerBuilder.Event(@event);
        return ref this;
    }

    /// <inheritdoc cref="ObserverBuilder.Event{T}()"/>
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Event<T>()
    {
        _observerBuilder.Event<T>();
        return ref this;
    }

    /// <inheritdoc cref="ObserverBuilder.YieldExisting(bool)"/>
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> YieldExisting(bool value = true)
    {
        _observerBuilder.YieldExisting(value);
        return ref this;
    }

    ///
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Ctx(void* data)
    {
        _observerBuilder.Ctx(data);
        return ref this;
    }
    
    /// <inheritdoc cref="ObserverBuilder.Run(System.Action)"/>
    public Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Run(Action callback)
    {
        return new Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(_observerBuilder.Run(callback));
    }
    
    /// <inheritdoc cref="ObserverBuilder.Run(System.Action)"/>
    public Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Run(delegate*<void> callback)
    {
        return new Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(_observerBuilder.Run(callback));
    }

    /// <inheritdoc cref="ObserverBuilder.Run(Ecs.RunDelegateCallback)"/>
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Run(Ecs.RunDelegateCallback callback)
    {
        _observerBuilder.Run(callback);
        return ref this;
    }

    /// <inheritdoc cref="ObserverBuilder.Run(Ecs.RunDelegateCallback)"/>
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Run(delegate*<Iter, Action<Iter>, void> callback)
    {
        _observerBuilder.Run(callback);
        return ref this;
    }

    /// <inheritdoc cref="ObserverBuilder.Run(Ecs.RunPointerCallback)"/>
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Run(Ecs.RunPointerCallback callback)
    {
        _observerBuilder.Run(callback);
        return ref this;
    }

    /// <inheritdoc cref="ObserverBuilder.Run(Ecs.RunPointerCallback)"/>
    public ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Run(delegate*<Iter, delegate*<Iter, void>, void> callback)
    {
        _observerBuilder.Run(callback);
        return ref this;
    }

    private ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> SetCallback<T>(T callback, IntPtr invoker) where T : Delegate
    {
        _observerBuilder.SetCallback(callback, invoker);
        return ref this;
    }

    private ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> SetCallback(IntPtr callback, IntPtr invoker)
    {
        _observerBuilder.SetCallback(callback, invoker);
        return ref this;
    }

    private ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> SetRun<T>(T callback, IntPtr invoker) where T : Delegate
    {
        _observerBuilder.SetRun(callback, invoker);
        return ref this;
    }

    private ref ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> SetRun(IntPtr callback, IntPtr invoker)
    {
        _observerBuilder.SetRun(callback, invoker);
        return ref this;
    }

    private Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Build()
    {
        return new Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(_observerBuilder.Build());
    }

    Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> IQueryBuilder<ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>.Build()
    {
        return Build();
    }

    /// <inheritdoc cref="ObserverBuilder.Equals(ObserverBuilder)"/>
    public bool Equals(ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
    {
        return _observerBuilder == other._observerBuilder;
    }

    /// <inheritdoc cref="ObserverBuilder.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other && Equals(other);
    }

    /// <inheritdoc cref="ObserverBuilder.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _observerBuilder.GetHashCode();
    }

    /// <inheritdoc cref="ObserverBuilder.op_Equality"/>
    public static bool operator ==(ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="ObserverBuilder.op_Inequality"/>
    public static bool operator !=(ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right)
    {
        return !(left == right);
    }
}