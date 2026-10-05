using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[NativeHeader("Modules/Physics/PhysicsManager.h")]
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
	public class Physics
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59C8390", Offset = "0x59C6F90", VA = "0x1859C8390")]
		[RequiredByNativeCode]
		private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x17000001")]
		[NativeProperty("DefaultPhysicsSceneHandle", true, TargetType.Function, true)]
		public static PhysicsScene defaultPhysicsScene
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x59CABF0", Offset = "0x59C97F0", VA = "0x1859CABF0")]
			get
			{
				return default(PhysicsScene);
			}
		}

		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x59C7EA0", Offset = "0x59C6AA0", VA = "0x1859C7EA0")]
		[MethodImpl(4096)]
		public static extern void IgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2, [DefaultValue("true")] bool ignore);

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x59C7F00", Offset = "0x59C6B00", VA = "0x1859C7F00")]
		[ExcludeFromDocs]
		public static void IgnoreCollision(Collider collider1, Collider collider2)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x59C9770", Offset = "0x59C8370", VA = "0x1859C9770")]
		public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59C92B0", Offset = "0x59C7EB0", VA = "0x1859C92B0")]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59CA800", Offset = "0x59C9400", VA = "0x1859CA800")]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x59CA320", Offset = "0x59C8F20", VA = "0x1859CA320")]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction)
		{
			return default(bool);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x59CA240", Offset = "0x59C8E40", VA = "0x1859CA240")]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x59C9940", Offset = "0x59C8540", VA = "0x1859C9940")]
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59C90D0", Offset = "0x59C7CD0", VA = "0x1859C90D0")]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x59C9480", Offset = "0x59C8080", VA = "0x1859C9480")]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x59CA040", Offset = "0x59C8C40", VA = "0x1859CA040")]
		public static bool Raycast(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x59C9A20", Offset = "0x59C8620", VA = "0x1859C9A20")]
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance, int layerMask)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x59C9C20", Offset = "0x59C8820", VA = "0x1859C9C20")]
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59CA9C0", Offset = "0x59C95C0", VA = "0x1859CA9C0")]
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray)
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59CA6F0", Offset = "0x59C92F0", VA = "0x1859CA6F0")]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59C9660", Offset = "0x59C8260", VA = "0x1859C9660")]
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59C9E20", Offset = "0x59C8A20", VA = "0x1859C9E20")]
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59CA4E0", Offset = "0x59C90E0", VA = "0x1859CA4E0")]
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x59C8030", Offset = "0x59C6C30", VA = "0x1859C8030")]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x59C81E0", Offset = "0x59C6DE0", VA = "0x1859C81E0")]
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x59C7FC0", Offset = "0x59C6BC0", VA = "0x1859C7FC0")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		[NativeName("RaycastAll")]
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x59C85E0", Offset = "0x59C71E0", VA = "0x1859C85E0")]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59C8590", Offset = "0x59C7190", VA = "0x1859C8590")]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x59C8810", Offset = "0x59C7410", VA = "0x1859C8810")]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x59C8860", Offset = "0x59C7460", VA = "0x1859C8860")]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x59C8760", Offset = "0x59C7360", VA = "0x1859C8760")]
		public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x59C84F0", Offset = "0x59C70F0", VA = "0x1859C84F0")]
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask)
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x59C8450", Offset = "0x59C7050", VA = "0x1859C8450")]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance)
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x59C88C0", Offset = "0x59C74C0", VA = "0x1859C88C0")]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray)
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59C8E10", Offset = "0x59C7A10", VA = "0x1859C8E10")]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x59C8B50", Offset = "0x59C7750", VA = "0x1859C8B50")]
		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask)
		{
			return 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x59C8950", Offset = "0x59C7550", VA = "0x1859C8950")]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance)
		{
			return 0;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59C8A50", Offset = "0x59C7650", VA = "0x1859C8A50")]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results)
		{
			return 0;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x59C8F20", Offset = "0x59C7B20", VA = "0x1859C8F20")]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x59C8D30", Offset = "0x59C7930", VA = "0x1859C8D30")]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask)
		{
			return 0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59C8C60", Offset = "0x59C7860", VA = "0x1859C8C60")]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance)
		{
			return 0;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x59C9000", Offset = "0x59C7C00", VA = "0x1859C9000")]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results)
		{
			return 0;
		}

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x59CABB0", Offset = "0x59C97B0", VA = "0x1859CABB0")]
		[MethodImpl(4096)]
		private static extern void get_defaultPhysicsScene_Injected(out PhysicsScene ret);

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x59C7F50", Offset = "0x59C6B50", VA = "0x1859C7F50")]
		[MethodImpl(4096)]
		private static extern RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD;
	}
}
