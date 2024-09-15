﻿// Each/Iterator/T13.g.cs
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
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1), ref Managed.GetTypeRef<T2>(pointer2), ref Managed.GetTypeRef<T3>(pointer3), ref Managed.GetTypeRef<T4>(pointer4), ref Managed.GetTypeRef<T5>(pointer5), ref Managed.GetTypeRef<T6>(pointer6), ref Managed.GetTypeRef<T7>(pointer7), ref Managed.GetTypeRef<T8>(pointer8), ref Managed.GetTypeRef<T9>(pointer9), ref Managed.GetTypeRef<T10>(pointer10), ref Managed.GetTypeRef<T11>(pointer11), ref Managed.GetTypeRef<T12>(pointer12));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1), ref Managed.GetTypeRef<T2>(pointer2), ref Managed.GetTypeRef<T3>(pointer3), ref Managed.GetTypeRef<T4>(pointer4), ref Managed.GetTypeRef<T5>(pointer5), ref Managed.GetTypeRef<T6>(pointer6), ref Managed.GetTypeRef<T7>(pointer7), ref Managed.GetTypeRef<T8>(pointer8), ref Managed.GetTypeRef<T9>(pointer9), ref Managed.GetTypeRef<T10>(pointer10), ref Managed.GetTypeRef<T11>(pointer11), ref Managed.GetTypeRef<T12>(pointer12));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(it, i, ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1), ref Managed.GetTypeRef<T2>(pointer2), ref Managed.GetTypeRef<T3>(pointer3), ref Managed.GetTypeRef<T4>(pointer4), ref Managed.GetTypeRef<T5>(pointer5), ref Managed.GetTypeRef<T6>(pointer6), ref Managed.GetTypeRef<T7>(pointer7), ref Managed.GetTypeRef<T8>(pointer8), ref Managed.GetTypeRef<T9>(pointer9), ref Managed.GetTypeRef<T10>(pointer10), ref Managed.GetTypeRef<T11>(pointer11), ref Managed.GetTypeRef<T12>(pointer12));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1), ref Managed.GetTypeRef<T2>(pointer2), ref Managed.GetTypeRef<T3>(pointer3), ref Managed.GetTypeRef<T4>(pointer4), ref Managed.GetTypeRef<T5>(pointer5), ref Managed.GetTypeRef<T6>(pointer6), ref Managed.GetTypeRef<T7>(pointer7), ref Managed.GetTypeRef<T8>(pointer8), ref Managed.GetTypeRef<T9>(pointer9), ref Managed.GetTypeRef<T10>(pointer10), ref Managed.GetTypeRef<T11>(pointer11), ref Managed.GetTypeRef<T12>(pointer12));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, void> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1), ref Managed.GetTypeRef<T2>(pointer2), ref Managed.GetTypeRef<T3>(pointer3), ref Managed.GetTypeRef<T4>(pointer4), ref Managed.GetTypeRef<T5>(pointer5), ref Managed.GetTypeRef<T6>(pointer6), ref Managed.GetTypeRef<T7>(pointer7), ref Managed.GetTypeRef<T8>(pointer8), ref Managed.GetTypeRef<T9>(pointer9), ref Managed.GetTypeRef<T10>(pointer10), ref Managed.GetTypeRef<T11>(pointer11), ref Managed.GetTypeRef<T12>(pointer12));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(it, i, ref Managed.GetTypeRef<T0>(pointer0), ref Managed.GetTypeRef<T1>(pointer1), ref Managed.GetTypeRef<T2>(pointer2), ref Managed.GetTypeRef<T3>(pointer3), ref Managed.GetTypeRef<T4>(pointer4), ref Managed.GetTypeRef<T5>(pointer5), ref Managed.GetTypeRef<T6>(pointer6), ref Managed.GetTypeRef<T7>(pointer7), ref Managed.GetTypeRef<T8>(pointer8), ref Managed.GetTypeRef<T9>(pointer9), ref Managed.GetTypeRef<T10>(pointer10), ref Managed.GetTypeRef<T11>(pointer11), ref Managed.GetTypeRef<T12>(pointer12));
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback((T0*)pointer0, (T1*)pointer1, (T2*)pointer2, (T3*)pointer3, (T4*)pointer4, (T5*)pointer5, (T6*)pointer6, (T7*)pointer7, (T8*)pointer8, (T9*)pointer9, (T10*)pointer10, (T11*)pointer11, (T12*)pointer12);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), (T0*)pointer0, (T1*)pointer1, (T2*)pointer2, (T3*)pointer3, (T4*)pointer4, (T5*)pointer5, (T6*)pointer6, (T7*)pointer7, (T8*)pointer8, (T9*)pointer9, (T10*)pointer10, (T11*)pointer11, (T12*)pointer12);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(it, i, (T0*)pointer0, (T1*)pointer1, (T2*)pointer2, (T3*)pointer3, (T4*)pointer4, (T5*)pointer5, (T6*)pointer6, (T7*)pointer7, (T8*)pointer8, (T9*)pointer9, (T10*)pointer10, (T11*)pointer11, (T12*)pointer12);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback((T0*)pointer0, (T1*)pointer1, (T2*)pointer2, (T3*)pointer3, (T4*)pointer4, (T5*)pointer5, (T6*)pointer6, (T7*)pointer7, (T8*)pointer8, (T9*)pointer9, (T10*)pointer10, (T11*)pointer11, (T12*)pointer12);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, void> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(new Entity(it.Handle->world, it.Handle->entities[i]), (T0*)pointer0, (T1*)pointer1, (T2*)pointer2, (T3*)pointer3, (T4*)pointer4, (T5*)pointer5, (T6*)pointer6, (T7*)pointer7, (T8*)pointer8, (T9*)pointer9, (T10*)pointer10, (T11*)pointer11, (T12*)pointer12);
            
        Ecs.TableUnlock(it);
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Each callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam> <typeparam name="T12">The T12 component type.</typeparam>
    public static void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Iter it, delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, void> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        byte* pointer0 = (byte*)it.GetPointer<T0>(0); byte* pointer1 = (byte*)it.GetPointer<T1>(1); byte* pointer2 = (byte*)it.GetPointer<T2>(2); byte* pointer3 = (byte*)it.GetPointer<T3>(3); byte* pointer4 = (byte*)it.GetPointer<T4>(4); byte* pointer5 = (byte*)it.GetPointer<T5>(5); byte* pointer6 = (byte*)it.GetPointer<T6>(6); byte* pointer7 = (byte*)it.GetPointer<T7>(7); byte* pointer8 = (byte*)it.GetPointer<T8>(8); byte* pointer9 = (byte*)it.GetPointer<T9>(9); byte* pointer10 = (byte*)it.GetPointer<T10>(10); byte* pointer11 = (byte*)it.GetPointer<T11>(11); byte* pointer12 = (byte*)it.GetPointer<T12>(12);
        int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8); int step9 = it.Step<T9>(9); int step10 = it.Step<T10>(10); int step11 = it.Step<T11>(11); int step12 = it.Step<T12>(12);
            
        Ecs.TableLock(it);
            
        for (int i = 0; i < count; i++, pointer0 = &pointer0[step0], pointer1 = &pointer1[step1], pointer2 = &pointer2[step2], pointer3 = &pointer3[step3], pointer4 = &pointer4[step4], pointer5 = &pointer5[step5], pointer6 = &pointer6[step6], pointer7 = &pointer7[step7], pointer8 = &pointer8[step8], pointer9 = &pointer9[step9], pointer10 = &pointer10[step10], pointer11 = &pointer11[step11], pointer12 = &pointer12[step12])
            callback(it, i, (T0*)pointer0, (T1*)pointer1, (T2*)pointer2, (T3*)pointer3, (T4*)pointer4, (T5*)pointer5, (T6*)pointer6, (T7*)pointer7, (T8*)pointer8, (T9*)pointer9, (T10*)pointer10, (T11*)pointer11, (T12*)pointer12);
            
        Ecs.TableUnlock(it);
    }
}