using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004487 RID: 17543
	[Token(Token = "0x2004487")]
	public class RoguelikeTopicBattlePassPurchaseGrandPrizeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ACD8 RID: 109784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACD8")]
		[Address(RVA = "0x13F53C0", Offset = "0x13F3FC0", VA = "0x1813F53C0")]
		public void Render(RoguelikeTopicBPPrizeViewModel itemModel, RoguelikeTopicBattlePassPurchaseViewModel outerModel, RoguelikeTopicBattlePassStyle style)
		{
		}

		// Token: 0x0601ACD9 RID: 109785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACD9")]
		[Address(RVA = "0x13F5730", Offset = "0x13F4330", VA = "0x1813F5730")]
		private void _RenderGrandPrizeStatus(RoguelikeTopicBPPrizeViewModel itemModel, RoguelikeTopicBattlePassPurchaseViewModel outerModel)
		{
		}

		// Token: 0x0601ACDA RID: 109786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACDA")]
		[Address(RVA = "0x13F59C0", Offset = "0x13F45C0", VA = "0x1813F59C0")]
		private void _RenderState(RoguelikeTopicBPPrizeViewModel itemModel, RoguelikeTopicBattlePassPurchaseViewModel outerModel, bool isInit)
		{
		}

		// Token: 0x0601ACDB RID: 109787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACDB")]
		[Address(RVA = "0x13F5CA0", Offset = "0x13F48A0", VA = "0x1813F5CA0")]
		private void _SwitchToState(RoguelikeTopicBattlePassPurchaseGrandPrizeView.State state, bool isInit)
		{
		}

		// Token: 0x0601ACDC RID: 109788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACDC")]
		[Address(RVA = "0x13F5AB0", Offset = "0x13F46B0", VA = "0x1813F5AB0")]
		private void _SetStyleIfNeeded(RoguelikeTopicBattlePassStyle style)
		{
		}

		// Token: 0x0601ACDD RID: 109789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACDD")]
		[Address(RVA = "0x13F5340", Offset = "0x13F3F40", VA = "0x1813F5340")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0601ACDE RID: 109790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACDE")]
		[Address(RVA = "0x13F6200", Offset = "0x13F4E00", VA = "0x1813F6200")]
		public RoguelikeTopicBattlePassPurchaseGrandPrizeView()
		{
		}

		// Token: 0x040224A3 RID: 140451
		[Token(Token = "0x40224A3")]
		private const string GRAND_PRIZE_CARD_IMAGE_PREFIX = "card_{0}";

		// Token: 0x040224A4 RID: 140452
		[Token(Token = "0x40224A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgPrize;

		// Token: 0x040224A5 RID: 140453
		[Token(Token = "0x40224A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x040224A6 RID: 140454
		[Token(Token = "0x40224A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textType;

		// Token: 0x040224A7 RID: 140455
		[Token(Token = "0x40224A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040224A8 RID: 140456
		[Token(Token = "0x40224A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasUnavailable;

		// Token: 0x040224A9 RID: 140457
		[Token(Token = "0x40224A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x040224AA RID: 140458
		[Token(Token = "0x40224AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasUnselected;

		// Token: 0x040224AB RID: 140459
		[Token(Token = "0x40224AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasRoot;

		// Token: 0x040224AC RID: 140460
		[Token(Token = "0x40224AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasLight;

		// Token: 0x040224AD RID: 140461
		[Token(Token = "0x40224AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _line;

		// Token: 0x040224AE RID: 140462
		[Token(Token = "0x40224AE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _unavailableMask;

		// Token: 0x040224AF RID: 140463
		[Token(Token = "0x40224AF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _disabledReason;

		// Token: 0x040224B0 RID: 140464
		[Token(Token = "0x40224B0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _iconSelected;

		// Token: 0x040224B1 RID: 140465
		[Token(Token = "0x40224B1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _imgLight;

		// Token: 0x040224B2 RID: 140466
		[Token(Token = "0x40224B2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x040224B3 RID: 140467
		[Token(Token = "0x40224B3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Anim Config")]
		private float _alphaUnavailable;

		// Token: 0x040224B4 RID: 140468
		[Token(Token = "0x40224B4")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Group("Anim Config")]
		private float _alphaSelected;

		// Token: 0x040224B5 RID: 140469
		[Token(Token = "0x40224B5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Anim Config")]
		private float _alphaUnselected;

		// Token: 0x040224B6 RID: 140470
		[Token(Token = "0x40224B6")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Group("Anim Config")]
		private Color _colorUnavailable;

		// Token: 0x040224B7 RID: 140471
		[Token(Token = "0x40224B7")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Group("Anim Config")]
		private Color _colorUnselected;

		// Token: 0x040224B8 RID: 140472
		[Token(Token = "0x40224B8")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Group("Anim Config")]
		private float _animDuration;

		// Token: 0x040224B9 RID: 140473
		[Token(Token = "0x40224B9")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_stateTween;

		// Token: 0x040224BA RID: 140474
		[Token(Token = "0x40224BA")]
		[FieldOffset(Offset = "0xC8")]
		private long m_cachedWidgetId;

		// Token: 0x040224BB RID: 140475
		[Token(Token = "0x40224BB")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedGrandPrizeId;

		// Token: 0x040224BC RID: 140476
		[Token(Token = "0x40224BC")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeTopicBattlePassPurchaseGrandPrizeView.State m_cachedState;

		// Token: 0x040224BD RID: 140477
		[Token(Token = "0x40224BD")]
		[FieldOffset(Offset = "0xDC")]
		private Color m_colorSelected;

		// Token: 0x040224BE RID: 140478
		[Token(Token = "0x40224BE")]
		[FieldOffset(Offset = "0xF0")]
		private RoguelikeTopicBattlePassStyle m_style;

		// Token: 0x040224BF RID: 140479
		[Token(Token = "0x40224BF")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		public Action<string> onBtnClicked;

		// Token: 0x040224C0 RID: 140480
		[Token(Token = "0x40224C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040224C1 RID: 140481
		[Token(Token = "0x40224C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderGrandPrizeStatus;

		// Token: 0x040224C2 RID: 140482
		[Token(Token = "0x40224C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderState;

		// Token: 0x040224C3 RID: 140483
		[Token(Token = "0x40224C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SwitchToState;

		// Token: 0x040224C4 RID: 140484
		[Token(Token = "0x40224C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetStyleIfNeeded;

		// Token: 0x040224C5 RID: 140485
		[Token(Token = "0x40224C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x040224C6 RID: 140486
		[Token(Token = "0x40224C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004488 RID: 17544
		[Token(Token = "0x2004488")]
		private enum State
		{
			// Token: 0x040224C8 RID: 140488
			[Token(Token = "0x40224C8")]
			UNAVAILABLE,
			// Token: 0x040224C9 RID: 140489
			[Token(Token = "0x40224C9")]
			SELECTED,
			// Token: 0x040224CA RID: 140490
			[Token(Token = "0x40224CA")]
			UNSELECTED
		}
	}
}
