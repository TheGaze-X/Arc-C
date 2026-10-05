using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public class X509ChainElement
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x512FFC0", Offset = "0x512EBC0", VA = "0x18512FFC0")]
		internal X509ChainElement(X509Certificate2 certificate)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public X509Certificate2 Certificate
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		public X509ChainStatus[] ChainElementStatus
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000186")]
		internal X509ChainStatusFlags StatusFlags
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return X509ChainStatusFlags.NoError;
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x512EFE0", Offset = "0x512DBE0", VA = "0x18512EFE0")]
		private int Count(X509ChainStatusFlags flags)
		{
			return 0;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x512F010", Offset = "0x512DC10", VA = "0x18512F010")]
		private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x512F090", Offset = "0x512DC90", VA = "0x18512F090")]
		internal void UncompressFlags()
		{
		}

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x10")]
		private X509Certificate2 certificate;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x18")]
		private X509ChainStatus[] status;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x20")]
		private string info;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x28")]
		private X509ChainStatusFlags compressed_status_flags;
	}
}
