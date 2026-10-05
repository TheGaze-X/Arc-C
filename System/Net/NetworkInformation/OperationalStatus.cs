using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200036A RID: 874
	[Token(Token = "0x200036A")]
	public enum OperationalStatus
	{
		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		Up = 1,
		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		Down,
		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		Testing,
		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		Unknown,
		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		Dormant,
		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		NotPresent,
		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		LowerLayerDown
	}
}
