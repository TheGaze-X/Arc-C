using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A19 RID: 10777
	[Token(Token = "0x2002A19")]
	public class LegionUICardRedrawState : CommonUIStateNode
	{
		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x06011E03 RID: 73219 RVA: 0x0006D4E8 File Offset: 0x0006B6E8
		[Token(Token = "0x17002753")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6011E03")]
			[Address(RVA = "0x9AF100", Offset = "0x9ADD00", VA = "0x1809AF100", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x06011E04 RID: 73220 RVA: 0x0006D500 File Offset: 0x0006B700
		[Token(Token = "0x17002754")]
		public override bool enablePause
		{
			[Token(Token = "0x6011E04")]
			[Address(RVA = "0x9AEFE0", Offset = "0x9ADBE0", VA = "0x1809AEFE0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x06011E05 RID: 73221 RVA: 0x0006D518 File Offset: 0x0006B718
		[Token(Token = "0x17002755")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6011E05")]
			[Address(RVA = "0x9AF040", Offset = "0x9ADC40", VA = "0x1809AF040", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x06011E06 RID: 73222 RVA: 0x0006D530 File Offset: 0x0006B730
		[Token(Token = "0x17002756")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6011E06")]
			[Address(RVA = "0x9AF0A0", Offset = "0x9ADCA0", VA = "0x1809AF0A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011E07 RID: 73223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E07")]
		[Address(RVA = "0x9AE8D0", Offset = "0x9AD4D0", VA = "0x1809AE8D0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06011E08 RID: 73224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E08")]
		[Address(RVA = "0x9AE340", Offset = "0x9ACF40", VA = "0x1809AE340", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06011E09 RID: 73225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E09")]
		[Address(RVA = "0x9AE690", Offset = "0x9AD290", VA = "0x1809AE690", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06011E0A RID: 73226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E0A")]
		[Address(RVA = "0x9AECE0", Offset = "0x9AD8E0", VA = "0x1809AECE0")]
		private void _OnCardToggled(object item)
		{
		}

		// Token: 0x06011E0B RID: 73227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E0B")]
		[Address(RVA = "0x9AE190", Offset = "0x9ACD90", VA = "0x1809AE190")]
		public void OnConfirm()
		{
		}

		// Token: 0x06011E0C RID: 73228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E0C")]
		[Address(RVA = "0x9AEBF0", Offset = "0x9AD7F0", VA = "0x1809AEBF0")]
		public void OnUnselect()
		{
		}

		// Token: 0x06011E0D RID: 73229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E0D")]
		[Address(RVA = "0x9AEAB0", Offset = "0x9AD6B0", VA = "0x1809AEAB0")]
		public void OnShowPendingCard()
		{
		}

		// Token: 0x06011E0E RID: 73230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E0E")]
		[Address(RVA = "0x9AEB20", Offset = "0x9AD720", VA = "0x1809AEB20")]
		public void OnShowUsedCard()
		{
		}

		// Token: 0x06011E0F RID: 73231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E0F")]
		[Address(RVA = "0x9AEB90", Offset = "0x9AD790", VA = "0x1809AEB90", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011E10 RID: 73232 RVA: 0x0006D548 File Offset: 0x0006B748
		[Token(Token = "0x6011E10")]
		[Address(RVA = "0x9AE0D0", Offset = "0x9ACCD0", VA = "0x1809AE0D0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06011E11 RID: 73233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E11")]
		[Address(RVA = "0x9AEF30", Offset = "0x9ADB30", VA = "0x1809AEF30")]
		public LegionUICardRedrawState()
		{
		}

		// Token: 0x06011E12 RID: 73234 RVA: 0x0006D560 File Offset: 0x0006B760
		[Token(Token = "0x6011E12")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06011E13 RID: 73235 RVA: 0x0006D578 File Offset: 0x0006B778
		[Token(Token = "0x6011E13")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06011E14 RID: 73236 RVA: 0x0006D590 File Offset: 0x0006B790
		[Token(Token = "0x6011E14")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06011E15 RID: 73237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E15")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06011E16 RID: 73238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E16")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06011E17 RID: 73239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E17")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06011E18 RID: 73240 RVA: 0x0006D5A8 File Offset: 0x0006B7A8
		[Token(Token = "0x6011E18")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x040141F7 RID: 82423
		[Token(Token = "0x40141F7")]
		[FieldOffset(Offset = "0x50")]
		private LegionUIPlugin m_plugin;

		// Token: 0x040141F8 RID: 82424
		[Token(Token = "0x40141F8")]
		[FieldOffset(Offset = "0x58")]
		private GameModeFactory.LegionGameMode m_manager;

		// Token: 0x040141F9 RID: 82425
		[Token(Token = "0x40141F9")]
		[FieldOffset(Offset = "0x60")]
		private List<UICard> m_selectedCardList;

		// Token: 0x040141FA RID: 82426
		[Token(Token = "0x40141FA")]
		[FieldOffset(Offset = "0x68")]
		private UIBattleLegionRedrawPanel m_panel;

		// Token: 0x040141FB RID: 82427
		[Token(Token = "0x40141FB")]
		private const BattleFunctionDisableMask FUNCTION_MASK = BattleFunctionDisableMask.COST_PANEL;

		// Token: 0x040141FC RID: 82428
		[Token(Token = "0x40141FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040141FD RID: 82429
		[Token(Token = "0x40141FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x040141FE RID: 82430
		[Token(Token = "0x40141FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x040141FF RID: 82431
		[Token(Token = "0x40141FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04014200 RID: 82432
		[Token(Token = "0x4014200")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04014201 RID: 82433
		[Token(Token = "0x4014201")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04014202 RID: 82434
		[Token(Token = "0x4014202")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04014203 RID: 82435
		[Token(Token = "0x4014203")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCardToggled;

		// Token: 0x04014204 RID: 82436
		[Token(Token = "0x4014204")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x04014205 RID: 82437
		[Token(Token = "0x4014205")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnUnselect;

		// Token: 0x04014206 RID: 82438
		[Token(Token = "0x4014206")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnShowPendingCard;

		// Token: 0x04014207 RID: 82439
		[Token(Token = "0x4014207")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnShowUsedCard;

		// Token: 0x04014208 RID: 82440
		[Token(Token = "0x4014208")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014209 RID: 82441
		[Token(Token = "0x4014209")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0401420A RID: 82442
		[Token(Token = "0x401420A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
