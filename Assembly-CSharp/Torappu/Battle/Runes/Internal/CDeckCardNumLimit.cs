using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F0 RID: 10480
	[Token(Token = "0x20028F0")]
	public class CDeckCardNumLimit : BasicCharacterRune
	{
		// Token: 0x0601168F RID: 71311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601168F")]
		[Address(RVA = "0x938950", Offset = "0x937550", VA = "0x180938950", Slot = "16")]
		protected override void OnInit()
		{
		}

		// Token: 0x06011690 RID: 71312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011690")]
		[Address(RVA = "0x9388D0", Offset = "0x9374D0", VA = "0x1809388D0", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011691 RID: 71313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011691")]
		[Address(RVA = "0x938A70", Offset = "0x937670", VA = "0x180938A70")]
		public CDeckCardNumLimit()
		{
		}

		// Token: 0x06011692 RID: 71314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011692")]
		[Address(RVA = "0x936420", Offset = "0x935020", VA = "0x180936420")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04013740 RID: 79680
		[Token(Token = "0x4013740")]
		[FieldOffset(Offset = "0x20")]
		private int m_visitCounter;

		// Token: 0x04013741 RID: 79681
		[Token(Token = "0x4013741")]
		[FieldOffset(Offset = "0x24")]
		private int m_limitNum;

		// Token: 0x04013742 RID: 79682
		[Token(Token = "0x4013742")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013743 RID: 79683
		[Token(Token = "0x4013743")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013744 RID: 79684
		[Token(Token = "0x4013744")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
