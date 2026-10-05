using System;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public enum AlertDescription : byte
	{
		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		CloseNotify,
		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		UnexpectedMessage = 10,
		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		BadRecordMAC = 20,
		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		DecryptionFailed_RESERVED,
		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		RecordOverflow,
		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		DecompressionFailure = 30,
		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		HandshakeFailure = 40,
		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		NoCertificate_RESERVED,
		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		BadCertificate,
		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		UnsupportedCertificate,
		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		CertificateRevoked,
		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		CertificateExpired,
		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		CertificateUnknown,
		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		IlegalParameter,
		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		UnknownCA,
		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		AccessDenied,
		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		DecodeError,
		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		DecryptError,
		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		ExportRestriction = 60,
		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		ProtocolVersion = 70,
		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		InsuficientSecurity,
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		InternalError = 80,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		UserCancelled = 90,
		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		NoRenegotiation = 100,
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		UnsupportedExtension = 110
	}
}
