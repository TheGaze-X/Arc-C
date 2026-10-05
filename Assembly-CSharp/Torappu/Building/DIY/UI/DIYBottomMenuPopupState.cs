using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B9 RID: 6585
	[Token(Token = "0x20019B9")]
	public abstract class DIYBottomMenuPopupState : UIPopupState
	{
		// Token: 0x0600A576 RID: 42358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A576")]
		[Address(RVA = "0x31EBE40", Offset = "0x31EAA40", VA = "0x1831EBE40", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A577")]
		[Address(RVA = "0x31EBF80", Offset = "0x31EAB80", VA = "0x1831EBF80", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A578")]
		[Address(RVA = "0x31EC0F0", Offset = "0x31EACF0", VA = "0x1831EC0F0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A579")]
		[Address(RVA = "0x31EC230", Offset = "0x31EAE30", VA = "0x1831EC230", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A57A")]
		[Address(RVA = "0x31EC3A0", Offset = "0x31EAFA0", VA = "0x1831EC3A0")]
		protected DIYBottomMenuPopupState()
		{
		}

		// Token: 0x04009D3C RID: 40252
		[Token(Token = "0x4009D3C")]
		private const float INIT_POS_Y = 0f;

		// Token: 0x04009D3D RID: 40253
		[Token(Token = "0x4009D3D")]
		private const float MOVE_OFFSET_Y = 25f;

		// Token: 0x04009D3E RID: 40254
		[Token(Token = "0x4009D3E")]
		private const float ANIM_DURATION = 0.25f;

		// Token: 0x04009D3F RID: 40255
		[Token(Token = "0x4009D3F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _animPanel;

		// Token: 0x04009D40 RID: 40256
		[Token(Token = "0x4009D40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04009D41 RID: 40257
		[Token(Token = "0x4009D41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04009D42 RID: 40258
		[Token(Token = "0x4009D42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04009D43 RID: 40259
		[Token(Token = "0x4009D43")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04009D44 RID: 40260
		[Token(Token = "0x4009D44")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
