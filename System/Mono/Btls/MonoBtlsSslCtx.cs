using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Util;

namespace Mono.Btls
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	internal class MonoBtlsSslCtx : MonoBtlsObject
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		internal new MonoBtlsSslCtx.BoringSslCtxHandle Handle
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x50D0070", Offset = "0x50CEC70", VA = "0x1850D0070")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600025E RID: 606
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x50D0240", Offset = "0x50CEE40", VA = "0x1850D0240")]
		[PreserveSig]
		private static extern IntPtr mono_btls_ssl_ctx_new();

		// Token: 0x0600025F RID: 607
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x50D0130", Offset = "0x50CED30", VA = "0x1850D0130")]
		[PreserveSig]
		private static extern int mono_btls_ssl_ctx_free(IntPtr handle);

		// Token: 0x06000260 RID: 608
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x50D01B0", Offset = "0x50CEDB0", VA = "0x1850D01B0")]
		[PreserveSig]
		private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance);

		// Token: 0x06000261 RID: 609
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x50D0340", Offset = "0x50CEF40", VA = "0x1850D0340")]
		[PreserveSig]
		private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required);

		// Token: 0x06000262 RID: 610
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x50D02B0", Offset = "0x50CEEB0", VA = "0x1850D02B0")]
		[PreserveSig]
		private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func);

		// Token: 0x06000263 RID: 611
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x50D05B0", Offset = "0x50CF1B0", VA = "0x1850D05B0")]
		[PreserveSig]
		private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version);

		// Token: 0x06000264 RID: 612
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x50D0520", Offset = "0x50CF120", VA = "0x1850D0520")]
		[PreserveSig]
		private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version);

		// Token: 0x06000265 RID: 613
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x50D03E0", Offset = "0x50CEFE0", VA = "0x1850D03E0")]
		[PreserveSig]
		private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported);

		// Token: 0x06000266 RID: 614
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x50D06D0", Offset = "0x50CF2D0", VA = "0x1850D06D0")]
		[PreserveSig]
		private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param);

		// Token: 0x06000267 RID: 615
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x50D0480", Offset = "0x50CF080", VA = "0x1850D0480")]
		[PreserveSig]
		private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data);

		// Token: 0x06000268 RID: 616
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x50D0640", Offset = "0x50CF240", VA = "0x1850D0640")]
		[PreserveSig]
		private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func);

		// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x50CF9E0", Offset = "0x50CE5E0", VA = "0x1850CF9E0")]
		public MonoBtlsSslCtx()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x50CFAC0", Offset = "0x50CE6C0", VA = "0x1850CFAC0")]
		internal MonoBtlsSslCtx(MonoBtlsSslCtx.BoringSslCtxHandle handle)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		public MonoBtlsX509Store CertificateStore
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x50CF9B0", Offset = "0x50CE5B0", VA = "0x1850CF9B0")]
		private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx)
		{
			return 0;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x50CEB50", Offset = "0x50CD750", VA = "0x1850CEB50")]
		[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeVerifyFunc))]
		private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx)
		{
			return 0;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x50CE8F0", Offset = "0x50CD4F0", VA = "0x1850CE8F0")]
		[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeSelectFunc))]
		private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data)
		{
			return 0;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x50CE410", Offset = "0x50CD010", VA = "0x1850CE410")]
		private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr)
		{
			return null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x50CF7C0", Offset = "0x50CE3C0", VA = "0x1850CF7C0")]
		public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x50CF640", Offset = "0x50CE240", VA = "0x1850CF640")]
		public void SetSelectCallback(MonoBtlsSelectCallback callback)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x50CF590", Offset = "0x50CE190", VA = "0x1850CF590")]
		public void SetMinVersion(int version)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x50CF4E0", Offset = "0x50CE0E0", VA = "0x1850CF4E0")]
		public void SetMaxVersion(int version)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x50CEEC0", Offset = "0x50CDAC0", VA = "0x1850CEEC0")]
		public void SetCiphers(short[] ciphers, bool allow_unsupported)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x50CF8A0", Offset = "0x50CE4A0", VA = "0x1850CF8A0")]
		public void SetVerifyParam(MonoBtlsX509VerifyParam param)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x50CF0D0", Offset = "0x50CDCD0", VA = "0x1850CF0D0")]
		public void SetClientCertificateIssuers(string[] acceptableIssuers)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x50CF700", Offset = "0x50CE300", VA = "0x1850CF700")]
		public void SetServerNameCallback(MonoBtlsServerNameCallback callback)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x50CEA40", Offset = "0x50CD640", VA = "0x1850CEA40")]
		[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeServerNameFunc))]
		private static int NativeServerNameCallback(IntPtr instance)
		{
			return 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x50CE3B0", Offset = "0x50CCFB0", VA = "0x1850CE3B0", Slot = "5")]
		protected override void Close()
		{
		}

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MonoBtlsSslCtx.NativeVerifyFunc verifyFunc;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MonoBtlsSslCtx.NativeSelectFunc selectFunc;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonoBtlsSslCtx.NativeServerNameFunc serverNameFunc;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr verifyFuncPtr;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr selectFuncPtr;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IntPtr serverNameFuncPtr;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MonoBtlsVerifyCallback verifyCallback;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MonoBtlsSelectCallback selectCallback;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MonoBtlsServerNameCallback serverNameCallback;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MonoBtlsX509Store store;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GCHandle instance;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IntPtr instancePtr;

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		internal class BoringSslCtxHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x0600027A RID: 634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringSslCtxHandle(IntPtr handle)
			{
			}

			// Token: 0x0600027B RID: 635 RVA: 0x00002C70 File Offset: 0x00000E70
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x50C9670", Offset = "0x50C8270", VA = "0x1850C9670", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x0600027D RID: 637
		[Token(Token = "0x2000084")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int NativeVerifyFunc(IntPtr instance, int preverify_ok, IntPtr ctx);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x0600027F RID: 639
		[Token(Token = "0x2000085")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int NativeSelectFunc(IntPtr instance, int count, IntPtr sizes, IntPtr data);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000281 RID: 641
		[Token(Token = "0x2000086")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int NativeServerNameFunc(IntPtr instance);
	}
}
