using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Users
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[Flags]
	public enum InputUserPairingOptions
	{
		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		None = 0,
		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		ForcePlatformUserAccountSelection = 1,
		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		ForceNoPlatformUserAccountSelection = 2,
		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		UnpairCurrentDevicesFromUser = 8
	}
}
