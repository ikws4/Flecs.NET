﻿// WorkerIterable.IIterable/T4.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/WorkerIterable.cs
using System;

namespace Flecs.NET.Core;

public unsafe partial struct WorkerIterable<T0, T1, T2, T3>
{
    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Run(Ecs.RunCallback callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Run(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Run(delegate*<Iter, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Run(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(Ecs.IterFieldCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Iter(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(Ecs.IterSpanCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Iter(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(Ecs.IterPointerCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Iter(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(delegate*<Iter, Field<T0>, Field<T1>, Field<T2>, Field<T3>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Iter(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(delegate*<Iter, Span<T0>, Span<T1>, Span<T2>, Span<T3>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Iter(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(delegate*<Iter, T0*, T1*, T2*, T3*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Iter(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachRefCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachEntityRefCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachIterRefCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<ref T0, ref T1, ref T2, ref T3, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachPointerCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachEntityPointerCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachIterPointerCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<T0*, T1*, T2*, T3*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Entity, T0*, T1*, T2*, T3*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Iter, int, T0*, T1*, T2*, T3*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        Invoker.Each(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindRefCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindEntityRefCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindIterRefCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<ref T0, ref T1, ref T2, ref T3, bool> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, bool> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, bool> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(true);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindPointerCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindEntityPointerCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindIterPointerCallback<T0, T1, T2, T3> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<T0*, T1*, T2*, T3*, bool> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Entity, T0*, T1*, T2*, T3*, bool> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        return Invoker.Find(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Iter, int, T0*, T1*, T2*, T3*, bool> callback)
    {
        TypeHelper<T0, T1, T2, T3>.AssertReferenceTypes(false);
        return Invoker.Find(ref this, callback);
    }
}