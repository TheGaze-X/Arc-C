using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x0200337C RID: 13180
	[Token(Token = "0x200337C")]
	public class UIFollowEpSlider : UIFollowSlider
	{
		// Token: 0x06015069 RID: 86121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015069")]
		[Address(RVA = "0xD703D0", Offset = "0xD6EFD0", VA = "0x180D703D0")]
		public void SetElementType(ElementType type)
		{
		}

		// Token: 0x0601506A RID: 86122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601506A")]
		[Address(RVA = "0xD709A0", Offset = "0xD6F5A0", VA = "0x180D709A0")]
		public void SetEpHitAnimation(ElementType type)
		{
		}

		// Token: 0x0601506B RID: 86123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601506B")]
		[Address(RVA = "0xD70530", Offset = "0xD6F130", VA = "0x180D70530")]
		public void SetEpBreakAnimation(ElementType type)
		{
		}

		// Token: 0x0601506C RID: 86124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601506C")]
		[Address(RVA = "0xD70CA0", Offset = "0xD6F8A0", VA = "0x180D70CA0")]
		public void SetSliderInRecovery(bool isInRecovery, ElementType recoveryType)
		{
		}

		// Token: 0x0601506D RID: 86125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601506D")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIFollowEpSlider()
		{
		}

		// Token: 0x0401904B RID: 102475
		[Token(Token = "0x401904B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _epAnimImage;

		// Token: 0x0401904C RID: 102476
		[Token(Token = "0x401904C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _epBreakAnimImage;

		// Token: 0x0401904D RID: 102477
		[Token(Token = "0x401904D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _epBreakAlpha;

		// Token: 0x0401904E RID: 102478
		[Token(Token = "0x401904E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _sliderFillBackImage;

		// Token: 0x0401904F RID: 102479
		[Token(Token = "0x401904F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _epIconImage;

		// Token: 0x04019050 RID: 102480
		[Token(Token = "0x4019050")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _epColorImage;

		// Token: 0x04019051 RID: 102481
		[Token(Token = "0x4019051")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIFollowEpSlider.ElementUIData[] _elementDatas;

		// Token: 0x04019052 RID: 102482
		[Token(Token = "0x4019052")]
		[FieldOffset(Offset = "0x80")]
		private Sequence m_tweenSequence;

		// Token: 0x04019053 RID: 102483
		[Token(Token = "0x4019053")]
		[FieldOffset(Offset = "0x88")]
		private Sequence m_breakTweenSequence;

		// Token: 0x04019054 RID: 102484
		[Token(Token = "0x4019054")]
		private const float EP_ANIM_DURATION = 0.3f;

		// Token: 0x04019055 RID: 102485
		[Token(Token = "0x4019055")]
		private const float EP_ANIM_TO_SCALE = 1.3f;

		// Token: 0x04019056 RID: 102486
		[Token(Token = "0x4019056")]
		private const float EP_BREAK_ANIM_DURATION = 0.5f;

		// Token: 0x04019057 RID: 102487
		[Token(Token = "0x4019057")]
		private const float EP_BREAK_ANIM_FROM_SCALE = 0.5f;

		// Token: 0x04019058 RID: 102488
		[Token(Token = "0x4019058")]
		private const float EP_BREAK_ANIM_TO_SCALE = 1.5f;

		// Token: 0x04019059 RID: 102489
		[Token(Token = "0x4019059")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inAutoRecovery;

		// Token: 0x0401905A RID: 102490
		[Token(Token = "0x401905A")]
		[FieldOffset(Offset = "0x94")]
		private ElementType m_elementType;

		// Token: 0x0200337D RID: 13181
		[Token(Token = "0x200337D")]
		[Serializable]
		public struct ElementUIData
		{
			// Token: 0x0401905B RID: 102491
			[Token(Token = "0x401905B")]
			[FieldOffset(Offset = "0x0")]
			public Color elementColor;

			// Token: 0x0401905C RID: 102492
			[Token(Token = "0x401905C")]
			[FieldOffset(Offset = "0x10")]
			public Sprite elementIcon;

			// Token: 0x0401905D RID: 102493
			[Token(Token = "0x401905D")]
			[FieldOffset(Offset = "0x18")]
			public Color epBreakColor;
		}
	}
}
