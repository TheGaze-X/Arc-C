using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062BE RID: 25278
	[Token(Token = "0x20062BE")]
	public class AutoChessConfirmDialogInPage : UICompDialog<AutoChessConfirmDialogInPage.Option>
	{
		// Token: 0x060246B4 RID: 149172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246B4")]
		[Address(RVA = "0x1F3B640", Offset = "0x1F3A240", VA = "0x181F3B640", Slot = "18")]
		protected override void OnRender(AutoChessConfirmDialogInPage.Option options)
		{
		}

		// Token: 0x060246B5 RID: 149173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60246B5")]
		[Address(RVA = "0x1F3B5D0", Offset = "0x1F3A1D0", VA = "0x181F3B5D0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060246B6 RID: 149174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246B6")]
		[Address(RVA = "0x1F3C070", Offset = "0x1F3AC70", VA = "0x181F3C070")]
		private void _ShowView(AutoChessConfirmDialogConfig config)
		{
		}

		// Token: 0x060246B7 RID: 149175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246B7")]
		[Address(RVA = "0x1F3BAE0", Offset = "0x1F3A6E0", VA = "0x181F3BAE0")]
		private void _ShowConfirmWithCancelView(AutoChessConfirmDialogConfig config)
		{
		}

		// Token: 0x060246B8 RID: 149176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246B8")]
		[Address(RVA = "0x1F3BE00", Offset = "0x1F3AA00", VA = "0x181F3BE00")]
		private void _ShowOnlyConfirmView(AutoChessConfirmDialogConfig config)
		{
		}

		// Token: 0x060246B9 RID: 149177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246B9")]
		[Address(RVA = "0x1F3B9E0", Offset = "0x1F3A5E0", VA = "0x181F3B9E0")]
		private void _OnConfirm()
		{
		}

		// Token: 0x060246BA RID: 149178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246BA")]
		[Address(RVA = "0x1F3B8E0", Offset = "0x1F3A4E0", VA = "0x181F3B8E0")]
		private void _OnCancel()
		{
		}

		// Token: 0x060246BB RID: 149179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246BB")]
		[Address(RVA = "0x1F3C210", Offset = "0x1F3AE10", VA = "0x181F3C210")]
		public AutoChessConfirmDialogInPage()
		{
		}

		// Token: 0x060246BD RID: 149181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60246BD")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x04032B01 RID: 207617
		[Token(Token = "0x4032B01")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x04032B02 RID: 207618
		[Token(Token = "0x4032B02")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _viewHolder;

		// Token: 0x04032B03 RID: 207619
		[Token(Token = "0x4032B03")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AutoChessConfirmDialogView _confirmWithCancelViewPrefab;

		// Token: 0x04032B04 RID: 207620
		[Token(Token = "0x4032B04")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AutoChessConfirmDialogView _onlyConfirmViewPrefab;

		// Token: 0x04032B05 RID: 207621
		[Token(Token = "0x4032B05")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static int CANCEL;

		// Token: 0x04032B06 RID: 207622
		[Token(Token = "0x4032B06")]
		[FieldOffset(Offset = "0x4")]
		[NonSerialized]
		public static int CONFIRM;

		// Token: 0x04032B07 RID: 207623
		[Token(Token = "0x4032B07")]
		[FieldOffset(Offset = "0x90")]
		private AutoChessConfirmDialogView m_confirmWithCancelView;

		// Token: 0x04032B08 RID: 207624
		[Token(Token = "0x4032B08")]
		[FieldOffset(Offset = "0x98")]
		private AutoChessConfirmDialogView m_onlyConfirmView;

		// Token: 0x04032B09 RID: 207625
		[Token(Token = "0x4032B09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04032B0A RID: 207626
		[Token(Token = "0x4032B0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04032B0B RID: 207627
		[Token(Token = "0x4032B0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowView;

		// Token: 0x04032B0C RID: 207628
		[Token(Token = "0x4032B0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowConfirmWithCancelView;

		// Token: 0x04032B0D RID: 207629
		[Token(Token = "0x4032B0D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowOnlyConfirmView;

		// Token: 0x04032B0E RID: 207630
		[Token(Token = "0x4032B0E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnConfirm;

		// Token: 0x04032B0F RID: 207631
		[Token(Token = "0x4032B0F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x04032B10 RID: 207632
		[Token(Token = "0x4032B10")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062BF RID: 25279
		[Token(Token = "0x20062BF")]
		public class Option
		{
			// Token: 0x060246BE RID: 149182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04032B11 RID: 207633
			[Token(Token = "0x4032B11")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessConfirmDialogConfig config;
		}
	}
}
