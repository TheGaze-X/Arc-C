using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public enum ScreenOrientation
	{
		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[Obsolete("Enum member Unknown has been deprecated.", false)]
		Unknown,
		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[Obsolete("Use LandscapeLeft instead (UnityUpgradable) -> LandscapeLeft", true)]
		Landscape = 3,
		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		Portrait = 1,
		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		PortraitUpsideDown,
		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		LandscapeLeft,
		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		LandscapeRight,
		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		AutoRotation
	}
}
