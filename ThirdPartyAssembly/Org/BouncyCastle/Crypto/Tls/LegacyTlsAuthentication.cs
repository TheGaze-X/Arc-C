using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	public class LegacyTlsAuthentication : TlsAuthentication
	{
		// Token: 0x060014DD RID: 5341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x1C198C0", Offset = "0x1C184C0", VA = "0x181C198C0")]
		public LegacyTlsAuthentication(Uri targetUri, ICertificateVerifyer verifyer, IClientCredentialsProvider prov)
		{
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x524A690", Offset = "0x5249290", VA = "0x18524A690", Slot = "6")]
		public virtual void NotifyServerCertificate(Certificate serverCertificate)
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x524A610", Offset = "0x5249210", VA = "0x18524A610", Slot = "7")]
		public virtual TlsCredentials GetClientCredentials(TlsContext context, CertificateRequest certificateRequest)
		{
			return null;
		}

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x10")]
		protected ICertificateVerifyer verifyer;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x18")]
		protected IClientCredentialsProvider credProvider;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x20")]
		protected Uri TargetUri;
	}
}
