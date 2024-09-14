﻿// IIterable/T11.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/IIterable.cs
using System;

using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     Interface for iterable objects.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam>
public unsafe interface IIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IIterableBase
{
    /// <inheritdoc cref="IIterable.Page(int, int)"/>
    public PageIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Page(int offset, int limit);
    
    /// <inheritdoc cref="IIterable.Worker(int, int)"/>
    public WorkerIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Worker(int index, int count);
    
    /// <inheritdoc cref="IIterable.Iter(Flecs.NET.Core.World)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Iter(World world = default);
    
    /// <inheritdoc cref="IIterable.Iter(Flecs.NET.Core.Iter)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Iter(Iter it);
    
    /// <inheritdoc cref="IIterable.Iter(Flecs.NET.Core.Entity)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Iter(Entity entity);

    /// <inheritdoc cref="IIterable.Count()"/>
    public int Count();
    
    /// <inheritdoc cref="IIterable.IsTrue()"/>
    public bool IsTrue();
    
    /// <inheritdoc cref="IIterable.First()"/>
    public Entity First();
    
    /// <inheritdoc cref="IIterable.SetVar(int, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> SetVar(int varId, ulong value);
    
    /// <inheritdoc cref="IIterable.SetVar(string, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> SetVar(string name, ulong value);
    
    /// <inheritdoc cref="IIterable.SetVar(string, ecs_table_t*)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> SetVar(string name, ecs_table_t* value);
    
    /// <inheritdoc cref="IIterable.SetVar(string, ecs_table_range_t)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> SetVar(string name, ecs_table_range_t value);
    
    /// <inheritdoc cref="IIterable.SetVar(string, Table)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> SetVar(string name, Table value);
    
    /// <inheritdoc cref="IIterable.SetGroup(ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> SetGroup(ulong groupId);
    
    /// <inheritdoc cref="IIterable.SetGroup{T}()"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> SetGroup<T>();
    
    /// <summary>
    ///     Iterates the iterable object using the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Run(Ecs.RunCallback callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Run(delegate*<Iter, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(Ecs.IterFieldCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(Ecs.IterSpanCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(Ecs.IterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(delegate*<Iter, Field<T0>, Field<T1>, Field<T2>, Field<T3>, Field<T4>, Field<T5>, Field<T6>, Field<T7>, Field<T8>, Field<T9>, Field<T10>, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(delegate*<Iter, Span<T0>, Span<T1>, Span<T2>, Span<T3>, Span<T4>, Span<T5>, Span<T6>, Span<T7>, Span<T8>, Span<T9>, Span<T10>, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Iter(delegate*<Iter, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public void Each(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, void> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, bool> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, bool> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, bool> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(Ecs.FindIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, bool> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, bool> callback);

    /// <summary>
    ///     Iterates the iterable object using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Entity Find(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, bool> callback);
}