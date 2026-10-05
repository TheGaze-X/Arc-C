using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006655 RID: 26197
	[Token(Token = "0x2006655")]
	public interface IArtGalleryListModeGroupSetViewModel : IHotfixable
	{
		// Token: 0x17005921 RID: 22817
		// (get) Token: 0x060259FD RID: 154109
		[Token(Token = "0x17005921")]
		ArtGalleryTabType groupSetType { [Token(Token = "0x60259FD")] get; }

		// Token: 0x17005922 RID: 22818
		// (get) Token: 0x060259FE RID: 154110
		[Token(Token = "0x17005922")]
		List<IArtGalleryListModeGroupViewModel> groupViewModels { [Token(Token = "0x60259FE")] get; }

		// Token: 0x17005923 RID: 22819
		// (get) Token: 0x060259FF RID: 154111
		[Token(Token = "0x17005923")]
		int refreshSeq { [Token(Token = "0x60259FF")] get; }

		// Token: 0x17005924 RID: 22820
		// (get) Token: 0x06025A00 RID: 154112
		[Token(Token = "0x17005924")]
		string currentSelectItemId { [Token(Token = "0x6025A00")] get; }

		// Token: 0x06025A01 RID: 154113
		[Token(Token = "0x6025A01")]
		void LoadData(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput input);

		// Token: 0x06025A02 RID: 154114
		[Token(Token = "0x6025A02")]
		void RefreshData(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput input);

		// Token: 0x06025A03 RID: 154115
		[Token(Token = "0x6025A03")]
		bool CheckIfEmpty();

		// Token: 0x02006656 RID: 26198
		[Token(Token = "0x2006656")]
		public struct GroupViewModelInput : IHotfixable
		{
			// Token: 0x04034DAB RID: 216491
			[Token(Token = "0x4034DAB")]
			[FieldOffset(Offset = "0x0")]
			public ArtGalleryDisplayViewModel.ArtGalleryShuffleRule curShuffleRule;

			// Token: 0x04034DAC RID: 216492
			[Token(Token = "0x4034DAC")]
			[FieldOffset(Offset = "0x8")]
			public ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam curSelectParam;

			// Token: 0x04034DAD RID: 216493
			[Token(Token = "0x4034DAD")]
			[FieldOffset(Offset = "0x18")]
			public long curTs;
		}
	}
}
