using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019F6 RID: 6646
	[Token(Token = "0x20019F6")]
	public struct FurnitureGroupIdComparer : IDIYItemViewComparer
	{
		// Token: 0x0600A6C4 RID: 42692 RVA: 0x00040788 File Offset: 0x0003E988
		[Token(Token = "0x600A6C4")]
		[Address(RVA = "0x3224680", Offset = "0x3223280", VA = "0x183224680")]
		private static int _GetFurnitureGroupSortId(IDIYItem furnitureData)
		{
			return 0;
		}

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x000407A0 File Offset: 0x0003E9A0
		[Token(Token = "0x600A6C5")]
		[Address(RVA = "0x3224540", Offset = "0x3223140", VA = "0x183224540", Slot = "4")]
		public int Compare(DIYItemViewData x, DIYItemViewData y, DIYSortMethodViewModel model)
		{
			return 0;
		}
	}
}
