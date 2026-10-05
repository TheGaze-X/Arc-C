using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073B4 RID: 29620
	[Token(Token = "0x20073B4")]
	public class Act42D0RewardAreaModelComparer : IComparer<KeyValuePair<string, Act42D0RewardAreaViewModel>>, IHotfixable
	{
		// Token: 0x06029DB4 RID: 171444 RVA: 0x000D6CE0 File Offset: 0x000D4EE0
		[Token(Token = "0x6029DB4")]
		[Address(RVA = "0x2573280", Offset = "0x2571E80", VA = "0x182573280", Slot = "4")]
		public int Compare(KeyValuePair<string, Act42D0RewardAreaViewModel> x, KeyValuePair<string, Act42D0RewardAreaViewModel> y)
		{
			return 0;
		}

		// Token: 0x06029DB5 RID: 171445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DB5")]
		[Address(RVA = "0x2573350", Offset = "0x2571F50", VA = "0x182573350")]
		public Act42D0RewardAreaModelComparer()
		{
		}

		// Token: 0x0403BFC1 RID: 245697
		[Token(Token = "0x403BFC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0403BFC2 RID: 245698
		[Token(Token = "0x403BFC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
