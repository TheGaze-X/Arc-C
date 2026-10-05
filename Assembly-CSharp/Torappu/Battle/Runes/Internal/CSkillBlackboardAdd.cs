using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F5 RID: 10485
	[Token(Token = "0x20028F5")]
	public class CSkillBlackboardAdd : BasicCharacterRune
	{
		// Token: 0x0601169F RID: 71327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601169F")]
		[Address(RVA = "0x939800", Offset = "0x938400", VA = "0x180939800", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116A0 RID: 71328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A0")]
		[Address(RVA = "0x9398C0", Offset = "0x9384C0", VA = "0x1809398C0")]
		public CSkillBlackboardAdd()
		{
		}

		// Token: 0x04013751 RID: 79697
		[Token(Token = "0x4013751")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013752 RID: 79698
		[Token(Token = "0x4013752")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
