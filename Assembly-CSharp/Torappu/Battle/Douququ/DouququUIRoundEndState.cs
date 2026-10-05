using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A41 RID: 10817
	[Token(Token = "0x2002A41")]
	public class DouququUIRoundEndState : CommonUIStateNode
	{
		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06011F65 RID: 73573 RVA: 0x0006DDA0 File Offset: 0x0006BFA0
		[Token(Token = "0x17002780")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6011F65")]
			[Address(RVA = "0xA04310", Offset = "0xA02F10", VA = "0x180A04310", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x06011F66 RID: 73574 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
		[Token(Token = "0x17002781")]
		public override bool enablePause
		{
			[Token(Token = "0x6011F66")]
			[Address(RVA = "0xA041F0", Offset = "0xA02DF0", VA = "0x180A041F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06011F67 RID: 73575 RVA: 0x0006DDD0 File Offset: 0x0006BFD0
		[Token(Token = "0x17002782")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6011F67")]
			[Address(RVA = "0xA04250", Offset = "0xA02E50", VA = "0x180A04250", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x06011F68 RID: 73576 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
		[Token(Token = "0x17002783")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6011F68")]
			[Address(RVA = "0xA042B0", Offset = "0xA02EB0", VA = "0x180A042B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x06011F69 RID: 73577 RVA: 0x0006DE00 File Offset: 0x0006C000
		[Token(Token = "0x17002784")]
		public override bool enableBackpress
		{
			[Token(Token = "0x6011F69")]
			[Address(RVA = "0xA04190", Offset = "0xA02D90", VA = "0x180A04190", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011F6A RID: 73578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F6A")]
		[Address(RVA = "0xA03BB0", Offset = "0xA027B0", VA = "0x180A03BB0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011F6B RID: 73579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F6B")]
		[Address(RVA = "0xA03910", Offset = "0xA02510", VA = "0x180A03910", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06011F6C RID: 73580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F6C")]
		[Address(RVA = "0xA040D0", Offset = "0xA02CD0", VA = "0x180A040D0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011F6D RID: 73581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F6D")]
		[Address(RVA = "0xA03AE0", Offset = "0xA026E0", VA = "0x180A03AE0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06011F6E RID: 73582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F6E")]
		[Address(RVA = "0xA04040", Offset = "0xA02C40", VA = "0x180A04040")]
		public void OnRoundResultShowEnd()
		{
		}

		// Token: 0x06011F6F RID: 73583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F6F")]
		[Address(RVA = "0xA03EC0", Offset = "0xA02AC0", VA = "0x180A03EC0")]
		public void OnRoundEndOver(bool isFinish)
		{
		}

		// Token: 0x06011F70 RID: 73584 RVA: 0x0006DE18 File Offset: 0x0006C018
		[Token(Token = "0x6011F70")]
		[Address(RVA = "0xA038A0", Offset = "0xA024A0", VA = "0x180A038A0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06011F71 RID: 73585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F71")]
		[Address(RVA = "0xA04130", Offset = "0xA02D30", VA = "0x180A04130")]
		public DouququUIRoundEndState()
		{
		}

		// Token: 0x06011F72 RID: 73586 RVA: 0x0006DE30 File Offset: 0x0006C030
		[Token(Token = "0x6011F72")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06011F73 RID: 73587 RVA: 0x0006DE48 File Offset: 0x0006C048
		[Token(Token = "0x6011F73")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06011F74 RID: 73588 RVA: 0x0006DE60 File Offset: 0x0006C060
		[Token(Token = "0x6011F74")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011F75 RID: 73589 RVA: 0x0006DE78 File Offset: 0x0006C078
		[Token(Token = "0x6011F75")]
		[Address(RVA = "0x785E20", Offset = "0x784A20", VA = "0x180785E20")]
		private bool <>xLuaBaseProxy_get_enableBackpress()
		{
			return default(bool);
		}

		// Token: 0x06011F76 RID: 73590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F76")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06011F77 RID: 73591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F77")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06011F78 RID: 73592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F78")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06011F79 RID: 73593 RVA: 0x0006DE90 File Offset: 0x0006C090
		[Token(Token = "0x6011F79")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0401446D RID: 83053
		[Token(Token = "0x401446D")]
		[FieldOffset(Offset = "0x50")]
		private DouququUIPlugin m_plugin;

		// Token: 0x0401446E RID: 83054
		[Token(Token = "0x401446E")]
		[FieldOffset(Offset = "0x58")]
		private UIBattleDouququRoundEndPanel m_panel;

		// Token: 0x0401446F RID: 83055
		[Token(Token = "0x401446F")]
		[FieldOffset(Offset = "0x60")]
		private GameModeFactory.DouququGameMode m_manager;

		// Token: 0x04014470 RID: 83056
		[Token(Token = "0x4014470")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04014471 RID: 83057
		[Token(Token = "0x4014471")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04014472 RID: 83058
		[Token(Token = "0x4014472")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04014473 RID: 83059
		[Token(Token = "0x4014473")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04014474 RID: 83060
		[Token(Token = "0x4014474")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enableBackpress;

		// Token: 0x04014475 RID: 83061
		[Token(Token = "0x4014475")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04014476 RID: 83062
		[Token(Token = "0x4014476")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04014477 RID: 83063
		[Token(Token = "0x4014477")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014478 RID: 83064
		[Token(Token = "0x4014478")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04014479 RID: 83065
		[Token(Token = "0x4014479")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRoundResultShowEnd;

		// Token: 0x0401447A RID: 83066
		[Token(Token = "0x401447A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRoundEndOver;

		// Token: 0x0401447B RID: 83067
		[Token(Token = "0x401447B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0401447C RID: 83068
		[Token(Token = "0x401447C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
