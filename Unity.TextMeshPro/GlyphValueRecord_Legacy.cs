using System;
using Il2CppDummyDll;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[Serializable]
	public struct GlyphValueRecord_Legacy
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x5880B50", Offset = "0x587F750", VA = "0x185880B50")]
		internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x57C1AE0", Offset = "0x57C06E0", VA = "0x1857C1AE0")]
		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b)
		{
			return default(GlyphValueRecord_Legacy);
		}

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x0")]
		public float xPlacement;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x4")]
		public float yPlacement;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x8")]
		public float xAdvance;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0xC")]
		public float yAdvance;
	}
}
