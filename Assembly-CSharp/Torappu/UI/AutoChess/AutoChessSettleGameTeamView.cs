using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.ReportPlayer;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062F8 RID: 25336
	[Token(Token = "0x20062F8")]
	public class AutoChessSettleGameTeamView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024853 RID: 149587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024853")]
		[Address(RVA = "0x1F62060", Offset = "0x1F60C60", VA = "0x181F62060")]
		public void Render(AutoChessSettleGameViewModel settleGameModel)
		{
		}

		// Token: 0x06024854 RID: 149588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024854")]
		[Address(RVA = "0x1F62C30", Offset = "0x1F61830", VA = "0x181F62C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024855 RID: 149589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024855")]
		[Address(RVA = "0x1F631D0", Offset = "0x1F61DD0", VA = "0x181F631D0")]
		private void _RenderBaseInfoPart(string actId, AutoChessSettleGameTeamViewModel model)
		{
		}

		// Token: 0x06024856 RID: 149590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024856")]
		[Address(RVA = "0x1F634D0", Offset = "0x1F620D0", VA = "0x181F634D0")]
		private void _RenderModeNamePart(string modeName, ActAutoChessModeDifficultyType difficultyType)
		{
		}

		// Token: 0x06024857 RID: 149591 RVA: 0x000C4728 File Offset: 0x000C2928
		[Token(Token = "0x6024857")]
		[Address(RVA = "0x1F62AB0", Offset = "0x1F616B0", VA = "0x181F62AB0")]
		private AutoChessSettleGameTeamView.AutoChessSettleGameTeamViewBtnType _GetBtnsType(ActAutoChessModeType modeType, ActAutoChessMultiModeSubType multiModeSubType, bool isFromBattle, bool isBattleFinish)
		{
			return AutoChessSettleGameTeamView.AutoChessSettleGameTeamViewBtnType.ONLY_RETURN_HOME;
		}

		// Token: 0x06024858 RID: 149592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024858")]
		[Address(RVA = "0x1F633B0", Offset = "0x1F61FB0", VA = "0x181F633B0")]
		private void _RenderBtnsPart(AutoChessSettleGameTeamView.AutoChessSettleGameTeamViewBtnType teamViewBtnType)
		{
		}

		// Token: 0x06024859 RID: 149593 RVA: 0x000C4740 File Offset: 0x000C2940
		[Token(Token = "0x6024859")]
		[Address(RVA = "0x1F62F90", Offset = "0x1F61B90", VA = "0x181F62F90")]
		private bool _IsEnterAnimPlaying()
		{
			return default(bool);
		}

		// Token: 0x0602485A RID: 149594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602485A")]
		[Address(RVA = "0x1F63000", Offset = "0x1F61C00", VA = "0x181F63000")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0602485B RID: 149595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602485B")]
		[Address(RVA = "0x1F63600", Offset = "0x1F62200", VA = "0x181F63600")]
		private void _RenderRoundDefaultInfo(AutoChessSettleGameTeamRoundType teamRoundType)
		{
		}

		// Token: 0x0602485C RID: 149596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602485C")]
		[Address(RVA = "0x1F62870", Offset = "0x1F61470", VA = "0x181F62870")]
		private Tween _GenRoundNumTween(AutoChessSettleGameTeamRoundType teamRoundType, int finishRound)
		{
			return null;
		}

		// Token: 0x0602485D RID: 149597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602485D")]
		[Address(RVA = "0x1F62700", Offset = "0x1F61300", VA = "0x181F62700")]
		private void _EventOnReportShow(string uid)
		{
		}

		// Token: 0x0602485E RID: 149598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602485E")]
		[Address(RVA = "0x1F626A0", Offset = "0x1F612A0", VA = "0x181F626A0")]
		private void _EventOnReportHide()
		{
		}

		// Token: 0x0602485F RID: 149599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602485F")]
		[Address(RVA = "0x1F62610", Offset = "0x1F61210", VA = "0x181F62610")]
		private void _EventOnReportButNoItemSelect(string toast)
		{
		}

		// Token: 0x06024860 RID: 149600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024860")]
		[Address(RVA = "0x1F62780", Offset = "0x1F61380", VA = "0x181F62780")]
		private void _EventOnReportSuc(string uid)
		{
		}

		// Token: 0x06024861 RID: 149601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024861")]
		[Address(RVA = "0x1F63710", Offset = "0x1F62310", VA = "0x181F63710")]
		private void _SetReportPanelVisible([Optional] string uid)
		{
		}

		// Token: 0x06024862 RID: 149602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024862")]
		[Address(RVA = "0x1F61D80", Offset = "0x1F60980", VA = "0x181F61D80")]
		public void EventOnBackToHome()
		{
		}

		// Token: 0x06024863 RID: 149603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024863")]
		[Address(RVA = "0x1F61E80", Offset = "0x1F60A80", VA = "0x181F61E80")]
		public void EventOnBackToRoom()
		{
		}

		// Token: 0x06024864 RID: 149604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024864")]
		[Address(RVA = "0x1F61F20", Offset = "0x1F60B20", VA = "0x181F61F20")]
		public void EventOnContinueMatch()
		{
		}

		// Token: 0x06024865 RID: 149605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024865")]
		[Address(RVA = "0x1F61FC0", Offset = "0x1F60BC0", VA = "0x181F61FC0")]
		public void EventOnTryReportBtnClick()
		{
		}

		// Token: 0x06024866 RID: 149606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024866")]
		[Address(RVA = "0x1F63810", Offset = "0x1F62410", VA = "0x181F63810")]
		public AutoChessSettleGameTeamView()
		{
		}

		// Token: 0x04032EAD RID: 208557
		[Token(Token = "0x4032EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("season info")]
		private Image _imgSeasonLogo;

		// Token: 0x04032EAE RID: 208558
		[Token(Token = "0x4032EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("mode info")]
		private AutoChessSettleGameModeNameInfo[] _modeNameInfos;

		// Token: 0x04032EAF RID: 208559
		[Token(Token = "0x4032EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("bg info")]
		private GameObject _objModeBgSuc;

		// Token: 0x04032EB0 RID: 208560
		[Token(Token = "0x4032EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("bg info")]
		private GameObject _objModeBgFail;

		// Token: 0x04032EB1 RID: 208561
		[Token(Token = "0x4032EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("bg info")]
		private GameObject _objModeBgBattling;

		// Token: 0x04032EB2 RID: 208562
		[Token(Token = "0x4032EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("battle brief info")]
		private GameObject _objModeTitleSuc;

		// Token: 0x04032EB3 RID: 208563
		[Token(Token = "0x4032EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("battle brief info")]
		private GameObject _objModeTitleFail;

		// Token: 0x04032EB4 RID: 208564
		[Token(Token = "0x4032EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("battle brief info")]
		private GameObject _objModeTitleBattling;

		// Token: 0x04032EB5 RID: 208565
		[Token(Token = "0x4032EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("round info")]
		private GameObject _objRoundNoInfo;

		// Token: 0x04032EB6 RID: 208566
		[Token(Token = "0x4032EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("round info")]
		private GameObject _objRoundInfo;

		// Token: 0x04032EB7 RID: 208567
		[Token(Token = "0x4032EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("round info")]
		private AutoChessSettleGameTeamView.RoundInfo[] _roundPassInfos;

		// Token: 0x04032EB8 RID: 208568
		[Token(Token = "0x4032EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("round info")]
		private Text _textEndTime;

		// Token: 0x04032EB9 RID: 208569
		[Token(Token = "0x4032EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("round info")]
		private Text _textBattleUseTime;

		// Token: 0x04032EBA RID: 208570
		[Token(Token = "0x4032EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("player info")]
		private SimpleLayoutContent _playerCardItemContent;

		// Token: 0x04032EBB RID: 208571
		[Token(Token = "0x4032EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("btns part")]
		private GameObject _objLeftBackToHomeBtn;

		// Token: 0x04032EBC RID: 208572
		[Token(Token = "0x4032EBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("btns part")]
		private GameObject _objRightBackToHomeBtn;

		// Token: 0x04032EBD RID: 208573
		[Token(Token = "0x4032EBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("btns part")]
		private GameObject _objRightBackToRoomBtn;

		// Token: 0x04032EBE RID: 208574
		[Token(Token = "0x4032EBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("btns part")]
		private GameObject _objRightContinueMatchBtn;

		// Token: 0x04032EBF RID: 208575
		[Token(Token = "0x4032EBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("report part")]
		private ReportPlayerPanel _reportPanelPrefab;

		// Token: 0x04032EC0 RID: 208576
		[Token(Token = "0x4032EC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("report part")]
		private RectTransform _reportPanelContainer;

		// Token: 0x04032EC1 RID: 208577
		[Token(Token = "0x4032EC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("btns part")]
		private GameObject _objReportBtn;

		// Token: 0x04032EC2 RID: 208578
		[Token(Token = "0x4032EC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("report part")]
		private UIAnimationLocation _reportBtnAnim;

		// Token: 0x04032EC3 RID: 208579
		[Token(Token = "0x4032EC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04032EC4 RID: 208580
		[Token(Token = "0x4032EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("anim")]
		private float _roundTweenDur;

		// Token: 0x04032EC5 RID: 208581
		[Token(Token = "0x4032EC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Group("anim")]
		private float _roundHiddenTweenDur;

		// Token: 0x04032EC6 RID: 208582
		[Token(Token = "0x4032EC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x04032EC7 RID: 208583
		[Token(Token = "0x4032EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032EC8 RID: 208584
		[Token(Token = "0x4032EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032EC9 RID: 208585
		[Token(Token = "0x4032EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool m_needShowBackHomeToast;

		// Token: 0x04032ECA RID: 208586
		[Token(Token = "0x4032ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<AutoChessSettleGameTeamPlayerCardViewModel> m_playerCardList;

		// Token: 0x04032ECB RID: 208587
		[Token(Token = "0x4032ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private AutoChessSettleGameTeamView.PlayerCardAdapter m_playerCardAdapter;

		// Token: 0x04032ECC RID: 208588
		[Token(Token = "0x4032ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Sequence m_enterSequence;

		// Token: 0x04032ECD RID: 208589
		[Token(Token = "0x4032ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AnimationWrapper m_enterAnimWrapper;

		// Token: 0x04032ECE RID: 208590
		[Token(Token = "0x4032ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool m_isEnterAnimPlayed;

		// Token: 0x04032ECF RID: 208591
		[Token(Token = "0x4032ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private AutoChessSettleGameTeamRoundType m_roundType;

		// Token: 0x04032ED0 RID: 208592
		[Token(Token = "0x4032ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int m_teamMaxPassRound;

		// Token: 0x04032ED1 RID: 208593
		[Token(Token = "0x4032ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private ReportPlayerPanel m_reportPanel;

		// Token: 0x04032ED2 RID: 208594
		[Token(Token = "0x4032ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private AnimationSwitchTween m_reportBtnSwitchTween;

		// Token: 0x04032ED3 RID: 208595
		[Token(Token = "0x4032ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool m_renderedBaseInfo;

		// Token: 0x04032ED4 RID: 208596
		[Token(Token = "0x4032ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		private bool m_canReportMode;

		// Token: 0x04032ED5 RID: 208597
		[Token(Token = "0x4032ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AutoChessSettleGameTeamViewModel m_teamViewModel;

		// Token: 0x04032ED6 RID: 208598
		[Token(Token = "0x4032ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032ED7 RID: 208599
		[Token(Token = "0x4032ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032ED8 RID: 208600
		[Token(Token = "0x4032ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBaseInfoPart;

		// Token: 0x04032ED9 RID: 208601
		[Token(Token = "0x4032ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderModeNamePart;

		// Token: 0x04032EDA RID: 208602
		[Token(Token = "0x4032EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetBtnsType;

		// Token: 0x04032EDB RID: 208603
		[Token(Token = "0x4032EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderBtnsPart;

		// Token: 0x04032EDC RID: 208604
		[Token(Token = "0x4032EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsEnterAnimPlaying;

		// Token: 0x04032EDD RID: 208605
		[Token(Token = "0x4032EDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04032EDE RID: 208606
		[Token(Token = "0x4032EDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderRoundDefaultInfo;

		// Token: 0x04032EDF RID: 208607
		[Token(Token = "0x4032EDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenRoundNumTween;

		// Token: 0x04032EE0 RID: 208608
		[Token(Token = "0x4032EE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnReportShow;

		// Token: 0x04032EE1 RID: 208609
		[Token(Token = "0x4032EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnReportHide;

		// Token: 0x04032EE2 RID: 208610
		[Token(Token = "0x4032EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnReportButNoItemSelect;

		// Token: 0x04032EE3 RID: 208611
		[Token(Token = "0x4032EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnReportSuc;

		// Token: 0x04032EE4 RID: 208612
		[Token(Token = "0x4032EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetReportPanelVisible;

		// Token: 0x04032EE5 RID: 208613
		[Token(Token = "0x4032EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnBackToHome;

		// Token: 0x04032EE6 RID: 208614
		[Token(Token = "0x4032EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnBackToRoom;

		// Token: 0x04032EE7 RID: 208615
		[Token(Token = "0x4032EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnContinueMatch;

		// Token: 0x04032EE8 RID: 208616
		[Token(Token = "0x4032EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnTryReportBtnClick;

		// Token: 0x04032EE9 RID: 208617
		[Token(Token = "0x4032EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062F9 RID: 25337
		[Token(Token = "0x20062F9")]
		private enum AutoChessSettleGameTeamViewBtnType
		{
			// Token: 0x04032EEB RID: 208619
			[Token(Token = "0x4032EEB")]
			ONLY_RETURN_HOME,
			// Token: 0x04032EEC RID: 208620
			[Token(Token = "0x4032EEC")]
			RETURN_HOME_WITH_ROOM,
			// Token: 0x04032EED RID: 208621
			[Token(Token = "0x4032EED")]
			RETURN_HOME_WITH_MATCH
		}

		// Token: 0x020062FA RID: 25338
		[Token(Token = "0x20062FA")]
		[Serializable]
		private class RoundInfo
		{
			// Token: 0x06024867 RID: 149607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024867")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoundInfo()
			{
			}

			// Token: 0x04032EEE RID: 208622
			[Token(Token = "0x4032EEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AutoChessSettleGameTeamRoundType teamRoundType;

			// Token: 0x04032EEF RID: 208623
			[Token(Token = "0x4032EEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject roundObj;

			// Token: 0x04032EF0 RID: 208624
			[Token(Token = "0x4032EF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text txtRound;
		}

		// Token: 0x020062FB RID: 25339
		[Token(Token = "0x20062FB")]
		private class PlayerCardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06024868 RID: 149608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024868")]
			[Address(RVA = "0x1F65F80", Offset = "0x1F64B80", VA = "0x181F65F80")]
			public PlayerCardAdapter(AutoChessSettleGameTeamView closure)
			{
			}

			// Token: 0x170055F4 RID: 22004
			// (get) Token: 0x06024869 RID: 149609 RVA: 0x000C4758 File Offset: 0x000C2958
			[Token(Token = "0x170055F4")]
			public override int count
			{
				[Token(Token = "0x6024869")]
				[Address(RVA = "0x1F66000", Offset = "0x1F64C00", VA = "0x181F66000", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602486A RID: 149610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602486A")]
			[Address(RVA = "0x1F65D20", Offset = "0x1F64920", VA = "0x181F65D20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04032EF1 RID: 208625
			[Token(Token = "0x4032EF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private AutoChessSettleGameTeamView m_closure;

			// Token: 0x04032EF2 RID: 208626
			[Token(Token = "0x4032EF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032EF3 RID: 208627
			[Token(Token = "0x4032EF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032EF4 RID: 208628
			[Token(Token = "0x4032EF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
