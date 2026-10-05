using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side.Battle.UI
{
	// Token: 0x020076AE RID: 30382
	[Token(Token = "0x20076AE")]
	public class Act27sideBattleFailedState : UIStateNode
	{
		// Token: 0x17006463 RID: 25699
		// (get) Token: 0x0602AB9A RID: 175002 RVA: 0x000D9A70 File Offset: 0x000D7C70
		[Token(Token = "0x17006463")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602AB9A")]
			[Address(RVA = "0x2694710", Offset = "0x2693310", VA = "0x182694710", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17006464 RID: 25700
		// (get) Token: 0x0602AB9B RID: 175003 RVA: 0x000D9A88 File Offset: 0x000D7C88
		[Token(Token = "0x17006464")]
		public override bool enablePause
		{
			[Token(Token = "0x602AB9B")]
			[Address(RVA = "0x26945F0", Offset = "0x26931F0", VA = "0x1826945F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006465 RID: 25701
		// (get) Token: 0x0602AB9C RID: 175004 RVA: 0x000D9AA0 File Offset: 0x000D7CA0
		[Token(Token = "0x17006465")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602AB9C")]
			[Address(RVA = "0x2694650", Offset = "0x2693250", VA = "0x182694650", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006466 RID: 25702
		// (get) Token: 0x0602AB9D RID: 175005 RVA: 0x000D9AB8 File Offset: 0x000D7CB8
		[Token(Token = "0x17006466")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602AB9D")]
			[Address(RVA = "0x26946B0", Offset = "0x26932B0", VA = "0x1826946B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB9E RID: 175006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB9E")]
		[Address(RVA = "0x2694400", Offset = "0x2693000", VA = "0x182694400", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0602AB9F RID: 175007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB9F")]
		[Address(RVA = "0x2694530", Offset = "0x2693130", VA = "0x182694530", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0602ABA0 RID: 175008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABA0")]
		[Address(RVA = "0x2694370", Offset = "0x2692F70", VA = "0x182694370")]
		public void OnClick()
		{
		}

		// Token: 0x0602ABA1 RID: 175009 RVA: 0x000D9AD0 File Offset: 0x000D7CD0
		[Token(Token = "0x602ABA1")]
		[Address(RVA = "0x2694300", Offset = "0x2692F00", VA = "0x182694300", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x0602ABA2 RID: 175010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABA2")]
		[Address(RVA = "0x2694590", Offset = "0x2693190", VA = "0x182694590")]
		public Act27sideBattleFailedState()
		{
		}

		// Token: 0x0602ABA3 RID: 175011 RVA: 0x000D9AE8 File Offset: 0x000D7CE8
		[Token(Token = "0x602ABA3")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0602ABA4 RID: 175012 RVA: 0x000D9B00 File Offset: 0x000D7D00
		[Token(Token = "0x602ABA4")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0602ABA5 RID: 175013 RVA: 0x000D9B18 File Offset: 0x000D7D18
		[Token(Token = "0x602ABA5")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602ABA6 RID: 175014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABA6")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602ABA7 RID: 175015 RVA: 0x000D9B30 File Offset: 0x000D7D30
		[Token(Token = "0x602ABA7")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403D910 RID: 252176
		[Token(Token = "0x403D910")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _battleFailedPanel;

		// Token: 0x0403D911 RID: 252177
		[Token(Token = "0x403D911")]
		[FieldOffset(Offset = "0x28")]
		private BattleFailedStateParam m_stateParam;

		// Token: 0x0403D912 RID: 252178
		[Token(Token = "0x403D912")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403D913 RID: 252179
		[Token(Token = "0x403D913")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403D914 RID: 252180
		[Token(Token = "0x403D914")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403D915 RID: 252181
		[Token(Token = "0x403D915")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403D916 RID: 252182
		[Token(Token = "0x403D916")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D917 RID: 252183
		[Token(Token = "0x403D917")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403D918 RID: 252184
		[Token(Token = "0x403D918")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403D919 RID: 252185
		[Token(Token = "0x403D919")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403D91A RID: 252186
		[Token(Token = "0x403D91A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
