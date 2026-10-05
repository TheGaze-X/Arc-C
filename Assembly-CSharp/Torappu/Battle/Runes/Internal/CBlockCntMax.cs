using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F8 RID: 10488
	[Token(Token = "0x20028F8")]
	public class CBlockCntMax : BasicCharacterRune
	{
		// Token: 0x060116A5 RID: 71333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A5")]
		[Address(RVA = "0x938190", Offset = "0x936D90", VA = "0x180938190", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116A6 RID: 71334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A6")]
		[Address(RVA = "0x938310", Offset = "0x936F10", VA = "0x180938310")]
		public CBlockCntMax()
		{
		}

		// Token: 0x04013757 RID: 79703
		[Token(Token = "0x4013757")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013758 RID: 79704
		[Token(Token = "0x4013758")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
