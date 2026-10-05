using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	internal class MonoBtlsX509 : MonoBtlsObject
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		internal new MonoBtlsX509.BoringX509Handle Handle
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x50DB150", Offset = "0x50D9D50", VA = "0x1850DB150")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4FA7520", Offset = "0x4FA6120", VA = "0x184FA7520")]
		internal MonoBtlsX509(MonoBtlsX509.BoringX509Handle handle)
		{
		}

		// Token: 0x0600028A RID: 650
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x50DB570", Offset = "0x50DA170", VA = "0x1850DB570")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle);

		// Token: 0x0600028B RID: 651
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x50DB3B0", Offset = "0x50D9FB0", VA = "0x1850DB3B0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format);

		// Token: 0x0600028C RID: 652
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x50DB4F0", Offset = "0x50DA0F0", VA = "0x1850DB4F0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle);

		// Token: 0x0600028D RID: 653
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x50DB450", Offset = "0x50DA050", VA = "0x1850DB450")]
		[PreserveSig]
		private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format);

		// Token: 0x0600028E RID: 654
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x50DB2A0", Offset = "0x50D9EA0", VA = "0x1850DB2A0")]
		[PreserveSig]
		private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b);

		// Token: 0x0600028F RID: 655
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x50DB330", Offset = "0x50D9F30", VA = "0x1850DB330")]
		[PreserveSig]
		private static extern void mono_btls_x509_free(IntPtr handle);

		// Token: 0x06000290 RID: 656
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x50DB210", Offset = "0x50D9E10", VA = "0x1850DB210")]
		[PreserveSig]
		private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind);

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x50DA710", Offset = "0x50D9310", VA = "0x1850DA710")]
		internal MonoBtlsX509 Copy()
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x50DAE30", Offset = "0x50D9A30", VA = "0x1850DAE30")]
		public static MonoBtlsX509 LoadFromData(byte[] buffer, MonoBtlsX509Format format)
		{
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x50DACC0", Offset = "0x50D98C0", VA = "0x1850DACC0")]
		public MonoBtlsX509Name GetSubjectName()
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x50DAA80", Offset = "0x50D9680", VA = "0x1850DAA80")]
		public long GetSubjectNameHash()
		{
			return 0L;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x50DA880", Offset = "0x50D9480", VA = "0x1850DA880")]
		public byte[] GetRawData(MonoBtlsX509Format format)
		{
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x50DA640", Offset = "0x50D9240", VA = "0x1850DA640")]
		public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b)
		{
			return 0;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x50DA550", Offset = "0x50D9150", VA = "0x1850DA550")]
		public void AddExplicitTrust(MonoBtlsX509TrustKind kind)
		{
		}

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x200008C")]
		internal class BoringX509Handle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringX509Handle(IntPtr handle)
			{
			}

			// Token: 0x06000299 RID: 665 RVA: 0x00002CE8 File Offset: 0x00000EE8
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x50C9840", Offset = "0x50C8440", VA = "0x1850C9840", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}

			// Token: 0x0600029A RID: 666 RVA: 0x00002D00 File Offset: 0x00000F00
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x50C9900", Offset = "0x50C8500", VA = "0x1850C9900")]
			public IntPtr StealHandle()
			{
				return 0;
			}
		}
	}
}
