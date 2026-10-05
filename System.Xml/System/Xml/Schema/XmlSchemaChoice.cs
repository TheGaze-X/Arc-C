using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000311")]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		public override XmlSchemaObjectCollection Items
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x38")]
		private XmlSchemaObjectCollection items;
	}
}
