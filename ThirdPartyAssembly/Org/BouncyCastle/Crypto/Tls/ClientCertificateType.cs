using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	public abstract class ClientCertificateType
	{
		// Token: 0x0600146A RID: 5226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ClientCertificateType()
		{
		}

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		public const byte rsa_sign = 1;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		public const byte dss_sign = 2;

		// Token: 0x04000AD8 RID: 2776
		[Token(Token = "0x4000AD8")]
		public const byte rsa_fixed_dh = 3;

		// Token: 0x04000AD9 RID: 2777
		[Token(Token = "0x4000AD9")]
		public const byte dss_fixed_dh = 4;

		// Token: 0x04000ADA RID: 2778
		[Token(Token = "0x4000ADA")]
		public const byte rsa_ephemeral_dh_RESERVED = 5;

		// Token: 0x04000ADB RID: 2779
		[Token(Token = "0x4000ADB")]
		public const byte dss_ephemeral_dh_RESERVED = 6;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		public const byte fortezza_dms_RESERVED = 20;

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		public const byte ecdsa_sign = 64;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		public const byte rsa_fixed_ecdh = 65;

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		public const byte ecdsa_fixed_ecdh = 66;
	}
}
