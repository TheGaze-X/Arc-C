using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A40 RID: 10816
	[Token(Token = "0x2002A40")]
	public class DouququUIAnnounceState : CommonUIStateNode
	{
		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x06011F51 RID: 73553 RVA: 0x0006DC98 File Offset: 0x0006BE98
		[Token(Token = "0x1700277B")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6011F51")]
			[Address(RVA = "0xA021F0", Offset = "0xA00DF0", VA = "0x180A021F0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x06011F52 RID: 73554 RVA: 0x0006DCB0 File Offset: 0x0006BEB0
		[Token(Token = "0x1700277C")]
		public override bool enablePause
		{
			[Token(Token = "0x6011F52")]
			[Address(RVA = "0xA020D0", Offset = "0xA00CD0", VA = "0x180A020D0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x06011F53 RID: 73555 RVA: 0x0006DCC8 File Offset: 0x0006BEC8
		[Token(Token = "0x1700277D")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6011F53")]
			[Address(RVA = "0xA02130", Offset = "0xA00D30", VA = "0x180A02130", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06011F54 RID: 73556 RVA: 0x0006DCE0 File Offset: 0x0006BEE0
		[Token(Token = "0x1700277E")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6011F54")]
			[Address(RVA = "0xA02190", Offset = "0xA00D90", VA = "0x180A02190", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06011F55 RID: 73557 RVA: 0x0006DCF8 File Offset: 0x0006BEF8
		[Token(Token = "0x1700277F")]
		public override bool enableBackpress
		{
			[Token(Token = "0x6011F55")]
			[Address(RVA = "0xA02070", Offset = "0xA00C70", VA = "0x180A02070", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011F56 RID: 73558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F56")]
		[Address(RVA = "0xA01C90", Offset = "0xA00890", VA = "0x180A01C90", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011F57 RID: 73559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F57")]
		[Address(RVA = "0xA019D0", Offset = "0xA005D0", VA = "0x180A019D0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06011F58 RID: 73560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F58")]
		[Address(RVA = "0xA01FB0", Offset = "0xA00BB0", VA = "0x180A01FB0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011F59 RID: 73561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F59")]
		[Address(RVA = "0xA01BC0", Offset = "0xA007C0", VA = "0x180A01BC0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06011F5A RID: 73562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F5A")]
		[Address(RVA = "0xA01870", Offset = "0xA00470", VA = "0x180A01870")]
		public void OnAnnounceEnd()
		{
		}

		// Token: 0x06011F5B RID: 73563 RVA: 0x0006DD10 File Offset: 0x0006BF10
		[Token(Token = "0x6011F5B")]
		[Address(RVA = "0xA01800", Offset = "0xA00400", VA = "0x180A01800", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06011F5C RID: 73564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F5C")]
		[Address(RVA = "0xA02010", Offset = "0xA00C10", VA = "0x180A02010")]
		public DouququUIAnnounceState()
		{
		}

		// Token: 0x06011F5D RID: 73565 RVA: 0x0006DD28 File Offset: 0x0006BF28
		[Token(Token = "0x6011F5D")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06011F5E RID: 73566 RVA: 0x0006DD40 File Offset: 0x0006BF40
		[Token(Token = "0x6011F5E")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06011F5F RID: 73567 RVA: 0x0006DD58 File Offset: 0x0006BF58
		[Token(Token = "0x6011F5F")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011F60 RID: 73568 RVA: 0x0006DD70 File Offset: 0x0006BF70
		[Token(Token = "0x6011F60")]
		[Address(RVA = "0x785E20", Offset = "0x784A20", VA = "0x180785E20")]
		private bool <>xLuaBaseProxy_get_enableBackpress()
		{
			return default(bool);
		}

		// Token: 0x06011F61 RID: 73569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F61")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06011F62 RID: 73570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F62")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06011F63 RID: 73571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F63")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06011F64 RID: 73572 RVA: 0x0006DD88 File Offset: 0x0006BF88
		[Token(Token = "0x6011F64")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0401445D RID: 83037
		[Token(Token = "0x401445D")]
		[FieldOffset(Offset = "0x50")]
		private DouququUIPlugin m_plugin;

		// Token: 0x0401445E RID: 83038
		[Token(Token = "0x401445E")]
		[FieldOffset(Offset = "0x58")]
		private UIBattleDouququAnnouncePanel m_panel;

		// Token: 0x0401445F RID: 83039
		[Token(Token = "0x401445F")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasStartBattle;

		// Token: 0x04014460 RID: 83040
		[Token(Token = "0x4014460")]
		[FieldOffset(Offset = "0x68")]
		private GameModeFactory.DouququGameMode m_manager;

		// Token: 0x04014461 RID: 83041
		[Token(Token = "0x4014461")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04014462 RID: 83042
		[Token(Token = "0x4014462")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04014463 RID: 83043
		[Token(Token = "0x4014463")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04014464 RID: 83044
		[Token(Token = "0x4014464")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04014465 RID: 83045
		[Token(Token = "0x4014465")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enableBackpress;

		// Token: 0x04014466 RID: 83046
		[Token(Token = "0x4014466")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04014467 RID: 83047
		[Token(Token = "0x4014467")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04014468 RID: 83048
		[Token(Token = "0x4014468")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014469 RID: 83049
		[Token(Token = "0x4014469")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401446A RID: 83050
		[Token(Token = "0x401446A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnAnnounceEnd;

		// Token: 0x0401446B RID: 83051
		[Token(Token = "0x401446B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0401446C RID: 83052
		[Token(Token = "0x401446C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
