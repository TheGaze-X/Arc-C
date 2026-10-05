using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006091 RID: 24721
	[Token(Token = "0x2006091")]
	public class CarvingMainShopView : DataBinder<CarvingMainProperty>
	{
		// Token: 0x06023C1F RID: 146463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C1F")]
		[Address(RVA = "0x1E68A70", Offset = "0x1E67670", VA = "0x181E68A70", Slot = "7")]
		public override void OnValueChanged(CarvingMainProperty property)
		{
		}

		// Token: 0x06023C20 RID: 146464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C20")]
		[Address(RVA = "0x1E68C80", Offset = "0x1E67880", VA = "0x181E68C80")]
		public void StateOnlyRegisterTutorialGO()
		{
		}

		// Token: 0x06023C21 RID: 146465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C21")]
		[Address(RVA = "0x1E690C0", Offset = "0x1E67CC0", VA = "0x181E690C0")]
		private void _PlayRefreshTweenAndRender(CarvingMainShopViewModel model)
		{
		}

		// Token: 0x06023C22 RID: 146466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C22")]
		[Address(RVA = "0x1E692F0", Offset = "0x1E67EF0", VA = "0x181E692F0")]
		private void _Render(CarvingMainShopViewModel model)
		{
		}

		// Token: 0x06023C23 RID: 146467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C23")]
		[Address(RVA = "0x1E68E70", Offset = "0x1E67A70", VA = "0x181E68E70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023C24 RID: 146468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C24")]
		[Address(RVA = "0x1E68FB0", Offset = "0x1E67BB0", VA = "0x181E68FB0")]
		private void _PlayFreeNotifyAnim()
		{
		}

		// Token: 0x06023C25 RID: 146469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C25")]
		[Address(RVA = "0x1E68770", Offset = "0x1E67370", VA = "0x181E68770")]
		public void OnClickCheckInfoBtn()
		{
		}

		// Token: 0x06023C26 RID: 146470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C26")]
		[Address(RVA = "0x1E68910", Offset = "0x1E67510", VA = "0x181E68910")]
		public void OnClickRefreshBtn()
		{
		}

		// Token: 0x06023C27 RID: 146471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C27")]
		[Address(RVA = "0x1E686C0", Offset = "0x1E672C0", VA = "0x181E686C0")]
		public void OnClickBuyBtn()
		{
		}

		// Token: 0x06023C28 RID: 146472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C28")]
		[Address(RVA = "0x1E689C0", Offset = "0x1E675C0", VA = "0x181E689C0")]
		public void OnClickToProcessBtn()
		{
		}

		// Token: 0x06023C29 RID: 146473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C29")]
		[Address(RVA = "0x1E68810", Offset = "0x1E67410", VA = "0x181E68810")]
		public void OnClickHandbookBtn()
		{
		}

		// Token: 0x06023C2A RID: 146474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C2A")]
		[Address(RVA = "0x1E69EA0", Offset = "0x1E68AA0", VA = "0x181E69EA0")]
		public CarvingMainShopView()
		{
		}

		// Token: 0x04031914 RID: 203028
		[Token(Token = "0x4031914")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _roundText;

		// Token: 0x04031915 RID: 203029
		[Token(Token = "0x4031915")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("refresh")]
		private GameObject _refreshObj;

		// Token: 0x04031916 RID: 203030
		[Token(Token = "0x4031916")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("refresh")]
		private Text _refreshCoinText;

		// Token: 0x04031917 RID: 203031
		[Token(Token = "0x4031917")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("refresh")]
		private Color _enoughCoinRefreshColor;

		// Token: 0x04031918 RID: 203032
		[Token(Token = "0x4031918")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("refresh")]
		private Color _notEnoughCoinRefreshColor;

		// Token: 0x04031919 RID: 203033
		[Token(Token = "0x4031919")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("refresh")]
		private UIAnimationLocation _shopRefreshAnimLocation;

		// Token: 0x0403191A RID: 203034
		[Token(Token = "0x403191A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("refresh")]
		private float _shopRefreshRenderDelay;

		// Token: 0x0403191B RID: 203035
		[Token(Token = "0x403191B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _noGoodsObj;

		// Token: 0x0403191C RID: 203036
		[Token(Token = "0x403191C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<CarvingMainShopGoodCardView> _cardViewList;

		// Token: 0x0403191D RID: 203037
		[Token(Token = "0x403191D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CarvingMainShopGoodSlotView _slotView;

		// Token: 0x0403191E RID: 203038
		[Token(Token = "0x403191E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _materialScaler;

		// Token: 0x0403191F RID: 203039
		[Token(Token = "0x403191F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _materialContent;

		// Token: 0x04031920 RID: 203040
		[Token(Token = "0x4031920")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _materialObj;

		// Token: 0x04031921 RID: 203041
		[Token(Token = "0x4031921")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("buy")]
		private GameObject _canBuyObj;

		// Token: 0x04031922 RID: 203042
		[Token(Token = "0x4031922")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("buy")]
		private GameObject _canNotBuyObj;

		// Token: 0x04031923 RID: 203043
		[Token(Token = "0x4031923")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("buy")]
		private GameObject _buyGroupObj;

		// Token: 0x04031924 RID: 203044
		[Token(Token = "0x4031924")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("next step")]
		private GameObject _canNextStepObj;

		// Token: 0x04031925 RID: 203045
		[Token(Token = "0x4031925")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("next step")]
		private GameObject _canNotNextStepObj;

		// Token: 0x04031926 RID: 203046
		[Token(Token = "0x4031926")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("free cnt")]
		private UIAnimationLocation _freeNotifyAnimLocation;

		// Token: 0x04031927 RID: 203047
		[Token(Token = "0x4031927")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("free cnt")]
		private GameObject _freeCntObj;

		// Token: 0x04031928 RID: 203048
		[Token(Token = "0x4031928")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("free cnt")]
		private Text _freeCardCntTxt;

		// Token: 0x04031929 RID: 203049
		[Token(Token = "0x4031929")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _tipsObj;

		// Token: 0x0403192A RID: 203050
		[Token(Token = "0x403192A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelNextRoundMat;

		// Token: 0x0403192B RID: 203051
		[Token(Token = "0x403192B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelBtnToProcess;

		// Token: 0x0403192C RID: 203052
		[Token(Token = "0x403192C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelFreeBuyCount;

		// Token: 0x0403192D RID: 203053
		[Token(Token = "0x403192D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelBuyCardGroup;

		// Token: 0x0403192E RID: 203054
		[Token(Token = "0x403192E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelBtnBuyCard;

		// Token: 0x0403192F RID: 203055
		[Token(Token = "0x403192F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelBtnNewSlot;

		// Token: 0x04031930 RID: 203056
		[Token(Token = "0x4031930")]
		[FieldOffset(Offset = "0x120")]
		private List<CarvingMaterialModel> m_cachedMaterialList;

		// Token: 0x04031931 RID: 203057
		[Token(Token = "0x4031931")]
		[FieldOffset(Offset = "0x128")]
		private bool m_isInited;

		// Token: 0x04031932 RID: 203058
		[Token(Token = "0x4031932")]
		[FieldOffset(Offset = "0x130")]
		private CarvingMainShopView.ShopMaterialAdapter m_adapter;

		// Token: 0x04031933 RID: 203059
		[Token(Token = "0x4031933")]
		[FieldOffset(Offset = "0x138")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031934 RID: 203060
		[Token(Token = "0x4031934")]
		[FieldOffset(Offset = "0x148")]
		private int m_freeNotifySeqNum;

		// Token: 0x04031935 RID: 203061
		[Token(Token = "0x4031935")]
		[FieldOffset(Offset = "0x150")]
		private Tween m_freeNotifyTween;

		// Token: 0x04031936 RID: 203062
		[Token(Token = "0x4031936")]
		[FieldOffset(Offset = "0x158")]
		private int m_refreshNotifySeqNum;

		// Token: 0x04031937 RID: 203063
		[Token(Token = "0x4031937")]
		[FieldOffset(Offset = "0x160")]
		private Sequence m_refreshSequence;

		// Token: 0x04031938 RID: 203064
		[Token(Token = "0x4031938")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031939 RID: 203065
		[Token(Token = "0x4031939")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StateOnlyRegisterTutorialGO;

		// Token: 0x0403193A RID: 203066
		[Token(Token = "0x403193A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayRefreshTweenAndRender;

		// Token: 0x0403193B RID: 203067
		[Token(Token = "0x403193B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403193C RID: 203068
		[Token(Token = "0x403193C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403193D RID: 203069
		[Token(Token = "0x403193D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayFreeNotifyAnim;

		// Token: 0x0403193E RID: 203070
		[Token(Token = "0x403193E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickCheckInfoBtn;

		// Token: 0x0403193F RID: 203071
		[Token(Token = "0x403193F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickRefreshBtn;

		// Token: 0x04031940 RID: 203072
		[Token(Token = "0x4031940")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickBuyBtn;

		// Token: 0x04031941 RID: 203073
		[Token(Token = "0x4031941")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClickToProcessBtn;

		// Token: 0x04031942 RID: 203074
		[Token(Token = "0x4031942")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClickHandbookBtn;

		// Token: 0x04031943 RID: 203075
		[Token(Token = "0x4031943")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006092 RID: 24722
		[Token(Token = "0x2006092")]
		private class ShopMaterialAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06023C2B RID: 146475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023C2B")]
			[Address(RVA = "0x1E6A3B0", Offset = "0x1E68FB0", VA = "0x181E6A3B0")]
			public ShopMaterialAdapter(CarvingMainShopView closure)
			{
			}

			// Token: 0x17005479 RID: 21625
			// (get) Token: 0x06023C2C RID: 146476 RVA: 0x000C1DB8 File Offset: 0x000BFFB8
			[Token(Token = "0x17005479")]
			public override int count
			{
				[Token(Token = "0x6023C2C")]
				[Address(RVA = "0x1E6A430", Offset = "0x1E69030", VA = "0x181E6A430", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023C2D RID: 146477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023C2D")]
			[Address(RVA = "0x1E6A1C0", Offset = "0x1E68DC0", VA = "0x181E6A1C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031944 RID: 203076
			[Token(Token = "0x4031944")]
			[FieldOffset(Offset = "0x20")]
			private CarvingMainShopView m_closure;

			// Token: 0x04031945 RID: 203077
			[Token(Token = "0x4031945")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031946 RID: 203078
			[Token(Token = "0x4031946")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031947 RID: 203079
			[Token(Token = "0x4031947")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
