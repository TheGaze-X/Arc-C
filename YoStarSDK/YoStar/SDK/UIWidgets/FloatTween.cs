using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public struct FloatTween : ITweenValue
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00003044 File Offset: 0x00001244
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000062")]
		public EasingEquations.EaseType easeType
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return EasingEquations.EaseType.LinearInOutFade;
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0000305C File Offset: 0x0000125C
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000063")]
		public float startValue
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000064")]
		public float targetValue
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0000308C File Offset: 0x0000128C
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000065")]
		public float duration
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000030A4 File Offset: 0x000012A4
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000066")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x5C2A670", Offset = "0x5C29270", VA = "0x185C2A670", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x5C2A500", Offset = "0x5C29100", VA = "0x185C2A500")]
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x5C2A5C0", Offset = "0x5C291C0", VA = "0x185C2A5C0")]
		public void AddOnFinishCallback(UnityAction callback)
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x5C2A650", Offset = "0x5C29250", VA = "0x185C2A650", Slot = "8")]
		public void OnFinish()
		{
		}

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x0")]
		private FloatTween.FloatTweenCallback m_Target;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x8")]
		private FloatTween.FloatTweenFinishCallback m_OnFinish;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x10")]
		private EasingEquations.EaseType m_EaseType;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x14")]
		private float m_StartValue;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x18")]
		private float m_TargetValue;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x1C")]
		private float m_Duration;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x20")]
		private bool m_IgnoreTimeScale;

		// Token: 0x020000E4 RID: 228
		[Token(Token = "0x20000E4")]
		public class FloatTweenCallback : UnityEvent<float>
		{
			// Token: 0x0600062F RID: 1583 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x5C2A4C0", Offset = "0x5C290C0", VA = "0x185C2A4C0")]
			public FloatTweenCallback()
			{
			}
		}

		// Token: 0x020000E5 RID: 229
		[Token(Token = "0x20000E5")]
		public class FloatTweenFinishCallback : UnityEvent
		{
			// Token: 0x06000630 RID: 1584 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
			public FloatTweenFinishCallback()
			{
			}
		}
	}
}
