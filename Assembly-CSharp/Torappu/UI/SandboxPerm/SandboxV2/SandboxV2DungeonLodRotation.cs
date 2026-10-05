using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004165 RID: 16741
	[Token(Token = "0x2004165")]
	public class SandboxV2DungeonLodRotation : SandboxV2DungeonLodElement
	{
		// Token: 0x06019D70 RID: 105840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D70")]
		[Address(RVA = "0x12C6950", Offset = "0x12C5550", VA = "0x1812C6950", Slot = "5")]
		public override void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank, bool fastMode = false)
		{
		}

		// Token: 0x06019D71 RID: 105841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D71")]
		[Address(RVA = "0x12C6A80", Offset = "0x12C5680", VA = "0x1812C6A80")]
		public SandboxV2DungeonLodRotation()
		{
		}

		// Token: 0x04020749 RID: 132937
		[Token(Token = "0x4020749")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _rotationMin;

		// Token: 0x0402074A RID: 132938
		[Token(Token = "0x402074A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _rotationMax;

		// Token: 0x0402074B RID: 132939
		[Token(Token = "0x402074B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLod;

		// Token: 0x0402074C RID: 132940
		[Token(Token = "0x402074C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
