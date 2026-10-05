using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F6 RID: 10486
	[Token(Token = "0x20028F6")]
	public class CSkillBlackboardMul : BasicCharacterRune
	{
		// Token: 0x060116A1 RID: 71329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A1")]
		[Address(RVA = "0x939960", Offset = "0x938560", VA = "0x180939960", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116A2 RID: 71330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A2")]
		[Address(RVA = "0x939A20", Offset = "0x938620", VA = "0x180939A20")]
		public CSkillBlackboardMul()
		{
		}

		// Token: 0x04013753 RID: 79699
		[Token(Token = "0x4013753")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013754 RID: 79700
		[Token(Token = "0x4013754")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
