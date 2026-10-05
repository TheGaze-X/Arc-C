using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI.EnemyDuel
{
	// Token: 0x020033A0 RID: 13216
	[Token(Token = "0x20033A0")]
	public class UIEnemyDuelBattleStartState : CommonUIStateNode, IFixedUpdateState
	{
		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x06015155 RID: 86357 RVA: 0x0008A510 File Offset: 0x00088710
		[Token(Token = "0x1700320B")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6015155")]
			[Address(RVA = "0xD97920", Offset = "0xD96520", VA = "0x180D97920", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x06015156 RID: 86358 RVA: 0x0008A528 File Offset: 0x00088728
		[Token(Token = "0x1700320C")]
		public override bool enablePause
		{
			[Token(Token = "0x6015156")]
			[Address(RVA = "0xD97800", Offset = "0xD96400", VA = "0x180D97800", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x06015157 RID: 86359 RVA: 0x0008A540 File Offset: 0x00088740
		[Token(Token = "0x1700320D")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6015157")]
			[Address(RVA = "0xD97860", Offset = "0xD96460", VA = "0x180D97860", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x06015158 RID: 86360 RVA: 0x0008A558 File Offset: 0x00088758
		[Token(Token = "0x1700320E")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6015158")]
			[Address(RVA = "0xD978C0", Offset = "0xD964C0", VA = "0x180D978C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015159 RID: 86361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015159")]
		[Address(RVA = "0xD973F0", Offset = "0xD95FF0", VA = "0x180D973F0", Slot = "30")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x0601515A RID: 86362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601515A")]
		[Address(RVA = "0xD97450", Offset = "0xD96050", VA = "0x180D97450", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601515B RID: 86363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601515B")]
		[Address(RVA = "0xD971D0", Offset = "0xD95DD0", VA = "0x180D971D0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601515C RID: 86364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601515C")]
		[Address(RVA = "0xD97300", Offset = "0xD95F00", VA = "0x180D97300", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0601515D RID: 86365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601515D")]
		[Address(RVA = "0xD97680", Offset = "0xD96280", VA = "0x180D97680", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601515E RID: 86366 RVA: 0x0008A570 File Offset: 0x00088770
		[Token(Token = "0x601515E")]
		[Address(RVA = "0xD97150", Offset = "0xD95D50", VA = "0x180D97150", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x0601515F RID: 86367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601515F")]
		[Address(RVA = "0xD976E0", Offset = "0xD962E0", VA = "0x180D976E0")]
		private void _OnBattleStart(object arg)
		{
		}

		// Token: 0x06015160 RID: 86368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015160")]
		[Address(RVA = "0xD977A0", Offset = "0xD963A0", VA = "0x180D977A0")]
		public UIEnemyDuelBattleStartState()
		{
		}

		// Token: 0x06015161 RID: 86369 RVA: 0x0008A588 File Offset: 0x00088788
		[Token(Token = "0x6015161")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06015162 RID: 86370 RVA: 0x0008A5A0 File Offset: 0x000887A0
		[Token(Token = "0x6015162")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06015163 RID: 86371 RVA: 0x0008A5B8 File Offset: 0x000887B8
		[Token(Token = "0x6015163")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015164 RID: 86372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015164")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06015165 RID: 86373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015165")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06015166 RID: 86374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015166")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06015167 RID: 86375 RVA: 0x0008A5D0 File Offset: 0x000887D0
		[Token(Token = "0x6015167")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x040191A1 RID: 102817
		[Token(Token = "0x40191A1")]
		[FieldOffset(Offset = "0x50")]
		private UIEnemyDuelBattleStartPanel m_panel;

		// Token: 0x040191A2 RID: 102818
		[Token(Token = "0x40191A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040191A3 RID: 102819
		[Token(Token = "0x40191A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x040191A4 RID: 102820
		[Token(Token = "0x40191A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x040191A5 RID: 102821
		[Token(Token = "0x40191A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x040191A6 RID: 102822
		[Token(Token = "0x40191A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x040191A7 RID: 102823
		[Token(Token = "0x40191A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040191A8 RID: 102824
		[Token(Token = "0x40191A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040191A9 RID: 102825
		[Token(Token = "0x40191A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040191AA RID: 102826
		[Token(Token = "0x40191AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040191AB RID: 102827
		[Token(Token = "0x40191AB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040191AC RID: 102828
		[Token(Token = "0x40191AC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBattleStart;

		// Token: 0x040191AD RID: 102829
		[Token(Token = "0x40191AD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
