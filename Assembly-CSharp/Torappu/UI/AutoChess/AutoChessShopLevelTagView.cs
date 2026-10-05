using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200634D RID: 25421
	[Token(Token = "0x200634D")]
	public class AutoChessShopLevelTagView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024ADF RID: 150239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ADF")]
		[Address(RVA = "0x1F89720", Offset = "0x1F88320", VA = "0x181F89720")]
		public void Render(AutoChessShopLevelTagViewModel tagViewModel)
		{
		}

		// Token: 0x06024AE0 RID: 150240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AE0")]
		[Address(RVA = "0x1F89A00", Offset = "0x1F88600", VA = "0x181F89A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024AE1 RID: 150241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AE1")]
		[Address(RVA = "0x1F89B50", Offset = "0x1F88750", VA = "0x181F89B50")]
		public AutoChessShopLevelTagView()
		{
		}

		// Token: 0x0403330F RID: 209679
		[Token(Token = "0x403330F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgDescDown;

		// Token: 0x04033310 RID: 209680
		[Token(Token = "0x4033310")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgTag;

		// Token: 0x04033311 RID: 209681
		[Token(Token = "0x4033311")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasCharDesc;

		// Token: 0x04033312 RID: 209682
		[Token(Token = "0x4033312")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasItemDesc;

		// Token: 0x04033313 RID: 209683
		[Token(Token = "0x4033313")]
		[FieldOffset(Offset = "0x38")]
		private int m_cachedLevel;

		// Token: 0x04033314 RID: 209684
		[Token(Token = "0x4033314")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_hasInited;

		// Token: 0x04033315 RID: 209685
		[Token(Token = "0x4033315")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033316 RID: 209686
		[Token(Token = "0x4033316")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_fadeSwitchTweenCharDesc;

		// Token: 0x04033317 RID: 209687
		[Token(Token = "0x4033317")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_fadeSwitchTweenItemDesc;

		// Token: 0x04033318 RID: 209688
		[Token(Token = "0x4033318")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033319 RID: 209689
		[Token(Token = "0x4033319")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403331A RID: 209690
		[Token(Token = "0x403331A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
