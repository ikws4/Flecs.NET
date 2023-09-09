using Flecs.NET.Core;
using Xunit;

namespace Flecs.NET.Tests.Cpp
{
    public unsafe class WorldFactoryTests
    {
        public WorldFactoryTests()
        {
            FlecsInternal.Reset();
        }

        [Fact]
        private void Entity()
        {
            using World world = World.Create();

            Entity e = world.Entity();
            Assert.True(e.Id != 0);
        }

        [Fact]
        private void EntityWithName()
        {
            using World world = World.Create();

            Entity e = world.Entity("MyName");
            Assert.True(e.Id != 0);
            Assert.Equal("MyName", e.Name());
        }

        [Fact]
        private void EntityWithId()
        {
            using World world = World.Create();

            Entity e = world.Entity(100);
            Assert.True(e.Id == 100);
        }

        [Fact]
        private void Prefab()
        {
            using World world = World.Create();

            Entity e = world.Prefab();
            Assert.True(e.Id != 0);
            Assert.True(e.Has(Ecs.Prefab));
        }

        [Fact]
        private void PrefabWithName()
        {
            using World world = World.Create();

            Entity e = world.Prefab("MyName");
            Assert.True(e.Id != 0);
            Assert.True(e.Has(Ecs.Prefab));
            Assert.Equal("MyName", e.Name());
        }

        [Fact]
        private void Routine()
        {
            using World world = World.Create();

            Routine routine = world.Routine(
                filter: world.FilterBuilder()
                    .With<Position>()
                    .With<Velocity>(),
                callback: (it, i) =>
                {
                    Column<Position> p = it.Field<Position>(1);
                    Column<Velocity> v = it.Field<Velocity>(2);

                    p[i].X += v[i].X;
                    p[i].Y += v[i].Y;
                }
            );

            Assert.True(routine.Id != 0);

            Entity e = world.Entity()
                .Set(new Position { X = 10, Y = 20 })
                .Set(new Velocity { X = 1, Y = 2 });

            world.Progress();

            Position* p = e.GetPtr<Position>();
            Assert.Equal(11, p->X);
            Assert.Equal(22, p->Y);
        }

        [Fact]
        private void RoutineWithName()
        {
            using World world = World.Create();

            Routine routine = world.Routine(
                name: "MySystem",
                filter: world.FilterBuilder()
                    .With<Position>()
                    .With<Velocity>(),
                callback: (it, i) =>
                {
                    Column<Position> p = it.Field<Position>(1);
                    Column<Velocity> v = it.Field<Velocity>(2);

                    p[i].X += v[i].X;
                    p[i].Y += v[i].Y;
                }
            );

            Assert.True(routine.Id != 0);
            Assert.Equal("MySystem", routine.Entity.Name());

            Entity e = world.Entity()
                .Set(new Position { X = 10, Y = 20 })
                .Set(new Velocity { X = 1, Y = 2 });

            world.Progress();

            Position* p = e.GetPtr<Position>();
            Assert.Equal(11, p->X);
            Assert.Equal(22, p->Y);
        }

        [Fact]
        private void RoutineWithExpr()
        {
            using World world = World.Create();

            world.Component<Position>();
            world.Component<Velocity>();

            Routine routine = world.Routine(
                name: "MySystem",
                filter: world.FilterBuilder().Expr("Position, [in] Velocity"),
                callback: (it, i) =>
                {
                    Column<Position> p = it.Field<Position>(1);
                    Column<Velocity> v = it.Field<Velocity>(2);

                    p[i].X += v[i].X;
                    p[i].Y += v[i].Y;
                }
            );

            Assert.True(routine.Id != 0);
            Assert.Equal("MySystem", routine.Entity.Name());

            Entity e = world.Entity()
                .Set(new Position { X = 10, Y = 20 })
                .Set(new Velocity { X = 1, Y = 2 });

            world.Progress();

            Position* p = e.GetPtr<Position>();
            Assert.Equal(11, p->X);
            Assert.Equal(22, p->Y);
        }

        [Fact]
        private void Query()
        {
            using World world = World.Create();

            Query q = world.Query(
                filter: world.FilterBuilder()
                    .With<Position>()
                    .With<Velocity>()
            );

            Entity e = world.Entity()
                .Set(new Position { X = 10, Y = 20 })
                .Set(new Velocity { X = 1, Y = 2 });

            q.Each((it, i) =>
            {
                Column<Position> p = it.Field<Position>(1);
                Column<Velocity> v = it.Field<Velocity>(2);

                p[i].X += v[i].X;
                p[i].Y += v[i].Y;
            });

            Position* p = e.GetPtr<Position>();
            Assert.Equal(11, p->X);
            Assert.Equal(22, p->Y);
        }

        [Fact]
        private void QueryWithExpr()
        {
            using World world = World.Create();

            world.Component<Position>();
            world.Component<Velocity>();

            Query q = world.Query(
                filter: world.FilterBuilder().Expr("Position, [in] Velocity")
            );

            Entity e = world.Entity()
                .Set(new Position { X = 10, Y = 20 })
                .Set(new Velocity { X = 1, Y = 2 });

            q.Each((it, i) =>
            {
                Column<Position> p = it.Field<Position>(1);
                Column<Velocity> v = it.Field<Velocity>(2);

                p[i].X += v[i].X;
                p[i].Y += v[i].Y;
            });

            Position* p = e.GetPtr<Position>();
            Assert.Equal(11, p->X);
            Assert.Equal(22, p->Y);
        }

        [Fact]
        private void Snapshot()
        {
            using World world = World.Create();

            world.Component<Position>();
            world.Component<Velocity>();

            Entity e = world.Entity()
                .Set(new Position { X = 10, Y = 20 })
                .Set(new Velocity { X = 1, Y = 2 });

            Snapshot s = world.Snapshot();

            e.Set(new Position { X = 11, Y = 22 });

            s.Restore();

            Position* p = e.GetPtr<Position>();
            Assert.Equal(11, p->X);
            Assert.Equal(22, p->Y);
        }

        [Fact]
        private void Module()
        {
            using World world = World.Create();

            world.Import<MyModule>();

            Entity p = world.Lookup("MyModule::Position");
            Assert.True(p.Id != 0);
        }
    }
}
