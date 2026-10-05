using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007950 RID: 31056
	[Token(Token = "0x2007950")]
	public class Act1ArcadeMilestoneState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0602B92F RID: 178479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B92F")]
		[Address(RVA = "0x2776E00", Offset = "0x2775A00", VA = "0x182776E00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B930 RID: 178480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B930")]
		[Address(RVA = "0x2777160", Offset = "0x2775D60", VA = "0x182777160", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602B931 RID: 178481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B931")]
		[Address(RVA = "0x27774C0", Offset = "0x27760C0", VA = "0x1827774C0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602B932 RID: 178482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B932")]
		[Address(RVA = "0x2776E60", Offset = "0x2775A60", VA = "0x182776E60", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602B933 RID: 178483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B933")]
		[Address(RVA = "0x2776F10", Offset = "0x2775B10", VA = "0x182776F10")]
		public void OnMilestoneAllRewardClick()
		{
		}

		// Token: 0x0602B934 RID: 178484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B934")]
		[Address(RVA = "0x2777230", Offset = "0x2775E30", VA = "0x182777230")]
		public void OnThemeRewardClick()
		{
		}

		// Token: 0x0602B935 RID: 178485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B935")]
		[Address(RVA = "0x2777610", Offset = "0x2776210", VA = "0x182777610")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B936 RID: 178486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B936")]
		[Address(RVA = "0x2777930", Offset = "0x2776530", VA = "0x182777930")]
		private void _OnMilestoneItemClick(string milestoneId)
		{
		}

		// Token: 0x0602B937 RID: 178487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B937")]
		[Address(RVA = "0x2777890", Offset = "0x2776490", VA = "0x182777890")]
		private void _OnClickBack()
		{
		}

		// Token: 0x0602B938 RID: 178488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B938")]
		[Address(RVA = "0x2777BB0", Offset = "0x27767B0", VA = "0x182777BB0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602B939 RID: 178489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B939")]
		[Address(RVA = "0x2777C60", Offset = "0x2776860", VA = "0x182777C60")]
		public Act1ArcadeMilestoneState()
		{
		}

		// Token: 0x0602B93B RID: 178491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B93B")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0602B93C RID: 178492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B93C")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0403F080 RID: 258176
		[Token(Token = "0x403F080")]
		[NonSerialized]
		public const int MSG_MILESTONE_CLICK = 1;

		// Token: 0x0403F081 RID: 258177
		[Token(Token = "0x403F081")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1ArcadeMilestoneViewAdapter _view;

		// Token: 0x0403F082 RID: 258178
		[Token(Token = "0x403F082")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403F083 RID: 258179
		[Token(Token = "0x403F083")]
		[FieldOffset(Offset = "0x80")]
		private string m_actId;

		// Token: 0x0403F084 RID: 258180
		[Token(Token = "0x403F084")]
		[FieldOffset(Offset = "0x88")]
		private Act1ArcadeMilestoneStateBean m_stateBean;

		// Token: 0x0403F085 RID: 258181
		[Token(Token = "0x403F085")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F086 RID: 258182
		[Token(Token = "0x403F086")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0403F087 RID: 258183
		[Token(Token = "0x403F087")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403F088 RID: 258184
		[Token(Token = "0x403F088")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403F089 RID: 258185
		[Token(Token = "0x403F089")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMilestoneAllRewardClick;

		// Token: 0x0403F08A RID: 258186
		[Token(Token = "0x403F08A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnThemeRewardClick;

		// Token: 0x0403F08B RID: 258187
		[Token(Token = "0x403F08B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F08C RID: 258188
		[Token(Token = "0x403F08C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnMilestoneItemClick;

		// Token: 0x0403F08D RID: 258189
		[Token(Token = "0x403F08D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClickBack;

		// Token: 0x0403F08E RID: 258190
		[Token(Token = "0x403F08E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403F08F RID: 258191
		[Token(Token = "0x403F08F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
