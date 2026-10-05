using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal class TextResourceManager
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x59FEC30", Offset = "0x59FD830", VA = "0x1859FEC30")]
		internal static void AddFontAsset(FontAsset fontAsset)
		{
		}

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, TextResourceManager.FontAssetRef> s_FontAssetReferences;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<int> s_FontAssetRemovalList;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int k_RegularStyleHashCode;

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		private struct FontAssetRef
		{
			// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x59FE530", Offset = "0x59FD130", VA = "0x1859FE530")]
			public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset)
			{
			}

			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			[FieldOffset(Offset = "0x0")]
			public int nameHashCode;

			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			[FieldOffset(Offset = "0x4")]
			public int familyNameHashCode;

			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			[FieldOffset(Offset = "0x8")]
			public int styleNameHashCode;

			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			[FieldOffset(Offset = "0x10")]
			public long familyNameAndStyleHashCode;

			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			[FieldOffset(Offset = "0x18")]
			public readonly FontAsset fontAsset;
		}
	}
}
