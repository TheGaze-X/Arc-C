using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200737F RID: 29567
	[Token(Token = "0x200737F")]
	public class Act42D0EffectBranchViewModelComparer : IComparer<KeyValuePair<string, Act42D0EffectBranchViewModel>>, IHotfixable
	{
		// Token: 0x06029CD4 RID: 171220 RVA: 0x000D6998 File Offset: 0x000D4B98
		[Token(Token = "0x6029CD4")]
		[Address(RVA = "0x2557DB0", Offset = "0x25569B0", VA = "0x182557DB0", Slot = "4")]
		public int Compare(KeyValuePair<string, Act42D0EffectBranchViewModel> x, KeyValuePair<string, Act42D0EffectBranchViewModel> y)
		{
			return 0;
		}

		// Token: 0x06029CD5 RID: 171221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CD5")]
		[Address(RVA = "0x2557E90", Offset = "0x2556A90", VA = "0x182557E90")]
		public Act42D0EffectBranchViewModelComparer()
		{
		}

		// Token: 0x0403BDBD RID: 245181
		[Token(Token = "0x403BDBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0403BDBE RID: 245182
		[Token(Token = "0x403BDBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
