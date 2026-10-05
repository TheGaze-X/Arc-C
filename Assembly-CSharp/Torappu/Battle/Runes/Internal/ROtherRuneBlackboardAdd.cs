using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002917 RID: 10519
	[Token(Token = "0x2002917")]
	public class ROtherRuneBlackboardAdd : BasicPreprocessRuneDataRune
	{
		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x06011715 RID: 71445 RVA: 0x0006B4C0 File Offset: 0x000696C0
		[Token(Token = "0x1700268F")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011715")]
			[Address(RVA = "0x944520", Offset = "0x943120", VA = "0x180944520", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011716 RID: 71446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011716")]
		[Address(RVA = "0x944160", Offset = "0x942D60", VA = "0x180944160", Slot = "14")]
		public override void PreprocessRuneData(IEnumerable<Rune> runes)
		{
		}

		// Token: 0x06011717 RID: 71447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011717")]
		[Address(RVA = "0x944480", Offset = "0x943080", VA = "0x180944480")]
		public ROtherRuneBlackboardAdd()
		{
		}

		// Token: 0x06011718 RID: 71448 RVA: 0x0006B4D8 File Offset: 0x000696D8
		[Token(Token = "0x6011718")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x06011719 RID: 71449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011719")]
		[Address(RVA = "0x9440B0", Offset = "0x942CB0", VA = "0x1809440B0")]
		private void <>xLuaBaseProxy_PreprocessRuneData(IEnumerable<Rune> P0)
		{
		}

		// Token: 0x040137B7 RID: 79799
		[Token(Token = "0x40137B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x040137B8 RID: 79800
		[Token(Token = "0x40137B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessRuneData;

		// Token: 0x040137B9 RID: 79801
		[Token(Token = "0x40137B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
