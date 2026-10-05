using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200058D RID: 1421
	[Token(Token = "0x200058D")]
	internal interface ISimpleCollator
	{
		// Token: 0x06002A84 RID: 10884
		[Token(Token = "0x6002A84")]
		SortKey GetSortKey(string source, CompareOptions options);

		// Token: 0x06002A85 RID: 10885
		[Token(Token = "0x6002A85")]
		int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

		// Token: 0x06002A86 RID: 10886
		[Token(Token = "0x6002A86")]
		bool IsPrefix(string src, string target, CompareOptions opt);

		// Token: 0x06002A87 RID: 10887
		[Token(Token = "0x6002A87")]
		bool IsSuffix(string src, string target, CompareOptions opt);

		// Token: 0x06002A88 RID: 10888
		[Token(Token = "0x6002A88")]
		int IndexOf(string s, string target, int start, int length, CompareOptions opt);

		// Token: 0x06002A89 RID: 10889
		[Token(Token = "0x6002A89")]
		int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
	}
}
