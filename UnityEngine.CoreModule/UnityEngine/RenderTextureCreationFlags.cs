using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	[Flags]
	public enum RenderTextureCreationFlags
	{
		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		MipMap = 1,
		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		AutoGenerateMips = 2,
		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		SRGB = 4,
		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		EyeTexture = 8,
		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		EnableRandomWrite = 16,
		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		CreatedFromScript = 32,
		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		AllowVerticalFlip = 128,
		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		NoResolvedColorSurface = 256,
		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		DynamicallyScalable = 1024,
		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		BindMS = 2048
	}
}
