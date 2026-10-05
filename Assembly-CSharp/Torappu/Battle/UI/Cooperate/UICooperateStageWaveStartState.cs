using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003406 RID: 13318
	[Token(Token = "0x2003406")]
	public class UICooperateStageWaveStartState : CommonUIStateNode, IFixedUpdateState
	{
		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x06015478 RID: 87160 RVA: 0x0008B218 File Offset: 0x00089418
		[Token(Token = "0x17003277")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6015478")]
			[Address(RVA = "0xDBD8F0", Offset = "0xDBC4F0", VA = "0x180DBD8F0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x06015479 RID: 87161 RVA: 0x0008B230 File Offset: 0x00089430
		[Token(Token = "0x17003278")]
		public override bool enablePause
		{
			[Token(Token = "0x6015479")]
			[Address(RVA = "0xDBD770", Offset = "0xDBC370", VA = "0x180DBD770", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0601547A RID: 87162 RVA: 0x0008B248 File Offset: 0x00089448
		[Token(Token = "0x17003279")]
		public override bool enableShowRange
		{
			[Token(Token = "0x601547A")]
			[Address(RVA = "0xDBD830", Offset = "0xDBC430", VA = "0x180DBD830", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0601547B RID: 87163 RVA: 0x0008B260 File Offset: 0x00089460
		[Token(Token = "0x1700327A")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x601547B")]
			[Address(RVA = "0xDBD890", Offset = "0xDBC490", VA = "0x180DBD890", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0601547C RID: 87164 RVA: 0x0008B278 File Offset: 0x00089478
		[Token(Token = "0x1700327B")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x601547C")]
			[Address(RVA = "0xDBD7D0", Offset = "0xDBC3D0", VA = "0x180DBD7D0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601547D RID: 87165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601547D")]
		[Address(RVA = "0xDBD4C0", Offset = "0xDBC0C0", VA = "0x180DBD4C0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601547E RID: 87166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601547E")]
		[Address(RVA = "0xDBD330", Offset = "0xDBBF30", VA = "0x180DBD330", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601547F RID: 87167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601547F")]
		[Address(RVA = "0xDBD6B0", Offset = "0xDBC2B0", VA = "0x180DBD6B0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015480 RID: 87168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015480")]
		[Address(RVA = "0xDBD3D0", Offset = "0xDBBFD0", VA = "0x180DBD3D0", Slot = "30")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x06015481 RID: 87169 RVA: 0x0008B290 File Offset: 0x00089490
		[Token(Token = "0x6015481")]
		[Address(RVA = "0xDBD2B0", Offset = "0xDBBEB0", VA = "0x180DBD2B0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06015482 RID: 87170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015482")]
		[Address(RVA = "0xDBD710", Offset = "0xDBC310", VA = "0x180DBD710")]
		public UICooperateStageWaveStartState()
		{
		}

		// Token: 0x06015483 RID: 87171 RVA: 0x0008B2A8 File Offset: 0x000894A8
		[Token(Token = "0x6015483")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06015484 RID: 87172 RVA: 0x0008B2C0 File Offset: 0x000894C0
		[Token(Token = "0x6015484")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06015485 RID: 87173 RVA: 0x0008B2D8 File Offset: 0x000894D8
		[Token(Token = "0x6015485")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015486 RID: 87174 RVA: 0x0008B2F0 File Offset: 0x000894F0
		[Token(Token = "0x6015486")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06015487 RID: 87175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015487")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06015488 RID: 87176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015488")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06015489 RID: 87177 RVA: 0x0008B308 File Offset: 0x00089508
		[Token(Token = "0x6015489")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x040196BE RID: 104126
		[Token(Token = "0x40196BE")]
		[FieldOffset(Offset = "0x50")]
		private UICooperateStageWaveStartPanel m_panel;

		// Token: 0x040196BF RID: 104127
		[Token(Token = "0x40196BF")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_originLocalPosition;

		// Token: 0x040196C0 RID: 104128
		[Token(Token = "0x40196C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040196C1 RID: 104129
		[Token(Token = "0x40196C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x040196C2 RID: 104130
		[Token(Token = "0x40196C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x040196C3 RID: 104131
		[Token(Token = "0x40196C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x040196C4 RID: 104132
		[Token(Token = "0x40196C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x040196C5 RID: 104133
		[Token(Token = "0x40196C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040196C6 RID: 104134
		[Token(Token = "0x40196C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040196C7 RID: 104135
		[Token(Token = "0x40196C7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040196C8 RID: 104136
		[Token(Token = "0x40196C8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x040196C9 RID: 104137
		[Token(Token = "0x40196C9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040196CA RID: 104138
		[Token(Token = "0x40196CA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
