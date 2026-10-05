using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019EE RID: 6638
	[Token(Token = "0x20019EE")]
	public interface IDIYItemViewComparer
	{
		// Token: 0x0600A6B6 RID: 42678
		[Token(Token = "0x600A6B6")]
		int Compare(DIYItemViewData x, DIYItemViewData y, DIYSortMethodViewModel model);
	}
}
