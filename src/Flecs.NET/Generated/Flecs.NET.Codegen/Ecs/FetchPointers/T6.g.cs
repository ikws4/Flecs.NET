﻿// FetchPointers/T6.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Ecs.cs
using System;

using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Ecs
{
    internal static bool EnsurePointers<T0, T1, T2, T3, T4, T5>(ecs_world_t* world, ulong e, void** ptrs)
    {
        ptrs[0] = ecs_ensure_id(world, e, Type<T0>.Id(world)); ptrs[1] = ecs_ensure_id(world, e, Type<T1>.Id(world)); ptrs[2] = ecs_ensure_id(world, e, Type<T2>.Id(world)); ptrs[3] = ecs_ensure_id(world, e, Type<T3>.Id(world)); ptrs[4] = ecs_ensure_id(world, e, Type<T4>.Id(world)); ptrs[5] = ecs_ensure_id(world, e, Type<T5>.Id(world));
        return true;
    }

    internal static bool GetPointers<T0, T1, T2, T3, T4, T5>(ecs_world_t* world, ulong e, ecs_record_t* r, ecs_table_t* table, void** ptrs)
    {
        Ecs.Assert(table != null, nameof(ECS_INTERNAL_ERROR));
    
        if (ecs_table_column_count(table) == 0 && ecs_table_has_flags(table, EcsTableHasSparse) == 0)
            return false;
    
        ecs_world_t* realWorld = ecs_get_world(world);
    
        ulong* ids = stackalloc ulong[] { Type<T0>.Id(world), Type<T1>.Id(world), Type<T2>.Id(world), Type<T3>.Id(world), Type<T4>.Id(world), Type<T5>.Id(world) };
        int* columns = stackalloc int[] { ecs_table_get_column_index(realWorld, table, ids[0]), ecs_table_get_column_index(realWorld, table, ids[1]), ecs_table_get_column_index(realWorld, table, ids[2]), ecs_table_get_column_index(realWorld, table, ids[3]), ecs_table_get_column_index(realWorld, table, ids[4]), ecs_table_get_column_index(realWorld, table, ids[5]) };
    
        for (int i = 0; i < 6; i++)
        {
            if (columns[i] == -1)
            {
                void *ptr = ecs_get_mut_id(world, e, ids[i]);
    
                if (ptr == null)
                    return false;
    
                ptrs[i] = ptr;
                continue;
            }
    
            ptrs[i] = ecs_record_get_by_column(r, columns[i], 0);
        }
    
        return true;
    }
}