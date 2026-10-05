using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x02007905 RID: 30981
	[Token(Token = "0x2007905")]
	public class GameCitySystemMenuState : UIStateNode
	{
		// Token: 0x170065CF RID: 26063
		// (get) Token: 0x0602B744 RID: 177988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065CF")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x602B744")]
			[Address(RVA = "0x275D760", Offset = "0x275C360", VA = "0x18275D760")]
			get
			{
				return null;
			}
		}

		// Token: 0x170065D0 RID: 26064
		// (get) Token: 0x0602B745 RID: 177989 RVA: 0x000DC0E0 File Offset: 0x000DA2E0
		[Token(Token = "0x170065D0")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602B745")]
			[Address(RVA = "0x275D900", Offset = "0x275C500", VA = "0x18275D900", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170065D1 RID: 26065
		// (get) Token: 0x0602B746 RID: 177990 RVA: 0x000DC0F8 File Offset: 0x000DA2F8
		[Token(Token = "0x170065D1")]
		public override bool enablePause
		{
			[Token(Token = "0x602B746")]
			[Address(RVA = "0x275D7E0", Offset = "0x275C3E0", VA = "0x18275D7E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065D2 RID: 26066
		// (get) Token: 0x0602B747 RID: 177991 RVA: 0x000DC110 File Offset: 0x000DA310
		[Token(Token = "0x170065D2")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602B747")]
			[Address(RVA = "0x275D840", Offset = "0x275C440", VA = "0x18275D840", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065D3 RID: 26067
		// (get) Token: 0x0602B748 RID: 177992 RVA: 0x000DC128 File Offset: 0x000DA328
		[Token(Token = "0x170065D3")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602B748")]
			[Address(RVA = "0x275D8A0", Offset = "0x275C4A0", VA = "0x18275D8A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B749 RID: 177993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B749")]
		[Address(RVA = "0x275CD80", Offset = "0x275B980", VA = "0x18275CD80")]
		public void OnCancel()
		{
		}

		// Token: 0x0602B74A RID: 177994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B74A")]
		[Address(RVA = "0x275D3D0", Offset = "0x275BFD0", VA = "0x18275D3D0")]
		public void OnRestartForBattle()
		{
		}

		// Token: 0x0602B74B RID: 177995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B74B")]
		[Address(RVA = "0x275CE60", Offset = "0x275BA60", VA = "0x18275CE60")]
		public void OnConfirmFinish()
		{
		}

		// Token: 0x0602B74C RID: 177996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B74C")]
		[Address(RVA = "0x275D280", Offset = "0x275BE80", VA = "0x18275D280", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602B74D RID: 177997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B74D")]
		[Address(RVA = "0x275CFC0", Offset = "0x275BBC0", VA = "0x18275CFC0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0602B74E RID: 177998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B74E")]
		[Address(RVA = "0x275D160", Offset = "0x275BD60", VA = "0x18275D160", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0602B74F RID: 177999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B74F")]
		[Address(RVA = "0x275D530", Offset = "0x275C130", VA = "0x18275D530", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0602B750 RID: 178000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B750")]
		[Address(RVA = "0x275D590", Offset = "0x275C190", VA = "0x18275D590")]
		private void _SwitchToBattleFinish()
		{
		}

		// Token: 0x0602B751 RID: 178001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B751")]
		[Address(RVA = "0x275D700", Offset = "0x275C300", VA = "0x18275D700")]
		public GameCitySystemMenuState()
		{
		}

		// Token: 0x0602B753 RID: 178003 RVA: 0x000DC140 File Offset: 0x000DA340
		[Token(Token = "0x602B753")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0602B754 RID: 178004 RVA: 0x000DC158 File Offset: 0x000DA358
		[Token(Token = "0x602B754")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0602B755 RID: 178005 RVA: 0x000DC170 File Offset: 0x000DA370
		[Token(Token = "0x602B755")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602B756 RID: 178006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B756")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0602B757 RID: 178007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B757")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602B758 RID: 178008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B758")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0403ED54 RID: 257364
		[Token(Token = "0x403ED54")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBattleSystemMenuPanel _battleMenu;

		// Token: 0x0403ED55 RID: 257365
		[Token(Token = "0x403ED55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x0403ED56 RID: 257366
		[Token(Token = "0x403ED56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403ED57 RID: 257367
		[Token(Token = "0x403ED57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403ED58 RID: 257368
		[Token(Token = "0x403ED58")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403ED59 RID: 257369
		[Token(Token = "0x403ED59")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403ED5A RID: 257370
		[Token(Token = "0x403ED5A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0403ED5B RID: 257371
		[Token(Token = "0x403ED5B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRestartForBattle;

		// Token: 0x0403ED5C RID: 257372
		[Token(Token = "0x403ED5C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnConfirmFinish;

		// Token: 0x0403ED5D RID: 257373
		[Token(Token = "0x403ED5D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403ED5E RID: 257374
		[Token(Token = "0x403ED5E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403ED5F RID: 257375
		[Token(Token = "0x403ED5F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403ED60 RID: 257376
		[Token(Token = "0x403ED60")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403ED61 RID: 257377
		[Token(Token = "0x403ED61")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SwitchToBattleFinish;

		// Token: 0x0403ED62 RID: 257378
		[Token(Token = "0x403ED62")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
