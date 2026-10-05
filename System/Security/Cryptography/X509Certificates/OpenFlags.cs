using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	[Flags]
	public enum OpenFlags
	{
		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		ReadOnly = 0,
		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		ReadWrite = 1,
		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		MaxAllowed = 2,
		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		OpenExistingOnly = 4,
		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		IncludeArchived = 8
	}
}
