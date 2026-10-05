using System;
using System.Text;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	internal static class StringPluginExtensions
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x3754BC0", Offset = "0x37537C0", VA = "0x183754BC0")]
		internal static void ScrambleChars(this char[] chars)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x3754A80", Offset = "0x3753680", VA = "0x183754A80")]
		internal static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, char[] chars)
		{
			return null;
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x0")]
		public static readonly char[] ScrambledCharsAll;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x8")]
		public static readonly char[] ScrambledCharsUppercase;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x10")]
		public static readonly char[] ScrambledCharsLowercase;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x18")]
		public static readonly char[] ScrambledCharsNumerals;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x20")]
		private static int _lastRndSeed;
	}
}
