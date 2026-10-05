using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023C RID: 572
	[Token(Token = "0x200023C")]
	public struct TimeValue : IEquatable<TimeValue>
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x170003E0")]
		public float value
		{
			[Token(Token = "0x6001015")]
			[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x170003E1")]
		public TimeUnit unit
		{
			[Token(Token = "0x6001016")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			get
			{
				return TimeUnit.Second;
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x5B212E0", Offset = "0x5B1FEE0", VA = "0x185B212E0")]
		public TimeValue(float value)
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x46B3760", Offset = "0x46B2360", VA = "0x1846B3760")]
		public TimeValue(float value, TimeUnit unit)
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x5B02370", Offset = "0x5B00F70", VA = "0x185B02370")]
		public static implicit operator TimeValue(float value)
		{
			return default(TimeValue);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x5B02340", Offset = "0x5B00F40", VA = "0x185B02340")]
		public static bool operator ==(TimeValue lhs, TimeValue rhs)
		{
			return default(bool);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x5B1ECF0", Offset = "0x5B1D8F0", VA = "0x185B1ECF0")]
		public static bool operator !=(TimeValue lhs, TimeValue rhs)
		{
			return default(bool);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x5B02100", Offset = "0x5B00D00", VA = "0x185B02100", Slot = "4")]
		public bool Equals(TimeValue other)
		{
			return default(bool);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x5B296E0", Offset = "0x5B282E0", VA = "0x185B296E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x600101E")]
		[Address(RVA = "0x5B02130", Offset = "0x5B00D30", VA = "0x185B02130", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600101F")]
		[Address(RVA = "0x5B29790", Offset = "0x5B28390", VA = "0x185B29790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x0")]
		private float m_Value;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x4")]
		private TimeUnit m_Unit;
	}
}
