using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[XmlTypeConvertor("ConvertForAssignment")]
	[XmlSchemaProvider(null, IsAny = true)]
	public class XElement : XContainer
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4F8B9D0", Offset = "0x4F8A5D0", VA = "0x184F8B9D0")]
		public XElement(XName name)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4F8B790", Offset = "0x4F8A390", VA = "0x184F8B790")]
		public XElement(XElement other)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4F8B930", Offset = "0x4F8A530", VA = "0x184F8B930")]
		public XElement(XStreamingElement other)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000016")]
		public bool IsEmpty
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x4F8BA60", Offset = "0x4F8A660", VA = "0x184F8BA60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public XName Name
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000018")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000019")]
		public string Value
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x4F8BA70", Offset = "0x4F8A670", VA = "0x184F8BA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x4F8BB20", Offset = "0x4F8A720", VA = "0x184F8BB20")]
			set
			{
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4F8AF60", Offset = "0x4F89B60", VA = "0x184F8AF60")]
		public XAttribute Attribute(XName name)
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4F8AFA0", Offset = "0x4F89BA0", VA = "0x184F8AFA0")]
		public IEnumerable<XAttribute> Attributes()
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4F8B200", Offset = "0x4F89E00", VA = "0x184F8B200")]
		public string GetPrefixOfNamespace(XNamespace ns)
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4F8B6D0", Offset = "0x4F8A2D0", VA = "0x184F8B6D0", Slot = "5")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4F8AAD0", Offset = "0x4F896D0", VA = "0x184F8AAD0", Slot = "8")]
		internal override void AddAttribute(XAttribute a)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4F8A940", Offset = "0x4F89540", VA = "0x184F8A940", Slot = "9")]
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x4F8ADD0", Offset = "0x4F899D0", VA = "0x184F8ADD0")]
		internal void AppendAttribute(XAttribute a)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4F8AD50", Offset = "0x4F89950", VA = "0x184F8AD50")]
		internal void AppendAttributeSkipNotify(XAttribute a)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4F8B030", Offset = "0x4F89C30", VA = "0x184F8B030", Slot = "7")]
		internal override XNode CloneNode()
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x4F8B090", Offset = "0x4F89C90", VA = "0x184F8B090")]
		private IEnumerable<XAttribute> GetAttributes(XName name)
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4F8B130", Offset = "0x4F89D30", VA = "0x184F8B130")]
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4F8B4D0", Offset = "0x4F8A0D0", VA = "0x184F8B4D0", Slot = "10")]
		internal override void ValidateNode(XNode node, XNode previous)
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x30")]
		internal XName name;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x38")]
		internal XAttribute lastAttr;
	}
}
