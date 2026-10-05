using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041A0 RID: 16800
	[Token(Token = "0x20041A0")]
	public class SandboxV2DungeonCrossDayCalcDetailItemModel : IHotfixable
	{
		// Token: 0x06019E93 RID: 106131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E93")]
		[Address(RVA = "0x12C0C30", Offset = "0x12BF830", VA = "0x1812C0C30")]
		public SandboxV2DungeonCrossDayCalcDetailItemModel(string title, int score, int sortId, bool isMax = false)
		{
		}

		// Token: 0x04020996 RID: 133526
		[Token(Token = "0x4020996")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x04020997 RID: 133527
		[Token(Token = "0x4020997")]
		[FieldOffset(Offset = "0x18")]
		public int score;

		// Token: 0x04020998 RID: 133528
		[Token(Token = "0x4020998")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04020999 RID: 133529
		[Token(Token = "0x4020999")]
		[FieldOffset(Offset = "0x20")]
		public bool isMax;

		// Token: 0x0402099A RID: 133530
		[Token(Token = "0x402099A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
