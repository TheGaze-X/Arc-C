using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BFC RID: 7164
	[Token(Token = "0x2001BFC")]
	public struct WorkResult
	{
		// Token: 0x0600B294 RID: 45716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B294")]
		[Address(RVA = "0x32EA880", Offset = "0x32E9480", VA = "0x1832EA880")]
		public WorkResult(WorkshopCheckResult checkResult, UIItemViewModel outcome, List<UIItemViewModel> extraList, long recoverCost)
		{
		}

		// Token: 0x0400ADC2 RID: 44482
		[Token(Token = "0x400ADC2")]
		[FieldOffset(Offset = "0x0")]
		public WorkshopCheckResult checkResult;

		// Token: 0x0400ADC3 RID: 44483
		[Token(Token = "0x400ADC3")]
		[FieldOffset(Offset = "0x8")]
		public UIItemViewModel outcome;

		// Token: 0x0400ADC4 RID: 44484
		[Token(Token = "0x400ADC4")]
		[FieldOffset(Offset = "0x10")]
		public List<UIItemViewModel> extraList;

		// Token: 0x0400ADC5 RID: 44485
		[Token(Token = "0x400ADC5")]
		[FieldOffset(Offset = "0x18")]
		public long recoverCost;
	}
}
