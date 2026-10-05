using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200419B RID: 16795
	[Token(Token = "0x200419B")]
	public class SandboxV2DungeonCrossDaySupplyModel : IHotfixable
	{
		// Token: 0x06019E87 RID: 106119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E87")]
		[Address(RVA = "0x12C6240", Offset = "0x12C4E40", VA = "0x1812C6240")]
		public void LoadData(SandboxV2Data gameData, PlayerSandboxV2 playerSandbox)
		{
		}

		// Token: 0x06019E88 RID: 106120 RVA: 0x0009FAF8 File Offset: 0x0009DCF8
		[Token(Token = "0x6019E88")]
		[Address(RVA = "0x12C63A0", Offset = "0x12C4FA0", VA = "0x1812C63A0")]
		private int _GetBuffCountByChars(List<int> supplyChars)
		{
			return 0;
		}

		// Token: 0x06019E89 RID: 106121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E89")]
		[Address(RVA = "0x12C67A0", Offset = "0x12C53A0", VA = "0x1812C67A0")]
		public SandboxV2DungeonCrossDaySupplyModel()
		{
		}

		// Token: 0x0402095B RID: 133467
		[Token(Token = "0x402095B")]
		[FieldOffset(Offset = "0x10")]
		public int charCount;

		// Token: 0x0402095C RID: 133468
		[Token(Token = "0x402095C")]
		[FieldOffset(Offset = "0x14")]
		public int periodCount;

		// Token: 0x0402095D RID: 133469
		[Token(Token = "0x402095D")]
		[FieldOffset(Offset = "0x18")]
		public int buffCount;

		// Token: 0x0402095E RID: 133470
		[Token(Token = "0x402095E")]
		[FieldOffset(Offset = "0x1C")]
		public bool showBuffEnough;

		// Token: 0x0402095F RID: 133471
		[Token(Token = "0x402095F")]
		[FieldOffset(Offset = "0x20")]
		public int drinkHasCount;

		// Token: 0x04020960 RID: 133472
		[Token(Token = "0x4020960")]
		[FieldOffset(Offset = "0x24")]
		public bool showDrinkNotEnoughTips;

		// Token: 0x04020961 RID: 133473
		[Token(Token = "0x4020961")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04020962 RID: 133474
		[Token(Token = "0x4020962")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetBuffCountByChars;

		// Token: 0x04020963 RID: 133475
		[Token(Token = "0x4020963")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
