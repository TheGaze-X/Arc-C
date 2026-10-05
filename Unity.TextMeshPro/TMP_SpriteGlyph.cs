using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[Serializable]
	public class TMP_SpriteGlyph : Glyph
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x58CE2E0", Offset = "0x58CCEE0", VA = "0x1858CE2E0")]
		public TMP_SpriteGlyph()
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x58CE240", Offset = "0x58CCE40", VA = "0x1858CE240")]
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x58CE180", Offset = "0x58CCD80", VA = "0x1858CE180")]
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite)
		{
		}

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x48")]
		public Sprite sprite;
	}
}
