using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	internal class UnityTlsContext : MobileTlsContext
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4F64C80", Offset = "0x4F63880", VA = "0x184F64C80")]
		public UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4F630B0", Offset = "0x4F61CB0", VA = "0x184F630B0")]
		private unsafe static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x1700000A")]
		public override bool IsAuthenticated
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x32F71F0", Offset = "0x32F5DF0", VA = "0x1832F71F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		internal override X509Certificate LocalClientCertificate
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public override X509Certificate2 RemoteCertificate
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		public override void Flush()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4F63CB0", Offset = "0x4F628B0", VA = "0x184F63CB0", Slot = "12")]
		public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count)
		{
			return default(ValueTuple<int, bool>);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4F64A90", Offset = "0x4F63690", VA = "0x184F64A90", Slot = "13")]
		public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count)
		{
			return default(ValueTuple<int, bool>);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4F63EC0", Offset = "0x4F62AC0", VA = "0x184F63EC0", Slot = "16")]
		public override void Renegotiate()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "15")]
		public override bool PendingRenegotiation()
		{
			return default(bool);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4F63F10", Offset = "0x4F62B10", VA = "0x184F63F10", Slot = "14")]
		public override void Shutdown()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4F62F30", Offset = "0x4F61B30", VA = "0x184F62F30", Slot = "17")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4F64040", Offset = "0x4F62C40", VA = "0x184F64040", Slot = "6")]
		public override void StartHandshake()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4F63560", Offset = "0x4F62160", VA = "0x184F63560", Slot = "7")]
		public override bool ProcessHandshake()
		{
			return default(bool);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4F633F0", Offset = "0x4F61FF0", VA = "0x184F633F0", Slot = "8")]
		public override void FinishHandshake()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4F64920", Offset = "0x4F63520", VA = "0x184F64920")]
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
		private unsafe static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			return 0;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4F64710", Offset = "0x4F63310", VA = "0x184F64710")]
		private unsafe IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			return 0;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4F638A0", Offset = "0x4F624A0", VA = "0x184F638A0")]
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
		private unsafe static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			return 0;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4F63A10", Offset = "0x4F62610", VA = "0x184F63A10")]
		private unsafe IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			return 0;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4F645B0", Offset = "0x4F631B0", VA = "0x184F645B0")]
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
		private unsafe static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			return UnityTls.unitytls_x509verify_result.UNITYTLS_X509VERIFY_SUCCESS;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4F64290", Offset = "0x4F62E90", VA = "0x184F64290")]
		private unsafe UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			return UnityTls.unitytls_x509verify_result.UNITYTLS_X509VERIFY_SUCCESS;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4F62D80", Offset = "0x4F61980", VA = "0x184F62D80")]
		[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
		private unsafe static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4F62A20", Offset = "0x4F61620", VA = "0x184F62A20")]
		private unsafe void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
		}

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private unsafe UnityTls.unitytls_tlsctx* tlsContext;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private unsafe UnityTls.unitytls_x509list* requestedClientCertChain;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private unsafe UnityTls.unitytls_key* requestedClientKey;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UnityTls.unitytls_tlsctx_read_callback readCallback;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UnityTls.unitytls_tlsctx_write_callback writeCallback;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private X509Certificate localClientCertificate;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private X509Certificate2 remoteCertificate;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private MonoTlsConnectionInfo connectioninfo;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool isAuthenticated;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool hasContext;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		private bool closedGraceful;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private byte[] writeBuffer;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private byte[] readBuffer;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GCHandle handle;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Exception lastException;
	}
}
