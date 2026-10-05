using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	internal class Datatype_fixed : Datatype_decimal
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x4FFEAE0", Offset = "0x4FFD6E0", VA = "0x184FFEAE0", Slot = "6")]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			return null;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x4FFEDB0", Offset = "0x4FFD9B0", VA = "0x184FFEDB0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x4FFEFB0", Offset = "0x4FFDBB0", VA = "0x184FFEFB0")]
		public Datatype_fixed()
		{
		}
	}
}
