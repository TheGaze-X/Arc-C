using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Permissions
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	[System.Obsolete("CAS support is not available with Silverlight applications.")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Flags]
	[System.Serializable]
	public enum SecurityPermissionFlag
	{
		// Token: 0x04000D23 RID: 3363
		[Token(Token = "0x4000D23")]
		NoFlags = 0,
		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		Assertion = 1,
		// Token: 0x04000D25 RID: 3365
		[Token(Token = "0x4000D25")]
		UnmanagedCode = 2,
		// Token: 0x04000D26 RID: 3366
		[Token(Token = "0x4000D26")]
		SkipVerification = 4,
		// Token: 0x04000D27 RID: 3367
		[Token(Token = "0x4000D27")]
		Execution = 8,
		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		ControlThread = 16,
		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		ControlEvidence = 32,
		// Token: 0x04000D2A RID: 3370
		[Token(Token = "0x4000D2A")]
		ControlPolicy = 64,
		// Token: 0x04000D2B RID: 3371
		[Token(Token = "0x4000D2B")]
		SerializationFormatter = 128,
		// Token: 0x04000D2C RID: 3372
		[Token(Token = "0x4000D2C")]
		ControlDomainPolicy = 256,
		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		ControlPrincipal = 512,
		// Token: 0x04000D2E RID: 3374
		[Token(Token = "0x4000D2E")]
		ControlAppDomain = 1024,
		// Token: 0x04000D2F RID: 3375
		[Token(Token = "0x4000D2F")]
		RemotingConfiguration = 2048,
		// Token: 0x04000D30 RID: 3376
		[Token(Token = "0x4000D30")]
		Infrastructure = 4096,
		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		BindingRedirects = 8192,
		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		AllFlags = 16383
	}
}
