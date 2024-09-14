﻿// Each/T4.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/World.cs
namespace Flecs.NET.Core;
             
public unsafe partial struct World
{
    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(Ecs.EachRefCallback<T0, T1, T2, T3> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(Ecs.EachEntityRefCallback<T0, T1, T2, T3> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(Ecs.EachIterRefCallback<T0, T1, T2, T3> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(delegate*<ref T0, ref T1, ref T2, ref T3, void> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, void> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, void> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(Ecs.EachPointerCallback<T0, T1, T2, T3> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(Ecs.EachEntityPointerCallback<T0, T1, T2, T3> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(Ecs.EachIterPointerCallback<T0, T1, T2, T3> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(delegate*<T0*, T1*, T2*, T3*, void> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(delegate*<Entity, T0*, T1*, T2*, T3*, void> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public void Each<T0, T1, T2, T3>(delegate*<Iter, int, T0*, T1*, T2*, T3*, void> callback)
    {
        using Query<T0, T1, T2, T3> query = Query<T0, T1, T2, T3>();
        query.Each(callback);   
    }
}