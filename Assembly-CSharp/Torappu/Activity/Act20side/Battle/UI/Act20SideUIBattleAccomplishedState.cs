using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side.Battle.UI
{
	// Token: 0x020076A9 RID: 30377
	[Token(Token = "0x20076A9")]
	public class Act20SideUIBattleAccomplishedState : UIStateNode
	{
		// Token: 0x1700645B RID: 25691
		// (get) Token: 0x0602AB55 RID: 174933 RVA: 0x000D9800 File Offset: 0x000D7A00
		[Token(Token = "0x1700645B")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602AB55")]
			[Address(RVA = "0x2667190", Offset = "0x2665D90", VA = "0x182667190", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700645C RID: 25692
		// (get) Token: 0x0602AB56 RID: 174934 RVA: 0x000D9818 File Offset: 0x000D7A18
		[Token(Token = "0x1700645C")]
		public override bool enablePause
		{
			[Token(Token = "0x602AB56")]
			[Address(RVA = "0x2667070", Offset = "0x2665C70", VA = "0x182667070", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700645D RID: 25693
		// (get) Token: 0x0602AB57 RID: 174935 RVA: 0x000D9830 File Offset: 0x000D7A30
		[Token(Token = "0x1700645D")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602AB57")]
			[Address(RVA = "0x26670D0", Offset = "0x2665CD0", VA = "0x1826670D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700645E RID: 25694
		// (get) Token: 0x0602AB58 RID: 174936 RVA: 0x000D9848 File Offset: 0x000D7A48
		[Token(Token = "0x1700645E")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602AB58")]
			[Address(RVA = "0x2667130", Offset = "0x2665D30", VA = "0x182667130", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB59 RID: 174937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB59")]
		[Address(RVA = "0x2666E80", Offset = "0x2665A80", VA = "0x182666E80", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602AB5A RID: 174938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB5A")]
		[Address(RVA = "0x2666D40", Offset = "0x2665940", VA = "0x182666D40", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0602AB5B RID: 174939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB5B")]
		[Address(RVA = "0x2666F40", Offset = "0x2665B40", VA = "0x182666F40", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0602AB5C RID: 174940 RVA: 0x000D9860 File Offset: 0x000D7A60
		[Token(Token = "0x602AB5C")]
		[Address(RVA = "0x2666CD0", Offset = "0x26658D0", VA = "0x182666CD0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x0602AB5D RID: 174941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB5D")]
		[Address(RVA = "0x2667010", Offset = "0x2665C10", VA = "0x182667010")]
		public Act20SideUIBattleAccomplishedState()
		{
		}

		// Token: 0x0602AB5E RID: 174942 RVA: 0x000D9878 File Offset: 0x000D7A78
		[Token(Token = "0x602AB5E")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0602AB5F RID: 174943 RVA: 0x000D9890 File Offset: 0x000D7A90
		[Token(Token = "0x602AB5F")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0602AB60 RID: 174944 RVA: 0x000D98A8 File Offset: 0x000D7AA8
		[Token(Token = "0x602AB60")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602AB61 RID: 174945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB61")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0602AB62 RID: 174946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB62")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602AB63 RID: 174947 RVA: 0x000D98C0 File Offset: 0x000D7AC0
		[Token(Token = "0x602AB63")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403D8BA RID: 252090
		[Token(Token = "0x403D8BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animation _showAnimation;

		// Token: 0x0403D8BB RID: 252091
		[Token(Token = "0x403D8BB")]
		[FieldOffset(Offset = "0x28")]
		private BattleFailedStateParam m_stateParam;

		// Token: 0x0403D8BC RID: 252092
		[Token(Token = "0x403D8BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403D8BD RID: 252093
		[Token(Token = "0x403D8BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403D8BE RID: 252094
		[Token(Token = "0x403D8BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403D8BF RID: 252095
		[Token(Token = "0x403D8BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403D8C0 RID: 252096
		[Token(Token = "0x403D8C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403D8C1 RID: 252097
		[Token(Token = "0x403D8C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D8C2 RID: 252098
		[Token(Token = "0x403D8C2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403D8C3 RID: 252099
		[Token(Token = "0x403D8C3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403D8C4 RID: 252100
		[Token(Token = "0x403D8C4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
