using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D0 RID: 720
	[Token(Token = "0x20002D0")]
	public class ECDomainParameters
	{
		// Token: 0x0600189B RID: 6299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x5286D30", Offset = "0x5285930", VA = "0x185286D30")]
		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n)
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x52871B0", Offset = "0x5285DB0", VA = "0x1852871B0")]
		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h)
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x5286F90", Offset = "0x5285B90", VA = "0x185286F90")]
		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h, byte[] seed)
		{
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035A")]
		public ECCurve Curve
		{
			[Token(Token = "0x600189E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035B")]
		public ECPoint G
		{
			[Token(Token = "0x600189F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035C")]
		public BigInteger N
		{
			[Token(Token = "0x60018A0")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035D")]
		public BigInteger H
		{
			[Token(Token = "0x60018A1")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x524CEB0", Offset = "0x524BAB0", VA = "0x18524CEB0")]
		public byte[] GetSeed()
		{
			return null;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x52869E0", Offset = "0x52855E0", VA = "0x1852869E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x5286AE0", Offset = "0x52856E0", VA = "0x185286AE0", Slot = "4")]
		protected virtual bool Equals(ECDomainParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x5286C00", Offset = "0x5285800", VA = "0x185286C00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x10")]
		internal ECCurve curve;

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x18")]
		internal byte[] seed;

		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x20")]
		internal ECPoint g;

		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x28")]
		internal BigInteger n;

		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x30")]
		internal BigInteger h;
	}
}
