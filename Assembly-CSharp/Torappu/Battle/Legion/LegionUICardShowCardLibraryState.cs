using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A1B RID: 10779
	[Token(Token = "0x2002A1B")]
	public class LegionUICardShowCardLibraryState : CommonUIStateNode
	{
		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x06011E30 RID: 73264 RVA: 0x0006D6C8 File Offset: 0x0006B8C8
		[Token(Token = "0x1700275D")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6011E30")]
			[Address(RVA = "0x9CA6B0", Offset = "0x9C92B0", VA = "0x1809CA6B0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x06011E31 RID: 73265 RVA: 0x0006D6E0 File Offset: 0x0006B8E0
		[Token(Token = "0x1700275E")]
		public override bool enablePause
		{
			[Token(Token = "0x6011E31")]
			[Address(RVA = "0x9CA590", Offset = "0x9C9190", VA = "0x1809CA590", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x06011E32 RID: 73266 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
		[Token(Token = "0x1700275F")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6011E32")]
			[Address(RVA = "0x9CA5F0", Offset = "0x9C91F0", VA = "0x1809CA5F0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x06011E33 RID: 73267 RVA: 0x0006D710 File Offset: 0x0006B910
		[Token(Token = "0x17002760")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6011E33")]
			[Address(RVA = "0x9CA650", Offset = "0x9C9250", VA = "0x1809CA650", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011E34 RID: 73268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E34")]
		[Address(RVA = "0x9CA3A0", Offset = "0x9C8FA0", VA = "0x1809CA3A0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011E35 RID: 73269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E35")]
		[Address(RVA = "0x9CA030", Offset = "0x9C8C30", VA = "0x1809CA030", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06011E36 RID: 73270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E36")]
		[Address(RVA = "0x9CA2C0", Offset = "0x9C8EC0", VA = "0x1809CA2C0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06011E37 RID: 73271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E37")]
		[Address(RVA = "0x9CA4D0", Offset = "0x9C90D0", VA = "0x1809CA4D0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011E38 RID: 73272 RVA: 0x0006D728 File Offset: 0x0006B928
		[Token(Token = "0x6011E38")]
		[Address(RVA = "0x9C9DF0", Offset = "0x9C89F0", VA = "0x1809C9DF0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06011E39 RID: 73273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E39")]
		[Address(RVA = "0x9C9EB0", Offset = "0x9C8AB0", VA = "0x1809C9EB0")]
		public void CloseUsedAndPendingPanel()
		{
		}

		// Token: 0x06011E3A RID: 73274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E3A")]
		[Address(RVA = "0x9CA530", Offset = "0x9C9130", VA = "0x1809CA530")]
		public LegionUICardShowCardLibraryState()
		{
		}

		// Token: 0x06011E3B RID: 73275 RVA: 0x0006D740 File Offset: 0x0006B940
		[Token(Token = "0x6011E3B")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06011E3C RID: 73276 RVA: 0x0006D758 File Offset: 0x0006B958
		[Token(Token = "0x6011E3C")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06011E3D RID: 73277 RVA: 0x0006D770 File Offset: 0x0006B970
		[Token(Token = "0x6011E3D")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011E3E RID: 73278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E3E")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06011E3F RID: 73279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E3F")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06011E40 RID: 73280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E40")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06011E41 RID: 73281 RVA: 0x0006D788 File Offset: 0x0006B988
		[Token(Token = "0x6011E41")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0401421E RID: 82462
		[Token(Token = "0x401421E")]
		[FieldOffset(Offset = "0x50")]
		private BattleLegionCardLibraryParam m_libraryData;

		// Token: 0x0401421F RID: 82463
		[Token(Token = "0x401421F")]
		[FieldOffset(Offset = "0x60")]
		private LegionUIPlugin m_plugin;

		// Token: 0x04014220 RID: 82464
		[Token(Token = "0x4014220")]
		[FieldOffset(Offset = "0x68")]
		private UIBattleLegionShowCardLibraryPanel m_panel;

		// Token: 0x04014221 RID: 82465
		[Token(Token = "0x4014221")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04014222 RID: 82466
		[Token(Token = "0x4014222")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04014223 RID: 82467
		[Token(Token = "0x4014223")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04014224 RID: 82468
		[Token(Token = "0x4014224")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04014225 RID: 82469
		[Token(Token = "0x4014225")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04014226 RID: 82470
		[Token(Token = "0x4014226")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04014227 RID: 82471
		[Token(Token = "0x4014227")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04014228 RID: 82472
		[Token(Token = "0x4014228")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014229 RID: 82473
		[Token(Token = "0x4014229")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0401422A RID: 82474
		[Token(Token = "0x401422A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CloseUsedAndPendingPanel;

		// Token: 0x0401422B RID: 82475
		[Token(Token = "0x401422B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
