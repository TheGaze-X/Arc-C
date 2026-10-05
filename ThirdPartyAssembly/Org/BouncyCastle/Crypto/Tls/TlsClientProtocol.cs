using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000287 RID: 647
	[Token(Token = "0x2000287")]
	public class TlsClientProtocol : TlsProtocol
	{
		// Token: 0x06001595 RID: 5525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x5256420", Offset = "0x5255020", VA = "0x185256420")]
		public TlsClientProtocol(Stream stream, SecureRandom secureRandom)
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x52563A0", Offset = "0x5254FA0", VA = "0x1852563A0")]
		public TlsClientProtocol(Stream input, Stream output, SecureRandom secureRandom)
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x5256340", Offset = "0x5254F40", VA = "0x185256340")]
		public TlsClientProtocol(SecureRandom secureRandom)
		{
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x52533B0", Offset = "0x5251FB0", VA = "0x1852533B0", Slot = "45")]
		public virtual void Connect(TlsClient tlsClient)
		{
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x5253330", Offset = "0x5251F30", VA = "0x185253330", Slot = "12")]
		protected override void CleanupHandshake()
		{
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		protected override TlsContext Context
		{
			[Token(Token = "0x600159A")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030D")]
		internal override AbstractTlsContext ContextAdmin
		{
			[Token(Token = "0x600159B")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030E")]
		protected override TlsPeer Peer
		{
			[Token(Token = "0x600159C")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x5253840", Offset = "0x5252440", VA = "0x185253840", Slot = "8")]
		protected override void HandleHandshakeMessage(byte type, byte[] data)
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x5254C00", Offset = "0x5253800", VA = "0x185254C00", Slot = "46")]
		protected virtual void HandleSupplementalData(IList serverSupplementalData)
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x5254CF0", Offset = "0x52538F0", VA = "0x185254CF0", Slot = "47")]
		protected virtual void ReceiveNewSessionTicketMessage(MemoryStream buf)
		{
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x5254EA0", Offset = "0x5253AA0", VA = "0x185254EA0", Slot = "48")]
		protected virtual void ReceiveServerHelloMessage(MemoryStream buf)
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x5255CC0", Offset = "0x52548C0", VA = "0x185255CC0", Slot = "49")]
		protected virtual void SendCertificateVerifyMessage(DigitallySigned certificateVerify)
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x5255D70", Offset = "0x5254970", VA = "0x185255D70", Slot = "50")]
		protected virtual void SendClientHelloMessage()
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x52562A0", Offset = "0x5254EA0", VA = "0x1852562A0", Slot = "51")]
		protected virtual void SendClientKeyExchangeMessage()
		{
		}

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0xA8")]
		protected TlsClient mTlsClient;

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0xB0")]
		internal TlsClientContextImpl mTlsClientContext;

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0xB8")]
		protected byte[] mSelectedSessionID;

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0xC0")]
		protected TlsKeyExchange mKeyExchange;

		// Token: 0x04000C12 RID: 3090
		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0xC8")]
		protected TlsAuthentication mAuthentication;

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0xD0")]
		protected CertificateStatus mCertificateStatus;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0xD8")]
		protected CertificateRequest mCertificateRequest;
	}
}
