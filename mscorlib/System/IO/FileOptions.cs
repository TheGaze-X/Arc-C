using System;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200064C RID: 1612
	[Token(Token = "0x200064C")]
	[System.Flags]
	public enum FileOptions
	{
		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		None = 0,
		// Token: 0x04001AB2 RID: 6834
		[Token(Token = "0x4001AB2")]
		WriteThrough = -2147483648,
		// Token: 0x04001AB3 RID: 6835
		[Token(Token = "0x4001AB3")]
		Asynchronous = 1073741824,
		// Token: 0x04001AB4 RID: 6836
		[Token(Token = "0x4001AB4")]
		RandomAccess = 268435456,
		// Token: 0x04001AB5 RID: 6837
		[Token(Token = "0x4001AB5")]
		DeleteOnClose = 67108864,
		// Token: 0x04001AB6 RID: 6838
		[Token(Token = "0x4001AB6")]
		SequentialScan = 134217728,
		// Token: 0x04001AB7 RID: 6839
		[Token(Token = "0x4001AB7")]
		Encrypted = 16384
	}
}
