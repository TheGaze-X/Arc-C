using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class TMP_FontAssetUtilities
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006A")]
		public static TMP_FontAssetUtilities instance
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x58891B0", Offset = "0x5887DB0", VA = "0x1858891B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x58887A0", Offset = "0x58873A0", VA = "0x1858887A0")]
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x5888370", Offset = "0x5886F70", VA = "0x185888370")]
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x5888930", Offset = "0x5887530", VA = "0x185888930")]
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x5888DE0", Offset = "0x58879E0", VA = "0x185888DE0")]
		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x5888C00", Offset = "0x5887800", VA = "0x185888C00")]
		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TMP_FontAssetUtilities()
		{
		}

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_FontAssetUtilities s_Instance;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x8")]
		private static HashSet<int> k_SearchedAssets;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x10")]
		private static bool k_IsFontEngineInitialized;
	}
}
