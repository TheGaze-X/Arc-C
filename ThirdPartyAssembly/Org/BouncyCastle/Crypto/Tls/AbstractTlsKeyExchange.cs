using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public abstract class AbstractTlsKeyExchange : TlsKeyExchange
	{
		// Token: 0x060013D1 RID: 5073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		protected AbstractTlsKeyExchange(int keyExchange, IList supportedSignatureAlgorithms)
		{
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x523FA60", Offset = "0x523E660", VA = "0x18523FA60", Slot = "19")]
		protected virtual DigitallySigned ParseSignature(Stream input)
		{
			return null;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x523F7F0", Offset = "0x523E3F0", VA = "0x18523F7F0", Slot = "20")]
		public virtual void Init(TlsContext context)
		{
		}

		// Token: 0x060013D4 RID: 5076
		[Token(Token = "0x60013D4")]
		public abstract void SkipServerCredentials();

		// Token: 0x060013D5 RID: 5077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public virtual void ProcessServerCertificate(Certificate serverCertificate)
		{
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x523FD00", Offset = "0x523E900", VA = "0x18523FD00", Slot = "23")]
		public virtual void ProcessServerCredentials(TlsCredentials serverCredentials)
		{
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x170002C4")]
		public virtual bool RequiresServerKeyExchange
		{
			[Token(Token = "0x60013D7")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x523F770", Offset = "0x523E370", VA = "0x18523F770", Slot = "25")]
		public virtual byte[] GenerateServerKeyExchange()
		{
			return null;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x523FE00", Offset = "0x523EA00", VA = "0x18523FE00", Slot = "26")]
		public virtual void SkipServerKeyExchange()
		{
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x523FD80", Offset = "0x523E980", VA = "0x18523FD80", Slot = "27")]
		public virtual void ProcessServerKeyExchange(Stream input)
		{
		}

		// Token: 0x060013DB RID: 5083
		[Token(Token = "0x60013DB")]
		public abstract void ValidateCertificateRequest(CertificateRequest certificateRequest);

		// Token: 0x060013DC RID: 5084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		public virtual void SkipClientCredentials()
		{
		}

		// Token: 0x060013DD RID: 5085
		[Token(Token = "0x60013DD")]
		public abstract void ProcessClientCredentials(TlsCredentials clientCredentials);

		// Token: 0x060013DE RID: 5086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public virtual void ProcessClientCertificate(Certificate clientCertificate)
		{
		}

		// Token: 0x060013DF RID: 5087
		[Token(Token = "0x60013DF")]
		public abstract void GenerateClientKeyExchange(Stream output);

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x523FCB0", Offset = "0x523E8B0", VA = "0x18523FCB0", Slot = "33")]
		public virtual void ProcessClientKeyExchange(Stream input)
		{
		}

		// Token: 0x060013E1 RID: 5089
		[Token(Token = "0x60013E1")]
		public abstract byte[] GeneratePremasterSecret();

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x10")]
		protected readonly int mKeyExchange;

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x18")]
		protected IList mSupportedSignatureAlgorithms;

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x20")]
		protected TlsContext mContext;
	}
}
