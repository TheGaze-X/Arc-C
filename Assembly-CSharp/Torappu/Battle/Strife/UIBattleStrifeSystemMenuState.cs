using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Strife
{
	// Token: 0x02002685 RID: 9861
	[Token(Token = "0x2002685")]
	public class UIBattleStrifeSystemMenuState : UIStateNode
	{
		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x060101AB RID: 65963 RVA: 0x00062430 File Offset: 0x00060630
		[Token(Token = "0x1700231B")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60101AB")]
			[Address(RVA = "0x7D4990", Offset = "0x7D3590", VA = "0x1807D4990", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x060101AC RID: 65964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101AC")]
		[Address(RVA = "0x7D48D0", Offset = "0x7D34D0", VA = "0x1807D48D0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060101AD RID: 65965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101AD")]
		[Address(RVA = "0x7D4700", Offset = "0x7D3300", VA = "0x1807D4700", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060101AE RID: 65966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101AE")]
		[Address(RVA = "0x7D41E0", Offset = "0x7D2DE0", VA = "0x1807D41E0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060101AF RID: 65967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101AF")]
		[Address(RVA = "0x7D45C0", Offset = "0x7D31C0", VA = "0x1807D45C0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060101B0 RID: 65968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B0")]
		[Address(RVA = "0x7D3F90", Offset = "0x7D2B90", VA = "0x1807D3F90")]
		public void CloseSystemMenuPanel()
		{
		}

		// Token: 0x060101B1 RID: 65969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B1")]
		[Address(RVA = "0x7D4090", Offset = "0x7D2C90", VA = "0x1807D4090")]
		public void FinishGameDirectly()
		{
		}

		// Token: 0x060101B2 RID: 65970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B2")]
		[Address(RVA = "0x7D4930", Offset = "0x7D3530", VA = "0x1807D4930")]
		public UIBattleStrifeSystemMenuState()
		{
		}

		// Token: 0x060101B3 RID: 65971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B3")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060101B4 RID: 65972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B4")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060101B5 RID: 65973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B5")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04011EF3 RID: 73459
		[Token(Token = "0x4011EF3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _parent;

		// Token: 0x04011EF4 RID: 73460
		[Token(Token = "0x4011EF4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _statePanel;

		// Token: 0x04011EF5 RID: 73461
		[Token(Token = "0x4011EF5")]
		[FieldOffset(Offset = "0x30")]
		private StrifeUIPlugin m_plugin;

		// Token: 0x04011EF6 RID: 73462
		[Token(Token = "0x4011EF6")]
		[FieldOffset(Offset = "0x38")]
		private UIBattleStrifeMenuSystemPanel m_panel;

		// Token: 0x04011EF7 RID: 73463
		[Token(Token = "0x4011EF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04011EF8 RID: 73464
		[Token(Token = "0x4011EF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011EF9 RID: 73465
		[Token(Token = "0x4011EF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011EFA RID: 73466
		[Token(Token = "0x4011EFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04011EFB RID: 73467
		[Token(Token = "0x4011EFB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04011EFC RID: 73468
		[Token(Token = "0x4011EFC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CloseSystemMenuPanel;

		// Token: 0x04011EFD RID: 73469
		[Token(Token = "0x4011EFD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FinishGameDirectly;

		// Token: 0x04011EFE RID: 73470
		[Token(Token = "0x4011EFE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
