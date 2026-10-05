using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007380 RID: 29568
	[Token(Token = "0x2007380")]
	public struct Act42D0EffectBranchViewModel
	{
		// Token: 0x0403BDBF RID: 245183
		[Token(Token = "0x403BDBF")]
		[FieldOffset(Offset = "0x0")]
		public ListDict<string, Act42D0EffectGroupViewModel> groups;

		// Token: 0x0403BDC0 RID: 245184
		[Token(Token = "0x403BDC0")]
		[FieldOffset(Offset = "0x8")]
		public int sortId;

		// Token: 0x0403BDC1 RID: 245185
		[Token(Token = "0x403BDC1")]
		[FieldOffset(Offset = "0x10")]
		public string branchName;
	}
}
