using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	internal interface IDtdParser
	{
		// Token: 0x0600008E RID: 142
		[Token(Token = "0x600008E")]
		IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

		// Token: 0x0600008F RID: 143
		[Token(Token = "0x600008F")]
		IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
	}
}
