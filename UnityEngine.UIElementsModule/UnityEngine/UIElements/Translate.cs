using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023E RID: 574
	[Token(Token = "0x200023E")]
	public struct Translate : IEquatable<Translate>
	{
		// Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x5B2AF60", Offset = "0x5B29B60", VA = "0x185B2AF60")]
		public Translate(Length x, Length y, float z)
		{
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x5B2ACA0", Offset = "0x5B298A0", VA = "0x185B2ACA0")]
		public static Translate None()
		{
			return default(Translate);
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00008EE0 File Offset: 0x000070E0
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E5")]
		public Length x
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return default(Length);
			}
			[Token(Token = "0x6001030")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			set
			{
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00008EF8 File Offset: 0x000070F8
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E6")]
		public Length y
		{
			[Token(Token = "0x6001031")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return default(Length);
			}
			[Token(Token = "0x6001032")]
			[Address(RVA = "0x33E8CB0", Offset = "0x33E78B0", VA = "0x1833E8CB0")]
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x170003E7")]
		public float z
		{
			[Token(Token = "0x6001033")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x5B2AF80", Offset = "0x5B29B80", VA = "0x185B2AF80")]
		public static bool operator ==(Translate lhs, Translate rhs)
		{
			return default(bool);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x5B2B090", Offset = "0x5B29C90", VA = "0x185B2B090")]
		public static bool operator !=(Translate lhs, Translate rhs)
		{
			return default(bool);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x5B2AB90", Offset = "0x5B29790", VA = "0x185B2AB90", Slot = "4")]
		public bool Equals(Translate other)
		{
			return default(bool);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x5B2ABE0", Offset = "0x5B297E0", VA = "0x185B2ABE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x5B2A050", Offset = "0x5B28C50", VA = "0x185B2A050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001039")]
		[Address(RVA = "0x5B2ACD0", Offset = "0x5B298D0", VA = "0x185B2ACD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x0")]
		private Length m_X;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x8")]
		private Length m_Y;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x10")]
		private float m_Z;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x14")]
		private bool m_isNone;
	}
}
