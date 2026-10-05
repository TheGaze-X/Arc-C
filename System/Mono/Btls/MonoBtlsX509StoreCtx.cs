using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	internal class MonoBtlsX509StoreCtx : MonoBtlsObject
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		internal new MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Handle
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x50D7C00", Offset = "0x50D6800", VA = "0x1850D7C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002EF RID: 751
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x50D8080", Offset = "0x50D6C80", VA = "0x1850D8080")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_store_ctx_new();

		// Token: 0x060002F0 RID: 752
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x50D7DD0", Offset = "0x50D69D0", VA = "0x1850D7DD0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx);

		// Token: 0x060002F1 RID: 753
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x50D7ED0", Offset = "0x50D6AD0", VA = "0x1850D7ED0")]
		[PreserveSig]
		private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string);

		// Token: 0x060002F2 RID: 754
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x50D7E50", Offset = "0x50D6A50", VA = "0x1850D7E50")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle);

		// Token: 0x060002F3 RID: 755
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x50D7FE0", Offset = "0x50D6BE0", VA = "0x1850D7FE0")]
		[PreserveSig]
		private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain);

		// Token: 0x060002F4 RID: 756
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x50D80F0", Offset = "0x50D6CF0", VA = "0x1850D80F0")]
		[PreserveSig]
		private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param);

		// Token: 0x060002F5 RID: 757
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x50D8200", Offset = "0x50D6E00", VA = "0x1850D8200")]
		[PreserveSig]
		private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle);

		// Token: 0x060002F6 RID: 758
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x50D7F60", Offset = "0x50D6B60", VA = "0x1850D7F60")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle);

		// Token: 0x060002F7 RID: 759
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x50D8180", Offset = "0x50D6D80", VA = "0x1850D8180")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle);

		// Token: 0x060002F8 RID: 760
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x50D7D50", Offset = "0x50D6950", VA = "0x1850D7D50")]
		[PreserveSig]
		private static extern void mono_btls_x509_store_ctx_free(IntPtr handle);

		// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x50D7AF0", Offset = "0x50D66F0", VA = "0x1850D7AF0")]
		internal MonoBtlsX509StoreCtx()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x50D7130", Offset = "0x50D5D30", VA = "0x1850D7130")]
		private static MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx)
		{
			return null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x50D7940", Offset = "0x50D6540", VA = "0x1850D7940")]
		internal MonoBtlsX509StoreCtx(int preverify_ok, IntPtr store_ctx)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x50D7BD0", Offset = "0x50D67D0", VA = "0x1850D7BD0")]
		internal MonoBtlsX509StoreCtx(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle ptr, int? verifyResult)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x50D73E0", Offset = "0x50D5FE0", VA = "0x1850D73E0")]
		public MonoBtlsX509Error GetError()
		{
			return MonoBtlsX509Error.OK;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x50D7270", Offset = "0x50D5E70", VA = "0x1850D7270")]
		public MonoBtlsX509Chain GetChain()
		{
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x50D7490", Offset = "0x50D6090", VA = "0x1850D7490")]
		public MonoBtlsX509Chain GetUntrusted()
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x50D7600", Offset = "0x50D6200", VA = "0x1850D7600")]
		public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x50D7740", Offset = "0x50D6340", VA = "0x1850D7740")]
		public void SetVerifyParam(MonoBtlsX509VerifyParam param)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700007E")]
		public int VerifyResult
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x50D7CC0", Offset = "0x50D68C0", VA = "0x1850D7CC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x50D7840", Offset = "0x50D6440", VA = "0x1850D7840")]
		public int Verify()
		{
			return 0;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x50D6FB0", Offset = "0x50D5BB0", VA = "0x1850D6FB0")]
		public MonoBtlsX509StoreCtx Copy()
		{
			return null;
		}

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int? verifyResult;

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		internal class BoringX509StoreCtxHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000305 RID: 773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x50C9AE0", Offset = "0x50C86E0", VA = "0x1850C9AE0")]
			internal BoringX509StoreCtxHandle(IntPtr handle, bool ownsHandle = true)
			{
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00002E68 File Offset: 0x00001068
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x50C9B10", Offset = "0x50C8710", VA = "0x1850C9B10", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}

			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool dontFree;
		}
	}
}
