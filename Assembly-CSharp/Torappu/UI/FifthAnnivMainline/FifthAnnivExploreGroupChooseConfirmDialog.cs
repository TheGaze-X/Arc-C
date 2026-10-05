using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EBF RID: 20159
	[Token(Token = "0x2004EBF")]
	public class FifthAnnivExploreGroupChooseConfirmDialog : UICompDialog<FifthAnnivExploreGroupChooseConfirmDialog.Options>
	{
		// Token: 0x0601E153 RID: 123219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E153")]
		[Address(RVA = "0x17BC0B0", Offset = "0x17BACB0", VA = "0x1817BC0B0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601E154 RID: 123220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E154")]
		[Address(RVA = "0x17BC3E0", Offset = "0x17BAFE0", VA = "0x1817BC3E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E155 RID: 123221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E155")]
		[Address(RVA = "0x17BC290", Offset = "0x17BAE90", VA = "0x1817BC290", Slot = "18")]
		protected override void OnRender(FifthAnnivExploreGroupChooseConfirmDialog.Options input)
		{
		}

		// Token: 0x0601E156 RID: 123222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E156")]
		[Address(RVA = "0x17BC1D0", Offset = "0x17BADD0", VA = "0x1817BC1D0")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x0601E157 RID: 123223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E157")]
		[Address(RVA = "0x17BC110", Offset = "0x17BAD10", VA = "0x1817BC110")]
		public void OnCancelBtnClick()
		{
		}

		// Token: 0x0601E158 RID: 123224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E158")]
		[Address(RVA = "0x17BC4D0", Offset = "0x17BB0D0", VA = "0x1817BC4D0")]
		public FifthAnnivExploreGroupChooseConfirmDialog()
		{
		}

		// Token: 0x0601E159 RID: 123225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E159")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0402803E RID: 163902
		[Token(Token = "0x402803E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402803F RID: 163903
		[Token(Token = "0x402803F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04028040 RID: 163904
		[Token(Token = "0x4028040")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween _fadeSwitchTween;

		// Token: 0x04028041 RID: 163905
		[Token(Token = "0x4028041")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04028042 RID: 163906
		[Token(Token = "0x4028042")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028043 RID: 163907
		[Token(Token = "0x4028043")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04028044 RID: 163908
		[Token(Token = "0x4028044")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028045 RID: 163909
		[Token(Token = "0x4028045")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04028046 RID: 163910
		[Token(Token = "0x4028046")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x04028047 RID: 163911
		[Token(Token = "0x4028047")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelBtnClick;

		// Token: 0x04028048 RID: 163912
		[Token(Token = "0x4028048")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EC0 RID: 20160
		[Token(Token = "0x2004EC0")]
		public class Options
		{
			// Token: 0x0601E15A RID: 123226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E15A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}
		}
	}
}
