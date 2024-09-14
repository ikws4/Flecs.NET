﻿// T5.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/TypeHelper.cs
#nullable enable

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Flecs.NET.Core;

[SuppressMessage("ReSharper", "StaticMemberInGenericType")]
internal static partial class TypeHelper<T0, T1, T2, T3, T4, T5>
{
    private static string[]? _typeNames;
    public static string[] TypeNames => _typeNames ??= [ Type<T0>.FullName, Type<T1>.FullName, Type<T2>.FullName, Type<T3>.FullName, Type<T4>.FullName, Type<T5>.FullName ];
    
    public static readonly int Tags = (Type<T0>.IsTag ? 1 << 0 : 0) | (Type<T1>.IsTag ? 1 << 1 : 0) | (Type<T2>.IsTag ? 1 << 2 : 0) | (Type<T3>.IsTag ? 1 << 3 : 0) | (Type<T4>.IsTag ? 1 << 4 : 0) | (Type<T5>.IsTag ? 1 << 5 : 0);
    public static readonly int ReferenceTypes = (RuntimeHelpers.IsReferenceOrContainsReferences<T0>() ? 1 << 0 : 0) | (RuntimeHelpers.IsReferenceOrContainsReferences<T1>() ? 1 << 1 : 0) | (RuntimeHelpers.IsReferenceOrContainsReferences<T2>() ? 1 << 2 : 0) | (RuntimeHelpers.IsReferenceOrContainsReferences<T3>() ? 1 << 3 : 0) | (RuntimeHelpers.IsReferenceOrContainsReferences<T4>() ? 1 << 4 : 0) | (RuntimeHelpers.IsReferenceOrContainsReferences<T5>() ? 1 << 5 : 0);
    
    [Conditional("DEBUG")]
    public static void AssertNoTags()
    {
        if (Tags == 0)
            return;
    
        string tags = string.Join(", ", Enumerable.Range(0, 6)
            .Where(i => (Tags & (1 << i)) != 0)
            .Select(i => TypeNames[i]));
    
        Ecs.Error($"Cannot use zero-sized structs as generic type arguments for this struct. Remove the following type arguments: {tags}");
    }
    
    [Conditional("DEBUG")]
    public static void AssertReferenceTypes(bool allowReferenceTypes)
    {
        if (allowReferenceTypes || ReferenceTypes == 0)
            return;
    
        string referenceTypes = string.Join(", ", Enumerable.Range(0, 6)
            .Where(i => (ReferenceTypes & (1 << i)) != 0)
            .Select(i => TypeNames[i]));
    
        Ecs.Error($"Cannot use managed types as generic type arguments for callback signatures that retrieve pointers or spans. Remove the following type arguments: {referenceTypes}");
    }
}