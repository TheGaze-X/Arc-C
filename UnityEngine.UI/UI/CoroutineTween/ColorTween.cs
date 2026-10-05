using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	internal struct ColorTween : ITweenValue
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017D")]
		public Color startColor
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x4007430", Offset = "0x4006030", VA = "0x184007430")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x4C97D60", Offset = "0x4C96960", VA = "0x184C97D60")]
			set
			{
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000043E0 File Offset: 0x000025E0
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017E")]
		public Color targetColor
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x36B1B50", Offset = "0x36B0750", VA = "0x1836B1B50")]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000043F8 File Offset: 0x000025F8
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017F")]
		public ColorTween.ColorTweenMode tweenMode
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return ColorTween.ColorTweenMode.All;
			}
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00004410 File Offset: 0x00002610
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000180")]
		public float duration
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00004428 File Offset: 0x00002628
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000181")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x5B84E40", Offset = "0x5B83A40", VA = "0x185B84E40", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x5B84D80", Offset = "0x5B83980", VA = "0x185B84D80")]
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
		public float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x0")]
		private ColorTween.ColorTweenCallback m_Target;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x8")]
		private Color m_StartColor;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x18")]
		private Color m_TargetColor;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x28")]
		private ColorTween.ColorTweenMode m_TweenMode;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Duration;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IgnoreTimeScale;

		// Token: 0x0200009D RID: 157
		[Token(Token = "0x200009D")]
		public enum ColorTweenMode
		{
			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x40002D8")]
			All,
			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x40002D9")]
			RGB,
			// Token: 0x040002DA RID: 730
			[Token(Token = "0x40002DA")]
			Alpha
		}

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		public class ColorTweenCallback : UnityEvent<Color>
		{
			// Token: 0x060005E8 RID: 1512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x5B84D40", Offset = "0x5B83940", VA = "0x185B84D40")]
			public ColorTweenCallback()
			{
			}
		}
	}
}
