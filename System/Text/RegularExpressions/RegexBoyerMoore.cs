using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	internal sealed class RegexBoyerMoore
	{
		// Token: 0x0600054B RID: 1355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x50ED450", Offset = "0x50EC050", VA = "0x1850ED450")]
		public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x50ECF70", Offset = "0x50EBB70", VA = "0x1850ECF70")]
		private bool MatchPattern(string text, int index)
		{
			return default(bool);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x50ECF00", Offset = "0x50EBB00", VA = "0x1850ECF00")]
		public bool IsMatch(string text, int index, int beglimit, int endlimit)
		{
			return default(bool);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x50ED0E0", Offset = "0x50EBCE0", VA = "0x1850ED0E0")]
		public int Scan(string text, int index, int beglimit, int endlimit)
		{
			return 0;
		}

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x10")]
		public readonly int[] Positive;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x18")]
		public readonly int[] NegativeASCII;

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x20")]
		public readonly int[][] NegativeUnicode;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x28")]
		public readonly string Pattern;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x30")]
		public readonly int LowASCII;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x34")]
		public readonly int HighASCII;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x38")]
		public readonly bool RightToLeft;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x39")]
		public readonly bool CaseInsensitive;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x40")]
		private readonly CultureInfo _culture;
	}
}
