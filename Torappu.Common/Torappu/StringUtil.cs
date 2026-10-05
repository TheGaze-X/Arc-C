using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public static class StringUtil
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x5527A20", Offset = "0x5526620", VA = "0x185527A20")]
		public static List<string> SplitLicenseToSegments(string content)
		{
			return null;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x5527E60", Offset = "0x5526A60", VA = "0x185527E60")]
		private static void _SplitLongString(string longStr, List<string> outputList)
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00006524 File Offset: 0x00004724
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x5527D90", Offset = "0x5526990", VA = "0x185527D90")]
		public static bool StartsWithOneOf(string str, string[] prefixes, bool ignoreCase = false)
		{
			return default(bool);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0000653C File Offset: 0x0000473C
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x55270B0", Offset = "0x5525CB0", VA = "0x1855270B0")]
		public static int CompareChinese(string a, string b)
		{
			return 0;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00006554 File Offset: 0x00004754
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x5527510", Offset = "0x5526110", VA = "0x185527510")]
		public static int IndexOfAny(this string str, IList<string> subStrs)
		{
			return 0;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000656C File Offset: 0x0000476C
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x5527380", Offset = "0x5525F80", VA = "0x185527380")]
		public static int IndexOfAny(this string str, IList<string> subStrs, StringComparison comparison)
		{
			return 0;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00006584 File Offset: 0x00004784
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x55276A0", Offset = "0x55262A0", VA = "0x1855276A0")]
		public static int LastIndexOfAny(this string str, IList<string> subStrs)
		{
			return 0;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000659C File Offset: 0x0000479C
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x5527130", Offset = "0x5525D30", VA = "0x185527130")]
		public static bool ContainsAny(this string str, IList<string> subStrs)
		{
			return default(bool);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000065B4 File Offset: 0x000047B4
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x55271F0", Offset = "0x5525DF0", VA = "0x1855271F0")]
		public static bool ContainsIgnoreCase(this string str, string substr)
		{
			return default(bool);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000065CC File Offset: 0x000047CC
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x5527220", Offset = "0x5525E20", VA = "0x185527220")]
		public static bool EqualsWithFuzzyNames(string str, string match, IList<string> fuzzyNames, out string matchedFuzzyName)
		{
			return default(bool);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x5527820", Offset = "0x5526420", VA = "0x185527820")]
		public static string MergeStringByDelimiter(IList<string> strList, string delimiter)
		{
			return null;
		}

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x0")]
		private static CultureInfo CHINESE_CULTURE;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		private const int MAX_TEXT_STRLEN = 10000;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		private const int MIN_TEXT_STRLEN = 1000;
	}
}
