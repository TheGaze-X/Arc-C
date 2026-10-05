using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public enum CollisionFlags
	{
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		None,
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		Sides,
		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		Above,
		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		Below = 4,
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		CollidedSides = 1,
		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		CollidedAbove,
		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		CollidedBelow = 4
	}
}
