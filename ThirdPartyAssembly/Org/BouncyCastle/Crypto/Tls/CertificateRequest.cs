using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	public class CertificateRequest
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
		public CertificateRequest(byte[] certificateTypes, IList supportedSignatureAlgorithms, IList certificateAuthorities)
		{
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D3")]
		public virtual byte[] CertificateTypes
		{
			[Token(Token = "0x6001446")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D4")]
		public virtual IList SupportedSignatureAlgorithms
		{
			[Token(Token = "0x6001447")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D5")]
		public virtual IList CertificateAuthorities
		{
			[Token(Token = "0x6001448")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x5242710", Offset = "0x5241310", VA = "0x185242710", Slot = "7")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x5242ED0", Offset = "0x5241AD0", VA = "0x185242ED0")]
		public static CertificateRequest Parse(TlsContext context, Stream input)
		{
			return null;
		}

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte[] mCertificateTypes;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x18")]
		protected readonly IList mSupportedSignatureAlgorithms;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x20")]
		protected readonly IList mCertificateAuthorities;
	}
}
