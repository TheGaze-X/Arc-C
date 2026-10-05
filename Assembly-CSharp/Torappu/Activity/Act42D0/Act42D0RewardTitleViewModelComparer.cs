using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073AF RID: 29615
	[Token(Token = "0x20073AF")]
	public class Act42D0RewardTitleViewModelComparer : IComparer<KeyValuePair<string, Act42D0RewardTitleViewModel>>, IHotfixable
	{
		// Token: 0x06029DAC RID: 171436 RVA: 0x000D6C98 File Offset: 0x000D4E98
		[Token(Token = "0x6029DAC")]
		[Address(RVA = "0x2574EE0", Offset = "0x2573AE0", VA = "0x182574EE0", Slot = "4")]
		public int Compare(KeyValuePair<string, Act42D0RewardTitleViewModel> x, KeyValuePair<string, Act42D0RewardTitleViewModel> y)
		{
			return 0;
		}

		// Token: 0x06029DAD RID: 171437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DAD")]
		[Address(RVA = "0x2574FB0", Offset = "0x2573BB0", VA = "0x182574FB0")]
		public Act42D0RewardTitleViewModelComparer()
		{
		}

		// Token: 0x0403BFB3 RID: 245683
		[Token(Token = "0x403BFB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0403BFB4 RID: 245684
		[Token(Token = "0x403BFB4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
