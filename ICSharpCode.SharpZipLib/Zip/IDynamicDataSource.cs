using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public interface IDynamicDataSource
	{
		// Token: 0x0600046B RID: 1131
		[Token(Token = "0x600046B")]
		Stream GetSource(ZipEntry entry, string name);
	}
}
