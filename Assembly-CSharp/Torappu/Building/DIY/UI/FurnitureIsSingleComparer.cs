using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019F7 RID: 6647
	[Token(Token = "0x20019F7")]
	public struct FurnitureIsSingleComparer : IDIYItemViewComparer
	{
		// Token: 0x0600A6C6 RID: 42694 RVA: 0x000407B8 File Offset: 0x0003E9B8
		[Token(Token = "0x600A6C6")]
		[Address(RVA = "0x3224920", Offset = "0x3223520", VA = "0x183224920")]
		private static int _IsFurnitureGroupSingle(IDIYItem furnitureData)
		{
			return 0;
		}

		// Token: 0x0600A6C7 RID: 42695 RVA: 0x000407D0 File Offset: 0x0003E9D0
		[Token(Token = "0x600A6C7")]
		[Address(RVA = "0x3224750", Offset = "0x3223350", VA = "0x183224750", Slot = "4")]
		public int Compare(DIYItemViewData x, DIYItemViewData y, DIYSortMethodViewModel model)
		{
			return 0;
		}
	}
}
