using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	internal struct FloatTween : ITweenValue
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public float startValue
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public float targetValue
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x877270", Offset = "0x875E70", VA = "0x180877270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public float duration
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			set
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5880970", Offset = "0x587F570", VA = "0x185880970", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x58808B0", Offset = "0x587F4B0", VA = "0x1858808B0")]
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
		public float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x0")]
		private FloatTween.FloatTweenCallback m_Target;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x8")]
		private float m_StartValue;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0xC")]
		private float m_TargetValue;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x10")]
		private float m_Duration;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IgnoreTimeScale;

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public class FloatTweenCallback : UnityEvent<float>
		{
			// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x5880870", Offset = "0x587F470", VA = "0x185880870")]
			public FloatTweenCallback()
			{
			}
		}
	}
}
