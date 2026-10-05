using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	internal struct FloatTween : ITweenValue
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00004488 File Offset: 0x00002688
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000182")]
		public float startValue
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000183")]
		public float targetValue
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x877270", Offset = "0x875E70", VA = "0x180877270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000184")]
		public float duration
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000044D0 File Offset: 0x000026D0
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000185")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			set
			{
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x5B89750", Offset = "0x5B88350", VA = "0x185B89750", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x5B89690", Offset = "0x5B88290", VA = "0x185B89690")]
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
		public float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x0")]
		private FloatTween.FloatTweenCallback m_Target;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x8")]
		private float m_StartValue;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0xC")]
		private float m_TargetValue;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x10")]
		private float m_Duration;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IgnoreTimeScale;

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		public class FloatTweenCallback : UnityEvent<float>
		{
			// Token: 0x060005F6 RID: 1526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x5B89650", Offset = "0x5B88250", VA = "0x185B89650")]
			public FloatTweenCallback()
			{
			}
		}
	}
}
