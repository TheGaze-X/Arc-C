using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059F2 RID: 23026
	[Token(Token = "0x20059F2")]
	public class CrisisV2TimeLimitItemModel : IHotfixable
	{
		// Token: 0x060218F0 RID: 137456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218F0")]
		[Address(RVA = "0x1C0DDF0", Offset = "0x1C0C9F0", VA = "0x181C0DDF0")]
		public CrisisV2TimeLimitItemModel()
		{
		}

		// Token: 0x0402DDC2 RID: 187842
		[Token(Token = "0x402DDC2")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel item;

		// Token: 0x0402DDC3 RID: 187843
		[Token(Token = "0x402DDC3")]
		[FieldOffset(Offset = "0x18")]
		public bool isTimeLimit;

		// Token: 0x0402DDC4 RID: 187844
		[Token(Token = "0x402DDC4")]
		[FieldOffset(Offset = "0x20")]
		public long rewardEndTime;

		// Token: 0x0402DDC5 RID: 187845
		[Token(Token = "0x402DDC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
