using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028EA RID: 10474
	[Token(Token = "0x20028EA")]
	public class CAttributesAdd : BasicCharacterRune
	{
		// Token: 0x0601167F RID: 71295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601167F")]
		[Address(RVA = "0x937B90", Offset = "0x936790", VA = "0x180937B90", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011680 RID: 71296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011680")]
		[Address(RVA = "0x937C20", Offset = "0x936820", VA = "0x180937C20")]
		public CAttributesAdd()
		{
		}

		// Token: 0x04013732 RID: 79666
		[Token(Token = "0x4013732")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013733 RID: 79667
		[Token(Token = "0x4013733")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
