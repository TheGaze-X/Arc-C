using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	[Flags]
	internal enum TouchFlags : byte
	{
		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		IndirectTouch = 1,
		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		PrimaryTouch = 8,
		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		TapPress = 16,
		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		TapRelease = 32,
		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		OrphanedPrimaryTouch = 64,
		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		BeganInSameFrame = 128
	}
}
