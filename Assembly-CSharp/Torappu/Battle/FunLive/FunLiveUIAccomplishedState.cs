using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x02002691 RID: 9873
	[Token(Token = "0x2002691")]
	public class FunLiveUIAccomplishedState : UIStateNode
	{
		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x060101F3 RID: 66035 RVA: 0x000624C0 File Offset: 0x000606C0
		[Token(Token = "0x1700231F")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60101F3")]
			[Address(RVA = "0x7E95B0", Offset = "0x7E81B0", VA = "0x1807E95B0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x060101F4 RID: 66036 RVA: 0x000624D8 File Offset: 0x000606D8
		[Token(Token = "0x17002320")]
		public override bool enablePause
		{
			[Token(Token = "0x60101F4")]
			[Address(RVA = "0x7E9490", Offset = "0x7E8090", VA = "0x1807E9490", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x060101F5 RID: 66037 RVA: 0x000624F0 File Offset: 0x000606F0
		[Token(Token = "0x17002321")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60101F5")]
			[Address(RVA = "0x7E94F0", Offset = "0x7E80F0", VA = "0x1807E94F0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060101F6 RID: 66038 RVA: 0x00062508 File Offset: 0x00060708
		[Token(Token = "0x17002322")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60101F6")]
			[Address(RVA = "0x7E9550", Offset = "0x7E8150", VA = "0x1807E9550", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060101F7 RID: 66039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101F7")]
		[Address(RVA = "0x7E9280", Offset = "0x7E7E80", VA = "0x1807E9280", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060101F8 RID: 66040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101F8")]
		[Address(RVA = "0x7E9140", Offset = "0x7E7D40", VA = "0x1807E9140", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060101F9 RID: 66041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101F9")]
		[Address(RVA = "0x7E9340", Offset = "0x7E7F40", VA = "0x1807E9340", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060101FA RID: 66042 RVA: 0x00062520 File Offset: 0x00060720
		[Token(Token = "0x60101FA")]
		[Address(RVA = "0x7E90D0", Offset = "0x7E7CD0", VA = "0x1807E90D0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x060101FB RID: 66043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101FB")]
		[Address(RVA = "0x7E9430", Offset = "0x7E8030", VA = "0x1807E9430")]
		public FunLiveUIAccomplishedState()
		{
		}

		// Token: 0x060101FC RID: 66044 RVA: 0x00062538 File Offset: 0x00060738
		[Token(Token = "0x60101FC")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060101FD RID: 66045 RVA: 0x00062550 File Offset: 0x00060750
		[Token(Token = "0x60101FD")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060101FE RID: 66046 RVA: 0x00062568 File Offset: 0x00060768
		[Token(Token = "0x60101FE")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060101FF RID: 66047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101FF")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06010200 RID: 66048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010200")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06010201 RID: 66049 RVA: 0x00062580 File Offset: 0x00060780
		[Token(Token = "0x6010201")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04011F7E RID: 73598
		[Token(Token = "0x4011F7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animation _showAnimation;

		// Token: 0x04011F7F RID: 73599
		[Token(Token = "0x4011F7F")]
		[FieldOffset(Offset = "0x28")]
		private BattleFailedStateParam m_stateParam;

		// Token: 0x04011F80 RID: 73600
		[Token(Token = "0x4011F80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04011F81 RID: 73601
		[Token(Token = "0x4011F81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04011F82 RID: 73602
		[Token(Token = "0x4011F82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04011F83 RID: 73603
		[Token(Token = "0x4011F83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04011F84 RID: 73604
		[Token(Token = "0x4011F84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011F85 RID: 73605
		[Token(Token = "0x4011F85")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04011F86 RID: 73606
		[Token(Token = "0x4011F86")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011F87 RID: 73607
		[Token(Token = "0x4011F87")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04011F88 RID: 73608
		[Token(Token = "0x4011F88")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
