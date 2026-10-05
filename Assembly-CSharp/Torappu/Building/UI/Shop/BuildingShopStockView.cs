using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001D01 RID: 7425
	[Token(Token = "0x2001D01")]
	public class BuildingShopStockView : DataBinder<SStockViewProperty>, ITimeWatcher
	{
		// Token: 0x0600B75C RID: 46940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B75C")]
		[Address(RVA = "0x3345260", Offset = "0x3343E60", VA = "0x183345260", Slot = "7")]
		public override void OnValueChanged(SStockViewProperty property)
		{
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B75D")]
		[Address(RVA = "0x3345D80", Offset = "0x3344980", VA = "0x183345D80")]
		private void _Init(SStockViewModel viewModel)
		{
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B75E")]
		[Address(RVA = "0x3346420", Offset = "0x3345020", VA = "0x183346420")]
		private void _UpdateCountDowns(SStockViewModel viewModel, ShopStockSnapshot snapshot)
		{
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B75F")]
		[Address(RVA = "0x3346110", Offset = "0x3344D10", VA = "0x183346110")]
		private void _InvokeCountChanged(int delta)
		{
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B760")]
		[Address(RVA = "0x33459C0", Offset = "0x33445C0", VA = "0x1833459C0")]
		private void Start()
		{
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B761")]
		[Address(RVA = "0x3345200", Offset = "0x3343E00", VA = "0x183345200")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B762")]
		[Address(RVA = "0x3345170", Offset = "0x3343D70", VA = "0x183345170")]
		public void EventOnFormulaClicked()
		{
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B763")]
		[Address(RVA = "0x33450F0", Offset = "0x3343CF0", VA = "0x1833450F0")]
		public void EventOnEditConfirmed()
		{
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B764")]
		[Address(RVA = "0x3345070", Offset = "0x3343C70", VA = "0x183345070")]
		public void EventOnEditCancelled()
		{
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B765")]
		[Address(RVA = "0x3345A20", Offset = "0x3344620", VA = "0x183345A20", Slot = "8")]
		public void UpdateTime(float timeDelta)
		{
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B766")]
		[Address(RVA = "0x3345AB0", Offset = "0x33446B0", VA = "0x183345AB0")]
		private void _CountDownProgress(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x0600B767 RID: 46951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B767")]
		[Address(RVA = "0x3345B60", Offset = "0x3344760", VA = "0x183345B60")]
		private void _CountDownRemainTime(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x0600B768 RID: 46952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B768")]
		[Address(RVA = "0x33461A0", Offset = "0x3344DA0", VA = "0x1833461A0")]
		private void _OnAvatarClicked(BuildingCharModel model, object param)
		{
		}

		// Token: 0x0600B769 RID: 46953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B769")]
		[Address(RVA = "0x3346360", Offset = "0x3344F60", VA = "0x183346360")]
		private void _OnPlusClicked()
		{
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B76A")]
		[Address(RVA = "0x3346290", Offset = "0x3344E90", VA = "0x183346290")]
		private void _OnMinusClicked()
		{
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x00045210 File Offset: 0x00043410
		[Token(Token = "0x600B76B")]
		[Address(RVA = "0x33463C0", Offset = "0x3344FC0", VA = "0x1833463C0")]
		private bool _OnPlusLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x00045228 File Offset: 0x00043428
		[Token(Token = "0x600B76C")]
		[Address(RVA = "0x33462F0", Offset = "0x3344EF0", VA = "0x1833462F0")]
		private bool _OnMinusLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B76D")]
		[Address(RVA = "0x3346800", Offset = "0x3345400", VA = "0x183346800")]
		public BuildingShopStockView()
		{
		}

		// Token: 0x0400B554 RID: 46420
		[Token(Token = "0x400B554")]
		private const string INVALID_TIME = "-:--:--";

		// Token: 0x0400B555 RID: 46421
		[Token(Token = "0x400B555")]
		private const int LONG_PRESS_DELTA = 5;

		// Token: 0x0400B556 RID: 46422
		[Token(Token = "0x400B556")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B557 RID: 46423
		[Token(Token = "0x400B557")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textReserve;

		// Token: 0x0400B558 RID: 46424
		[Token(Token = "0x400B558")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRemain;

		// Token: 0x0400B559 RID: 46425
		[Token(Token = "0x400B559")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRemainInactive;

		// Token: 0x0400B55A RID: 46426
		[Token(Token = "0x400B55A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textLimit;

		// Token: 0x0400B55B RID: 46427
		[Token(Token = "0x400B55B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StretchProgressBar _progressBar;

		// Token: 0x0400B55C RID: 46428
		[Token(Token = "0x400B55C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400B55D RID: 46429
		[Token(Token = "0x400B55D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIItemCard _itemPrefab;

		// Token: 0x0400B55E RID: 46430
		[Token(Token = "0x400B55E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x0400B55F RID: 46431
		[Token(Token = "0x400B55F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400B560 RID: 46432
		[Token(Token = "0x400B560")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400B561 RID: 46433
		[Token(Token = "0x400B561")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0400B562 RID: 46434
		[Token(Token = "0x400B562")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelChanged;

		// Token: 0x0400B563 RID: 46435
		[Token(Token = "0x400B563")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelStation;

		// Token: 0x0400B564 RID: 46436
		[Token(Token = "0x400B564")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelPause;

		// Token: 0x0400B565 RID: 46437
		[Token(Token = "0x400B565")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelFinish;

		// Token: 0x0400B566 RID: 46438
		[Token(Token = "0x400B566")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelUnlockCommon;

		// Token: 0x0400B567 RID: 46439
		[Token(Token = "0x400B567")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0400B568 RID: 46440
		[Token(Token = "0x400B568")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private BuildingCharAvatar _avatarPrefab;

		// Token: 0x0400B569 RID: 46441
		[Token(Token = "0x400B569")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0400B56A RID: 46442
		[Token(Token = "0x400B56A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UILongPressButton _btnPlus;

		// Token: 0x0400B56B RID: 46443
		[Token(Token = "0x400B56B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UILongPressButton _btnMinus;

		// Token: 0x0400B56C RID: 46444
		[Token(Token = "0x400B56C")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0400B56D RID: 46445
		[Token(Token = "0x400B56D")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isInited;

		// Token: 0x0400B56E RID: 46446
		[Token(Token = "0x400B56E")]
		[FieldOffset(Offset = "0xE0")]
		private UIItemCard m_itemCard;

		// Token: 0x0400B56F RID: 46447
		[Token(Token = "0x400B56F")]
		[FieldOffset(Offset = "0xE8")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0400B570 RID: 46448
		[Token(Token = "0x400B570")]
		[FieldOffset(Offset = "0xF0")]
		private BuildingCharModel m_charModel;

		// Token: 0x0400B571 RID: 46449
		[Token(Token = "0x400B571")]
		[FieldOffset(Offset = "0x168")]
		private BuildingCharAvatar m_charAvatar;

		// Token: 0x0400B572 RID: 46450
		[Token(Token = "0x400B572")]
		[FieldOffset(Offset = "0x170")]
		private int m_secsPerItem;

		// Token: 0x0400B573 RID: 46451
		[Token(Token = "0x400B573")]
		[FieldOffset(Offset = "0x178")]
		private SStockViewModel m_cachedViewModel;

		// Token: 0x0400B574 RID: 46452
		[Token(Token = "0x400B574")]
		[FieldOffset(Offset = "0x180")]
		private CountDownTask m_progressCountDown;

		// Token: 0x0400B575 RID: 46453
		[Token(Token = "0x400B575")]
		[FieldOffset(Offset = "0x188")]
		private CountDownTask m_remainTimeCountDown;

		// Token: 0x0400B576 RID: 46454
		[Token(Token = "0x400B576")]
		[FieldOffset(Offset = "0x190")]
		[NonSerialized]
		public BuildingShopStockView.Listeners listeners;

		// Token: 0x0400B577 RID: 46455
		[Token(Token = "0x400B577")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B578 RID: 46456
		[Token(Token = "0x400B578")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400B579 RID: 46457
		[Token(Token = "0x400B579")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateCountDowns;

		// Token: 0x0400B57A RID: 46458
		[Token(Token = "0x400B57A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InvokeCountChanged;

		// Token: 0x0400B57B RID: 46459
		[Token(Token = "0x400B57B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400B57C RID: 46460
		[Token(Token = "0x400B57C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400B57D RID: 46461
		[Token(Token = "0x400B57D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnFormulaClicked;

		// Token: 0x0400B57E RID: 46462
		[Token(Token = "0x400B57E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnEditConfirmed;

		// Token: 0x0400B57F RID: 46463
		[Token(Token = "0x400B57F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnEditCancelled;

		// Token: 0x0400B580 RID: 46464
		[Token(Token = "0x400B580")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0400B581 RID: 46465
		[Token(Token = "0x400B581")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CountDownProgress;

		// Token: 0x0400B582 RID: 46466
		[Token(Token = "0x400B582")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CountDownRemainTime;

		// Token: 0x0400B583 RID: 46467
		[Token(Token = "0x400B583")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnAvatarClicked;

		// Token: 0x0400B584 RID: 46468
		[Token(Token = "0x400B584")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnPlusClicked;

		// Token: 0x0400B585 RID: 46469
		[Token(Token = "0x400B585")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnMinusClicked;

		// Token: 0x0400B586 RID: 46470
		[Token(Token = "0x400B586")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnPlusLongPressed;

		// Token: 0x0400B587 RID: 46471
		[Token(Token = "0x400B587")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnMinusLongPressed;

		// Token: 0x0400B588 RID: 46472
		[Token(Token = "0x400B588")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D02 RID: 7426
		[Token(Token = "0x2001D02")]
		public struct Listeners
		{
			// Token: 0x0400B589 RID: 46473
			[Token(Token = "0x400B589")]
			[FieldOffset(Offset = "0x0")]
			public Action<SStockViewModel, int> onCountChanged;

			// Token: 0x0400B58A RID: 46474
			[Token(Token = "0x400B58A")]
			[FieldOffset(Offset = "0x8")]
			public Action<SStockViewModel> onFormulaClicked;

			// Token: 0x0400B58B RID: 46475
			[Token(Token = "0x400B58B")]
			[FieldOffset(Offset = "0x10")]
			public Action<SStockViewModel> onCharClicked;

			// Token: 0x0400B58C RID: 46476
			[Token(Token = "0x400B58C")]
			[FieldOffset(Offset = "0x18")]
			public Action<SStockViewModel> onEditConfirmed;

			// Token: 0x0400B58D RID: 46477
			[Token(Token = "0x400B58D")]
			[FieldOffset(Offset = "0x20")]
			public Action<SStockViewModel> onEditCancelled;
		}
	}
}
