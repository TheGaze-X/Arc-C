using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	[FriendAccessAllowed]
	internal enum AsyncCausalityStatus
	{
		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		Started,
		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		Completed,
		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		Canceled,
		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		Error
	}
}
