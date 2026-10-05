using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D1 RID: 28881
	[Token(Token = "0x20070D1")]
	public class BossRushMoveCameraState : UIStateNode
	{
		// Token: 0x17006146 RID: 24902
		// (get) Token: 0x060290BB RID: 168123 RVA: 0x000D4370 File Offset: 0x000D2570
		[Token(Token = "0x17006146")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60290BB")]
			[Address(RVA = "0x2476AF0", Offset = "0x24756F0", VA = "0x182476AF0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17006147 RID: 24903
		// (get) Token: 0x060290BC RID: 168124 RVA: 0x000D4388 File Offset: 0x000D2588
		[Token(Token = "0x17006147")]
		public override bool enablePause
		{
			[Token(Token = "0x60290BC")]
			[Address(RVA = "0x2476970", Offset = "0x2475570", VA = "0x182476970", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006148 RID: 24904
		// (get) Token: 0x060290BD RID: 168125 RVA: 0x000D43A0 File Offset: 0x000D25A0
		[Token(Token = "0x17006148")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60290BD")]
			[Address(RVA = "0x2476A30", Offset = "0x2475630", VA = "0x182476A30", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006149 RID: 24905
		// (get) Token: 0x060290BE RID: 168126 RVA: 0x000D43B8 File Offset: 0x000D25B8
		[Token(Token = "0x17006149")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60290BE")]
			[Address(RVA = "0x2476A90", Offset = "0x2475690", VA = "0x182476A90", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700614A RID: 24906
		// (get) Token: 0x060290BF RID: 168127 RVA: 0x000D43D0 File Offset: 0x000D25D0
		[Token(Token = "0x1700614A")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x60290BF")]
			[Address(RVA = "0x24769D0", Offset = "0x24755D0", VA = "0x1824769D0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060290C0 RID: 168128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290C0")]
		[Address(RVA = "0x24768B0", Offset = "0x24754B0", VA = "0x1824768B0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060290C1 RID: 168129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290C1")]
		[Address(RVA = "0x24766D0", Offset = "0x24752D0", VA = "0x1824766D0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060290C2 RID: 168130 RVA: 0x000D43E8 File Offset: 0x000D25E8
		[Token(Token = "0x60290C2")]
		[Address(RVA = "0x2476630", Offset = "0x2475230", VA = "0x182476630", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x060290C3 RID: 168131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290C3")]
		[Address(RVA = "0x2476800", Offset = "0x2475400", VA = "0x182476800", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060290C4 RID: 168132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290C4")]
		[Address(RVA = "0x2476910", Offset = "0x2475510", VA = "0x182476910")]
		public BossRushMoveCameraState()
		{
		}

		// Token: 0x060290C5 RID: 168133 RVA: 0x000D4400 File Offset: 0x000D2600
		[Token(Token = "0x60290C5")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060290C6 RID: 168134 RVA: 0x000D4418 File Offset: 0x000D2618
		[Token(Token = "0x60290C6")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060290C7 RID: 168135 RVA: 0x000D4430 File Offset: 0x000D2630
		[Token(Token = "0x60290C7")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060290C8 RID: 168136 RVA: 0x000D4448 File Offset: 0x000D2648
		[Token(Token = "0x60290C8")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x060290C9 RID: 168137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290C9")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060290CA RID: 168138 RVA: 0x000D4460 File Offset: 0x000D2660
		[Token(Token = "0x60290CA")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x060290CB RID: 168139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290CB")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0403A97B RID: 239995
		[Token(Token = "0x403A97B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403A97C RID: 239996
		[Token(Token = "0x403A97C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403A97D RID: 239997
		[Token(Token = "0x403A97D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403A97E RID: 239998
		[Token(Token = "0x403A97E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403A97F RID: 239999
		[Token(Token = "0x403A97F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0403A980 RID: 240000
		[Token(Token = "0x403A980")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403A981 RID: 240001
		[Token(Token = "0x403A981")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A982 RID: 240002
		[Token(Token = "0x403A982")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403A983 RID: 240003
		[Token(Token = "0x403A983")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403A984 RID: 240004
		[Token(Token = "0x403A984")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
