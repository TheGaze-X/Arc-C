using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x0200675E RID: 26462
	[Token(Token = "0x200675E")]
	public class HalfIdleUIBattleEquipItemViewModel : IHotfixable
	{
		// Token: 0x06025F80 RID: 155520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F80")]
		[Address(RVA = "0x20F18A0", Offset = "0x20F04A0", VA = "0x1820F18A0")]
		public void Reset()
		{
		}

		// Token: 0x06025F81 RID: 155521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F81")]
		[Address(RVA = "0x20F1910", Offset = "0x20F0510", VA = "0x1820F1910")]
		public HalfIdleUIBattleEquipItemViewModel()
		{
		}

		// Token: 0x040356A2 RID: 218786
		[Token(Token = "0x40356A2")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x040356A3 RID: 218787
		[Token(Token = "0x40356A3")]
		[FieldOffset(Offset = "0x14")]
		public uint equipUid;

		// Token: 0x040356A4 RID: 218788
		[Token(Token = "0x40356A4")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleEquipData equipData;

		// Token: 0x040356A5 RID: 218789
		[Token(Token = "0x40356A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040356A6 RID: 218790
		[Token(Token = "0x40356A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
