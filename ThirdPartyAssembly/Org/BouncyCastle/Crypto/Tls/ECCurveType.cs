using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public abstract class ECCurveType
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ECCurveType()
		{
		}

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		public const byte explicit_prime = 1;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		public const byte explicit_char2 = 2;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		public const byte named_curve = 3;
	}
}
