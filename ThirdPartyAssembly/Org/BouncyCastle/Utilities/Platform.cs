using System;
using System.Collections;
using System.Globalization;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	internal abstract class Platform
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x544DE90", Offset = "0x544CA90", VA = "0x18544DE90")]
		private static string GetNewLine()
		{
			return null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x544DE50", Offset = "0x544CA50", VA = "0x18544DE50")]
		internal static bool EqualsIgnoreCase(string a, string b)
		{
			return default(bool);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x544DE70", Offset = "0x544CA70", VA = "0x18544DE70")]
		internal static string GetEnvironmentVariable(string variable)
		{
			return null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x544DCC0", Offset = "0x544C8C0", VA = "0x18544DCC0")]
		internal static Exception CreateNotImplementedException(string message)
		{
			return null;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x544DB00", Offset = "0x544C700", VA = "0x18544DB00")]
		internal static IList CreateArrayList()
		{
			return null;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x544DB50", Offset = "0x544C750", VA = "0x18544DB50")]
		internal static IList CreateArrayList(int capacity)
		{
			return null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x544D830", Offset = "0x544C430", VA = "0x18544D830")]
		internal static IList CreateArrayList(ICollection collection)
		{
			return null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x544D890", Offset = "0x544C490", VA = "0x18544D890")]
		internal static IList CreateArrayList(IEnumerable collection)
		{
			return null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x544DC10", Offset = "0x544C810", VA = "0x18544DC10")]
		internal static IDictionary CreateHashtable()
		{
			return null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x544DBB0", Offset = "0x544C7B0", VA = "0x18544DBB0")]
		internal static IDictionary CreateHashtable(int capacity)
		{
			return null;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x544DC60", Offset = "0x544C860", VA = "0x18544DC60")]
		internal static IDictionary CreateHashtable(IDictionary dictionary)
		{
			return null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x544E100", Offset = "0x544CD00", VA = "0x18544E100")]
		internal static string ToLowerInvariant(string s)
		{
			return null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x544E160", Offset = "0x544CD60", VA = "0x18544E160")]
		internal static string ToUpperInvariant(string s)
		{
			return null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x544DD60", Offset = "0x544C960", VA = "0x18544DD60")]
		internal static void Dispose(Stream s)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x544DD20", Offset = "0x544C920", VA = "0x18544DD20")]
		internal static void Dispose(TextWriter t)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x544DEF0", Offset = "0x544CAF0", VA = "0x18544DEF0")]
		internal static int IndexOf(string source, string value)
		{
			return 0;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x544DFA0", Offset = "0x544CBA0", VA = "0x18544DFA0")]
		internal static int LastIndexOf(string source, string value)
		{
			return 0;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x544E050", Offset = "0x544CC50", VA = "0x18544E050")]
		internal static bool StartsWith(string source, string prefix)
		{
			return default(bool);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x544DDA0", Offset = "0x544C9A0", VA = "0x18544DDA0")]
		internal static bool EndsWith(string source, string suffix)
		{
			return default(bool);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x544DEA0", Offset = "0x544CAA0", VA = "0x18544DEA0")]
		internal static string GetTypeName(object obj)
		{
			return null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Platform()
		{
		}

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CompareInfo InvariantCompareInfo;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly string NewLine;
	}
}
