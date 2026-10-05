using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006641 RID: 26177
	[Token(Token = "0x2006641")]
	public class ArtGalleryDisplayAvatarItemViewModel : ArtGalleryDisplayItemViewModelBase
	{
		// Token: 0x170058F3 RID: 22771
		// (get) Token: 0x06025987 RID: 153991 RVA: 0x000C86E8 File Offset: 0x000C68E8
		[Token(Token = "0x170058F3")]
		public override ItemType itemType
		{
			[Token(Token = "0x6025987")]
			[Address(RVA = "0x2089AF0", Offset = "0x20886F0", VA = "0x182089AF0", Slot = "19")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x06025988 RID: 153992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025988")]
		[Address(RVA = "0x2089850", Offset = "0x2088450", VA = "0x182089850", Slot = "21")]
		public override void LoadData(ArtGalleryItemData itemData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x06025989 RID: 153993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025989")]
		[Address(RVA = "0x2089A50", Offset = "0x2088650", VA = "0x182089A50")]
		public ArtGalleryDisplayAvatarItemViewModel()
		{
		}

		// Token: 0x0602598A RID: 153994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602598A")]
		[Address(RVA = "0x2089A20", Offset = "0x2088620", VA = "0x182089A20")]
		private void <>xLuaBaseProxy_LoadData(ArtGalleryItemData P0, IArtGalleryDisplayItemViewModel.ItemRefreshParam P1)
		{
		}

		// Token: 0x04034D25 RID: 216357
		[Token(Token = "0x4034D25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04034D26 RID: 216358
		[Token(Token = "0x4034D26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034D27 RID: 216359
		[Token(Token = "0x4034D27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
