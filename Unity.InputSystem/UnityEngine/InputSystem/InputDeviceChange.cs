using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	public enum InputDeviceChange
	{
		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		Added,
		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		Removed,
		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		Disconnected,
		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		Reconnected,
		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		Enabled,
		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		Disabled,
		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		UsageChanged,
		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		ConfigurationChanged,
		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		SoftReset,
		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		HardReset,
		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[Obsolete("Destroyed enum has been deprecated.")]
		Destroyed
	}
}
