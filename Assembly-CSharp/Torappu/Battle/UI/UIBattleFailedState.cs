using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200331A RID: 13082
	[Token(Token = "0x200331A")]
	public class UIBattleFailedState : UIStateNode
	{
		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x06014CA4 RID: 85156 RVA: 0x00088710 File Offset: 0x00086910
		[Token(Token = "0x1700313A")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014CA4")]
			[Address(RVA = "0xD39300", Offset = "0xD37F00", VA = "0x180D39300", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06014CA5 RID: 85157 RVA: 0x00088728 File Offset: 0x00086928
		[Token(Token = "0x1700313B")]
		public override bool enablePause
		{
			[Token(Token = "0x6014CA5")]
			[Address(RVA = "0xD391E0", Offset = "0xD37DE0", VA = "0x180D391E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x06014CA6 RID: 85158 RVA: 0x00088740 File Offset: 0x00086940
		[Token(Token = "0x1700313C")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014CA6")]
			[Address(RVA = "0xD39240", Offset = "0xD37E40", VA = "0x180D39240", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x06014CA7 RID: 85159 RVA: 0x00088758 File Offset: 0x00086958
		[Token(Token = "0x1700313D")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014CA7")]
			[Address(RVA = "0xD392A0", Offset = "0xD37EA0", VA = "0x180D392A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014CA8 RID: 85160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CA8")]
		[Address(RVA = "0xD38EF0", Offset = "0xD37AF0", VA = "0x180D38EF0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014CA9 RID: 85161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CA9")]
		[Address(RVA = "0xD38A60", Offset = "0xD37660", VA = "0x180D38A60", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014CAA RID: 85162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CAA")]
		[Address(RVA = "0xD38D20", Offset = "0xD37920", VA = "0x180D38D20", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014CAB RID: 85163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CAB")]
		[Address(RVA = "0xD39120", Offset = "0xD37D20", VA = "0x180D39120", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014CAC RID: 85164 RVA: 0x00088770 File Offset: 0x00086970
		[Token(Token = "0x6014CAC")]
		[Address(RVA = "0xD389F0", Offset = "0xD375F0", VA = "0x180D389F0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06014CAD RID: 85165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CAD")]
		[Address(RVA = "0xD38E60", Offset = "0xD37A60", VA = "0x180D38E60")]
		public void OnFailPanelClose()
		{
		}

		// Token: 0x06014CAE RID: 85166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CAE")]
		[Address(RVA = "0xD39180", Offset = "0xD37D80", VA = "0x180D39180")]
		public UIBattleFailedState()
		{
		}

		// Token: 0x06014CAF RID: 85167 RVA: 0x00088788 File Offset: 0x00086988
		[Token(Token = "0x6014CAF")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014CB0 RID: 85168 RVA: 0x000887A0 File Offset: 0x000869A0
		[Token(Token = "0x6014CB0")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014CB1 RID: 85169 RVA: 0x000887B8 File Offset: 0x000869B8
		[Token(Token = "0x6014CB1")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014CB2 RID: 85170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CB2")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014CB3 RID: 85171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CB3")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014CB4 RID: 85172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CB4")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06014CB5 RID: 85173 RVA: 0x000887D0 File Offset: 0x000869D0
		[Token(Token = "0x6014CB5")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04018BBB RID: 101307
		[Token(Token = "0x4018BBB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBattleFailedPanel _failedPanel;

		// Token: 0x04018BBC RID: 101308
		[Token(Token = "0x4018BBC")]
		[FieldOffset(Offset = "0x28")]
		private BattleFailedStateParam m_stateParam;

		// Token: 0x04018BBD RID: 101309
		[Token(Token = "0x4018BBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018BBE RID: 101310
		[Token(Token = "0x4018BBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018BBF RID: 101311
		[Token(Token = "0x4018BBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018BC0 RID: 101312
		[Token(Token = "0x4018BC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018BC1 RID: 101313
		[Token(Token = "0x4018BC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018BC2 RID: 101314
		[Token(Token = "0x4018BC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018BC3 RID: 101315
		[Token(Token = "0x4018BC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018BC4 RID: 101316
		[Token(Token = "0x4018BC4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018BC5 RID: 101317
		[Token(Token = "0x4018BC5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04018BC6 RID: 101318
		[Token(Token = "0x4018BC6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFailPanelClose;

		// Token: 0x04018BC7 RID: 101319
		[Token(Token = "0x4018BC7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
