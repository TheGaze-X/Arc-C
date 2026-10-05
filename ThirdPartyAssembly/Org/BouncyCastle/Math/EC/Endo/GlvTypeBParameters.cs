using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	public class GlvTypeBParameters
	{
		// Token: 0x06000BE2 RID: 3042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x54B6FF0", Offset = "0x54B5BF0", VA = "0x1854B6FF0")]
		public GlvTypeBParameters(BigInteger beta, BigInteger lambda, BigInteger[] v1, BigInteger[] v2, BigInteger g1, BigInteger g2, int bits)
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000133")]
		public virtual BigInteger Beta
		{
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000134")]
		public virtual BigInteger Lambda
		{
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000135")]
		public virtual BigInteger[] V1
		{
			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000136")]
		public virtual BigInteger[] V2
		{
			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000137")]
		public virtual BigInteger G1
		{
			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000138")]
		public virtual BigInteger G2
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x17000139")]
		public virtual int Bits
		{
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x10")]
		protected readonly BigInteger m_beta;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x18")]
		protected readonly BigInteger m_lambda;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x20")]
		protected readonly BigInteger[] m_v1;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x28")]
		protected readonly BigInteger[] m_v2;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x30")]
		protected readonly BigInteger m_g1;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x38")]
		protected readonly BigInteger m_g2;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x40")]
		protected readonly int m_bits;
	}
}
