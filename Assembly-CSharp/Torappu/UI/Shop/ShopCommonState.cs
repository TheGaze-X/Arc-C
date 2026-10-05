using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A76 RID: 23158
	[Token(Token = "0x2005A76")]
	public abstract class ShopCommonState : UIPopupState
	{
		// Token: 0x06021B0D RID: 137997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B0D")]
		[Address(RVA = "0x1C1BA00", Offset = "0x1C1A600", VA = "0x181C1BA00")]
		protected void SetContentPartVisible(bool isShow)
		{
		}

		// Token: 0x06021B0E RID: 137998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B0E")]
		[Address(RVA = "0x1C1BAD0", Offset = "0x1C1A6D0", VA = "0x181C1BAD0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06021B0F RID: 137999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B0F")]
		[Address(RVA = "0x1C1BC10", Offset = "0x1C1A810", VA = "0x181C1BC10", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06021B10 RID: 138000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B10")]
		[Address(RVA = "0x1C1B7E0", Offset = "0x1C1A3E0", VA = "0x181C1B7E0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06021B11 RID: 138001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B11")]
		[Address(RVA = "0x1C1B910", Offset = "0x1C1A510", VA = "0x181C1B910", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06021B12 RID: 138002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B12")]
		[Address(RVA = "0x1C1B540", Offset = "0x1C1A140", VA = "0x181C1B540", Slot = "27")]
		protected override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06021B13 RID: 138003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B13")]
		[Address(RVA = "0x1C1B640", Offset = "0x1C1A240", VA = "0x181C1B640", Slot = "28")]
		protected override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06021B14 RID: 138004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B14")]
		[Address(RVA = "0x1C1BD00", Offset = "0x1C1A900", VA = "0x181C1BD00")]
		protected ShopCommonState()
		{
		}

		// Token: 0x06021B15 RID: 138005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B15")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x06021B16 RID: 138006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B16")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x0402E123 RID: 188707
		[Token(Token = "0x402E123")]
		private const float FADEIN_DUR = 0.15f;

		// Token: 0x0402E124 RID: 188708
		[Token(Token = "0x402E124")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _contentAlphaHandler;

		// Token: 0x0402E125 RID: 188709
		[Token(Token = "0x402E125")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetContentPartVisible;

		// Token: 0x0402E126 RID: 188710
		[Token(Token = "0x402E126")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402E127 RID: 188711
		[Token(Token = "0x402E127")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0402E128 RID: 188712
		[Token(Token = "0x402E128")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0402E129 RID: 188713
		[Token(Token = "0x402E129")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0402E12A RID: 188714
		[Token(Token = "0x402E12A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x0402E12B RID: 188715
		[Token(Token = "0x402E12B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x0402E12C RID: 188716
		[Token(Token = "0x402E12C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
