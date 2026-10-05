using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C9C RID: 27804
	[Token(Token = "0x2006C9C")]
	public class TemplateActivityMilestoneState : PopupFloatState, IBaseActStateBinder, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x06027A9C RID: 162460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A9C")]
		[Address(RVA = "0x22E3440", Offset = "0x22E2040", VA = "0x1822E3440", Slot = "32")]
		public void BindHandler(IBaseActHandler handler)
		{
		}

		// Token: 0x06027A9D RID: 162461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A9D")]
		[Address(RVA = "0x22E3770", Offset = "0x22E2370", VA = "0x1822E3770", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027A9E RID: 162462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A9E")]
		[Address(RVA = "0x22E39F0", Offset = "0x22E25F0", VA = "0x1822E39F0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06027A9F RID: 162463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A9F")]
		[Address(RVA = "0x22E37D0", Offset = "0x22E23D0", VA = "0x1822E37D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027AA0 RID: 162464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA0")]
		[Address(RVA = "0x22E3AC0", Offset = "0x22E26C0", VA = "0x1822E3AC0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06027AA1 RID: 162465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA1")]
		[Address(RVA = "0x22E3940", Offset = "0x22E2540", VA = "0x1822E3940", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06027AA2 RID: 162466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AA2")]
		[Address(RVA = "0x22E3C10", Offset = "0x22E2810", VA = "0x1822E3C10", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06027AA3 RID: 162467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA3")]
		[Address(RVA = "0x22E34C0", Offset = "0x22E20C0", VA = "0x1822E34C0")]
		public void EventOnBtnAllReward()
		{
		}

		// Token: 0x06027AA4 RID: 162468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA4")]
		[Address(RVA = "0x22E3710", Offset = "0x22E2310", VA = "0x1822E3710")]
		public void EventOnBtnCharSkinClick()
		{
		}

		// Token: 0x06027AA5 RID: 162469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA5")]
		[Address(RVA = "0x22E3D60", Offset = "0x22E2960", VA = "0x1822E3D60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027AA6 RID: 162470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA6")]
		[Address(RVA = "0x22E3FF0", Offset = "0x22E2BF0", VA = "0x1822E3FF0")]
		private void _OnMilestoneItemClick(string milestoneId)
		{
		}

		// Token: 0x06027AA7 RID: 162471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA7")]
		[Address(RVA = "0x22E3E40", Offset = "0x22E2A40", VA = "0x1822E3E40")]
		private void _OnMilestoneCharSkinClick()
		{
		}

		// Token: 0x06027AA8 RID: 162472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AA8")]
		[Address(RVA = "0x22E4270", Offset = "0x22E2E70", VA = "0x1822E4270")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x06027AA9 RID: 162473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AA9")]
		[Address(RVA = "0x22E4320", Offset = "0x22E2F20", VA = "0x1822E4320")]
		public TemplateActivityMilestoneState()
		{
		}

		// Token: 0x06027AAB RID: 162475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AAB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06027AAC RID: 162476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AAC")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06027AAD RID: 162477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AAD")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06027AAE RID: 162478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AAE")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x04038427 RID: 230439
		[Token(Token = "0x4038427")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TemplateActivityMilestoneHolder _holder;

		// Token: 0x04038428 RID: 230440
		[Token(Token = "0x4038428")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04038429 RID: 230441
		[Token(Token = "0x4038429")]
		[NonSerialized]
		public const int MSG_MILESTONE_CLICK = 1;

		// Token: 0x0403842A RID: 230442
		[Token(Token = "0x403842A")]
		[NonSerialized]
		public const int MSG_CHAR_SKIN_CLICK = 2;

		// Token: 0x0403842B RID: 230443
		[Token(Token = "0x403842B")]
		[FieldOffset(Offset = "0x80")]
		private IBaseActHandler m_handler;

		// Token: 0x0403842C RID: 230444
		[Token(Token = "0x403842C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403842D RID: 230445
		[Token(Token = "0x403842D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindHandler;

		// Token: 0x0403842E RID: 230446
		[Token(Token = "0x403842E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403842F RID: 230447
		[Token(Token = "0x403842F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04038430 RID: 230448
		[Token(Token = "0x4038430")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038431 RID: 230449
		[Token(Token = "0x4038431")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04038432 RID: 230450
		[Token(Token = "0x4038432")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04038433 RID: 230451
		[Token(Token = "0x4038433")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04038434 RID: 230452
		[Token(Token = "0x4038434")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnAllReward;

		// Token: 0x04038435 RID: 230453
		[Token(Token = "0x4038435")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBtnCharSkinClick;

		// Token: 0x04038436 RID: 230454
		[Token(Token = "0x4038436")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038437 RID: 230455
		[Token(Token = "0x4038437")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnMilestoneItemClick;

		// Token: 0x04038438 RID: 230456
		[Token(Token = "0x4038438")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnMilestoneCharSkinClick;

		// Token: 0x04038439 RID: 230457
		[Token(Token = "0x4038439")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403843A RID: 230458
		[Token(Token = "0x403843A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
