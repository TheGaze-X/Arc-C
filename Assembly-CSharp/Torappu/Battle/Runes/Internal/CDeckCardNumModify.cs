using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F1 RID: 10481
	[Token(Token = "0x20028F1")]
	public class CDeckCardNumModify : BasicCharacterRune
	{
		// Token: 0x06011693 RID: 71315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011693")]
		[Address(RVA = "0x938B90", Offset = "0x937790", VA = "0x180938B90", Slot = "16")]
		protected override void OnInit()
		{
		}

		// Token: 0x06011694 RID: 71316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011694")]
		[Address(RVA = "0x938B10", Offset = "0x937710", VA = "0x180938B10", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011695 RID: 71317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011695")]
		[Address(RVA = "0x938CB0", Offset = "0x9378B0", VA = "0x180938CB0")]
		public CDeckCardNumModify()
		{
		}

		// Token: 0x06011696 RID: 71318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011696")]
		[Address(RVA = "0x936420", Offset = "0x935020", VA = "0x180936420")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04013745 RID: 79685
		[Token(Token = "0x4013745")]
		[FieldOffset(Offset = "0x20")]
		private int m_visitCounter;

		// Token: 0x04013746 RID: 79686
		[Token(Token = "0x4013746")]
		[FieldOffset(Offset = "0x24")]
		private int m_decreaseNum;

		// Token: 0x04013747 RID: 79687
		[Token(Token = "0x4013747")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013748 RID: 79688
		[Token(Token = "0x4013748")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013749 RID: 79689
		[Token(Token = "0x4013749")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
