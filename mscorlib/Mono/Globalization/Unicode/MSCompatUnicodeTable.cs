using System;
using System.Globalization;
using Il2CppDummyDll;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	internal class MSCompatUnicodeTable
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4AAF0A0", Offset = "0x4AADCA0", VA = "0x184AAF0A0")]
		public static TailoringInfo GetTailoringInfo(int lcid)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4AAE0A0", Offset = "0x4AACCA0", VA = "0x184AAE0A0")]
		public static void BuildTailoringTables(System.Globalization.CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4AAF760", Offset = "0x4AAE360", VA = "0x184AAF760")]
		private unsafe static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4AAE780", Offset = "0x4AAD380", VA = "0x184AAE780")]
		public static byte Category(int cp)
		{
			return 0;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4AAF550", Offset = "0x4AAE150", VA = "0x184AAF550")]
		public static byte Level1(int cp)
		{
			return 0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4AAF600", Offset = "0x4AAE200", VA = "0x184AAF600")]
		public static byte Level2(int cp)
		{
			return 0;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4AAF6B0", Offset = "0x4AAE2B0", VA = "0x184AAF6B0")]
		public static byte Level3(int cp)
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4AAF2B0", Offset = "0x4AADEB0", VA = "0x184AAF2B0")]
		public static bool IsIgnorable(int cp, byte flag)
		{
			return default(bool);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4AAF260", Offset = "0x4AADE60", VA = "0x184AAF260")]
		public static bool IsIgnorableNonSpacing(int cp)
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4AAFA30", Offset = "0x4AAE630", VA = "0x184AAFA30")]
		public static int ToKanaTypeInsensitive(int i)
		{
			return 0;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4AAFA50", Offset = "0x4AAE650", VA = "0x184AAFA50")]
		public static int ToWidthCompat(int i)
		{
			return 0;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4AAF1B0", Offset = "0x4AADDB0", VA = "0x184AAF1B0")]
		public static bool HasSpecialWeight(char c)
		{
			return default(bool);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4AAF220", Offset = "0x4AADE20", VA = "0x184AAF220")]
		public static bool IsHalfWidthKana(char c)
		{
			return default(bool);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4AAF240", Offset = "0x4AADE40", VA = "0x184AAF240")]
		public static bool IsHiragana(char c)
		{
			return default(bool);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x4AAF3E0", Offset = "0x4AADFE0", VA = "0x184AAF3E0")]
		public static bool IsJapaneseSmallLetter(char c)
		{
			return default(bool);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x17000016")]
		public static bool IsReady
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4AB0220", Offset = "0x4AAEE20", VA = "0x184AB0220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4AAEF50", Offset = "0x4AADB50", VA = "0x184AAEF50")]
		private static System.IntPtr GetResource(string name)
		{
			return 0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4AAFBD0", Offset = "0x4AAE7D0", VA = "0x184AAFBD0")]
		private unsafe static uint UInt32FromBytePtr(byte* raw, uint idx)
		{
			return 0U;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4AAEDE0", Offset = "0x4AAD9E0", VA = "0x184AAEDE0")]
		public unsafe static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4AAE830", Offset = "0x4AAD430", VA = "0x184AAE830")]
		private unsafe static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table)
		{
		}

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x0")]
		public static int MaxExpansionLength;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x8")]
		private unsafe static readonly byte* ignorableFlags;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x10")]
		private unsafe static readonly byte* categories;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x18")]
		private unsafe static readonly byte* level1;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x20")]
		private unsafe static readonly byte* level2;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x28")]
		private unsafe static readonly byte* level3;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x30")]
		private unsafe static byte* cjkCHScategory;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x38")]
		private unsafe static byte* cjkCHTcategory;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x40")]
		private unsafe static byte* cjkJAcategory;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x48")]
		private unsafe static byte* cjkKOcategory;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x50")]
		private unsafe static byte* cjkCHSlv1;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x58")]
		private unsafe static byte* cjkCHTlv1;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x60")]
		private unsafe static byte* cjkJAlv1;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x68")]
		private unsafe static byte* cjkKOlv1;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x70")]
		private unsafe static byte* cjkKOlv2;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x78")]
		private static readonly char[] tailoringArr;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x80")]
		private static readonly TailoringInfo[] tailoringInfos;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x88")]
		private static object forLock;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x90")]
		public static readonly bool isReady;
	}
}
