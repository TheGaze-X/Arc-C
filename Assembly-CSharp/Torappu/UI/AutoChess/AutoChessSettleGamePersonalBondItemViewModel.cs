using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062FF RID: 25343
	[Token(Token = "0x20062FF")]
	public class AutoChessSettleGamePersonalBondItemViewModel : IComparable<AutoChessSettleGamePersonalBondItemViewModel>, IHotfixable
	{
		// Token: 0x06024872 RID: 149618 RVA: 0x000C47B8 File Offset: 0x000C29B8
		[Token(Token = "0x6024872")]
		[Address(RVA = "0x1F55D50", Offset = "0x1F54950", VA = "0x181F55D50", Slot = "4")]
		public int CompareTo(AutoChessSettleGamePersonalBondItemViewModel other)
		{
			return 0;
		}

		// Token: 0x06024873 RID: 149619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024873")]
		[Address(RVA = "0x1F55E50", Offset = "0x1F54A50", VA = "0x181F55E50")]
		public AutoChessSettleGamePersonalBondItemViewModel()
		{
		}

		// Token: 0x04032F0E RID: 208654
		[Token(Token = "0x4032F0E")]
		[FieldOffset(Offset = "0x10")]
		public string bondId;

		// Token: 0x04032F0F RID: 208655
		[Token(Token = "0x4032F0F")]
		[FieldOffset(Offset = "0x18")]
		public string bondIconId;

		// Token: 0x04032F10 RID: 208656
		[Token(Token = "0x4032F10")]
		[FieldOffset(Offset = "0x20")]
		public int layer;

		// Token: 0x04032F11 RID: 208657
		[Token(Token = "0x4032F11")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x04032F12 RID: 208658
		[Token(Token = "0x4032F12")]
		[FieldOffset(Offset = "0x28")]
		public bool hasStack;

		// Token: 0x04032F13 RID: 208659
		[Token(Token = "0x4032F13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04032F14 RID: 208660
		[Token(Token = "0x4032F14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
