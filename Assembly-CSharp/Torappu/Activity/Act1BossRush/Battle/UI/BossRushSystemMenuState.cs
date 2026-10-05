using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D2 RID: 28882
	[Token(Token = "0x20070D2")]
	public class BossRushSystemMenuState : UIStateNode
	{
		// Token: 0x1700614B RID: 24907
		// (get) Token: 0x060290CC RID: 168140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700614B")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x60290CC")]
			[Address(RVA = "0x2478130", Offset = "0x2476D30", VA = "0x182478130")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700614C RID: 24908
		// (get) Token: 0x060290CD RID: 168141 RVA: 0x000D4478 File Offset: 0x000D2678
		[Token(Token = "0x1700614C")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60290CD")]
			[Address(RVA = "0x24782D0", Offset = "0x2476ED0", VA = "0x1824782D0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700614D RID: 24909
		// (get) Token: 0x060290CE RID: 168142 RVA: 0x000D4490 File Offset: 0x000D2690
		[Token(Token = "0x1700614D")]
		public override bool enablePause
		{
			[Token(Token = "0x60290CE")]
			[Address(RVA = "0x24781B0", Offset = "0x2476DB0", VA = "0x1824781B0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700614E RID: 24910
		// (get) Token: 0x060290CF RID: 168143 RVA: 0x000D44A8 File Offset: 0x000D26A8
		[Token(Token = "0x1700614E")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60290CF")]
			[Address(RVA = "0x2478210", Offset = "0x2476E10", VA = "0x182478210", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700614F RID: 24911
		// (get) Token: 0x060290D0 RID: 168144 RVA: 0x000D44C0 File Offset: 0x000D26C0
		[Token(Token = "0x1700614F")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60290D0")]
			[Address(RVA = "0x2478270", Offset = "0x2476E70", VA = "0x182478270", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060290D1 RID: 168145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D1")]
		[Address(RVA = "0x2477880", Offset = "0x2476480", VA = "0x182477880")]
		public void OnCancel()
		{
		}

		// Token: 0x060290D2 RID: 168146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D2")]
		[Address(RVA = "0x2477920", Offset = "0x2476520", VA = "0x182477920")]
		public void OnConfirmFinish()
		{
		}

		// Token: 0x060290D3 RID: 168147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D3")]
		[Address(RVA = "0x2477E30", Offset = "0x2476A30", VA = "0x182477E30", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060290D4 RID: 168148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D4")]
		[Address(RVA = "0x2477A10", Offset = "0x2476610", VA = "0x182477A10", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060290D5 RID: 168149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D5")]
		[Address(RVA = "0x2477CA0", Offset = "0x24768A0", VA = "0x182477CA0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060290D6 RID: 168150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D6")]
		[Address(RVA = "0x2477FD0", Offset = "0x2476BD0", VA = "0x182477FD0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060290D7 RID: 168151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D7")]
		[Address(RVA = "0x2478030", Offset = "0x2476C30", VA = "0x182478030")]
		private void _SwitchToFailedState(bool isGiveUp)
		{
		}

		// Token: 0x060290D8 RID: 168152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290D8")]
		[Address(RVA = "0x24780D0", Offset = "0x2476CD0", VA = "0x1824780D0")]
		public BossRushSystemMenuState()
		{
		}

		// Token: 0x060290D9 RID: 168153 RVA: 0x000D44D8 File Offset: 0x000D26D8
		[Token(Token = "0x60290D9")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060290DA RID: 168154 RVA: 0x000D44F0 File Offset: 0x000D26F0
		[Token(Token = "0x60290DA")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060290DB RID: 168155 RVA: 0x000D4508 File Offset: 0x000D2708
		[Token(Token = "0x60290DB")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060290DC RID: 168156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290DC")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060290DD RID: 168157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290DD")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060290DE RID: 168158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290DE")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0403A985 RID: 240005
		[Token(Token = "0x403A985")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossRushSystemMenuPanel _battleMenu;

		// Token: 0x0403A986 RID: 240006
		[Token(Token = "0x403A986")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isFromFailState;

		// Token: 0x0403A987 RID: 240007
		[Token(Token = "0x403A987")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x0403A988 RID: 240008
		[Token(Token = "0x403A988")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403A989 RID: 240009
		[Token(Token = "0x403A989")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403A98A RID: 240010
		[Token(Token = "0x403A98A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403A98B RID: 240011
		[Token(Token = "0x403A98B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403A98C RID: 240012
		[Token(Token = "0x403A98C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0403A98D RID: 240013
		[Token(Token = "0x403A98D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnConfirmFinish;

		// Token: 0x0403A98E RID: 240014
		[Token(Token = "0x403A98E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403A98F RID: 240015
		[Token(Token = "0x403A98F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A990 RID: 240016
		[Token(Token = "0x403A990")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403A991 RID: 240017
		[Token(Token = "0x403A991")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403A992 RID: 240018
		[Token(Token = "0x403A992")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SwitchToFailedState;

		// Token: 0x0403A993 RID: 240019
		[Token(Token = "0x403A993")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
