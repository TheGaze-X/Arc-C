using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000268 RID: 616
	[Token(Token = "0x2000268")]
	public sealed class LegacyTlsClient : DefaultTlsClient
	{
		// Token: 0x060014E0 RID: 5344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x524A8B0", Offset = "0x52494B0", VA = "0x18524A8B0")]
		public LegacyTlsClient(Uri targetUri, ICertificateVerifyer verifyer, IClientCredentialsProvider prov, List<string> hostNames)
		{
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x524A800", Offset = "0x5249400", VA = "0x18524A800", Slot = "56")]
		public override TlsAuthentication GetAuthentication()
		{
			return null;
		}

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x50")]
		private readonly Uri TargetUri;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x58")]
		private readonly ICertificateVerifyer verifyer;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x60")]
		private readonly IClientCredentialsProvider credProvider;
	}
}
