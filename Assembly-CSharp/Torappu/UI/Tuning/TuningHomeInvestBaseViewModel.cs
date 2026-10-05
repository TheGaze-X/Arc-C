using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CAC RID: 15532
	[Token(Token = "0x2003CAC")]
	public class TuningHomeInvestBaseViewModel : IHotfixable
	{
		// Token: 0x060183CF RID: 99279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183CF")]
		[Address(RVA = "0x10BBFA0", Offset = "0x10BABA0", VA = "0x1810BBFA0")]
		public TuningHomeInvestBaseViewModel()
		{
		}

		// Token: 0x0401D8D0 RID: 121040
		[Token(Token = "0x401D8D0")]
		[FieldOffset(Offset = "0x10")]
		public string imgName;

		// Token: 0x0401D8D1 RID: 121041
		[Token(Token = "0x401D8D1")]
		[FieldOffset(Offset = "0x18")]
		public string investId;

		// Token: 0x0401D8D2 RID: 121042
		[Token(Token = "0x401D8D2")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0401D8D3 RID: 121043
		[Token(Token = "0x401D8D3")]
		[FieldOffset(Offset = "0x28")]
		public UIItemViewModel rewardItem;

		// Token: 0x0401D8D4 RID: 121044
		[Token(Token = "0x401D8D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
