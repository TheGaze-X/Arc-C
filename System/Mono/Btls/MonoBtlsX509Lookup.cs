using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	internal class MonoBtlsX509Lookup : MonoBtlsObject
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		internal new MonoBtlsX509Lookup.BoringX509LookupHandle Handle
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x50D5CF0", Offset = "0x50D48F0", VA = "0x1850D5CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002AB RID: 683
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x50D5F60", Offset = "0x50D4B60", VA = "0x1850D5F60")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type);

		// Token: 0x060002AC RID: 684
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x50D5DB0", Offset = "0x50D49B0", VA = "0x1850D5DB0")]
		[PreserveSig]
		private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type);

		// Token: 0x060002AD RID: 685
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x50D5E50", Offset = "0x50D4A50", VA = "0x1850D5E50")]
		[PreserveSig]
		private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup);

		// Token: 0x060002AE RID: 686
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x50D5EE0", Offset = "0x50D4AE0", VA = "0x1850D5EE0")]
		[PreserveSig]
		private static extern void mono_btls_x509_lookup_free(IntPtr handle);

		// Token: 0x060002AF RID: 687
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x50D5FF0", Offset = "0x50D4BF0", VA = "0x1850D5FF0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle);

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x50D5950", Offset = "0x50D4550", VA = "0x1850D5950")]
		private static MonoBtlsX509Lookup.BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type)
		{
			return null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x50D5B50", Offset = "0x50D4750", VA = "0x1850D5B50")]
		internal MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x50D5AB0", Offset = "0x50D46B0", VA = "0x1850D5AB0")]
		internal IntPtr GetNativeLookup()
		{
			return 0;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x50D53F0", Offset = "0x50D3FF0", VA = "0x1850D53F0")]
		public void AddDirectory(string dir, MonoBtlsX509FileType type)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x50D5590", Offset = "0x50D4190", VA = "0x1850D5590")]
		internal void AddMono(MonoBtlsX509LookupMono monoLookup)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x50D52E0", Offset = "0x50D3EE0", VA = "0x1850D52E0")]
		internal void AddCertificate(MonoBtlsX509 certificate)
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x50D57C0", Offset = "0x50D43C0", VA = "0x1850D57C0", Slot = "5")]
		protected override void Close()
		{
		}

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MonoBtlsX509Store store;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MonoBtlsX509LookupType type;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<MonoBtlsX509LookupMono> monoLookups;

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		internal class BoringX509LookupHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060002B7 RID: 695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringX509LookupHandle(IntPtr handle)
			{
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x00002D60 File Offset: 0x00000F60
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x50C9950", Offset = "0x50C8550", VA = "0x1850C9950", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
