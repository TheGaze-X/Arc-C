using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.EnemyDuel
{
	// Token: 0x0200339D RID: 13213
	[Token(Token = "0x200339D")]
	public class EnemyDuelUIPlugin : UIController.Plugin
	{
		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x06015127 RID: 86311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700320A")]
		private GameModeFactory.EnemyDuelGameMode gameMode
		{
			[Token(Token = "0x6015127")]
			[Address(RVA = "0xD6AB50", Offset = "0xD69750", VA = "0x180D6AB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015128 RID: 86312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015128")]
		[Address(RVA = "0xD68C10", Offset = "0xD67810", VA = "0x180D68C10", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06015129 RID: 86313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015129")]
		[Address(RVA = "0xD69100", Offset = "0xD67D00", VA = "0x180D69100", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x0601512A RID: 86314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601512A")]
		[Address(RVA = "0xD68DD0", Offset = "0xD679D0", VA = "0x180D68DD0", Slot = "14")]
		public override void OnGameReset(BattleController battleController)
		{
		}

		// Token: 0x0601512B RID: 86315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601512B")]
		[Address(RVA = "0xD692D0", Offset = "0xD67ED0", VA = "0x180D692D0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601512C RID: 86316 RVA: 0x0008A480 File Offset: 0x00088680
		[Token(Token = "0x601512C")]
		[Address(RVA = "0xD68860", Offset = "0xD67460", VA = "0x180D68860", Slot = "45")]
		public override bool HookPauseMask(bool isPause)
		{
			return default(bool);
		}

		// Token: 0x0601512D RID: 86317 RVA: 0x0008A498 File Offset: 0x00088698
		[Token(Token = "0x601512D")]
		[Address(RVA = "0xD68710", Offset = "0xD67310", VA = "0x180D68710", Slot = "22")]
		public override bool HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601512E RID: 86318 RVA: 0x0008A4B0 File Offset: 0x000886B0
		[Token(Token = "0x601512E")]
		[Address(RVA = "0xD687F0", Offset = "0xD673F0", VA = "0x180D687F0", Slot = "23")]
		public override bool HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601512F RID: 86319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601512F")]
		[Address(RVA = "0xD69460", Offset = "0xD68060", VA = "0x180D69460")]
		public void OnRequestFinishGame()
		{
		}

		// Token: 0x06015130 RID: 86320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015130")]
		[Address(RVA = "0xD69AB0", Offset = "0xD686B0", VA = "0x180D69AB0")]
		private void _HookUITopBar()
		{
		}

		// Token: 0x06015131 RID: 86321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015131")]
		[Address(RVA = "0xD6A210", Offset = "0xD68E10", VA = "0x180D6A210")]
		private void _OnRoundStateChanged()
		{
		}

		// Token: 0x06015132 RID: 86322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015132")]
		[Address(RVA = "0xD69C80", Offset = "0xD68880", VA = "0x180D69C80")]
		private void _OnNextRoundWillStart()
		{
		}

		// Token: 0x06015133 RID: 86323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015133")]
		[Address(RVA = "0xD69B50", Offset = "0xD68750", VA = "0x180D69B50")]
		private void _OnBetStart()
		{
		}

		// Token: 0x06015134 RID: 86324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015134")]
		[Address(RVA = "0xD6A000", Offset = "0xD68C00", VA = "0x180D6A000")]
		private void _OnRoundBattleStart()
		{
		}

		// Token: 0x06015135 RID: 86325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015135")]
		[Address(RVA = "0xD6A0C0", Offset = "0xD68CC0", VA = "0x180D6A0C0")]
		private void _OnRoundSettle()
		{
		}

		// Token: 0x06015136 RID: 86326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015136")]
		[Address(RVA = "0xD6A790", Offset = "0xD69390", VA = "0x180D6A790")]
		private void _SwitchTimeState(EnemyDuelUIPlugin.RoundTimerState newState)
		{
		}

		// Token: 0x06015137 RID: 86327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015137")]
		[Address(RVA = "0xD69910", Offset = "0xD68510", VA = "0x180D69910")]
		private void _HandleEnemyDuelBattleStart(object arg)
		{
		}

		// Token: 0x06015138 RID: 86328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015138")]
		[Address(RVA = "0xD697C0", Offset = "0xD683C0", VA = "0x180D697C0")]
		private void _HandleEnemyDuelBattleEnd(object arg)
		{
		}

		// Token: 0x06015139 RID: 86329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015139")]
		[Address(RVA = "0xD69640", Offset = "0xD68240", VA = "0x180D69640")]
		private void _HandleBattleStatusChanged(object arg)
		{
		}

		// Token: 0x0601513A RID: 86330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601513A")]
		[Address(RVA = "0xD695B0", Offset = "0xD681B0", VA = "0x180D695B0")]
		private void _Bet_TimeEnd()
		{
		}

		// Token: 0x0601513B RID: 86331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601513B")]
		[Address(RVA = "0xD6A720", Offset = "0xD69320", VA = "0x180D6A720")]
		private void _Settle_TimeEnd()
		{
		}

		// Token: 0x0601513C RID: 86332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601513C")]
		[Address(RVA = "0xD69540", Offset = "0xD68140", VA = "0x180D69540")]
		private void _Battle_TimeEnd()
		{
		}

		// Token: 0x0601513D RID: 86333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601513D")]
		[Address(RVA = "0xD6A690", Offset = "0xD69290", VA = "0x180D6A690")]
		private void _RoundStartShow_TimeEnd()
		{
		}

		// Token: 0x0601513E RID: 86334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601513E")]
		[Address(RVA = "0xD69D90", Offset = "0xD68990", VA = "0x180D69D90")]
		private void _OnPlayerBet(object arg)
		{
		}

		// Token: 0x0601513F RID: 86335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601513F")]
		[Address(RVA = "0xD69ED0", Offset = "0xD68AD0", VA = "0x180D69ED0")]
		private void _OnPlayerSendEmoji(object arg)
		{
		}

		// Token: 0x06015140 RID: 86336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015140")]
		[Address(RVA = "0xD696D0", Offset = "0xD682D0", VA = "0x180D696D0")]
		private void _HandleEmojiRev(object args)
		{
		}

		// Token: 0x06015141 RID: 86337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015141")]
		[Address(RVA = "0xD699A0", Offset = "0xD685A0", VA = "0x180D699A0")]
		private void _HandleQuitRev(object args)
		{
		}

		// Token: 0x06015142 RID: 86338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015142")]
		[Address(RVA = "0xD68550", Offset = "0xD67150", VA = "0x180D68550")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06015143 RID: 86339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015143")]
		[Address(RVA = "0xD688F0", Offset = "0xD674F0", VA = "0x180D688F0")]
		public void OnDestroy()
		{
		}

		// Token: 0x06015144 RID: 86340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015144")]
		[Address(RVA = "0xD6AA80", Offset = "0xD69680", VA = "0x180D6AA80")]
		public EnemyDuelUIPlugin()
		{
		}

		// Token: 0x0601514A RID: 86346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601514A")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x0601514B RID: 86347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601514B")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x0601514C RID: 86348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601514C")]
		[Address(RVA = "0x7D24B0", Offset = "0x7D10B0", VA = "0x1807D24B0")]
		private void <>xLuaBaseProxy_OnGameReset(BattleController P0)
		{
		}

		// Token: 0x0601514D RID: 86349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601514D")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0601514E RID: 86350 RVA: 0x0008A4C8 File Offset: 0x000886C8
		[Token(Token = "0x601514E")]
		[Address(RVA = "0xA032B0", Offset = "0xA01EB0", VA = "0x180A032B0")]
		private bool <>xLuaBaseProxy_HookPauseMask(bool P0)
		{
			return default(bool);
		}

		// Token: 0x0601514F RID: 86351 RVA: 0x0008A4E0 File Offset: 0x000886E0
		[Token(Token = "0x601514F")]
		[Address(RVA = "0x9CCDA0", Offset = "0x9CB9A0", VA = "0x1809CCDA0")]
		private bool <>xLuaBaseProxy_HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015150 RID: 86352 RVA: 0x0008A4F8 File Offset: 0x000886F8
		[Token(Token = "0x6015150")]
		[Address(RVA = "0xD69530", Offset = "0xD68130", VA = "0x180D69530")]
		private bool <>xLuaBaseProxy_HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0401916A RID: 102762
		[Token(Token = "0x401916A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_BATTLE_START;

		// Token: 0x0401916B RID: 102763
		[Token(Token = "0x401916B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<UIStateNode> _states;

		// Token: 0x0401916C RID: 102764
		[Token(Token = "0x401916C")]
		[FieldOffset(Offset = "0x30")]
		private SpeedLevel m_defaultSpeedLevel;

		// Token: 0x0401916D RID: 102765
		[Token(Token = "0x401916D")]
		[FieldOffset(Offset = "0x38")]
		private ActivityEnemyDuelConstData m_constData;

		// Token: 0x0401916E RID: 102766
		[Token(Token = "0x401916E")]
		[FieldOffset(Offset = "0x40")]
		private EnemyDuelModeType m_modeType;

		// Token: 0x0401916F RID: 102767
		[Token(Token = "0x401916F")]
		[FieldOffset(Offset = "0x44")]
		private EnemyDuelServiceGameState m_curRoundState;

		// Token: 0x04019170 RID: 102768
		[Token(Token = "0x4019170")]
		[FieldOffset(Offset = "0x48")]
		private EnemyDuelUIPlugin.RoundTimerState m_timerState;

		// Token: 0x04019171 RID: 102769
		[Token(Token = "0x4019171")]
		[FieldOffset(Offset = "0x50")]
		private PeriodicTimer m_stateTimer;

		// Token: 0x04019172 RID: 102770
		[Token(Token = "0x4019172")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isMultiPlayer;

		// Token: 0x04019173 RID: 102771
		[Token(Token = "0x4019173")]
		[FieldOffset(Offset = "0x60")]
		private GameModeFactory.EnemyDuelGameMode m_gameMode;

		// Token: 0x04019174 RID: 102772
		[Token(Token = "0x4019174")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x04019175 RID: 102773
		[Token(Token = "0x4019175")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04019176 RID: 102774
		[Token(Token = "0x4019176")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04019177 RID: 102775
		[Token(Token = "0x4019177")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x04019178 RID: 102776
		[Token(Token = "0x4019178")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04019179 RID: 102777
		[Token(Token = "0x4019179")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookPauseMask;

		// Token: 0x0401917A RID: 102778
		[Token(Token = "0x401917A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

		// Token: 0x0401917B RID: 102779
		[Token(Token = "0x401917B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookGameStartStateSwitch;

		// Token: 0x0401917C RID: 102780
		[Token(Token = "0x401917C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRequestFinishGame;

		// Token: 0x0401917D RID: 102781
		[Token(Token = "0x401917D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HookUITopBar;

		// Token: 0x0401917E RID: 102782
		[Token(Token = "0x401917E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnRoundStateChanged;

		// Token: 0x0401917F RID: 102783
		[Token(Token = "0x401917F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnNextRoundWillStart;

		// Token: 0x04019180 RID: 102784
		[Token(Token = "0x4019180")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBetStart;

		// Token: 0x04019181 RID: 102785
		[Token(Token = "0x4019181")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRoundBattleStart;

		// Token: 0x04019182 RID: 102786
		[Token(Token = "0x4019182")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRoundSettle;

		// Token: 0x04019183 RID: 102787
		[Token(Token = "0x4019183")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SwitchTimeState;

		// Token: 0x04019184 RID: 102788
		[Token(Token = "0x4019184")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleEnemyDuelBattleStart;

		// Token: 0x04019185 RID: 102789
		[Token(Token = "0x4019185")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleEnemyDuelBattleEnd;

		// Token: 0x04019186 RID: 102790
		[Token(Token = "0x4019186")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleBattleStatusChanged;

		// Token: 0x04019187 RID: 102791
		[Token(Token = "0x4019187")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__Bet_TimeEnd;

		// Token: 0x04019188 RID: 102792
		[Token(Token = "0x4019188")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__Settle_TimeEnd;

		// Token: 0x04019189 RID: 102793
		[Token(Token = "0x4019189")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__Battle_TimeEnd;

		// Token: 0x0401918A RID: 102794
		[Token(Token = "0x401918A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RoundStartShow_TimeEnd;

		// Token: 0x0401918B RID: 102795
		[Token(Token = "0x401918B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnPlayerBet;

		// Token: 0x0401918C RID: 102796
		[Token(Token = "0x401918C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnPlayerSendEmoji;

		// Token: 0x0401918D RID: 102797
		[Token(Token = "0x401918D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandleEmojiRev;

		// Token: 0x0401918E RID: 102798
		[Token(Token = "0x401918E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__HandleQuitRev;

		// Token: 0x0401918F RID: 102799
		[Token(Token = "0x401918F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04019190 RID: 102800
		[Token(Token = "0x4019190")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019191 RID: 102801
		[Token(Token = "0x4019191")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200339E RID: 13214
		[Token(Token = "0x200339E")]
		private enum RoundTimerState
		{
			// Token: 0x04019193 RID: 102803
			[Token(Token = "0x4019193")]
			NONE,
			// Token: 0x04019194 RID: 102804
			[Token(Token = "0x4019194")]
			ROUND_START_ENEMY_SHOW,
			// Token: 0x04019195 RID: 102805
			[Token(Token = "0x4019195")]
			BET,
			// Token: 0x04019196 RID: 102806
			[Token(Token = "0x4019196")]
			BATTLE,
			// Token: 0x04019197 RID: 102807
			[Token(Token = "0x4019197")]
			SETTLE
		}
	}
}
