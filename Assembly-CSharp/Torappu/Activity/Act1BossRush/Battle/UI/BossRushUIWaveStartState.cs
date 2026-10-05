using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D3 RID: 28883
	[Token(Token = "0x20070D3")]
	public class BossRushUIWaveStartState : UIStateNode
	{
		// Token: 0x17006150 RID: 24912
		// (get) Token: 0x060290DF RID: 168159 RVA: 0x000D4520 File Offset: 0x000D2720
		[Token(Token = "0x17006150")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60290DF")]
			[Address(RVA = "0x24796C0", Offset = "0x24782C0", VA = "0x1824796C0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17006151 RID: 24913
		// (get) Token: 0x060290E0 RID: 168160 RVA: 0x000D4538 File Offset: 0x000D2738
		[Token(Token = "0x17006151")]
		public override bool enablePause
		{
			[Token(Token = "0x60290E0")]
			[Address(RVA = "0x2479540", Offset = "0x2478140", VA = "0x182479540", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006152 RID: 24914
		// (get) Token: 0x060290E1 RID: 168161 RVA: 0x000D4550 File Offset: 0x000D2750
		[Token(Token = "0x17006152")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60290E1")]
			[Address(RVA = "0x2479600", Offset = "0x2478200", VA = "0x182479600", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006153 RID: 24915
		// (get) Token: 0x060290E2 RID: 168162 RVA: 0x000D4568 File Offset: 0x000D2768
		[Token(Token = "0x17006153")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60290E2")]
			[Address(RVA = "0x2479660", Offset = "0x2478260", VA = "0x182479660", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006154 RID: 24916
		// (get) Token: 0x060290E3 RID: 168163 RVA: 0x000D4580 File Offset: 0x000D2780
		[Token(Token = "0x17006154")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x60290E3")]
			[Address(RVA = "0x24795A0", Offset = "0x24781A0", VA = "0x1824795A0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060290E4 RID: 168164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290E4")]
		[Address(RVA = "0x2479000", Offset = "0x2477C00", VA = "0x182479000", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060290E5 RID: 168165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290E5")]
		[Address(RVA = "0x2478B80", Offset = "0x2477780", VA = "0x182478B80", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060290E6 RID: 168166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290E6")]
		[Address(RVA = "0x24792F0", Offset = "0x2477EF0", VA = "0x1824792F0")]
		private void _ResetPerformPositionByCameraPos()
		{
		}

		// Token: 0x060290E7 RID: 168167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290E7")]
		[Address(RVA = "0x2479290", Offset = "0x2477E90", VA = "0x182479290", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060290E8 RID: 168168 RVA: 0x000D4598 File Offset: 0x000D2798
		[Token(Token = "0x60290E8")]
		[Address(RVA = "0x2478B10", Offset = "0x2477710", VA = "0x182478B10", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x060290E9 RID: 168169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290E9")]
		[Address(RVA = "0x24794E0", Offset = "0x24780E0", VA = "0x1824794E0")]
		public BossRushUIWaveStartState()
		{
		}

		// Token: 0x060290EA RID: 168170 RVA: 0x000D45B0 File Offset: 0x000D27B0
		[Token(Token = "0x60290EA")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060290EB RID: 168171 RVA: 0x000D45C8 File Offset: 0x000D27C8
		[Token(Token = "0x60290EB")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060290EC RID: 168172 RVA: 0x000D45E0 File Offset: 0x000D27E0
		[Token(Token = "0x60290EC")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060290ED RID: 168173 RVA: 0x000D45F8 File Offset: 0x000D27F8
		[Token(Token = "0x60290ED")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x060290EE RID: 168174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290EE")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060290EF RID: 168175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290EF")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060290F0 RID: 168176 RVA: 0x000D4610 File Offset: 0x000D2810
		[Token(Token = "0x60290F0")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403A994 RID: 240020
		[Token(Token = "0x403A994")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossRushWaveStartPanel _perform;

		// Token: 0x0403A995 RID: 240021
		[Token(Token = "0x403A995")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_offset;

		// Token: 0x0403A996 RID: 240022
		[Token(Token = "0x403A996")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_originLocalPosition;

		// Token: 0x0403A997 RID: 240023
		[Token(Token = "0x403A997")]
		[FieldOffset(Offset = "0x40")]
		private BossRushWaveStartPanel m_panel;

		// Token: 0x0403A998 RID: 240024
		[Token(Token = "0x403A998")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403A999 RID: 240025
		[Token(Token = "0x403A999")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403A99A RID: 240026
		[Token(Token = "0x403A99A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403A99B RID: 240027
		[Token(Token = "0x403A99B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403A99C RID: 240028
		[Token(Token = "0x403A99C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0403A99D RID: 240029
		[Token(Token = "0x403A99D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403A99E RID: 240030
		[Token(Token = "0x403A99E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A99F RID: 240031
		[Token(Token = "0x403A99F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetPerformPositionByCameraPos;

		// Token: 0x0403A9A0 RID: 240032
		[Token(Token = "0x403A9A0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403A9A1 RID: 240033
		[Token(Token = "0x403A9A1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403A9A2 RID: 240034
		[Token(Token = "0x403A9A2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
