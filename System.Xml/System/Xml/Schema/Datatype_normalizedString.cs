using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	internal class Datatype_normalizedString : Datatype_string
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x17000266")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x5000DB0", Offset = "0x4FFF9B0", VA = "0x185000DB0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x17000267")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "14")]
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x4FF9F50", Offset = "0x4FF8B50", VA = "0x184FF9F50")]
		public Datatype_normalizedString()
		{
		}
	}
}
