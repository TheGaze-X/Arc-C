using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000227 RID: 551
	[Token(Token = "0x2000227")]
	public struct Length : IEquatable<Length>
	{
		// Token: 0x06000F5B RID: 3931 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x5B1EA40", Offset = "0x5B1D640", VA = "0x185B1EA40")]
		public static Length Percent(float value)
		{
			return default(Length);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x5B1E930", Offset = "0x5B1D530", VA = "0x185B1E930")]
		internal static Length Auto()
		{
			return default(Length);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x5B1EA20", Offset = "0x5B1D620", VA = "0x185B1EA20")]
		internal static Length None()
		{
			return default(Length);
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000081C0 File Offset: 0x000063C0
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C2")]
		public float value
		{
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F5F")]
			[Address(RVA = "0x5B1ED20", Offset = "0x5B1D920", VA = "0x185B1ED20")]
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x170003C3")]
		public LengthUnit unit
		{
			[Token(Token = "0x6000F60")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			get
			{
				return LengthUnit.Pixel;
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x5B1EA00", Offset = "0x5B1D600", VA = "0x185B1EA00")]
		internal bool IsAuto()
		{
			return default(bool);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x5B1EA10", Offset = "0x5B1D610", VA = "0x185B1EA10")]
		internal bool IsNone()
		{
			return default(bool);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x5B1EC80", Offset = "0x5B1D880", VA = "0x185B1EC80")]
		public Length(float value)
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x5B1EC50", Offset = "0x5B1D850", VA = "0x185B1EC50")]
		public Length(float value, LengthUnit unit)
		{
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x5B1EC50", Offset = "0x5B1D850", VA = "0x185B1EC50")]
		private Length(float value, Length.Unit unit)
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x5B1ECB0", Offset = "0x5B1D8B0", VA = "0x185B1ECB0")]
		public static implicit operator Length(float value)
		{
			return default(Length);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x5B02340", Offset = "0x5B00F40", VA = "0x185B02340")]
		public static bool operator ==(Length lhs, Length rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x5B1ECF0", Offset = "0x5B1D8F0", VA = "0x185B1ECF0")]
		public static bool operator !=(Length lhs, Length rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x5B02100", Offset = "0x5B00D00", VA = "0x185B02100", Slot = "4")]
		public bool Equals(Length other)
		{
			return default(bool);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x5B1E950", Offset = "0x5B1D550", VA = "0x185B1E950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x5B02130", Offset = "0x5B00D30", VA = "0x185B02130", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x5B1EA80", Offset = "0x5B1D680", VA = "0x185B1EA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		private const float k_MaxValue = 8388608f;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x0")]
		private float m_Value;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x4")]
		private Length.Unit m_Unit;

		// Token: 0x02000228 RID: 552
		[Token(Token = "0x2000228")]
		private enum Unit
		{
			// Token: 0x04000804 RID: 2052
			[Token(Token = "0x4000804")]
			Pixel,
			// Token: 0x04000805 RID: 2053
			[Token(Token = "0x4000805")]
			Percent,
			// Token: 0x04000806 RID: 2054
			[Token(Token = "0x4000806")]
			Auto,
			// Token: 0x04000807 RID: 2055
			[Token(Token = "0x4000807")]
			None
		}
	}
}
