using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x59F6F00", Offset = "0x59F5B00", VA = "0x1859F6F00", Slot = "4")]
		public bool Equals(TextGenerationSettings other)
		{
			return default(bool);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x59F73F0", Offset = "0x59F5FF0", VA = "0x1859F73F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x59F74F0", Offset = "0x59F60F0", VA = "0x1859F74F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x59F7B90", Offset = "0x59F6790", VA = "0x1859F7B90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x59F9F50", Offset = "0x59F8B50", VA = "0x1859F9F50")]
		public TextGenerationSettings()
		{
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x18")]
		public Rect screenRect;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x28")]
		public Vector4 margins;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x38")]
		public float scale;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x40")]
		public FontAsset fontAsset;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x48")]
		public Material material;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x50")]
		public SpriteAsset spriteAsset;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x58")]
		public TextStyleSheet styleSheet;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x60")]
		public FontStyles fontStyle;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x68")]
		public TextSettings textSettings;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x70")]
		public TextAlignment textAlignment;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x74")]
		public TextOverflowMode overflowMode;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x78")]
		public bool wordWrap;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x7C")]
		public float wordWrappingRatio;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x80")]
		public Color color;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x90")]
		public TextColorGradient fontColorGradient;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x98")]
		public bool tintSprites;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x99")]
		public bool overrideRichTextColors;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x9C")]
		public float fontSize;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0xA0")]
		public bool autoSize;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xA4")]
		public float fontSizeMin;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0xA8")]
		public float fontSizeMax;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0xAC")]
		public bool enableKerning;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0xAD")]
		public bool richText;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0xAE")]
		public bool isRightToLeft;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0xAF")]
		public bool extraPadding;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0xB0")]
		public bool parseControlCharacters;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0xB4")]
		public float characterSpacing;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0xB8")]
		public float wordSpacing;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0xBC")]
		public float lineSpacing;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0xC0")]
		public float paragraphSpacing;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0xC4")]
		public float lineSpacingMax;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0xC8")]
		public int maxVisibleCharacters;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xCC")]
		public int maxVisibleWords;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xD0")]
		public int maxVisibleLines;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0xD4")]
		public int firstVisibleCharacter;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0xD8")]
		public bool useMaxVisibleDescender;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0xDC")]
		public TextFontWeight fontWeight;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0xE0")]
		public int pageToDisplay;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0xE4")]
		public TextureMapping horizontalMapping;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xE8")]
		public TextureMapping verticalMapping;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0xEC")]
		public float uvLineOffset;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0xF0")]
		public VertexSortingOrder geometrySortingOrder;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0xF4")]
		public bool inverseYAxis;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0xF8")]
		public float charWidthMaxAdj;
	}
}
