using System;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x4DF4B70", Offset = "0x4DF3770", VA = "0x184DF4B70")]
		public XmlElementWrapper(XmlElement element)
		{
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x4DF56A0", Offset = "0x4DF42A0", VA = "0x184DF56A0", Slot = "15")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x4C6A820", Offset = "0x4C69420", VA = "0x184C6A820", Slot = "16")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x170001DB")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x4DF5810", Offset = "0x4DF4410", VA = "0x184DF5810", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlElement _element;
	}
}
