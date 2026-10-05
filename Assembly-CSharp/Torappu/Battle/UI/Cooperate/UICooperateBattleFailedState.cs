using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033FD RID: 13309
	[Token(Token = "0x20033FD")]
	public class UICooperateBattleFailedState : CommonUIStateNode
	{
		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x06015400 RID: 87040 RVA: 0x0008ACD8 File Offset: 0x00088ED8
		[Token(Token = "0x1700325F")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6015400")]
			[Address(RVA = "0xDB1C50", Offset = "0xDB0850", VA = "0x180DB1C50", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x06015401 RID: 87041 RVA: 0x0008ACF0 File Offset: 0x00088EF0
		[Token(Token = "0x17003260")]
		public override bool enablePause
		{
			[Token(Token = "0x6015401")]
			[Address(RVA = "0xDB1AD0", Offset = "0xDB06D0", VA = "0x180DB1AD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x06015402 RID: 87042 RVA: 0x0008AD08 File Offset: 0x00088F08
		[Token(Token = "0x17003261")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6015402")]
			[Address(RVA = "0xDB1B90", Offset = "0xDB0790", VA = "0x180DB1B90", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x06015403 RID: 87043 RVA: 0x0008AD20 File Offset: 0x00088F20
		[Token(Token = "0x17003262")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6015403")]
			[Address(RVA = "0xDB1BF0", Offset = "0xDB07F0", VA = "0x180DB1BF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x06015404 RID: 87044 RVA: 0x0008AD38 File Offset: 0x00088F38
		[Token(Token = "0x17003263")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6015404")]
			[Address(RVA = "0xDB1B30", Offset = "0xDB0730", VA = "0x180DB1B30", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015405 RID: 87045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015405")]
		[Address(RVA = "0xDB1460", Offset = "0xDB0060", VA = "0x180DB1460", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06015406 RID: 87046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015406")]
		[Address(RVA = "0xDB10B0", Offset = "0xDAFCB0", VA = "0x180DB10B0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06015407 RID: 87047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015407")]
		[Address(RVA = "0xDB17D0", Offset = "0xDB03D0", VA = "0x180DB17D0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015408 RID: 87048 RVA: 0x0008AD50 File Offset: 0x00088F50
		[Token(Token = "0x6015408")]
		[Address(RVA = "0xDB1040", Offset = "0xDAFC40", VA = "0x180DB1040", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06015409 RID: 87049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015409")]
		[Address(RVA = "0xDB1880", Offset = "0xDB0480", VA = "0x180DB1880")]
		private void _ResetPerformPositionByCameraPos()
		{
		}

		// Token: 0x0601540A RID: 87050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601540A")]
		[Address(RVA = "0xDB1A70", Offset = "0xDB0670", VA = "0x180DB1A70")]
		public UICooperateBattleFailedState()
		{
		}

		// Token: 0x0601540C RID: 87052 RVA: 0x0008AD68 File Offset: 0x00088F68
		[Token(Token = "0x601540C")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0601540D RID: 87053 RVA: 0x0008AD80 File Offset: 0x00088F80
		[Token(Token = "0x601540D")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0601540E RID: 87054 RVA: 0x0008AD98 File Offset: 0x00088F98
		[Token(Token = "0x601540E")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601540F RID: 87055 RVA: 0x0008ADB0 File Offset: 0x00088FB0
		[Token(Token = "0x601540F")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06015410 RID: 87056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015410")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06015411 RID: 87057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015411")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06015412 RID: 87058 RVA: 0x0008ADC8 File Offset: 0x00088FC8
		[Token(Token = "0x6015412")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04019653 RID: 104019
		[Token(Token = "0x4019653")]
		[FieldOffset(Offset = "0x50")]
		private BattleFailedStateParam m_stateParam;

		// Token: 0x04019654 RID: 104020
		[Token(Token = "0x4019654")]
		[FieldOffset(Offset = "0x58")]
		private UIAnimationPerform m_panel;

		// Token: 0x04019655 RID: 104021
		[Token(Token = "0x4019655")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 m_offset;

		// Token: 0x04019656 RID: 104022
		[Token(Token = "0x4019656")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04019657 RID: 104023
		[Token(Token = "0x4019657")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04019658 RID: 104024
		[Token(Token = "0x4019658")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04019659 RID: 104025
		[Token(Token = "0x4019659")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0401965A RID: 104026
		[Token(Token = "0x401965A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0401965B RID: 104027
		[Token(Token = "0x401965B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401965C RID: 104028
		[Token(Token = "0x401965C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401965D RID: 104029
		[Token(Token = "0x401965D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401965E RID: 104030
		[Token(Token = "0x401965E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0401965F RID: 104031
		[Token(Token = "0x401965F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetPerformPositionByCameraPos;

		// Token: 0x04019660 RID: 104032
		[Token(Token = "0x4019660")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
