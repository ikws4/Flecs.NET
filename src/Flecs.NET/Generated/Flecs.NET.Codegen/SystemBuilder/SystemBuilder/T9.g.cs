﻿// SystemBuilder/T9.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/SystemBuilder.cs
#nullable enable

using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A type-safe wrapper over <see cref="SystemBuilder"/> that takes 9 type arguments.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
public unsafe partial struct SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IDisposable, IEquatable<SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8>>, IQueryBuilder<SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8>, System<T0, T1, T2, T3, T4, T5, T6, T7, T8>>
{
    private SystemBuilder _systemBuilder;

    /// <inheritdoc cref="SystemBuilder.World"/>
    public ref ecs_world_t* World => ref _systemBuilder.World;

    /// <inheritdoc cref="SystemBuilder.Desc"/>
    public ref ecs_system_desc_t Desc => ref _systemBuilder.Desc;

    /// <inheritdoc cref="SystemBuilder.QueryBuilder"/>
    public ref QueryBuilder QueryBuilder => ref _systemBuilder.QueryBuilder;

    /// <summary>
    ///     Creates a system builder with the provided system builder.
    /// </summary>
    /// <param name="systemBuilder">The system builder.</param>
    public SystemBuilder(SystemBuilder systemBuilder)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertNoTags();
        _systemBuilder = systemBuilder;
    }

    /// <inheritdoc cref="SystemBuilder(ecs_world_t*)"/>
    public SystemBuilder(ecs_world_t* world)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertNoTags();
        _systemBuilder = new SystemBuilder(world).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>();
    }

    /// <inheritdoc cref="SystemBuilder(ecs_world_t*, string)"/>
    public SystemBuilder(ecs_world_t* world, string name)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertNoTags();
        _systemBuilder = new SystemBuilder(world, name).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>();
    }

    /// <inheritdoc cref="SystemBuilder.Dispose()"/>
    public void Dispose()
    {
        _systemBuilder.Dispose();
    }

    /// <inheritdoc cref="SystemBuilder.Kind(ulong)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Kind(ulong phase)
    {
        _systemBuilder.Kind(phase);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Kind{T}()"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Kind<T>()
    {
        _systemBuilder.Kind<T>();
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Kind{T}(T)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Kind<T>(T value) where T : Enum
    {
        _systemBuilder.Kind(value);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.MultiThreaded(bool)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> MultiThreaded(bool value = true)
    {
        _systemBuilder.MultiThreaded();
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Immediate(bool)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Immediate(bool value = true)
    {
        _systemBuilder.Immediate(value);
        return ref this;
    }
    
    /// <inheritdoc cref="SystemBuilder.Interval(float)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Interval(float interval)
    {
        _systemBuilder.Interval(interval);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Rate(ulong, int)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Rate(ulong tickSource, int rate)
    {
        _systemBuilder.Rate(tickSource, rate);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Rate(int)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Rate(int rate)
    {
        _systemBuilder.Rate(rate);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.TickSource(ulong)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> TickSource(ulong tickSource)
    {
        _systemBuilder.TickSource(tickSource);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.TickSource{T}()"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> TickSource<T>()
    {
        _systemBuilder.TickSource<T>();
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Ctx"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Ctx(void* ctx)
    {
        _systemBuilder.Ctx(ctx);
        return ref this;
    }
    
    /// <inheritdoc cref="SystemBuilder.Run(System.Action)"/>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(Action callback)
    {
        return new System<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_systemBuilder.Run(callback));
    }
    
    /// <inheritdoc cref="SystemBuilder.Run(System.Action)"/>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(delegate*<void> callback)
    {
        return new System<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_systemBuilder.Run(callback));
    }

    /// <inheritdoc cref="SystemBuilder.Run(Ecs.RunDelegateCallback)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(Ecs.RunDelegateCallback callback)
    {
        _systemBuilder.Run(callback);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Run(Ecs.RunDelegateCallback)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(delegate*<Iter, Action<Iter>, void> callback)
    {
        _systemBuilder.Run(callback);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Run(Ecs.RunPointerCallback)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(Ecs.RunPointerCallback callback)
    {
        _systemBuilder.Run(callback);
        return ref this;
    }

    /// <inheritdoc cref="SystemBuilder.Run(Ecs.RunPointerCallback)"/>
    public ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(delegate*<Iter, delegate*<Iter, void>, void> callback)
    {
        _systemBuilder.Run(callback);
        return ref this;
    }

    internal ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> SetCallback<T>(T callback, IntPtr invoker) where T : Delegate
    {
        _systemBuilder.SetCallback(callback, invoker);
        return ref this;
    }

    internal ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> SetCallback(IntPtr callback, IntPtr invoker)
    {
        _systemBuilder.SetCallback(callback, invoker);
        return ref this;
    }

    internal ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> SetRun<T>(T callback, IntPtr invoker) where T : Delegate
    {
        _systemBuilder.SetRun(callback, invoker);
        return ref this;
    }

    internal ref SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> SetRun(IntPtr callback, IntPtr invoker)
    {
        _systemBuilder.SetRun(callback, invoker);
        return ref this;
    }

    internal System<T0, T1, T2, T3, T4, T5, T6, T7, T8> Build()
    {
        return new System<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_systemBuilder.Build());
    }
    
    System<T0, T1, T2, T3, T4, T5, T6, T7, T8> IQueryBuilder<SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8>, System<T0, T1, T2, T3, T4, T5, T6, T7, T8>>.Build()
    {
        return Build();
    }

    /// <inheritdoc cref="SystemBuilder.Equals(SystemBuilder)"/>
    public bool Equals(SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
    {
        return _systemBuilder == other._systemBuilder;
    }

    /// <inheritdoc cref="SystemBuilder.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> other && Equals(other);
    }

    /// <inheritdoc cref="SystemBuilder.GetHashCode()"/>
    public override int GetHashCode()
    {
        return HashCode.Combine(Desc.GetHashCode(), QueryBuilder.GetHashCode());
    }

    /// <inheritdoc cref="SystemBuilder.op_Equality"/>
    public static bool operator ==(SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> left, SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="SystemBuilder.op_Inequality"/>
    public static bool operator !=(SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> left, SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8> right)
    {
        return !(left == right);
    }
}