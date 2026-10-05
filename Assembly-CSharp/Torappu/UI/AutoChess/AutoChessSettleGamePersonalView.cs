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
	// Token: 0x020062EE RID: 25326
	[Token(Token = "0x20062EE")]
	public class AutoChessSettleGamePersonalView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024803 RID: 149507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024803")]
		[Address(RVA = "0x1F58850", Offset = "0x1F57450", VA = "0x181F58850")]
		public void Render(AutoChessSettleGameViewModel settleGameModel)
		{
		}

		// Token: 0x06024804 RID: 149508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024804")]
		[Address(RVA = "0x1F59030", Offset = "0x1F57C30", VA = "0x181F59030")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024805 RID: 149509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024805")]
		[Address(RVA = "0x1F59A80", Offset = "0x1F58680", VA = "0x181F59A80")]
		private void _RenderBaseInfoPart(string actId, AutoChessSettleGamePersonalViewModel model)
		{
		}

		// Token: 0x06024806 RID: 149510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024806")]
		[Address(RVA = "0x1F5A000", Offset = "0x1F58C00", VA = "0x181F5A000")]
		private void _RenderModeNamePart(string modeName, ActAutoChessModeDifficultyType difficultyType)
		{
		}

		// Token: 0x06024807 RID: 149511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024807")]
		[Address(RVA = "0x1F5ACE0", Offset = "0x1F598E0", VA = "0x181F5ACE0")]
		private void _RenderRoundInfoPart(AutoChessSettleGamePlayerStatus battleStatus, int finishRound)
		{
		}

		// Token: 0x06024808 RID: 149512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024808")]
		[Address(RVA = "0x1F5AE70", Offset = "0x1F59A70", VA = "0x181F5AE70")]
		private void _RenderSucBossInfoPart(AutoChessSettleGamePlayerStatus battleStatus, string bossIconId, string spBossIconId)
		{
		}

		// Token: 0x06024809 RID: 149513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024809")]
		[Address(RVA = "0x1F5A2D0", Offset = "0x1F58ED0", VA = "0x181F5A2D0")]
		private void _RenderPlayerInfoPart(ActAutoChessModeType modeType, AutoChessSettleGamePersonalViewModel model)
		{
		}

		// Token: 0x0602480A RID: 149514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602480A")]
		[Address(RVA = "0x1F59E80", Offset = "0x1F58A80", VA = "0x181F59E80")]
		private void _RenderCharInfoPart(AutoChessSettleGameInterruptType interruptType, List<AutoChessSettleGamePersonalCharItemViewModel> chars)
		{
		}

		// Token: 0x0602480B RID: 149515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602480B")]
		[Address(RVA = "0x1F59C00", Offset = "0x1F58800", VA = "0x181F59C00")]
		private void _RenderBondsInfoPart(AutoChessSettleGameInterruptType interruptType, List<AutoChessSettleGamePersonalBondItemViewModel> bonds)
		{
		}

		// Token: 0x0602480C RID: 149516 RVA: 0x000C4698 File Offset: 0x000C2898
		[Token(Token = "0x602480C")]
		[Address(RVA = "0x1F58F20", Offset = "0x1F57B20", VA = "0x181F58F20")]
		private AutoChessSettleGamePersonalView.BondListType _GetBondListType(AutoChessSettleGameInterruptType interruptType, int bondCount)
		{
			return AutoChessSettleGamePersonalView.BondListType.NONE;
		}

		// Token: 0x0602480D RID: 149517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602480D")]
		[Address(RVA = "0x1F5A9B0", Offset = "0x1F595B0", VA = "0x181F5A9B0")]
		private void _RenderRewardsAndTips(AutoChessSettleGamePersonalViewModel model, ActAutoChessModeType modeType)
		{
		}

		// Token: 0x0602480E RID: 149518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602480E")]
		[Address(RVA = "0x1F5A130", Offset = "0x1F58D30", VA = "0x181F5A130")]
		private void _RenderNormalRewards(string rewardItemId, int rewardCount)
		{
		}

		// Token: 0x0602480F RID: 149519 RVA: 0x000C46B0 File Offset: 0x000C28B0
		[Token(Token = "0x602480F")]
		[Address(RVA = "0x1F592B0", Offset = "0x1F57EB0", VA = "0x181F592B0")]
		private bool _IsEnterAnimPlaying()
		{
			return default(bool);
		}

		// Token: 0x06024810 RID: 149520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024810")]
		[Address(RVA = "0x1F59320", Offset = "0x1F57F20", VA = "0x181F59320")]
		private void _PlayEnterAnim(AutoChessSettleGamePersonalViewModel personalViewModel)
		{
		}

		// Token: 0x06024811 RID: 149521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024811")]
		[Address(RVA = "0x1F59920", Offset = "0x1F58520", VA = "0x181F59920")]
		private void _PlayHiddenBossAudioFx()
		{
		}

		// Token: 0x06024812 RID: 149522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024812")]
		[Address(RVA = "0x1F599B0", Offset = "0x1F585B0", VA = "0x181F599B0")]
		private void _PlayVoice(CharWordData charWordData)
		{
		}

		// Token: 0x06024813 RID: 149523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024813")]
		[Address(RVA = "0x1F587B0", Offset = "0x1F573B0", VA = "0x181F587B0")]
		public void EventOnNextBtnClick()
		{
		}

		// Token: 0x06024814 RID: 149524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024814")]
		[Address(RVA = "0x1F586C0", Offset = "0x1F572C0", VA = "0x181F586C0")]
		public void EventOnBackToHomeBtnClick()
		{
		}

		// Token: 0x06024815 RID: 149525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024815")]
		[Address(RVA = "0x1F5AF90", Offset = "0x1F59B90", VA = "0x181F5AF90")]
		public AutoChessSettleGamePersonalView()
		{
		}

		// Token: 0x04032DD6 RID: 208342
		[Token(Token = "0x4032DD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("season info")]
		private Image _imgSeasonLogoEnter;

		// Token: 0x04032DD7 RID: 208343
		[Token(Token = "0x4032DD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("season info")]
		private Image _imgSeasonLogo;

		// Token: 0x04032DD8 RID: 208344
		[Token(Token = "0x4032DD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("band info")]
		private Image _imgBand;

		// Token: 0x04032DD9 RID: 208345
		[Token(Token = "0x4032DD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("band info")]
		private GameObject _objBandVictor;

		// Token: 0x04032DDA RID: 208346
		[Token(Token = "0x4032DDA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("mode info")]
		private AutoChessSettleGameModeNameInfo[] _modeNameInfos;

		// Token: 0x04032DDB RID: 208347
		[Token(Token = "0x4032DDB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("battle brief info")]
		private GameObject _objModeTitleSuc;

		// Token: 0x04032DDC RID: 208348
		[Token(Token = "0x4032DDC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("battle brief info")]
		private GameObject _objModeTitleFail;

		// Token: 0x04032DDD RID: 208349
		[Token(Token = "0x4032DDD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("battle brief info")]
		private AutoChessSettleGamePersonalView.RoundInfo[] _roundInfos;

		// Token: 0x04032DDE RID: 208350
		[Token(Token = "0x4032DDE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("battle brief info")]
		private Text _txtPassRoundNum;

		// Token: 0x04032DDF RID: 208351
		[Token(Token = "0x4032DDF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("boss info")]
		private Image _imgSucBossIcon;

		// Token: 0x04032DE0 RID: 208352
		[Token(Token = "0x4032DE0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("boss info")]
		private GameObject _objSpBoss;

		// Token: 0x04032DE1 RID: 208353
		[Token(Token = "0x4032DE1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("boss info")]
		private GameObject _objSpBossFx;

		// Token: 0x04032DE2 RID: 208354
		[Token(Token = "0x4032DE2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("boss info")]
		private Image _imgSucSpBossIcon;

		// Token: 0x04032DE3 RID: 208355
		[Token(Token = "0x4032DE3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("player info")]
		private RectTransform _avatarContainer;

		// Token: 0x04032DE4 RID: 208356
		[Token(Token = "0x4032DE4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("player info")]
		private Text _txtPlayerName;

		// Token: 0x04032DE5 RID: 208357
		[Token(Token = "0x4032DE5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("player info")]
		private GameObject _objMultiPlayerInfoPart;

		// Token: 0x04032DE6 RID: 208358
		[Token(Token = "0x4032DE6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("player info")]
		private GameObject _objPlayerInfoBgNormal;

		// Token: 0x04032DE7 RID: 208359
		[Token(Token = "0x4032DE7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("player info")]
		private GameObject _objPlayerInfoBgQuit;

		// Token: 0x04032DE8 RID: 208360
		[Token(Token = "0x4032DE8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("player info")]
		private Image _imgTrophyIcon;

		// Token: 0x04032DE9 RID: 208361
		[Token(Token = "0x4032DE9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("player info")]
		private Text _txtTotalTrophyCnt;

		// Token: 0x04032DEA RID: 208362
		[Token(Token = "0x4032DEA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("player info")]
		private Text _txtGetTrophyCnt;

		// Token: 0x04032DEB RID: 208363
		[Token(Token = "0x4032DEB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("player info")]
		private GameObject _objGetTrophyNone;

		// Token: 0x04032DEC RID: 208364
		[Token(Token = "0x4032DEC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("player info")]
		private GameObject _objSinglePlayerInfoPart;

		// Token: 0x04032DED RID: 208365
		[Token(Token = "0x4032DED")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("player info")]
		private Text _txtSinglePlayerUseTime;

		// Token: 0x04032DEE RID: 208366
		[Token(Token = "0x4032DEE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("player info")]
		private Text _txtSinglePlayerEndTime;

		// Token: 0x04032DEF RID: 208367
		[Token(Token = "0x4032DEF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("char info")]
		private List<AutoChessSettleGameCharItemView> _charItems;

		// Token: 0x04032DF0 RID: 208368
		[Token(Token = "0x4032DF0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("bond info")]
		private GameObject _objBondsScroll;

		// Token: 0x04032DF1 RID: 208369
		[Token(Token = "0x4032DF1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("bond info")]
		private GameObject _objBondsLess;

		// Token: 0x04032DF2 RID: 208370
		[Token(Token = "0x4032DF2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("bond info")]
		private GameObject _objBondsNone;

		// Token: 0x04032DF3 RID: 208371
		[Token(Token = "0x4032DF3")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("bond info")]
		private SimpleLayoutContent _bondsScrollContent;

		// Token: 0x04032DF4 RID: 208372
		[Token(Token = "0x4032DF4")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("bond info")]
		private SimpleLayoutContent _bondsLessContent;

		// Token: 0x04032DF5 RID: 208373
		[Token(Token = "0x4032DF5")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("reward info")]
		private GameObject _objNormalRewardPart;

		// Token: 0x04032DF6 RID: 208374
		[Token(Token = "0x4032DF6")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("reward info")]
		private Image _imgBpItemIcon;

		// Token: 0x04032DF7 RID: 208375
		[Token(Token = "0x4032DF7")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("reward info")]
		private Text _txtBpItemGain;

		// Token: 0x04032DF8 RID: 208376
		[Token(Token = "0x4032DF8")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("reward info")]
		public Text _normalRewardCountText;

		// Token: 0x04032DF9 RID: 208377
		[Token(Token = "0x4032DF9")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("reward info")]
		private GameObject _objDailyRewardPart;

		// Token: 0x04032DFA RID: 208378
		[Token(Token = "0x4032DFA")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("reward info")]
		private ActBattleFinishCommonDailyRewardView _dailyRewardView;

		// Token: 0x04032DFB RID: 208379
		[Token(Token = "0x4032DFB")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("reward info")]
		private GameObject _objMilestoneRewardPart;

		// Token: 0x04032DFC RID: 208380
		[Token(Token = "0x4032DFC")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("reward info")]
		private ActBattleFinishCommonMilestoneView _milestoneView;

		// Token: 0x04032DFD RID: 208381
		[Token(Token = "0x4032DFD")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("reward info")]
		private GameObject _objInterruptTipsPart;

		// Token: 0x04032DFE RID: 208382
		[Token(Token = "0x4032DFE")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("reward info")]
		private Text _txtInterruptTips;

		// Token: 0x04032DFF RID: 208383
		[Token(Token = "0x4032DFF")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("btn info")]
		private CanvasGroup _canvasNextBtn;

		// Token: 0x04032E00 RID: 208384
		[Token(Token = "0x4032E00")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("btn info")]
		private CanvasGroup _canvasBackToHomeBtn;

		// Token: 0x04032E01 RID: 208385
		[Token(Token = "0x4032E01")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _enterSucAnim;

		// Token: 0x04032E02 RID: 208386
		[Token(Token = "0x4032E02")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _enterFailAnim;

		// Token: 0x04032E03 RID: 208387
		[Token(Token = "0x4032E03")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _hiddenBossAnim;

		// Token: 0x04032E04 RID: 208388
		[Token(Token = "0x4032E04")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("anim")]
		private float _voicePlayDelay;

		// Token: 0x04032E05 RID: 208389
		[Token(Token = "0x4032E05")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		[Group("anim")]
		private float _dailyRewardDelay;

		// Token: 0x04032E06 RID: 208390
		[Token(Token = "0x4032E06")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("anim")]
		private float _milestoneRewardDelayWithDaily;

		// Token: 0x04032E07 RID: 208391
		[Token(Token = "0x4032E07")]
		[FieldOffset(Offset = "0x1AC")]
		[SerializeField]
		[Group("anim")]
		private float _milestoneRewardDelayWithoutDaily;

		// Token: 0x04032E08 RID: 208392
		[Token(Token = "0x4032E08")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("anim")]
		private float _hiddenBossDelay;

		// Token: 0x04032E09 RID: 208393
		[Token(Token = "0x4032E09")]
		[FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		[Group("anim")]
		private float _passRoundNumDelay;

		// Token: 0x04032E0A RID: 208394
		[Token(Token = "0x4032E0A")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("anim")]
		private float _passRoundNumDur;

		// Token: 0x04032E0B RID: 208395
		[Token(Token = "0x4032E0B")]
		[FieldOffset(Offset = "0x1BC")]
		private bool m_isInited;

		// Token: 0x04032E0C RID: 208396
		[Token(Token = "0x4032E0C")]
		[FieldOffset(Offset = "0x1C0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032E0D RID: 208397
		[Token(Token = "0x4032E0D")]
		[FieldOffset(Offset = "0x1D0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032E0E RID: 208398
		[Token(Token = "0x4032E0E")]
		[FieldOffset(Offset = "0x1E0")]
		private AnimationWrapper m_enterAnimWrapper;

		// Token: 0x04032E0F RID: 208399
		[Token(Token = "0x4032E0F")]
		[FieldOffset(Offset = "0x1E8")]
		private AnimationWrapper m_hiddenBossAnimWrapper;

		// Token: 0x04032E10 RID: 208400
		[Token(Token = "0x4032E10")]
		[FieldOffset(Offset = "0x1F0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04032E11 RID: 208401
		[Token(Token = "0x4032E11")]
		[FieldOffset(Offset = "0x1F8")]
		private AutoChessSettleGamePersonalView.BondsAdapter m_bondsScrollAdapter;

		// Token: 0x04032E12 RID: 208402
		[Token(Token = "0x4032E12")]
		[FieldOffset(Offset = "0x200")]
		private AutoChessSettleGamePersonalView.BondsAdapter m_bondsLessAdapter;

		// Token: 0x04032E13 RID: 208403
		[Token(Token = "0x4032E13")]
		[FieldOffset(Offset = "0x208")]
		private FadeSwitchTween m_tweenNextBtn;

		// Token: 0x04032E14 RID: 208404
		[Token(Token = "0x4032E14")]
		[FieldOffset(Offset = "0x210")]
		private FadeSwitchTween m_tweenBackToHomeBtn;

		// Token: 0x04032E15 RID: 208405
		[Token(Token = "0x4032E15")]
		[FieldOffset(Offset = "0x218")]
		private Sequence m_enterSequence;

		// Token: 0x04032E16 RID: 208406
		[Token(Token = "0x4032E16")]
		[FieldOffset(Offset = "0x220")]
		private bool m_isEnterAnimPlayed;

		// Token: 0x04032E17 RID: 208407
		[Token(Token = "0x4032E17")]
		private const int BOND_SCROLL_MIN_COUNT = 4;

		// Token: 0x04032E18 RID: 208408
		[Token(Token = "0x4032E18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032E19 RID: 208409
		[Token(Token = "0x4032E19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032E1A RID: 208410
		[Token(Token = "0x4032E1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBaseInfoPart;

		// Token: 0x04032E1B RID: 208411
		[Token(Token = "0x4032E1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderModeNamePart;

		// Token: 0x04032E1C RID: 208412
		[Token(Token = "0x4032E1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderRoundInfoPart;

		// Token: 0x04032E1D RID: 208413
		[Token(Token = "0x4032E1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSucBossInfoPart;

		// Token: 0x04032E1E RID: 208414
		[Token(Token = "0x4032E1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderPlayerInfoPart;

		// Token: 0x04032E1F RID: 208415
		[Token(Token = "0x4032E1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderCharInfoPart;

		// Token: 0x04032E20 RID: 208416
		[Token(Token = "0x4032E20")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderBondsInfoPart;

		// Token: 0x04032E21 RID: 208417
		[Token(Token = "0x4032E21")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetBondListType;

		// Token: 0x04032E22 RID: 208418
		[Token(Token = "0x4032E22")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderRewardsAndTips;

		// Token: 0x04032E23 RID: 208419
		[Token(Token = "0x4032E23")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderNormalRewards;

		// Token: 0x04032E24 RID: 208420
		[Token(Token = "0x4032E24")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsEnterAnimPlaying;

		// Token: 0x04032E25 RID: 208421
		[Token(Token = "0x4032E25")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04032E26 RID: 208422
		[Token(Token = "0x4032E26")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__PlayHiddenBossAudioFx;

		// Token: 0x04032E27 RID: 208423
		[Token(Token = "0x4032E27")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayVoice;

		// Token: 0x04032E28 RID: 208424
		[Token(Token = "0x4032E28")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClick;

		// Token: 0x04032E29 RID: 208425
		[Token(Token = "0x4032E29")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnBackToHomeBtnClick;

		// Token: 0x04032E2A RID: 208426
		[Token(Token = "0x4032E2A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062EF RID: 25327
		[Token(Token = "0x20062EF")]
		[Serializable]
		private class RoundInfo
		{
			// Token: 0x06024816 RID: 149526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024816")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoundInfo()
			{
			}

			// Token: 0x04032E2B RID: 208427
			[Token(Token = "0x4032E2B")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessSettleGamePlayerStatus battleStatus;

			// Token: 0x04032E2C RID: 208428
			[Token(Token = "0x4032E2C")]
			[FieldOffset(Offset = "0x18")]
			public GameObject roundObj;

			// Token: 0x04032E2D RID: 208429
			[Token(Token = "0x4032E2D")]
			[FieldOffset(Offset = "0x20")]
			public Text txtRound;
		}

		// Token: 0x020062F0 RID: 25328
		[Token(Token = "0x20062F0")]
		private enum BondListType
		{
			// Token: 0x04032E2F RID: 208431
			[Token(Token = "0x4032E2F")]
			NONE,
			// Token: 0x04032E30 RID: 208432
			[Token(Token = "0x4032E30")]
			LESS,
			// Token: 0x04032E31 RID: 208433
			[Token(Token = "0x4032E31")]
			SCROLL
		}

		// Token: 0x020062F1 RID: 25329
		[Token(Token = "0x20062F1")]
		private class BondsAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170055EF RID: 21999
			// (get) Token: 0x06024817 RID: 149527 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06024818 RID: 149528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170055EF")]
			public List<AutoChessSettleGamePersonalBondItemViewModel> dataSource
			{
				[Token(Token = "0x6024817")]
				[Address(RVA = "0x1F659D0", Offset = "0x1F645D0", VA = "0x181F659D0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6024818")]
				[Address(RVA = "0x1F65A30", Offset = "0x1F64630", VA = "0x181F65A30")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170055F0 RID: 22000
			// (get) Token: 0x06024819 RID: 149529 RVA: 0x000C46C8 File Offset: 0x000C28C8
			[Token(Token = "0x170055F0")]
			public override int count
			{
				[Token(Token = "0x6024819")]
				[Address(RVA = "0x1F65910", Offset = "0x1F64510", VA = "0x181F65910", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602481A RID: 149530 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602481A")]
			[Address(RVA = "0x1F65610", Offset = "0x1F64210", VA = "0x181F65610", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602481B RID: 149531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602481B")]
			[Address(RVA = "0x1F658B0", Offset = "0x1F644B0", VA = "0x181F658B0")]
			public BondsAdapter()
			{
			}

			// Token: 0x04032E33 RID: 208435
			[Token(Token = "0x4032E33")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSource;

			// Token: 0x04032E34 RID: 208436
			[Token(Token = "0x4032E34")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSource;

			// Token: 0x04032E35 RID: 208437
			[Token(Token = "0x4032E35")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032E36 RID: 208438
			[Token(Token = "0x4032E36")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04032E37 RID: 208439
			[Token(Token = "0x4032E37")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
