using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F21 RID: 24353
	[Token(Token = "0x2005F21")]
	public class CharacterLvlupWheelItemViewModel : IHotfixable
	{
		// Token: 0x0602346F RID: 144495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602346F")]
		[Address(RVA = "0x1DCC720", Offset = "0x1DCB320", VA = "0x181DCC720")]
		public CharacterLvlupWheelItemViewModel()
		{
		}

		// Token: 0x04030A18 RID: 199192
		[Token(Token = "0x4030A18")]
		[FieldOffset(Offset = "0x10")]
		public int number;

		// Token: 0x04030A19 RID: 199193
		[Token(Token = "0x4030A19")]
		[FieldOffset(Offset = "0x14")]
		public bool isAttainable;

		// Token: 0x04030A1A RID: 199194
		[Token(Token = "0x4030A1A")]
		[FieldOffset(Offset = "0x15")]
		public bool isMaxLevel;

		// Token: 0x04030A1B RID: 199195
		[Token(Token = "0x4030A1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
