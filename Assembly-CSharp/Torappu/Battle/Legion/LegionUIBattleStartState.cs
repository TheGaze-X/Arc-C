using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A17 RID: 10775
	[Token(Token = "0x2002A17")]
	public class LegionUIBattleStartState : UIStateNode
	{
		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x06011DF2 RID: 73202 RVA: 0x0006D410 File Offset: 0x0006B610
		[Token(Token = "0x1700274F")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6011DF2")]
			[Address(RVA = "0x9AE040", Offset = "0x9ACC40", VA = "0x1809AE040", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x06011DF3 RID: 73203 RVA: 0x0006D428 File Offset: 0x0006B628
		[Token(Token = "0x17002750")]
		public override bool enablePause
		{
			[Token(Token = "0x6011DF3")]
			[Address(RVA = "0x9ADF20", Offset = "0x9ACB20", VA = "0x1809ADF20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x06011DF4 RID: 73204 RVA: 0x0006D440 File Offset: 0x0006B640
		[Token(Token = "0x17002751")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6011DF4")]
			[Address(RVA = "0x9ADF80", Offset = "0x9ACB80", VA = "0x1809ADF80", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x06011DF5 RID: 73205 RVA: 0x0006D458 File Offset: 0x0006B658
		[Token(Token = "0x17002752")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6011DF5")]
			[Address(RVA = "0x9ADFE0", Offset = "0x9ACBE0", VA = "0x1809ADFE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011DF6 RID: 73206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DF6")]
		[Address(RVA = "0x9ADCB0", Offset = "0x9AC8B0", VA = "0x1809ADCB0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011DF7 RID: 73207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DF7")]
		[Address(RVA = "0x9AD9F0", Offset = "0x9AC5F0", VA = "0x1809AD9F0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06011DF8 RID: 73208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DF8")]
		[Address(RVA = "0x9ADE60", Offset = "0x9ACA60", VA = "0x1809ADE60", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011DF9 RID: 73209 RVA: 0x0006D470 File Offset: 0x0006B670
		[Token(Token = "0x6011DF9")]
		[Address(RVA = "0x9AD930", Offset = "0x9AC530", VA = "0x1809AD930", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06011DFA RID: 73210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DFA")]
		[Address(RVA = "0x9ADEC0", Offset = "0x9ACAC0", VA = "0x1809ADEC0")]
		public LegionUIBattleStartState()
		{
		}

		// Token: 0x06011DFB RID: 73211 RVA: 0x0006D488 File Offset: 0x0006B688
		[Token(Token = "0x6011DFB")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06011DFC RID: 73212 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
		[Token(Token = "0x6011DFC")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06011DFD RID: 73213 RVA: 0x0006D4B8 File Offset: 0x0006B6B8
		[Token(Token = "0x6011DFD")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011DFE RID: 73214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DFE")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06011DFF RID: 73215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DFF")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06011E00 RID: 73216 RVA: 0x0006D4D0 File Offset: 0x0006B6D0
		[Token(Token = "0x6011E00")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x040141E9 RID: 82409
		[Token(Token = "0x40141E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _parent;

		// Token: 0x040141EA RID: 82410
		[Token(Token = "0x40141EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBattleStartPanel _startPanel;

		// Token: 0x040141EB RID: 82411
		[Token(Token = "0x40141EB")]
		[FieldOffset(Offset = "0x30")]
		private GameModeFactory.LegionGameMode m_manager;

		// Token: 0x040141EC RID: 82412
		[Token(Token = "0x40141EC")]
		[FieldOffset(Offset = "0x38")]
		private UIBattleStartPanel m_panel;

		// Token: 0x040141ED RID: 82413
		[Token(Token = "0x40141ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040141EE RID: 82414
		[Token(Token = "0x40141EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x040141EF RID: 82415
		[Token(Token = "0x40141EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x040141F0 RID: 82416
		[Token(Token = "0x40141F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x040141F1 RID: 82417
		[Token(Token = "0x40141F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040141F2 RID: 82418
		[Token(Token = "0x40141F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040141F3 RID: 82419
		[Token(Token = "0x40141F3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040141F4 RID: 82420
		[Token(Token = "0x40141F4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040141F5 RID: 82421
		[Token(Token = "0x40141F5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
