using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A42 RID: 10818
	[Token(Token = "0x2002A42")]
	public class DouququUIPlugin : UIController.Plugin
	{
		// Token: 0x06011F7A RID: 73594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F7A")]
		[Address(RVA = "0xA027D0", Offset = "0xA013D0", VA = "0x180A027D0", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06011F7B RID: 73595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F7B")]
		[Address(RVA = "0xA02A20", Offset = "0xA01620", VA = "0x180A02A20", Slot = "14")]
		public override void OnGameReset(BattleController battleController)
		{
		}

		// Token: 0x06011F7C RID: 73596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F7C")]
		[Address(RVA = "0xA02CA0", Offset = "0xA018A0", VA = "0x180A02CA0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011F7D RID: 73597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F7D")]
		[Address(RVA = "0xA02BB0", Offset = "0xA017B0", VA = "0x180A02BB0", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06011F7E RID: 73598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F7E")]
		[Address(RVA = "0xA02610", Offset = "0xA01210", VA = "0x180A02610", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06011F7F RID: 73599 RVA: 0x0006DEA8 File Offset: 0x0006C0A8
		[Token(Token = "0x6011F7F")]
		[Address(RVA = "0xA02280", Offset = "0xA00E80", VA = "0x180A02280", Slot = "45")]
		public override bool HookPauseMask(bool isPause)
		{
			return default(bool);
		}

		// Token: 0x06011F80 RID: 73600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F80")]
		[Address(RVA = "0xA02310", Offset = "0xA00F10", VA = "0x180A02310")]
		public void OnAnnounceEnd(bool isFirst)
		{
		}

		// Token: 0x06011F81 RID: 73601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F81")]
		[Address(RVA = "0xA02400", Offset = "0xA01000", VA = "0x180A02400")]
		public void OnBetEnd()
		{
		}

		// Token: 0x06011F82 RID: 73602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F82")]
		[Address(RVA = "0xA02E20", Offset = "0xA01A20", VA = "0x180A02E20")]
		public void OnRoundEndOver(bool isFinish)
		{
		}

		// Token: 0x06011F83 RID: 73603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F83")]
		[Address(RVA = "0xA036D0", Offset = "0xA022D0", VA = "0x180A036D0")]
		private void _ShowBetPanel()
		{
		}

		// Token: 0x06011F84 RID: 73604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F84")]
		[Address(RVA = "0xA032C0", Offset = "0xA01EC0", VA = "0x180A032C0")]
		private void _HideBetPanel()
		{
		}

		// Token: 0x06011F85 RID: 73605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F85")]
		[Address(RVA = "0xA033E0", Offset = "0xA01FE0", VA = "0x180A033E0")]
		private void _HookUITopBar()
		{
		}

		// Token: 0x06011F86 RID: 73606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F86")]
		[Address(RVA = "0xA03480", Offset = "0xA02080", VA = "0x180A03480")]
		private void _OnCurWaveWillFinish(float postDelay)
		{
		}

		// Token: 0x06011F87 RID: 73607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F87")]
		[Address(RVA = "0xA03580", Offset = "0xA02180", VA = "0x180A03580")]
		private void _OnCurWaveWillStart(float preDelay)
		{
		}

		// Token: 0x06011F88 RID: 73608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F88")]
		[Address(RVA = "0xA037F0", Offset = "0xA023F0", VA = "0x180A037F0")]
		public DouququUIPlugin()
		{
		}

		// Token: 0x06011F8C RID: 73612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F8C")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06011F8D RID: 73613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F8D")]
		[Address(RVA = "0x7D24B0", Offset = "0x7D10B0", VA = "0x1807D24B0")]
		private void <>xLuaBaseProxy_OnGameReset(BattleController P0)
		{
		}

		// Token: 0x06011F8E RID: 73614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F8E")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06011F8F RID: 73615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F8F")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x06011F90 RID: 73616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F90")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06011F91 RID: 73617 RVA: 0x0006DEC0 File Offset: 0x0006C0C0
		[Token(Token = "0x6011F91")]
		[Address(RVA = "0xA032B0", Offset = "0xA01EB0", VA = "0x180A032B0")]
		private bool <>xLuaBaseProxy_HookPauseMask(bool P0)
		{
			return default(bool);
		}

		// Token: 0x0401447D RID: 83069
		[Token(Token = "0x401447D")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly UIStateEnum UI_STATE_ANNOUNCE;

		// Token: 0x0401447E RID: 83070
		[Token(Token = "0x401447E")]
		[FieldOffset(Offset = "0x4")]
		[HideInInspector]
		public static readonly UIStateEnum UI_STATE_ROUND_END;

		// Token: 0x0401447F RID: 83071
		[Token(Token = "0x401447F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04014480 RID: 83072
		[Token(Token = "0x4014480")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBattleDouququBetPanel _betPanel;

		// Token: 0x04014481 RID: 83073
		[Token(Token = "0x4014481")]
		[FieldOffset(Offset = "0x38")]
		private GameModeFactory.DouququGameMode m_gameMode;

		// Token: 0x04014482 RID: 83074
		[Token(Token = "0x4014482")]
		[FieldOffset(Offset = "0x40")]
		private UIBattleDouququBetPanel m_betPanel;

		// Token: 0x04014483 RID: 83075
		[Token(Token = "0x4014483")]
		[FieldOffset(Offset = "0x48")]
		private SpeedLevel m_cacheSpeedLevel;

		// Token: 0x04014484 RID: 83076
		[Token(Token = "0x4014484")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isInBet;

		// Token: 0x04014485 RID: 83077
		[Token(Token = "0x4014485")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04014486 RID: 83078
		[Token(Token = "0x4014486")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x04014487 RID: 83079
		[Token(Token = "0x4014487")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04014488 RID: 83080
		[Token(Token = "0x4014488")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04014489 RID: 83081
		[Token(Token = "0x4014489")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401448A RID: 83082
		[Token(Token = "0x401448A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookPauseMask;

		// Token: 0x0401448B RID: 83083
		[Token(Token = "0x401448B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnAnnounceEnd;

		// Token: 0x0401448C RID: 83084
		[Token(Token = "0x401448C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBetEnd;

		// Token: 0x0401448D RID: 83085
		[Token(Token = "0x401448D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRoundEndOver;

		// Token: 0x0401448E RID: 83086
		[Token(Token = "0x401448E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowBetPanel;

		// Token: 0x0401448F RID: 83087
		[Token(Token = "0x401448F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HideBetPanel;

		// Token: 0x04014490 RID: 83088
		[Token(Token = "0x4014490")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HookUITopBar;

		// Token: 0x04014491 RID: 83089
		[Token(Token = "0x4014491")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnCurWaveWillFinish;

		// Token: 0x04014492 RID: 83090
		[Token(Token = "0x4014492")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnCurWaveWillStart;

		// Token: 0x04014493 RID: 83091
		[Token(Token = "0x4014493")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
