using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F9 RID: 10489
	[Token(Token = "0x20028F9")]
	public class CTalentBlackbAssign : BasicCharacterRune
	{
		// Token: 0x060116A7 RID: 71335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A7")]
		[Address(RVA = "0x939F80", Offset = "0x938B80", VA = "0x180939F80", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116A8 RID: 71336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A8")]
		[Address(RVA = "0x93A190", Offset = "0x938D90", VA = "0x18093A190")]
		public CTalentBlackbAssign()
		{
		}

		// Token: 0x04013759 RID: 79705
		[Token(Token = "0x4013759")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401375A RID: 79706
		[Token(Token = "0x401375A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
