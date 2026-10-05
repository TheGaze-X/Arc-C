using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023D RID: 573
	[Token(Token = "0x200023D")]
	public struct TransformOrigin : IEquatable<TransformOrigin>
	{
		// Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x5B2A3C0", Offset = "0x5B28FC0", VA = "0x185B2A3C0")]
		public TransformOrigin(Length x, Length y, float z)
		{
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x5B2A0D0", Offset = "0x5B28CD0", VA = "0x185B2A0D0")]
		public static TransformOrigin Initial()
		{
			return default(TransformOrigin);
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00008E08 File Offset: 0x00007008
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E2")]
		public Length x
		{
			[Token(Token = "0x6001022")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return default(Length);
			}
			[Token(Token = "0x6001023")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			set
			{
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00008E20 File Offset: 0x00007020
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E3")]
		public Length y
		{
			[Token(Token = "0x6001024")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return default(Length);
			}
			[Token(Token = "0x6001025")]
			[Address(RVA = "0x33E8CB0", Offset = "0x33E78B0", VA = "0x1833E8CB0")]
			set
			{
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x170003E4")]
		public float z
		{
			[Token(Token = "0x6001026")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x5B2A3D0", Offset = "0x5B28FD0", VA = "0x185B2A3D0")]
		public static bool operator ==(TransformOrigin lhs, TransformOrigin rhs)
		{
			return default(bool);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x5B2A4A0", Offset = "0x5B290A0", VA = "0x185B2A4A0")]
		public static bool operator !=(TransformOrigin lhs, TransformOrigin rhs)
		{
			return default(bool);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x6001029")]
		[Address(RVA = "0x5B29EE0", Offset = "0x5B28AE0", VA = "0x185B29EE0", Slot = "4")]
		public bool Equals(TransformOrigin other)
		{
			return default(bool);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x600102A")]
		[Address(RVA = "0x5B29FB0", Offset = "0x5B28BB0", VA = "0x185B29FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x5B2A050", Offset = "0x5B28C50", VA = "0x185B2A050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600102C")]
		[Address(RVA = "0x5B2A130", Offset = "0x5B28D30", VA = "0x185B2A130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x0")]
		private Length m_X;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x8")]
		private Length m_Y;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x10")]
		private float m_Z;
	}
}
