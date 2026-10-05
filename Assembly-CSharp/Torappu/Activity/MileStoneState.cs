using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D88 RID: 28040
	[Token(Token = "0x2006D88")]
	public abstract class MileStoneState : PopupFadeState
	{
		// Token: 0x06027F18 RID: 163608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F18")]
		[Address(RVA = "0x2342B00", Offset = "0x2341700", VA = "0x182342B00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027F19 RID: 163609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F19")]
		[Address(RVA = "0x2342B60", Offset = "0x2341760", VA = "0x182342B60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027F1A RID: 163610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F1A")]
		[Address(RVA = "0x2343090", Offset = "0x2341C90", VA = "0x182343090", Slot = "30")]
		protected override IEnumerator WaitForLoading()
		{
			return null;
		}

		// Token: 0x06027F1B RID: 163611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F1B")]
		[Address(RVA = "0x2342E10", Offset = "0x2341A10", VA = "0x182342E10")]
		public void SendItemRequest(string rewardId)
		{
		}

		// Token: 0x06027F1C RID: 163612
		[Token(Token = "0x6027F1C")]
		protected abstract string GetMileStoneServiceCode();

		// Token: 0x06027F1D RID: 163613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F1D")]
		[Address(RVA = "0x2343120", Offset = "0x2341D20", VA = "0x182343120")]
		private void _SendItemRequest(string rewardId)
		{
		}

		// Token: 0x06027F1E RID: 163614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F1E")]
		[Address(RVA = "0x2342D20", Offset = "0x2341920", VA = "0x182342D20")]
		public static IEnumerator ReceiveItemsCoroutine(List<ActivityItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06027F1F RID: 163615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F1F")]
		[Address(RVA = "0x2343420", Offset = "0x2342020", VA = "0x182343420")]
		protected MileStoneState()
		{
		}

		// Token: 0x06027F21 RID: 163617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F21")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06027F22 RID: 163618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F22")]
		[Address(RVA = "0x2342E90", Offset = "0x2341A90", VA = "0x182342E90")]
		private IEnumerator <>xLuaBaseProxy_WaitForLoading()
		{
			return null;
		}

		// Token: 0x040389CE RID: 231886
		[Token(Token = "0x40389CE")]
		private const int PRELOAD_FRAME_CNT = 3;

		// Token: 0x040389CF RID: 231887
		[Token(Token = "0x40389CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MileStoneStateBean _stateBean;

		// Token: 0x040389D0 RID: 231888
		[Token(Token = "0x40389D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MileStoneHolder _view;

		// Token: 0x040389D1 RID: 231889
		[Token(Token = "0x40389D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040389D2 RID: 231890
		[Token(Token = "0x40389D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040389D3 RID: 231891
		[Token(Token = "0x40389D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_WaitForLoading;

		// Token: 0x040389D4 RID: 231892
		[Token(Token = "0x40389D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendItemRequest;

		// Token: 0x040389D5 RID: 231893
		[Token(Token = "0x40389D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendItemRequest;

		// Token: 0x040389D6 RID: 231894
		[Token(Token = "0x40389D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x040389D7 RID: 231895
		[Token(Token = "0x40389D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
