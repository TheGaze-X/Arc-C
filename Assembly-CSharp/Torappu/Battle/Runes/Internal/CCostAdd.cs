using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028EC RID: 10476
	[Token(Token = "0x20028EC")]
	public class CCostAdd : BasicCharacterRune
	{
		// Token: 0x06011685 RID: 71301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011685")]
		[Address(RVA = "0x9383B0", Offset = "0x936FB0", VA = "0x1809383B0", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011686 RID: 71302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011686")]
		[Address(RVA = "0x938570", Offset = "0x937170", VA = "0x180938570")]
		public CCostAdd()
		{
		}

		// Token: 0x04013737 RID: 79671
		[Token(Token = "0x4013737")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013738 RID: 79672
		[Token(Token = "0x4013738")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
