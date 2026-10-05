using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A95 RID: 23189
	[Token(Token = "0x2005A95")]
	public class ShopDetailBlindboxView : ShopDetailCommonView
	{
		// Token: 0x06021B8F RID: 138127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B8F")]
		[Address(RVA = "0x1C1EA30", Offset = "0x1C1D630", VA = "0x181C1EA30")]
		private void _InitAdapterIfNot()
		{
		}

		// Token: 0x06021B90 RID: 138128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B90")]
		[Address(RVA = "0x1C1DF10", Offset = "0x1C1CB10", VA = "0x181C1DF10", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021B91 RID: 138129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B91")]
		[Address(RVA = "0x1C1EDC0", Offset = "0x1C1D9C0", VA = "0x181C1EDC0")]
		private Sprite _LoadSelectionVoucherIcon(string voucherId)
		{
			return null;
		}

		// Token: 0x06021B92 RID: 138130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B92")]
		[Address(RVA = "0x1C1EB50", Offset = "0x1C1D750", VA = "0x181C1EB50")]
		private Sprite _LoadBlindboxBackSprite(string itemId)
		{
			return null;
		}

		// Token: 0x06021B93 RID: 138131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B93")]
		[Address(RVA = "0x1C1EC40", Offset = "0x1C1D840", VA = "0x181C1EC40")]
		private Sprite _LoadPriceSprite(SpriteHub hub, UIItemViewModel item)
		{
			return null;
		}

		// Token: 0x06021B94 RID: 138132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B94")]
		[Address(RVA = "0x1C1E970", Offset = "0x1C1D570", VA = "0x181C1E970")]
		public void OnDetailBtnClicked()
		{
		}

		// Token: 0x06021B95 RID: 138133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B95")]
		[Address(RVA = "0x1C1E8D0", Offset = "0x1C1D4D0", VA = "0x181C1E8D0", Slot = "5")]
		public override void OnClick()
		{
		}

		// Token: 0x06021B96 RID: 138134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B96")]
		[Address(RVA = "0x1C1EF60", Offset = "0x1C1DB60", VA = "0x181C1EF60")]
		public ShopDetailBlindboxView()
		{
		}

		// Token: 0x06021B97 RID: 138135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B97")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x06021B98 RID: 138136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B98")]
		[Address(RVA = "0x1C1EA20", Offset = "0x1C1D620", VA = "0x181C1EA20")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402E209 RID: 188937
		[Token(Token = "0x402E209")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("itemDetail")]
		private SimpleLayoutContent _descriptionContainer;

		// Token: 0x0402E20A RID: 188938
		[Token(Token = "0x402E20A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("itemDetail")]
		private Text _goodName;

		// Token: 0x0402E20B RID: 188939
		[Token(Token = "0x402E20B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("itemDetail")]
		private Text _remainCount;

		// Token: 0x0402E20C RID: 188940
		[Token(Token = "0x402E20C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("selectionVoucher")]
		private GameObject _selectionVoucherPart;

		// Token: 0x0402E20D RID: 188941
		[Token(Token = "0x402E20D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("selectionVoucher")]
		private Image _selectionVoucherBackImage;

		// Token: 0x0402E20E RID: 188942
		[Token(Token = "0x402E20E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("selectionVoucher")]
		private Image _selectionVoucherIcon;

		// Token: 0x0402E20F RID: 188943
		[Token(Token = "0x402E20F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("selectionVoucher")]
		private Text _selectionConvertDesc;

		// Token: 0x0402E210 RID: 188944
		[Token(Token = "0x402E210")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("detailPreview")]
		private Image _blindboxImage;

		// Token: 0x0402E211 RID: 188945
		[Token(Token = "0x402E211")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("detailPreview")]
		private GameObject _selectionVoucherImage;

		// Token: 0x0402E212 RID: 188946
		[Token(Token = "0x402E212")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("detailPreview")]
		private GameObject _gachaVoucherImage;

		// Token: 0x0402E213 RID: 188947
		[Token(Token = "0x402E213")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInit;

		// Token: 0x0402E214 RID: 188948
		[Token(Token = "0x402E214")]
		[FieldOffset(Offset = "0x100")]
		private ShopDetailBlindboxView.ItemDescriptionGroupViewAdapter m_itemDescriptionAdapter;

		// Token: 0x0402E215 RID: 188949
		[Token(Token = "0x402E215")]
		[FieldOffset(Offset = "0x108")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402E216 RID: 188950
		[Token(Token = "0x402E216")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitAdapterIfNot;

		// Token: 0x0402E217 RID: 188951
		[Token(Token = "0x402E217")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E218 RID: 188952
		[Token(Token = "0x402E218")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSelectionVoucherIcon;

		// Token: 0x0402E219 RID: 188953
		[Token(Token = "0x402E219")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadBlindboxBackSprite;

		// Token: 0x0402E21A RID: 188954
		[Token(Token = "0x402E21A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadPriceSprite;

		// Token: 0x0402E21B RID: 188955
		[Token(Token = "0x402E21B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetailBtnClicked;

		// Token: 0x0402E21C RID: 188956
		[Token(Token = "0x402E21C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E21D RID: 188957
		[Token(Token = "0x402E21D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A96 RID: 23190
		[Token(Token = "0x2005A96")]
		private class ItemDescriptionGroupViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004F0E RID: 20238
			// (get) Token: 0x06021B99 RID: 138137 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06021B9A RID: 138138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004F0E")]
			public List<BlindboxDetailViewModel.BlindboxDescriptionModel> dataSet
			{
				[Token(Token = "0x6021B99")]
				[Address(RVA = "0x1C1B0A0", Offset = "0x1C19CA0", VA = "0x181C1B0A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6021B9A")]
				[Address(RVA = "0x1C1B100", Offset = "0x1C19D00", VA = "0x181C1B100")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004F0F RID: 20239
			// (get) Token: 0x06021B9B RID: 138139 RVA: 0x000BB290 File Offset: 0x000B9490
			[Token(Token = "0x17004F0F")]
			public override int count
			{
				[Token(Token = "0x6021B9B")]
				[Address(RVA = "0x1C1AFE0", Offset = "0x1C19BE0", VA = "0x181C1AFE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021B9C RID: 138140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021B9C")]
			[Address(RVA = "0x1C1AD90", Offset = "0x1C19990", VA = "0x181C1AD90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021B9D RID: 138141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021B9D")]
			[Address(RVA = "0x1C1AF80", Offset = "0x1C19B80", VA = "0x181C1AF80")]
			public ItemDescriptionGroupViewAdapter()
			{
			}

			// Token: 0x0402E21F RID: 188959
			[Token(Token = "0x402E21F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0402E220 RID: 188960
			[Token(Token = "0x402E220")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0402E221 RID: 188961
			[Token(Token = "0x402E221")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E222 RID: 188962
			[Token(Token = "0x402E222")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402E223 RID: 188963
			[Token(Token = "0x402E223")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
