using System;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class X509Stores
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1182440", Offset = "0x1181040", VA = "0x181182440")]
		internal X509Stores(string path, bool newFormat)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public X509Store TrustedRoot
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x4A8FD40", Offset = "0x4A8E940", VA = "0x184A8FD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4A8FC00", Offset = "0x4A8E800", VA = "0x184A8FC00")]
		public X509Store Open(string storeName, bool create)
		{
			return null;
		}

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		private string _storePath;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x18")]
		private bool _newFormat;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x20")]
		private X509Store _trusted;
	}
}
