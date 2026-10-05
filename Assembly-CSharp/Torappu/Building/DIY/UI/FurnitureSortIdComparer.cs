using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019F4 RID: 6644
	[Token(Token = "0x20019F4")]
	public struct FurnitureSortIdComparer : IDIYItemViewComparer
	{
		// Token: 0x0600A6C0 RID: 42688 RVA: 0x00040728 File Offset: 0x0003E928
		[Token(Token = "0x600A6C0")]
		[Address(RVA = "0x3224D60", Offset = "0x3223960", VA = "0x183224D60")]
		private static int _GetFurnitureSortId(IDIYItem furnitureData)
		{
			return 0;
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x00040740 File Offset: 0x0003E940
		[Token(Token = "0x600A6C1")]
		[Address(RVA = "0x3224BB0", Offset = "0x32237B0", VA = "0x183224BB0", Slot = "4")]
		public int Compare(DIYItemViewData x, DIYItemViewData y, DIYSortMethodViewModel model)
		{
			return 0;
		}
	}
}
