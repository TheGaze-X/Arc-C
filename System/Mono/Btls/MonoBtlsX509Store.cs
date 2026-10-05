using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	internal class MonoBtlsX509Store : MonoBtlsObject
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		internal new MonoBtlsX509Store.BoringX509StoreHandle Handle
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x50D9520", Offset = "0x50D8120", VA = "0x1850D9520")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002DF RID: 735
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x50D9770", Offset = "0x50D8370", VA = "0x1850D9770")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_store_new();

		// Token: 0x060002E0 RID: 736
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x50D96F0", Offset = "0x50D82F0", VA = "0x1850D96F0")]
		[PreserveSig]
		private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle);

		// Token: 0x060002E1 RID: 737
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x50D95E0", Offset = "0x50D81E0", VA = "0x1850D95E0")]
		[PreserveSig]
		private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509);

		// Token: 0x060002E2 RID: 738
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x50D9670", Offset = "0x50D8270", VA = "0x1850D9670")]
		[PreserveSig]
		private static extern void mono_btls_x509_store_free(IntPtr handle);

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x50D9140", Offset = "0x50D7D40", VA = "0x1850D9140")]
		private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal()
		{
			return null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x50D8FF0", Offset = "0x50D7BF0", VA = "0x1850D8FF0")]
		private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal(MonoBtlsSslCtx.BoringSslCtxHandle ctx)
		{
			return null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x50D9270", Offset = "0x50D7E70", VA = "0x1850D9270")]
		internal MonoBtlsX509Store()
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x50D93C0", Offset = "0x50D7FC0", VA = "0x1850D93C0")]
		internal MonoBtlsX509Store(MonoBtlsSslCtx.BoringSslCtxHandle ctx)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x50D8890", Offset = "0x50D7490", VA = "0x1850D8890")]
		public void AddCertificate(MonoBtlsX509 x509)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x50D8C60", Offset = "0x50D7860", VA = "0x1850D8C60")]
		public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type)
		{
			return null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x50D8A60", Offset = "0x50D7660", VA = "0x1850D8A60")]
		public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x50D8990", Offset = "0x50D7590", VA = "0x1850D8990")]
		public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x50D8E40", Offset = "0x50D7A40", VA = "0x1850D8E40", Slot = "5")]
		protected override void Close()
		{
		}

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash;

		// Token: 0x0200009D RID: 157
		[Token(Token = "0x200009D")]
		internal class BoringX509StoreHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060002EC RID: 748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x50C96F0", Offset = "0x50C82F0", VA = "0x1850C96F0")]
			public BoringX509StoreHandle(IntPtr handle)
			{
			}

			// Token: 0x060002ED RID: 749 RVA: 0x00002E08 File Offset: 0x00001008
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x50C9BA0", Offset = "0x50C87A0", VA = "0x1850C9BA0", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
