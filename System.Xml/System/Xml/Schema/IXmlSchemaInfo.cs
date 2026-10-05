using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public interface IXmlSchemaInfo
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000A10 RID: 2576
		[Token(Token = "0x170002AF")]
		XmlSchemaValidity Validity { [Token(Token = "0x6000A10")] get; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000A11 RID: 2577
		[Token(Token = "0x170002B0")]
		bool IsDefault { [Token(Token = "0x6000A11")] get; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000A12 RID: 2578
		[Token(Token = "0x170002B1")]
		bool IsNil { [Token(Token = "0x6000A12")] get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000A13 RID: 2579
		[Token(Token = "0x170002B2")]
		XmlSchemaSimpleType MemberType { [Token(Token = "0x6000A13")] get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000A14 RID: 2580
		[Token(Token = "0x170002B3")]
		XmlSchemaType SchemaType { [Token(Token = "0x6000A14")] get; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000A15 RID: 2581
		[Token(Token = "0x170002B4")]
		XmlSchemaElement SchemaElement { [Token(Token = "0x6000A15")] get; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000A16 RID: 2582
		[Token(Token = "0x170002B5")]
		XmlSchemaAttribute SchemaAttribute { [Token(Token = "0x6000A16")] get; }
	}
}
