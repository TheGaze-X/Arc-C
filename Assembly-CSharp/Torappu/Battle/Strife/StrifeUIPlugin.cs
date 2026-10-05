using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Strife
{
	// Token: 0x02002688 RID: 9864
	[Token(Token = "0x2002688")]
	public class StrifeUIPlugin : UIController.Plugin
	{
		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x060101BE RID: 65982 RVA: 0x00062448 File Offset: 0x00060648
		[Token(Token = "0x1700231C")]
		public int finishWave
		{
			[Token(Token = "0x60101BE")]
			[Address(RVA = "0x7D2CA0", Offset = "0x7D18A0", VA = "0x1807D2CA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x060101BF RID: 65983 RVA: 0x00062460 File Offset: 0x00060660
		[Token(Token = "0x1700231D")]
		public int totalWave
		{
			[Token(Token = "0x60101BF")]
			[Address(RVA = "0x7D2D10", Offset = "0x7D1910", VA = "0x1807D2D10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060101C0 RID: 65984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C0")]
		[Address(RVA = "0x7D1F60", Offset = "0x7D0B60", VA = "0x1807D1F60", Slot = "14")]
		public override void OnGameReset(BattleController battleController)
		{
		}

		// Token: 0x060101C1 RID: 65985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C1")]
		[Address(RVA = "0x7D1BD0", Offset = "0x7D07D0", VA = "0x1807D1BD0", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x060101C2 RID: 65986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C2")]
		[Address(RVA = "0x7D1E80", Offset = "0x7D0A80", VA = "0x1807D1E80", Slot = "19")]
		public override void OnGameOver(BattleController.GameResult battleController)
		{
		}

		// Token: 0x060101C3 RID: 65987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C3")]
		[Address(RVA = "0x7D2080", Offset = "0x7D0C80", VA = "0x1807D2080", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x060101C4 RID: 65988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C4")]
		[Address(RVA = "0x7D1950", Offset = "0x7D0550", VA = "0x1807D1950", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x060101C5 RID: 65989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C5")]
		[Address(RVA = "0x7D2600", Offset = "0x7D1200", VA = "0x1807D2600")]
		public void UpdateRemainingDuration(object obj)
		{
		}

		// Token: 0x060101C6 RID: 65990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C6")]
		[Address(RVA = "0x7D26E0", Offset = "0x7D12E0", VA = "0x1807D26E0")]
		public void UpdateRemainingDuration(float remainingDuration, int totalDuration)
		{
		}

		// Token: 0x060101C7 RID: 65991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C7")]
		[Address(RVA = "0x7D2A10", Offset = "0x7D1610", VA = "0x1807D2A10")]
		private void _PreloadAssets()
		{
		}

		// Token: 0x060101C8 RID: 65992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C8")]
		[Address(RVA = "0x7D24F0", Offset = "0x7D10F0", VA = "0x1807D24F0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x060101C9 RID: 65993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101C9")]
		[Address(RVA = "0x7D2930", Offset = "0x7D1530", VA = "0x1807D2930")]
		private void _OnCurWaveWillFinish(float showTime)
		{
		}

		// Token: 0x060101CA RID: 65994 RVA: 0x00062478 File Offset: 0x00060678
		[Token(Token = "0x60101CA")]
		[Address(RVA = "0x7D1790", Offset = "0x7D0390", VA = "0x1807D1790", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x060101CB RID: 65995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101CB")]
		[Address(RVA = "0x7D2200", Offset = "0x7D0E00", VA = "0x1807D2200", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x060101CC RID: 65996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101CC")]
		[Address(RVA = "0x7D27A0", Offset = "0x7D13A0", VA = "0x1807D27A0")]
		private void _HookUITopBar()
		{
		}

		// Token: 0x060101CD RID: 65997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101CD")]
		[Address(RVA = "0x7D15E0", Offset = "0x7D01E0", VA = "0x1807D15E0")]
		public void CloseSystemMenuPanel()
		{
		}

		// Token: 0x060101CE RID: 65998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101CE")]
		[Address(RVA = "0x7D1690", Offset = "0x7D0290", VA = "0x1807D1690")]
		public void FinishGameDirectly()
		{
		}

		// Token: 0x060101CF RID: 65999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101CF")]
		[Address(RVA = "0x7D2BF0", Offset = "0x7D17F0", VA = "0x1807D2BF0")]
		public StrifeUIPlugin()
		{
		}

		// Token: 0x060101D2 RID: 66002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101D2")]
		[Address(RVA = "0x7D24B0", Offset = "0x7D10B0", VA = "0x1807D24B0")]
		private void <>xLuaBaseProxy_OnGameReset(BattleController P0)
		{
		}

		// Token: 0x060101D3 RID: 66003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101D3")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x060101D4 RID: 66004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101D4")]
		[Address(RVA = "0x7D24A0", Offset = "0x7D10A0", VA = "0x1807D24A0")]
		private void <>xLuaBaseProxy_OnGameOver(BattleController.GameResult P0)
		{
		}

		// Token: 0x060101D5 RID: 66005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101D5")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x060101D6 RID: 66006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101D6")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x060101D7 RID: 66007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101D7")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x060101D8 RID: 66008 RVA: 0x00062490 File Offset: 0x00060690
		[Token(Token = "0x60101D8")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x060101D9 RID: 66009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101D9")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D10D0", VA = "0x1807D24D0")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x04011F14 RID: 73492
		[Token(Token = "0x4011F14")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_SYSTEM_MENU;

		// Token: 0x04011F15 RID: 73493
		[Token(Token = "0x4011F15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UITopBar.BasicStatus _basicStatus;

		// Token: 0x04011F16 RID: 73494
		[Token(Token = "0x4011F16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04011F17 RID: 73495
		[Token(Token = "0x4011F17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIBattleStrifeLastWavePanel _lastWavePanel;

		// Token: 0x04011F18 RID: 73496
		[Token(Token = "0x4011F18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIBattleStrifeTopBar _topBarWaveInfo;

		// Token: 0x04011F19 RID: 73497
		[Token(Token = "0x4011F19")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIBattleBlurPanel _blurPanel;

		// Token: 0x04011F1A RID: 73498
		[Token(Token = "0x4011F1A")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.StrifeGameMode m_gameMode;

		// Token: 0x04011F1B RID: 73499
		[Token(Token = "0x4011F1B")]
		[FieldOffset(Offset = "0x58")]
		private UIBattleStrifeLastWavePanel m_lastWavePanel;

		// Token: 0x04011F1C RID: 73500
		[Token(Token = "0x4011F1C")]
		[FieldOffset(Offset = "0x60")]
		private int m_curWave;

		// Token: 0x04011F1D RID: 73501
		[Token(Token = "0x4011F1D")]
		[FieldOffset(Offset = "0x64")]
		private int m_totalWave;

		// Token: 0x04011F1E RID: 73502
		[Token(Token = "0x4011F1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_finishWave;

		// Token: 0x04011F1F RID: 73503
		[Token(Token = "0x4011F1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalWave;

		// Token: 0x04011F20 RID: 73504
		[Token(Token = "0x4011F20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x04011F21 RID: 73505
		[Token(Token = "0x4011F21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04011F22 RID: 73506
		[Token(Token = "0x4011F22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04011F23 RID: 73507
		[Token(Token = "0x4011F23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04011F24 RID: 73508
		[Token(Token = "0x4011F24")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04011F25 RID: 73509
		[Token(Token = "0x4011F25")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateRemainingDuration;

		// Token: 0x04011F26 RID: 73510
		[Token(Token = "0x4011F26")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_UpdateRemainingDuration;

		// Token: 0x04011F27 RID: 73511
		[Token(Token = "0x4011F27")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PreloadAssets;

		// Token: 0x04011F28 RID: 73512
		[Token(Token = "0x4011F28")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04011F29 RID: 73513
		[Token(Token = "0x4011F29")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnCurWaveWillFinish;

		// Token: 0x04011F2A RID: 73514
		[Token(Token = "0x4011F2A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x04011F2B RID: 73515
		[Token(Token = "0x4011F2B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x04011F2C RID: 73516
		[Token(Token = "0x4011F2C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HookUITopBar;

		// Token: 0x04011F2D RID: 73517
		[Token(Token = "0x4011F2D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CloseSystemMenuPanel;

		// Token: 0x04011F2E RID: 73518
		[Token(Token = "0x4011F2E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_FinishGameDirectly;

		// Token: 0x04011F2F RID: 73519
		[Token(Token = "0x4011F2F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
