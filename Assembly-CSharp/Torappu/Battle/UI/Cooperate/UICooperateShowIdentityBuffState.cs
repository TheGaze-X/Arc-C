using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003404 RID: 13316
	[Token(Token = "0x2003404")]
	public class UICooperateShowIdentityBuffState : UIStateNode, IFixedUpdateState
	{
		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0601545D RID: 87133 RVA: 0x0008B110 File Offset: 0x00089310
		[Token(Token = "0x17003272")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x601545D")]
			[Address(RVA = "0xDBD220", Offset = "0xDBBE20", VA = "0x180DBD220", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0601545E RID: 87134 RVA: 0x0008B128 File Offset: 0x00089328
		[Token(Token = "0x17003273")]
		public override bool enablePause
		{
			[Token(Token = "0x601545E")]
			[Address(RVA = "0xDBD0A0", Offset = "0xDBBCA0", VA = "0x180DBD0A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0601545F RID: 87135 RVA: 0x0008B140 File Offset: 0x00089340
		[Token(Token = "0x17003274")]
		public override bool enableShowRange
		{
			[Token(Token = "0x601545F")]
			[Address(RVA = "0xDBD160", Offset = "0xDBBD60", VA = "0x180DBD160", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x06015460 RID: 87136 RVA: 0x0008B158 File Offset: 0x00089358
		[Token(Token = "0x17003275")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6015460")]
			[Address(RVA = "0xDBD1C0", Offset = "0xDBBDC0", VA = "0x180DBD1C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x06015461 RID: 87137 RVA: 0x0008B170 File Offset: 0x00089370
		[Token(Token = "0x17003276")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6015461")]
			[Address(RVA = "0xDBD100", Offset = "0xDBBD00", VA = "0x180DBD100", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015462 RID: 87138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015462")]
		[Address(RVA = "0xDBC300", Offset = "0xDBAF00", VA = "0x180DBC300", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06015463 RID: 87139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015463")]
		[Address(RVA = "0xDBBBD0", Offset = "0xDBA7D0", VA = "0x180DBBBD0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06015464 RID: 87140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015464")]
		[Address(RVA = "0xDBC100", Offset = "0xDBAD00", VA = "0x180DBC100", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06015465 RID: 87141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015465")]
		[Address(RVA = "0xDBC180", Offset = "0xDBAD80", VA = "0x180DBC180", Slot = "29")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x06015466 RID: 87142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015466")]
		[Address(RVA = "0xDBC7A0", Offset = "0xDBB3A0", VA = "0x180DBC7A0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015467 RID: 87143 RVA: 0x0008B188 File Offset: 0x00089388
		[Token(Token = "0x6015467")]
		[Address(RVA = "0xDBBB10", Offset = "0xDBA710", VA = "0x180DBBB10", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06015468 RID: 87144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015468")]
		[Address(RVA = "0xDBC800", Offset = "0xDBB400", VA = "0x180DBC800")]
		private void _CheckFirstWaveState(FP deltaTime)
		{
		}

		// Token: 0x06015469 RID: 87145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015469")]
		[Address(RVA = "0xDBC910", Offset = "0xDBB510", VA = "0x180DBC910")]
		private void _InitIdentityPanel()
		{
		}

		// Token: 0x0601546A RID: 87146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601546A")]
		[Address(RVA = "0xDBCD70", Offset = "0xDBB970", VA = "0x180DBCD70")]
		private void _ProcessPanelRenderData(ActMultiV3Data actData, GameModeFactory.CooperateGameMode.CooperateIdentityInfo identityInfo, UICooperateShowIdentityBuffPanel.IdentityRenderData selfRenderData, UICooperateShowIdentityBuffPanel.IdentityRenderData oppositeRenderData)
		{
		}

		// Token: 0x0601546B RID: 87147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601546B")]
		[Address(RVA = "0xDBCB90", Offset = "0xDBB790", VA = "0x180DBCB90")]
		private string _ProcessGameModeColor(ActMultiV3Data actData, GameModeFactory.CooperateGameMode.CooperateIdentityInfo identityInfo)
		{
			return null;
		}

		// Token: 0x0601546C RID: 87148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601546C")]
		[Address(RVA = "0xDBCFF0", Offset = "0xDBBBF0", VA = "0x180DBCFF0")]
		public UICooperateShowIdentityBuffState()
		{
		}

		// Token: 0x0601546D RID: 87149 RVA: 0x0008B1A0 File Offset: 0x000893A0
		[Token(Token = "0x601546D")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0601546E RID: 87150 RVA: 0x0008B1B8 File Offset: 0x000893B8
		[Token(Token = "0x601546E")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0601546F RID: 87151 RVA: 0x0008B1D0 File Offset: 0x000893D0
		[Token(Token = "0x601546F")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015470 RID: 87152 RVA: 0x0008B1E8 File Offset: 0x000893E8
		[Token(Token = "0x6015470")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06015471 RID: 87153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015471")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06015472 RID: 87154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015472")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06015473 RID: 87155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015473")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06015474 RID: 87156 RVA: 0x0008B200 File Offset: 0x00089400
		[Token(Token = "0x6015474")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x040196A4 RID: 104100
		[Token(Token = "0x40196A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICooperateStageWaveStartPanel _waveStartPanel;

		// Token: 0x040196A5 RID: 104101
		[Token(Token = "0x40196A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICooperateShowIdentityBuffPanel _identityBuffPanel;

		// Token: 0x040196A6 RID: 104102
		[Token(Token = "0x40196A6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _firstWaveStateWaitTime;

		// Token: 0x040196A7 RID: 104103
		[Token(Token = "0x40196A7")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_originLocalPosition;

		// Token: 0x040196A8 RID: 104104
		[Token(Token = "0x40196A8")]
		[FieldOffset(Offset = "0x40")]
		private UICooperateShowIdentityBuffPanel m_panel;

		// Token: 0x040196A9 RID: 104105
		[Token(Token = "0x40196A9")]
		[FieldOffset(Offset = "0x48")]
		private UICooperateStageWaveStartPanel m_wavePanel;

		// Token: 0x040196AA RID: 104106
		[Token(Token = "0x40196AA")]
		[FieldOffset(Offset = "0x50")]
		private CooperateUIPlugin m_plugin;

		// Token: 0x040196AB RID: 104107
		[Token(Token = "0x40196AB")]
		[FieldOffset(Offset = "0x58")]
		private PeriodicTimer m_firstWaveStateTimer;

		// Token: 0x040196AC RID: 104108
		[Token(Token = "0x40196AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040196AD RID: 104109
		[Token(Token = "0x40196AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x040196AE RID: 104110
		[Token(Token = "0x40196AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x040196AF RID: 104111
		[Token(Token = "0x40196AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x040196B0 RID: 104112
		[Token(Token = "0x40196B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x040196B1 RID: 104113
		[Token(Token = "0x40196B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040196B2 RID: 104114
		[Token(Token = "0x40196B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040196B3 RID: 104115
		[Token(Token = "0x40196B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040196B4 RID: 104116
		[Token(Token = "0x40196B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x040196B5 RID: 104117
		[Token(Token = "0x40196B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040196B6 RID: 104118
		[Token(Token = "0x40196B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040196B7 RID: 104119
		[Token(Token = "0x40196B7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckFirstWaveState;

		// Token: 0x040196B8 RID: 104120
		[Token(Token = "0x40196B8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIdentityPanel;

		// Token: 0x040196B9 RID: 104121
		[Token(Token = "0x40196B9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ProcessPanelRenderData;

		// Token: 0x040196BA RID: 104122
		[Token(Token = "0x40196BA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ProcessGameModeColor;

		// Token: 0x040196BB RID: 104123
		[Token(Token = "0x40196BB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
