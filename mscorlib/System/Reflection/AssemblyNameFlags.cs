using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	[System.Flags]
	public enum AssemblyNameFlags
	{
		// Token: 0x04001492 RID: 5266
		[Token(Token = "0x4001492")]
		None = 0,
		// Token: 0x04001493 RID: 5267
		[Token(Token = "0x4001493")]
		PublicKey = 1,
		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x4001494")]
		EnableJITcompileOptimizer = 16384,
		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		EnableJITcompileTracking = 32768,
		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001496")]
		Retargetable = 256
	}
}
