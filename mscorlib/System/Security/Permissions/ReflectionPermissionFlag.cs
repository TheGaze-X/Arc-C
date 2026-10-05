using System;
using Il2CppDummyDll;

namespace System.Security.Permissions
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	[System.Flags]
	public enum ReflectionPermissionFlag
	{
		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[System.Obsolete("This permission has been deprecated. Use PermissionState.Unrestricted to get full access.")]
		AllFlags = 7,
		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		MemberAccess = 2,
		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		NoFlags = 0,
		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		[System.Obsolete("This permission is no longer used by the CLR.")]
		ReflectionEmit = 4,
		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		RestrictedMemberAccess = 8,
		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[System.Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
		TypeInformation = 1
	}
}
