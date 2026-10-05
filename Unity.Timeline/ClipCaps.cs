using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Flags]
	public enum ClipCaps
	{
		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		None = 0,
		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		Looping = 1,
		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		Extrapolation = 2,
		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		ClipIn = 4,
		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		SpeedMultiplier = 8,
		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		Blending = 16,
		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		AutoScale = 40,
		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		All = -1
	}
}
