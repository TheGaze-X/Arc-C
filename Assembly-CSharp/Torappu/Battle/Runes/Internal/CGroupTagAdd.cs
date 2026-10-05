using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028FA RID: 10490
	[Token(Token = "0x20028FA")]
	public class CGroupTagAdd : BasicCharacterRune
	{
		// Token: 0x060116A9 RID: 71337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116A9")]
		[Address(RVA = "0x939170", Offset = "0x937D70", VA = "0x180939170", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116AA RID: 71338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116AA")]
		[Address(RVA = "0x9392E0", Offset = "0x937EE0", VA = "0x1809392E0")]
		public CGroupTagAdd()
		{
		}

		// Token: 0x0401375B RID: 79707
		[Token(Token = "0x401375B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401375C RID: 79708
		[Token(Token = "0x401375C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
