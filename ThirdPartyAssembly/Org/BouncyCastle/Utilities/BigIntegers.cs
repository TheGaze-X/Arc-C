using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	public abstract class BigIntegers
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x543EFD0", Offset = "0x543DBD0", VA = "0x18543EFD0")]
		public static byte[] AsUnsignedByteArray(BigInteger n)
		{
			return null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x543EED0", Offset = "0x543DAD0", VA = "0x18543EED0")]
		public static byte[] AsUnsignedByteArray(int length, BigInteger n)
		{
			return null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x543EFF0", Offset = "0x543DBF0", VA = "0x18543EFF0")]
		public static BigInteger CreateRandomInRange(BigInteger min, BigInteger max, SecureRandom random)
		{
			return null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BigIntegers()
		{
		}

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		private const int MaxIterations = 1000;
	}
}
