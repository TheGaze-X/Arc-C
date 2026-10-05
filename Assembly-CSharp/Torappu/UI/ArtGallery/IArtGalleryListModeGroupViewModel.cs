using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006657 RID: 26199
	[Token(Token = "0x2006657")]
	public interface IArtGalleryListModeGroupViewModel : IHotfixable
	{
		// Token: 0x17005925 RID: 22821
		// (get) Token: 0x06025A04 RID: 154116
		[Token(Token = "0x17005925")]
		string groupType { [Token(Token = "0x6025A04")] get; }

		// Token: 0x17005926 RID: 22822
		// (get) Token: 0x06025A05 RID: 154117
		[Token(Token = "0x17005926")]
		bool isEmpty { [Token(Token = "0x6025A05")] get; }

		// Token: 0x17005927 RID: 22823
		// (get) Token: 0x06025A06 RID: 154118
		[Token(Token = "0x17005927")]
		string title { [Token(Token = "0x6025A06")] get; }

		// Token: 0x17005928 RID: 22824
		// (get) Token: 0x06025A07 RID: 154119
		[Token(Token = "0x17005928")]
		int sortId { [Token(Token = "0x6025A07")] get; }

		// Token: 0x17005929 RID: 22825
		// (get) Token: 0x06025A08 RID: 154120
		[Token(Token = "0x17005929")]
		int refreshSeq { [Token(Token = "0x6025A08")] get; }

		// Token: 0x1700592A RID: 22826
		// (get) Token: 0x06025A09 RID: 154121
		[Token(Token = "0x1700592A")]
		List<IArtGalleryDisplayItemViewModel> shuffledItemModels { [Token(Token = "0x6025A09")] get; }

		// Token: 0x06025A0A RID: 154122
		[Token(Token = "0x6025A0A")]
		void LoadData(ArtGalleryGroupData groupData, IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput);

		// Token: 0x06025A0B RID: 154123
		[Token(Token = "0x6025A0B")]
		void RefreshData(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput);
	}
}
