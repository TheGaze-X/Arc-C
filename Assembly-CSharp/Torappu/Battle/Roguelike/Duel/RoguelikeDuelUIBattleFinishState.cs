using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Roguelike.Duel
{
	// Token: 0x02002933 RID: 10547
	[Token(Token = "0x2002933")]
	public class RoguelikeDuelUIBattleFinishState : UIStateNode
	{
		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x060117EC RID: 71660 RVA: 0x0006BAC0 File Offset: 0x00069CC0
		[Token(Token = "0x170026B2")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60117EC")]
			[Address(RVA = "0x962DD0", Offset = "0x9619D0", VA = "0x180962DD0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x060117ED RID: 71661 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		[Token(Token = "0x170026B3")]
		public override bool enablePause
		{
			[Token(Token = "0x60117ED")]
			[Address(RVA = "0x962CB0", Offset = "0x9618B0", VA = "0x180962CB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x060117EE RID: 71662 RVA: 0x0006BAF0 File Offset: 0x00069CF0
		[Token(Token = "0x170026B4")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60117EE")]
			[Address(RVA = "0x962D10", Offset = "0x961910", VA = "0x180962D10", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x060117EF RID: 71663 RVA: 0x0006BB08 File Offset: 0x00069D08
		[Token(Token = "0x170026B5")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60117EF")]
			[Address(RVA = "0x962D70", Offset = "0x961970", VA = "0x180962D70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060117F0 RID: 71664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117F0")]
		[Address(RVA = "0x962AC0", Offset = "0x9616C0", VA = "0x180962AC0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060117F1 RID: 71665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117F1")]
		[Address(RVA = "0x962670", Offset = "0x961270", VA = "0x180962670", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060117F2 RID: 71666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117F2")]
		[Address(RVA = "0x962B50", Offset = "0x961750", VA = "0x180962B50", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060117F3 RID: 71667 RVA: 0x0006BB20 File Offset: 0x00069D20
		[Token(Token = "0x60117F3")]
		[Address(RVA = "0x962600", Offset = "0x961200", VA = "0x180962600", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x060117F4 RID: 71668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117F4")]
		[Address(RVA = "0x962BC0", Offset = "0x9617C0", VA = "0x180962BC0")]
		private void _OnAnimationFinish()
		{
		}

		// Token: 0x060117F5 RID: 71669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117F5")]
		[Address(RVA = "0x962C50", Offset = "0x961850", VA = "0x180962C50")]
		public RoguelikeDuelUIBattleFinishState()
		{
		}

		// Token: 0x060117F9 RID: 71673 RVA: 0x0006BB38 File Offset: 0x00069D38
		[Token(Token = "0x60117F9")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060117FA RID: 71674 RVA: 0x0006BB50 File Offset: 0x00069D50
		[Token(Token = "0x60117FA")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060117FB RID: 71675 RVA: 0x0006BB68 File Offset: 0x00069D68
		[Token(Token = "0x60117FB")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060117FC RID: 71676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117FC")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060117FD RID: 71677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117FD")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060117FE RID: 71678 RVA: 0x0006BB80 File Offset: 0x00069D80
		[Token(Token = "0x60117FE")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0401390B RID: 80139
		[Token(Token = "0x401390B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _showLoseAnimation;

		// Token: 0x0401390C RID: 80140
		[Token(Token = "0x401390C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _showDrawAnimation;

		// Token: 0x0401390D RID: 80141
		[Token(Token = "0x401390D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _showWinAnimation;

		// Token: 0x0401390E RID: 80142
		[Token(Token = "0x401390E")]
		[FieldOffset(Offset = "0x50")]
		private BattleFailedStateParam m_stateParam;

		// Token: 0x0401390F RID: 80143
		[Token(Token = "0x401390F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04013910 RID: 80144
		[Token(Token = "0x4013910")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04013911 RID: 80145
		[Token(Token = "0x4013911")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04013912 RID: 80146
		[Token(Token = "0x4013912")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04013913 RID: 80147
		[Token(Token = "0x4013913")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013914 RID: 80148
		[Token(Token = "0x4013914")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04013915 RID: 80149
		[Token(Token = "0x4013915")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013916 RID: 80150
		[Token(Token = "0x4013916")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04013917 RID: 80151
		[Token(Token = "0x4013917")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnAnimationFinish;

		// Token: 0x04013918 RID: 80152
		[Token(Token = "0x4013918")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
