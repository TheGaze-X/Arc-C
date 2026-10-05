using System;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x4DF4B70", Offset = "0x4DF3770", VA = "0x184DF4B70")]
		public XmlDocumentWrapper(XmlDocument document)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x4DF4F50", Offset = "0x4DF3B50", VA = "0x184DF4F50", Slot = "15")]
		public IXmlNode CreateComment(string data)
		{
			return null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x4DF52C0", Offset = "0x4DF3EC0", VA = "0x184DF52C0", Slot = "16")]
		public IXmlNode CreateTextNode(string text)
		{
			return null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x4DF4EA0", Offset = "0x4DF3AA0", VA = "0x184DF4EA0", Slot = "17")]
		public IXmlNode CreateCDataSection(string data)
		{
			return null;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x4DF5370", Offset = "0x4DF3F70", VA = "0x184DF5370", Slot = "18")]
		public IXmlNode CreateWhitespace(string text)
		{
			return null;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x4DF5210", Offset = "0x4DF3E10", VA = "0x184DF5210", Slot = "19")]
		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return null;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x4DF5420", Offset = "0x4DF4020", VA = "0x184DF5420", Slot = "20")]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x4DF5500", Offset = "0x4DF4100", VA = "0x184DF5500", Slot = "21")]
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x4DF5150", Offset = "0x4DF3D50", VA = "0x184DF5150", Slot = "22")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x4DF5000", Offset = "0x4DF3C00", VA = "0x184DF5000", Slot = "23")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x4DF50A0", Offset = "0x4DF3CA0", VA = "0x184DF50A0", Slot = "24")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x4DF4CF0", Offset = "0x4DF38F0", VA = "0x184DF4CF0", Slot = "25")]
		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x4DF4DC0", Offset = "0x4DF39C0", VA = "0x184DF4DC0", Slot = "26")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DA")]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x4DF55F0", Offset = "0x4DF41F0", VA = "0x184DF55F0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDocument _document;
	}
}
