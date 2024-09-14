﻿// QueryBuilder.QueryBuilder/T13.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/QueryBuilder.cs
using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public unsafe partial struct QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
{
    /// <inheritdoc cref="Core.QueryBuilder.Self()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Self()
    {
        Ecs.GetQueryBuilder(ref this).Self();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Id(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Id(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Id(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Entity(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Entity(ulong entity)
    {
        Ecs.GetQueryBuilder(ref this).Entity(entity);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Name(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Name(string name)
    {
        Ecs.GetQueryBuilder(ref this).Name(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Var(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Var(string name)
    {
        Ecs.GetQueryBuilder(ref this).Var(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Term(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Term(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Term(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Src()
    {
        Ecs.GetQueryBuilder(ref this).Src();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> First()
    {
        Ecs.GetQueryBuilder(ref this).First();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Second()
    {
        Ecs.GetQueryBuilder(ref this).Second();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Src(ulong srcId)
    {
        Ecs.GetQueryBuilder(ref this).Src(srcId);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Src<T>()
    {
        Ecs.GetQueryBuilder(ref this).Src<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Src<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Src(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Src(string name)
    {
        Ecs.GetQueryBuilder(ref this).Src(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> First(ulong firstId)
    {
        Ecs.GetQueryBuilder(ref this).First(firstId);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> First<T>()
    {
        Ecs.GetQueryBuilder(ref this).First<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> First<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).First(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> First(string name)
    {
        Ecs.GetQueryBuilder(ref this).First(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Second(ulong secondId)
    {
        Ecs.GetQueryBuilder(ref this).Second(secondId);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Second<T>()
    {
        Ecs.GetQueryBuilder(ref this).Second<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Second<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Second(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Second(string secondName)
    {
        Ecs.GetQueryBuilder(ref this).Second(secondName);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Up(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Up(ulong traverse = 0)
    {
        Ecs.GetQueryBuilder(ref this).Up(traverse);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Up{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Up<T>()
    {
        Ecs.GetQueryBuilder(ref this).Up<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Up{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Up<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Up(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cascade(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Cascade(ulong traverse = 0)
    {
        Ecs.GetQueryBuilder(ref this).Cascade(traverse);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cascade{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Cascade<T>()
    {
        Ecs.GetQueryBuilder(ref this).Cascade<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cascade{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Cascade<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Cascade(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Descend()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Descend()
    {
        Ecs.GetQueryBuilder(ref this).Descend();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Parent()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Parent()
    {
        Ecs.GetQueryBuilder(ref this).Parent();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Trav(ulong, uint)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Trav(ulong traverse, uint flags = 0)
    {
        Ecs.GetQueryBuilder(ref this).Trav(traverse, flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Trav{T}(uint)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Trav<T>(uint flags = 0)
    {
        Ecs.GetQueryBuilder(ref this).Trav<T>(flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Trav{T}(T, uint)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Trav<T>(T value, uint flags = 0) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Trav(value, flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Flags"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Flags(ulong flags)
    {
        Ecs.GetQueryBuilder(ref this).Flags(flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOut(ecs_inout_kind_t)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InOut(ecs_inout_kind_t inOut)
    {
        Ecs.GetQueryBuilder(ref this).InOut(inOut);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOutStage(ecs_inout_kind_t)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InOutStage(ecs_inout_kind_t inOut)
    {
        Ecs.GetQueryBuilder(ref this).InOutStage(inOut);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write()
    {
        Ecs.GetQueryBuilder(ref this).Write();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read()
    {
        Ecs.GetQueryBuilder(ref this).Read();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ReadWrite()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ReadWrite()
    {
        Ecs.GetQueryBuilder(ref this).ReadWrite();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.In()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> In()
    {
        Ecs.GetQueryBuilder(ref this).In();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Out()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Out()
    {
        Ecs.GetQueryBuilder(ref this).Out();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOut()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InOut()
    {
        Ecs.GetQueryBuilder(ref this).InOut();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOutNone()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InOutNone()
    {
        Ecs.GetQueryBuilder(ref this).InOutNone();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Oper(ecs_oper_kind_t)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Oper(ecs_oper_kind_t oper)
    {
        Ecs.GetQueryBuilder(ref this).Oper(oper);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.And()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> And()
    {
        Ecs.GetQueryBuilder(ref this).And();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Or()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Or()
    {
        Ecs.GetQueryBuilder(ref this).Or();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Not()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Not()
    {
        Ecs.GetQueryBuilder(ref this).Not();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Optional()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Optional()
    {
        Ecs.GetQueryBuilder(ref this).Optional();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.AndFrom()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> AndFrom()
    {
        Ecs.GetQueryBuilder(ref this).AndFrom();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OrFrom()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> OrFrom()
    {
        Ecs.GetQueryBuilder(ref this).OrFrom();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.NotFrom()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> NotFrom()
    {
        Ecs.GetQueryBuilder(ref this).NotFrom();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Singleton()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Singleton()
    {
        Ecs.GetQueryBuilder(ref this).Singleton();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Filter()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Filter()
    {
        Ecs.GetQueryBuilder(ref this).Filter();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.QueryFlags"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> QueryFlags(uint flags)
    {
        Ecs.GetQueryBuilder(ref this).QueryFlags(flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.CacheKind(ecs_query_cache_kind_t)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CacheKind(ecs_query_cache_kind_t kind)
    {
        Ecs.GetQueryBuilder(ref this).CacheKind(kind);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cached()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Cached()
    {
        Ecs.GetQueryBuilder(ref this).Cached();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Expr(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Expr(string expr)
    {
        Ecs.GetQueryBuilder(ref this).Expr(expr);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(Core.Term)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With(Term term)
    {
        Ecs.GetQueryBuilder(ref this).With(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).With(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With(string name)
    {
        Ecs.GetQueryBuilder(ref this).With(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(ulong, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(ulong, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(string, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(string, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<T>()
    {
        Ecs.GetQueryBuilder(ref this).With<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).With(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}(T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}(T1)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1}(T1, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T2}(string, T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> With<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithSecond{T2}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> WithSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).WithSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithSecond{T2}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> WithSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).WithSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(Core.Term)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without(Term term)
    {
        Ecs.GetQueryBuilder(ref this).Without(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Without(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without(string name)
    {
        Ecs.GetQueryBuilder(ref this).Without(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(ulong, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(ulong, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(string, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(string, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<T>()
    {
        Ecs.GetQueryBuilder(ref this).Without<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}(T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}(T1)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(T1, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T2}(string, T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Without<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithoutSecond{T2}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> WithoutSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).WithoutSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithoutSecond{T2}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> WithoutSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).WithoutSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(Core.Term)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write(Term term)
    {
        Ecs.GetQueryBuilder(ref this).Write(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Write(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write(string name)
    {
        Ecs.GetQueryBuilder(ref this).Write(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(ulong, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(ulong, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(string, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(string, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<T>()
    {
        Ecs.GetQueryBuilder(ref this).Write<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}(T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}(T1)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(T1, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T2}(string, T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Write<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WriteSecond{T2}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> WriteSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).WriteSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WriteSecond{T2}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> WriteSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).WriteSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(Core.Term)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read(Term term)
    {
        Ecs.GetQueryBuilder(ref this).Read(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Read(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read(string name)
    {
        Ecs.GetQueryBuilder(ref this).Read(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(ulong, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(ulong, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(string, ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(string, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<T>()
    {
        Ecs.GetQueryBuilder(ref this).Read<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T}(T)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}(T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}(T1)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(T1, string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T2}(string, T2)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Read<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ReadSecond{T2}(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ReadSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).ReadSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ReadSecond{T2}(string)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ReadSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).ReadSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ScopeOpen()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ScopeOpen()
    {
        Ecs.GetQueryBuilder(ref this).ScopeOpen();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ScopeClose()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ScopeClose()
    {
        Ecs.GetQueryBuilder(ref this).ScopeClose();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Term()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Term()
    {
        Ecs.GetQueryBuilder(ref this).Term();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.TermAt(int)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> TermAt(int termIndex)
    {
        Ecs.GetQueryBuilder(ref this).TermAt(termIndex);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OrderBy(ulong, Ecs.OrderByAction)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> OrderBy(ulong component, Ecs.OrderByAction compare)
    {
        Ecs.GetQueryBuilder(ref this).OrderBy(component, compare);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OrderBy{T}(Ecs.OrderByAction)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> OrderBy<T>(Ecs.OrderByAction compare)
    {
        Ecs.GetQueryBuilder(ref this).OrderBy<T>(compare);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy(ulong)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupBy(ulong component)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy(component);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T}()"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupBy<T>()
    {
        Ecs.GetQueryBuilder(ref this).GroupBy<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy(ulong, Ecs.GroupByAction)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupBy(ulong component, Ecs.GroupByAction callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy(component, callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T}(Ecs.GroupByAction)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupBy<T>(Ecs.GroupByAction callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy<T>(callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy(ulong, Ecs.GroupByCallback)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupBy(ulong component, Ecs.GroupByCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy(component, callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T}(Ecs.GroupByCallback)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupBy<T>(Ecs.GroupByCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy<T>(callback);
        return ref this;
    }

    ///
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupByCtx(void* ctx, Ecs.ContextFree contextFree)
    {
        Ecs.GetQueryBuilder(ref this).GroupByCtx(ctx, contextFree);
        return ref this;
    }

    ///
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GroupByCtx(void* ctx)
    {
        Ecs.GetQueryBuilder(ref this).GroupByCtx(ctx);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OnGroupCreate(Ecs.GroupCreateAction)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> OnGroupCreate(Ecs.GroupCreateAction onGroupCreate)
    {
        Ecs.GetQueryBuilder(ref this).OnGroupCreate(onGroupCreate);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OnGroupDelete(Ecs.GroupDeleteAction)"/>
    public ref QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> OnGroupDelete(Ecs.GroupDeleteAction onGroupDelete)
    {
        Ecs.GetQueryBuilder(ref this).OnGroupDelete(onGroupDelete);
        return ref this;
    }
}