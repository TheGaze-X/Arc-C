using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public interface IXmlNamespaceResolver
	{
		// Token: 0x06000637 RID: 1591
		[Token(Token = "0x6000637")]
		string LookupNamespace(string prefix);

		// Token: 0x06000638 RID: 1592
		[Token(Token = "0x6000638")]
		string LookupPrefix(string namespaceName);
	}
}
