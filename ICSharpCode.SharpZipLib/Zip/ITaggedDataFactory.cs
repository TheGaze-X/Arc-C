using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	internal interface ITaggedDataFactory
	{
		// Token: 0x06000392 RID: 914
		[Token(Token = "0x6000392")]
		ITaggedData Create(short tag, byte[] data, int offset, int count);
	}
}
