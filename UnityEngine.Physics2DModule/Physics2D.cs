using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	[NativeHeader("Physics2DScriptingClasses.h")]
	[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
	[NativeHeader("Physics2DScriptingClasses.h")]
	public class Physics2D
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x17000001")]
		public static PhysicsScene2D defaultPhysicsScene
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x592C430", Offset = "0x592B030", VA = "0x18592C430")]
			get
			{
				return default(PhysicsScene2D);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x17000002")]
		[StaticAccessor("GetPhysics2DSettings()")]
		public static Vector2 gravity
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x59C5170", Offset = "0x59C3D70", VA = "0x1859C5170")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001F RID: 31
		[Token(Token = "0x17000003")]
		[StaticAccessor("GetPhysics2DSettings()")]
		public static extern bool queriesHitTriggers { [Token(Token = "0x600001F")] [Address(RVA = "0x59C51E0", Offset = "0x59C3DE0", VA = "0x1859C51E0")] [MethodImpl(4096)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32
		// (set) Token: 0x06000021 RID: 33
		[Token(Token = "0x17000004")]
		[StaticAccessor("GetPhysics2DSettings()")]
		public static extern SimulationMode2D simulationMode { [Token(Token = "0x6000020")] [Address(RVA = "0x59C5210", Offset = "0x59C3E10", VA = "0x1859C5210")] [MethodImpl(4096)] get; [Token(Token = "0x6000021")] [Address(RVA = "0x59C5240", Offset = "0x59C3E40", VA = "0x1859C5240")] [MethodImpl(4096)] set; }

		// Token: 0x06000022 RID: 34 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x59C4FF0", Offset = "0x59C3BF0", VA = "0x1859C4FF0")]
		public static bool Simulate(float step)
		{
			return default(bool);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59C4F70", Offset = "0x59C3B70", VA = "0x1859C4F70")]
		[NativeMethod("Simulate_Binding")]
		internal static bool Simulate_Internal(PhysicsScene2D physicsScene, float step)
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x59C4DC0", Offset = "0x59C39C0", VA = "0x1859C4DC0")]
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x59C4A40", Offset = "0x59C3640", VA = "0x1859C4A40")]
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59C47B0", Offset = "0x59C33B0", VA = "0x1859C47B0")]
		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x59C4C20", Offset = "0x59C3820", VA = "0x1859C4C20")]
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x59C4510", Offset = "0x59C3110", VA = "0x1859C4510")]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x59C46B0", Offset = "0x59C32B0", VA = "0x1859C46B0")]
		[ExcludeFromDocs]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return 0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59C4940", Offset = "0x59C3540", VA = "0x1859C4940")]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
		{
			return 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x59C4B20", Offset = "0x59C3720", VA = "0x1859C4B20")]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity)
		{
			return 0;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x59C4180", Offset = "0x59C2D80", VA = "0x1859C4180")]
		public static RaycastHit2D GetRayIntersection(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return default(RaycastHit2D);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x59C3D00", Offset = "0x59C2900", VA = "0x1859C3D00")]
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray)
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x59C3BD0", Offset = "0x59C27D0", VA = "0x1859C3BD0")]
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance)
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x59C3AA0", Offset = "0x59C26A0", VA = "0x1859C3AA0")]
		[RequiredByNativeCode]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x59C3A00", Offset = "0x59C2600", VA = "0x1859C3A00")]
		[NativeMethod("GetRayIntersectionAll_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59C4060", Offset = "0x59C2C60", VA = "0x1859C4060")]
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results)
		{
			return 0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x59C3E20", Offset = "0x59C2A20", VA = "0x1859C3E20")]
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance)
		{
			return 0;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x59C3F40", Offset = "0x59C2B40", VA = "0x1859C3F40")]
		[RequiredByNativeCode]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return 0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x59C43F0", Offset = "0x59C2FF0", VA = "0x1859C43F0")]
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask)
		{
			return 0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x59C42F0", Offset = "0x59C2EF0", VA = "0x1859C42F0")]
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask)
		{
			return 0;
		}

		// Token: 0x06000037 RID: 55
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x59C5130", Offset = "0x59C3D30", VA = "0x1859C5130")]
		[MethodImpl(4096)]
		private static extern void get_gravity_Injected(out Vector2 ret);

		// Token: 0x06000038 RID: 56
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x59C4F20", Offset = "0x59C3B20", VA = "0x1859C4F20")]
		[MethodImpl(4096)]
		private static extern bool Simulate_Internal_Injected(ref PhysicsScene2D physicsScene, float step);

		// Token: 0x06000039 RID: 57
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59C3990", Offset = "0x59C2590", VA = "0x1859C3990")]
		[MethodImpl(4096)]
		private static extern RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask);

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x0")]
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D;
	}
}
