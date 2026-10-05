using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ItemRepo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ACA RID: 15050
	[Token(Token = "0x2003ACA")]
	public class ItemRepoDropInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017BCC RID: 97228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BCC")]
		[Address(RVA = "0xFFB540", Offset = "0xFFA140", VA = "0x180FFB540")]
		public void Init(ItemRepoDropInfoView.Options options)
		{
		}

		// Token: 0x06017BCD RID: 97229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BCD")]
		[Address(RVA = "0xFFB5D0", Offset = "0xFFA1D0", VA = "0x180FFB5D0")]
		public void UpdateItemDropInfo(UIItemViewModel itemModel, UIItemDescViewModel descModel)
		{
		}

		// Token: 0x06017BCE RID: 97230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BCE")]
		private void _DestroyViews<ViewType>(IDictionary<string, ViewType> views) where ViewType : MonoBehaviour
		{
		}

		// Token: 0x06017BCF RID: 97231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BCF")]
		[Address(RVA = "0xFFB920", Offset = "0xFFA520", VA = "0x180FFB920")]
		private UIItemDescFloatStageDropDetail _CreateStageDropView()
		{
			return null;
		}

		// Token: 0x06017BD0 RID: 97232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BD0")]
		[Address(RVA = "0xFFB780", Offset = "0xFFA380", VA = "0x180FFB780")]
		private UIItemDescFloatBuildingProduct _CreateBuildingProductView()
		{
			return null;
		}

		// Token: 0x06017BD1 RID: 97233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BD1")]
		[Address(RVA = "0xFFB9F0", Offset = "0xFFA5F0", VA = "0x180FFB9F0")]
		private UIItemDescFloatVoucherRelation _CreateVoucherRelationView()
		{
			return null;
		}

		// Token: 0x06017BD2 RID: 97234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BD2")]
		[Address(RVA = "0xFFB850", Offset = "0xFFA450", VA = "0x180FFB850")]
		private UIItemDescFloatShopDetail _CreateShopDetailView()
		{
			return null;
		}

		// Token: 0x06017BD3 RID: 97235 RVA: 0x00097D70 File Offset: 0x00095F70
		[Token(Token = "0x6017BD3")]
		[Address(RVA = "0xFFC110", Offset = "0xFFAD10", VA = "0x180FFC110")]
		private bool _UpdateStageDropInfo(UIItemViewModel itemModel, UIItemDescViewModel descModel)
		{
			return default(bool);
		}

		// Token: 0x06017BD4 RID: 97236 RVA: 0x00097D88 File Offset: 0x00095F88
		[Token(Token = "0x6017BD4")]
		[Address(RVA = "0xFFBAC0", Offset = "0xFFA6C0", VA = "0x180FFBAC0")]
		private bool _UpdateBuildingProductInfo(UIItemViewModel itemModel, UIItemDescViewModel descModel)
		{
			return default(bool);
		}

		// Token: 0x06017BD5 RID: 97237 RVA: 0x00097DA0 File Offset: 0x00095FA0
		[Token(Token = "0x6017BD5")]
		[Address(RVA = "0xFFC940", Offset = "0xFFB540", VA = "0x180FFC940")]
		private bool _UpdateVoucherRelationInfo(UIItemViewModel itemModel, UIItemDescViewModel descModel)
		{
			return default(bool);
		}

		// Token: 0x06017BD6 RID: 97238 RVA: 0x00097DB8 File Offset: 0x00095FB8
		[Token(Token = "0x6017BD6")]
		[Address(RVA = "0xFFBDD0", Offset = "0xFFA9D0", VA = "0x180FFBDD0")]
		private bool _UpdateShopDetailInfo(UIItemViewModel itemModel, UIItemDescViewModel descModel)
		{
			return default(bool);
		}

		// Token: 0x06017BD7 RID: 97239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BD7")]
		[Address(RVA = "0xFFCD90", Offset = "0xFFB990", VA = "0x180FFCD90")]
		public ItemRepoDropInfoView()
		{
		}

		// Token: 0x0401CA7B RID: 117371
		[Token(Token = "0x401CA7B")]
		private const string VOUCHER_INST_FORMAT = "{0}_{1}";

		// Token: 0x0401CA7C RID: 117372
		[Token(Token = "0x401CA7C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIItemDescFloatStageDropDetail _stageDropDetail;

		// Token: 0x0401CA7D RID: 117373
		[Token(Token = "0x401CA7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _stageDropContainer;

		// Token: 0x0401CA7E RID: 117374
		[Token(Token = "0x401CA7E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIItemDescFloatBuildingProduct _buildingProduct;

		// Token: 0x0401CA7F RID: 117375
		[Token(Token = "0x401CA7F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _buildingProductContainer;

		// Token: 0x0401CA80 RID: 117376
		[Token(Token = "0x401CA80")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIItemDescFloatShopDetail _shopDetail;

		// Token: 0x0401CA81 RID: 117377
		[Token(Token = "0x401CA81")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _shopItemContainer;

		// Token: 0x0401CA82 RID: 117378
		[Token(Token = "0x401CA82")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelShop;

		// Token: 0x0401CA83 RID: 117379
		[Token(Token = "0x401CA83")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIItemDescFloatVoucherRelation _voucherRelationPrefab;

		// Token: 0x0401CA84 RID: 117380
		[Token(Token = "0x401CA84")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _voucherRelationContainer;

		// Token: 0x0401CA85 RID: 117381
		[Token(Token = "0x401CA85")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textObtain;

		// Token: 0x0401CA86 RID: 117382
		[Token(Token = "0x401CA86")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _titleOthers;

		// Token: 0x0401CA87 RID: 117383
		[Token(Token = "0x401CA87")]
		[FieldOffset(Offset = "0x70")]
		private ListDict<string, UIItemDescFloatStageDropDetail> m_zoneDropList;

		// Token: 0x0401CA88 RID: 117384
		[Token(Token = "0x401CA88")]
		[FieldOffset(Offset = "0x78")]
		private ListDict<string, UIItemDescFloatStageDropDetail> m_stageDropList;

		// Token: 0x0401CA89 RID: 117385
		[Token(Token = "0x401CA89")]
		[FieldOffset(Offset = "0x80")]
		private UIItemDescFloatStageDropDetail m_campaignDrop;

		// Token: 0x0401CA8A RID: 117386
		[Token(Token = "0x401CA8A")]
		[FieldOffset(Offset = "0x88")]
		private UIItemDescFloatStageDropDetail m_climbTowerDrop;

		// Token: 0x0401CA8B RID: 117387
		[Token(Token = "0x401CA8B")]
		[FieldOffset(Offset = "0x90")]
		private ListDict<string, UIItemDescFloatBuildingProduct> m_buildingProductList;

		// Token: 0x0401CA8C RID: 117388
		[Token(Token = "0x401CA8C")]
		[FieldOffset(Offset = "0x98")]
		private ListDict<string, UIItemDescFloatShopDetail> m_shopDetailList;

		// Token: 0x0401CA8D RID: 117389
		[Token(Token = "0x401CA8D")]
		[FieldOffset(Offset = "0xA0")]
		private List<string> m_campaignStages;

		// Token: 0x0401CA8E RID: 117390
		[Token(Token = "0x401CA8E")]
		[FieldOffset(Offset = "0xA8")]
		private ListDict<string, UIItemDescFloatVoucherRelation> m_voucherRelationList;

		// Token: 0x0401CA8F RID: 117391
		[Token(Token = "0x401CA8F")]
		[FieldOffset(Offset = "0xB0")]
		private ItemRepoDropInfoView.Options m_options;

		// Token: 0x0401CA90 RID: 117392
		[Token(Token = "0x401CA90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401CA91 RID: 117393
		[Token(Token = "0x401CA91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateItemDropInfo;

		// Token: 0x0401CA92 RID: 117394
		[Token(Token = "0x401CA92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DestroyViews;

		// Token: 0x0401CA93 RID: 117395
		[Token(Token = "0x401CA93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateStageDropView;

		// Token: 0x0401CA94 RID: 117396
		[Token(Token = "0x401CA94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateBuildingProductView;

		// Token: 0x0401CA95 RID: 117397
		[Token(Token = "0x401CA95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateVoucherRelationView;

		// Token: 0x0401CA96 RID: 117398
		[Token(Token = "0x401CA96")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateShopDetailView;

		// Token: 0x0401CA97 RID: 117399
		[Token(Token = "0x401CA97")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateStageDropInfo;

		// Token: 0x0401CA98 RID: 117400
		[Token(Token = "0x401CA98")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateBuildingProductInfo;

		// Token: 0x0401CA99 RID: 117401
		[Token(Token = "0x401CA99")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateVoucherRelationInfo;

		// Token: 0x0401CA9A RID: 117402
		[Token(Token = "0x401CA9A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateShopDetailInfo;

		// Token: 0x0401CA9B RID: 117403
		[Token(Token = "0x401CA9B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003ACB RID: 15051
		[Token(Token = "0x2003ACB")]
		public struct Options
		{
			// Token: 0x0401CA9C RID: 117404
			[Token(Token = "0x401CA9C")]
			[FieldOffset(Offset = "0x0")]
			public Action<UIItemDescFloatStageDropDetail.RouteTarget> onStageClicked;

			// Token: 0x0401CA9D RID: 117405
			[Token(Token = "0x401CA9D")]
			[FieldOffset(Offset = "0x8")]
			public Action<BuildingData.RoomType, ItemBundle> onRoomClicked;

			// Token: 0x0401CA9E RID: 117406
			[Token(Token = "0x401CA9E")]
			[FieldOffset(Offset = "0x10")]
			public Action<ItemUtil.ConsumableInfo, ItemType, UIItemDescFloatVoucherRelation.VoucherRouteFocus> onVoucherClicked;

			// Token: 0x0401CA9F RID: 117407
			[Token(Token = "0x401CA9F")]
			[FieldOffset(Offset = "0x18")]
			public Action<ItemData.ShopRelateInfo> onShopClicked;
		}
	}
}
