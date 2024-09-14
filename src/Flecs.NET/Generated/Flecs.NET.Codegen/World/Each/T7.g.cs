﻿// Each/T7.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/World.cs
namespace Flecs.NET.Core;
             
public unsafe partial struct World
{
    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6> query = Query<T0, T1, T2, T3, T4, T5, T6>();
        query.Each(callback);   
    }
}