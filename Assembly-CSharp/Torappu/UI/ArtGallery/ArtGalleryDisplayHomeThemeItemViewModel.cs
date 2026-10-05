using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006647 RID: 26183
	[Token(Token = "0x2006647")]
	public class ArtGalleryDisplayHomeThemeItemViewModel : ArtGalleryDisplayItemViewModelBase
	{
		// Token: 0x170058F7 RID: 22775
		// (get) Token: 0x0602599A RID: 154010 RVA: 0x000C8760 File Offset: 0x000C6960
		[Token(Token = "0x170058F7")]
		public override ItemType itemType
		{
			[Token(Token = "0x602599A")]
			[Address(RVA = "0x208ACE0", Offset = "0x20898E0", VA = "0x18208ACE0", Slot = "19")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x0602599B RID: 154011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602599B")]
		[Address(RVA = "0x208A910", Offset = "0x2089510", VA = "0x18208A910", Slot = "21")]
		public override void LoadData(ArtGalleryItemData itemData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x0602599C RID: 154012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602599C")]
		[Address(RVA = "0x208A7A0", Offset = "0x20893A0", VA = "0x18208A7A0")]
		public void LoadDataFromHomeThemeData(HomeThemeDisplayData homeThemeItemData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x0602599D RID: 154013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602599D")]
		[Address(RVA = "0x208AA80", Offset = "0x2089680", VA = "0x18208AA80")]
		private void _LoadBasicInfo(HomeThemeDisplayData homeThemeItemData)
		{
		}

		// Token: 0x0602599E RID: 154014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602599E")]
		[Address(RVA = "0x208AC40", Offset = "0x2089840", VA = "0x18208AC40")]
		public ArtGalleryDisplayHomeThemeItemViewModel()
		{
		}

		// Token: 0x0602599F RID: 154015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602599F")]
		[Address(RVA = "0x2089A20", Offset = "0x2088620", VA = "0x182089A20")]
		private void <>xLuaBaseProxy_LoadData(ArtGalleryItemData P0, IArtGalleryDisplayItemViewModel.ItemRefreshParam P1)
		{
		}

		// Token: 0x04034D39 RID: 216377
		[Token(Token = "0x4034D39")]
		[FieldOffset(Offset = "0x58")]
		public bool isMultiForm;

		// Token: 0x04034D3A RID: 216378
		[Token(Token = "0x4034D3A")]
		[FieldOffset(Offset = "0x60")]
		public string previewPicId;

		// Token: 0x04034D3B RID: 216379
		[Token(Token = "0x4034D3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04034D3C RID: 216380
		[Token(Token = "0x4034D3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034D3D RID: 216381
		[Token(Token = "0x4034D3D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadDataFromHomeThemeData;

		// Token: 0x04034D3E RID: 216382
		[Token(Token = "0x4034D3E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadBasicInfo;

		// Token: 0x04034D3F RID: 216383
		[Token(Token = "0x4034D3F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
