using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019F1 RID: 6641
	[Token(Token = "0x20019F1")]
	public struct ThemeRecentAcquireTimeComparer : IDIYItemViewComparer
	{
		// Token: 0x0600A6BA RID: 42682 RVA: 0x00040698 File Offset: 0x0003E898
		[Token(Token = "0x600A6BA")]
		[Address(RVA = "0x3226B40", Offset = "0x3225740", VA = "0x183226B40")]
		private static long _GetThemeRecentAquireTime(DIYItemViewData itemViewData, DIYSortMethodViewModel model)
		{
			return 0L;
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x000406B0 File Offset: 0x0003E8B0
		[Token(Token = "0x600A6BB")]
		[Address(RVA = "0x3226A00", Offset = "0x3225600", VA = "0x183226A00", Slot = "4")]
		public int Compare(DIYItemViewData x, DIYItemViewData y, DIYSortMethodViewModel model)
		{
			return 0;
		}
	}
}
