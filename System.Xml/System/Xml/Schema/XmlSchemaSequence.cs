using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032A")]
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		public override XmlSchemaObjectCollection Items
		{
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x50210E0", Offset = "0x501FCE0", VA = "0x1850210E0")]
		public XmlSchemaSequence()
		{
		}

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x38")]
		private XmlSchemaObjectCollection items;
	}
}
