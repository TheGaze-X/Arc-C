using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Btls
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4F570E0", Offset = "0x4F55CE0", VA = "0x184F570E0")]
		public MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4F552D0", Offset = "0x4F53ED0", VA = "0x184F552D0")]
		private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4F56C10", Offset = "0x4F55810", VA = "0x184F56C10")]
		private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx)
		{
			return 0;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4F56560", Offset = "0x4F55160", VA = "0x184F56560")]
		private int SelectCallback(string[] acceptableIssuers)
		{
			return 0;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4F56660", Offset = "0x4F55260", VA = "0x184F56660")]
		private int ServerNameCallback()
		{
			return 0;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4F56A90", Offset = "0x4F55690", VA = "0x184F56A90", Slot = "6")]
		public override void StartHandshake()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4F566E0", Offset = "0x4F552E0", VA = "0x184F566E0")]
		private void SetPrivateCertificate(X509CertificateImplBtls privateCert)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4F54D40", Offset = "0x4F53940", VA = "0x184F54D40")]
		private static Exception GetException(MonoBtlsSslError status)
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4F560B0", Offset = "0x4F54CB0", VA = "0x184F560B0", Slot = "7")]
		public override bool ProcessHandshake()
		{
			return default(bool);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4F54C70", Offset = "0x4F53870", VA = "0x184F54C70")]
		private MonoBtlsSslError DoProcessHandshake()
		{
			return MonoBtlsSslError.None;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4F54CD0", Offset = "0x4F538D0", VA = "0x184F54CD0", Slot = "8")]
		public override void FinishHandshake()
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4F55610", Offset = "0x4F54210", VA = "0x184F55610")]
		private void InitializeConnection()
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4F551F0", Offset = "0x4F53DF0", VA = "0x184F551F0")]
		private void GetPeerCertificate()
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4F55E10", Offset = "0x4F54A10", VA = "0x184F55E10")]
		private void InitializeSession()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4F55580", Offset = "0x4F54180", VA = "0x184F55580")]
		private static TlsProtocols GetProtocol(TlsProtocolCode protocol)
		{
			return TlsProtocols.Zero;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4F54CF0", Offset = "0x4F538F0", VA = "0x184F54CF0", Slot = "11")]
		public override void Flush()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4F56220", Offset = "0x4F54E20", VA = "0x184F56220", Slot = "12")]
		public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int size)
		{
			return default(ValueTuple<int, bool>);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x4F56E40", Offset = "0x4F55A40", VA = "0x184F56E40", Slot = "13")]
		public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int size)
		{
			return default(ValueTuple<int, bool>);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x4F56510", Offset = "0x4F55110", VA = "0x184F56510", Slot = "16")]
		public override void Renegotiate()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x4F56A30", Offset = "0x4F55630", VA = "0x184F56A30", Slot = "14")]
		public override void Shutdown()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4F56080", Offset = "0x4F54C80", VA = "0x184F56080", Slot = "15")]
		public override bool PendingRenegotiation()
		{
			return default(bool);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C6")]
		private void Dispose<T>(ref T disposable) where T : class, IDisposable
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4F54B10", Offset = "0x4F53710", VA = "0x184F54B10", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4F56020", Offset = "0x4F54C20", VA = "0x184F56020", Slot = "18")]
		private int Read(byte[] buffer, int offset, int size, out bool wantMore)
		{
			return 0;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4F56050", Offset = "0x4F54C50", VA = "0x184F56050", Slot = "19")]
		private bool Write(byte[] buffer, int offset, int size)
		{
			return default(bool);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		private void Flush()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		private void Close()
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x17000062")]
		public override bool IsAuthenticated
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x4F57130", Offset = "0x4F55D30", VA = "0x184F57130", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		internal override X509Certificate LocalClientCertificate
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public override X509Certificate2 RemoteCertificate
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x58")]
		private X509Certificate2 remoteCertificate;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x60")]
		private X509Certificate clientCertificate;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x68")]
		private X509CertificateImplBtls nativeServerCertificate;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x70")]
		private X509CertificateImplBtls nativeClientCertificate;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x78")]
		private MonoBtlsSslCtx ctx;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x80")]
		private MonoBtlsSsl ssl;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x88")]
		private MonoBtlsBio bio;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x90")]
		private MonoBtlsBio errbio;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x98")]
		private MonoTlsConnectionInfo connectionInfo;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0xA0")]
		private bool certificateValidated;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0xA1")]
		private bool isAuthenticated;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0xA2")]
		private bool connected;
	}
}
