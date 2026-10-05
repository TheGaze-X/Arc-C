using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class XDeclaration
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
		public XDeclaration(string version, string encoding, string standalone)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4F89C40", Offset = "0x4F88840", VA = "0x184F89C40")]
		public XDeclaration(XDeclaration other)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000B")]
		public string Encoding
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000C")]
		public string Standalone
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public string Version
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4F89A70", Offset = "0x4F88670", VA = "0x184F89A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private string _version;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private string _encoding;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		private string _standalone;
	}
}
