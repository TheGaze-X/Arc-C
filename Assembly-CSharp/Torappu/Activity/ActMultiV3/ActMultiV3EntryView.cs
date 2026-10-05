using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F24 RID: 28452
	[Token(Token = "0x2006F24")]
	public class ActMultiV3EntryView : DataBinder<ActMultiV3EntryProperty>, ITimeWatcher
	{
		// Token: 0x060286B2 RID: 165554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B2")]
		[Address(RVA = "0x23B7AC0", Offset = "0x23B66C0", VA = "0x1823B7AC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060286B3 RID: 165555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B3")]
		[Address(RVA = "0x23B8010", Offset = "0x23B6C10", VA = "0x1823B8010")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x060286B4 RID: 165556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B4")]
		[Address(RVA = "0x23B7890", Offset = "0x23B6490", VA = "0x1823B7890")]
		public void RegisterTeamTutorialGo()
		{
		}

		// Token: 0x060286B5 RID: 165557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B5")]
		[Address(RVA = "0x23B7A40", Offset = "0x23B6640", VA = "0x1823B7A40", Slot = "8")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x060286B6 RID: 165558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B6")]
		[Address(RVA = "0x23B79E0", Offset = "0x23B65E0", VA = "0x1823B79E0")]
		private void Start()
		{
		}

		// Token: 0x060286B7 RID: 165559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B7")]
		[Address(RVA = "0x23B6F20", Offset = "0x23B5B20", VA = "0x1823B6F20")]
		private void OnDestroy()
		{
		}

		// Token: 0x060286B8 RID: 165560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B8")]
		[Address(RVA = "0x23B70A0", Offset = "0x23B5CA0", VA = "0x1823B70A0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3EntryProperty property)
		{
		}

		// Token: 0x060286B9 RID: 165561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286B9")]
		[Address(RVA = "0x23B8CA0", Offset = "0x23B78A0", VA = "0x1823B8CA0")]
		private void _RenderTime(ActMultiV3LifeCycleViewModel lifeCycleModel)
		{
		}

		// Token: 0x060286BA RID: 165562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286BA")]
		[Address(RVA = "0x23B85E0", Offset = "0x23B71E0", VA = "0x1823B85E0")]
		private void _RenderMileStone(ActMultiV3EntryMilestoneViewModel milestoneModel)
		{
		}

		// Token: 0x060286BB RID: 165563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286BB")]
		[Address(RVA = "0x23B8490", Offset = "0x23B7090", VA = "0x1823B8490")]
		private void _RenderDailyMission(ActMultiV3EntryViewModel model)
		{
		}

		// Token: 0x060286BC RID: 165564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286BC")]
		[Address(RVA = "0x23B8850", Offset = "0x23B7450", VA = "0x1823B8850")]
		private void _RenderSquadAndStage(ActMultiV3EntryViewModel model)
		{
		}

		// Token: 0x060286BD RID: 165565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286BD")]
		[Address(RVA = "0x23B8A30", Offset = "0x23B7630", VA = "0x1823B8A30")]
		private void _RenderTeamMatch(ActMultiV3EntryViewModel model)
		{
		}

		// Token: 0x060286BE RID: 165566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286BE")]
		[Address(RVA = "0x23B8780", Offset = "0x23B7380", VA = "0x1823B8780")]
		private void _RenderRoom(ActMultiV3EntryViewModel model)
		{
		}

		// Token: 0x060286BF RID: 165567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286BF")]
		[Address(RVA = "0x23B81B0", Offset = "0x23B6DB0", VA = "0x1823B81B0")]
		private void _RenderBannedStatus(ActMultiV3EntryViewModel model)
		{
		}

		// Token: 0x060286C0 RID: 165568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C0")]
		[Address(RVA = "0x23B6980", Offset = "0x23B5580", VA = "0x1823B6980")]
		public void OnBtnManualClicked()
		{
		}

		// Token: 0x060286C1 RID: 165569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C1")]
		[Address(RVA = "0x23B6AC0", Offset = "0x23B56C0", VA = "0x1823B6AC0")]
		public void OnBtnMilestoneClicked()
		{
		}

		// Token: 0x060286C2 RID: 165570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C2")]
		[Address(RVA = "0x23B6C00", Offset = "0x23B5800", VA = "0x1823B6C00")]
		public void OnBtnRewardClicked()
		{
		}

		// Token: 0x060286C3 RID: 165571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C3")]
		[Address(RVA = "0x23B6CA0", Offset = "0x23B58A0", VA = "0x1823B6CA0")]
		public void OnBtnSquadClicked()
		{
		}

		// Token: 0x060286C4 RID: 165572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C4")]
		[Address(RVA = "0x23B6D40", Offset = "0x23B5940", VA = "0x1823B6D40")]
		public void OnBtnStageClicked()
		{
		}

		// Token: 0x060286C5 RID: 165573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C5")]
		[Address(RVA = "0x23B6DE0", Offset = "0x23B59E0", VA = "0x1823B6DE0")]
		public void OnBtnTeamMatchClicked()
		{
		}

		// Token: 0x060286C6 RID: 165574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C6")]
		[Address(RVA = "0x23B6B60", Offset = "0x23B5760", VA = "0x1823B6B60")]
		public void OnBtnQuickMatchClicked()
		{
		}

		// Token: 0x060286C7 RID: 165575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C7")]
		[Address(RVA = "0x23B6A20", Offset = "0x23B5620", VA = "0x1823B6A20")]
		public void OnBtnMedalClicked()
		{
		}

		// Token: 0x060286C8 RID: 165576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C8")]
		[Address(RVA = "0x23B6F80", Offset = "0x23B5B80", VA = "0x1823B6F80")]
		public void OnInputValueChanged()
		{
		}

		// Token: 0x060286C9 RID: 165577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286C9")]
		[Address(RVA = "0x23B67A0", Offset = "0x23B53A0", VA = "0x1823B67A0")]
		public void OnBtnCreateTeamClicked()
		{
		}

		// Token: 0x060286CA RID: 165578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286CA")]
		[Address(RVA = "0x23B68E0", Offset = "0x23B54E0", VA = "0x1823B68E0")]
		public void OnBtnJoinTeamClicked()
		{
		}

		// Token: 0x060286CB RID: 165579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286CB")]
		[Address(RVA = "0x23B6E80", Offset = "0x23B5A80", VA = "0x1823B6E80")]
		public void OnBtnTrainingRoomClicked()
		{
		}

		// Token: 0x060286CC RID: 165580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286CC")]
		[Address(RVA = "0x23B6840", Offset = "0x23B5440", VA = "0x1823B6840")]
		public void OnBtnInviteClicked()
		{
		}

		// Token: 0x060286CD RID: 165581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286CD")]
		[Address(RVA = "0x23B8E80", Offset = "0x23B7A80", VA = "0x1823B8E80")]
		public ActMultiV3EntryView()
		{
		}

		// Token: 0x04039772 RID: 235378
		[Token(Token = "0x4039772")]
		private const string TITLE_FORMAT = "{0}{1}";

		// Token: 0x04039773 RID: 235379
		[Token(Token = "0x4039773")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgLogo;

		// Token: 0x04039774 RID: 235380
		[Token(Token = "0x4039774")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _entryAnimLogo;

		// Token: 0x04039775 RID: 235381
		[Token(Token = "0x4039775")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgEntryAnimBkg;

		// Token: 0x04039776 RID: 235382
		[Token(Token = "0x4039776")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04039777 RID: 235383
		[Token(Token = "0x4039777")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgManualEntry;

		// Token: 0x04039778 RID: 235384
		[Token(Token = "0x4039778")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textMilestoneRank;

		// Token: 0x04039779 RID: 235385
		[Token(Token = "0x4039779")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlMilestoneProgress;

		// Token: 0x0403977A RID: 235386
		[Token(Token = "0x403977A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlMilestoneComplete;

		// Token: 0x0403977B RID: 235387
		[Token(Token = "0x403977B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgMilestoneItemIcon;

		// Token: 0x0403977C RID: 235388
		[Token(Token = "0x403977C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _sliderMilestone;

		// Token: 0x0403977D RID: 235389
		[Token(Token = "0x403977D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _milestoneProgress;

		// Token: 0x0403977E RID: 235390
		[Token(Token = "0x403977E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _milestoneHighLight;

		// Token: 0x0403977F RID: 235391
		[Token(Token = "0x403977F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlRewardProgress;

		// Token: 0x04039780 RID: 235392
		[Token(Token = "0x4039780")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pnlRewardComplete;

		// Token: 0x04039781 RID: 235393
		[Token(Token = "0x4039781")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlRewardActivityEnd;

		// Token: 0x04039782 RID: 235394
		[Token(Token = "0x4039782")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _btnDailyReward;

		// Token: 0x04039783 RID: 235395
		[Token(Token = "0x4039783")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _imgRewardProgress;

		// Token: 0x04039784 RID: 235396
		[Token(Token = "0x4039784")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _pnlSquadInvalid;

		// Token: 0x04039785 RID: 235397
		[Token(Token = "0x4039785")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _pnlSquadNotEnough;

		// Token: 0x04039786 RID: 235398
		[Token(Token = "0x4039786")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _pnlStageActivityEnd;

		// Token: 0x04039787 RID: 235399
		[Token(Token = "0x4039787")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _pnlMatchNotTrained;

		// Token: 0x04039788 RID: 235400
		[Token(Token = "0x4039788")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _pnlMatchSquadInvalid;

		// Token: 0x04039789 RID: 235401
		[Token(Token = "0x4039789")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _pnlMatchBanned;

		// Token: 0x0403978A RID: 235402
		[Token(Token = "0x403978A")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _pnlMatchActivityEnd;

		// Token: 0x0403978B RID: 235403
		[Token(Token = "0x403978B")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ActMultiV3EntryView.PnlMask _pnlMask;

		// Token: 0x0403978C RID: 235404
		[Token(Token = "0x403978C")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _pnlStageEndTime;

		// Token: 0x0403978D RID: 235405
		[Token(Token = "0x403978D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _pnlRewardEndTime;

		// Token: 0x0403978E RID: 235406
		[Token(Token = "0x403978E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _textEndTime;

		// Token: 0x0403978F RID: 235407
		[Token(Token = "0x403978F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x04039790 RID: 235408
		[Token(Token = "0x4039790")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Button _btnSquad;

		// Token: 0x04039791 RID: 235409
		[Token(Token = "0x4039791")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Button _btnStage;

		// Token: 0x04039792 RID: 235410
		[Token(Token = "0x4039792")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Button _btnTeamMatch;

		// Token: 0x04039793 RID: 235411
		[Token(Token = "0x4039793")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Button _btnQuickMatch;

		// Token: 0x04039794 RID: 235412
		[Token(Token = "0x4039794")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private CanvasGroup _canvasTeamMatch;

		// Token: 0x04039795 RID: 235413
		[Token(Token = "0x4039795")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private CanvasGroup _canvasQuickMatch;

		// Token: 0x04039796 RID: 235414
		[Token(Token = "0x4039796")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private CanvasGroup _canvasInvite;

		// Token: 0x04039797 RID: 235415
		[Token(Token = "0x4039797")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private InputField _inputTeamId;

		// Token: 0x04039798 RID: 235416
		[Token(Token = "0x4039798")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _panelJoinEnable;

		// Token: 0x04039799 RID: 235417
		[Token(Token = "0x4039799")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject _panelJoinDisable;

		// Token: 0x0403979A RID: 235418
		[Token(Token = "0x403979A")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private RectTransform _bottomBarHolder;

		// Token: 0x0403979B RID: 235419
		[Token(Token = "0x403979B")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Text _textBannedRemainTime;

		// Token: 0x0403979C RID: 235420
		[Token(Token = "0x403979C")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GameObject _btnCreateRoomGO;

		// Token: 0x0403979D RID: 235421
		[Token(Token = "0x403979D")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _btnJoinRoomGO;

		// Token: 0x0403979E RID: 235422
		[Token(Token = "0x403979E")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject _btnTrainingGO;

		// Token: 0x0403979F RID: 235423
		[Token(Token = "0x403979F")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private GameObject _btnInviteGO;

		// Token: 0x040397A0 RID: 235424
		[Token(Token = "0x40397A0")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Trackpoint")]
		private GameObject _trackpointPrefab;

		// Token: 0x040397A1 RID: 235425
		[Token(Token = "0x40397A1")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Trackpoint")]
		private RectTransform _manualTrackpointHolder;

		// Token: 0x040397A2 RID: 235426
		[Token(Token = "0x40397A2")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Trackpoint")]
		private RectTransform _milestoneTrackpointHolder;

		// Token: 0x040397A3 RID: 235427
		[Token(Token = "0x40397A3")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("Trackpoint")]
		private GameObject _milestoneNewTitleMark;

		// Token: 0x040397A4 RID: 235428
		[Token(Token = "0x40397A4")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("Trackpoint")]
		private RectTransform _squadTrackpointHolder;

		// Token: 0x040397A5 RID: 235429
		[Token(Token = "0x40397A5")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("Trackpoint")]
		private RectTransform _mainInviteTrackpointHolder;

		// Token: 0x040397A6 RID: 235430
		[Token(Token = "0x40397A6")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("Trackpoint")]
		private RectTransform _roomInviteTrackpointHolder;

		// Token: 0x040397A7 RID: 235431
		[Token(Token = "0x40397A7")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[Group("Trackpoint")]
		private GameObject _manualHasNewTitleMark;

		// Token: 0x040397A8 RID: 235432
		[Token(Token = "0x40397A8")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("Trackpoint")]
		private GameObject _stageHasNewTitleMark;

		// Token: 0x040397A9 RID: 235433
		[Token(Token = "0x40397A9")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("Trackpoint")]
		private GameObject _matchHasNewTitleMark;

		// Token: 0x040397AA RID: 235434
		[Token(Token = "0x40397AA")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Trackpoint")]
		private GameObject _trainingHasNewTitleMark;

		// Token: 0x040397AB RID: 235435
		[Token(Token = "0x40397AB")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("Invited")]
		private GameObject _pnlInvited;

		// Token: 0x040397AC RID: 235436
		[Token(Token = "0x40397AC")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("Invited")]
		private GameObject _pnlInvitedDisable;

		// Token: 0x040397AD RID: 235437
		[Token(Token = "0x40397AD")]
		[FieldOffset(Offset = "0x1F0")]
		private string m_cachedActId;

		// Token: 0x040397AE RID: 235438
		[Token(Token = "0x40397AE")]
		[FieldOffset(Offset = "0x1F8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040397AF RID: 235439
		[Token(Token = "0x40397AF")]
		[FieldOffset(Offset = "0x208")]
		private bool m_inited;

		// Token: 0x040397B0 RID: 235440
		[Token(Token = "0x40397B0")]
		[FieldOffset(Offset = "0x210")]
		private ActMultiV3EntryViewModel m_cachedViewModel;

		// Token: 0x040397B1 RID: 235441
		[Token(Token = "0x40397B1")]
		[FieldOffset(Offset = "0x218")]
		private ActMultiV3CommonBottomBar m_bottomBar;

		// Token: 0x040397B2 RID: 235442
		[Token(Token = "0x40397B2")]
		[FieldOffset(Offset = "0x220")]
		private GameObject m_manualTrackPoint;

		// Token: 0x040397B3 RID: 235443
		[Token(Token = "0x40397B3")]
		[FieldOffset(Offset = "0x228")]
		private GameObject m_milestoneTrackPoint;

		// Token: 0x040397B4 RID: 235444
		[Token(Token = "0x40397B4")]
		[FieldOffset(Offset = "0x230")]
		private GameObject m_squadTrackPoint;

		// Token: 0x040397B5 RID: 235445
		[Token(Token = "0x40397B5")]
		[FieldOffset(Offset = "0x238")]
		private GameObject m_mainInviteTrackPoint;

		// Token: 0x040397B6 RID: 235446
		[Token(Token = "0x40397B6")]
		[FieldOffset(Offset = "0x240")]
		private GameObject m_roomInviteTrackPoint;

		// Token: 0x040397B7 RID: 235447
		[Token(Token = "0x40397B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040397B8 RID: 235448
		[Token(Token = "0x40397B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x040397B9 RID: 235449
		[Token(Token = "0x40397B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterTeamTutorialGo;

		// Token: 0x040397BA RID: 235450
		[Token(Token = "0x40397BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x040397BB RID: 235451
		[Token(Token = "0x40397BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040397BC RID: 235452
		[Token(Token = "0x40397BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040397BD RID: 235453
		[Token(Token = "0x40397BD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040397BE RID: 235454
		[Token(Token = "0x40397BE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderTime;

		// Token: 0x040397BF RID: 235455
		[Token(Token = "0x40397BF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderMileStone;

		// Token: 0x040397C0 RID: 235456
		[Token(Token = "0x40397C0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderDailyMission;

		// Token: 0x040397C1 RID: 235457
		[Token(Token = "0x40397C1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderSquadAndStage;

		// Token: 0x040397C2 RID: 235458
		[Token(Token = "0x40397C2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderTeamMatch;

		// Token: 0x040397C3 RID: 235459
		[Token(Token = "0x40397C3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderRoom;

		// Token: 0x040397C4 RID: 235460
		[Token(Token = "0x40397C4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderBannedStatus;

		// Token: 0x040397C5 RID: 235461
		[Token(Token = "0x40397C5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBtnManualClicked;

		// Token: 0x040397C6 RID: 235462
		[Token(Token = "0x40397C6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnBtnMilestoneClicked;

		// Token: 0x040397C7 RID: 235463
		[Token(Token = "0x40397C7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBtnRewardClicked;

		// Token: 0x040397C8 RID: 235464
		[Token(Token = "0x40397C8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBtnSquadClicked;

		// Token: 0x040397C9 RID: 235465
		[Token(Token = "0x40397C9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBtnStageClicked;

		// Token: 0x040397CA RID: 235466
		[Token(Token = "0x40397CA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnBtnTeamMatchClicked;

		// Token: 0x040397CB RID: 235467
		[Token(Token = "0x40397CB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnBtnQuickMatchClicked;

		// Token: 0x040397CC RID: 235468
		[Token(Token = "0x40397CC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnBtnMedalClicked;

		// Token: 0x040397CD RID: 235469
		[Token(Token = "0x40397CD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnInputValueChanged;

		// Token: 0x040397CE RID: 235470
		[Token(Token = "0x40397CE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnBtnCreateTeamClicked;

		// Token: 0x040397CF RID: 235471
		[Token(Token = "0x40397CF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnBtnJoinTeamClicked;

		// Token: 0x040397D0 RID: 235472
		[Token(Token = "0x40397D0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnBtnTrainingRoomClicked;

		// Token: 0x040397D1 RID: 235473
		[Token(Token = "0x40397D1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnBtnInviteClicked;

		// Token: 0x040397D2 RID: 235474
		[Token(Token = "0x40397D2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F25 RID: 28453
		[Token(Token = "0x2006F25")]
		[Serializable]
		private class PnlMask : IHotfixable
		{
			// Token: 0x060286CE RID: 165582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60286CE")]
			[Address(RVA = "0x23BCB10", Offset = "0x23BB710", VA = "0x1823BCB10")]
			public void SetMaskShowStatus(ActMultiV3EntryView.PnlMask.ShowType showType, bool status)
			{
			}

			// Token: 0x060286CF RID: 165583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60286CF")]
			[Address(RVA = "0x23BCC30", Offset = "0x23BB830", VA = "0x1823BCC30")]
			public PnlMask()
			{
			}

			// Token: 0x040397D3 RID: 235475
			[Token(Token = "0x40397D3")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _mask;

			// Token: 0x040397D4 RID: 235476
			[Token(Token = "0x40397D4")]
			[FieldOffset(Offset = "0x18")]
			private bool m_showForbiddenMask;

			// Token: 0x040397D5 RID: 235477
			[Token(Token = "0x40397D5")]
			[FieldOffset(Offset = "0x19")]
			private bool m_showUnavailableMask;

			// Token: 0x040397D6 RID: 235478
			[Token(Token = "0x40397D6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetMaskShowStatus;

			// Token: 0x040397D7 RID: 235479
			[Token(Token = "0x40397D7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02006F26 RID: 28454
			[Token(Token = "0x2006F26")]
			public enum ShowType
			{
				// Token: 0x040397D9 RID: 235481
				[Token(Token = "0x40397D9")]
				NONE,
				// Token: 0x040397DA RID: 235482
				[Token(Token = "0x40397DA")]
				TYPE_FORBIDDEN,
				// Token: 0x040397DB RID: 235483
				[Token(Token = "0x40397DB")]
				TYPE_UNAVAILABLE
			}
		}
	}
}
