using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	public abstract class X9IntegerConverter
	{
		// Token: 0x060021CE RID: 8654 RVA: 0x0000F780 File Offset: 0x0000D980
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x5355AD0", Offset = "0x53546D0", VA = "0x185355AD0")]
		public static int GetByteLength(ECFieldElement fe)
		{
			return 0;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0000F798 File Offset: 0x0000D998
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x5355B20", Offset = "0x5354720", VA = "0x185355B20")]
		public static int GetByteLength(ECCurve c)
		{
			return 0;
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x5355B70", Offset = "0x5354770", VA = "0x185355B70")]
		public static byte[] IntegerToBytes(BigInteger s, int qLength)
		{
			return null;
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X9IntegerConverter()
		{
		}
	}
}
