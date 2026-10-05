using System;
using System.Globalization;
using Il2CppDummyDll;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	internal class SimpleCollator : ISimpleCollator
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x4AB7820", Offset = "0x4AB6420", VA = "0x184AB7820")]
		public SimpleCollator(System.Globalization.CultureInfo culture)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4AB7570", Offset = "0x4AB6170", VA = "0x184AB7570")]
		private unsafe void SetCJKTable(System.Globalization.CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4AB4120", Offset = "0x4AB2D20", VA = "0x184AB4120")]
		private static System.Globalization.CultureInfo GetNeutralCulture(System.Globalization.CultureInfo info)
		{
			return null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x4AB2150", Offset = "0x4AB0D50", VA = "0x184AB2150")]
		private byte Category(int cp)
		{
			return 0;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4AB62D0", Offset = "0x4AB4ED0", VA = "0x184AB62D0")]
		private byte Level1(int cp)
		{
			return 0;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x4AB6370", Offset = "0x4AB4F70", VA = "0x184AB6370")]
		private byte Level2(int cp, SimpleCollator.ExtenderType ext)
		{
			return 0;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4AB5480", Offset = "0x4AB4080", VA = "0x184AB5480")]
		private static bool IsHalfKana(int cp, System.Globalization.CompareOptions opt)
		{
			return default(bool);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x4AB3F90", Offset = "0x4AB2B90", VA = "0x184AB3F90")]
		private Contraction GetContraction(string s, int start, int end)
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x4AB3E60", Offset = "0x4AB2A60", VA = "0x184AB3E60")]
		private Contraction GetContraction(string s, int start, int end, Contraction[] clist)
		{
			return null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x4AB4970", Offset = "0x4AB3570", VA = "0x184AB4970")]
		private Contraction GetTailContraction(string s, int start, int end)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x4AB4770", Offset = "0x4AB3370", VA = "0x184AB4770")]
		private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist)
		{
			return null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x4AB3B90", Offset = "0x4AB2790", VA = "0x184AB3B90")]
		private int FilterOptions(int i, System.Globalization.CompareOptions opt)
		{
			return 0;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4AB4070", Offset = "0x4AB2C70", VA = "0x184AB4070")]
		private SimpleCollator.ExtenderType GetExtenderType(int i)
		{
			return SimpleCollator.ExtenderType.None;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x4AB7750", Offset = "0x4AB6350", VA = "0x184AB7750")]
		private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, System.Globalization.CompareOptions opt)
		{
			return 0;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x4AB3980", Offset = "0x4AB2580", VA = "0x184AB3980")]
		private int FilterExtender(int i, SimpleCollator.ExtenderType ext, System.Globalization.CompareOptions opt)
		{
			return 0;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x4AB5500", Offset = "0x4AB4100", VA = "0x184AB5500")]
		private static bool IsIgnorable(int i, System.Globalization.CompareOptions opt)
		{
			return default(bool);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x4AB5750", Offset = "0x4AB4350", VA = "0x184AB5750")]
		private bool IsSafe(int i)
		{
			return default(bool);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x4AB4680", Offset = "0x4AB3280", VA = "0x184AB4680", Slot = "4")]
		public System.Globalization.SortKey GetSortKey(string s, System.Globalization.CompareOptions options)
		{
			return null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4AB4220", Offset = "0x4AB2E20", VA = "0x184AB4220")]
		public System.Globalization.SortKey GetSortKey(string s, int start, int length, System.Globalization.CompareOptions options)
		{
			return null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x4AB4320", Offset = "0x4AB2F20", VA = "0x184AB4320")]
		private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, System.Globalization.CompareOptions opt)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4AB3440", Offset = "0x4AB2040", VA = "0x184AB3440")]
		private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, System.Globalization.CompareOptions opt)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x4AB38D0", Offset = "0x4AB24D0", VA = "0x184AB38D0")]
		private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4AB7740", Offset = "0x4AB6340", VA = "0x184AB7740", Slot = "5")]
		private int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, System.Globalization.CompareOptions options)
		{
			return 0;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x4AB3340", Offset = "0x4AB1F40", VA = "0x184AB3340")]
		internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, System.Globalization.CompareOptions options)
		{
			return 0;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4AB21F0", Offset = "0x4AB0DF0", VA = "0x184AB21F0")]
		private unsafe void ClearBuffer(byte* buffer, int size)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4AB2230", Offset = "0x4AB0E30", VA = "0x184AB2230")]
		private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx)
		{
			return 0;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4AB2210", Offset = "0x4AB0E10", VA = "0x184AB2210")]
		private int CompareFlagPair(bool b1, bool b2)
		{
			return 0;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4AB5610", Offset = "0x4AB4210", VA = "0x184AB5610", Slot = "6")]
		public bool IsPrefix(string src, string target, System.Globalization.CompareOptions opt)
		{
			return default(bool);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4AB5650", Offset = "0x4AB4250", VA = "0x184AB5650")]
		public bool IsPrefix(string s, string target, int start, int length, System.Globalization.CompareOptions opt)
		{
			return default(bool);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4AB5590", Offset = "0x4AB4190", VA = "0x184AB5590")]
		private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx)
		{
			return default(bool);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4AB5870", Offset = "0x4AB4470", VA = "0x184AB5870", Slot = "7")]
		public bool IsSuffix(string src, string target, System.Globalization.CompareOptions opt)
		{
			return default(bool);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4AB57B0", Offset = "0x4AB43B0", VA = "0x184AB57B0")]
		public bool IsSuffix(string s, string target, int start, int length, System.Globalization.CompareOptions opt)
		{
			return default(bool);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4AB7430", Offset = "0x4AB6030", VA = "0x184AB7430")]
		private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
		{
			return 0;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4AB51A0", Offset = "0x4AB3DA0", VA = "0x184AB51A0", Slot = "8")]
		public int IndexOf(string s, string target, int start, int length, System.Globalization.CompareOptions opt)
		{
			return 0;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4AB4A50", Offset = "0x4AB3650", VA = "0x184AB4A50")]
		private int IndexOfOrdinal(string s, string target, int start, int length)
		{
			return 0;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4AB4B10", Offset = "0x4AB3710", VA = "0x184AB4B10")]
		private int IndexOfOrdinal(string s, char target, int start, int length)
		{
			return 0;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4AB4B90", Offset = "0x4AB3790", VA = "0x184AB4B90")]
		private unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			return 0;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4AB4C50", Offset = "0x4AB3850", VA = "0x184AB4C50")]
		private unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			return 0;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4AB6110", Offset = "0x4AB4D10", VA = "0x184AB6110", Slot = "9")]
		public int LastIndexOf(string s, string target, int start, int length, System.Globalization.CompareOptions opt)
		{
			return 0;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4AB5930", Offset = "0x4AB4530", VA = "0x184AB5930")]
		private int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			return 0;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4AB5A60", Offset = "0x4AB4660", VA = "0x184AB5A60")]
		private unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			return 0;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x4AB5B30", Offset = "0x4AB4730", VA = "0x184AB5B30")]
		private unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			return 0;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4AB7080", Offset = "0x4AB5C80", VA = "0x184AB7080")]
		private unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			return default(bool);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x4AB6CE0", Offset = "0x4AB58E0", VA = "0x184AB6CE0")]
		private unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			return default(bool);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4AB7250", Offset = "0x4AB5E50", VA = "0x184AB7250")]
		private unsafe bool MatchesPrimitive(System.Globalization.CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4)
		{
			return default(bool);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x4AB6B00", Offset = "0x4AB5700", VA = "0x184AB6B00")]
		private unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			return default(bool);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4AB6510", Offset = "0x4AB5110", VA = "0x184AB6510")]
		private unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			return default(bool);
		}

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x0")]
		private static SimpleCollator invariant;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Globalization.TextInfo textInfo;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x18")]
		private readonly CodePointIndexer cjkIndexer;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x20")]
		private readonly Contraction[] contractions;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x28")]
		private readonly Level2Map[] level2Maps;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x30")]
		private readonly byte[] unsafeFlags;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x38")]
		private unsafe readonly byte* cjkCatTable;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x40")]
		private unsafe readonly byte* cjkLv1Table;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x48")]
		private unsafe readonly byte* cjkLv2Table;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x50")]
		private readonly CodePointIndexer cjkLv2Indexer;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x58")]
		private readonly int lcid;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x5C")]
		private readonly bool frenchSort;

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		internal struct Context
		{
			// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x4AAA6B0", Offset = "0x4AA92B0", VA = "0x184AAA6B0")]
			public unsafe Context(System.Globalization.CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
			}

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x0")]
			public readonly System.Globalization.CompareOptions Option;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x8")]
			public unsafe readonly byte* NeverMatchFlags;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x10")]
			public unsafe readonly byte* AlwaysMatchFlags;

			// Token: 0x0400019B RID: 411
			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x18")]
			public unsafe byte* Buffer1;

			// Token: 0x0400019C RID: 412
			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0x20")]
			public unsafe byte* Buffer2;

			// Token: 0x0400019D RID: 413
			[Token(Token = "0x400019D")]
			[FieldOffset(Offset = "0x28")]
			public int PrevCode;

			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x30")]
			public unsafe byte* PrevSortKey;
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		private struct PreviousInfo
		{
			// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x4AB0C70", Offset = "0x4AAF870", VA = "0x184AB0C70")]
			public PreviousInfo(bool dummy)
			{
			}

			// Token: 0x0400019F RID: 415
			[Token(Token = "0x400019F")]
			[FieldOffset(Offset = "0x0")]
			public int Code;

			// Token: 0x040001A0 RID: 416
			[Token(Token = "0x40001A0")]
			[FieldOffset(Offset = "0x8")]
			public unsafe byte* SortKey;
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		private struct Escape
		{
			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0x0")]
			public string Source;

			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0x8")]
			public int Index;

			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			[FieldOffset(Offset = "0xC")]
			public int Start;

			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			[FieldOffset(Offset = "0x10")]
			public int End;

			// Token: 0x040001A5 RID: 421
			[Token(Token = "0x40001A5")]
			[FieldOffset(Offset = "0x14")]
			public int Optional;
		}

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x200005D")]
		private enum ExtenderType
		{
			// Token: 0x040001A7 RID: 423
			[Token(Token = "0x40001A7")]
			None,
			// Token: 0x040001A8 RID: 424
			[Token(Token = "0x40001A8")]
			Simple,
			// Token: 0x040001A9 RID: 425
			[Token(Token = "0x40001A9")]
			Voiced,
			// Token: 0x040001AA RID: 426
			[Token(Token = "0x40001AA")]
			Conditional,
			// Token: 0x040001AB RID: 427
			[Token(Token = "0x40001AB")]
			Buggy
		}
	}
}
