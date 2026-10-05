using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062F6 RID: 25334
	[Token(Token = "0x20062F6")]
	public class AutoChessSettleGameTeamPlayerCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170055F3 RID: 22003
		// (get) Token: 0x0602483A RID: 149562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602483B RID: 149563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055F3")]
		public Action<string> onReportBtnClick
		{
			[Token(Token = "0x602483A")]
			[Address(RVA = "0x1F5FBC0", Offset = "0x1F5E7C0", VA = "0x181F5FBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602483B")]
			[Address(RVA = "0x1F5FC20", Offset = "0x1F5E820", VA = "0x181F5FC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602483C RID: 149564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602483C")]
		[Address(RVA = "0x1F5E1E0", Offset = "0x1F5CDE0", VA = "0x181F5E1E0")]
		public void Render(AutoChessSettleGameTeamPlayerCardViewModel viewModel)
		{
		}

		// Token: 0x0602483D RID: 149565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602483D")]
		[Address(RVA = "0x1F5E510", Offset = "0x1F5D110", VA = "0x181F5E510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602483E RID: 149566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602483E")]
		[Address(RVA = "0x1F5F0E0", Offset = "0x1F5DCE0", VA = "0x181F5F0E0")]
		private void _RenderBaseInfoPart(AutoChessSettleGameTeamPlayerCardViewModel viewModel)
		{
		}

		// Token: 0x0602483F RID: 149567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602483F")]
		[Address(RVA = "0x1F5F490", Offset = "0x1F5E090", VA = "0x181F5F490")]
		private void _RenderInteractPart(AutoChessSettleGameTeamPlayerCardViewModel viewModel)
		{
		}

		// Token: 0x06024840 RID: 149568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024840")]
		[Address(RVA = "0x1F5E080", Offset = "0x1F5CC80", VA = "0x181F5E080")]
		private void OnDestroy()
		{
		}

		// Token: 0x06024841 RID: 149569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024841")]
		[Address(RVA = "0x1F5EFC0", Offset = "0x1F5DBC0", VA = "0x181F5EFC0")]
		private void _RegisterReceiveLikeEvent()
		{
		}

		// Token: 0x06024842 RID: 149570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024842")]
		[Address(RVA = "0x1F5F9E0", Offset = "0x1F5E5E0", VA = "0x181F5F9E0")]
		private void _UnRegisterReceiveLikeEvent()
		{
		}

		// Token: 0x06024843 RID: 149571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024843")]
		[Address(RVA = "0x1F5E7B0", Offset = "0x1F5D3B0", VA = "0x181F5E7B0")]
		private void _OnReceiveLikeEvent(object arg)
		{
		}

		// Token: 0x06024844 RID: 149572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024844")]
		[Address(RVA = "0x1F5F7A0", Offset = "0x1F5E3A0", VA = "0x181F5F7A0")]
		private void _TryShowOtherLikeMe(string uid)
		{
		}

		// Token: 0x06024845 RID: 149573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024845")]
		[Address(RVA = "0x1F5F890", Offset = "0x1F5E490", VA = "0x181F5F890")]
		private void _TryShowOthersLikeMe(List<string> uidList)
		{
		}

		// Token: 0x06024846 RID: 149574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024846")]
		[Address(RVA = "0x1F5EC60", Offset = "0x1F5D860", VA = "0x181F5EC60")]
		private void _RefreshLikeMePart()
		{
		}

		// Token: 0x06024847 RID: 149575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024847")]
		[Address(RVA = "0x1F5E990", Offset = "0x1F5D590", VA = "0x181F5E990")]
		private void _PlayLikeMeThumbAnim()
		{
		}

		// Token: 0x06024848 RID: 149576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024848")]
		[Address(RVA = "0x1F5EAE0", Offset = "0x1F5D6E0", VA = "0x181F5EAE0")]
		private void _PlayShowCardAnim(int index)
		{
		}

		// Token: 0x06024849 RID: 149577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024849")]
		[Address(RVA = "0x1F5DD30", Offset = "0x1F5C930", VA = "0x181F5DD30")]
		public void EventOnLikeOtherClick()
		{
		}

		// Token: 0x0602484A RID: 149578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602484A")]
		[Address(RVA = "0x1F5DA50", Offset = "0x1F5C650", VA = "0x181F5DA50")]
		public void EventOnAddFriendClick()
		{
		}

		// Token: 0x0602484B RID: 149579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602484B")]
		[Address(RVA = "0x1F5DB70", Offset = "0x1F5C770", VA = "0x181F5DB70")]
		public void EventOnAddFriendInDiffServerClick()
		{
		}

		// Token: 0x0602484C RID: 149580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602484C")]
		[Address(RVA = "0x1F5DEC0", Offset = "0x1F5CAC0", VA = "0x181F5DEC0")]
		public void EventOnReportBtnClick()
		{
		}

		// Token: 0x0602484D RID: 149581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602484D")]
		[Address(RVA = "0x1F5DFA0", Offset = "0x1F5CBA0", VA = "0x181F5DFA0")]
		public void EventOnSentFriendClick()
		{
		}

		// Token: 0x0602484E RID: 149582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602484E")]
		[Address(RVA = "0x1F5DC50", Offset = "0x1F5C850", VA = "0x181F5DC50")]
		public void EventOnAlreadyFriendClick()
		{
		}

		// Token: 0x0602484F RID: 149583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602484F")]
		[Address(RVA = "0x1F5FB00", Offset = "0x1F5E700", VA = "0x181F5FB00")]
		public AutoChessSettleGameTeamPlayerCardView()
		{
		}

		// Token: 0x04032E5C RID: 208476
		[Token(Token = "0x4032E5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("illust part")]
		private RectTransform _illustContainer;

		// Token: 0x04032E5D RID: 208477
		[Token(Token = "0x4032E5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("bg part")]
		private GameObject _objPassBg;

		// Token: 0x04032E5E RID: 208478
		[Token(Token = "0x4032E5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("bg part")]
		private GameObject _objNotPassBg;

		// Token: 0x04032E5F RID: 208479
		[Token(Token = "0x4032E5F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("round part")]
		private GameObject _objRoundPass;

		// Token: 0x04032E60 RID: 208480
		[Token(Token = "0x4032E60")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("round part")]
		private Text _txtRoundPassNum;

		// Token: 0x04032E61 RID: 208481
		[Token(Token = "0x4032E61")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("round part")]
		private GameObject _objRoundFail;

		// Token: 0x04032E62 RID: 208482
		[Token(Token = "0x4032E62")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("round part")]
		private Text _txtRoundFailNum;

		// Token: 0x04032E63 RID: 208483
		[Token(Token = "0x4032E63")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("round part")]
		private GameObject _objRoundQuit;

		// Token: 0x04032E64 RID: 208484
		[Token(Token = "0x4032E64")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("round part")]
		private GameObject _objRoundBattling;

		// Token: 0x04032E65 RID: 208485
		[Token(Token = "0x4032E65")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("name card part")]
		private GameObject _selfTagBg;

		// Token: 0x04032E66 RID: 208486
		[Token(Token = "0x4032E66")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("name card part")]
		private GameObject _selfTagObj;

		// Token: 0x04032E67 RID: 208487
		[Token(Token = "0x4032E67")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("name card part")]
		private RectTransform _infoCardContainer;

		// Token: 0x04032E68 RID: 208488
		[Token(Token = "0x4032E68")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("name card part")]
		private AutoChessPlayerInfoCardView _infoCardViewPrefab;

		// Token: 0x04032E69 RID: 208489
		[Token(Token = "0x4032E69")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("title part")]
		private GameObject _objTitle;

		// Token: 0x04032E6A RID: 208490
		[Token(Token = "0x4032E6A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("title part")]
		private Text _txtTitle;

		// Token: 0x04032E6B RID: 208491
		[Token(Token = "0x4032E6B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("title part")]
		private Image _imgTitle;

		// Token: 0x04032E6C RID: 208492
		[Token(Token = "0x4032E6C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("title part")]
		private GameObject _objTitleWaiting;

		// Token: 0x04032E6D RID: 208493
		[Token(Token = "0x4032E6D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("self interact part")]
		private GameObject _objSelfInteractPart;

		// Token: 0x04032E6E RID: 208494
		[Token(Token = "0x4032E6E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("self interact part")]
		private AutoChessSettleGameTeamPlayerLikeItemView[] _likeItemViews;

		// Token: 0x04032E6F RID: 208495
		[Token(Token = "0x4032E6F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("self interact part")]
		private UIAnimationLocation _likeMeAnim;

		// Token: 0x04032E70 RID: 208496
		[Token(Token = "0x4032E70")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("other interact part")]
		private GameObject _objOtherInteractPart;

		// Token: 0x04032E71 RID: 208497
		[Token(Token = "0x4032E71")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("other interact part")]
		private UIAnimationLocation _likeOtherAnim;

		// Token: 0x04032E72 RID: 208498
		[Token(Token = "0x4032E72")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("other interact part")]
		private ThreeStateToggle _friendStateToggle;

		// Token: 0x04032E73 RID: 208499
		[Token(Token = "0x4032E73")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("other interact part")]
		private TwoStateToggle _diffServerToggle;

		// Token: 0x04032E74 RID: 208500
		[Token(Token = "0x4032E74")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("report part")]
		private GameObject _objReportPart;

		// Token: 0x04032E75 RID: 208501
		[Token(Token = "0x4032E75")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("report part")]
		private CanvasGroup _canvasReportBtn;

		// Token: 0x04032E76 RID: 208502
		[Token(Token = "0x4032E76")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("report part")]
		private CanvasGroup _canvasReported;

		// Token: 0x04032E77 RID: 208503
		[Token(Token = "0x4032E77")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _showAnim;

		// Token: 0x04032E78 RID: 208504
		[Token(Token = "0x4032E78")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("anim")]
		private float _animDelay;

		// Token: 0x04032E79 RID: 208505
		[Token(Token = "0x4032E79")]
		[FieldOffset(Offset = "0x114")]
		private bool m_isInited;

		// Token: 0x04032E7A RID: 208506
		[Token(Token = "0x4032E7A")]
		[FieldOffset(Offset = "0x118")]
		private string m_uid;

		// Token: 0x04032E7B RID: 208507
		[Token(Token = "0x4032E7B")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isSelf;

		// Token: 0x04032E7C RID: 208508
		[Token(Token = "0x4032E7C")]
		[FieldOffset(Offset = "0x128")]
		private AutoChessPlayerInfoCardView m_infoCardView;

		// Token: 0x04032E7D RID: 208509
		[Token(Token = "0x4032E7D")]
		[FieldOffset(Offset = "0x130")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032E7E RID: 208510
		[Token(Token = "0x4032E7E")]
		[FieldOffset(Offset = "0x140")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032E7F RID: 208511
		[Token(Token = "0x4032E7F")]
		[FieldOffset(Offset = "0x150")]
		private Tween m_showTween;

		// Token: 0x04032E80 RID: 208512
		[Token(Token = "0x4032E80")]
		[FieldOffset(Offset = "0x158")]
		private Tween m_likeMeTween;

		// Token: 0x04032E81 RID: 208513
		[Token(Token = "0x4032E81")]
		[FieldOffset(Offset = "0x160")]
		private AnimationSwitchTween m_likeOtherSwitchTween;

		// Token: 0x04032E82 RID: 208514
		[Token(Token = "0x4032E82")]
		[FieldOffset(Offset = "0x168")]
		private List<string> m_cachedLikedMeUidList;

		// Token: 0x04032E83 RID: 208515
		[Token(Token = "0x4032E83")]
		[FieldOffset(Offset = "0x170")]
		private Dictionary<string, AutoChessSettleGameTeamOtherPlayerAvatarInfo> m_otherPlayerAvatarInfoDict;

		// Token: 0x04032E84 RID: 208516
		[Token(Token = "0x4032E84")]
		[FieldOffset(Offset = "0x178")]
		private bool m_registeredReceiveLikeEvent;

		// Token: 0x04032E85 RID: 208517
		[Token(Token = "0x4032E85")]
		[FieldOffset(Offset = "0x17C")]
		private FriendState m_cacheFriendState;

		// Token: 0x04032E86 RID: 208518
		[Token(Token = "0x4032E86")]
		[FieldOffset(Offset = "0x180")]
		private FadeSwitchTween m_reportBtnTween;

		// Token: 0x04032E87 RID: 208519
		[Token(Token = "0x4032E87")]
		[FieldOffset(Offset = "0x188")]
		private FadeSwitchTween m_reportedTween;

		// Token: 0x04032E88 RID: 208520
		[Token(Token = "0x4032E88")]
		[FieldOffset(Offset = "0x190")]
		private bool m_canLikeAndAdd;

		// Token: 0x04032E89 RID: 208521
		[Token(Token = "0x4032E89")]
		[FieldOffset(Offset = "0x191")]
		private bool m_isReportPartShowing;

		// Token: 0x04032E8A RID: 208522
		[Token(Token = "0x4032E8A")]
		[FieldOffset(Offset = "0x192")]
		private bool m_reported;

		// Token: 0x04032E8B RID: 208523
		[Token(Token = "0x4032E8B")]
		[FieldOffset(Offset = "0x193")]
		private bool m_renderedBaseInfo;

		// Token: 0x04032E8C RID: 208524
		[Token(Token = "0x4032E8C")]
		[FieldOffset(Offset = "0x194")]
		private bool m_isEnterShowAnimPlayed;

		// Token: 0x04032E8E RID: 208526
		[Token(Token = "0x4032E8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onReportBtnClick;

		// Token: 0x04032E8F RID: 208527
		[Token(Token = "0x4032E8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onReportBtnClick;

		// Token: 0x04032E90 RID: 208528
		[Token(Token = "0x4032E90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032E91 RID: 208529
		[Token(Token = "0x4032E91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032E92 RID: 208530
		[Token(Token = "0x4032E92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderBaseInfoPart;

		// Token: 0x04032E93 RID: 208531
		[Token(Token = "0x4032E93")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderInteractPart;

		// Token: 0x04032E94 RID: 208532
		[Token(Token = "0x4032E94")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04032E95 RID: 208533
		[Token(Token = "0x4032E95")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RegisterReceiveLikeEvent;

		// Token: 0x04032E96 RID: 208534
		[Token(Token = "0x4032E96")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UnRegisterReceiveLikeEvent;

		// Token: 0x04032E97 RID: 208535
		[Token(Token = "0x4032E97")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnReceiveLikeEvent;

		// Token: 0x04032E98 RID: 208536
		[Token(Token = "0x4032E98")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryShowOtherLikeMe;

		// Token: 0x04032E99 RID: 208537
		[Token(Token = "0x4032E99")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryShowOthersLikeMe;

		// Token: 0x04032E9A RID: 208538
		[Token(Token = "0x4032E9A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RefreshLikeMePart;

		// Token: 0x04032E9B RID: 208539
		[Token(Token = "0x4032E9B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayLikeMeThumbAnim;

		// Token: 0x04032E9C RID: 208540
		[Token(Token = "0x4032E9C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__PlayShowCardAnim;

		// Token: 0x04032E9D RID: 208541
		[Token(Token = "0x4032E9D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnLikeOtherClick;

		// Token: 0x04032E9E RID: 208542
		[Token(Token = "0x4032E9E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnAddFriendClick;

		// Token: 0x04032E9F RID: 208543
		[Token(Token = "0x4032E9F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnAddFriendInDiffServerClick;

		// Token: 0x04032EA0 RID: 208544
		[Token(Token = "0x4032EA0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnReportBtnClick;

		// Token: 0x04032EA1 RID: 208545
		[Token(Token = "0x4032EA1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnSentFriendClick;

		// Token: 0x04032EA2 RID: 208546
		[Token(Token = "0x4032EA2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnAlreadyFriendClick;

		// Token: 0x04032EA3 RID: 208547
		[Token(Token = "0x4032EA3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
