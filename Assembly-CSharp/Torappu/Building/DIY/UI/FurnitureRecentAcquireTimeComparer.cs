using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019F5 RID: 6645
	[Token(Token = "0x20019F5")]
	public struct FurnitureRecentAcquireTimeComparer : IDIYItemViewComparer
	{
		// Token: 0x0600A6C2 RID: 42690 RVA: 0x00040758 File Offset: 0x0003E958
		[Token(Token = "0x600A6C2")]
		[Address(RVA = "0x3224AD0", Offset = "0x32236D0", VA = "0x183224AD0")]
		private static long _GetFurnitureRecentAquireTime(IDIYItem furnitureData, DIYSortMethodViewModel model)
		{
			return 0L;
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x00040770 File Offset: 0x0003E970
		[Token(Token = "0x600A6C3")]
		[Address(RVA = "0x3224980", Offset = "0x3223580", VA = "0x183224980", Slot = "4")]
		public int Compare(DIYItemViewData x, DIYItemViewData y, DIYSortMethodViewModel model)
		{
			return 0;
		}
	}
}
