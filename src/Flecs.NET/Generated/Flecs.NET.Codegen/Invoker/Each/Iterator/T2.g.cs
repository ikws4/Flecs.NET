﻿// Each/Iterator/T2.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Invoker.cs
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Invoker
{
    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, Ecs.EachRefCallback<T0, T1> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, Ecs.EachEntityRefCallback<T0, T1> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, Ecs.EachIterRefCallback<T0, T1> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(it, i, ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, delegate*<ref T0, ref T1, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, delegate*<Entity, ref T0, ref T1, void> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, delegate*<Iter, int, ref T0, ref T1, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(it, i, ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, Ecs.EachPointerCallback<T0, T1> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback((T0*)pointer0, (T1*)pointer1);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, Ecs.EachEntityPointerCallback<T0, T1> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), (T0*)pointer0, (T1*)pointer1);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, Ecs.EachIterPointerCallback<T0, T1> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(it, i, (T0*)pointer0, (T1*)pointer1);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, delegate*<T0*, T1*, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback((T0*)pointer0, (T1*)pointer1);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, delegate*<Entity, T0*, T1*, void> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), (T0*)pointer0, (T1*)pointer1);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam>
    public static void Each<T0, T1>(Iter it, delegate*<Iter, int, T0*, T1*, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1])
            callback(it, i, (T0*)pointer0, (T1*)pointer1);
            
        Ecs.TableUnlock(it);
    }
}