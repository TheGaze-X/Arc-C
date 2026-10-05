using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side.Battle.UI
{
	// Token: 0x020076AD RID: 30381
	[Token(Token = "0x20076AD")]
	public class Act27sideBattleAccomplishedState : UIStateNode
	{
		// Token: 0x1700645F RID: 25695
		// (get) Token: 0x0602AB8C RID: 174988 RVA: 0x000D9998 File Offset: 0x000D7B98
		[Token(Token = "0x1700645F")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602AB8C")]
			[Address(RVA = "0x2694270", Offset = "0x2692E70", VA = "0x182694270", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17006460 RID: 25696
		// (get) Token: 0x0602AB8D RID: 174989 RVA: 0x000D99B0 File Offset: 0x000D7BB0
		[Token(Token = "0x17006460")]
		public override bool enablePause
		{
			[Token(Token = "0x602AB8D")]
			[Address(RVA = "0x2694150", Offset = "0x2692D50", VA = "0x182694150", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006461 RID: 25697
		// (get) Token: 0x0602AB8E RID: 174990 RVA: 0x000D99C8 File Offset: 0x000D7BC8
		[Token(Token = "0x17006461")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602AB8E")]
			[Address(RVA = "0x26941B0", Offset = "0x2692DB0", VA = "0x1826941B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006462 RID: 25698
		// (get) Token: 0x0602AB8F RID: 174991 RVA: 0x000D99E0 File Offset: 0x000D7BE0
		[Token(Token = "0x17006462")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602AB8F")]
			[Address(RVA = "0x2694210", Offset = "0x2692E10", VA = "0x182694210", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB90 RID: 174992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB90")]
		[Address(RVA = "0x2693FD0", Offset = "0x2692BD0", VA = "0x182693FD0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0602AB91 RID: 174993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB91")]
		[Address(RVA = "0x2694090", Offset = "0x2692C90", VA = "0x182694090", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0602AB92 RID: 174994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB92")]
		[Address(RVA = "0x2693F40", Offset = "0x2692B40", VA = "0x182693F40")]
		public void OnClick()
		{
		}

		// Token: 0x0602AB93 RID: 174995 RVA: 0x000D99F8 File Offset: 0x000D7BF8
		[Token(Token = "0x602AB93")]
		[Address(RVA = "0x2693ED0", Offset = "0x2692AD0", VA = "0x182693ED0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x0602AB94 RID: 174996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB94")]
		[Address(RVA = "0x26940F0", Offset = "0x2692CF0", VA = "0x1826940F0")]
		public Act27sideBattleAccomplishedState()
		{
		}

		// Token: 0x0602AB95 RID: 174997 RVA: 0x000D9A10 File Offset: 0x000D7C10
		[Token(Token = "0x602AB95")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0602AB96 RID: 174998 RVA: 0x000D9A28 File Offset: 0x000D7C28
		[Token(Token = "0x602AB96")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0602AB97 RID: 174999 RVA: 0x000D9A40 File Offset: 0x000D7C40
		[Token(Token = "0x602AB97")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602AB98 RID: 175000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB98")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602AB99 RID: 175001 RVA: 0x000D9A58 File Offset: 0x000D7C58
		[Token(Token = "0x602AB99")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403D906 RID: 252166
		[Token(Token = "0x403D906")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _battleAccomplishedPanel;

		// Token: 0x0403D907 RID: 252167
		[Token(Token = "0x403D907")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403D908 RID: 252168
		[Token(Token = "0x403D908")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403D909 RID: 252169
		[Token(Token = "0x403D909")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403D90A RID: 252170
		[Token(Token = "0x403D90A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403D90B RID: 252171
		[Token(Token = "0x403D90B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D90C RID: 252172
		[Token(Token = "0x403D90C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403D90D RID: 252173
		[Token(Token = "0x403D90D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403D90E RID: 252174
		[Token(Token = "0x403D90E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403D90F RID: 252175
		[Token(Token = "0x403D90F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
