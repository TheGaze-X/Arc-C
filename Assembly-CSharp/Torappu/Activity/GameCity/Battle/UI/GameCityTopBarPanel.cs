using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x0200790D RID: 30989
	[Token(Token = "0x200790D")]
	public class GameCityTopBarPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170065DB RID: 26075
		// (set) Token: 0x0602B787 RID: 178055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065DB")]
		private bool cachedRest
		{
			[Token(Token = "0x602B787")]
			[Address(RVA = "0x275F5B0", Offset = "0x275E1B0", VA = "0x18275F5B0")]
			set
			{
			}
		}

		// Token: 0x170065DC RID: 26076
		// (get) Token: 0x0602B788 RID: 178056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065DC")]
		public Text scoretext
		{
			[Token(Token = "0x602B788")]
			[Address(RVA = "0x275F550", Offset = "0x275E150", VA = "0x18275F550")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B789 RID: 178057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B789")]
		[Address(RVA = "0x275D990", Offset = "0x275C590", VA = "0x18275D990")]
		public void InitPanel(GameModeFactory.GameCityGameMode gamemode)
		{
		}

		// Token: 0x0602B78A RID: 178058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B78A")]
		[Address(RVA = "0x275DDE0", Offset = "0x275C9E0", VA = "0x18275DDE0")]
		public void OnGameReady()
		{
		}

		// Token: 0x0602B78B RID: 178059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B78B")]
		[Address(RVA = "0x275E450", Offset = "0x275D050", VA = "0x18275E450")]
		public void UpdateDisableMask(BattleFunctionDisableMask mask)
		{
		}

		// Token: 0x0602B78C RID: 178060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B78C")]
		[Address(RVA = "0x275E550", Offset = "0x275D150", VA = "0x18275E550")]
		public void UpdateTime(float progress)
		{
		}

		// Token: 0x0602B78D RID: 178061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B78D")]
		[Address(RVA = "0x275E2E0", Offset = "0x275CEE0", VA = "0x18275E2E0")]
		public void SetScore(int value)
		{
		}

		// Token: 0x0602B78E RID: 178062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B78E")]
		[Address(RVA = "0x275EBF0", Offset = "0x275D7F0", VA = "0x18275EBF0")]
		public void UpgradeRank(ActArcadeData.Rank rank, float score)
		{
		}

		// Token: 0x0602B78F RID: 178063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B78F")]
		[Address(RVA = "0x275E1E0", Offset = "0x275CDE0", VA = "0x18275E1E0")]
		public void OnWaveStart()
		{
		}

		// Token: 0x0602B790 RID: 178064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B790")]
		[Address(RVA = "0x275DFC0", Offset = "0x275CBC0", VA = "0x18275DFC0")]
		public void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x0602B791 RID: 178065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B791")]
		[Address(RVA = "0x275F040", Offset = "0x275DC40", VA = "0x18275F040")]
		private void _OnSpeedLevelChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x0602B792 RID: 178066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B792")]
		[Address(RVA = "0x275E9D0", Offset = "0x275D5D0", VA = "0x18275E9D0")]
		private void Update()
		{
		}

		// Token: 0x0602B793 RID: 178067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B793")]
		[Address(RVA = "0x275F1C0", Offset = "0x275DDC0", VA = "0x18275F1C0")]
		private void _StartLevelUp()
		{
		}

		// Token: 0x0602B794 RID: 178068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B794")]
		[Address(RVA = "0x275EF30", Offset = "0x275DB30", VA = "0x18275EF30")]
		private void _OnCompleteScoreAnim()
		{
		}

		// Token: 0x0602B795 RID: 178069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B795")]
		[Address(RVA = "0x275ECE0", Offset = "0x275D8E0", VA = "0x18275ECE0")]
		private void _OnBackPressPause()
		{
		}

		// Token: 0x0602B796 RID: 178070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B796")]
		[Address(RVA = "0x275F480", Offset = "0x275E080", VA = "0x18275F480")]
		public GameCityTopBarPanel()
		{
		}

		// Token: 0x0403ED9D RID: 257437
		[Token(Token = "0x403ED9D")]
		private const float TIME_FADE = 0.4f;

		// Token: 0x0403ED9E RID: 257438
		[Token(Token = "0x403ED9E")]
		private const string TIMER_FORMAT = "{0}:{1}";

		// Token: 0x0403ED9F RID: 257439
		[Token(Token = "0x403ED9F")]
		private const char SHOW_SCORE_PADDING = '0';

		// Token: 0x0403EDA0 RID: 257440
		[Token(Token = "0x403EDA0")]
		private const int SHOW_SCORE_DIGIT_CNT = 7;

		// Token: 0x0403EDA1 RID: 257441
		[Token(Token = "0x403EDA1")]
		private const string WARING_ANIMATION_KEY = "act1arcade_hud_countdown_loop";

		// Token: 0x0403EDA2 RID: 257442
		[Token(Token = "0x403EDA2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("score")]
		private Text _scoretext;

		// Token: 0x0403EDA3 RID: 257443
		[Token(Token = "0x403EDA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("score")]
		private GameCityScoreTitlePanel _scoreTitletextPanel;

		// Token: 0x0403EDA4 RID: 257444
		[Token(Token = "0x403EDA4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("score")]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403EDA5 RID: 257445
		[Token(Token = "0x403EDA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("score")]
		private List<string> _animationKeys;

		// Token: 0x0403EDA6 RID: 257446
		[Token(Token = "0x403EDA6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("score")]
		private Image _scoreProgress;

		// Token: 0x0403EDA7 RID: 257447
		[Token(Token = "0x403EDA7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("score")]
		private float _sliderSpeed;

		// Token: 0x0403EDA8 RID: 257448
		[Token(Token = "0x403EDA8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("timer")]
		private CanvasGroup _timerCanvas;

		// Token: 0x0403EDA9 RID: 257449
		[Token(Token = "0x403EDA9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("timer")]
		private Text _timerText;

		// Token: 0x0403EDAA RID: 257450
		[Token(Token = "0x403EDAA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("timer")]
		private Slider _timerSlider;

		// Token: 0x0403EDAB RID: 257451
		[Token(Token = "0x403EDAB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("timer")]
		private float _waringTime;

		// Token: 0x0403EDAC RID: 257452
		[Token(Token = "0x403EDAC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("timer")]
		private AnimationWrapper _waringTimeWrapper;

		// Token: 0x0403EDAD RID: 257453
		[Token(Token = "0x403EDAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("info")]
		private Text _waveInfoCntText;

		// Token: 0x0403EDAE RID: 257454
		[Token(Token = "0x403EDAE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("resting")]
		private GameCityRestingPanel _restPanel;

		// Token: 0x0403EDAF RID: 257455
		[Token(Token = "0x403EDAF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("resting")]
		private CanvasGroup _restCanvas;

		// Token: 0x0403EDB0 RID: 257456
		[Token(Token = "0x403EDB0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("menu")]
		private GameCityPauseButton _pauseButton;

		// Token: 0x0403EDB1 RID: 257457
		[Token(Token = "0x403EDB1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("menu")]
		private GameCitySpeedSwitchButton _speedButton;

		// Token: 0x0403EDB2 RID: 257458
		[Token(Token = "0x403EDB2")]
		[FieldOffset(Offset = "0x98")]
		private GameModeFactory.GameCityGameMode m_gamemode;

		// Token: 0x0403EDB3 RID: 257459
		[Token(Token = "0x403EDB3")]
		[FieldOffset(Offset = "0xA0")]
		private ActArcadeData.Rank m_curShownRank;

		// Token: 0x0403EDB4 RID: 257460
		[Token(Token = "0x403EDB4")]
		[FieldOffset(Offset = "0xA4")]
		private float m_targetValue;

		// Token: 0x0403EDB5 RID: 257461
		[Token(Token = "0x403EDB5")]
		[FieldOffset(Offset = "0xA8")]
		private float m_curValue;

		// Token: 0x0403EDB6 RID: 257462
		[Token(Token = "0x403EDB6")]
		[FieldOffset(Offset = "0xAC")]
		private float m_curMaxValue;

		// Token: 0x0403EDB7 RID: 257463
		[Token(Token = "0x403EDB7")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_scoreTween;

		// Token: 0x0403EDB8 RID: 257464
		[Token(Token = "0x403EDB8")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_timerTween;

		// Token: 0x0403EDB9 RID: 257465
		[Token(Token = "0x403EDB9")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_cachedInRest;

		// Token: 0x0403EDBA RID: 257466
		[Token(Token = "0x403EDBA")]
		[FieldOffset(Offset = "0xC4")]
		private int m_cachedValue;

		// Token: 0x0403EDBB RID: 257467
		[Token(Token = "0x403EDBB")]
		[FieldOffset(Offset = "0xC8")]
		private List<GameCityTopBarPanel.UpgradeData> m_upgradeData;

		// Token: 0x0403EDBC RID: 257468
		[Token(Token = "0x403EDBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_cachedRest;

		// Token: 0x0403EDBD RID: 257469
		[Token(Token = "0x403EDBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_scoretext;

		// Token: 0x0403EDBE RID: 257470
		[Token(Token = "0x403EDBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitPanel;

		// Token: 0x0403EDBF RID: 257471
		[Token(Token = "0x403EDBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0403EDC0 RID: 257472
		[Token(Token = "0x403EDC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateDisableMask;

		// Token: 0x0403EDC1 RID: 257473
		[Token(Token = "0x403EDC1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0403EDC2 RID: 257474
		[Token(Token = "0x403EDC2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetScore;

		// Token: 0x0403EDC3 RID: 257475
		[Token(Token = "0x403EDC3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpgradeRank;

		// Token: 0x0403EDC4 RID: 257476
		[Token(Token = "0x403EDC4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnWaveStart;

		// Token: 0x0403EDC5 RID: 257477
		[Token(Token = "0x403EDC5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x0403EDC6 RID: 257478
		[Token(Token = "0x403EDC6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSpeedLevelChanged;

		// Token: 0x0403EDC7 RID: 257479
		[Token(Token = "0x403EDC7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403EDC8 RID: 257480
		[Token(Token = "0x403EDC8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StartLevelUp;

		// Token: 0x0403EDC9 RID: 257481
		[Token(Token = "0x403EDC9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnCompleteScoreAnim;

		// Token: 0x0403EDCA RID: 257482
		[Token(Token = "0x403EDCA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnBackPressPause;

		// Token: 0x0403EDCB RID: 257483
		[Token(Token = "0x403EDCB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200790E RID: 30990
		[Token(Token = "0x200790E")]
		private class UpgradeData
		{
			// Token: 0x0602B797 RID: 178071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B797")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UpgradeData()
			{
			}

			// Token: 0x0403EDCC RID: 257484
			[Token(Token = "0x403EDCC")]
			[FieldOffset(Offset = "0x10")]
			public float updateScore;

			// Token: 0x0403EDCD RID: 257485
			[Token(Token = "0x403EDCD")]
			[FieldOffset(Offset = "0x14")]
			public ActArcadeData.Rank updateRank;
		}
	}
}
