using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public class MeshGenerationContext
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal MeshGenerationContext(IStylePainter painter)
		{
		}

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x10")]
		internal IStylePainter painter;

		// Token: 0x02000210 RID: 528
		[Token(Token = "0x2000210")]
		[Flags]
		internal enum MeshFlags
		{
			// Token: 0x0400077E RID: 1918
			[Token(Token = "0x400077E")]
			None = 0,
			// Token: 0x0400077F RID: 1919
			[Token(Token = "0x400077F")]
			UVisDisplacement = 1,
			// Token: 0x04000780 RID: 1920
			[Token(Token = "0x4000780")]
			SkipDynamicAtlas = 2
		}
	}
}
