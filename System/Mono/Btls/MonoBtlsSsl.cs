using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Util;

namespace Mono.Btls
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	internal class MonoBtlsSsl : MonoBtlsObject
	{
		// Token: 0x06000227 RID: 551
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x50D2590", Offset = "0x50D1190", VA = "0x1850D2590")]
		[PreserveSig]
		private static extern void mono_btls_ssl_destroy(IntPtr handle);

		// Token: 0x06000228 RID: 552
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x50D2920", Offset = "0x50D1520", VA = "0x1850D2920")]
		[PreserveSig]
		private static extern IntPtr mono_btls_ssl_new(IntPtr handle);

		// Token: 0x06000229 RID: 553
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x50D2E10", Offset = "0x50D1A10", VA = "0x1850D2E10")]
		[PreserveSig]
		private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509);

		// Token: 0x0600022A RID: 554
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x50D2EA0", Offset = "0x50D1AA0", VA = "0x1850D2EA0")]
		[PreserveSig]
		private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key);

		// Token: 0x0600022B RID: 555
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x50D2400", Offset = "0x50D1000", VA = "0x1850D2400")]
		[PreserveSig]
		private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509);

		// Token: 0x0600022C RID: 556
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x50D2380", Offset = "0x50D0F80", VA = "0x1850D2380")]
		[PreserveSig]
		private static extern int mono_btls_ssl_accept(IntPtr handle);

		// Token: 0x0600022D RID: 557
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x50D2510", Offset = "0x50D1110", VA = "0x1850D2510")]
		[PreserveSig]
		private static extern int mono_btls_ssl_connect(IntPtr handle);

		// Token: 0x0600022E RID: 558
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x50D28A0", Offset = "0x50D14A0", VA = "0x1850D28A0")]
		[PreserveSig]
		private static extern int mono_btls_ssl_handshake(IntPtr handle);

		// Token: 0x0600022F RID: 559
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x50D2490", Offset = "0x50D1090", VA = "0x1850D2490")]
		[PreserveSig]
		private static extern void mono_btls_ssl_close(IntPtr handle);

		// Token: 0x06000230 RID: 560
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x50D2D90", Offset = "0x50D1990", VA = "0x1850D2D90")]
		[PreserveSig]
		private static extern int mono_btls_ssl_shutdown(IntPtr handle);

		// Token: 0x06000231 RID: 561
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x50D2BE0", Offset = "0x50D17E0", VA = "0x1850D2BE0")]
		[PreserveSig]
		private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode);

		// Token: 0x06000232 RID: 562
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x50D2B50", Offset = "0x50D1750", VA = "0x1850D2B50")]
		[PreserveSig]
		private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio);

		// Token: 0x06000233 RID: 563
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x50D2A30", Offset = "0x50D1630", VA = "0x1850D2A30")]
		[PreserveSig]
		private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len);

		// Token: 0x06000234 RID: 564
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x50D2F30", Offset = "0x50D1B30", VA = "0x1850D2F30")]
		[PreserveSig]
		private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len);

		// Token: 0x06000235 RID: 565
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x50D2690", Offset = "0x50D1290", VA = "0x1850D2690")]
		[PreserveSig]
		private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code);

		// Token: 0x06000236 RID: 566
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x50D2820", Offset = "0x50D1420", VA = "0x1850D2820")]
		[PreserveSig]
		private static extern int mono_btls_ssl_get_version(IntPtr handle);

		// Token: 0x06000237 RID: 567
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x50D2610", Offset = "0x50D1210", VA = "0x1850D2610")]
		[PreserveSig]
		private static extern int mono_btls_ssl_get_cipher(IntPtr handle);

		// Token: 0x06000238 RID: 568
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x50D2720", Offset = "0x50D1320", VA = "0x1850D2720")]
		[PreserveSig]
		private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle);

		// Token: 0x06000239 RID: 569
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x50D29A0", Offset = "0x50D15A0", VA = "0x1850D29A0")]
		[PreserveSig]
		private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx);

		// Token: 0x0600023A RID: 570
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x50D2D00", Offset = "0x50D1900", VA = "0x1850D2D00")]
		[PreserveSig]
		private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name);

		// Token: 0x0600023B RID: 571
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x50D27A0", Offset = "0x50D13A0", VA = "0x1850D27A0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle);

		// Token: 0x0600023C RID: 572
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x50D2C70", Offset = "0x50D1870", VA = "0x1850D2C70")]
		[PreserveSig]
		private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode);

		// Token: 0x0600023D RID: 573
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x50D2AD0", Offset = "0x50D16D0", VA = "0x1850D2AD0")]
		[PreserveSig]
		private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle);

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x50D0AC0", Offset = "0x50CF6C0", VA = "0x1850D0AC0")]
		private static MonoBtlsSsl.BoringSslHandle Create_internal(MonoBtlsSslCtx ctx)
		{
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x50D2000", Offset = "0x50D0C00", VA = "0x1850D2000")]
		public MonoBtlsSsl(MonoBtlsSslCtx ctx)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		internal new MonoBtlsSsl.BoringSslHandle Handle
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x50D22C0", Offset = "0x50D0EC0", VA = "0x1850D22C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x50D1680", Offset = "0x50D0280", VA = "0x1850D1680")]
		public void SetBio(MonoBtlsBio bio)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x50D1D20", Offset = "0x50D0920", VA = "0x1850D1D20")]
		private Exception ThrowError([CallerMemberName] [Optional] string callerName)
		{
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x50D0D00", Offset = "0x50CF900", VA = "0x1850D0D00")]
		private MonoBtlsSslError GetError(int ret_code)
		{
			return MonoBtlsSslError.None;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x50D1770", Offset = "0x50D0370", VA = "0x1850D1770")]
		public void SetCertificate(MonoBtlsX509 x509)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x50D1870", Offset = "0x50D0470", VA = "0x1850D1870")]
		public void SetPrivateKey(MonoBtlsKey key)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x50D0820", Offset = "0x50CF420", VA = "0x1850D0820")]
		public void AddIntermediateCertificate(MonoBtlsX509 x509)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x50D0760", Offset = "0x50CF360", VA = "0x1850D0760")]
		public MonoBtlsSslError Accept()
		{
			return MonoBtlsSslError.None;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x50D0A00", Offset = "0x50CF600", VA = "0x1850D0A00")]
		public MonoBtlsSslError Connect()
		{
			return MonoBtlsSslError.None;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x50D1250", Offset = "0x50CFE50", VA = "0x1850D1250")]
		public MonoBtlsSslError Handshake()
		{
			return MonoBtlsSslError.None;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x50D1310", Offset = "0x50CFF10", VA = "0x1850D1310")]
		[MonoPInvokeCallback(typeof(MonoBtlsSsl.PrintErrorsCallbackFunc))]
		private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx)
		{
			return 0;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x50D0D80", Offset = "0x50CF980", VA = "0x1850D0D80")]
		public string GetErrors()
		{
			return null;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x50D1400", Offset = "0x50D0000", VA = "0x1850D1400")]
		public void PrintErrors()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x50D14E0", Offset = "0x50D00E0", VA = "0x1850D14E0")]
		public MonoBtlsSslError Read(IntPtr data, ref int dataSize)
		{
			return MonoBtlsSslError.None;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x50D1EF0", Offset = "0x50D0AF0", VA = "0x1850D1EF0")]
		public MonoBtlsSslError Write(IntPtr data, ref int dataSize)
		{
			return MonoBtlsSslError.None;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x50D11B0", Offset = "0x50CFDB0", VA = "0x1850D11B0")]
		public int GetVersion()
		{
			return 0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x50D0C20", Offset = "0x50CF820", VA = "0x1850D0C20")]
		public int GetCipher()
		{
			return 0;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x50D0F40", Offset = "0x50CFB40", VA = "0x1850D0F40")]
		public MonoBtlsX509 GetPeerCertificate()
		{
			return null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x50D1AC0", Offset = "0x50D06C0", VA = "0x1850D1AC0")]
		public void SetServerName(string name)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x50D10A0", Offset = "0x50CFCA0", VA = "0x1850D10A0")]
		public string GetServerName()
		{
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x50D1C50", Offset = "0x50D0850", VA = "0x1850D1C50")]
		public void Shutdown()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x50D1970", Offset = "0x50D0570", VA = "0x1850D1970")]
		public void SetQuietShutdown()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x50D0920", Offset = "0x50CF520", VA = "0x1850D0920", Slot = "5")]
		protected override void Close()
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x50D1A10", Offset = "0x50D0610", VA = "0x1850D1A10")]
		public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x50D15E0", Offset = "0x50D01E0", VA = "0x1850D15E0")]
		public bool RenegotiatePending()
		{
			return default(bool);
		}

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MonoBtlsBio bio;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MonoBtlsSsl.PrintErrorsCallbackFunc printErrorsFunc;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IntPtr printErrorsFuncPtr;

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		internal class BoringSslHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000259 RID: 601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringSslHandle(IntPtr handle)
			{
			}

			// Token: 0x0600025A RID: 602 RVA: 0x00002BF8 File Offset: 0x00000DF8
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x50C9700", Offset = "0x50C8300", VA = "0x1850C9700", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x0600025C RID: 604
		[Token(Token = "0x2000081")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int PrintErrorsCallbackFunc(IntPtr str, IntPtr len, IntPtr ctx);
	}
}
