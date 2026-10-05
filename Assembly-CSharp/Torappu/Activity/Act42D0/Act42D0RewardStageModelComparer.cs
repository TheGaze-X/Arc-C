using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073B2 RID: 29618
	[Token(Token = "0x20073B2")]
	public class Act42D0RewardStageModelComparer : IComparer<KeyValuePair<string, Act42D0RewardStageViewModel>>, IHotfixable
	{
		// Token: 0x06029DB1 RID: 171441 RVA: 0x000D6CC8 File Offset: 0x000D4EC8
		[Token(Token = "0x6029DB1")]
		[Address(RVA = "0x2573E70", Offset = "0x2572A70", VA = "0x182573E70", Slot = "4")]
		public int Compare(KeyValuePair<string, Act42D0RewardStageViewModel> x, KeyValuePair<string, Act42D0RewardStageViewModel> y)
		{
			return 0;
		}

		// Token: 0x06029DB2 RID: 171442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DB2")]
		[Address(RVA = "0x2573F40", Offset = "0x2572B40", VA = "0x182573F40")]
		public Act42D0RewardStageModelComparer()
		{
		}

		// Token: 0x0403BFBB RID: 245691
		[Token(Token = "0x403BFBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0403BFBC RID: 245692
		[Token(Token = "0x403BFBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
