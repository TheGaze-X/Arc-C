using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	[System.Flags]
	public enum DllImportSearchPath
	{
		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		UseDllDirectoryForDependencies = 256,
		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		ApplicationDirectory = 512,
		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		UserDirectories = 1024,
		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		System32 = 2048,
		// Token: 0x04001392 RID: 5010
		[Token(Token = "0x4001392")]
		SafeDirectories = 4096,
		// Token: 0x04001393 RID: 5011
		[Token(Token = "0x4001393")]
		AssemblyDirectory = 2,
		// Token: 0x04001394 RID: 5012
		[Token(Token = "0x4001394")]
		LegacyBehavior = 0
	}
}
