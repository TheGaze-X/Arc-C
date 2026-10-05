using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CD9 RID: 27865
	[Token(Token = "0x2006CD9")]
	public class TemplateActivityCoinViewModel : TemplateActivityViewModel
	{
		// Token: 0x06027BEC RID: 162796 RVA: 0x000CF348 File Offset: 0x000CD548
		[Token(Token = "0x6027BEC")]
		[Address(RVA = "0x22F9D10", Offset = "0x22F8910", VA = "0x1822F9D10")]
		public int GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06027BED RID: 162797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BED")]
		[Address(RVA = "0x22F9D80", Offset = "0x22F8980", VA = "0x1822F9D80")]
		public TemplateActivityCoinViewModel(object param)
		{
		}

		// Token: 0x040385E3 RID: 230883
		[Token(Token = "0x40385E3")]
		[FieldOffset(Offset = "0x20")]
		public Func<int> getCoinFunc;

		// Token: 0x040385E4 RID: 230884
		[Token(Token = "0x40385E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCoinCount;

		// Token: 0x040385E5 RID: 230885
		[Token(Token = "0x40385E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CDA RID: 27866
		[Token(Token = "0x2006CDA")]
		public class Input
		{
			// Token: 0x06027BEE RID: 162798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BEE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040385E6 RID: 230886
			[Token(Token = "0x40385E6")]
			[FieldOffset(Offset = "0x10")]
			public Func<int> getCoinFunc;
		}
	}
}
