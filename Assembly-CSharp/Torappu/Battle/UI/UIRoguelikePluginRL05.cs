using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003345 RID: 13125
	[Token(Token = "0x2003345")]
	public class UIRoguelikePluginRL05 : UIController.Plugin
	{
		// Token: 0x06014EF8 RID: 85752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EF8")]
		[Address(RVA = "0xD624B0", Offset = "0xD610B0", VA = "0x180D624B0", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06014EF9 RID: 85753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EF9")]
		[Address(RVA = "0xD62690", Offset = "0xD61290", VA = "0x180D62690", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06014EFA RID: 85754 RVA: 0x00089820 File Offset: 0x00087A20
		[Token(Token = "0x6014EFA")]
		[Address(RVA = "0xD622D0", Offset = "0xD60ED0", VA = "0x180D622D0", Slot = "22")]
		public override bool HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014EFB RID: 85755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EFB")]
		[Address(RVA = "0xD62A10", Offset = "0xD61610", VA = "0x180D62A10", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06014EFC RID: 85756 RVA: 0x00089838 File Offset: 0x00087A38
		[Token(Token = "0x6014EFC")]
		[Address(RVA = "0xD62060", Offset = "0xD60C60", VA = "0x180D62060", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x06014EFD RID: 85757 RVA: 0x00089850 File Offset: 0x00087A50
		[Token(Token = "0x6014EFD")]
		[Address(RVA = "0xD61E80", Offset = "0xD60A80", VA = "0x180D61E80", Slot = "30")]
		public override bool HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014EFE RID: 85758 RVA: 0x00089868 File Offset: 0x00087A68
		[Token(Token = "0x6014EFE")]
		[Address(RVA = "0xD61DF0", Offset = "0xD609F0", VA = "0x180D61DF0", Slot = "31")]
		public override bool HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x06014EFF RID: 85759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EFF")]
		[Address(RVA = "0xD62BD0", Offset = "0xD617D0", VA = "0x180D62BD0")]
		private void _InitTopBar()
		{
		}

		// Token: 0x06014F00 RID: 85760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F00")]
		[Address(RVA = "0xD62B20", Offset = "0xD61720", VA = "0x180D62B20")]
		private void _InitFailedPanel()
		{
		}

		// Token: 0x06014F01 RID: 85761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F01")]
		[Address(RVA = "0xD62CF0", Offset = "0xD618F0", VA = "0x180D62CF0")]
		public UIRoguelikePluginRL05()
		{
		}

		// Token: 0x06014F02 RID: 85762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F02")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06014F03 RID: 85763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F03")]
		[Address(RVA = "0xD520E0", Offset = "0xD50CE0", VA = "0x180D520E0")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06014F04 RID: 85764 RVA: 0x00089880 File Offset: 0x00087A80
		[Token(Token = "0x6014F04")]
		[Address(RVA = "0xD57EA0", Offset = "0xD56AA0", VA = "0x180D57EA0")]
		private bool <>xLuaBaseProxy_HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014F05 RID: 85765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F05")]
		[Address(RVA = "0xD52260", Offset = "0xD50E60", VA = "0x180D52260")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06014F06 RID: 85766 RVA: 0x00089898 File Offset: 0x00087A98
		[Token(Token = "0x6014F06")]
		[Address(RVA = "0xD57D40", Offset = "0xD56940", VA = "0x180D57D40")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x06014F07 RID: 85767 RVA: 0x000898B0 File Offset: 0x00087AB0
		[Token(Token = "0x6014F07")]
		[Address(RVA = "0xD57AE0", Offset = "0xD566E0", VA = "0x180D57AE0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014F08 RID: 85768 RVA: 0x000898C8 File Offset: 0x00087AC8
		[Token(Token = "0x6014F08")]
		[Address(RVA = "0xD57A20", Offset = "0xD56620", VA = "0x180D57A20")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x04018E57 RID: 101975
		[Token(Token = "0x4018E57")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("BattleFailedMask")]
		private UIRoguelikeBattleFailedMaskRL5Zone _battleFailedMaskPrefab;

		// Token: 0x04018E58 RID: 101976
		[Token(Token = "0x4018E58")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("BattleFailedMask")]
		private UIRoguelikeBattleFailedMaskRL5Zone _battleFailedMaskSpZonePrefab;

		// Token: 0x04018E59 RID: 101977
		[Token(Token = "0x4018E59")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("BattleFailedMask")]
		private UIRoguelikeBattleFailedMaskRL5Zone _battleFailedMaskSpZoneOutPrefab;

		// Token: 0x04018E5A RID: 101978
		[Token(Token = "0x4018E5A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRoguelikePluginRL05.UITopbarStatusRL5 _UITopbarStatusRL5;

		// Token: 0x04018E5B RID: 101979
		[Token(Token = "0x4018E5B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIGoldStealBattleToastPanelRL05 _goldStealBattleToastPrefab;

		// Token: 0x04018E5C RID: 101980
		[Token(Token = "0x4018E5C")]
		[FieldOffset(Offset = "0x50")]
		private UIRoguelikePluginRL05.UITopbarStatusRL5 m_currentStatus;

		// Token: 0x04018E5D RID: 101981
		[Token(Token = "0x4018E5D")]
		[FieldOffset(Offset = "0x58")]
		private UIRoguelikeBattleFailedMaskRL5Zone m_failedPanel;

		// Token: 0x04018E5E RID: 101982
		[Token(Token = "0x4018E5E")]
		[FieldOffset(Offset = "0x60")]
		private GameModeFactory.RoguelikeGameMode m_gameMode;

		// Token: 0x04018E5F RID: 101983
		[Token(Token = "0x4018E5F")]
		[FieldOffset(Offset = "0x68")]
		private Animator m_failedAnimator;

		// Token: 0x04018E60 RID: 101984
		[Token(Token = "0x4018E60")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isSpZoneType;

		// Token: 0x04018E61 RID: 101985
		[Token(Token = "0x4018E61")]
		[FieldOffset(Offset = "0x71")]
		private bool m_isSpZoneOut;

		// Token: 0x04018E62 RID: 101986
		[Token(Token = "0x4018E62")]
		[FieldOffset(Offset = "0x78")]
		private UIGoldStealBattleToastPanelRL05 m_goldStealToast;

		// Token: 0x04018E63 RID: 101987
		[Token(Token = "0x4018E63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04018E64 RID: 101988
		[Token(Token = "0x4018E64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04018E65 RID: 101989
		[Token(Token = "0x4018E65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

		// Token: 0x04018E66 RID: 101990
		[Token(Token = "0x4018E66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04018E67 RID: 101991
		[Token(Token = "0x4018E67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x04018E68 RID: 101992
		[Token(Token = "0x4018E68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelShow;

		// Token: 0x04018E69 RID: 101993
		[Token(Token = "0x4018E69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelHide;

		// Token: 0x04018E6A RID: 101994
		[Token(Token = "0x4018E6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitTopBar;

		// Token: 0x04018E6B RID: 101995
		[Token(Token = "0x4018E6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitFailedPanel;

		// Token: 0x04018E6C RID: 101996
		[Token(Token = "0x4018E6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003346 RID: 13126
		[Token(Token = "0x2003346")]
		public enum ToastTypeRL05
		{
			// Token: 0x04018E6E RID: 101998
			[Token(Token = "0x4018E6E")]
			GOLD_STEAL = 7
		}

		// Token: 0x02003347 RID: 13127
		[Token(Token = "0x2003347")]
		[Serializable]
		public class UITopbarStatusRL5
		{
			// Token: 0x170031AD RID: 12717
			// (get) Token: 0x06014F09 RID: 85769 RVA: 0x000898E0 File Offset: 0x00087AE0
			[Token(Token = "0x170031AD")]
			public int killedEnemiesCnt
			{
				[Token(Token = "0x6014F09")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170031AE RID: 12718
			// (get) Token: 0x06014F0A RID: 85770 RVA: 0x000898F8 File Offset: 0x00087AF8
			[Token(Token = "0x170031AE")]
			public int totalEnemiesCnt
			{
				[Token(Token = "0x6014F0A")]
				[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06014F0B RID: 85771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F0B")]
			[Address(RVA = "0xD672D0", Offset = "0xD65ED0", VA = "0x180D672D0")]
			public void InitData(BattleController controller, bool isSpZoneType)
			{
			}

			// Token: 0x06014F0C RID: 85772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F0C")]
			[Address(RVA = "0xD672F0", Offset = "0xD65EF0", VA = "0x180D672F0")]
			public void UpdateData(BattleController controller, bool hideLifePoint, bool force)
			{
			}

			// Token: 0x06014F0D RID: 85773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F0D")]
			[Address(RVA = "0xD67460", Offset = "0xD66060", VA = "0x180D67460")]
			private void _UpdateEnemyInfo(BattleController controller, bool force)
			{
			}

			// Token: 0x06014F0E RID: 85774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014F0E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UITopbarStatusRL5()
			{
			}

			// Token: 0x04018E6F RID: 101999
			[Token(Token = "0x4018E6F")]
			[FieldOffset(Offset = "0x10")]
			public GameObject container;

			// Token: 0x04018E70 RID: 102000
			[Token(Token = "0x4018E70")]
			[FieldOffset(Offset = "0x18")]
			public Text enemyInfoText;

			// Token: 0x04018E71 RID: 102001
			[Token(Token = "0x4018E71")]
			[FieldOffset(Offset = "0x20")]
			private int m_cachedKillededEnemiesCnt;

			// Token: 0x04018E72 RID: 102002
			[Token(Token = "0x4018E72")]
			[FieldOffset(Offset = "0x24")]
			private int m_cachedTotalEnemiesCnt;
		}
	}
}
