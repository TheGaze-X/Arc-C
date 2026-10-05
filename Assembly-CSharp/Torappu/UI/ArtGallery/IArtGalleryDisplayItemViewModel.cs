using System;
using Il2CppDummyDll;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006653 RID: 26195
	[Token(Token = "0x2006653")]
	public interface IArtGalleryDisplayItemViewModel : IHotfixable
	{
		// Token: 0x17005916 RID: 22806
		// (get) Token: 0x060259EF RID: 154095
		[Token(Token = "0x17005916")]
		string itemName { [Token(Token = "0x60259EF")] get; }

		// Token: 0x17005917 RID: 22807
		// (get) Token: 0x060259F0 RID: 154096
		[Token(Token = "0x17005917")]
		bool isEmpty { [Token(Token = "0x60259F0")] get; }

		// Token: 0x17005918 RID: 22808
		// (get) Token: 0x060259F1 RID: 154097
		[Token(Token = "0x17005918")]
		bool isCurSelect { [Token(Token = "0x60259F1")] get; }

		// Token: 0x17005919 RID: 22809
		// (get) Token: 0x060259F2 RID: 154098
		[Token(Token = "0x17005919")]
		string itemGroupType { [Token(Token = "0x60259F2")] get; }

		// Token: 0x1700591A RID: 22810
		// (get) Token: 0x060259F3 RID: 154099
		[Token(Token = "0x1700591A")]
		ItemType itemType { [Token(Token = "0x60259F3")] get; }

		// Token: 0x1700591B RID: 22811
		// (get) Token: 0x060259F4 RID: 154100
		[Token(Token = "0x1700591B")]
		int itemSortId { [Token(Token = "0x60259F4")] get; }

		// Token: 0x1700591C RID: 22812
		// (get) Token: 0x060259F5 RID: 154101
		[Token(Token = "0x1700591C")]
		string itemId { [Token(Token = "0x60259F5")] get; }

		// Token: 0x1700591D RID: 22813
		// (get) Token: 0x060259F6 RID: 154102
		[Token(Token = "0x1700591D")]
		long availTs { [Token(Token = "0x60259F6")] get; }

		// Token: 0x1700591E RID: 22814
		// (get) Token: 0x060259F7 RID: 154103
		[Token(Token = "0x1700591E")]
		bool isSecret { [Token(Token = "0x60259F7")] get; }

		// Token: 0x1700591F RID: 22815
		// (get) Token: 0x060259F8 RID: 154104
		[Token(Token = "0x1700591F")]
		bool isLimit { [Token(Token = "0x60259F8")] get; }

		// Token: 0x17005920 RID: 22816
		// (get) Token: 0x060259F9 RID: 154105
		[Token(Token = "0x17005920")]
		string itemDesc { [Token(Token = "0x60259F9")] get; }

		// Token: 0x060259FA RID: 154106
		[Token(Token = "0x60259FA")]
		void LoadData(ArtGalleryItemData itemData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam);

		// Token: 0x060259FB RID: 154107
		[Token(Token = "0x60259FB")]
		void RefreshData(IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam);

		// Token: 0x060259FC RID: 154108
		[Token(Token = "0x60259FC")]
		bool CheckCanItemShow(ArtGalleryDisplayViewModel.ArtGalleryShuffleRule shuffleRule);

		// Token: 0x02006654 RID: 26196
		[Token(Token = "0x2006654")]
		public struct ItemRefreshParam : IHotfixable
		{
			// Token: 0x04034DA9 RID: 216489
			[Token(Token = "0x4034DA9")]
			[FieldOffset(Offset = "0x0")]
			public ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam itemSelectParam;

			// Token: 0x04034DAA RID: 216490
			[Token(Token = "0x4034DAA")]
			[FieldOffset(Offset = "0x10")]
			public long curTs;
		}
	}
}
