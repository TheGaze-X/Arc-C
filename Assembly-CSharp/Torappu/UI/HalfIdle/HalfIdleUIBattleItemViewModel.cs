using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x0200675B RID: 26459
	[Token(Token = "0x200675B")]
	public class HalfIdleUIBattleItemViewModel : IHotfixable
	{
		// Token: 0x06025F7B RID: 155515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F7B")]
		[Address(RVA = "0x20F61E0", Offset = "0x20F4DE0", VA = "0x1820F61E0")]
		public HalfIdleUIBattleItemViewModel()
		{
		}

		// Token: 0x0403568F RID: 218767
		[Token(Token = "0x403568F")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04035690 RID: 218768
		[Token(Token = "0x4035690")]
		[FieldOffset(Offset = "0x18")]
		public int itemCnt;

		// Token: 0x04035691 RID: 218769
		[Token(Token = "0x4035691")]
		[FieldOffset(Offset = "0x1C")]
		public float itemCollectProgress;

		// Token: 0x04035692 RID: 218770
		[Token(Token = "0x4035692")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
