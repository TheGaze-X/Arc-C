using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	public abstract class AbstractTlsPeer : TlsPeer
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
		public virtual bool ShouldUseGmtUnixTime()
		{
			return default(bool);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x523FE80", Offset = "0x523EA80", VA = "0x18523FE80", Slot = "12")]
		public virtual void NotifySecureRenegotiation(bool secureRenegotiation)
		{
		}

		// Token: 0x060013E4 RID: 5092
		[Token(Token = "0x60013E4")]
		public abstract TlsCompression GetCompression();

		// Token: 0x060013E5 RID: 5093
		[Token(Token = "0x60013E5")]
		public abstract TlsCipher GetCipher();

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void NotifyAlertRaised(byte alertLevel, byte alertDescription, string message, Exception cause)
		{
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void NotifyAlertReceived(byte alertLevel, byte alertDescription)
		{
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public virtual void NotifyHandshakeComplete()
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractTlsPeer()
		{
		}
	}
}
