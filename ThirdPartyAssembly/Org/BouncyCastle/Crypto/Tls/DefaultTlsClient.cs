using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	public abstract class DefaultTlsClient : AbstractTlsClient
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x523EFE0", Offset = "0x523DBE0", VA = "0x18523EFE0")]
		public DefaultTlsClient()
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public DefaultTlsClient(TlsCipherFactory cipherFactory)
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x5247EC0", Offset = "0x5246AC0", VA = "0x185247EC0", Slot = "48")]
		public override int[] GetCipherSuites()
		{
			return null;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x5247F20", Offset = "0x5246B20", VA = "0x185247F20", Slot = "55")]
		public override TlsKeyExchange GetKeyExchange()
		{
			return null;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x5247BF0", Offset = "0x52467F0", VA = "0x185247BF0", Slot = "59")]
		protected virtual TlsKeyExchange CreateDHKeyExchange(int keyExchange)
		{
			return null;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x5247C70", Offset = "0x5246870", VA = "0x185247C70", Slot = "60")]
		protected virtual TlsKeyExchange CreateDheKeyExchange(int keyExchange)
		{
			return null;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x5247CF0", Offset = "0x52468F0", VA = "0x185247CF0", Slot = "61")]
		protected virtual TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
		{
			return null;
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x5247DA0", Offset = "0x52469A0", VA = "0x185247DA0", Slot = "62")]
		protected virtual TlsKeyExchange CreateECDheKeyExchange(int keyExchange)
		{
			return null;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x5247E50", Offset = "0x5246A50", VA = "0x185247E50", Slot = "63")]
		protected virtual TlsKeyExchange CreateRsaKeyExchange()
		{
			return null;
		}
	}
}
