using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.HalfIdle
{
	// Token: 0x02003421 RID: 13345
	[Token(Token = "0x2003421")]
	public class HalfIdleUIBattleCardListWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0601557F RID: 87423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003284")]
		private GameModeFactory.HalfIdleGameMode gameMode
		{
			[Token(Token = "0x601557F")]
			[Address(RVA = "0xDCF090", Offset = "0xDCDC90", VA = "0x180DCF090")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015580 RID: 87424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015580")]
		[Address(RVA = "0xDCE520", Offset = "0xDCD120", VA = "0x180DCE520")]
		public void OnInit(UIController uiController)
		{
		}

		// Token: 0x06015581 RID: 87425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015581")]
		[Address(RVA = "0xDCE810", Offset = "0xDCD410", VA = "0x180DCE810")]
		public void OnUpdate()
		{
		}

		// Token: 0x06015582 RID: 87426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015582")]
		[Address(RVA = "0xDCE930", Offset = "0xDCD530", VA = "0x180DCE930")]
		private void _OnGainCard(object arg)
		{
		}

		// Token: 0x06015583 RID: 87427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015583")]
		[Address(RVA = "0xDCE8A0", Offset = "0xDCD4A0", VA = "0x180DCE8A0")]
		private void _OnCardListChanged(object arg)
		{
		}

		// Token: 0x06015584 RID: 87428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015584")]
		[Address(RVA = "0xDCEE80", Offset = "0xDCDA80", VA = "0x180DCEE80")]
		private void _UpdateWidget(bool forceRefresh = false)
		{
		}

		// Token: 0x06015585 RID: 87429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015585")]
		[Address(RVA = "0xDCEC50", Offset = "0xDCD850", VA = "0x180DCEC50")]
		private void _SetPageIndex()
		{
		}

		// Token: 0x06015586 RID: 87430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015586")]
		[Address(RVA = "0xDCEAE0", Offset = "0xDCD6E0", VA = "0x180DCEAE0")]
		public void _OnTogglePageClicked()
		{
		}

		// Token: 0x06015587 RID: 87431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015587")]
		[Address(RVA = "0xDCF010", Offset = "0xDCDC10", VA = "0x180DCF010")]
		public HalfIdleUIBattleCardListWidget()
		{
		}

		// Token: 0x0401986F RID: 104559
		[Token(Token = "0x401986F")]
		private const string GRAY_PAGE_CNT_FORMAT = "<color=#7E7E7E>{0}</color>/{1}";

		// Token: 0x04019870 RID: 104560
		[Token(Token = "0x4019870")]
		private const string NORMAL_PAGE_CNT_FORMAT = "<color=#FFFFFF>{0}</color>/{1}";

		// Token: 0x04019871 RID: 104561
		[Token(Token = "0x4019871")]
		private const int PAGE_1_INDEX = 1;

		// Token: 0x04019872 RID: 104562
		[Token(Token = "0x4019872")]
		private const int DISABLE_TOGGLE_PAGE_CNT = 1;

		// Token: 0x04019873 RID: 104563
		[Token(Token = "0x4019873")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 CardListOffsetMax;

		// Token: 0x04019874 RID: 104564
		[Token(Token = "0x4019874")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 CardListOffsetMin;

		// Token: 0x04019875 RID: 104565
		[Token(Token = "0x4019875")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCurPage;

		// Token: 0x04019876 RID: 104566
		[Token(Token = "0x4019876")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _buttonToggle;

		// Token: 0x04019877 RID: 104567
		[Token(Token = "0x4019877")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x04019878 RID: 104568
		[Token(Token = "0x4019878")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x04019879 RID: 104569
		[Token(Token = "0x4019879")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pageIndex1;

		// Token: 0x0401987A RID: 104570
		[Token(Token = "0x401987A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pageIndex2;

		// Token: 0x0401987B RID: 104571
		[Token(Token = "0x401987B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _getCardAnim;

		// Token: 0x0401987C RID: 104572
		[Token(Token = "0x401987C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private HalfIdleUICardPlugin _uiCardPlugin;

		// Token: 0x0401987D RID: 104573
		[Token(Token = "0x401987D")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isTrapCardShown;

		// Token: 0x0401987E RID: 104574
		[Token(Token = "0x401987E")]
		[FieldOffset(Offset = "0x68")]
		private UIController m_uiController;

		// Token: 0x0401987F RID: 104575
		[Token(Token = "0x401987F")]
		[FieldOffset(Offset = "0x70")]
		private bool m_initialized;

		// Token: 0x04019880 RID: 104576
		[Token(Token = "0x4019880")]
		[FieldOffset(Offset = "0x74")]
		private int m_curPageIndex;

		// Token: 0x04019881 RID: 104577
		[Token(Token = "0x4019881")]
		[FieldOffset(Offset = "0x78")]
		private int m_maxPageNum;

		// Token: 0x04019882 RID: 104578
		[Token(Token = "0x4019882")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_gainCardTween;

		// Token: 0x04019883 RID: 104579
		[Token(Token = "0x4019883")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x04019884 RID: 104580
		[Token(Token = "0x4019884")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019885 RID: 104581
		[Token(Token = "0x4019885")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04019886 RID: 104582
		[Token(Token = "0x4019886")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnGainCard;

		// Token: 0x04019887 RID: 104583
		[Token(Token = "0x4019887")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCardListChanged;

		// Token: 0x04019888 RID: 104584
		[Token(Token = "0x4019888")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateWidget;

		// Token: 0x04019889 RID: 104585
		[Token(Token = "0x4019889")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetPageIndex;

		// Token: 0x0401988A RID: 104586
		[Token(Token = "0x401988A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnTogglePageClicked;

		// Token: 0x0401988B RID: 104587
		[Token(Token = "0x401988B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
