using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200334C RID: 13132
	[Token(Token = "0x200334C")]
	public class UIRoguelikePluginRL3 : UIController.Plugin
	{
		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x06014F37 RID: 85815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031AF")]
		public UIBossHudRL3 bossLeftHud
		{
			[Token(Token = "0x6014F37")]
			[Address(RVA = "0xD64930", Offset = "0xD63530", VA = "0x180D64930")]
			get
			{
				return null;
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x06014F38 RID: 85816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031B0")]
		public UIBossHudRL3 bossRightHud
		{
			[Token(Token = "0x6014F38")]
			[Address(RVA = "0xD64990", Offset = "0xD63590", VA = "0x180D64990")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014F39 RID: 85817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F39")]
		[Address(RVA = "0xD638A0", Offset = "0xD624A0", VA = "0x180D638A0", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06014F3A RID: 85818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F3A")]
		[Address(RVA = "0xD63B50", Offset = "0xD62750", VA = "0x180D63B50", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06014F3B RID: 85819 RVA: 0x00089AC0 File Offset: 0x00087CC0
		[Token(Token = "0x6014F3B")]
		[Address(RVA = "0xD631F0", Offset = "0xD61DF0", VA = "0x180D631F0", Slot = "22")]
		public override bool HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014F3C RID: 85820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F3C")]
		[Address(RVA = "0xD63EA0", Offset = "0xD62AA0", VA = "0x180D63EA0", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06014F3D RID: 85821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F3D")]
		[Address(RVA = "0xD64000", Offset = "0xD62C00", VA = "0x180D64000", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06014F3E RID: 85822 RVA: 0x00089AD8 File Offset: 0x00087CD8
		[Token(Token = "0x6014F3E")]
		[Address(RVA = "0xD63000", Offset = "0xD61C00", VA = "0x180D63000", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x06014F3F RID: 85823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F3F")]
		[Address(RVA = "0xD62E20", Offset = "0xD61A20", VA = "0x180D62E20", Slot = "29")]
		public override RectTransform HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014F40 RID: 85824 RVA: 0x00089AF0 File Offset: 0x00087CF0
		[Token(Token = "0x6014F40")]
		[Address(RVA = "0xD62EB0", Offset = "0xD61AB0", VA = "0x180D62EB0", Slot = "30")]
		public override bool HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014F41 RID: 85825 RVA: 0x00089B08 File Offset: 0x00087D08
		[Token(Token = "0x6014F41")]
		[Address(RVA = "0xD62D90", Offset = "0xD61990", VA = "0x180D62D90", Slot = "31")]
		public override bool HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x06014F42 RID: 85826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F42")]
		[Address(RVA = "0xD64340", Offset = "0xD62F40", VA = "0x180D64340")]
		private void _InitTopBar()
		{
		}

		// Token: 0x06014F43 RID: 85827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F43")]
		[Address(RVA = "0xD64270", Offset = "0xD62E70", VA = "0x180D64270")]
		private void _InitFailedPanel()
		{
		}

		// Token: 0x06014F44 RID: 85828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F44")]
		[Address(RVA = "0xD641C0", Offset = "0xD62DC0", VA = "0x180D641C0")]
		private void _InitBossHud()
		{
		}

		// Token: 0x06014F45 RID: 85829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F45")]
		[Address(RVA = "0xD646F0", Offset = "0xD632F0", VA = "0x180D646F0")]
		private void _UpdateBossHudInfo()
		{
		}

		// Token: 0x06014F46 RID: 85830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F46")]
		[Address(RVA = "0xD64490", Offset = "0xD63090", VA = "0x180D64490")]
		private void _StartBossHudFadeInTweenAnim()
		{
		}

		// Token: 0x06014F47 RID: 85831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F47")]
		[Address(RVA = "0xD636A0", Offset = "0xD622A0", VA = "0x180D636A0")]
		public void OnBossSkillReady()
		{
		}

		// Token: 0x06014F48 RID: 85832 RVA: 0x00089B20 File Offset: 0x00087D20
		[Token(Token = "0x6014F48")]
		[Address(RVA = "0xD633F0", Offset = "0xD61FF0", VA = "0x180D633F0", Slot = "46")]
		public override bool HookPredefinedUILocation(Camera uiCam, PredefinedLocation location, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x06014F49 RID: 85833 RVA: 0x00089B38 File Offset: 0x00087D38
		[Token(Token = "0x6014F49")]
		[Address(RVA = "0xD64120", Offset = "0xD62D20", VA = "0x180D64120")]
		private RoguelikeTopicMode _GetSpecialTopicMode()
		{
			return RoguelikeTopicMode.NONE;
		}

		// Token: 0x06014F4A RID: 85834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F4A")]
		[Address(RVA = "0xD64890", Offset = "0xD63490", VA = "0x180D64890")]
		public UIRoguelikePluginRL3()
		{
		}

		// Token: 0x06014F4B RID: 85835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F4B")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06014F4C RID: 85836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F4C")]
		[Address(RVA = "0xD520E0", Offset = "0xD50CE0", VA = "0x180D520E0")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06014F4D RID: 85837 RVA: 0x00089B50 File Offset: 0x00087D50
		[Token(Token = "0x6014F4D")]
		[Address(RVA = "0xD57EA0", Offset = "0xD56AA0", VA = "0x180D57EA0")]
		private bool <>xLuaBaseProxy_HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014F4E RID: 85838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F4E")]
		[Address(RVA = "0xD52140", Offset = "0xD50D40", VA = "0x180D52140")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x06014F4F RID: 85839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F4F")]
		[Address(RVA = "0xD52260", Offset = "0xD50E60", VA = "0x180D52260")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06014F50 RID: 85840 RVA: 0x00089B68 File Offset: 0x00087D68
		[Token(Token = "0x6014F50")]
		[Address(RVA = "0xD57D40", Offset = "0xD56940", VA = "0x180D57D40")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x06014F51 RID: 85841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F51")]
		[Address(RVA = "0xD57A80", Offset = "0xD56680", VA = "0x180D57A80")]
		private RectTransform <>xLuaBaseProxy_HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014F52 RID: 85842 RVA: 0x00089B80 File Offset: 0x00087D80
		[Token(Token = "0x6014F52")]
		[Address(RVA = "0xD57AE0", Offset = "0xD566E0", VA = "0x180D57AE0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014F53 RID: 85843 RVA: 0x00089B98 File Offset: 0x00087D98
		[Token(Token = "0x6014F53")]
		[Address(RVA = "0xD57A20", Offset = "0xD56620", VA = "0x180D57A20")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x06014F54 RID: 85844 RVA: 0x00089BB0 File Offset: 0x00087DB0
		[Token(Token = "0x6014F54")]
		[Address(RVA = "0xD51FB0", Offset = "0xD50BB0", VA = "0x180D51FB0")]
		private bool <>xLuaBaseProxy_HookPredefinedUILocation(Camera P0, PredefinedLocation P1, out Vector3 P2)
		{
			return default(bool);
		}

		// Token: 0x04018EAB RID: 102059
		[Token(Token = "0x4018EAB")]
		private const float FADE_TIME = 0.5f;

		// Token: 0x04018EAC RID: 102060
		[Token(Token = "0x4018EAC")]
		private const float BLINK_TIME = 0.15f;

		// Token: 0x04018EAD RID: 102061
		[Token(Token = "0x4018EAD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("BattleFailedMask")]
		private UIRoguelikeBattleFailedMask _battleFailedMaskPrefab;

		// Token: 0x04018EAE RID: 102062
		[Token(Token = "0x4018EAE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("BattleFailedMask")]
		private UIRoguelikeBattleFailedMask _battleFailedMaskPrefab2;

		// Token: 0x04018EAF RID: 102063
		[Token(Token = "0x4018EAF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Rogue3BossHud")]
		private GameObject _bossHudHolder;

		// Token: 0x04018EB0 RID: 102064
		[Token(Token = "0x4018EB0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Rogue3BossHud")]
		private UIAtlasImage _imageBossSkillReady;

		// Token: 0x04018EB1 RID: 102065
		[Token(Token = "0x4018EB1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Rogue3BossHud")]
		private UIBossHudRL3 _bossLeftHud;

		// Token: 0x04018EB2 RID: 102066
		[Token(Token = "0x4018EB2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Rogue3BossHud")]
		private UIBossHudRL3 _bossRightHud;

		// Token: 0x04018EB3 RID: 102067
		[Token(Token = "0x4018EB3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIRoguelikePluginRL3.UITopbarStatusRL3 _UITopbarStatusRL3;

		// Token: 0x04018EB4 RID: 102068
		[Token(Token = "0x4018EB4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRoguelikePluginRL3.UITopbarStatusRL3 _UITopbarStatusWithExp;

		// Token: 0x04018EB5 RID: 102069
		[Token(Token = "0x4018EB5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIEmergencyBattleToastPanelRL3 _emergencyBattletoastPrefab;

		// Token: 0x04018EB6 RID: 102070
		[Token(Token = "0x4018EB6")]
		[FieldOffset(Offset = "0x70")]
		private UIEmergencyBattleToastPanelRL3 m_toast;

		// Token: 0x04018EB7 RID: 102071
		[Token(Token = "0x4018EB7")]
		[FieldOffset(Offset = "0x78")]
		private UIRoguelikePluginRL3.UITopbarStatusRL3 m_currentStatus;

		// Token: 0x04018EB8 RID: 102072
		[Token(Token = "0x4018EB8")]
		[FieldOffset(Offset = "0x80")]
		private UIRoguelikeBattleFailedMask m_failedPanel;

		// Token: 0x04018EB9 RID: 102073
		[Token(Token = "0x4018EB9")]
		[FieldOffset(Offset = "0x88")]
		public bool hideUILifePoint;

		// Token: 0x04018EBA RID: 102074
		[Token(Token = "0x4018EBA")]
		[FieldOffset(Offset = "0x90")]
		private GameModeFactory.RoguelikeGameMode m_gameMode;

		// Token: 0x04018EBB RID: 102075
		[Token(Token = "0x4018EBB")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isSpecialExpStyle;

		// Token: 0x04018EBC RID: 102076
		[Token(Token = "0x4018EBC")]
		[FieldOffset(Offset = "0x99")]
		private bool m_isFailProtect;

		// Token: 0x04018EBD RID: 102077
		[Token(Token = "0x4018EBD")]
		[FieldOffset(Offset = "0x9C")]
		private float m_defaultBossReadyAlpha;

		// Token: 0x04018EBE RID: 102078
		[Token(Token = "0x4018EBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bossLeftHud;

		// Token: 0x04018EBF RID: 102079
		[Token(Token = "0x4018EBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_bossRightHud;

		// Token: 0x04018EC0 RID: 102080
		[Token(Token = "0x4018EC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04018EC1 RID: 102081
		[Token(Token = "0x4018EC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04018EC2 RID: 102082
		[Token(Token = "0x4018EC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

		// Token: 0x04018EC3 RID: 102083
		[Token(Token = "0x4018EC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04018EC4 RID: 102084
		[Token(Token = "0x4018EC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04018EC5 RID: 102085
		[Token(Token = "0x4018EC5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x04018EC6 RID: 102086
		[Token(Token = "0x4018EC6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelInit;

		// Token: 0x04018EC7 RID: 102087
		[Token(Token = "0x4018EC7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelShow;

		// Token: 0x04018EC8 RID: 102088
		[Token(Token = "0x4018EC8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelHide;

		// Token: 0x04018EC9 RID: 102089
		[Token(Token = "0x4018EC9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitTopBar;

		// Token: 0x04018ECA RID: 102090
		[Token(Token = "0x4018ECA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitFailedPanel;

		// Token: 0x04018ECB RID: 102091
		[Token(Token = "0x4018ECB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitBossHud;

		// Token: 0x04018ECC RID: 102092
		[Token(Token = "0x4018ECC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateBossHudInfo;

		// Token: 0x04018ECD RID: 102093
		[Token(Token = "0x4018ECD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__StartBossHudFadeInTweenAnim;

		// Token: 0x04018ECE RID: 102094
		[Token(Token = "0x4018ECE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBossSkillReady;

		// Token: 0x04018ECF RID: 102095
		[Token(Token = "0x4018ECF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HookPredefinedUILocation;

		// Token: 0x04018ED0 RID: 102096
		[Token(Token = "0x4018ED0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetSpecialTopicMode;

		// Token: 0x04018ED1 RID: 102097
		[Token(Token = "0x4018ED1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200334D RID: 13133
		[Token(Token = "0x200334D")]
		[Serializable]
		public class UITopbarStatusRL3
		{
			// Token: 0x06014F55 RID: 85845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F55")]
			[Address(RVA = "0xD66970", Offset = "0xD65570", VA = "0x180D66970")]
			public void InitData(BattleController controller, bool hideLifePoint)
			{
			}

			// Token: 0x06014F56 RID: 85846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F56")]
			[Address(RVA = "0xD66B40", Offset = "0xD65740", VA = "0x180D66B40")]
			public void UpdateData(BattleController controller, bool hideLifePoint, bool force)
			{
			}

			// Token: 0x06014F57 RID: 85847 RVA: 0x00089BC8 File Offset: 0x00087DC8
			[Token(Token = "0x6014F57")]
			[Address(RVA = "0xD66810", Offset = "0xD65410", VA = "0x180D66810")]
			public Vector3 CalculateExpScreenPos(Camera uiCam)
			{
				return default(Vector3);
			}

			// Token: 0x06014F58 RID: 85848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F58")]
			[Address(RVA = "0xD67150", Offset = "0xD65D50", VA = "0x180D67150")]
			private void _UpdateMonsterInfo(BattleController controller, bool force)
			{
			}

			// Token: 0x06014F59 RID: 85849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F59")]
			[Address(RVA = "0xD66FC0", Offset = "0xD65BC0", VA = "0x180D66FC0")]
			private void _UpdateExpInfo(BattleController controller, bool force)
			{
			}

			// Token: 0x06014F5A RID: 85850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F5A")]
			[Address(RVA = "0xD66DA0", Offset = "0xD659A0", VA = "0x180D66DA0")]
			private void _OnExpReached(object arg)
			{
			}

			// Token: 0x06014F5B RID: 85851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F5B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UITopbarStatusRL3()
			{
			}

			// Token: 0x04018ED2 RID: 102098
			[Token(Token = "0x4018ED2")]
			[FieldOffset(Offset = "0x10")]
			public GameObject container;

			// Token: 0x04018ED3 RID: 102099
			[Token(Token = "0x4018ED3")]
			[FieldOffset(Offset = "0x18")]
			public UILifePoint lifePoint;

			// Token: 0x04018ED4 RID: 102100
			[Token(Token = "0x4018ED4")]
			[FieldOffset(Offset = "0x20")]
			public UILifePointRL3 _RL3LifepointMask;

			// Token: 0x04018ED5 RID: 102101
			[Token(Token = "0x4018ED5")]
			[FieldOffset(Offset = "0x28")]
			public Text monsterInfoText;

			// Token: 0x04018ED6 RID: 102102
			[Token(Token = "0x4018ED6")]
			[FieldOffset(Offset = "0x30")]
			public Text expText;

			// Token: 0x04018ED7 RID: 102103
			[Token(Token = "0x4018ED7")]
			[FieldOffset(Offset = "0x38")]
			public UIAtlasImage expImage;

			// Token: 0x04018ED8 RID: 102104
			[Token(Token = "0x4018ED8")]
			[FieldOffset(Offset = "0x40")]
			public Color expTweenColor;

			// Token: 0x04018ED9 RID: 102105
			[Token(Token = "0x4018ED9")]
			[FieldOffset(Offset = "0x50")]
			public float expTweenTime;

			// Token: 0x04018EDA RID: 102106
			[Token(Token = "0x4018EDA")]
			[FieldOffset(Offset = "0x58")]
			public UILifeLostGroup lifeLostContainer;

			// Token: 0x04018EDB RID: 102107
			[Token(Token = "0x4018EDB")]
			[FieldOffset(Offset = "0x60")]
			private int m_cachedFinishedEnemiesCnt;

			// Token: 0x04018EDC RID: 102108
			[Token(Token = "0x4018EDC")]
			[FieldOffset(Offset = "0x64")]
			private int m_cachedTotalEnemiesCnt;

			// Token: 0x04018EDD RID: 102109
			[Token(Token = "0x4018EDD")]
			[FieldOffset(Offset = "0x68")]
			private int m_cachedExp;

			// Token: 0x04018EDE RID: 102110
			[Token(Token = "0x4018EDE")]
			[FieldOffset(Offset = "0x70")]
			private Tween m_tween;

			// Token: 0x04018EDF RID: 102111
			[Token(Token = "0x4018EDF")]
			[FieldOffset(Offset = "0x78")]
			private Color m_originColor;
		}
	}
}
