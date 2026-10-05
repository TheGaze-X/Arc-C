using System;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x200066F")]
	[System.Flags]
	public enum FileAttributes
	{
		// Token: 0x04001B40 RID: 6976
		[Token(Token = "0x4001B40")]
		ReadOnly = 1,
		// Token: 0x04001B41 RID: 6977
		[Token(Token = "0x4001B41")]
		Hidden = 2,
		// Token: 0x04001B42 RID: 6978
		[Token(Token = "0x4001B42")]
		System = 4,
		// Token: 0x04001B43 RID: 6979
		[Token(Token = "0x4001B43")]
		Directory = 16,
		// Token: 0x04001B44 RID: 6980
		[Token(Token = "0x4001B44")]
		Archive = 32,
		// Token: 0x04001B45 RID: 6981
		[Token(Token = "0x4001B45")]
		Device = 64,
		// Token: 0x04001B46 RID: 6982
		[Token(Token = "0x4001B46")]
		Normal = 128,
		// Token: 0x04001B47 RID: 6983
		[Token(Token = "0x4001B47")]
		Temporary = 256,
		// Token: 0x04001B48 RID: 6984
		[Token(Token = "0x4001B48")]
		SparseFile = 512,
		// Token: 0x04001B49 RID: 6985
		[Token(Token = "0x4001B49")]
		ReparsePoint = 1024,
		// Token: 0x04001B4A RID: 6986
		[Token(Token = "0x4001B4A")]
		Compressed = 2048,
		// Token: 0x04001B4B RID: 6987
		[Token(Token = "0x4001B4B")]
		Offline = 4096,
		// Token: 0x04001B4C RID: 6988
		[Token(Token = "0x4001B4C")]
		NotContentIndexed = 8192,
		// Token: 0x04001B4D RID: 6989
		[Token(Token = "0x4001B4D")]
		Encrypted = 16384,
		// Token: 0x04001B4E RID: 6990
		[Token(Token = "0x4001B4E")]
		IntegrityStream = 32768,
		// Token: 0x04001B4F RID: 6991
		[Token(Token = "0x4001B4F")]
		NoScrubData = 131072
	}
}
