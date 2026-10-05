using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002EF RID: 751
	[Token(Token = "0x20002EF")]
	public class RsaPrivateCrtKeyParameters : RsaKeyParameters
	{
		// Token: 0x06001936 RID: 6454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x5296560", Offset = "0x5295160", VA = "0x185296560")]
		public RsaPrivateCrtKeyParameters(BigInteger modulus, BigInteger publicExponent, BigInteger privateExponent, BigInteger p, BigInteger q, BigInteger dP, BigInteger dQ, BigInteger qInv)
		{
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038C")]
		public BigInteger PublicExponent
		{
			[Token(Token = "0x6001937")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038D")]
		public BigInteger P
		{
			[Token(Token = "0x6001938")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038E")]
		public BigInteger Q
		{
			[Token(Token = "0x6001939")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038F")]
		public BigInteger DP
		{
			[Token(Token = "0x600193A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000390")]
		public BigInteger DQ
		{
			[Token(Token = "0x600193B")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000391")]
		public BigInteger QInv
		{
			[Token(Token = "0x600193C")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x5296090", Offset = "0x5294C90", VA = "0x185296090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0000C468 File Offset: 0x0000A668
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x5296270", Offset = "0x5294E70", VA = "0x185296270", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x5296480", Offset = "0x5295080", VA = "0x185296480")]
		private static void ValidateValue(BigInteger x, string name, string desc)
		{
		}

		// Token: 0x04000D4C RID: 3404
		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x28")]
		private readonly BigInteger e;

		// Token: 0x04000D4D RID: 3405
		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x30")]
		private readonly BigInteger p;

		// Token: 0x04000D4E RID: 3406
		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x38")]
		private readonly BigInteger q;

		// Token: 0x04000D4F RID: 3407
		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x40")]
		private readonly BigInteger dP;

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x48")]
		private readonly BigInteger dQ;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x50")]
		private readonly BigInteger qInv;
	}
}
