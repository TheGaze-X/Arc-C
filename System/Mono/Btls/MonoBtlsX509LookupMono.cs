using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Util;

namespace Mono.Btls
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		internal new MonoBtlsX509LookupMono.BoringX509LookupMonoHandle Handle
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x50D5090", Offset = "0x50D3C90", VA = "0x1850D5090")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002BA RID: 698
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x50D5270", Offset = "0x50D3E70", VA = "0x1850D5270")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_lookup_mono_new();

		// Token: 0x060002BB RID: 699
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x50D51D0", Offset = "0x50D3DD0", VA = "0x1850D51D0")]
		[PreserveSig]
		private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func);

		// Token: 0x060002BC RID: 700
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x50D5150", Offset = "0x50D3D50", VA = "0x1850D5150")]
		[PreserveSig]
		private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle);

		// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x50D4DD0", Offset = "0x50D39D0", VA = "0x1850D4DD0")]
		internal MonoBtlsX509LookupMono()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x50D4A00", Offset = "0x50D3600", VA = "0x1850D4A00")]
		internal void Install(MonoBtlsX509Lookup lookup)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x50D4850", Offset = "0x50D3450", VA = "0x1850D4850")]
		protected void AddCertificate(MonoBtlsX509 certificate)
		{
		}

		// Token: 0x060002C0 RID: 704
		[Token(Token = "0x60002C0")]
		protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name);

		// Token: 0x060002C1 RID: 705 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x50D4A70", Offset = "0x50D3670", VA = "0x1850D4A70")]
		[MonoPInvokeCallback(typeof(MonoBtlsX509LookupMono.BySubjectFunc))]
		private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr)
		{
			return 0;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x50D4970", Offset = "0x50D3570", VA = "0x1850D4970", Slot = "5")]
		protected override void Close()
		{
		}

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle gch;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr instance;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonoBtlsX509LookupMono.BySubjectFunc bySubjectFunc;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr bySubjectFuncPtr;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MonoBtlsX509Lookup lookup;

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		internal class BoringX509LookupMonoHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringX509LookupMonoHandle(IntPtr handle)
			{
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x00002D90 File Offset: 0x00000F90
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x50C99D0", Offset = "0x50C85D0", VA = "0x1850C99D0", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060002C6 RID: 710
		[Token(Token = "0x2000096")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int BySubjectFunc(IntPtr instance, IntPtr name, out IntPtr x509_ptr);
	}
}
