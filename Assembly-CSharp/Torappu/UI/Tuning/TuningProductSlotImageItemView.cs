using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CE1 RID: 15585
	[Token(Token = "0x2003CE1")]
	public class TuningProductSlotImageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060184BD RID: 99517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184BD")]
		[Address(RVA = "0x10CD0E0", Offset = "0x10CBCE0", VA = "0x1810CD0E0")]
		public void Render(string imageName)
		{
		}

		// Token: 0x060184BE RID: 99518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184BE")]
		[Address(RVA = "0x10CD2B0", Offset = "0x10CBEB0", VA = "0x1810CD2B0")]
		private void _SetIfShow(bool isShow, bool isChangeSprite)
		{
		}

		// Token: 0x060184BF RID: 99519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184BF")]
		[Address(RVA = "0x10CD1E0", Offset = "0x10CBDE0", VA = "0x1810CD1E0")]
		private void _LoadSprite()
		{
		}

		// Token: 0x060184C0 RID: 99520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184C0")]
		[Address(RVA = "0x10CD550", Offset = "0x10CC150", VA = "0x1810CD550")]
		public TuningProductSlotImageItemView()
		{
		}

		// Token: 0x0401DABF RID: 121535
		[Token(Token = "0x401DABF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _slotImage;

		// Token: 0x0401DAC0 RID: 121536
		[Token(Token = "0x401DAC0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _imgShowAlpha;

		// Token: 0x0401DAC1 RID: 121537
		[Token(Token = "0x401DAC1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _imgHideAlpha;

		// Token: 0x0401DAC2 RID: 121538
		[Token(Token = "0x401DAC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _imgTweenDuration;

		// Token: 0x0401DAC3 RID: 121539
		[Token(Token = "0x401DAC3")]
		[FieldOffset(Offset = "0x30")]
		private Sequence m_sequence;

		// Token: 0x0401DAC4 RID: 121540
		[Token(Token = "0x401DAC4")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedImageName;

		// Token: 0x0401DAC5 RID: 121541
		[Token(Token = "0x401DAC5")]
		[FieldOffset(Offset = "0x40")]
		private bool m_cachedIsShow;

		// Token: 0x0401DAC6 RID: 121542
		[Token(Token = "0x401DAC6")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401DAC7 RID: 121543
		[Token(Token = "0x401DAC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DAC8 RID: 121544
		[Token(Token = "0x401DAC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetIfShow;

		// Token: 0x0401DAC9 RID: 121545
		[Token(Token = "0x401DAC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0401DACA RID: 121546
		[Token(Token = "0x401DACA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
