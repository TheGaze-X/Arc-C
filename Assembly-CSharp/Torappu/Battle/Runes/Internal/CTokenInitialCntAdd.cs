using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F2 RID: 10482
	[Token(Token = "0x20028F2")]
	public class CTokenInitialCntAdd : BasicCharacterRune
	{
		// Token: 0x06011697 RID: 71319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011697")]
		[Address(RVA = "0x93A230", Offset = "0x938E30", VA = "0x18093A230", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011698 RID: 71320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011698")]
		[Address(RVA = "0x93A310", Offset = "0x938F10", VA = "0x18093A310")]
		public CTokenInitialCntAdd()
		{
		}

		// Token: 0x0401374A RID: 79690
		[Token(Token = "0x401374A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401374B RID: 79691
		[Token(Token = "0x401374B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
