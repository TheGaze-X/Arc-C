using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003312 RID: 13074
	[Token(Token = "0x2003312")]
	public class UITopBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06014C3D RID: 85053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003126")]
		public UISwitchToggle pauseButton
		{
			[Token(Token = "0x6014C3D")]
			[Address(RVA = "0xD4F4E0", Offset = "0xD4E0E0", VA = "0x180D4F4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06014C3E RID: 85054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003127")]
		public UISpeedSwitcher speedSwitcher
		{
			[Token(Token = "0x6014C3E")]
			[Address(RVA = "0xD4F620", Offset = "0xD4E220", VA = "0x180D4F620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06014C3F RID: 85055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003128")]
		public Image pauseMask
		{
			[Token(Token = "0x6014C3F")]
			[Address(RVA = "0xD4F540", Offset = "0xD4E140", VA = "0x180D4F540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x06014C40 RID: 85056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003129")]
		public Button systemMenuButton
		{
			[Token(Token = "0x6014C40")]
			[Address(RVA = "0xD4F680", Offset = "0xD4E280", VA = "0x180D4F680")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x06014C41 RID: 85057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700312A")]
		public UITopBar.BasicStatus twoPartStatus
		{
			[Token(Token = "0x6014C41")]
			[Address(RVA = "0xD4F6E0", Offset = "0xD4E2E0", VA = "0x180D4F6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x06014C42 RID: 85058 RVA: 0x00088470 File Offset: 0x00086670
		// (set) Token: 0x06014C43 RID: 85059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700312B")]
		public SpeedLevel speedLevel
		{
			[Token(Token = "0x6014C42")]
			[Address(RVA = "0xD4F5A0", Offset = "0xD4E1A0", VA = "0x180D4F5A0")]
			get
			{
				return SpeedLevel.SLOW_MOTION;
			}
			[Token(Token = "0x6014C43")]
			[Address(RVA = "0xD4F7C0", Offset = "0xD4E3C0", VA = "0x180D4F7C0")]
			private set
			{
			}
		}

		// Token: 0x06014C44 RID: 85060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C44")]
		[Address(RVA = "0xD4EEF0", Offset = "0xD4DAF0", VA = "0x180D4EEF0")]
		private void _OnSpeedLevelChanged(object unused)
		{
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x06014C45 RID: 85061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014C46 RID: 85062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700312C")]
		public UITopBar.BasicStatus currentBasicStatus
		{
			[Token(Token = "0x6014C45")]
			[Address(RVA = "0xD4F480", Offset = "0xD4E080", VA = "0x180D4F480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6014C46")]
			[Address(RVA = "0xD4F740", Offset = "0xD4E340", VA = "0x180D4F740")]
			set
			{
			}
		}

		// Token: 0x06014C47 RID: 85063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C47")]
		[Address(RVA = "0xD4EB70", Offset = "0xD4D770", VA = "0x180D4EB70")]
		public void UpdateInfo(BattleController controller)
		{
		}

		// Token: 0x06014C48 RID: 85064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C48")]
		[Address(RVA = "0xD4E880", Offset = "0xD4D480", VA = "0x180D4E880")]
		public void UpdateDisableMask(BattleFunctionDisableMask disableMask)
		{
		}

		// Token: 0x06014C49 RID: 85065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C49")]
		[Address(RVA = "0xD4EBF0", Offset = "0xD4D7F0", VA = "0x180D4EBF0")]
		private void _InitializeUIState(Behaviour behaviour)
		{
		}

		// Token: 0x06014C4A RID: 85066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C4A")]
		[Address(RVA = "0xD4F160", Offset = "0xD4DD60", VA = "0x180D4F160")]
		private void _RefreshEnableUIButton()
		{
		}

		// Token: 0x06014C4B RID: 85067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C4B")]
		[Address(RVA = "0xD4E640", Offset = "0xD4D240", VA = "0x180D4E640")]
		public void SetPaused(bool value, bool quiet)
		{
		}

		// Token: 0x06014C4C RID: 85068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C4C")]
		[Address(RVA = "0xD4D770", Offset = "0xD4C370", VA = "0x180D4D770")]
		public void OnGameInit()
		{
		}

		// Token: 0x06014C4D RID: 85069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C4D")]
		[Address(RVA = "0xD4DB30", Offset = "0xD4C730", VA = "0x180D4DB30")]
		public void OnGameReady()
		{
		}

		// Token: 0x06014C4E RID: 85070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C4E")]
		[Address(RVA = "0xD4DE60", Offset = "0xD4CA60", VA = "0x180D4DE60")]
		public void OnGameStart()
		{
		}

		// Token: 0x06014C4F RID: 85071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C4F")]
		[Address(RVA = "0xD4EC90", Offset = "0xD4D890", VA = "0x180D4EC90")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x06014C50 RID: 85072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C50")]
		[Address(RVA = "0xD4E030", Offset = "0xD4CC30", VA = "0x180D4E030")]
		public void OnPauseButtonClicked()
		{
		}

		// Token: 0x06014C51 RID: 85073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C51")]
		[Address(RVA = "0xD4E1A0", Offset = "0xD4CDA0", VA = "0x180D4E1A0")]
		public void OnPuaseUIButtonClikedByKeyCode()
		{
		}

		// Token: 0x06014C52 RID: 85074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C52")]
		[Address(RVA = "0xD4E3A0", Offset = "0xD4CFA0", VA = "0x180D4E3A0")]
		public void OnSpeedSwitcherClicked()
		{
		}

		// Token: 0x06014C53 RID: 85075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C53")]
		[Address(RVA = "0xD4E270", Offset = "0xD4CE70", VA = "0x180D4E270")]
		public void OnShowAllRangeToggled()
		{
		}

		// Token: 0x06014C54 RID: 85076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C54")]
		[Address(RVA = "0xD4DEC0", Offset = "0xD4CAC0", VA = "0x180D4DEC0")]
		public void OnMenuButtonClicked()
		{
		}

		// Token: 0x06014C55 RID: 85077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C55")]
		[Address(RVA = "0xD4E480", Offset = "0xD4D080", VA = "0x180D4E480")]
		public void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x06014C56 RID: 85078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C56")]
		[Address(RVA = "0xD4F410", Offset = "0xD4E010", VA = "0x180D4F410")]
		public UITopBar()
		{
		}

		// Token: 0x04018B3C RID: 101180
		[Token(Token = "0x4018B3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _pauseMask;

		// Token: 0x04018B3D RID: 101181
		[Token(Token = "0x4018B3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISwitchToggle _pauseButton;

		// Token: 0x04018B3E RID: 101182
		[Token(Token = "0x4018B3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIButton _pauseUIButton;

		// Token: 0x04018B3F RID: 101183
		[Token(Token = "0x4018B3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UISpeedSwitcher _speedSwitcher;

		// Token: 0x04018B40 RID: 101184
		[Token(Token = "0x4018B40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle _showAllRangeToggle;

		// Token: 0x04018B41 RID: 101185
		[Token(Token = "0x4018B41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _systemMenuButton;

		// Token: 0x04018B42 RID: 101186
		[Token(Token = "0x4018B42")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UITopBar.BasicStatus _twoPartStatus;

		// Token: 0x04018B43 RID: 101187
		[Token(Token = "0x4018B43")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UITopBar.BasicStatus _threePartStatus;

		// Token: 0x04018B44 RID: 101188
		[Token(Token = "0x4018B44")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UITopBar.BasicStatus _threePartStatusWithTime;

		// Token: 0x04018B45 RID: 101189
		[Token(Token = "0x4018B45")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedLevel _maxSpeedLevel;

		// Token: 0x04018B46 RID: 101190
		[Token(Token = "0x4018B46")]
		[FieldOffset(Offset = "0x68")]
		private UITopBar.BasicStatus m_currentBasicStatus;

		// Token: 0x04018B47 RID: 101191
		[Token(Token = "0x4018B47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pauseButton;

		// Token: 0x04018B48 RID: 101192
		[Token(Token = "0x4018B48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_speedSwitcher;

		// Token: 0x04018B49 RID: 101193
		[Token(Token = "0x4018B49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pauseMask;

		// Token: 0x04018B4A RID: 101194
		[Token(Token = "0x4018B4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_systemMenuButton;

		// Token: 0x04018B4B RID: 101195
		[Token(Token = "0x4018B4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_twoPartStatus;

		// Token: 0x04018B4C RID: 101196
		[Token(Token = "0x4018B4C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_speedLevel;

		// Token: 0x04018B4D RID: 101197
		[Token(Token = "0x4018B4D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_speedLevel;

		// Token: 0x04018B4E RID: 101198
		[Token(Token = "0x4018B4E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSpeedLevelChanged;

		// Token: 0x04018B4F RID: 101199
		[Token(Token = "0x4018B4F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currentBasicStatus;

		// Token: 0x04018B50 RID: 101200
		[Token(Token = "0x4018B50")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_currentBasicStatus;

		// Token: 0x04018B51 RID: 101201
		[Token(Token = "0x4018B51")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateInfo;

		// Token: 0x04018B52 RID: 101202
		[Token(Token = "0x4018B52")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateDisableMask;

		// Token: 0x04018B53 RID: 101203
		[Token(Token = "0x4018B53")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitializeUIState;

		// Token: 0x04018B54 RID: 101204
		[Token(Token = "0x4018B54")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RefreshEnableUIButton;

		// Token: 0x04018B55 RID: 101205
		[Token(Token = "0x4018B55")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetPaused;

		// Token: 0x04018B56 RID: 101206
		[Token(Token = "0x4018B56")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04018B57 RID: 101207
		[Token(Token = "0x4018B57")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04018B58 RID: 101208
		[Token(Token = "0x4018B58")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04018B59 RID: 101209
		[Token(Token = "0x4018B59")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x04018B5A RID: 101210
		[Token(Token = "0x4018B5A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnPauseButtonClicked;

		// Token: 0x04018B5B RID: 101211
		[Token(Token = "0x4018B5B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnPuaseUIButtonClikedByKeyCode;

		// Token: 0x04018B5C RID: 101212
		[Token(Token = "0x4018B5C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnSpeedSwitcherClicked;

		// Token: 0x04018B5D RID: 101213
		[Token(Token = "0x4018B5D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnShowAllRangeToggled;

		// Token: 0x04018B5E RID: 101214
		[Token(Token = "0x4018B5E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnMenuButtonClicked;

		// Token: 0x04018B5F RID: 101215
		[Token(Token = "0x4018B5F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x04018B60 RID: 101216
		[Token(Token = "0x4018B60")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003313 RID: 13075
		[Token(Token = "0x2003313")]
		[Serializable]
		public class BasicStatus
		{
			// Token: 0x06014C57 RID: 85079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014C57")]
			[Address(RVA = "0xD31860", Offset = "0xD30460", VA = "0x180D31860")]
			public void InitData(BattleController controller)
			{
			}

			// Token: 0x06014C58 RID: 85080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014C58")]
			[Address(RVA = "0xD319E0", Offset = "0xD305E0", VA = "0x180D319E0")]
			public void UpdateData(BattleController controller, bool force)
			{
			}

			// Token: 0x06014C59 RID: 85081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014C59")]
			[Address(RVA = "0xD32270", Offset = "0xD30E70", VA = "0x180D32270")]
			private void _UpdateRemainingTimeText()
			{
			}

			// Token: 0x06014C5A RID: 85082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014C5A")]
			[Address(RVA = "0xD31CE0", Offset = "0xD308E0", VA = "0x180D31CE0")]
			private void _UpdateBossCountDownTimeText(BattleController controller)
			{
			}

			// Token: 0x06014C5B RID: 85083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014C5B")]
			[Address(RVA = "0xD320E0", Offset = "0xD30CE0", VA = "0x180D320E0")]
			private void _UpdateMonsterInfo(BattleController controller, bool force)
			{
			}

			// Token: 0x06014C5C RID: 85084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014C5C")]
			[Address(RVA = "0xD324D0", Offset = "0xD310D0", VA = "0x180D324D0")]
			public BasicStatus()
			{
			}

			// Token: 0x04018B61 RID: 101217
			[Token(Token = "0x4018B61")]
			[FieldOffset(Offset = "0x10")]
			public GameObject container;

			// Token: 0x04018B62 RID: 101218
			[Token(Token = "0x4018B62")]
			[FieldOffset(Offset = "0x18")]
			public UILifePoint lifePoint;

			// Token: 0x04018B63 RID: 101219
			[Token(Token = "0x4018B63")]
			[FieldOffset(Offset = "0x20")]
			public Text monsterInfoText;

			// Token: 0x04018B64 RID: 101220
			[Token(Token = "0x4018B64")]
			[FieldOffset(Offset = "0x28")]
			public Text killCntText;

			// Token: 0x04018B65 RID: 101221
			[Token(Token = "0x4018B65")]
			[FieldOffset(Offset = "0x30")]
			public Text remainingTimeText;

			// Token: 0x04018B66 RID: 101222
			[Token(Token = "0x4018B66")]
			[FieldOffset(Offset = "0x38")]
			public GameObject goBossCountDownNormal;

			// Token: 0x04018B67 RID: 101223
			[Token(Token = "0x4018B67")]
			[FieldOffset(Offset = "0x40")]
			public Text textBossCountDownNormal;

			// Token: 0x04018B68 RID: 101224
			[Token(Token = "0x4018B68")]
			[FieldOffset(Offset = "0x48")]
			public GameObject goBossCountDownRed;

			// Token: 0x04018B69 RID: 101225
			[Token(Token = "0x4018B69")]
			[FieldOffset(Offset = "0x50")]
			public Text textBossCountDownRed;

			// Token: 0x04018B6A RID: 101226
			[Token(Token = "0x4018B6A")]
			[FieldOffset(Offset = "0x58")]
			public Transform practiceHint;

			// Token: 0x04018B6B RID: 101227
			[Token(Token = "0x4018B6B")]
			[FieldOffset(Offset = "0x60")]
			public UILifeLostGroup lifeLostContainer;

			// Token: 0x04018B6C RID: 101228
			[Token(Token = "0x4018B6C")]
			[FieldOffset(Offset = "0x68")]
			private int m_cachedFinishedEnemiesCnt;

			// Token: 0x04018B6D RID: 101229
			[Token(Token = "0x4018B6D")]
			[FieldOffset(Offset = "0x6C")]
			private int m_cachedTotalEnemiesCnt;

			// Token: 0x04018B6E RID: 101230
			[Token(Token = "0x4018B6E")]
			[FieldOffset(Offset = "0x70")]
			private int m_cachedPlayTime;

			// Token: 0x04018B6F RID: 101231
			[Token(Token = "0x4018B6F")]
			[FieldOffset(Offset = "0x78")]
			private FP m_enemyBossStartCoundDownTime;
		}
	}
}
