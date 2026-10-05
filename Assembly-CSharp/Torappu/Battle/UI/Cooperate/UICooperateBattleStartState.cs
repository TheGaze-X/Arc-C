using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033FE RID: 13310
	[Token(Token = "0x20033FE")]
	public class UICooperateBattleStartState : CommonUIStateNode, IFixedUpdateState
	{
		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x06015413 RID: 87059 RVA: 0x0008ADE0 File Offset: 0x00088FE0
		[Token(Token = "0x17003264")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6015413")]
			[Address(RVA = "0xDB4470", Offset = "0xDB3070", VA = "0x180DB4470", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x06015414 RID: 87060 RVA: 0x0008ADF8 File Offset: 0x00088FF8
		[Token(Token = "0x17003265")]
		public override bool enablePause
		{
			[Token(Token = "0x6015414")]
			[Address(RVA = "0xDB4350", Offset = "0xDB2F50", VA = "0x180DB4350", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x06015415 RID: 87061 RVA: 0x0008AE10 File Offset: 0x00089010
		[Token(Token = "0x17003266")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6015415")]
			[Address(RVA = "0xDB43B0", Offset = "0xDB2FB0", VA = "0x180DB43B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x06015416 RID: 87062 RVA: 0x0008AE28 File Offset: 0x00089028
		[Token(Token = "0x17003267")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6015416")]
			[Address(RVA = "0xDB4410", Offset = "0xDB3010", VA = "0x180DB4410", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015417 RID: 87063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015417")]
		[Address(RVA = "0xDB3E00", Offset = "0xDB2A00", VA = "0x180DB3E00", Slot = "30")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x06015418 RID: 87064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015418")]
		[Address(RVA = "0xDB3EC0", Offset = "0xDB2AC0", VA = "0x180DB3EC0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06015419 RID: 87065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015419")]
		[Address(RVA = "0xDB3BC0", Offset = "0xDB27C0", VA = "0x180DB3BC0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601541A RID: 87066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601541A")]
		[Address(RVA = "0xDB3D10", Offset = "0xDB2910", VA = "0x180DB3D10", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0601541B RID: 87067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601541B")]
		[Address(RVA = "0xDB40F0", Offset = "0xDB2CF0", VA = "0x180DB40F0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601541C RID: 87068 RVA: 0x0008AE40 File Offset: 0x00089040
		[Token(Token = "0x601541C")]
		[Address(RVA = "0xDB3AE0", Offset = "0xDB26E0", VA = "0x180DB3AE0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x0601541D RID: 87069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601541D")]
		[Address(RVA = "0xDB4170", Offset = "0xDB2D70", VA = "0x180DB4170")]
		private void _OnBattleStart(object arg)
		{
		}

		// Token: 0x0601541E RID: 87070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601541E")]
		[Address(RVA = "0xDB42F0", Offset = "0xDB2EF0", VA = "0x180DB42F0")]
		public UICooperateBattleStartState()
		{
		}

		// Token: 0x06015420 RID: 87072 RVA: 0x0008AE58 File Offset: 0x00089058
		[Token(Token = "0x6015420")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06015421 RID: 87073 RVA: 0x0008AE70 File Offset: 0x00089070
		[Token(Token = "0x6015421")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06015422 RID: 87074 RVA: 0x0008AE88 File Offset: 0x00089088
		[Token(Token = "0x6015422")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015423 RID: 87075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015423")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06015424 RID: 87076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015424")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06015425 RID: 87077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015425")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06015426 RID: 87078 RVA: 0x0008AEA0 File Offset: 0x000890A0
		[Token(Token = "0x6015426")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04019661 RID: 104033
		[Token(Token = "0x4019661")]
		[FieldOffset(Offset = "0x50")]
		private UICooperateBattleStartPanel m_panel;

		// Token: 0x04019662 RID: 104034
		[Token(Token = "0x4019662")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04019663 RID: 104035
		[Token(Token = "0x4019663")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04019664 RID: 104036
		[Token(Token = "0x4019664")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04019665 RID: 104037
		[Token(Token = "0x4019665")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04019666 RID: 104038
		[Token(Token = "0x4019666")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x04019667 RID: 104039
		[Token(Token = "0x4019667")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019668 RID: 104040
		[Token(Token = "0x4019668")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04019669 RID: 104041
		[Token(Token = "0x4019669")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401966A RID: 104042
		[Token(Token = "0x401966A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401966B RID: 104043
		[Token(Token = "0x401966B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0401966C RID: 104044
		[Token(Token = "0x401966C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBattleStart;

		// Token: 0x0401966D RID: 104045
		[Token(Token = "0x401966D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
