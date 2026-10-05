using System;
using Il2CppDummyDll;

namespace JetBrains.Annotations
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Flags]
	public enum ImplicitUseTargetFlags
	{
		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		Default = 1,
		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		Itself = 1,
		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		Members = 2,
		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		WithMembers = 3
	}
}
