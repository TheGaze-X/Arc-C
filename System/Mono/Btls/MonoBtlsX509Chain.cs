using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	internal class MonoBtlsX509Chain : MonoBtlsObject
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		internal new MonoBtlsX509Chain.BoringX509ChainHandle Handle
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x50D3F00", Offset = "0x50D2B00", VA = "0x1850D3F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600029C RID: 668
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x50D41E0", Offset = "0x50D2DE0", VA = "0x1850D41E0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_chain_new();

		// Token: 0x0600029D RID: 669
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x50D4160", Offset = "0x50D2D60", VA = "0x1850D4160")]
		[PreserveSig]
		private static extern int mono_btls_x509_chain_get_count(IntPtr handle);

		// Token: 0x0600029E RID: 670
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x50D40D0", Offset = "0x50D2CD0", VA = "0x1850D40D0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index);

		// Token: 0x0600029F RID: 671
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x50D3FC0", Offset = "0x50D2BC0", VA = "0x1850D3FC0")]
		[PreserveSig]
		private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509);

		// Token: 0x060002A0 RID: 672
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x50D4250", Offset = "0x50D2E50", VA = "0x1850D4250")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle);

		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x50D4050", Offset = "0x50D2C50", VA = "0x1850D4050")]
		[PreserveSig]
		private static extern void mono_btls_x509_chain_free(IntPtr handle);

		// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x50D3D80", Offset = "0x50D2980", VA = "0x1850D3D80")]
		public MonoBtlsX509Chain()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4FA7520", Offset = "0x4FA6120", VA = "0x184FA7520")]
		internal MonoBtlsX509Chain(MonoBtlsX509Chain.BoringX509ChainHandle handle)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x17000078")]
		public int Count
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x50D3E60", Offset = "0x50D2A60", VA = "0x1850D3E60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x50D3BB0", Offset = "0x50D27B0", VA = "0x1850D3BB0")]
		public MonoBtlsX509 GetCertificate(int index)
		{
			return null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x50D3980", Offset = "0x50D2580", VA = "0x1850D3980")]
		public void AddCertificate(MonoBtlsX509 x509)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x50D3A40", Offset = "0x50D2640", VA = "0x1850D3A40")]
		internal MonoBtlsX509Chain Copy()
		{
			return null;
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		internal class BoringX509ChainHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringX509ChainHandle(IntPtr handle)
			{
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00002D30 File Offset: 0x00000F30
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x50C97C0", Offset = "0x50C83C0", VA = "0x1850C97C0", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
