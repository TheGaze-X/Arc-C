using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act7Fun.Battle.UI
{
	// Token: 0x020071A7 RID: 29095
	[Token(Token = "0x20071A7")]
	public class Act7FunGameStartState : UIStateNode
	{
		// Token: 0x170061BC RID: 25020
		// (get) Token: 0x060294AE RID: 169134 RVA: 0x000D5288 File Offset: 0x000D3488
		[Token(Token = "0x170061BC")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60294AE")]
			[Address(RVA = "0x24BD2A0", Offset = "0x24BBEA0", VA = "0x1824BD2A0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170061BD RID: 25021
		// (get) Token: 0x060294AF RID: 169135 RVA: 0x000D52A0 File Offset: 0x000D34A0
		[Token(Token = "0x170061BD")]
		public override bool enablePause
		{
			[Token(Token = "0x60294AF")]
			[Address(RVA = "0x24BD120", Offset = "0x24BBD20", VA = "0x1824BD120", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061BE RID: 25022
		// (get) Token: 0x060294B0 RID: 169136 RVA: 0x000D52B8 File Offset: 0x000D34B8
		[Token(Token = "0x170061BE")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60294B0")]
			[Address(RVA = "0x24BD1E0", Offset = "0x24BBDE0", VA = "0x1824BD1E0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061BF RID: 25023
		// (get) Token: 0x060294B1 RID: 169137 RVA: 0x000D52D0 File Offset: 0x000D34D0
		[Token(Token = "0x170061BF")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60294B1")]
			[Address(RVA = "0x24BD240", Offset = "0x24BBE40", VA = "0x1824BD240", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061C0 RID: 25024
		// (get) Token: 0x060294B2 RID: 169138 RVA: 0x000D52E8 File Offset: 0x000D34E8
		[Token(Token = "0x170061C0")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x60294B2")]
			[Address(RVA = "0x24BD180", Offset = "0x24BBD80", VA = "0x1824BD180", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060294B3 RID: 169139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294B3")]
		[Address(RVA = "0x24BCED0", Offset = "0x24BBAD0", VA = "0x1824BCED0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060294B4 RID: 169140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294B4")]
		[Address(RVA = "0x24BCAB0", Offset = "0x24BB6B0", VA = "0x1824BCAB0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060294B5 RID: 169141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294B5")]
		[Address(RVA = "0x24BCE10", Offset = "0x24BBA10", VA = "0x1824BCE10", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060294B6 RID: 169142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294B6")]
		[Address(RVA = "0x24BD030", Offset = "0x24BBC30", VA = "0x1824BD030", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060294B7 RID: 169143 RVA: 0x000D5300 File Offset: 0x000D3500
		[Token(Token = "0x60294B7")]
		[Address(RVA = "0x24BCA40", Offset = "0x24BB640", VA = "0x1824BCA40", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x060294B8 RID: 169144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294B8")]
		[Address(RVA = "0x24BD090", Offset = "0x24BBC90", VA = "0x1824BD090")]
		public Act7FunGameStartState()
		{
		}

		// Token: 0x060294B9 RID: 169145 RVA: 0x000D5318 File Offset: 0x000D3518
		[Token(Token = "0x60294B9")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060294BA RID: 169146 RVA: 0x000D5330 File Offset: 0x000D3530
		[Token(Token = "0x60294BA")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060294BB RID: 169147 RVA: 0x000D5348 File Offset: 0x000D3548
		[Token(Token = "0x60294BB")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060294BC RID: 169148 RVA: 0x000D5360 File Offset: 0x000D3560
		[Token(Token = "0x60294BC")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x060294BD RID: 169149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294BD")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060294BE RID: 169150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294BE")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060294BF RID: 169151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294BF")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x060294C0 RID: 169152 RVA: 0x000D5378 File Offset: 0x000D3578
		[Token(Token = "0x60294C0")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403AF84 RID: 241540
		[Token(Token = "0x403AF84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animKey;

		// Token: 0x0403AF85 RID: 241541
		[Token(Token = "0x403AF85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _gameStartBanner;

		// Token: 0x0403AF86 RID: 241542
		[Token(Token = "0x403AF86")]
		[FieldOffset(Offset = "0x30")]
		private AnimationWrapper m_animationWrapper;

		// Token: 0x0403AF87 RID: 241543
		[Token(Token = "0x403AF87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403AF88 RID: 241544
		[Token(Token = "0x403AF88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403AF89 RID: 241545
		[Token(Token = "0x403AF89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403AF8A RID: 241546
		[Token(Token = "0x403AF8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403AF8B RID: 241547
		[Token(Token = "0x403AF8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0403AF8C RID: 241548
		[Token(Token = "0x403AF8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403AF8D RID: 241549
		[Token(Token = "0x403AF8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AF8E RID: 241550
		[Token(Token = "0x403AF8E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403AF8F RID: 241551
		[Token(Token = "0x403AF8F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403AF90 RID: 241552
		[Token(Token = "0x403AF90")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403AF91 RID: 241553
		[Token(Token = "0x403AF91")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
