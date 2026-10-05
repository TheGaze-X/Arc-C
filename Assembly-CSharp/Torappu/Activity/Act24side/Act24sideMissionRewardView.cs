using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075E7 RID: 30183
	[Token(Token = "0x20075E7")]
	public class Act24sideMissionRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170063EE RID: 25582
		// (get) Token: 0x0602A7DE RID: 174046 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A7DF RID: 174047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063EE")]
		public Action onHideRequested
		{
			[Token(Token = "0x602A7DE")]
			[Address(RVA = "0x262BDE0", Offset = "0x262A9E0", VA = "0x18262BDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A7DF")]
			[Address(RVA = "0x262BED0", Offset = "0x262AAD0", VA = "0x18262BED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170063EF RID: 25583
		// (get) Token: 0x0602A7E0 RID: 174048 RVA: 0x000D8B58 File Offset: 0x000D6D58
		// (set) Token: 0x0602A7E1 RID: 174049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063EF")]
		private bool isRenderingFinished
		{
			[Token(Token = "0x602A7E0")]
			[Address(RVA = "0x262BC60", Offset = "0x262A860", VA = "0x18262BC60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A7E1")]
			[Address(RVA = "0x262BE40", Offset = "0x262AA40", VA = "0x18262BE40")]
			set
			{
			}
		}

		// Token: 0x170063F0 RID: 25584
		// (get) Token: 0x0602A7E2 RID: 174050 RVA: 0x000D8B70 File Offset: 0x000D6D70
		[Token(Token = "0x170063F0")]
		private int maxItemCntForEffect
		{
			[Token(Token = "0x602A7E2")]
			[Address(RVA = "0x262BD60", Offset = "0x262A960", VA = "0x18262BD60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170063F1 RID: 25585
		// (get) Token: 0x0602A7E3 RID: 174051 RVA: 0x000D8B88 File Offset: 0x000D6D88
		[Token(Token = "0x170063F1")]
		private int maxItemCntForAnimation
		{
			[Token(Token = "0x602A7E3")]
			[Address(RVA = "0x262BCE0", Offset = "0x262A8E0", VA = "0x18262BCE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602A7E4 RID: 174052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7E4")]
		[Address(RVA = "0x262A740", Offset = "0x2629340", VA = "0x18262A740")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0602A7E5 RID: 174053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7E5")]
		[Address(RVA = "0x262A6E0", Offset = "0x26292E0", VA = "0x18262A6E0")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x0602A7E6 RID: 174054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7E6")]
		[Address(RVA = "0x262A7A0", Offset = "0x26293A0", VA = "0x18262A7A0")]
		public void EventOnMaskClicked()
		{
		}

		// Token: 0x0602A7E7 RID: 174055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7E7")]
		[Address(RVA = "0x262ADF0", Offset = "0x26299F0", VA = "0x18262ADF0")]
		protected void Start()
		{
		}

		// Token: 0x0602A7E8 RID: 174056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7E8")]
		[Address(RVA = "0x262A950", Offset = "0x2629550", VA = "0x18262A950")]
		protected void OnEnable()
		{
		}

		// Token: 0x0602A7E9 RID: 174057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7E9")]
		[Address(RVA = "0x262AD40", Offset = "0x2629940", VA = "0x18262AD40")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602A7EA RID: 174058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7EA")]
		[Address(RVA = "0x262AC20", Offset = "0x2629820", VA = "0x18262AC20")]
		public void RequestHide()
		{
		}

		// Token: 0x0602A7EB RID: 174059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7EB")]
		[Address(RVA = "0x262A8A0", Offset = "0x26294A0", VA = "0x18262A8A0")]
		public IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0602A7EC RID: 174060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7EC")]
		[Address(RVA = "0x262A9C0", Offset = "0x26295C0", VA = "0x18262A9C0")]
		public void Render(Act24sideMissionRewardViewModel model, ILoadAsset assetLoader, string actId)
		{
		}

		// Token: 0x0602A7ED RID: 174061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7ED")]
		[Address(RVA = "0x262B080", Offset = "0x2629C80", VA = "0x18262B080")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A7EE RID: 174062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7EE")]
		[Address(RVA = "0x262B840", Offset = "0x262A440", VA = "0x18262B840")]
		private void _UpdateAutoLayouts()
		{
		}

		// Token: 0x0602A7EF RID: 174063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7EF")]
		[Address(RVA = "0x262BA50", Offset = "0x262A650", VA = "0x18262BA50")]
		private IEnumerator _UpdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0602A7F0 RID: 174064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7F0")]
		[Address(RVA = "0x262B2E0", Offset = "0x2629EE0", VA = "0x18262B2E0")]
		private void _OnItemListRenderFinished()
		{
		}

		// Token: 0x0602A7F1 RID: 174065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7F1")]
		[Address(RVA = "0x262B340", Offset = "0x2629F40", VA = "0x18262B340")]
		private void _SetItemsModels(IList<UIItemViewModel> itemModels, IList<Act24sideMeldingItemViewModel> actItemModels)
		{
		}

		// Token: 0x0602A7F2 RID: 174066 RVA: 0x000D8BA0 File Offset: 0x000D6DA0
		[Token(Token = "0x602A7F2")]
		[Address(RVA = "0x262AFC0", Offset = "0x2629BC0", VA = "0x18262AFC0")]
		private int _CompareItemModelWithSortId(UIItemViewModel lhs, UIItemViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0602A7F3 RID: 174067 RVA: 0x000D8BB8 File Offset: 0x000D6DB8
		[Token(Token = "0x602A7F3")]
		[Address(RVA = "0x262AF00", Offset = "0x2629B00", VA = "0x18262AF00")]
		private int _CompareItemModelWithSortId(Act24sideMeldingItemViewModel lhs, Act24sideMeldingItemViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0602A7F4 RID: 174068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7F4")]
		[Address(RVA = "0x262BB00", Offset = "0x262A700", VA = "0x18262BB00")]
		public Act24sideMissionRewardView()
		{
		}

		// Token: 0x0403D2A0 RID: 250528
		[Token(Token = "0x403D2A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _floatPanel;

		// Token: 0x0403D2A1 RID: 250529
		[Token(Token = "0x403D2A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0403D2A2 RID: 250530
		[Token(Token = "0x403D2A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemGridLayout;

		// Token: 0x0403D2A3 RID: 250531
		[Token(Token = "0x403D2A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _actItemGridLayout;

		// Token: 0x0403D2A4 RID: 250532
		[Token(Token = "0x403D2A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x0403D2A5 RID: 250533
		[Token(Token = "0x403D2A5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0403D2A6 RID: 250534
		[Token(Token = "0x403D2A6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _itemScroll;

		// Token: 0x0403D2A7 RID: 250535
		[Token(Token = "0x403D2A7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GridLayoutGroup _gridLayoutGroup;

		// Token: 0x0403D2A8 RID: 250536
		[Token(Token = "0x403D2A8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VerticalLayoutGroup _verticalLayoutGroup;

		// Token: 0x0403D2A9 RID: 250537
		[Token(Token = "0x403D2A9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _topMask;

		// Token: 0x0403D2AA RID: 250538
		[Token(Token = "0x403D2AA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _normTitle;

		// Token: 0x0403D2AB RID: 250539
		[Token(Token = "0x403D2AB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _actTitle;

		// Token: 0x0403D2AC RID: 250540
		[Token(Token = "0x403D2AC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Details")]
		private Transform _effectHolder;

		// Token: 0x0403D2AD RID: 250541
		[Token(Token = "0x403D2AD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Details")]
		private float _delayToShowEachItem;

		// Token: 0x0403D2AE RID: 250542
		[Token(Token = "0x403D2AE")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Group("Details")]
		private int _maxRowForEffect;

		// Token: 0x0403D2AF RID: 250543
		[Token(Token = "0x403D2AF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Details")]
		private int _maxRowForAnimation;

		// Token: 0x0403D2B0 RID: 250544
		[Token(Token = "0x403D2B0")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Group("Details")]
		private int _topPaddingSingleRow;

		// Token: 0x0403D2B1 RID: 250545
		[Token(Token = "0x403D2B1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Details")]
		private int _topPaddingMultiRows;

		// Token: 0x0403D2B2 RID: 250546
		[Token(Token = "0x403D2B2")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Group("Details")]
		private int _topPaddingSingleNormItem;

		// Token: 0x0403D2B3 RID: 250547
		[Token(Token = "0x403D2B3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Details")]
		private int _topPaddingSingleActItem;

		// Token: 0x0403D2B4 RID: 250548
		[Token(Token = "0x403D2B4")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIItemViewModel> m_itemModels;

		// Token: 0x0403D2B5 RID: 250549
		[Token(Token = "0x403D2B5")]
		[FieldOffset(Offset = "0xA8")]
		private List<Act24sideMeldingItemViewModel> m_actItemModels;

		// Token: 0x0403D2B6 RID: 250550
		[Token(Token = "0x403D2B6")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0403D2B7 RID: 250551
		[Token(Token = "0x403D2B7")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_isLayoutUpdating;

		// Token: 0x0403D2B8 RID: 250552
		[Token(Token = "0x403D2B8")]
		[FieldOffset(Offset = "0xB8")]
		private Act24sideMissionRewardView.NormalItemAdapter m_normalItemAdapter;

		// Token: 0x0403D2B9 RID: 250553
		[Token(Token = "0x403D2B9")]
		[FieldOffset(Offset = "0xC0")]
		private Act24sideMissionRewardView.ActItemAdapter m_actItemAdapter;

		// Token: 0x0403D2BA RID: 250554
		[Token(Token = "0x403D2BA")]
		[FieldOffset(Offset = "0xC8")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0403D2BB RID: 250555
		[Token(Token = "0x403D2BB")]
		[FieldOffset(Offset = "0xD0")]
		private string m_actId;

		// Token: 0x0403D2BD RID: 250557
		[Token(Token = "0x403D2BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onHideRequested;

		// Token: 0x0403D2BE RID: 250558
		[Token(Token = "0x403D2BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onHideRequested;

		// Token: 0x0403D2BF RID: 250559
		[Token(Token = "0x403D2BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isRenderingFinished;

		// Token: 0x0403D2C0 RID: 250560
		[Token(Token = "0x403D2C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isRenderingFinished;

		// Token: 0x0403D2C1 RID: 250561
		[Token(Token = "0x403D2C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxItemCntForEffect;

		// Token: 0x0403D2C2 RID: 250562
		[Token(Token = "0x403D2C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_maxItemCntForAnimation;

		// Token: 0x0403D2C3 RID: 250563
		[Token(Token = "0x403D2C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0403D2C4 RID: 250564
		[Token(Token = "0x403D2C4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBlankClicked;

		// Token: 0x0403D2C5 RID: 250565
		[Token(Token = "0x403D2C5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnMaskClicked;

		// Token: 0x0403D2C6 RID: 250566
		[Token(Token = "0x403D2C6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403D2C7 RID: 250567
		[Token(Token = "0x403D2C7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403D2C8 RID: 250568
		[Token(Token = "0x403D2C8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403D2C9 RID: 250569
		[Token(Token = "0x403D2C9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RequestHide;

		// Token: 0x0403D2CA RID: 250570
		[Token(Token = "0x403D2CA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403D2CB RID: 250571
		[Token(Token = "0x403D2CB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D2CC RID: 250572
		[Token(Token = "0x403D2CC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D2CD RID: 250573
		[Token(Token = "0x403D2CD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayouts;

		// Token: 0x0403D2CE RID: 250574
		[Token(Token = "0x403D2CE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateLayoutCoroutine;

		// Token: 0x0403D2CF RID: 250575
		[Token(Token = "0x403D2CF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnItemListRenderFinished;

		// Token: 0x0403D2D0 RID: 250576
		[Token(Token = "0x403D2D0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetItemsModels;

		// Token: 0x0403D2D1 RID: 250577
		[Token(Token = "0x403D2D1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CompareItemModelWithSortId;

		// Token: 0x0403D2D2 RID: 250578
		[Token(Token = "0x403D2D2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix1__CompareItemModelWithSortId;

		// Token: 0x0403D2D3 RID: 250579
		[Token(Token = "0x403D2D3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075E8 RID: 30184
		[Token(Token = "0x20075E8")]
		private abstract class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A7F5 RID: 174069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7F5")]
			[Address(RVA = "0x2633BA0", Offset = "0x26327A0", VA = "0x182633BA0")]
			public void OnMaskClicked()
			{
			}

			// Token: 0x0602A7F6 RID: 174070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7F6")]
			[Address(RVA = "0x2633AF0", Offset = "0x26326F0", VA = "0x182633AF0")]
			public void OnHide()
			{
			}

			// Token: 0x0602A7F7 RID: 174071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7F7")]
			[Address(RVA = "0x2633A60", Offset = "0x2632660", VA = "0x182633A60", Slot = "8")]
			public override void NotifyDataSetChanged()
			{
			}

			// Token: 0x0602A7F8 RID: 174072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7F8")]
			[Address(RVA = "0x2633F70", Offset = "0x2632B70", VA = "0x182633F70")]
			protected void _OnItemCardRenderFinished()
			{
			}

			// Token: 0x0602A7F9 RID: 174073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7F9")]
			[Address(RVA = "0x2633E00", Offset = "0x2632A00", VA = "0x182633E00")]
			private void _ForeachItemCard(Action<Act24sideMissionRewardCardView> callback)
			{
			}

			// Token: 0x0602A7FA RID: 174074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7FA")]
			[Address(RVA = "0x2634000", Offset = "0x2632C00", VA = "0x182634000")]
			protected ItemAdapter()
			{
			}

			// Token: 0x0602A7FD RID: 174077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7FD")]
			[Address(RVA = "0xDEAD20", Offset = "0xDE9920", VA = "0x180DEAD20")]
			private void <>xLuaBaseProxy_NotifyDataSetChanged()
			{
			}

			// Token: 0x0403D2D4 RID: 250580
			[Token(Token = "0x403D2D4")]
			[FieldOffset(Offset = "0x20")]
			protected Act24sideMissionRewardView m_closure;

			// Token: 0x0403D2D5 RID: 250581
			[Token(Token = "0x403D2D5")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isItemsRendering;

			// Token: 0x0403D2D6 RID: 250582
			[Token(Token = "0x403D2D6")]
			[FieldOffset(Offset = "0x2C")]
			private int m_pendingItemCntToRender;

			// Token: 0x0403D2D7 RID: 250583
			[Token(Token = "0x403D2D7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnMaskClicked;

			// Token: 0x0403D2D8 RID: 250584
			[Token(Token = "0x403D2D8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnHide;

			// Token: 0x0403D2D9 RID: 250585
			[Token(Token = "0x403D2D9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_NotifyDataSetChanged;

			// Token: 0x0403D2DA RID: 250586
			[Token(Token = "0x403D2DA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__OnItemCardRenderFinished;

			// Token: 0x0403D2DB RID: 250587
			[Token(Token = "0x403D2DB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__ForeachItemCard;

			// Token: 0x0403D2DC RID: 250588
			[Token(Token = "0x403D2DC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020075E9 RID: 30185
		[Token(Token = "0x20075E9")]
		private class NormalItemAdapter : Act24sideMissionRewardView.ItemAdapter
		{
			// Token: 0x0602A7FE RID: 174078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7FE")]
			[Address(RVA = "0x26343E0", Offset = "0x2632FE0", VA = "0x1826343E0")]
			public NormalItemAdapter(Act24sideMissionRewardView closure)
			{
			}

			// Token: 0x170063F2 RID: 25586
			// (get) Token: 0x0602A7FF RID: 174079 RVA: 0x000D8BD0 File Offset: 0x000D6DD0
			[Token(Token = "0x170063F2")]
			public override int count
			{
				[Token(Token = "0x602A7FF")]
				[Address(RVA = "0x26344A0", Offset = "0x26330A0", VA = "0x1826344A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A800 RID: 174080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A800")]
			[Address(RVA = "0x2634060", Offset = "0x2632C60", VA = "0x182634060", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D2DD RID: 250589
			[Token(Token = "0x403D2DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D2DE RID: 250590
			[Token(Token = "0x403D2DE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D2DF RID: 250591
			[Token(Token = "0x403D2DF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020075EA RID: 30186
		[Token(Token = "0x20075EA")]
		private class ActItemAdapter : Act24sideMissionRewardView.ItemAdapter
		{
			// Token: 0x0602A801 RID: 174081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A801")]
			[Address(RVA = "0x2633190", Offset = "0x2631D90", VA = "0x182633190")]
			public ActItemAdapter(Act24sideMissionRewardView closure)
			{
			}

			// Token: 0x170063F3 RID: 25587
			// (get) Token: 0x0602A802 RID: 174082 RVA: 0x000D8BE8 File Offset: 0x000D6DE8
			[Token(Token = "0x170063F3")]
			public override int count
			{
				[Token(Token = "0x602A802")]
				[Address(RVA = "0x2633250", Offset = "0x2631E50", VA = "0x182633250", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A803 RID: 174083 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A803")]
			[Address(RVA = "0x2632D90", Offset = "0x2631990", VA = "0x182632D90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D2E0 RID: 250592
			[Token(Token = "0x403D2E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D2E1 RID: 250593
			[Token(Token = "0x403D2E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D2E2 RID: 250594
			[Token(Token = "0x403D2E2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
