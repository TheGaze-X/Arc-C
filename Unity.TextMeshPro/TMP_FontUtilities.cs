using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public static class TMP_FontUtilities
	{
		// Token: 0x0600025A RID: 602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x5892DB0", Offset = "0x58919B0", VA = "0x185892DB0")]
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			return null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x5892CC0", Offset = "0x58918C0", VA = "0x185892CC0")]
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x5892980", Offset = "0x5891580", VA = "0x185892980")]
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			return null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x5892BD0", Offset = "0x58917D0", VA = "0x185892BD0")]
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			return null;
		}

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x0")]
		private static List<int> k_searchedFontAssets;
	}
}
