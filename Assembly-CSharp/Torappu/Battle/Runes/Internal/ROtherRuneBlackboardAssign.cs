using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002916 RID: 10518
	[Token(Token = "0x2002916")]
	public class ROtherRuneBlackboardAssign : BasicPreprocessRuneDataRune
	{
		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x06011710 RID: 71440 RVA: 0x0006B490 File Offset: 0x00069690
		[Token(Token = "0x1700268E")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011710")]
			[Address(RVA = "0x944940", Offset = "0x943540", VA = "0x180944940", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011711 RID: 71441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011711")]
		[Address(RVA = "0x944580", Offset = "0x943180", VA = "0x180944580", Slot = "14")]
		public override void PreprocessRuneData(IEnumerable<Rune> runes)
		{
		}

		// Token: 0x06011712 RID: 71442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011712")]
		[Address(RVA = "0x9448A0", Offset = "0x9434A0", VA = "0x1809448A0")]
		public ROtherRuneBlackboardAssign()
		{
		}

		// Token: 0x06011713 RID: 71443 RVA: 0x0006B4A8 File Offset: 0x000696A8
		[Token(Token = "0x6011713")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x06011714 RID: 71444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011714")]
		[Address(RVA = "0x9440B0", Offset = "0x942CB0", VA = "0x1809440B0")]
		private void <>xLuaBaseProxy_PreprocessRuneData(IEnumerable<Rune> P0)
		{
		}

		// Token: 0x040137B4 RID: 79796
		[Token(Token = "0x40137B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x040137B5 RID: 79797
		[Token(Token = "0x40137B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessRuneData;

		// Token: 0x040137B6 RID: 79798
		[Token(Token = "0x40137B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
