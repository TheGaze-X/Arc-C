using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	public enum MethodImplAttributes
	{
		// Token: 0x04001508 RID: 5384
		[Token(Token = "0x4001508")]
		CodeTypeMask = 3,
		// Token: 0x04001509 RID: 5385
		[Token(Token = "0x4001509")]
		IL = 0,
		// Token: 0x0400150A RID: 5386
		[Token(Token = "0x400150A")]
		Native,
		// Token: 0x0400150B RID: 5387
		[Token(Token = "0x400150B")]
		OPTIL,
		// Token: 0x0400150C RID: 5388
		[Token(Token = "0x400150C")]
		Runtime,
		// Token: 0x0400150D RID: 5389
		[Token(Token = "0x400150D")]
		ManagedMask,
		// Token: 0x0400150E RID: 5390
		[Token(Token = "0x400150E")]
		Unmanaged = 4,
		// Token: 0x0400150F RID: 5391
		[Token(Token = "0x400150F")]
		Managed = 0,
		// Token: 0x04001510 RID: 5392
		[Token(Token = "0x4001510")]
		ForwardRef = 16,
		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		PreserveSig = 128,
		// Token: 0x04001512 RID: 5394
		[Token(Token = "0x4001512")]
		InternalCall = 4096,
		// Token: 0x04001513 RID: 5395
		[Token(Token = "0x4001513")]
		Synchronized = 32,
		// Token: 0x04001514 RID: 5396
		[Token(Token = "0x4001514")]
		NoInlining = 8,
		// Token: 0x04001515 RID: 5397
		[Token(Token = "0x4001515")]
		AggressiveInlining = 256,
		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001516")]
		NoOptimization = 64,
		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x4001517")]
		MaxMethodImplVal = 65535,
		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x4001518")]
		SecurityMitigations = 1024
	}
}
