using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC7 RID: 23239
	[Token(Token = "0x2005AC7")]
	public class ShopGPCommonSortPanel : ShopGPDisplayPanelBase<ShopGPCommonSortPanelModel>
	{
		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x06021C78 RID: 138360 RVA: 0x000BB458 File Offset: 0x000B9658
		[Token(Token = "0x17004F19")]
		protected override ShopGPPanelType type
		{
			[Token(Token = "0x6021C78")]
			[Address(RVA = "0x1C41A70", Offset = "0x1C40670", VA = "0x181C41A70", Slot = "4")]
			get
			{
				return ShopGPPanelType.DEFAULT_COMMON;
			}
		}

		// Token: 0x06021C79 RID: 138361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C79")]
		[Address(RVA = "0x1C41570", Offset = "0x1C40170", VA = "0x181C41570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021C7A RID: 138362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C7A")]
		[Address(RVA = "0x1C41370", Offset = "0x1C3FF70", VA = "0x181C41370", Slot = "7")]
		protected override void OnRender(ShopGPCommonSortPanelModel panelModel)
		{
		}

		// Token: 0x06021C7B RID: 138363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C7B")]
		[Address(RVA = "0x1C41410", Offset = "0x1C40010", VA = "0x181C41410", Slot = "8")]
		protected override void SetShow(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x06021C7C RID: 138364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C7C")]
		[Address(RVA = "0x1C41950", Offset = "0x1C40550", VA = "0x181C41950")]
		private void _ResetScrollPos()
		{
		}

		// Token: 0x06021C7D RID: 138365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C7D")]
		[Address(RVA = "0x1C418D0", Offset = "0x1C404D0", VA = "0x181C418D0")]
		private void _OnScrollRectPosReady()
		{
		}

		// Token: 0x06021C7E RID: 138366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C7E")]
		[Address(RVA = "0x1C41220", Offset = "0x1C3FE20", VA = "0x181C41220")]
		private void OnDestroy()
		{
		}

		// Token: 0x06021C7F RID: 138367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C7F")]
		[Address(RVA = "0x1C41A00", Offset = "0x1C40600", VA = "0x181C41A00")]
		public ShopGPCommonSortPanel()
		{
		}

		// Token: 0x0402E3BE RID: 189374
		[Token(Token = "0x402E3BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShopGPCommonItemView _itemView;

		// Token: 0x0402E3BF RID: 189375
		[Token(Token = "0x402E3BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ShopGPMonthlySubItem _monthlyItemView;

		// Token: 0x0402E3C0 RID: 189376
		[Token(Token = "0x402E3C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402E3C1 RID: 189377
		[Token(Token = "0x402E3C1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _content;

		// Token: 0x0402E3C2 RID: 189378
		[Token(Token = "0x402E3C2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _rootCg;

		// Token: 0x0402E3C3 RID: 189379
		[Token(Token = "0x402E3C3")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402E3C4 RID: 189380
		[Token(Token = "0x402E3C4")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0402E3C5 RID: 189381
		[Token(Token = "0x402E3C5")]
		[FieldOffset(Offset = "0x58")]
		private ShopGPCommonSortPanel.Holder m_holder;

		// Token: 0x0402E3C6 RID: 189382
		[Token(Token = "0x402E3C6")]
		[FieldOffset(Offset = "0x60")]
		private ShopGPSimplePanelAdapter m_adapter;

		// Token: 0x0402E3C7 RID: 189383
		[Token(Token = "0x402E3C7")]
		[FieldOffset(Offset = "0x68")]
		private ShopGPCommonSortPanelModel m_cachedViewModel;

		// Token: 0x0402E3C8 RID: 189384
		[Token(Token = "0x402E3C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402E3C9 RID: 189385
		[Token(Token = "0x402E3C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E3CA RID: 189386
		[Token(Token = "0x402E3CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402E3CB RID: 189387
		[Token(Token = "0x402E3CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402E3CC RID: 189388
		[Token(Token = "0x402E3CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetScrollPos;

		// Token: 0x0402E3CD RID: 189389
		[Token(Token = "0x402E3CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnScrollRectPosReady;

		// Token: 0x0402E3CE RID: 189390
		[Token(Token = "0x402E3CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402E3CF RID: 189391
		[Token(Token = "0x402E3CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AC8 RID: 23240
		[Token(Token = "0x2005AC8")]
		private class Holder : ShopGPSimplePanelAdapter.IShopGPSimplePanelHolder, IHotfixable
		{
			// Token: 0x06021C80 RID: 138368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021C80")]
			[Address(RVA = "0x1C31640", Offset = "0x1C30240", VA = "0x181C31640")]
			public Holder(ShopGPCommonSortPanel closure)
			{
			}

			// Token: 0x06021C81 RID: 138369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C81")]
			[Address(RVA = "0x1C311C0", Offset = "0x1C2FDC0", VA = "0x181C311C0", Slot = "4")]
			public ShopGPCommonItemView GetCommonItemViewPrefab()
			{
				return null;
			}

			// Token: 0x06021C82 RID: 138370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C82")]
			[Address(RVA = "0x1C31400", Offset = "0x1C30000", VA = "0x181C31400", Slot = "5")]
			public ShopGPMonthlySubItem GetMonthlySubItemViewPrefab()
			{
				return null;
			}

			// Token: 0x06021C83 RID: 138371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C83")]
			[Address(RVA = "0x1C31230", Offset = "0x1C2FE30", VA = "0x181C31230", Slot = "6")]
			public IList<ShopGPCommonItemViewModel> GetItemList()
			{
				return null;
			}

			// Token: 0x06021C84 RID: 138372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C84")]
			[Address(RVA = "0x1C31470", Offset = "0x1C30070", VA = "0x181C31470", Slot = "7")]
			public IList<ShopGPCommonItemViewModel> GetSoldOutList()
			{
				return null;
			}

			// Token: 0x0402E3D0 RID: 189392
			[Token(Token = "0x402E3D0")]
			[FieldOffset(Offset = "0x10")]
			private ShopGPCommonSortPanel m_closure;

			// Token: 0x0402E3D1 RID: 189393
			[Token(Token = "0x402E3D1")]
			[FieldOffset(Offset = "0x18")]
			private List<ShopGPCommonItemViewModel> m_showItems;

			// Token: 0x0402E3D2 RID: 189394
			[Token(Token = "0x402E3D2")]
			[FieldOffset(Offset = "0x20")]
			private List<ShopGPCommonItemViewModel> m_soldOutItems;

			// Token: 0x0402E3D3 RID: 189395
			[Token(Token = "0x402E3D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E3D4 RID: 189396
			[Token(Token = "0x402E3D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCommonItemViewPrefab;

			// Token: 0x0402E3D5 RID: 189397
			[Token(Token = "0x402E3D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetMonthlySubItemViewPrefab;

			// Token: 0x0402E3D6 RID: 189398
			[Token(Token = "0x402E3D6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetItemList;

			// Token: 0x0402E3D7 RID: 189399
			[Token(Token = "0x402E3D7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetSoldOutList;
		}
	}
}
