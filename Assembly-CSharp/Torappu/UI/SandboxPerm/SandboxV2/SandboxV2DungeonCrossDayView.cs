using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041A3 RID: 16803
	[Token(Token = "0x20041A3")]
	public class SandboxV2DungeonCrossDayView : DataBinder<SandboxV2DungeonCrossDayProp>
	{
		// Token: 0x06019E98 RID: 106136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E98")]
		[Address(RVA = "0x12D6190", Offset = "0x12D4D90", VA = "0x1812D6190")]
		public void Init(SandboxV2DungeonCrossDayPage page)
		{
		}

		// Token: 0x06019E99 RID: 106137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E99")]
		[Address(RVA = "0x12D6210", Offset = "0x12D4E10", VA = "0x1812D6210", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonCrossDayProp property)
		{
		}

		// Token: 0x06019E9A RID: 106138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E9A")]
		[Address(RVA = "0x12D6710", Offset = "0x12D5310", VA = "0x1812D6710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019E9B RID: 106139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E9B")]
		[Address(RVA = "0x12D89A0", Offset = "0x12D75A0", VA = "0x1812D89A0")]
		private void _ShowSettleCalcPanel(SandboxV2DungeonCrossDaySettleCalcModel calcModel)
		{
		}

		// Token: 0x06019E9C RID: 106140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E9C")]
		[Address(RVA = "0x12D8C10", Offset = "0x12D7810", VA = "0x1812D8C10")]
		private void _ShowTechProgressPart(bool isTechMax, float startProgress, float endProgress, int round)
		{
		}

		// Token: 0x06019E9D RID: 106141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E9D")]
		[Address(RVA = "0x12D78F0", Offset = "0x12D64F0", VA = "0x1812D78F0")]
		private void _ShowCalcClickAreaPart(bool show)
		{
		}

		// Token: 0x06019E9E RID: 106142 RVA: 0x0009FB28 File Offset: 0x0009DD28
		[Token(Token = "0x6019E9E")]
		[Address(RVA = "0x12D6B30", Offset = "0x12D5730", VA = "0x1812D6B30")]
		private bool _IsTechTweenPlaying()
		{
			return default(bool);
		}

		// Token: 0x06019E9F RID: 106143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E9F")]
		[Address(RVA = "0x12D7750", Offset = "0x12D6350", VA = "0x1812D7750")]
		private void _RefreshTechCircleCountTxt(int currentCircle)
		{
		}

		// Token: 0x06019EA0 RID: 106144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA0")]
		[Address(RVA = "0x12D6640", Offset = "0x12D5240", VA = "0x1812D6640")]
		private void _HideSettleCalcPanel()
		{
		}

		// Token: 0x06019EA1 RID: 106145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA1")]
		[Address(RVA = "0x12D7A90", Offset = "0x12D6690", VA = "0x1812D7A90")]
		private void _ShowDayBriefInfoPart(SandboxV2DungeonCrossDayDailyModel dailyModel)
		{
		}

		// Token: 0x06019EA2 RID: 106146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA2")]
		[Address(RVA = "0x12D8160", Offset = "0x12D6D60", VA = "0x1812D8160")]
		private void _ShowDayExpeditionInfoPart(SandboxV2DungeonCrossDayDailyModel dailyModel)
		{
		}

		// Token: 0x06019EA3 RID: 106147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA3")]
		[Address(RVA = "0x12D7990", Offset = "0x12D6590", VA = "0x1812D7990")]
		private void _ShowDayBaseProductInfoPart(SandboxV2DungeonCrossDayDailyModel dailyModel)
		{
		}

		// Token: 0x06019EA4 RID: 106148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA4")]
		[Address(RVA = "0x12D86E0", Offset = "0x12D72E0", VA = "0x1812D86E0")]
		private void _ShowDaySupplyInfoPart(bool showSupplyPart, SandboxV2DungeonCrossDaySupplyModel supplyModel)
		{
		}

		// Token: 0x06019EA5 RID: 106149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA5")]
		[Address(RVA = "0x12D7100", Offset = "0x12D5D00", VA = "0x1812D7100")]
		private void _PlayDayInfoEnterAnim(bool showLongAnim, bool isFirstDay, bool isRead)
		{
		}

		// Token: 0x06019EA6 RID: 106150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA6")]
		[Address(RVA = "0x12D8280", Offset = "0x12D6E80", VA = "0x1812D8280")]
		private void _ShowDayInfoPanel(SandboxV2DungeonCrossDayDailyModel dailyModel, bool showSupplyPart, SandboxV2DungeonCrossDaySupplyModel supplyModel)
		{
		}

		// Token: 0x06019EA7 RID: 106151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019EA7")]
		[Address(RVA = "0x12D94D0", Offset = "0x12D80D0", VA = "0x1812D94D0")]
		private IEnumerator _StartDayPanelAutoScroll(float delay)
		{
			return null;
		}

		// Token: 0x06019EA8 RID: 106152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA8")]
		[Address(RVA = "0x12D74A0", Offset = "0x12D60A0", VA = "0x1812D74A0")]
		private void _RefreshDayPanelAfterAutoScrollEnd()
		{
		}

		// Token: 0x06019EA9 RID: 106153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EA9")]
		[Address(RVA = "0x12D7800", Offset = "0x12D6400", VA = "0x1812D7800")]
		private void _ResetCoAutoCloseDailyPanel()
		{
		}

		// Token: 0x06019EAA RID: 106154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EAA")]
		[Address(RVA = "0x12D6F00", Offset = "0x12D5B00", VA = "0x1812D6F00")]
		private void _PlayDayEnterPanelTween(string animName, [Optional] TweenCallback onTweenComplete)
		{
		}

		// Token: 0x06019EAB RID: 106155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EAB")]
		[Address(RVA = "0x12D7340", Offset = "0x12D5F40", VA = "0x1812D7340")]
		private void _PlayPanelTween(string animName, [Optional] TweenCallback onTweenComplete)
		{
		}

		// Token: 0x06019EAC RID: 106156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019EAC")]
		[Address(RVA = "0x12D6590", Offset = "0x12D5190", VA = "0x1812D6590")]
		private IEnumerator _CoNormalDayAutoClose()
		{
			return null;
		}

		// Token: 0x06019EAD RID: 106157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EAD")]
		[Address(RVA = "0x12D6BA0", Offset = "0x12D57A0", VA = "0x1812D6BA0")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x06019EAE RID: 106158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EAE")]
		[Address(RVA = "0x12D6DD0", Offset = "0x12D59D0", VA = "0x1812D6DD0")]
		private void _OnCalcPanelExitAnimComplete()
		{
		}

		// Token: 0x06019EAF RID: 106159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EAF")]
		[Address(RVA = "0x12D6E70", Offset = "0x12D5A70", VA = "0x1812D6E70")]
		private void _OnContinueNormalDay()
		{
		}

		// Token: 0x06019EB0 RID: 106160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB0")]
		[Address(RVA = "0x12D5F80", Offset = "0x12D4B80", VA = "0x1812D5F80")]
		public void EventOnDailyPanelBgClickArea()
		{
		}

		// Token: 0x06019EB1 RID: 106161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB1")]
		[Address(RVA = "0x12D5D00", Offset = "0x12D4900", VA = "0x1812D5D00")]
		public void EventOnCalcDetailClick()
		{
		}

		// Token: 0x06019EB2 RID: 106162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB2")]
		[Address(RVA = "0x12D5D90", Offset = "0x12D4990", VA = "0x1812D5D90")]
		public void EventOnContinueFromCalcClick()
		{
		}

		// Token: 0x06019EB3 RID: 106163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB3")]
		[Address(RVA = "0x12D6100", Offset = "0x12D4D00", VA = "0x1812D6100")]
		public void EventOnSupplyBtnClick()
		{
		}

		// Token: 0x06019EB4 RID: 106164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB4")]
		[Address(RVA = "0x12D5FE0", Offset = "0x12D4BE0", VA = "0x1812D5FE0")]
		public void EventOnDrinkTipsBtnClick()
		{
		}

		// Token: 0x06019EB5 RID: 106165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB5")]
		[Address(RVA = "0x12D5EF0", Offset = "0x12D4AF0", VA = "0x1812D5EF0")]
		public void EventOnContinueSettleDayBtnClick()
		{
		}

		// Token: 0x06019EB6 RID: 106166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB6")]
		[Address(RVA = "0x12D5E80", Offset = "0x12D4A80", VA = "0x1812D5E80")]
		public void EventOnContinueNormalDayBtnClick()
		{
		}

		// Token: 0x06019EB7 RID: 106167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB7")]
		[Address(RVA = "0x12D6070", Offset = "0x12D4C70", VA = "0x1812D6070")]
		public void EventOnExitDailyPanelBtnClick()
		{
		}

		// Token: 0x06019EB8 RID: 106168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB8")]
		[Address(RVA = "0x12D9670", Offset = "0x12D8270", VA = "0x1812D9670")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x06019EB9 RID: 106169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EB9")]
		[Address(RVA = "0x12D9590", Offset = "0x12D8190", VA = "0x1812D9590")]
		private void _TryRaiseTutorialSignal()
		{
		}

		// Token: 0x06019EBA RID: 106170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EBA")]
		[Address(RVA = "0x12D9790", Offset = "0x12D8390", VA = "0x1812D9790")]
		public SandboxV2DungeonCrossDayView()
		{
		}

		// Token: 0x040209AB RID: 133547
		[Token(Token = "0x40209AB")]
		private const float SEASON_AUDIO_FX_OFFSET = 1.33f;

		// Token: 0x040209AC RID: 133548
		[Token(Token = "0x40209AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x040209AD RID: 133549
		[Token(Token = "0x40209AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objCalView;

		// Token: 0x040209AE RID: 133550
		[Token(Token = "0x40209AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtSurviveDayTitle;

		// Token: 0x040209AF RID: 133551
		[Token(Token = "0x40209AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtSurviveDay;

		// Token: 0x040209B0 RID: 133552
		[Token(Token = "0x40209B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtTotalScoreTitle;

		// Token: 0x040209B1 RID: 133553
		[Token(Token = "0x40209B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtSurviveTotalScore;

		// Token: 0x040209B2 RID: 133554
		[Token(Token = "0x40209B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objTechMax;

		// Token: 0x040209B3 RID: 133555
		[Token(Token = "0x40209B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objTechCount;

		// Token: 0x040209B4 RID: 133556
		[Token(Token = "0x40209B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtTechCount;

		// Token: 0x040209B5 RID: 133557
		[Token(Token = "0x40209B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgTechProgress;

		// Token: 0x040209B6 RID: 133558
		[Token(Token = "0x40209B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objShopMax;

		// Token: 0x040209B7 RID: 133559
		[Token(Token = "0x40209B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objShopCount;

		// Token: 0x040209B8 RID: 133560
		[Token(Token = "0x40209B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtShopCount;

		// Token: 0x040209B9 RID: 133561
		[Token(Token = "0x40209B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _objCalcContinueClickArea;

		// Token: 0x040209BA RID: 133562
		[Token(Token = "0x40209BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _canvasContinueTxt;

		// Token: 0x040209BB RID: 133563
		[Token(Token = "0x40209BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _objCrossDayDetailView;

		// Token: 0x040209BC RID: 133564
		[Token(Token = "0x40209BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ScrollRect _dayDetailScrollRect;

		// Token: 0x040209BD RID: 133565
		[Token(Token = "0x40209BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _objHasReadRightTop;

		// Token: 0x040209BE RID: 133566
		[Token(Token = "0x40209BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _objHasSaveRightTop;

		// Token: 0x040209BF RID: 133567
		[Token(Token = "0x40209BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _objSeasonInfo;

		// Token: 0x040209C0 RID: 133568
		[Token(Token = "0x40209C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _txtSeasonTitle;

		// Token: 0x040209C1 RID: 133569
		[Token(Token = "0x40209C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAtlasImage _imgSeasonLineLeft;

		// Token: 0x040209C2 RID: 133570
		[Token(Token = "0x40209C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAtlasImage _imgSeasonLineRight;

		// Token: 0x040209C3 RID: 133571
		[Token(Token = "0x40209C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _txtSeasonDetail;

		// Token: 0x040209C4 RID: 133572
		[Token(Token = "0x40209C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _txtDayBefore;

		// Token: 0x040209C5 RID: 133573
		[Token(Token = "0x40209C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _txtDayAfter;

		// Token: 0x040209C6 RID: 133574
		[Token(Token = "0x40209C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _objDayTotalRift;

		// Token: 0x040209C7 RID: 133575
		[Token(Token = "0x40209C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _txtDayTotalRift;

		// Token: 0x040209C8 RID: 133576
		[Token(Token = "0x40209C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _objDayTextNormal;

		// Token: 0x040209C9 RID: 133577
		[Token(Token = "0x40209C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text _txtDayTextNormal;

		// Token: 0x040209CA RID: 133578
		[Token(Token = "0x40209CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _objDayIconNormal;

		// Token: 0x040209CB RID: 133579
		[Token(Token = "0x40209CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _objDayIconRift;

		// Token: 0x040209CC RID: 133580
		[Token(Token = "0x40209CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _objDayIconChallenge;

		// Token: 0x040209CD RID: 133581
		[Token(Token = "0x40209CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private SimpleLayoutContent _dayApListContent;

		// Token: 0x040209CE RID: 133582
		[Token(Token = "0x40209CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _objDaySeasonInfo;

		// Token: 0x040209CF RID: 133583
		[Token(Token = "0x40209CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private GameObject _objDayRiftInfo;

		// Token: 0x040209D0 RID: 133584
		[Token(Token = "0x40209D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject _objDayChallengeInfo;

		// Token: 0x040209D1 RID: 133585
		[Token(Token = "0x40209D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private RectTransform _daySeasonAngle;

		// Token: 0x040209D2 RID: 133586
		[Token(Token = "0x40209D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject _objExpedition;

		// Token: 0x040209D3 RID: 133587
		[Token(Token = "0x40209D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private SandboxV2DungeonCrossDayExpeditionSquadsView _expeditionSquadsView;

		// Token: 0x040209D4 RID: 133588
		[Token(Token = "0x40209D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private SimpleLayoutContent _expeditionRewardContent;

		// Token: 0x040209D5 RID: 133589
		[Token(Token = "0x40209D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private SimpleLayoutContent _baseProductRewardContent;

		// Token: 0x040209D6 RID: 133590
		[Token(Token = "0x40209D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _objBaseProduct;

		// Token: 0x040209D7 RID: 133591
		[Token(Token = "0x40209D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject _objSupply;

		// Token: 0x040209D8 RID: 133592
		[Token(Token = "0x40209D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Text _txtSupplySquadCount;

		// Token: 0x040209D9 RID: 133593
		[Token(Token = "0x40209D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Text _txtSupplyPeriod;

		// Token: 0x040209DA RID: 133594
		[Token(Token = "0x40209DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GameObject _objSupplyBuffEnough;

		// Token: 0x040209DB RID: 133595
		[Token(Token = "0x40209DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Text _txtSupplyBuffEnoughTips;

		// Token: 0x040209DC RID: 133596
		[Token(Token = "0x40209DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _objSupplyBuffNotEnough;

		// Token: 0x040209DD RID: 133597
		[Token(Token = "0x40209DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private Text _txtSupplyBuffNotEnoughTips;

		// Token: 0x040209DE RID: 133598
		[Token(Token = "0x40209DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Text _txtDrinkHasCount;

		// Token: 0x040209DF RID: 133599
		[Token(Token = "0x40209DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Color _colDrinkHasCountEnough;

		// Token: 0x040209E0 RID: 133600
		[Token(Token = "0x40209E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Color _colDrinkHasCountLess;

		// Token: 0x040209E1 RID: 133601
		[Token(Token = "0x40209E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private GameObject _objDrinkNotEnoughTips;

		// Token: 0x040209E2 RID: 133602
		[Token(Token = "0x40209E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private Text _txtDrinkNotEnoughTips;

		// Token: 0x040209E3 RID: 133603
		[Token(Token = "0x40209E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private float _rewardItemCardScale;

		// Token: 0x040209E4 RID: 133604
		[Token(Token = "0x40209E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private GameObject _objNormalDayContinueBtn;

		// Token: 0x040209E5 RID: 133605
		[Token(Token = "0x40209E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private GameObject _objSettleDayContinueBtn;

		// Token: 0x040209E6 RID: 133606
		[Token(Token = "0x40209E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[SerializeField]
		private CanvasGroup _scrollBlocker;

		// Token: 0x040209E7 RID: 133607
		[Token(Token = "0x40209E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		private CanvasGroup _canvasBtnExit;

		// Token: 0x040209E8 RID: 133608
		[Token(Token = "0x40209E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private RectTransform _backTransform;

		// Token: 0x040209E9 RID: 133609
		[Token(Token = "0x40209E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private Button _btnSupplyGo;

		// Token: 0x040209EA RID: 133610
		[Token(Token = "0x40209EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private bool m_isInited;

		// Token: 0x040209EB RID: 133611
		[Token(Token = "0x40209EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040209EC RID: 133612
		[Token(Token = "0x40209EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private SandboxV2DungeonCrossDayView.ApItemListAdapter m_adapterDayApItemList;

		// Token: 0x040209ED RID: 133613
		[Token(Token = "0x40209ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private SandboxV2DungeonCrossDayView.RewardItemListAdapter m_adapterMissionRewardList;

		// Token: 0x040209EE RID: 133614
		[Token(Token = "0x40209EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private SandboxV2DungeonCrossDayView.RewardItemListAdapter m_adapterBaseRewardList;

		// Token: 0x040209EF RID: 133615
		[Token(Token = "0x40209EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private SandboxV2DungeonCrossDayModel m_model;

		// Token: 0x040209F0 RID: 133616
		[Token(Token = "0x40209F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private Tween m_animTween;

		// Token: 0x040209F1 RID: 133617
		[Token(Token = "0x40209F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private UIPage m_page;

		// Token: 0x040209F2 RID: 133618
		[Token(Token = "0x40209F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private bool m_isSettleDay;

		// Token: 0x040209F3 RID: 133619
		[Token(Token = "0x40209F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private FadeSwitchTween m_tweenBtnExit;

		// Token: 0x040209F4 RID: 133620
		[Token(Token = "0x40209F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private Coroutine m_coAutoCloseDailyPanel;

		// Token: 0x040209F5 RID: 133621
		[Token(Token = "0x40209F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private UISwitchTween.TweenWrapper m_scrollAutoMoveTween;

		// Token: 0x040209F6 RID: 133622
		[Token(Token = "0x40209F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private UISwitchTween.TweenWrapper m_seasonAngleChangeTween;

		// Token: 0x040209F7 RID: 133623
		[Token(Token = "0x40209F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool m_isScreenClicked;

		// Token: 0x040209F8 RID: 133624
		[Token(Token = "0x40209F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private UISwitchTween.TweenWrapper m_techProgressTween;

		// Token: 0x040209F9 RID: 133625
		[Token(Token = "0x40209F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private FadeSwitchTween m_tweenCanvasCalcContinueTxt;

		// Token: 0x040209FA RID: 133626
		[Token(Token = "0x40209FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool m_isDayInfoEnterAnimPlayed;

		// Token: 0x040209FB RID: 133627
		[Token(Token = "0x40209FB")]
		private const string CALC_PANEL_ENTER = "sandboxv2_crossday_cycle_entry";

		// Token: 0x040209FC RID: 133628
		[Token(Token = "0x40209FC")]
		private const string CALC_PANEL_EXIT = "sandboxv2_crossday_cycle_exit";

		// Token: 0x040209FD RID: 133629
		[Token(Token = "0x40209FD")]
		private const string DAY_PANEL_ENTER_LONG = "sandboxv2_crossday_entry_long";

		// Token: 0x040209FE RID: 133630
		[Token(Token = "0x40209FE")]
		private const string DAY_PANEL_ENTER_SHORT = "sandboxv2_crossday_entry_short";

		// Token: 0x040209FF RID: 133631
		[Token(Token = "0x40209FF")]
		private const string DAY_PANEL_ENTER_FIRST_LONG = "sandboxv2_crossday_entry_first_long";

		// Token: 0x04020A00 RID: 133632
		[Token(Token = "0x4020A00")]
		private const float AUTO_SCROLL_DUR_MAX = 1f;

		// Token: 0x04020A01 RID: 133633
		[Token(Token = "0x4020A01")]
		private const float AUTO_SCROLL_DUR_MIN = 0.1f;

		// Token: 0x04020A02 RID: 133634
		[Token(Token = "0x4020A02")]
		private const float NORMAL_DAY_AUTO_CLOSE_DELAY = 3f;

		// Token: 0x04020A03 RID: 133635
		[Token(Token = "0x4020A03")]
		private const float SEASON_ROTATE_DUR = 1f;

		// Token: 0x04020A04 RID: 133636
		[Token(Token = "0x4020A04")]
		private const float SEASON_ROTATE_DELAY = 1f;

		// Token: 0x04020A05 RID: 133637
		[Token(Token = "0x4020A05")]
		private const string RIFT_TOTAL_FORMAT = "/{0}";

		// Token: 0x04020A06 RID: 133638
		[Token(Token = "0x4020A06")]
		private const float DAY_ENTER_ANIM_DELAY = 0.2f;

		// Token: 0x04020A07 RID: 133639
		[Token(Token = "0x4020A07")]
		private const float DUR_PER_ROUND_TECH = 0.1f;

		// Token: 0x04020A08 RID: 133640
		[Token(Token = "0x4020A08")]
		private const float TECH_PROGRESS_TWEEN_DELAY = 1.5f;

		// Token: 0x04020A09 RID: 133641
		[Token(Token = "0x4020A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04020A0A RID: 133642
		[Token(Token = "0x4020A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020A0B RID: 133643
		[Token(Token = "0x4020A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020A0C RID: 133644
		[Token(Token = "0x4020A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowSettleCalcPanel;

		// Token: 0x04020A0D RID: 133645
		[Token(Token = "0x4020A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowTechProgressPart;

		// Token: 0x04020A0E RID: 133646
		[Token(Token = "0x4020A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowCalcClickAreaPart;

		// Token: 0x04020A0F RID: 133647
		[Token(Token = "0x4020A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsTechTweenPlaying;

		// Token: 0x04020A10 RID: 133648
		[Token(Token = "0x4020A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshTechCircleCountTxt;

		// Token: 0x04020A11 RID: 133649
		[Token(Token = "0x4020A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HideSettleCalcPanel;

		// Token: 0x04020A12 RID: 133650
		[Token(Token = "0x4020A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowDayBriefInfoPart;

		// Token: 0x04020A13 RID: 133651
		[Token(Token = "0x4020A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowDayExpeditionInfoPart;

		// Token: 0x04020A14 RID: 133652
		[Token(Token = "0x4020A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowDayBaseProductInfoPart;

		// Token: 0x04020A15 RID: 133653
		[Token(Token = "0x4020A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowDaySupplyInfoPart;

		// Token: 0x04020A16 RID: 133654
		[Token(Token = "0x4020A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayDayInfoEnterAnim;

		// Token: 0x04020A17 RID: 133655
		[Token(Token = "0x4020A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ShowDayInfoPanel;

		// Token: 0x04020A18 RID: 133656
		[Token(Token = "0x4020A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__StartDayPanelAutoScroll;

		// Token: 0x04020A19 RID: 133657
		[Token(Token = "0x4020A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshDayPanelAfterAutoScrollEnd;

		// Token: 0x04020A1A RID: 133658
		[Token(Token = "0x4020A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ResetCoAutoCloseDailyPanel;

		// Token: 0x04020A1B RID: 133659
		[Token(Token = "0x4020A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayDayEnterPanelTween;

		// Token: 0x04020A1C RID: 133660
		[Token(Token = "0x4020A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__PlayPanelTween;

		// Token: 0x04020A1D RID: 133661
		[Token(Token = "0x4020A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CoNormalDayAutoClose;

		// Token: 0x04020A1E RID: 133662
		[Token(Token = "0x4020A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x04020A1F RID: 133663
		[Token(Token = "0x4020A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnCalcPanelExitAnimComplete;

		// Token: 0x04020A20 RID: 133664
		[Token(Token = "0x4020A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnContinueNormalDay;

		// Token: 0x04020A21 RID: 133665
		[Token(Token = "0x4020A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnDailyPanelBgClickArea;

		// Token: 0x04020A22 RID: 133666
		[Token(Token = "0x4020A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnCalcDetailClick;

		// Token: 0x04020A23 RID: 133667
		[Token(Token = "0x4020A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnContinueFromCalcClick;

		// Token: 0x04020A24 RID: 133668
		[Token(Token = "0x4020A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EventOnSupplyBtnClick;

		// Token: 0x04020A25 RID: 133669
		[Token(Token = "0x4020A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_EventOnDrinkTipsBtnClick;

		// Token: 0x04020A26 RID: 133670
		[Token(Token = "0x4020A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_EventOnContinueSettleDayBtnClick;

		// Token: 0x04020A27 RID: 133671
		[Token(Token = "0x4020A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_EventOnContinueNormalDayBtnClick;

		// Token: 0x04020A28 RID: 133672
		[Token(Token = "0x4020A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EventOnExitDailyPanelBtnClick;

		// Token: 0x04020A29 RID: 133673
		[Token(Token = "0x4020A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x04020A2A RID: 133674
		[Token(Token = "0x4020A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__TryRaiseTutorialSignal;

		// Token: 0x04020A2B RID: 133675
		[Token(Token = "0x4020A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041A4 RID: 16804
		[Token(Token = "0x20041A4")]
		private class ApItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019EBE RID: 106174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019EBE")]
			[Address(RVA = "0x12CC200", Offset = "0x12CAE00", VA = "0x1812CC200")]
			public ApItemListAdapter(SandboxV2DungeonCrossDayView closure)
			{
			}

			// Token: 0x17003DBB RID: 15803
			// (get) Token: 0x06019EBF RID: 106175 RVA: 0x0009FB58 File Offset: 0x0009DD58
			[Token(Token = "0x17003DBB")]
			public override int count
			{
				[Token(Token = "0x6019EBF")]
				[Address(RVA = "0x12CC2F0", Offset = "0x12CAEF0", VA = "0x1812CC2F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019EC0 RID: 106176 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019EC0")]
			[Address(RVA = "0x12CBDE0", Offset = "0x12CA9E0", VA = "0x1812CBDE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020A2C RID: 133676
			[Token(Token = "0x4020A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonCrossDayView m_closure;

			// Token: 0x04020A2D RID: 133677
			[Token(Token = "0x4020A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020A2E RID: 133678
			[Token(Token = "0x4020A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020A2F RID: 133679
			[Token(Token = "0x4020A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020041A5 RID: 16805
		[Token(Token = "0x20041A5")]
		private class RewardItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019EC1 RID: 106177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019EC1")]
			[Address(RVA = "0x12CC780", Offset = "0x12CB380", VA = "0x1812CC780")]
			public RewardItemListAdapter(SandboxV2DungeonCrossDayView closure)
			{
			}

			// Token: 0x17003DBC RID: 15804
			// (get) Token: 0x06019EC2 RID: 106178 RVA: 0x0009FB70 File Offset: 0x0009DD70
			[Token(Token = "0x17003DBC")]
			public override int count
			{
				[Token(Token = "0x6019EC2")]
				[Address(RVA = "0x12CC800", Offset = "0x12CB400", VA = "0x1812CC800", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019EC3 RID: 106179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019EC3")]
			[Address(RVA = "0x12CC450", Offset = "0x12CB050", VA = "0x1812CC450", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020A30 RID: 133680
			[Token(Token = "0x4020A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<SandboxV2DungeonCrossDayReportItemModel> itemDataList;

			// Token: 0x04020A31 RID: 133681
			[Token(Token = "0x4020A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SandboxV2DungeonCrossDayView m_closure;

			// Token: 0x04020A32 RID: 133682
			[Token(Token = "0x4020A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020A33 RID: 133683
			[Token(Token = "0x4020A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020A34 RID: 133684
			[Token(Token = "0x4020A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
