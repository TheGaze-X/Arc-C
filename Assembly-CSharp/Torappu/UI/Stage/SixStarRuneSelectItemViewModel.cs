using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006843 RID: 26691
	[Token(Token = "0x2006843")]
	public class SixStarRuneSelectItemViewModel : IHotfixable
	{
		// Token: 0x0602637C RID: 156540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602637C")]
		[Address(RVA = "0x214ADB0", Offset = "0x21499B0", VA = "0x18214ADB0")]
		public SixStarRuneSelectItemViewModel()
		{
		}

		// Token: 0x04035DEC RID: 220652
		[Token(Token = "0x4035DEC")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04035DED RID: 220653
		[Token(Token = "0x4035DED")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04035DEE RID: 220654
		[Token(Token = "0x4035DEE")]
		[FieldOffset(Offset = "0x1C")]
		public bool isSelected;

		// Token: 0x04035DEF RID: 220655
		[Token(Token = "0x4035DEF")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04035DF0 RID: 220656
		[Token(Token = "0x4035DF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
