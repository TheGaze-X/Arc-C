using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028EF RID: 10479
	[Token(Token = "0x20028EF")]
	public class CExcludedFromBattle : BasicCharacterRune
	{
		// Token: 0x0601168D RID: 71309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601168D")]
		[Address(RVA = "0x938FE0", Offset = "0x937BE0", VA = "0x180938FE0", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x0601168E RID: 71310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601168E")]
		[Address(RVA = "0x9390D0", Offset = "0x937CD0", VA = "0x1809390D0")]
		public CExcludedFromBattle()
		{
		}

		// Token: 0x0401373E RID: 79678
		[Token(Token = "0x401373E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401373F RID: 79679
		[Token(Token = "0x401373F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
