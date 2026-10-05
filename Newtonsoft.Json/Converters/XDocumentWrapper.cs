using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000207")]
		private XDocument Document
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x4DF3B80", Offset = "0x4DF2780", VA = "0x184DF3B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x4DF2930", Offset = "0x4DF1530", VA = "0x184DF2930")]
		public XDocumentWrapper(XDocument document)
		{
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000208")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x4DF3980", Offset = "0x4DF2580", VA = "0x184DF3980", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x4DF32D0", Offset = "0x4DF1ED0", VA = "0x184DF32D0", Slot = "23")]
		public IXmlNode CreateComment(string text)
		{
			return null;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x4DF36C0", Offset = "0x4DF22C0", VA = "0x184DF36C0", Slot = "24")]
		public IXmlNode CreateTextNode(string text)
		{
			return null;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x4DF3230", Offset = "0x4DF1E30", VA = "0x184DF3230", Slot = "25")]
		public IXmlNode CreateCDataSection(string data)
		{
			return null;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x4DF3760", Offset = "0x4DF2360", VA = "0x184DF3760", Slot = "26")]
		public IXmlNode CreateWhitespace(string text)
		{
			return null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x4DF3620", Offset = "0x4DF2220", VA = "0x184DF3620", Slot = "27")]
		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return null;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x4DF3800", Offset = "0x4DF2400", VA = "0x184DF3800", Slot = "28")]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x4DF38C0", Offset = "0x4DF24C0", VA = "0x184DF38C0", Slot = "29")]
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x4DF3540", Offset = "0x4DF2140", VA = "0x184DF3540", Slot = "30")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x4DF3370", Offset = "0x4DF1F70", VA = "0x184DF3370", Slot = "31")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x4DF3450", Offset = "0x4DF2050", VA = "0x184DF3450", Slot = "32")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x4DF3040", Offset = "0x4DF1C40", VA = "0x184DF3040", Slot = "33")]
		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x4DF3130", Offset = "0x4DF1D30", VA = "0x184DF3130", Slot = "34")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000209")]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x4DF3A90", Offset = "0x4DF2690", VA = "0x184DF3A90", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x4DF2F00", Offset = "0x4DF1B00", VA = "0x184DF2F00", Slot = "21")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
