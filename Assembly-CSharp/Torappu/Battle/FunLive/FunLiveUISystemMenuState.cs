using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x02002693 RID: 9875
	[Token(Token = "0x2002693")]
	public class FunLiveUISystemMenuState : CommonUIStateNode
	{
		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x0601020C RID: 66060 RVA: 0x000625B0 File Offset: 0x000607B0
		[Token(Token = "0x17002324")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x601020C")]
			[Address(RVA = "0x7EBF30", Offset = "0x7EAB30", VA = "0x1807EBF30", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x0601020D RID: 66061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601020D")]
		[Address(RVA = "0x7EBE70", Offset = "0x7EAA70", VA = "0x1807EBE70", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601020E RID: 66062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601020E")]
		[Address(RVA = "0x7EBD40", Offset = "0x7EA940", VA = "0x1807EBD40", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601020F RID: 66063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601020F")]
		[Address(RVA = "0x7EBA50", Offset = "0x7EA650", VA = "0x1807EBA50", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06010210 RID: 66064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010210")]
		[Address(RVA = "0x7EBC60", Offset = "0x7EA860", VA = "0x1807EBC60", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06010211 RID: 66065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010211")]
		[Address(RVA = "0x7EB870", Offset = "0x7EA470", VA = "0x1807EB870")]
		public void CloseSystemMenuPanel()
		{
		}

		// Token: 0x06010212 RID: 66066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010212")]
		[Address(RVA = "0x7EB960", Offset = "0x7EA560", VA = "0x1807EB960")]
		public void FinishGameDirectly()
		{
		}

		// Token: 0x06010213 RID: 66067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010213")]
		[Address(RVA = "0x7EBED0", Offset = "0x7EAAD0", VA = "0x1807EBED0")]
		public FunLiveUISystemMenuState()
		{
		}

		// Token: 0x06010214 RID: 66068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010214")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06010215 RID: 66069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010215")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06010216 RID: 66070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010216")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04011F93 RID: 73619
		[Token(Token = "0x4011F93")]
		[FieldOffset(Offset = "0x50")]
		private FunLiveUIPlugin m_plugin;

		// Token: 0x04011F94 RID: 73620
		[Token(Token = "0x4011F94")]
		[FieldOffset(Offset = "0x58")]
		private FunLiveUIBattleMenuSystemPanel m_panel;

		// Token: 0x04011F95 RID: 73621
		[Token(Token = "0x4011F95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04011F96 RID: 73622
		[Token(Token = "0x4011F96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011F97 RID: 73623
		[Token(Token = "0x4011F97")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011F98 RID: 73624
		[Token(Token = "0x4011F98")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04011F99 RID: 73625
		[Token(Token = "0x4011F99")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04011F9A RID: 73626
		[Token(Token = "0x4011F9A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CloseSystemMenuPanel;

		// Token: 0x04011F9B RID: 73627
		[Token(Token = "0x4011F9B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FinishGameDirectly;

		// Token: 0x04011F9C RID: 73628
		[Token(Token = "0x4011F9C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
