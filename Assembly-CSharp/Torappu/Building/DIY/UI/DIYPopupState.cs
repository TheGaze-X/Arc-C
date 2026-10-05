using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019C5 RID: 6597
	[Token(Token = "0x20019C5")]
	public abstract class DIYPopupState : UIPopupState
	{
		// Token: 0x0600A5AA RID: 42410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5AA")]
		[Address(RVA = "0x31F2420", Offset = "0x31F1020", VA = "0x1831F2420", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5AB")]
		[Address(RVA = "0x31F2560", Offset = "0x31F1160", VA = "0x1831F2560", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5AC")]
		[Address(RVA = "0x31F26C0", Offset = "0x31F12C0", VA = "0x1831F26C0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5AD")]
		[Address(RVA = "0x31F2800", Offset = "0x31F1400", VA = "0x1831F2800", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5AE")]
		[Address(RVA = "0x31F2960", Offset = "0x31F1560", VA = "0x1831F2960")]
		protected DIYPopupState()
		{
		}

		// Token: 0x04009D75 RID: 40309
		[Token(Token = "0x4009D75")]
		private const float INIT_POS_Y = 15.5f;

		// Token: 0x04009D76 RID: 40310
		[Token(Token = "0x4009D76")]
		private const float MOVE_OFFSET_Y = 50f;

		// Token: 0x04009D77 RID: 40311
		[Token(Token = "0x4009D77")]
		private const float ANIM_DURATION = 0.25f;

		// Token: 0x04009D78 RID: 40312
		[Token(Token = "0x4009D78")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _animPanel;

		// Token: 0x04009D79 RID: 40313
		[Token(Token = "0x4009D79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04009D7A RID: 40314
		[Token(Token = "0x4009D7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04009D7B RID: 40315
		[Token(Token = "0x4009D7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04009D7C RID: 40316
		[Token(Token = "0x4009D7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04009D7D RID: 40317
		[Token(Token = "0x4009D7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
