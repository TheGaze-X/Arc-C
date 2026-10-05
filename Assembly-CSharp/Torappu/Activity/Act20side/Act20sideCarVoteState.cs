using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200766A RID: 30314
	[Token(Token = "0x200766A")]
	public class Act20sideCarVoteState : PopupFadeState
	{
		// Token: 0x0602AA33 RID: 174643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA33")]
		[Address(RVA = "0x266CB60", Offset = "0x266B760", VA = "0x18266CB60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AA34 RID: 174644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA34")]
		[Address(RVA = "0x266CBC0", Offset = "0x266B7C0", VA = "0x18266CBC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AA35 RID: 174645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA35")]
		[Address(RVA = "0x266CE90", Offset = "0x266BA90", VA = "0x18266CE90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA36 RID: 174646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA36")]
		[Address(RVA = "0x266D100", Offset = "0x266BD00", VA = "0x18266D100")]
		private void _UpdateCarVoteProperty(bool updateNext = false)
		{
		}

		// Token: 0x0602AA37 RID: 174647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA37")]
		[Address(RVA = "0x266D370", Offset = "0x266BF70", VA = "0x18266D370")]
		private void _Vote(int index)
		{
		}

		// Token: 0x0602AA38 RID: 174648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA38")]
		[Address(RVA = "0x266D020", Offset = "0x266BC20", VA = "0x18266D020")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602AA39 RID: 174649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA39")]
		[Address(RVA = "0x266C9D0", Offset = "0x266B5D0", VA = "0x18266C9D0")]
		public void EventOnVoteClick(int index)
		{
		}

		// Token: 0x0602AA3A RID: 174650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA3A")]
		[Address(RVA = "0x266C890", Offset = "0x266B490", VA = "0x18266C890")]
		public void EventOnPlayerClick(int index)
		{
		}

		// Token: 0x0602AA3B RID: 174651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA3B")]
		[Address(RVA = "0x266C4A0", Offset = "0x266B0A0", VA = "0x18266C4A0")]
		public void EventOnCarDetailClick(int index)
		{
		}

		// Token: 0x0602AA3C RID: 174652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA3C")]
		[Address(RVA = "0x266C660", Offset = "0x266B260", VA = "0x18266C660")]
		public void EventOnDetailDismiss()
		{
		}

		// Token: 0x0602AA3D RID: 174653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA3D")]
		[Address(RVA = "0x266C6D0", Offset = "0x266B2D0", VA = "0x18266C6D0")]
		public void EventOnFriendRequestSuc(string uid)
		{
		}

		// Token: 0x0602AA3E RID: 174654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA3E")]
		[Address(RVA = "0x266C390", Offset = "0x266AF90", VA = "0x18266C390")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x0602AA3F RID: 174655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA3F")]
		[Address(RVA = "0x266D6C0", Offset = "0x266C2C0", VA = "0x18266D6C0")]
		public Act20sideCarVoteState()
		{
		}

		// Token: 0x0602AA42 RID: 174658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA42")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403D68E RID: 251534
		[Token(Token = "0x403D68E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act20sideCarVoteView _carVoteView;

		// Token: 0x0403D68F RID: 251535
		[Token(Token = "0x403D68F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act20sideCarVotePlayerDetailView _detailView;

		// Token: 0x0403D690 RID: 251536
		[Token(Token = "0x403D690")]
		[FieldOffset(Offset = "0x80")]
		private Act20sideCarVoteStateBean m_stateBean;

		// Token: 0x0403D691 RID: 251537
		[Token(Token = "0x403D691")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0403D692 RID: 251538
		[Token(Token = "0x403D692")]
		[FieldOffset(Offset = "0x89")]
		private bool m_playEnterAnim;

		// Token: 0x0403D693 RID: 251539
		[Token(Token = "0x403D693")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedActId;

		// Token: 0x0403D694 RID: 251540
		[Token(Token = "0x403D694")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D695 RID: 251541
		[Token(Token = "0x403D695")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D696 RID: 251542
		[Token(Token = "0x403D696")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D697 RID: 251543
		[Token(Token = "0x403D697")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateCarVoteProperty;

		// Token: 0x0403D698 RID: 251544
		[Token(Token = "0x403D698")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Vote;

		// Token: 0x0403D699 RID: 251545
		[Token(Token = "0x403D699")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403D69A RID: 251546
		[Token(Token = "0x403D69A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnVoteClick;

		// Token: 0x0403D69B RID: 251547
		[Token(Token = "0x403D69B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnPlayerClick;

		// Token: 0x0403D69C RID: 251548
		[Token(Token = "0x403D69C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnCarDetailClick;

		// Token: 0x0403D69D RID: 251549
		[Token(Token = "0x403D69D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnDetailDismiss;

		// Token: 0x0403D69E RID: 251550
		[Token(Token = "0x403D69E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnFriendRequestSuc;

		// Token: 0x0403D69F RID: 251551
		[Token(Token = "0x403D69F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x0403D6A0 RID: 251552
		[Token(Token = "0x403D6A0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
