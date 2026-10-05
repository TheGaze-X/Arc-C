using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	internal interface IXmlElement : IXmlNode
	{
		// Token: 0x06000AB3 RID: 2739
		[Token(Token = "0x6000AB3")]
		void SetAttributeNode(IXmlNode attribute);

		// Token: 0x06000AB4 RID: 2740
		[Token(Token = "0x6000AB4")]
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AB5 RID: 2741
		[Token(Token = "0x170001F4")]
		bool IsEmpty { [Token(Token = "0x6000AB5")] get; }
	}
}
