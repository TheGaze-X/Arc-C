using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x06000A9D RID: 2717
		[Token(Token = "0x6000A9D")]
		IXmlNode CreateComment(string text);

		// Token: 0x06000A9E RID: 2718
		[Token(Token = "0x6000A9E")]
		IXmlNode CreateTextNode(string text);

		// Token: 0x06000A9F RID: 2719
		[Token(Token = "0x6000A9F")]
		IXmlNode CreateCDataSection(string data);

		// Token: 0x06000AA0 RID: 2720
		[Token(Token = "0x6000AA0")]
		IXmlNode CreateWhitespace(string text);

		// Token: 0x06000AA1 RID: 2721
		[Token(Token = "0x6000AA1")]
		IXmlNode CreateSignificantWhitespace(string text);

		// Token: 0x06000AA2 RID: 2722
		[Token(Token = "0x6000AA2")]
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		// Token: 0x06000AA3 RID: 2723
		[Token(Token = "0x6000AA3")]
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06000AA4 RID: 2724
		[Token(Token = "0x6000AA4")]
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x06000AA5 RID: 2725
		[Token(Token = "0x6000AA5")]
		IXmlElement CreateElement(string elementName);

		// Token: 0x06000AA6 RID: 2726
		[Token(Token = "0x6000AA6")]
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x06000AA7 RID: 2727
		[Token(Token = "0x6000AA7")]
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x06000AA8 RID: 2728
		[Token(Token = "0x6000AA8")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AA9 RID: 2729
		[Token(Token = "0x170001EC")]
		IXmlElement DocumentElement { [Token(Token = "0x6000AA9")] get; }
	}
}
