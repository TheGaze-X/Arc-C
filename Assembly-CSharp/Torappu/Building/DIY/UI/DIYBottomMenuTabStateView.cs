using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019BE RID: 6590
	[Token(Token = "0x20019BE")]
	public abstract class DIYBottomMenuTabStateView : DataBinder<DIYMenuProperty>
	{
		// Token: 0x0600A58C RID: 42380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A58C")]
		[Address(RVA = "0x31ED200", Offset = "0x31EBE00", VA = "0x1831ED200", Slot = "8")]
		public virtual void ShowImmediately()
		{
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A58D")]
		[Address(RVA = "0x31ED0E0", Offset = "0x31EBCE0", VA = "0x1831ED0E0", Slot = "9")]
		public virtual void HideImmediately()
		{
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A58E")]
		[Address(RVA = "0x31ED1A0", Offset = "0x31EBDA0", VA = "0x1831ED1A0", Slot = "10")]
		public virtual Tween PlayShowTween()
		{
			return null;
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A58F")]
		[Address(RVA = "0x31ED140", Offset = "0x31EBD40", VA = "0x1831ED140", Slot = "11")]
		public virtual Tween PlayHideTween()
		{
			return null;
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A590")]
		[Address(RVA = "0x31ED260", Offset = "0x31EBE60", VA = "0x1831ED260")]
		protected DIYBottomMenuTabStateView()
		{
		}

		// Token: 0x04009D4E RID: 40270
		[Token(Token = "0x4009D4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04009D4F RID: 40271
		[Token(Token = "0x4009D4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04009D50 RID: 40272
		[Token(Token = "0x4009D50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayShowTween;

		// Token: 0x04009D51 RID: 40273
		[Token(Token = "0x4009D51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayHideTween;

		// Token: 0x04009D52 RID: 40274
		[Token(Token = "0x4009D52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
