using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	internal struct ColorTween : ITweenValue
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public Color startColor
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x4007430", Offset = "0x4006030", VA = "0x184007430")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x4C97D60", Offset = "0x4C96960", VA = "0x184C97D60")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002748 File Offset: 0x00000948
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public Color targetColor
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x36B1B50", Offset = "0x36B0750", VA = "0x1836B1B50")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public ColorTween.ColorTweenMode tweenMode
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return ColorTween.ColorTweenMode.All;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002778 File Offset: 0x00000978
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public float duration
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002790 File Offset: 0x00000990
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x5880140", Offset = "0x587ED40", VA = "0x185880140", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5880080", Offset = "0x587EC80", VA = "0x185880080")]
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
		public float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x0")]
		private ColorTween.ColorTweenCallback m_Target;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x8")]
		private Color m_StartColor;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x18")]
		private Color m_TargetColor;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x28")]
		private ColorTween.ColorTweenMode m_TweenMode;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Duration;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IgnoreTimeScale;

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public enum ColorTweenMode
		{
			// Token: 0x04000166 RID: 358
			[Token(Token = "0x4000166")]
			All,
			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000167")]
			RGB,
			// Token: 0x04000168 RID: 360
			[Token(Token = "0x4000168")]
			Alpha
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		public class ColorTweenCallback : UnityEvent<Color>
		{
			// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x5880040", Offset = "0x587EC40", VA = "0x185880040")]
			public ColorTweenCallback()
			{
			}
		}
	}
}
