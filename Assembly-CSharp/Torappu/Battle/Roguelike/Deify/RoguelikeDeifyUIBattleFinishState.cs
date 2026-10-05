using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Roguelike.Deify
{
	// Token: 0x02002934 RID: 10548
	[Token(Token = "0x2002934")]
	public class RoguelikeDeifyUIBattleFinishState : UIStateNode
	{
		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x060117FF RID: 71679 RVA: 0x0006BB98 File Offset: 0x00069D98
		[Token(Token = "0x170026B6")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60117FF")]
			[Address(RVA = "0x95E9C0", Offset = "0x95D5C0", VA = "0x18095E9C0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x06011800 RID: 71680 RVA: 0x0006BBB0 File Offset: 0x00069DB0
		[Token(Token = "0x170026B7")]
		public override bool enablePause
		{
			[Token(Token = "0x6011800")]
			[Address(RVA = "0x95E8A0", Offset = "0x95D4A0", VA = "0x18095E8A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x06011801 RID: 71681 RVA: 0x0006BBC8 File Offset: 0x00069DC8
		[Token(Token = "0x170026B8")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6011801")]
			[Address(RVA = "0x95E900", Offset = "0x95D500", VA = "0x18095E900", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x06011802 RID: 71682 RVA: 0x0006BBE0 File Offset: 0x00069DE0
		[Token(Token = "0x170026B9")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6011802")]
			[Address(RVA = "0x95E960", Offset = "0x95D560", VA = "0x18095E960", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011803 RID: 71683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011803")]
		[Address(RVA = "0x95E380", Offset = "0x95CF80", VA = "0x18095E380", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06011804 RID: 71684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011804")]
		[Address(RVA = "0x95E660", Offset = "0x95D260", VA = "0x18095E660")]
		private void ShowAnimation(bool win)
		{
		}

		// Token: 0x06011805 RID: 71685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011805")]
		[Address(RVA = "0x95E600", Offset = "0x95D200", VA = "0x18095E600", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011806 RID: 71686 RVA: 0x0006BBF8 File Offset: 0x00069DF8
		[Token(Token = "0x6011806")]
		[Address(RVA = "0x95E310", Offset = "0x95CF10", VA = "0x18095E310", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06011807 RID: 71687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011807")]
		[Address(RVA = "0x95E7B0", Offset = "0x95D3B0", VA = "0x18095E7B0")]
		private void _OnAnimationFinish()
		{
		}

		// Token: 0x06011808 RID: 71688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011808")]
		[Address(RVA = "0x95E840", Offset = "0x95D440", VA = "0x18095E840")]
		public RoguelikeDeifyUIBattleFinishState()
		{
		}

		// Token: 0x0601180A RID: 71690 RVA: 0x0006BC10 File Offset: 0x00069E10
		[Token(Token = "0x601180A")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0601180B RID: 71691 RVA: 0x0006BC28 File Offset: 0x00069E28
		[Token(Token = "0x601180B")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0601180C RID: 71692 RVA: 0x0006BC40 File Offset: 0x00069E40
		[Token(Token = "0x601180C")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601180D RID: 71693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601180D")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0601180E RID: 71694 RVA: 0x0006BC58 File Offset: 0x00069E58
		[Token(Token = "0x601180E")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04013919 RID: 80153
		[Token(Token = "0x4013919")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _showLoseAnimation;

		// Token: 0x0401391A RID: 80154
		[Token(Token = "0x401391A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _showWinAnimation;

		// Token: 0x0401391B RID: 80155
		[Token(Token = "0x401391B")]
		[FieldOffset(Offset = "0x40")]
		private BattleFailedStateParam m_stateParam;

		// Token: 0x0401391C RID: 80156
		[Token(Token = "0x401391C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0401391D RID: 80157
		[Token(Token = "0x401391D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0401391E RID: 80158
		[Token(Token = "0x401391E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0401391F RID: 80159
		[Token(Token = "0x401391F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04013920 RID: 80160
		[Token(Token = "0x4013920")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04013921 RID: 80161
		[Token(Token = "0x4013921")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowAnimation;

		// Token: 0x04013922 RID: 80162
		[Token(Token = "0x4013922")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013923 RID: 80163
		[Token(Token = "0x4013923")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04013924 RID: 80164
		[Token(Token = "0x4013924")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnAnimationFinish;

		// Token: 0x04013925 RID: 80165
		[Token(Token = "0x4013925")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
