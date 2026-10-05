using System;
using ICSharpCode.SharpZipLib.Core;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public interface IEntryFactory
	{
		// Token: 0x06000301 RID: 769
		[Token(Token = "0x6000301")]
		ZipEntry MakeFileEntry(string fileName);

		// Token: 0x06000302 RID: 770
		[Token(Token = "0x6000302")]
		ZipEntry MakeFileEntry(string fileName, bool useFileSystem);

		// Token: 0x06000303 RID: 771
		[Token(Token = "0x6000303")]
		ZipEntry MakeDirectoryEntry(string directoryName);

		// Token: 0x06000304 RID: 772
		[Token(Token = "0x6000304")]
		ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem);

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000305 RID: 773
		// (set) Token: 0x06000306 RID: 774
		[Token(Token = "0x170000A0")]
		INameTransform NameTransform { [Token(Token = "0x6000305")] get; [Token(Token = "0x6000306")] set; }
	}
}
