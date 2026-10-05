using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
	public struct PhysicsScene2D : IEquatable<PhysicsScene2D>
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59C6330", Offset = "0x59C4F30", VA = "0x1859C6330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x59C53E0", Offset = "0x59C3FE0", VA = "0x1859C53E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5921240", Offset = "0x591FE40", VA = "0x185921240", Slot = "4")]
		public bool Equals(PhysicsScene2D other)
		{
			return default(bool);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x59C6110", Offset = "0x59C4D10", VA = "0x1859C6110")]
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59C6250", Offset = "0x59C4E50", VA = "0x1859C6250")]
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59C5F50", Offset = "0x59C4B50", VA = "0x1859C5F50")]
		[NativeMethod("Raycast_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x59C5FD0", Offset = "0x59C4BD0", VA = "0x1859C5FD0")]
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return 0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x59C5D70", Offset = "0x59C4970", VA = "0x1859C5D70")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("RaycastArray_Binding")]
		private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [Unmarshalled] [NotNull("ArgumentNullException")] RaycastHit2D[] results)
		{
			return 0;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x59C6070", Offset = "0x59C4C70", VA = "0x1859C6070")]
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return 0;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59C5E60", Offset = "0x59C4A60", VA = "0x1859C5E60")]
		[NativeMethod("RaycastList_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull("ArgumentNullException")] List<RaycastHit2D> results)
		{
			return 0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x59C5630", Offset = "0x59C4230", VA = "0x1859C5630")]
		public RaycastHit2D GetRayIntersection(Ray ray, float distance, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x59C55B0", Offset = "0x59C41B0", VA = "0x1859C55B0")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("GetRayIntersection_Binding")]
		private static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x59C5760", Offset = "0x59C4360", VA = "0x1859C5760")]
		public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return 0;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x59C54D0", Offset = "0x59C40D0", VA = "0x1859C54D0")]
		[NativeMethod("GetRayIntersectionArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, [Unmarshalled] [NotNull("ArgumentNullException")] RaycastHit2D[] results)
		{
			return 0;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59C5C70", Offset = "0x59C4870", VA = "0x1859C5C70")]
		public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59C5C00", Offset = "0x59C4800", VA = "0x1859C5C00")]
		[NativeMethod("OverlapCircleArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int OverlapCircleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, [NotNull("ArgumentNullException")] [Unmarshalled] Collider2D[] results)
		{
			return 0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59C5AF0", Offset = "0x59C46F0", VA = "0x1859C5AF0")]
		public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59C5A70", Offset = "0x59C4670", VA = "0x1859C5A70")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("OverlapBoxArray_Binding")]
		private static int OverlapBoxArray_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, [Unmarshalled] [NotNull("ArgumentNullException")] Collider2D[] results)
		{
			return 0;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59C59B0", Offset = "0x59C45B0", VA = "0x1859C59B0")]
		public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x59C5840", Offset = "0x59C4440", VA = "0x1859C5840")]
		private int OverlapAreaToBoxArray_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x59C5EE0", Offset = "0x59C4AE0", VA = "0x1859C5EE0")]
		[MethodImpl(4096)]
		private static extern void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret);

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x59C5D00", Offset = "0x59C4900", VA = "0x1859C5D00")]
		[MethodImpl(4096)]
		private static extern int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x59C5DF0", Offset = "0x59C49F0", VA = "0x1859C5DF0")]
		[MethodImpl(4096)]
		private static extern int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results);

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59C5540", Offset = "0x59C4140", VA = "0x1859C5540")]
		[MethodImpl(4096)]
		private static extern void GetRayIntersection_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret);

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x59C5460", Offset = "0x59C4060", VA = "0x1859C5460")]
		[MethodImpl(4096)]
		private static extern int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results);

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x59C5B90", Offset = "0x59C4790", VA = "0x1859C5B90")]
		[MethodImpl(4096)]
		private static extern int OverlapCircleArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x59C5A00", Offset = "0x59C4600", VA = "0x1859C5A00")]
		[MethodImpl(4096)]
		private static extern int OverlapBoxArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter, Collider2D[] results);

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private int m_Handle;
	}
}
