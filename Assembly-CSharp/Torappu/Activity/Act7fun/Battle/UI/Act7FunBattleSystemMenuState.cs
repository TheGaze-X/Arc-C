using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act7Fun.Battle.UI
{
	// Token: 0x020071A6 RID: 29094
	[Token(Token = "0x20071A6")]
	public class Act7FunBattleSystemMenuState : UIStateNode
	{
		// Token: 0x170061B7 RID: 25015
		// (get) Token: 0x0602949D RID: 169117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061B7")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x602949D")]
			[Address(RVA = "0x24BAC90", Offset = "0x24B9890", VA = "0x1824BAC90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061B8 RID: 25016
		// (get) Token: 0x0602949E RID: 169118 RVA: 0x000D51E0 File Offset: 0x000D33E0
		[Token(Token = "0x170061B8")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602949E")]
			[Address(RVA = "0x24BAE30", Offset = "0x24B9A30", VA = "0x1824BAE30", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170061B9 RID: 25017
		// (get) Token: 0x0602949F RID: 169119 RVA: 0x000D51F8 File Offset: 0x000D33F8
		[Token(Token = "0x170061B9")]
		public override bool enablePause
		{
			[Token(Token = "0x602949F")]
			[Address(RVA = "0x24BAD10", Offset = "0x24B9910", VA = "0x1824BAD10", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061BA RID: 25018
		// (get) Token: 0x060294A0 RID: 169120 RVA: 0x000D5210 File Offset: 0x000D3410
		[Token(Token = "0x170061BA")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60294A0")]
			[Address(RVA = "0x24BAD70", Offset = "0x24B9970", VA = "0x1824BAD70", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061BB RID: 25019
		// (get) Token: 0x060294A1 RID: 169121 RVA: 0x000D5228 File Offset: 0x000D3428
		[Token(Token = "0x170061BB")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60294A1")]
			[Address(RVA = "0x24BADD0", Offset = "0x24B99D0", VA = "0x1824BADD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060294A2 RID: 169122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294A2")]
		[Address(RVA = "0x24BA4B0", Offset = "0x24B90B0", VA = "0x1824BA4B0")]
		public void OnCancel()
		{
		}

		// Token: 0x060294A3 RID: 169123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294A3")]
		[Address(RVA = "0x24BA9C0", Offset = "0x24B95C0", VA = "0x1824BA9C0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060294A4 RID: 169124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294A4")]
		[Address(RVA = "0x24BA540", Offset = "0x24B9140", VA = "0x1824BA540", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060294A5 RID: 169125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294A5")]
		[Address(RVA = "0x24BA8A0", Offset = "0x24B94A0", VA = "0x1824BA8A0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060294A6 RID: 169126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294A6")]
		[Address(RVA = "0x24BABD0", Offset = "0x24B97D0", VA = "0x1824BABD0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060294A7 RID: 169127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294A7")]
		[Address(RVA = "0x24BAC30", Offset = "0x24B9830", VA = "0x1824BAC30")]
		public Act7FunBattleSystemMenuState()
		{
		}

		// Token: 0x060294A8 RID: 169128 RVA: 0x000D5240 File Offset: 0x000D3440
		[Token(Token = "0x60294A8")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060294A9 RID: 169129 RVA: 0x000D5258 File Offset: 0x000D3458
		[Token(Token = "0x60294A9")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060294AA RID: 169130 RVA: 0x000D5270 File Offset: 0x000D3470
		[Token(Token = "0x60294AA")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060294AB RID: 169131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294AB")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060294AC RID: 169132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294AC")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060294AD RID: 169133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294AD")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0403AF77 RID: 241527
		[Token(Token = "0x403AF77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _battleMenu;

		// Token: 0x0403AF78 RID: 241528
		[Token(Token = "0x403AF78")]
		[FieldOffset(Offset = "0x28")]
		private Act7FunBattleSystemMenuPanel m_battleMenu;

		// Token: 0x0403AF79 RID: 241529
		[Token(Token = "0x403AF79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x0403AF7A RID: 241530
		[Token(Token = "0x403AF7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403AF7B RID: 241531
		[Token(Token = "0x403AF7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403AF7C RID: 241532
		[Token(Token = "0x403AF7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403AF7D RID: 241533
		[Token(Token = "0x403AF7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403AF7E RID: 241534
		[Token(Token = "0x403AF7E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0403AF7F RID: 241535
		[Token(Token = "0x403AF7F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403AF80 RID: 241536
		[Token(Token = "0x403AF80")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AF81 RID: 241537
		[Token(Token = "0x403AF81")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403AF82 RID: 241538
		[Token(Token = "0x403AF82")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403AF83 RID: 241539
		[Token(Token = "0x403AF83")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
