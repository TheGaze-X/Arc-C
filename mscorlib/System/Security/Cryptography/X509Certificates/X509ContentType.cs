using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	public enum X509ContentType
	{
		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		Unknown,
		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		Cert,
		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		SerializedCert,
		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		Pfx,
		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		Pkcs12 = 3,
		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		SerializedStore,
		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		Pkcs7,
		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		Authenticode
	}
}
