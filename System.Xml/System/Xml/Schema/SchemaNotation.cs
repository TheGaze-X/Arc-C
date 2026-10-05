using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	internal sealed class SchemaNotation
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal SchemaNotation(XmlQualifiedName name)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000300")]
		internal XmlQualifiedName Name
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000301")]
		internal string SystemLiteral
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000302")]
		internal string Pubid
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x10")]
		private XmlQualifiedName name;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x18")]
		private string systemLiteral;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x20")]
		private string pubid;
	}
}
