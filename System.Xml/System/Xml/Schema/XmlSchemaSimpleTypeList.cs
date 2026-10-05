using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		// Token: 0x1700032C RID: 812
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032C")]
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaSimpleType ItemType
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032D")]
		[XmlIgnore]
		public XmlSchemaSimpleType BaseItemType
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x5021680", Offset = "0x5020280", VA = "0x185021680")]
		public XmlSchemaSimpleTypeList()
		{
		}

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x10")]
		private XmlQualifiedName itemTypeName;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x18")]
		private XmlSchemaSimpleType itemType;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x20")]
		private XmlSchemaSimpleType baseItemType;
	}
}
