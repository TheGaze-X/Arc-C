using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A1A RID: 10778
	[Token(Token = "0x2002A1A")]
	public class LegionUICardSelectState : CommonUIStateNode
	{
		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x06011E19 RID: 73241 RVA: 0x0006D5C0 File Offset: 0x0006B7C0
		[Token(Token = "0x17002757")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6011E19")]
			[Address(RVA = "0x9C9D60", Offset = "0x9C8960", VA = "0x1809C9D60", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x06011E1A RID: 73242 RVA: 0x0006D5D8 File Offset: 0x0006B7D8
		[Token(Token = "0x17002758")]
		public override bool enablePause
		{
			[Token(Token = "0x6011E1A")]
			[Address(RVA = "0x9C9B60", Offset = "0x9C8760", VA = "0x1809C9B60", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x06011E1B RID: 73243 RVA: 0x0006D5F0 File Offset: 0x0006B7F0
		[Token(Token = "0x17002759")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6011E1B")]
			[Address(RVA = "0x9C9BC0", Offset = "0x9C87C0", VA = "0x1809C9BC0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x06011E1C RID: 73244 RVA: 0x0006D608 File Offset: 0x0006B808
		[Token(Token = "0x1700275A")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6011E1C")]
			[Address(RVA = "0x9C9C20", Offset = "0x9C8820", VA = "0x1809C9C20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x06011E1D RID: 73245 RVA: 0x0006D620 File Offset: 0x0006B820
		[Token(Token = "0x1700275B")]
		public int inHandCardCount
		{
			[Token(Token = "0x6011E1D")]
			[Address(RVA = "0x9C9C80", Offset = "0x9C8880", VA = "0x1809C9C80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x06011E1E RID: 73246 RVA: 0x0006D638 File Offset: 0x0006B838
		[Token(Token = "0x1700275C")]
		public int maxCardCount
		{
			[Token(Token = "0x6011E1E")]
			[Address(RVA = "0x9C9CF0", Offset = "0x9C88F0", VA = "0x1809C9CF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011E1F RID: 73247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E1F")]
		[Address(RVA = "0x9C95B0", Offset = "0x9C81B0", VA = "0x1809C95B0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011E20 RID: 73248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E20")]
		[Address(RVA = "0x9C9120", Offset = "0x9C7D20", VA = "0x1809C9120", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06011E21 RID: 73249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E21")]
		[Address(RVA = "0x9C94C0", Offset = "0x9C80C0", VA = "0x1809C94C0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06011E22 RID: 73250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E22")]
		[Address(RVA = "0x9C98B0", Offset = "0x9C84B0", VA = "0x1809C98B0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011E23 RID: 73251 RVA: 0x0006D650 File Offset: 0x0006B850
		[Token(Token = "0x6011E23")]
		[Address(RVA = "0x9C9090", Offset = "0x9C7C90", VA = "0x1809C9090", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06011E24 RID: 73252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E24")]
		[Address(RVA = "0x9C97B0", Offset = "0x9C83B0", VA = "0x1809C97B0", Slot = "29")]
		public override void OnPanelHiden()
		{
		}

		// Token: 0x06011E25 RID: 73253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E25")]
		[Address(RVA = "0x9C9910", Offset = "0x9C8510", VA = "0x1809C9910")]
		public void SelectDone(List<uint> selectRangeIds, List<uint> selectIds)
		{
		}

		// Token: 0x06011E26 RID: 73254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E26")]
		[Address(RVA = "0x9C8E70", Offset = "0x9C7A70", VA = "0x1809C8E70")]
		public void CancelSelect(List<uint> selectRangeIds)
		{
		}

		// Token: 0x06011E27 RID: 73255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E27")]
		[Address(RVA = "0x9C9B00", Offset = "0x9C8700", VA = "0x1809C9B00")]
		public LegionUICardSelectState()
		{
		}

		// Token: 0x06011E28 RID: 73256 RVA: 0x0006D668 File Offset: 0x0006B868
		[Token(Token = "0x6011E28")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06011E29 RID: 73257 RVA: 0x0006D680 File Offset: 0x0006B880
		[Token(Token = "0x6011E29")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06011E2A RID: 73258 RVA: 0x0006D698 File Offset: 0x0006B898
		[Token(Token = "0x6011E2A")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011E2B RID: 73259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E2B")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06011E2C RID: 73260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E2C")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06011E2D RID: 73261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E2D")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06011E2E RID: 73262 RVA: 0x0006D6B0 File Offset: 0x0006B8B0
		[Token(Token = "0x6011E2E")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x06011E2F RID: 73263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E2F")]
		[Address(RVA = "0x9C9AF0", Offset = "0x9C86F0", VA = "0x1809C9AF0")]
		private void <>xLuaBaseProxy_OnPanelHiden()
		{
		}

		// Token: 0x0401420B RID: 82443
		[Token(Token = "0x401420B")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public BattleLegionSelectCardParam selectData;

		// Token: 0x0401420C RID: 82444
		[Token(Token = "0x401420C")]
		[FieldOffset(Offset = "0x80")]
		private GameModeFactory.LegionGameMode m_manager;

		// Token: 0x0401420D RID: 82445
		[Token(Token = "0x401420D")]
		[FieldOffset(Offset = "0x88")]
		private LegionUIPlugin m_plugin;

		// Token: 0x0401420E RID: 82446
		[Token(Token = "0x401420E")]
		[FieldOffset(Offset = "0x90")]
		private UIBattleLegionCardSelectPanel m_panel;

		// Token: 0x0401420F RID: 82447
		[Token(Token = "0x401420F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04014210 RID: 82448
		[Token(Token = "0x4014210")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04014211 RID: 82449
		[Token(Token = "0x4014211")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04014212 RID: 82450
		[Token(Token = "0x4014212")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04014213 RID: 82451
		[Token(Token = "0x4014213")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inHandCardCount;

		// Token: 0x04014214 RID: 82452
		[Token(Token = "0x4014214")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_maxCardCount;

		// Token: 0x04014215 RID: 82453
		[Token(Token = "0x4014215")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04014216 RID: 82454
		[Token(Token = "0x4014216")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04014217 RID: 82455
		[Token(Token = "0x4014217")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04014218 RID: 82456
		[Token(Token = "0x4014218")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014219 RID: 82457
		[Token(Token = "0x4014219")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0401421A RID: 82458
		[Token(Token = "0x401421A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnPanelHiden;

		// Token: 0x0401421B RID: 82459
		[Token(Token = "0x401421B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SelectDone;

		// Token: 0x0401421C RID: 82460
		[Token(Token = "0x401421C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CancelSelect;

		// Token: 0x0401421D RID: 82461
		[Token(Token = "0x401421D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
