using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003320 RID: 13088
	[Token(Token = "0x2003320")]
	public class UIBattleSystemMenuState : UIStateNode
	{
		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x06014CEE RID: 85230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003148")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014CEE")]
			[Address(RVA = "0xD3B8D0", Offset = "0xD3A4D0", VA = "0x180D3B8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x06014CEF RID: 85231 RVA: 0x000889C8 File Offset: 0x00086BC8
		[Token(Token = "0x17003149")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014CEF")]
			[Address(RVA = "0xD3BA70", Offset = "0xD3A670", VA = "0x180D3BA70", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x06014CF0 RID: 85232 RVA: 0x000889E0 File Offset: 0x00086BE0
		[Token(Token = "0x1700314A")]
		public override bool enablePause
		{
			[Token(Token = "0x6014CF0")]
			[Address(RVA = "0xD3B950", Offset = "0xD3A550", VA = "0x180D3B950", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x06014CF1 RID: 85233 RVA: 0x000889F8 File Offset: 0x00086BF8
		[Token(Token = "0x1700314B")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014CF1")]
			[Address(RVA = "0xD3B9B0", Offset = "0xD3A5B0", VA = "0x180D3B9B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x06014CF2 RID: 85234 RVA: 0x00088A10 File Offset: 0x00086C10
		[Token(Token = "0x1700314C")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014CF2")]
			[Address(RVA = "0xD3BA10", Offset = "0xD3A610", VA = "0x180D3BA10", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014CF3 RID: 85235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CF3")]
		[Address(RVA = "0xD3AB60", Offset = "0xD39760", VA = "0x180D3AB60")]
		public void OnCancel()
		{
		}

		// Token: 0x06014CF4 RID: 85236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CF4")]
		[Address(RVA = "0xD3B5E0", Offset = "0xD3A1E0", VA = "0x180D3B5E0")]
		public void OnRestart()
		{
		}

		// Token: 0x06014CF5 RID: 85237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CF5")]
		[Address(RVA = "0xD3B3F0", Offset = "0xD39FF0", VA = "0x180D3B3F0")]
		public void OnRestartForBattle()
		{
		}

		// Token: 0x06014CF6 RID: 85238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CF6")]
		[Address(RVA = "0xD3B1C0", Offset = "0xD39DC0", VA = "0x180D3B1C0")]
		public void OnForceSucceed()
		{
		}

		// Token: 0x06014CF7 RID: 85239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CF7")]
		[Address(RVA = "0xD3B220", Offset = "0xD39E20", VA = "0x180D3B220")]
		public void OnGiveUp()
		{
		}

		// Token: 0x06014CF8 RID: 85240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CF8")]
		[Address(RVA = "0xD3AD30", Offset = "0xD39930", VA = "0x180D3AD30")]
		public void OnConfirmFinish()
		{
		}

		// Token: 0x06014CF9 RID: 85241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CF9")]
		[Address(RVA = "0xD3B2A0", Offset = "0xD39EA0", VA = "0x180D3B2A0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014CFA RID: 85242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CFA")]
		[Address(RVA = "0xD3AEA0", Offset = "0xD39AA0", VA = "0x180D3AEA0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014CFB RID: 85243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CFB")]
		[Address(RVA = "0xD3B0A0", Offset = "0xD39CA0", VA = "0x180D3B0A0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014CFC RID: 85244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CFC")]
		[Address(RVA = "0xD3B640", Offset = "0xD3A240", VA = "0x180D3B640", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014CFD RID: 85245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CFD")]
		[Address(RVA = "0xD3B6B0", Offset = "0xD3A2B0", VA = "0x180D3B6B0")]
		private void _SwitchToFailedState(bool isGiveUp)
		{
		}

		// Token: 0x06014CFE RID: 85246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CFE")]
		[Address(RVA = "0xD3B860", Offset = "0xD3A460", VA = "0x180D3B860")]
		public UIBattleSystemMenuState()
		{
		}

		// Token: 0x06014D00 RID: 85248 RVA: 0x00088A28 File Offset: 0x00086C28
		[Token(Token = "0x6014D00")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014D01 RID: 85249 RVA: 0x00088A40 File Offset: 0x00086C40
		[Token(Token = "0x6014D01")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014D02 RID: 85250 RVA: 0x00088A58 File Offset: 0x00086C58
		[Token(Token = "0x6014D02")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014D03 RID: 85251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D03")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014D04 RID: 85252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D04")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014D05 RID: 85253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D05")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018BF6 RID: 101366
		[Token(Token = "0x4018BF6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBattleSystemMenuPanel _battleMenu;

		// Token: 0x04018BF7 RID: 101367
		[Token(Token = "0x4018BF7")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isFromFailState;

		// Token: 0x04018BF8 RID: 101368
		[Token(Token = "0x4018BF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x04018BF9 RID: 101369
		[Token(Token = "0x4018BF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018BFA RID: 101370
		[Token(Token = "0x4018BFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018BFB RID: 101371
		[Token(Token = "0x4018BFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018BFC RID: 101372
		[Token(Token = "0x4018BFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018BFD RID: 101373
		[Token(Token = "0x4018BFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x04018BFE RID: 101374
		[Token(Token = "0x4018BFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRestart;

		// Token: 0x04018BFF RID: 101375
		[Token(Token = "0x4018BFF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRestartForBattle;

		// Token: 0x04018C00 RID: 101376
		[Token(Token = "0x4018C00")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnForceSucceed;

		// Token: 0x04018C01 RID: 101377
		[Token(Token = "0x4018C01")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnGiveUp;

		// Token: 0x04018C02 RID: 101378
		[Token(Token = "0x4018C02")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnConfirmFinish;

		// Token: 0x04018C03 RID: 101379
		[Token(Token = "0x4018C03")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018C04 RID: 101380
		[Token(Token = "0x4018C04")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018C05 RID: 101381
		[Token(Token = "0x4018C05")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018C06 RID: 101382
		[Token(Token = "0x4018C06")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018C07 RID: 101383
		[Token(Token = "0x4018C07")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SwitchToFailedState;

		// Token: 0x04018C08 RID: 101384
		[Token(Token = "0x4018C08")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
