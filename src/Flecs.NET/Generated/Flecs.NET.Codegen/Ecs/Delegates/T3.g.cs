﻿// Delegates/T3.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Ecs.cs
using System;

namespace Flecs.NET.Core;

public static unsafe partial class Ecs
{
    /// <summary>
    ///     Function signature that takes an <see cref="Iter"/> and 3 <see cref="Field{T}"/> arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void IterFieldCallback<T0, T1, T2>(Iter it, Field<T0> t0, Field<T1> t1, Field<T2> t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Iter"/> and 3 <see cref="Span{T}"/> arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void IterSpanCallback<T0, T1, T2>(Iter it, Span<T0> t0, Span<T1> t1, Span<T2> t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Iter"/> and 3 T* arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void IterPointerCallback<T0, T1, T2>(Iter it, T0* t0, T1* t1, T2* t2);
    
    /// <summary>
    ///     Function signature that takes 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void EachRefCallback<T0, T1, T2>(ref T0 t0, ref T1 t1, ref T2 t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Entity"/> and 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void EachEntityRefCallback<T0, T1, T2>(Entity entity, ref T0 t0, ref T1 t1, ref T2 t2);

    /// <summary>
    ///     Function signature that takes an <see cref="Iter"/>, an <see cref="int"/>, and 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void EachIterRefCallback<T0, T1, T2>(Iter it, int i, ref T0 t0, ref T1 t1, ref T2 t2);
    
    /// <summary>
    ///     Function signature that takes 3 T* arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void EachPointerCallback<T0, T1, T2>(T0* t0, T1* t1, T2* t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Entity"/> and 3 T* arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void EachEntityPointerCallback<T0, T1, T2>(Entity entity, T0* t0, T1* t1, T2* t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Iter"/>, an <see cref="int"/>, and 3 T* arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void EachIterPointerCallback<T0, T1, T2>(Iter it, int i, T0* t0, T1* t1, T2* t2);
    
    /// <summary>
    ///     Function signature that takes 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate bool FindRefCallback<T0, T1, T2>(ref T0 t0, ref T1 t1, ref T2 t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Entity"/> and 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate bool FindEntityRefCallback<T0, T1, T2>(Entity entity, ref T0 t0, ref T1 t1, ref T2 t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Iter"/>, an <see cref="int"/>, and 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate bool FindIterRefCallback<T0, T1, T2>(Iter it, int i, ref T0 t0, ref T1 t1, ref T2 t2);
    
    /// <summary>
    ///     Function signature that takes 3 T* arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate bool FindPointerCallback<T0, T1, T2>(T0* t0, T1* t1, T2* t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Entity"/> and 3 T* arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate bool FindEntityPointerCallback<T0, T1, T2>(Entity entity, T0* t0, T1* t1, T2* t2);
    
    /// <summary>
    ///     Function signature that takes an <see cref="Iter"/>, an <see cref="int"/>, and 3 T* arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate bool FindIterPointerCallback<T0, T1, T2>(Iter it, int i, T0* t0, T1* t1, T2* t2);
    
    /// <summary>
    ///     Function signature that takes 3 ref readonly T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void ReadRefCallback<T0, T1, T2>(ref readonly T0 t0, ref readonly T1 t1, ref readonly T2 t2);
    
    /// <summary>
    ///     Function signature that takes 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void WriteRefCallback<T0, T1, T2>(ref T0 t0, ref T1 t1, ref T2 t2);
    
    /// <summary>
    ///     Function signature that takes 3 ref T arguments.
    /// </summary>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam>
    public delegate void InsertRefCallback<T0, T1, T2>(ref T0 t0, ref T1 t1, ref T2 t2);
}