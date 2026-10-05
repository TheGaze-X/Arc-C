using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	public abstract class CertChainType
	{
		// Token: 0x0600143A RID: 5178 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x5242700", Offset = "0x5241300", VA = "0x185242700")]
		public static bool IsValid(byte certChainType)
		{
			return default(bool);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CertChainType()
		{
		}

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		public const byte individual_certs = 0;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		public const byte pkipath = 1;
	}
}
