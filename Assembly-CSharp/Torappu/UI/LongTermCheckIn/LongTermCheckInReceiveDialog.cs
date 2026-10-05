using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049BF RID: 18879
	[Token(Token = "0x20049BF")]
	public class LongTermCheckInReceiveDialog : LongTermCheckInDialogBase, IHotfixable
	{
		// Token: 0x0601C70D RID: 116493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C70D")]
		[Address(RVA = "0x15E5400", Offset = "0x15E4000", VA = "0x1815E5400", Slot = "19")]
		protected override void Init()
		{
		}

		// Token: 0x0601C70E RID: 116494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C70E")]
		[Address(RVA = "0x15E54E0", Offset = "0x15E40E0", VA = "0x1815E54E0", Slot = "18")]
		protected override void OnRender(object input)
		{
		}

		// Token: 0x0601C70F RID: 116495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C70F")]
		[Address(RVA = "0x15E5140", Offset = "0x15E3D40", VA = "0x1815E5140", Slot = "20")]
		protected override void EventOnBackPressed()
		{
		}

		// Token: 0x0601C710 RID: 116496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C710")]
		[Address(RVA = "0x15E51A0", Offset = "0x15E3DA0", VA = "0x1815E51A0")]
		public void EventOnReceiveClicked()
		{
		}

		// Token: 0x0601C711 RID: 116497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C711")]
		[Address(RVA = "0x15E56C0", Offset = "0x15E42C0", VA = "0x1815E56C0")]
		private void _RenderReward()
		{
		}

		// Token: 0x0601C712 RID: 116498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C712")]
		[Address(RVA = "0x15E5580", Offset = "0x15E4180", VA = "0x1815E5580")]
		private void _HandleReceiveResponse(ReceiveLongTermCheckInRewardResponse response)
		{
		}

		// Token: 0x0601C713 RID: 116499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C713")]
		[Address(RVA = "0x15E5870", Offset = "0x15E4470", VA = "0x1815E5870")]
		public LongTermCheckInReceiveDialog()
		{
		}

		// Token: 0x04025446 RID: 152646
		[Token(Token = "0x4025446")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x04025447 RID: 152647
		[Token(Token = "0x4025447")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _loopDelay;

		// Token: 0x04025448 RID: 152648
		[Token(Token = "0x4025448")]
		[FieldOffset(Offset = "0xC8")]
		private LongTermCheckInViewModel m_viewModel;

		// Token: 0x04025449 RID: 152649
		[Token(Token = "0x4025449")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402544A RID: 152650
		[Token(Token = "0x402544A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402544B RID: 152651
		[Token(Token = "0x402544B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402544C RID: 152652
		[Token(Token = "0x402544C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackPressed;

		// Token: 0x0402544D RID: 152653
		[Token(Token = "0x402544D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnReceiveClicked;

		// Token: 0x0402544E RID: 152654
		[Token(Token = "0x402544E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderReward;

		// Token: 0x0402544F RID: 152655
		[Token(Token = "0x402544F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleReceiveResponse;

		// Token: 0x04025450 RID: 152656
		[Token(Token = "0x4025450")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
