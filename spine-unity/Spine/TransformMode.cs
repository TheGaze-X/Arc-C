using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Flags]
	public enum TransformMode
	{
		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		Normal = 0,
		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		OnlyTranslation = 7,
		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		NoRotationOrReflection = 1,
		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		NoScale = 2,
		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		NoScaleOrReflection = 6
	}
}
