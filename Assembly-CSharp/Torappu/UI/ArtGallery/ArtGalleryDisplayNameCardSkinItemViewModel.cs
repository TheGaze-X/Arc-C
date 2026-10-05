using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200664A RID: 26186
	[Token(Token = "0x200664A")]
	public class ArtGalleryDisplayNameCardSkinItemViewModel : ArtGalleryDisplayItemViewModelBase
	{
		// Token: 0x170058F9 RID: 22777
		// (get) Token: 0x060259A4 RID: 154020 RVA: 0x000C8790 File Offset: 0x000C6990
		[Token(Token = "0x170058F9")]
		public override ItemType itemType
		{
			[Token(Token = "0x60259A4")]
			[Address(RVA = "0x208C2F0", Offset = "0x208AEF0", VA = "0x18208C2F0", Slot = "19")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x060259A5 RID: 154021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259A5")]
		[Address(RVA = "0x208BF00", Offset = "0x208AB00", VA = "0x18208BF00", Slot = "21")]
		public override void LoadData(ArtGalleryItemData itemData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x060259A6 RID: 154022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259A6")]
		[Address(RVA = "0x208BD90", Offset = "0x208A990", VA = "0x18208BD90")]
		public void LoadDataFromNameCardData(NameCardV2SkinData nameCardV2SkinData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x060259A7 RID: 154023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259A7")]
		[Address(RVA = "0x208C070", Offset = "0x208AC70", VA = "0x18208C070")]
		private void _LoadBasicInfo(NameCardV2SkinData nameCardV2SkinData)
		{
		}

		// Token: 0x060259A8 RID: 154024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259A8")]
		[Address(RVA = "0x208C250", Offset = "0x208AE50", VA = "0x18208C250")]
		public ArtGalleryDisplayNameCardSkinItemViewModel()
		{
		}

		// Token: 0x060259A9 RID: 154025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259A9")]
		[Address(RVA = "0x2089A20", Offset = "0x2088620", VA = "0x182089A20")]
		private void <>xLuaBaseProxy_LoadData(ArtGalleryItemData P0, IArtGalleryDisplayItemViewModel.ItemRefreshParam P1)
		{
		}

		// Token: 0x04034D44 RID: 216388
		[Token(Token = "0x4034D44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04034D45 RID: 216389
		[Token(Token = "0x4034D45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034D46 RID: 216390
		[Token(Token = "0x4034D46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadDataFromNameCardData;

		// Token: 0x04034D47 RID: 216391
		[Token(Token = "0x4034D47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadBasicInfo;

		// Token: 0x04034D48 RID: 216392
		[Token(Token = "0x4034D48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
