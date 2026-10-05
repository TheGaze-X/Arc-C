using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F18 RID: 16152
	[Token(Token = "0x2003F18")]
	public class SiracusaCharTaskRingRewardState : PopupFloatState, ISiracusaReplaceable
	{
		// Token: 0x06019148 RID: 102728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019148")]
		[Address(RVA = "0x11B5390", Offset = "0x11B3F90", VA = "0x1811B5390", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019149 RID: 102729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019149")]
		[Address(RVA = "0x11B53F0", Offset = "0x11B3FF0", VA = "0x1811B53F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601914A RID: 102730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601914A")]
		[Address(RVA = "0x11B56B0", Offset = "0x11B42B0", VA = "0x1811B56B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601914B RID: 102731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601914B")]
		[Address(RVA = "0x11B4CE0", Offset = "0x11B38E0", VA = "0x1811B4CE0", Slot = "27")]
		protected sealed override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601914C RID: 102732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601914C")]
		[Address(RVA = "0x11B4E30", Offset = "0x11B3A30", VA = "0x1811B4E30", Slot = "28")]
		protected sealed override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601914D RID: 102733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601914D")]
		[Address(RVA = "0x11B4F80", Offset = "0x11B3B80", VA = "0x1811B4F80")]
		public void EventOnBtnReward()
		{
		}

		// Token: 0x0601914E RID: 102734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601914E")]
		[Address(RVA = "0x11B5790", Offset = "0x11B4390", VA = "0x1811B5790")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0601914F RID: 102735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601914F")]
		[Address(RVA = "0x11B5840", Offset = "0x11B4440", VA = "0x1811B5840")]
		public SiracusaCharTaskRingRewardState()
		{
		}

		// Token: 0x06019150 RID: 102736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019150")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019151 RID: 102737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019151")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06019152 RID: 102738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019152")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x06019153 RID: 102739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019153")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x0401F083 RID: 127107
		[Token(Token = "0x401F083")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SiracusaCharTaskRingRewardView _view;

		// Token: 0x0401F084 RID: 127108
		[Token(Token = "0x401F084")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0401F085 RID: 127109
		[Token(Token = "0x401F085")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F086 RID: 127110
		[Token(Token = "0x401F086")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F087 RID: 127111
		[Token(Token = "0x401F087")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401F088 RID: 127112
		[Token(Token = "0x401F088")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x0401F089 RID: 127113
		[Token(Token = "0x401F089")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x0401F08A RID: 127114
		[Token(Token = "0x401F08A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBtnReward;

		// Token: 0x0401F08B RID: 127115
		[Token(Token = "0x401F08B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0401F08C RID: 127116
		[Token(Token = "0x401F08C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
