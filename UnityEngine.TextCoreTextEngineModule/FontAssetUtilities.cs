using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	internal static class FontAssetUtilities
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x59E8E70", Offset = "0x59E7A70", VA = "0x1859E8E70")]
		internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x59E8A80", Offset = "0x59E7680", VA = "0x1859E8A80")]
		private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x59E8F90", Offset = "0x59E7B90", VA = "0x1859E8F90")]
		public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x59E9330", Offset = "0x59E7F30", VA = "0x1859E9330")]
		public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x59E9170", Offset = "0x59E7D70", VA = "0x1859E9170")]
		private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<int> k_SearchedAssets;
	}
}
