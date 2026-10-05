using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028EB RID: 10475
	[Token(Token = "0x20028EB")]
	public class CCostMul : BasicCharacterRune
	{
		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x06011681 RID: 71297 RVA: 0x0006B178 File Offset: 0x00069378
		[Token(Token = "0x1700267D")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011681")]
			[Address(RVA = "0x938870", Offset = "0x937470", VA = "0x180938870", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011682 RID: 71298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011682")]
		[Address(RVA = "0x938610", Offset = "0x937210", VA = "0x180938610", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011683 RID: 71299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011683")]
		[Address(RVA = "0x9387D0", Offset = "0x9373D0", VA = "0x1809387D0")]
		public CCostMul()
		{
		}

		// Token: 0x06011684 RID: 71300 RVA: 0x0006B190 File Offset: 0x00069390
		[Token(Token = "0x6011684")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013734 RID: 79668
		[Token(Token = "0x4013734")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013735 RID: 79669
		[Token(Token = "0x4013735")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x04013736 RID: 79670
		[Token(Token = "0x4013736")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
