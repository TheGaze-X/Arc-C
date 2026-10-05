using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200419E RID: 16798
	[Token(Token = "0x200419E")]
	public class SandboxV2DungeonCrossDayEnemyRushData : IHotfixable
	{
		// Token: 0x06019E91 RID: 106129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E91")]
		[Address(RVA = "0x12C21D0", Offset = "0x12C0DD0", VA = "0x1812C21D0")]
		public SandboxV2DungeonCrossDayEnemyRushData()
		{
		}

		// Token: 0x0402098D RID: 133517
		[Token(Token = "0x402098D")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0402098E RID: 133518
		[Token(Token = "0x402098E")]
		[FieldOffset(Offset = "0x18")]
		public int killCount;

		// Token: 0x0402098F RID: 133519
		[Token(Token = "0x402098F")]
		[FieldOffset(Offset = "0x1C")]
		public int rewardScore;

		// Token: 0x04020990 RID: 133520
		[Token(Token = "0x4020990")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
