using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F1C RID: 20252
	[Token(Token = "0x2004F1C")]
	public class FifthAnnivExploreQuitConfirmDialog : UICompDialog<FifthAnnivExploreQuitConfirmDialog.Options>
	{
		// Token: 0x0601E2D3 RID: 123603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E2D3")]
		[Address(RVA = "0x17F17F0", Offset = "0x17F03F0", VA = "0x1817F17F0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601E2D4 RID: 123604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2D4")]
		[Address(RVA = "0x17F2260", Offset = "0x17F0E60", VA = "0x1817F2260")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E2D5 RID: 123605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2D5")]
		[Address(RVA = "0x17F2480", Offset = "0x17F1080", VA = "0x1817F2480")]
		private void _LoadData()
		{
		}

		// Token: 0x0601E2D6 RID: 123606 RVA: 0x000ADBC8 File Offset: 0x000ABDC8
		[Token(Token = "0x601E2D6")]
		[Address(RVA = "0x17F20F0", Offset = "0x17F0CF0", VA = "0x1817F20F0")]
		private bool _CheckNeedRestartBtn()
		{
			return default(bool);
		}

		// Token: 0x0601E2D7 RID: 123607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2D7")]
		[Address(RVA = "0x17F1A70", Offset = "0x17F0670", VA = "0x1817F1A70", Slot = "18")]
		protected override void OnRender(FifthAnnivExploreQuitConfirmDialog.Options input)
		{
		}

		// Token: 0x0601E2D8 RID: 123608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2D8")]
		[Address(RVA = "0x17F1FB0", Offset = "0x17F0BB0", VA = "0x1817F1FB0")]
		private void Render()
		{
		}

		// Token: 0x0601E2D9 RID: 123609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2D9")]
		[Address(RVA = "0x17F18E0", Offset = "0x17F04E0", VA = "0x1817F18E0")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x0601E2DA RID: 123610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2DA")]
		[Address(RVA = "0x17F1850", Offset = "0x17F0450", VA = "0x1817F1850")]
		public void OnCancelBtnClick()
		{
		}

		// Token: 0x0601E2DB RID: 123611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2DB")]
		[Address(RVA = "0x17F1B00", Offset = "0x17F0700", VA = "0x1817F1B00")]
		public void OnRestartBtnClick()
		{
		}

		// Token: 0x0601E2DC RID: 123612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2DC")]
		[Address(RVA = "0x17F1C30", Offset = "0x17F0830", VA = "0x1817F1C30")]
		public void OnRestartCancelBtnClick()
		{
		}

		// Token: 0x0601E2DD RID: 123613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2DD")]
		[Address(RVA = "0x17F1D60", Offset = "0x17F0960", VA = "0x1817F1D60")]
		public void OnRestartConfirmBtnClick()
		{
		}

		// Token: 0x0601E2DE RID: 123614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2DE")]
		[Address(RVA = "0x17F2640", Offset = "0x17F1240", VA = "0x1817F2640")]
		public FifthAnnivExploreQuitConfirmDialog()
		{
		}

		// Token: 0x0601E2E0 RID: 123616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E2E0")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x04028306 RID: 164614
		[Token(Token = "0x4028306")]
		public const int CONFIRM_RESTART = 1;

		// Token: 0x04028307 RID: 164615
		[Token(Token = "0x4028307")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04028308 RID: 164616
		[Token(Token = "0x4028308")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04028309 RID: 164617
		[Token(Token = "0x4028309")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _restartObj;

		// Token: 0x0402830A RID: 164618
		[Token(Token = "0x402830A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _quitCanvasGroup;

		// Token: 0x0402830B RID: 164619
		[Token(Token = "0x402830B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _restartCanvasGroup;

		// Token: 0x0402830C RID: 164620
		[Token(Token = "0x402830C")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_mainFadeSwitchTween;

		// Token: 0x0402830D RID: 164621
		[Token(Token = "0x402830D")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_quitFadeSwitchTween;

		// Token: 0x0402830E RID: 164622
		[Token(Token = "0x402830E")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_restartFadeSwitchTween;

		// Token: 0x0402830F RID: 164623
		[Token(Token = "0x402830F")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x04028310 RID: 164624
		[Token(Token = "0x4028310")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028311 RID: 164625
		[Token(Token = "0x4028311")]
		[FieldOffset(Offset = "0xC8")]
		private FifthAnnivExploreMapController m_mapController;

		// Token: 0x04028312 RID: 164626
		[Token(Token = "0x4028312")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_needRestartBtn;

		// Token: 0x04028313 RID: 164627
		[Token(Token = "0x4028313")]
		[FieldOffset(Offset = "0xD1")]
		private bool m_isShowingRestart;

		// Token: 0x04028314 RID: 164628
		[Token(Token = "0x4028314")]
		[FieldOffset(Offset = "0xD4")]
		private int m_restartConfirmInstId;

		// Token: 0x04028315 RID: 164629
		[Token(Token = "0x4028315")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04028316 RID: 164630
		[Token(Token = "0x4028316")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028317 RID: 164631
		[Token(Token = "0x4028317")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04028318 RID: 164632
		[Token(Token = "0x4028318")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckNeedRestartBtn;

		// Token: 0x04028319 RID: 164633
		[Token(Token = "0x4028319")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402831A RID: 164634
		[Token(Token = "0x402831A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402831B RID: 164635
		[Token(Token = "0x402831B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x0402831C RID: 164636
		[Token(Token = "0x402831C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCancelBtnClick;

		// Token: 0x0402831D RID: 164637
		[Token(Token = "0x402831D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRestartBtnClick;

		// Token: 0x0402831E RID: 164638
		[Token(Token = "0x402831E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRestartCancelBtnClick;

		// Token: 0x0402831F RID: 164639
		[Token(Token = "0x402831F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRestartConfirmBtnClick;

		// Token: 0x04028320 RID: 164640
		[Token(Token = "0x4028320")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F1D RID: 20253
		[Token(Token = "0x2004F1D")]
		public class Options
		{
			// Token: 0x0601E2E1 RID: 123617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2E1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}
		}
	}
}
