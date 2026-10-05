using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200752C RID: 29996
	[Token(Token = "0x200752C")]
	public class Act25sideAreaViewModelComparer : IComparer<KeyValuePair<string, Act25sideAreaViewModel>>, IHotfixable
	{
		// Token: 0x0602A432 RID: 173106 RVA: 0x000D7D60 File Offset: 0x000D5F60
		[Token(Token = "0x602A432")]
		[Address(RVA = "0x25DAEC0", Offset = "0x25D9AC0", VA = "0x1825DAEC0", Slot = "4")]
		public int Compare(KeyValuePair<string, Act25sideAreaViewModel> x, KeyValuePair<string, Act25sideAreaViewModel> y)
		{
			return 0;
		}

		// Token: 0x0602A433 RID: 173107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A433")]
		[Address(RVA = "0x25DB040", Offset = "0x25D9C40", VA = "0x1825DB040")]
		public Act25sideAreaViewModelComparer()
		{
		}

		// Token: 0x0403CC2B RID: 248875
		[Token(Token = "0x403CC2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0403CC2C RID: 248876
		[Token(Token = "0x403CC2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
