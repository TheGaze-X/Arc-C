using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006644 RID: 26180
	[Token(Token = "0x2006644")]
	public class ArtGalleryDisplayHomeBackgroundItemViewModel : ArtGalleryDisplayItemViewModelBase
	{
		// Token: 0x170058F5 RID: 22773
		// (get) Token: 0x06025990 RID: 154000 RVA: 0x000C8730 File Offset: 0x000C6930
		[Token(Token = "0x170058F5")]
		public override ItemType itemType
		{
			[Token(Token = "0x6025990")]
			[Address(RVA = "0x208A740", Offset = "0x2089340", VA = "0x18208A740", Slot = "19")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x06025991 RID: 154001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025991")]
		[Address(RVA = "0x208A120", Offset = "0x2088D20", VA = "0x18208A120", Slot = "21")]
		public override void LoadData(ArtGalleryItemData itemData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x06025992 RID: 154002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025992")]
		[Address(RVA = "0x208A290", Offset = "0x2088E90", VA = "0x18208A290")]
		public void LoadFromPlayerData(HomeBackgroundSingleData homeBackgroundData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x06025993 RID: 154003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025993")]
		[Address(RVA = "0x208A400", Offset = "0x2089000", VA = "0x18208A400")]
		private void _LoadBasicInfoFromBgData(HomeBackgroundSingleData homeBgData)
		{
		}

		// Token: 0x06025994 RID: 154004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025994")]
		[Address(RVA = "0x208A6A0", Offset = "0x20892A0", VA = "0x18208A6A0")]
		public ArtGalleryDisplayHomeBackgroundItemViewModel()
		{
		}

		// Token: 0x06025995 RID: 154005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025995")]
		[Address(RVA = "0x2089A20", Offset = "0x2088620", VA = "0x182089A20")]
		private void <>xLuaBaseProxy_LoadData(ArtGalleryItemData P0, IArtGalleryDisplayItemViewModel.ItemRefreshParam P1)
		{
		}

		// Token: 0x04034D2D RID: 216365
		[Token(Token = "0x4034D2D")]
		[FieldOffset(Offset = "0x58")]
		public bool isMultiForm;

		// Token: 0x04034D2E RID: 216366
		[Token(Token = "0x4034D2E")]
		[FieldOffset(Offset = "0x60")]
		public string previewPicId;

		// Token: 0x04034D2F RID: 216367
		[Token(Token = "0x4034D2F")]
		[FieldOffset(Offset = "0x68")]
		public bool hasMusic;

		// Token: 0x04034D30 RID: 216368
		[Token(Token = "0x4034D30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04034D31 RID: 216369
		[Token(Token = "0x4034D31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034D32 RID: 216370
		[Token(Token = "0x4034D32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadFromPlayerData;

		// Token: 0x04034D33 RID: 216371
		[Token(Token = "0x4034D33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadBasicInfoFromBgData;

		// Token: 0x04034D34 RID: 216372
		[Token(Token = "0x4034D34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
