using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002908 RID: 10504
	[Token(Token = "0x2002908")]
	public class CDynamicAbilityNew : BasicCharacterRune
	{
		// Token: 0x060116D8 RID: 71384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116D8")]
		[Address(RVA = "0x938D50", Offset = "0x937950", VA = "0x180938D50", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116D9 RID: 71385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116D9")]
		[Address(RVA = "0x938F40", Offset = "0x937B40", VA = "0x180938F40")]
		public CDynamicAbilityNew()
		{
		}

		// Token: 0x04013783 RID: 79747
		[Token(Token = "0x4013783")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013784 RID: 79748
		[Token(Token = "0x4013784")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
