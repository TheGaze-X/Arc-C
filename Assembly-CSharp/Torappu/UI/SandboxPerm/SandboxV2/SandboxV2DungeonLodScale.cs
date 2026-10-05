using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004166 RID: 16742
	[Token(Token = "0x2004166")]
	public class SandboxV2DungeonLodScale : SandboxV2DungeonLodElement
	{
		// Token: 0x06019D72 RID: 105842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D72")]
		[Address(RVA = "0x12C6AE0", Offset = "0x12C56E0", VA = "0x1812C6AE0", Slot = "5")]
		public override void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank, bool fastMode = false)
		{
		}

		// Token: 0x06019D73 RID: 105843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D73")]
		[Address(RVA = "0x12C6C30", Offset = "0x12C5830", VA = "0x1812C6C30")]
		public SandboxV2DungeonLodScale()
		{
		}

		// Token: 0x0402074D RID: 132941
		[Token(Token = "0x402074D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _scaleMin;

		// Token: 0x0402074E RID: 132942
		[Token(Token = "0x402074E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _scaleMax;

		// Token: 0x0402074F RID: 132943
		[Token(Token = "0x402074F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLod;

		// Token: 0x04020750 RID: 132944
		[Token(Token = "0x4020750")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
