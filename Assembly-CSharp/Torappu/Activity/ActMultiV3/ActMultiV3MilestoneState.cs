using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F3B RID: 28475
	[Token(Token = "0x2006F3B")]
	public class ActMultiV3MilestoneState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06028703 RID: 165635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028703")]
		[Address(RVA = "0x23CAE90", Offset = "0x23C9A90", VA = "0x1823CAE90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028704 RID: 165636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028704")]
		[Address(RVA = "0x23CAEF0", Offset = "0x23C9AF0", VA = "0x1823CAEF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028705 RID: 165637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028705")]
		[Address(RVA = "0x23CB520", Offset = "0x23CA120", VA = "0x1823CB520", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06028706 RID: 165638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028706")]
		[Address(RVA = "0x23CB590", Offset = "0x23CA190", VA = "0x1823CB590", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06028707 RID: 165639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028707")]
		[Address(RVA = "0x23CB0E0", Offset = "0x23C9CE0", VA = "0x1823CB0E0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028708 RID: 165640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028708")]
		[Address(RVA = "0x23CBC80", Offset = "0x23CA880", VA = "0x1823CBC80")]
		private void _OnSkinRewardPreviewClick(string id)
		{
		}

		// Token: 0x06028709 RID: 165641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028709")]
		[Address(RVA = "0x23CB220", Offset = "0x23C9E20", VA = "0x1823CB220")]
		public void OnMilestoneAllRewardClick()
		{
		}

		// Token: 0x0602870A RID: 165642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602870A")]
		[Address(RVA = "0x23CB800", Offset = "0x23CA400", VA = "0x1823CB800")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602870B RID: 165643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602870B")]
		[Address(RVA = "0x23CB6E0", Offset = "0x23CA2E0", VA = "0x1823CB6E0")]
		private void _EventOnClickReturnBtn()
		{
		}

		// Token: 0x0602870C RID: 165644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602870C")]
		[Address(RVA = "0x23CB950", Offset = "0x23CA550", VA = "0x1823CB950")]
		private void _OnMilestoneItemClick(string milestoneId)
		{
		}

		// Token: 0x0602870D RID: 165645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602870D")]
		[Address(RVA = "0x23CBD10", Offset = "0x23CA910", VA = "0x1823CBD10")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602870E RID: 165646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602870E")]
		[Address(RVA = "0x23CBDC0", Offset = "0x23CA9C0", VA = "0x1823CBDC0")]
		public ActMultiV3MilestoneState()
		{
		}

		// Token: 0x06028710 RID: 165648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028710")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028711 RID: 165649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028711")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06028712 RID: 165650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028712")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0403986A RID: 235626
		[Token(Token = "0x403986A")]
		[NonSerialized]
		public const int MSG_MILESTONE_CLICK = 1;

		// Token: 0x0403986B RID: 235627
		[Token(Token = "0x403986B")]
		[NonSerialized]
		public const int MSG_MILESTONE_SKIN_CHECK = 2;

		// Token: 0x0403986C RID: 235628
		[Token(Token = "0x403986C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3TemplateMilestoneViewAdapter _view;

		// Token: 0x0403986D RID: 235629
		[Token(Token = "0x403986D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403986E RID: 235630
		[Token(Token = "0x403986E")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403986F RID: 235631
		[Token(Token = "0x403986F")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039870 RID: 235632
		[Token(Token = "0x4039870")]
		[FieldOffset(Offset = "0x98")]
		private ActMultiV3MileStoneStateBean m_stateBean;

		// Token: 0x04039871 RID: 235633
		[Token(Token = "0x4039871")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039872 RID: 235634
		[Token(Token = "0x4039872")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039873 RID: 235635
		[Token(Token = "0x4039873")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04039874 RID: 235636
		[Token(Token = "0x4039874")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04039875 RID: 235637
		[Token(Token = "0x4039875")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04039876 RID: 235638
		[Token(Token = "0x4039876")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSkinRewardPreviewClick;

		// Token: 0x04039877 RID: 235639
		[Token(Token = "0x4039877")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMilestoneAllRewardClick;

		// Token: 0x04039878 RID: 235640
		[Token(Token = "0x4039878")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039879 RID: 235641
		[Token(Token = "0x4039879")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnClickReturnBtn;

		// Token: 0x0403987A RID: 235642
		[Token(Token = "0x403987A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnMilestoneItemClick;

		// Token: 0x0403987B RID: 235643
		[Token(Token = "0x403987B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403987C RID: 235644
		[Token(Token = "0x403987C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
