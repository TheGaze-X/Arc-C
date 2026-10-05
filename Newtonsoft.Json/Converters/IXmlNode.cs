using System;
using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	internal interface IXmlNode
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000AB6 RID: 2742
		[Token(Token = "0x170001F5")]
		XmlNodeType NodeType { [Token(Token = "0x6000AB6")] get; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000AB7 RID: 2743
		[Token(Token = "0x170001F6")]
		string LocalName { [Token(Token = "0x6000AB7")] get; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000AB8 RID: 2744
		[Token(Token = "0x170001F7")]
		List<IXmlNode> ChildNodes { [Token(Token = "0x6000AB8")] get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000AB9 RID: 2745
		[Token(Token = "0x170001F8")]
		List<IXmlNode> Attributes { [Token(Token = "0x6000AB9")] get; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000ABA RID: 2746
		[Token(Token = "0x170001F9")]
		IXmlNode ParentNode { [Token(Token = "0x6000ABA")] get; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000ABB RID: 2747
		// (set) Token: 0x06000ABC RID: 2748
		[Token(Token = "0x170001FA")]
		string Value { [Token(Token = "0x6000ABB")] get; [Token(Token = "0x6000ABC")] set; }

		// Token: 0x06000ABD RID: 2749
		[Token(Token = "0x6000ABD")]
		IXmlNode AppendChild(IXmlNode newChild);

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000ABE RID: 2750
		[Token(Token = "0x170001FB")]
		string NamespaceUri { [Token(Token = "0x6000ABE")] get; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000ABF RID: 2751
		[Token(Token = "0x170001FC")]
		object WrappedNode { [Token(Token = "0x6000ABF")] get; }
	}
}
