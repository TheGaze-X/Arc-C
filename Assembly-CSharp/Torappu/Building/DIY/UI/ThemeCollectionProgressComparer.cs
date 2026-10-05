using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019F3 RID: 6643
	[Token(Token = "0x20019F3")]
	public struct ThemeCollectionProgressComparer : IDIYItemViewComparer
	{
		// Token: 0x0600A6BE RID: 42686 RVA: 0x000406F8 File Offset: 0x0003E8F8
		[Token(Token = "0x600A6BE")]
		[Address(RVA = "0x3225E40", Offset = "0x3224A40", VA = "0x183225E40")]
		private static float _GetThemeCollectionProgress(DIYItemViewData themeData)
		{
			return 0f;
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x00040710 File Offset: 0x0003E910
		[Token(Token = "0x600A6BF")]
		[Address(RVA = "0x3225C60", Offset = "0x3224860", VA = "0x183225C60", Slot = "4")]
		public int Compare(DIYItemViewData x, DIYItemViewData y, DIYSortMethodViewModel model)
		{
			return 0;
		}
	}
}
