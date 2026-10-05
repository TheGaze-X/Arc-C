using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ACC RID: 23244
	[Token(Token = "0x2005ACC")]
	public class ShopGPRcmdSortPanel : ShopGPDisplayPanelBase<ShopGPRecommedPanelModel>
	{
		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x06021C94 RID: 138388 RVA: 0x000BB488 File Offset: 0x000B9688
		[Token(Token = "0x17004F1C")]
		protected override ShopGPPanelType type
		{
			[Token(Token = "0x6021C94")]
			[Address(RVA = "0x1C426F0", Offset = "0x1C412F0", VA = "0x181C426F0", Slot = "4")]
			get
			{
				return ShopGPPanelType.DEFAULT_COMMON;
			}
		}

		// Token: 0x06021C95 RID: 138389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C95")]
		[Address(RVA = "0x1C42460", Offset = "0x1C41060", VA = "0x181C42460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021C96 RID: 138390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C96")]
		[Address(RVA = "0x1C42240", Offset = "0x1C40E40", VA = "0x181C42240", Slot = "7")]
		protected override void OnRender(ShopGPRecommedPanelModel panelModel)
		{
		}

		// Token: 0x06021C97 RID: 138391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C97")]
		[Address(RVA = "0x1C422E0", Offset = "0x1C40EE0", VA = "0x181C422E0", Slot = "8")]
		protected override void SetShow(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x06021C98 RID: 138392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C98")]
		[Address(RVA = "0x1C425D0", Offset = "0x1C411D0", VA = "0x181C425D0")]
		private void _ResetScrollPos()
		{
		}

		// Token: 0x06021C99 RID: 138393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C99")]
		[Address(RVA = "0x1C42680", Offset = "0x1C41280", VA = "0x181C42680")]
		public ShopGPRcmdSortPanel()
		{
		}

		// Token: 0x0402E3EA RID: 189418
		[Token(Token = "0x402E3EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShopGPCommonItemView _itemView;

		// Token: 0x0402E3EB RID: 189419
		[Token(Token = "0x402E3EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ShopGPMonthlySubItem _monthlyItemView;

		// Token: 0x0402E3EC RID: 189420
		[Token(Token = "0x402E3EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402E3ED RID: 189421
		[Token(Token = "0x402E3ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _content;

		// Token: 0x0402E3EE RID: 189422
		[Token(Token = "0x402E3EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _rootCg;

		// Token: 0x0402E3EF RID: 189423
		[Token(Token = "0x402E3EF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402E3F0 RID: 189424
		[Token(Token = "0x402E3F0")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0402E3F1 RID: 189425
		[Token(Token = "0x402E3F1")]
		[FieldOffset(Offset = "0x58")]
		private ShopGPRcmdSortPanel.Holder m_holder;

		// Token: 0x0402E3F2 RID: 189426
		[Token(Token = "0x402E3F2")]
		[FieldOffset(Offset = "0x60")]
		private ShopGPSimplePanelAdapter m_adapter;

		// Token: 0x0402E3F3 RID: 189427
		[Token(Token = "0x402E3F3")]
		[FieldOffset(Offset = "0x68")]
		private ShopGPRecommedPanelModel m_cachedViewModel;

		// Token: 0x0402E3F4 RID: 189428
		[Token(Token = "0x402E3F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402E3F5 RID: 189429
		[Token(Token = "0x402E3F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E3F6 RID: 189430
		[Token(Token = "0x402E3F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402E3F7 RID: 189431
		[Token(Token = "0x402E3F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402E3F8 RID: 189432
		[Token(Token = "0x402E3F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetScrollPos;

		// Token: 0x0402E3F9 RID: 189433
		[Token(Token = "0x402E3F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005ACD RID: 23245
		[Token(Token = "0x2005ACD")]
		private class Holder : ShopGPSimplePanelAdapter.IShopGPSimplePanelHolder, IHotfixable
		{
			// Token: 0x06021C9A RID: 138394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021C9A")]
			[Address(RVA = "0x1C433F0", Offset = "0x1C41FF0", VA = "0x181C433F0")]
			public Holder(ShopGPRcmdSortPanel closure)
			{
			}

			// Token: 0x06021C9B RID: 138395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C9B")]
			[Address(RVA = "0x1C42F20", Offset = "0x1C41B20", VA = "0x181C42F20", Slot = "4")]
			public ShopGPCommonItemView GetCommonItemViewPrefab()
			{
				return null;
			}

			// Token: 0x06021C9C RID: 138396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C9C")]
			[Address(RVA = "0x1C431B0", Offset = "0x1C41DB0", VA = "0x181C431B0", Slot = "5")]
			public ShopGPMonthlySubItem GetMonthlySubItemViewPrefab()
			{
				return null;
			}

			// Token: 0x06021C9D RID: 138397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C9D")]
			[Address(RVA = "0x1C42F90", Offset = "0x1C41B90", VA = "0x181C42F90", Slot = "6")]
			public IList<ShopGPCommonItemViewModel> GetItemList()
			{
				return null;
			}

			// Token: 0x06021C9E RID: 138398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C9E")]
			[Address(RVA = "0x1C43220", Offset = "0x1C41E20", VA = "0x181C43220", Slot = "7")]
			public IList<ShopGPCommonItemViewModel> GetSoldOutList()
			{
				return null;
			}

			// Token: 0x0402E3FA RID: 189434
			[Token(Token = "0x402E3FA")]
			[FieldOffset(Offset = "0x10")]
			private ShopGPRcmdSortPanel m_closure;

			// Token: 0x0402E3FB RID: 189435
			[Token(Token = "0x402E3FB")]
			[FieldOffset(Offset = "0x18")]
			private List<ShopGPCommonItemViewModel> m_showItems;

			// Token: 0x0402E3FC RID: 189436
			[Token(Token = "0x402E3FC")]
			[FieldOffset(Offset = "0x20")]
			private List<ShopGPCommonItemViewModel> m_soldOutItems;

			// Token: 0x0402E3FD RID: 189437
			[Token(Token = "0x402E3FD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E3FE RID: 189438
			[Token(Token = "0x402E3FE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCommonItemViewPrefab;

			// Token: 0x0402E3FF RID: 189439
			[Token(Token = "0x402E3FF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetMonthlySubItemViewPrefab;

			// Token: 0x0402E400 RID: 189440
			[Token(Token = "0x402E400")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetItemList;

			// Token: 0x0402E401 RID: 189441
			[Token(Token = "0x402E401")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetSoldOutList;
		}
	}
}
