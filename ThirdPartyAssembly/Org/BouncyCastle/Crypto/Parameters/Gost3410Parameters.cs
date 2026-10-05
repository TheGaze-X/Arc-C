using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	public class Gost3410Parameters : ICipherParameters
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x528E370", Offset = "0x528CF70", VA = "0x18528E370")]
		public Gost3410Parameters(BigInteger p, BigInteger q, BigInteger a)
		{
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x528E1E0", Offset = "0x528CDE0", VA = "0x18528E1E0")]
		public Gost3410Parameters(BigInteger p, BigInteger q, BigInteger a, Gost3410ValidationParameters validation)
		{
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036E")]
		public BigInteger P
		{
			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036F")]
		public BigInteger Q
		{
			[Token(Token = "0x60018E8")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000370")]
		public BigInteger A
		{
			[Token(Token = "0x60018E9")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000371")]
		public Gost3410ValidationParameters ValidationParameters
		{
			[Token(Token = "0x60018EA")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x528E040", Offset = "0x528CC40", VA = "0x18528E040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x5285A20", Offset = "0x5284620", VA = "0x185285A20")]
		protected bool Equals(Gost3410Parameters other)
		{
			return default(bool);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x5285CC0", Offset = "0x52848C0", VA = "0x185285CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D25 RID: 3365
		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0x10")]
		private readonly BigInteger p;

		// Token: 0x04000D26 RID: 3366
		[Token(Token = "0x4000D26")]
		[FieldOffset(Offset = "0x18")]
		private readonly BigInteger q;

		// Token: 0x04000D27 RID: 3367
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger a;

		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x28")]
		private readonly Gost3410ValidationParameters validation;
	}
}
