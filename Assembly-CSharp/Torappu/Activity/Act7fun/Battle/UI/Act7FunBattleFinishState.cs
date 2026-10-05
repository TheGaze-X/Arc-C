using System;
using Il2CppDummyDll;
using Torappu.Activity.Act7fun;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act7Fun.Battle.UI
{
	// Token: 0x020071A5 RID: 29093
	[Token(Token = "0x20071A5")]
	public class Act7FunBattleFinishState : UIStateNode
	{
		// Token: 0x170061B2 RID: 25010
		// (get) Token: 0x0602948A RID: 169098 RVA: 0x000D50D8 File Offset: 0x000D32D8
		[Token(Token = "0x170061B2")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602948A")]
			[Address(RVA = "0x24B90A0", Offset = "0x24B7CA0", VA = "0x1824B90A0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170061B3 RID: 25011
		// (get) Token: 0x0602948B RID: 169099 RVA: 0x000D50F0 File Offset: 0x000D32F0
		[Token(Token = "0x170061B3")]
		public override bool enablePause
		{
			[Token(Token = "0x602948B")]
			[Address(RVA = "0x24B8F20", Offset = "0x24B7B20", VA = "0x1824B8F20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061B4 RID: 25012
		// (get) Token: 0x0602948C RID: 169100 RVA: 0x000D5108 File Offset: 0x000D3308
		[Token(Token = "0x170061B4")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602948C")]
			[Address(RVA = "0x24B8FE0", Offset = "0x24B7BE0", VA = "0x1824B8FE0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061B5 RID: 25013
		// (get) Token: 0x0602948D RID: 169101 RVA: 0x000D5120 File Offset: 0x000D3320
		[Token(Token = "0x170061B5")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602948D")]
			[Address(RVA = "0x24B9040", Offset = "0x24B7C40", VA = "0x1824B9040", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170061B6 RID: 25014
		// (get) Token: 0x0602948E RID: 169102 RVA: 0x000D5138 File Offset: 0x000D3338
		[Token(Token = "0x170061B6")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x602948E")]
			[Address(RVA = "0x24B8F80", Offset = "0x24B7B80", VA = "0x1824B8F80", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602948F RID: 169103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602948F")]
		[Address(RVA = "0x24B8AA0", Offset = "0x24B76A0", VA = "0x1824B8AA0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06029490 RID: 169104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029490")]
		[Address(RVA = "0x24B8600", Offset = "0x24B7200", VA = "0x1824B8600", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06029491 RID: 169105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029491")]
		[Address(RVA = "0x24B8C30", Offset = "0x24B7830", VA = "0x1824B8C30", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06029492 RID: 169106 RVA: 0x000D5150 File Offset: 0x000D3350
		[Token(Token = "0x6029492")]
		[Address(RVA = "0x24B8590", Offset = "0x24B7190", VA = "0x1824B8590", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06029493 RID: 169107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029493")]
		[Address(RVA = "0x24B8E00", Offset = "0x24B7A00", VA = "0x1824B8E00")]
		private void _SwitchToBattleFinishService()
		{
		}

		// Token: 0x06029494 RID: 169108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029494")]
		[Address(RVA = "0x24B8C90", Offset = "0x24B7890", VA = "0x1824B8C90")]
		private void _InitSpineStatus()
		{
		}

		// Token: 0x06029495 RID: 169109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029495")]
		[Address(RVA = "0x24B8E90", Offset = "0x24B7A90", VA = "0x1824B8E90")]
		public Act7FunBattleFinishState()
		{
		}

		// Token: 0x06029496 RID: 169110 RVA: 0x000D5168 File Offset: 0x000D3368
		[Token(Token = "0x6029496")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06029497 RID: 169111 RVA: 0x000D5180 File Offset: 0x000D3380
		[Token(Token = "0x6029497")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06029498 RID: 169112 RVA: 0x000D5198 File Offset: 0x000D3398
		[Token(Token = "0x6029498")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06029499 RID: 169113 RVA: 0x000D51B0 File Offset: 0x000D33B0
		[Token(Token = "0x6029499")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x0602949A RID: 169114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602949A")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0602949B RID: 169115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602949B")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602949C RID: 169116 RVA: 0x000D51C8 File Offset: 0x000D33C8
		[Token(Token = "0x602949C")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403AF67 RID: 241511
		[Token(Token = "0x403AF67")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _clipName;

		// Token: 0x0403AF68 RID: 241512
		[Token(Token = "0x403AF68")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _gameFinishBanner;

		// Token: 0x0403AF69 RID: 241513
		[Token(Token = "0x403AF69")]
		[FieldOffset(Offset = "0x30")]
		private AnimationWrapper m_animWrapper;

		// Token: 0x0403AF6A RID: 241514
		[Token(Token = "0x403AF6A")]
		[FieldOffset(Offset = "0x38")]
		private Act7FunSpineDisplayPanel m_spineDisplayPanel;

		// Token: 0x0403AF6B RID: 241515
		[Token(Token = "0x403AF6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403AF6C RID: 241516
		[Token(Token = "0x403AF6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403AF6D RID: 241517
		[Token(Token = "0x403AF6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403AF6E RID: 241518
		[Token(Token = "0x403AF6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403AF6F RID: 241519
		[Token(Token = "0x403AF6F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0403AF70 RID: 241520
		[Token(Token = "0x403AF70")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403AF71 RID: 241521
		[Token(Token = "0x403AF71")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AF72 RID: 241522
		[Token(Token = "0x403AF72")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403AF73 RID: 241523
		[Token(Token = "0x403AF73")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403AF74 RID: 241524
		[Token(Token = "0x403AF74")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SwitchToBattleFinishService;

		// Token: 0x0403AF75 RID: 241525
		[Token(Token = "0x403AF75")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitSpineStatus;

		// Token: 0x0403AF76 RID: 241526
		[Token(Token = "0x403AF76")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
