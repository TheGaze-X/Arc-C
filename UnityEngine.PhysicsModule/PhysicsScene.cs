using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
	public struct PhysicsScene : IEquatable<PhysicsScene>
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x59C7DC0", Offset = "0x59C69C0", VA = "0x1859C7DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x59C7610", Offset = "0x59C6210", VA = "0x1859C7610", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5921240", Offset = "0x591FE40", VA = "0x185921240", Slot = "4")]
		public bool Equals(PhysicsScene other)
		{
			return default(bool);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x59C7B20", Offset = "0x59C6720", VA = "0x1859C7B20")]
		public bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x59C77E0", Offset = "0x59C63E0", VA = "0x1859C77E0")]
		[NativeName("RaycastTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x59C7C60", Offset = "0x59C6860", VA = "0x1859C7C60")]
		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x59C78C0", Offset = "0x59C64C0", VA = "0x1859C78C0")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		[NativeName("Raycast")]
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return default(bool);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x59C7930", Offset = "0x59C6530", VA = "0x1859C7930")]
		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x59C7700", Offset = "0x59C6300", VA = "0x1859C7700")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		[NativeName("RaycastNonAlloc")]
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		// Token: 0x06000079 RID: 121
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x59C7770", Offset = "0x59C6370", VA = "0x1859C7770")]
		[MethodImpl(4096)]
		private static extern bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600007A RID: 122
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x59C7850", Offset = "0x59C6450", VA = "0x1859C7850")]
		[MethodImpl(4096)]
		private static extern bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0600007B RID: 123
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x59C7690", Offset = "0x59C6290", VA = "0x1859C7690")]
		[MethodImpl(4096)]
		private static extern int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		private int m_Handle;
	}
}
