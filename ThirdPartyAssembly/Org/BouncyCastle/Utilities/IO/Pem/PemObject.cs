using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public class PemObject : PemObjectGenerator
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x5467270", Offset = "0x5465E70", VA = "0x185467270")]
		public PemObject(string type, byte[] content)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x54672F0", Offset = "0x5465EF0", VA = "0x1854672F0")]
		public PemObject(string type, IList headers, byte[] content)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CB")]
		public string Type
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		public IList Headers
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		public byte[] Content
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000790")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "4")]
		public PemObject Generate()
		{
			return null;
		}

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x10")]
		private string type;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x18")]
		private IList headers;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x20")]
		private byte[] content;
	}
}
