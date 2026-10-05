using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003998 RID: 14744
	[Token(Token = "0x2003998")]
	public abstract class PopupFadeState : UIPopupState, IInteruptInputState
	{
		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x060174E9 RID: 95465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037CD")]
		protected CanvasGroup rootView
		{
			[Token(Token = "0x60174E9")]
			[Address(RVA = "0xFAD800", Offset = "0xFAC400", VA = "0x180FAD800")]
			get
			{
				return null;
			}
		}

		// Token: 0x060174EA RID: 95466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60174EA")]
		[Address(RVA = "0xFAD450", Offset = "0xFAC050", VA = "0x180FAD450", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060174EB RID: 95467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60174EB")]
		[Address(RVA = "0xFAD110", Offset = "0xFABD10", VA = "0x180FAD110", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060174EC RID: 95468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174EC")]
		[Address(RVA = "0xFAD590", Offset = "0xFAC190", VA = "0x180FAD590", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060174ED RID: 95469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174ED")]
		[Address(RVA = "0xFAD250", Offset = "0xFABE50", VA = "0x180FAD250", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060174EE RID: 95470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174EE")]
		[Address(RVA = "0xFAD3A0", Offset = "0xFABFA0", VA = "0x180FAD3A0", Slot = "29")]
		protected virtual void SetRootViewActive(CanvasGroup rootView, bool active)
		{
		}

		// Token: 0x060174EF RID: 95471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60174EF")]
		[Address(RVA = "0xFAD710", Offset = "0xFAC310", VA = "0x180FAD710", Slot = "30")]
		protected virtual IEnumerator WaitForLoading()
		{
			return null;
		}

		// Token: 0x060174F0 RID: 95472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174F0")]
		[Address(RVA = "0xFAD7A0", Offset = "0xFAC3A0", VA = "0x180FAD7A0")]
		protected PopupFadeState()
		{
		}

		// Token: 0x0401C222 RID: 115234
		[Token(Token = "0x401C222")]
		public const float FADE_DURATION = 0.23f;

		// Token: 0x0401C223 RID: 115235
		[Token(Token = "0x401C223")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x0401C224 RID: 115236
		[Token(Token = "0x401C224")]
		[FieldOffset(Offset = "0x68")]
		private CanvasGroup m_dynCanvasGroup;

		// Token: 0x0401C225 RID: 115237
		[Token(Token = "0x401C225")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rootView;

		// Token: 0x0401C226 RID: 115238
		[Token(Token = "0x401C226")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401C227 RID: 115239
		[Token(Token = "0x401C227")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401C228 RID: 115240
		[Token(Token = "0x401C228")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0401C229 RID: 115241
		[Token(Token = "0x401C229")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0401C22A RID: 115242
		[Token(Token = "0x401C22A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetRootViewActive;

		// Token: 0x0401C22B RID: 115243
		[Token(Token = "0x401C22B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_WaitForLoading;

		// Token: 0x0401C22C RID: 115244
		[Token(Token = "0x401C22C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
