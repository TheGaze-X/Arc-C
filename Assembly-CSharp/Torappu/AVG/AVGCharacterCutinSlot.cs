using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F48 RID: 8008
	[Token(Token = "0x2001F48")]
	public class AVGCharacterCutinSlot : MonoBehaviour, IReusable, IFadeTimeRatio
	{
		// Token: 0x0600C711 RID: 50961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C711")]
		[Address(RVA = "0x34746F0", Offset = "0x34732F0", VA = "0x1834746F0")]
		public void Show(Command command, Action onShowEnd)
		{
		}

		// Token: 0x0600C712 RID: 50962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C712")]
		[Address(RVA = "0x34754E0", Offset = "0x34740E0", VA = "0x1834754E0")]
		public void SlotUpdate(Command command, Action onShowEnd)
		{
		}

		// Token: 0x0600C713 RID: 50963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C713")]
		[Address(RVA = "0x3474150", Offset = "0x3472D50", VA = "0x183474150")]
		public void Hide(Command command, Action onShowEnd)
		{
		}

		// Token: 0x0600C714 RID: 50964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C714")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x0600C715 RID: 50965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C715")]
		[Address(RVA = "0x34746A0", Offset = "0x34732A0", VA = "0x1834746A0", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x0600C716 RID: 50966 RVA: 0x000489A8 File Offset: 0x00046BA8
		[Token(Token = "0x600C716")]
		[Address(RVA = "0x34740F0", Offset = "0x3472CF0", VA = "0x1834740F0", Slot = "6")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C717 RID: 50967 RVA: 0x000489C0 File Offset: 0x00046BC0
		[Token(Token = "0x600C717")]
		[Address(RVA = "0x3474650", Offset = "0x3473250", VA = "0x183474650", Slot = "7")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C718 RID: 50968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C718")]
		[Address(RVA = "0x3475970", Offset = "0x3474570", VA = "0x183475970")]
		public AVGCharacterCutinSlot()
		{
		}

		// Token: 0x0400CCBB RID: 52411
		[Token(Token = "0x400CCBB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400CCBC RID: 52412
		[Token(Token = "0x400CCBC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _offsetTransform;

		// Token: 0x0400CCBD RID: 52413
		[Token(Token = "0x400CCBD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _maskRectTransform;

		// Token: 0x0400CCBE RID: 52414
		[Token(Token = "0x400CCBE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _zoomAndPovRectTransform;

		// Token: 0x0400CCBF RID: 52415
		[Token(Token = "0x400CCBF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _defualtBackground;

		// Token: 0x0400CCC0 RID: 52416
		[Token(Token = "0x400CCC0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _backgroundRectTransform;

		// Token: 0x0400CCC1 RID: 52417
		[Token(Token = "0x400CCC1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400CCC2 RID: 52418
		[Token(Token = "0x400CCC2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGCharacterSlot _characterSlot;

		// Token: 0x0400CCC3 RID: 52419
		[Token(Token = "0x400CCC3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _defaultFadetime;

		// Token: 0x0400CCC4 RID: 52420
		[Token(Token = "0x400CCC4")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int _defaultSlotWidth;

		// Token: 0x0400CCC5 RID: 52421
		[Token(Token = "0x400CCC5")]
		[FieldOffset(Offset = "0x60")]
		private AVGCharacterCutinSlot.Align m_align;

		// Token: 0x0400CCC6 RID: 52422
		[Token(Token = "0x400CCC6")]
		[FieldOffset(Offset = "0x64")]
		private AVGCharacterCutinSlot.FadeStyle m_showFadeStyle;

		// Token: 0x02001F49 RID: 8009
		[Token(Token = "0x2001F49")]
		public enum Align
		{
			// Token: 0x0400CCC8 RID: 52424
			[Token(Token = "0x400CCC8")]
			HORIZONTAL,
			// Token: 0x0400CCC9 RID: 52425
			[Token(Token = "0x400CCC9")]
			VERTICAL
		}

		// Token: 0x02001F4A RID: 8010
		[Token(Token = "0x2001F4A")]
		public enum FadeStyle
		{
			// Token: 0x0400CCCB RID: 52427
			[Token(Token = "0x400CCCB")]
			fade,
			// Token: 0x0400CCCC RID: 52428
			[Token(Token = "0x400CCCC")]
			horiz_expand_center,
			// Token: 0x0400CCCD RID: 52429
			[Token(Token = "0x400CCCD")]
			horiz_expand_left2right,
			// Token: 0x0400CCCE RID: 52430
			[Token(Token = "0x400CCCE")]
			horiz_expand_right2left,
			// Token: 0x0400CCCF RID: 52431
			[Token(Token = "0x400CCCF")]
			vert_expand_center,
			// Token: 0x0400CCD0 RID: 52432
			[Token(Token = "0x400CCD0")]
			vert_expand_top2bottom,
			// Token: 0x0400CCD1 RID: 52433
			[Token(Token = "0x400CCD1")]
			vert_expand_bottom2top
		}
	}
}
