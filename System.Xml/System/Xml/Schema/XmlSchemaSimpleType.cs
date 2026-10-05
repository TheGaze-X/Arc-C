using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x5021850", Offset = "0x5020450", VA = "0x185021850")]
		public XmlSchemaSimpleType()
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032B")]
		[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
		[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
		[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
		public XmlSchemaSimpleTypeContent Content
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x40")]
		private XmlSchemaSimpleTypeContent content;
	}
}
