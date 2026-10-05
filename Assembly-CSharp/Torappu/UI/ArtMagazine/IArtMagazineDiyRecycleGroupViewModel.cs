using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006599 RID: 26009
	[Token(Token = "0x2006599")]
	public interface IArtMagazineDiyRecycleGroupViewModel
	{
		// Token: 0x17005873 RID: 22643
		// (get) Token: 0x06025652 RID: 153170
		[Token(Token = "0x17005873")]
		List<IArtMagazineDiyItemViewModel> displayItemList { [Token(Token = "0x6025652")] get; }

		// Token: 0x17005874 RID: 22644
		// (get) Token: 0x06025653 RID: 153171
		[Token(Token = "0x17005874")]
		HashSet<string> selectedItem { [Token(Token = "0x6025653")] get; }

		// Token: 0x17005875 RID: 22645
		// (get) Token: 0x06025654 RID: 153172
		[Token(Token = "0x17005875")]
		int itemMaxSelectNum { [Token(Token = "0x6025654")] get; }

		// Token: 0x06025655 RID: 153173
		[Token(Token = "0x6025655")]
		void LoadData(string leafId);

		// Token: 0x06025656 RID: 153174
		[Token(Token = "0x6025656")]
		void RefreshData(ArtMagazineLeafData leafData);

		// Token: 0x06025657 RID: 153175
		[Token(Token = "0x6025657")]
		bool SelectItem(string id);

		// Token: 0x06025658 RID: 153176
		[Token(Token = "0x6025658")]
		void SwitchItemByLeafView(string itemId, ItemType itemType, int oldTemplateId, int newTemplateId);

		// Token: 0x06025659 RID: 153177
		[Token(Token = "0x6025659")]
		void UnselectItem(string id);

		// Token: 0x0602565A RID: 153178
		[Token(Token = "0x602565A")]
		void UnselectItemByLeafView(string itemId, ItemType itemType, int templateId);

		// Token: 0x0602565B RID: 153179
		[Token(Token = "0x602565B")]
		void UnselectAll();

		// Token: 0x0602565C RID: 153180
		[Token(Token = "0x602565C")]
		bool IsItemSelected(string itemId, ItemType itemType, int templateId);

		// Token: 0x0602565D RID: 153181
		[Token(Token = "0x602565D")]
		void SetSorter(SorterType sorterType);

		// Token: 0x0602565E RID: 153182
		[Token(Token = "0x602565E")]
		void SetFilter(FilterGroupType filterGroupType, object filterParam);
	}
}
