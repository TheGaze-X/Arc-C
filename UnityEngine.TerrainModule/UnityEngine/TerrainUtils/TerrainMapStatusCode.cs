using System;
using Il2CppDummyDll;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	internal enum TerrainMapStatusCode
	{
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		OK,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		Overlapping,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		SizeMismatch = 4,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		EdgeAlignmentMismatch = 8
	}
}
