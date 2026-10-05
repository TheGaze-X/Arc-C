using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064DF RID: 25823
	[Token(Token = "0x20064DF")]
	public class AutoChessBattleUIPlayerInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602519F RID: 151967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602519F")]
		[Address(RVA = "0x2021000", Offset = "0x201FC00", VA = "0x182021000")]
		public void Render(AutoChessBattleUIViewModel model)
		{
		}

		// Token: 0x060251A0 RID: 151968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A0")]
		[Address(RVA = "0x2020F70", Offset = "0x201FB70", VA = "0x182020F70")]
		public void OnTogglePlayerInfo()
		{
		}

		// Token: 0x060251A1 RID: 151969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A1")]
		[Address(RVA = "0x2020EE0", Offset = "0x201FAE0", VA = "0x182020EE0")]
		public void OnToggleEnemyInfo()
		{
		}

		// Token: 0x060251A2 RID: 151970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A2")]
		[Address(RVA = "0x2022970", Offset = "0x2021570", VA = "0x182022970")]
		private void _RenderStageInfo(AutoChessHUDStageInfoModel stageInfo)
		{
		}

		// Token: 0x060251A3 RID: 151971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A3")]
		[Address(RVA = "0x2022B00", Offset = "0x2021700", VA = "0x182022B00")]
		private void _RenderStatus(AutoChessBattleUIPlayerInfoViewModel model, AutoChessHUDStatusModel statusModel)
		{
		}

		// Token: 0x060251A4 RID: 151972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A4")]
		[Address(RVA = "0x2022720", Offset = "0x2021320", VA = "0x182022720")]
		private void _RenderNormalStatus(AutoChessHUDStageInfoModel stageInfo)
		{
		}

		// Token: 0x060251A5 RID: 151973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A5")]
		[Address(RVA = "0x20225D0", Offset = "0x20211D0", VA = "0x1820225D0")]
		private void _RenderHelpStatus(AutoChessHUDStageInfoModel stageInfo)
		{
		}

		// Token: 0x060251A6 RID: 151974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A6")]
		[Address(RVA = "0x20223D0", Offset = "0x2020FD0", VA = "0x1820223D0")]
		private void _RenderBossStatus(AutoChessHUDStageInfoModel stageInfo)
		{
		}

		// Token: 0x060251A7 RID: 151975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A7")]
		[Address(RVA = "0x2022290", Offset = "0x2020E90", VA = "0x182022290")]
		private void _RenderBandInfo(AutoChessHUDStatusModel statusModel, AutoChessGameStatus stateModel)
		{
		}

		// Token: 0x060251A8 RID: 151976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251A8")]
		[Address(RVA = "0x20224D0", Offset = "0x20210D0", VA = "0x1820224D0")]
		private void _RenderEnemyInfo(AutoChessHUDStatusModel statusModel, AutoChessGameStatus stateModel)
		{
		}

		// Token: 0x060251A9 RID: 151977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60251A9")]
		[Address(RVA = "0x20216E0", Offset = "0x20202E0", VA = "0x1820216E0")]
		private string _GetEnemyText(int curEnemy, int totalEnemy)
		{
			return null;
		}

		// Token: 0x060251AA RID: 151978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251AA")]
		[Address(RVA = "0x20217D0", Offset = "0x20203D0", VA = "0x1820217D0")]
		private void _PlayAnim(UIAnimationLocation anim, ref Tween tgtTween)
		{
		}

		// Token: 0x060251AB RID: 151979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251AB")]
		[Address(RVA = "0x2021640", Offset = "0x2020240", VA = "0x182021640")]
		private void _ClearAnim(ref Tween tgtTween)
		{
		}

		// Token: 0x060251AC RID: 151980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251AC")]
		[Address(RVA = "0x2021D30", Offset = "0x2020930", VA = "0x182021D30")]
		private void _PlayStatusAnim(AutoChessBattleUIPlayerInfoView.MidHUDGroup hudGrp, AutoChessHUDStatus status, AutoChessBattleUIPlayerInfoViewModel model, AutoChessHUDStatusModel statusModel)
		{
		}

		// Token: 0x060251AD RID: 151981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251AD")]
		[Address(RVA = "0x2022870", Offset = "0x2021470", VA = "0x182022870")]
		private void _RenderOtherBattleFinish(AutoChessHUDStatusModel statusModel)
		{
		}

		// Token: 0x060251AE RID: 151982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251AE")]
		[Address(RVA = "0x2021A50", Offset = "0x2020650", VA = "0x182021A50")]
		private void _PlayBattleFinishAnim(AutoChessHUDStatusModel statusModel)
		{
		}

		// Token: 0x060251AF RID: 151983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251AF")]
		[Address(RVA = "0x2022030", Offset = "0x2020C30", VA = "0x182022030")]
		private void _PlayStatusChangeAnim(AutoChessBattleUIPlayerInfoView.MidHUDGroup hudGrp)
		{
		}

		// Token: 0x060251B0 RID: 151984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B0")]
		[Address(RVA = "0x2021920", Offset = "0x2020520", VA = "0x182021920")]
		private void _PlayAudioWhenPlayStatusChangeAnim(AutoChessHUDStatus hudStatus)
		{
		}

		// Token: 0x060251B1 RID: 151985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B1")]
		[Address(RVA = "0x2021C90", Offset = "0x2020890", VA = "0x182021C90")]
		private void _PlayHpLostAnim(int lostHp)
		{
		}

		// Token: 0x060251B2 RID: 151986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B2")]
		[Address(RVA = "0x2021BD0", Offset = "0x20207D0", VA = "0x182021BD0")]
		private void _PlayEnemyLostAnim(AutoChessHUDStatus status, int lostEnemyCnt)
		{
		}

		// Token: 0x060251B3 RID: 151987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B3")]
		[Address(RVA = "0x2022D40", Offset = "0x2021940", VA = "0x182022D40")]
		public AutoChessBattleUIPlayerInfoView()
		{
		}

		// Token: 0x04033FC9 RID: 212937
		[Token(Token = "0x4033FC9")]
		private const float BATTLE_FINISH_ANIM_DELAY = 0.5f;

		// Token: 0x04033FCA RID: 212938
		[Token(Token = "0x4033FCA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("StageInfo")]
		private Text _roundText;

		// Token: 0x04033FCB RID: 212939
		[Token(Token = "0x4033FCB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("StageInfo")]
		private Text _playerHpText;

		// Token: 0x04033FCC RID: 212940
		[Token(Token = "0x4033FCC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("StageInfo")]
		private GameObject _loseHpGrp;

		// Token: 0x04033FCD RID: 212941
		[Token(Token = "0x4033FCD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("StageInfo")]
		private Text _lostHpText;

		// Token: 0x04033FCE RID: 212942
		[Token(Token = "0x4033FCE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("MidHudGroup")]
		private AutoChessBattleUIPlayerInfoView.MidHUDGroup[] _midHUDGrps;

		// Token: 0x04033FCF RID: 212943
		[Token(Token = "0x4033FCF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("MidHudGroup/Normal")]
		private Text _normalEnemyText;

		// Token: 0x04033FD0 RID: 212944
		[Token(Token = "0x4033FD0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("MidHudGroup/Normal")]
		private GameObject _normalLostEnemyGrp;

		// Token: 0x04033FD1 RID: 212945
		[Token(Token = "0x4033FD1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("MidHudGroup/Normal")]
		private Text _normalLostEnemyText;

		// Token: 0x04033FD2 RID: 212946
		[Token(Token = "0x4033FD2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("MidHudGroup/Normal")]
		private UIAnimationLocation _normalLostEnemyAnim;

		// Token: 0x04033FD3 RID: 212947
		[Token(Token = "0x4033FD3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("MidHudGroup/Help")]
		private Text _helpEnemyText;

		// Token: 0x04033FD4 RID: 212948
		[Token(Token = "0x4033FD4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("MidHudGroup/Help")]
		private GameObject _helpLostEnemyGrp;

		// Token: 0x04033FD5 RID: 212949
		[Token(Token = "0x4033FD5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("MidHudGroup/Help")]
		private Text _helpLostEnemyText;

		// Token: 0x04033FD6 RID: 212950
		[Token(Token = "0x4033FD6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("MidHudGroup/Help")]
		private UIAnimationLocation _helpLostEnemyAnim;

		// Token: 0x04033FD7 RID: 212951
		[Token(Token = "0x4033FD7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("MidHudGroup/Boss")]
		private Text _bossEnemyText;

		// Token: 0x04033FD8 RID: 212952
		[Token(Token = "0x4033FD8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("MidHudGroup/Boss")]
		private Image _imgBossHpBarFill;

		// Token: 0x04033FD9 RID: 212953
		[Token(Token = "0x4033FD9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("BandInfo")]
		private GameObject _bandInfoBtn;

		// Token: 0x04033FDA RID: 212954
		[Token(Token = "0x4033FDA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("BandInfo")]
		private GameObject _bandInfoNormalObj;

		// Token: 0x04033FDB RID: 212955
		[Token(Token = "0x4033FDB")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("BandInfo")]
		private GameObject _bandInfoExpandedObj;

		// Token: 0x04033FDC RID: 212956
		[Token(Token = "0x4033FDC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("BandInfo")]
		private GameObject _bandInfoEnemyExpandedObj;

		// Token: 0x04033FDD RID: 212957
		[Token(Token = "0x4033FDD")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("EnemyInfo")]
		private GameObject _enemyInfoBtn;

		// Token: 0x04033FDE RID: 212958
		[Token(Token = "0x4033FDE")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("EnemyInfo")]
		private GameObject _enemyInfoNormalObj;

		// Token: 0x04033FDF RID: 212959
		[Token(Token = "0x4033FDF")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("EnemyInfo")]
		private GameObject _enemyInfoExpandedObj;

		// Token: 0x04033FE0 RID: 212960
		[Token(Token = "0x4033FE0")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _loseHpAnim;

		// Token: 0x04033FE1 RID: 212961
		[Token(Token = "0x4033FE1")]
		[FieldOffset(Offset = "0xE8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033FE2 RID: 212962
		[Token(Token = "0x4033FE2")]
		[FieldOffset(Offset = "0xF8")]
		private SeqNumSource.Checker m_statusChecker;

		// Token: 0x04033FE3 RID: 212963
		[Token(Token = "0x4033FE3")]
		[FieldOffset(Offset = "0x100")]
		private SeqNumSource.Checker m_battleFinishChecker;

		// Token: 0x04033FE4 RID: 212964
		[Token(Token = "0x4033FE4")]
		[FieldOffset(Offset = "0x108")]
		private SeqNumSource.Checker m_otherBattleFinishChecker;

		// Token: 0x04033FE5 RID: 212965
		[Token(Token = "0x4033FE5")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_statusChangeTween;

		// Token: 0x04033FE6 RID: 212966
		[Token(Token = "0x4033FE6")]
		[FieldOffset(Offset = "0x118")]
		private Tween m_loseHpTween;

		// Token: 0x04033FE7 RID: 212967
		[Token(Token = "0x4033FE7")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_missEnemyTween;

		// Token: 0x04033FE8 RID: 212968
		[Token(Token = "0x4033FE8")]
		[FieldOffset(Offset = "0x128")]
		private Tween m_battleFinishTween;

		// Token: 0x04033FE9 RID: 212969
		[Token(Token = "0x4033FE9")]
		[FieldOffset(Offset = "0x130")]
		private int m_cachedLostHp;

		// Token: 0x04033FEA RID: 212970
		[Token(Token = "0x4033FEA")]
		[FieldOffset(Offset = "0x134")]
		private int m_cachedLostEnemy;

		// Token: 0x04033FEB RID: 212971
		[Token(Token = "0x4033FEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033FEC RID: 212972
		[Token(Token = "0x4033FEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTogglePlayerInfo;

		// Token: 0x04033FED RID: 212973
		[Token(Token = "0x4033FED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnToggleEnemyInfo;

		// Token: 0x04033FEE RID: 212974
		[Token(Token = "0x4033FEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderStageInfo;

		// Token: 0x04033FEF RID: 212975
		[Token(Token = "0x4033FEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderStatus;

		// Token: 0x04033FF0 RID: 212976
		[Token(Token = "0x4033FF0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderNormalStatus;

		// Token: 0x04033FF1 RID: 212977
		[Token(Token = "0x4033FF1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderHelpStatus;

		// Token: 0x04033FF2 RID: 212978
		[Token(Token = "0x4033FF2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderBossStatus;

		// Token: 0x04033FF3 RID: 212979
		[Token(Token = "0x4033FF3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderBandInfo;

		// Token: 0x04033FF4 RID: 212980
		[Token(Token = "0x4033FF4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderEnemyInfo;

		// Token: 0x04033FF5 RID: 212981
		[Token(Token = "0x4033FF5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetEnemyText;

		// Token: 0x04033FF6 RID: 212982
		[Token(Token = "0x4033FF6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x04033FF7 RID: 212983
		[Token(Token = "0x4033FF7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearAnim;

		// Token: 0x04033FF8 RID: 212984
		[Token(Token = "0x4033FF8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayStatusAnim;

		// Token: 0x04033FF9 RID: 212985
		[Token(Token = "0x4033FF9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderOtherBattleFinish;

		// Token: 0x04033FFA RID: 212986
		[Token(Token = "0x4033FFA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayBattleFinishAnim;

		// Token: 0x04033FFB RID: 212987
		[Token(Token = "0x4033FFB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__PlayStatusChangeAnim;

		// Token: 0x04033FFC RID: 212988
		[Token(Token = "0x4033FFC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PlayAudioWhenPlayStatusChangeAnim;

		// Token: 0x04033FFD RID: 212989
		[Token(Token = "0x4033FFD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayHpLostAnim;

		// Token: 0x04033FFE RID: 212990
		[Token(Token = "0x4033FFE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__PlayEnemyLostAnim;

		// Token: 0x04033FFF RID: 212991
		[Token(Token = "0x4033FFF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064E0 RID: 25824
		[Token(Token = "0x20064E0")]
		[Serializable]
		private struct MidHUDGroup
		{
			// Token: 0x04034000 RID: 212992
			[Token(Token = "0x4034000")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessHUDStatus status;

			// Token: 0x04034001 RID: 212993
			[Token(Token = "0x4034001")]
			[FieldOffset(Offset = "0x8")]
			public GameObject grpObj;

			// Token: 0x04034002 RID: 212994
			[Token(Token = "0x4034002")]
			[FieldOffset(Offset = "0x10")]
			public UIAnimationLocation statusChangeAnim;
		}
	}
}
