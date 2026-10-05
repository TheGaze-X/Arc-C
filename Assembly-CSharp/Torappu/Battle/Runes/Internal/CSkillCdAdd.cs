using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F4 RID: 10484
	[Token(Token = "0x20028F4")]
	public class CSkillCdAdd : BasicCharacterRune
	{
		// Token: 0x0601169D RID: 71325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601169D")]
		[Address(RVA = "0x939AC0", Offset = "0x9386C0", VA = "0x180939AC0", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x0601169E RID: 71326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601169E")]
		[Address(RVA = "0x939C50", Offset = "0x938850", VA = "0x180939C50")]
		public CSkillCdAdd()
		{
		}

		// Token: 0x0401374F RID: 79695
		[Token(Token = "0x401374F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013750 RID: 79696
		[Token(Token = "0x4013750")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
