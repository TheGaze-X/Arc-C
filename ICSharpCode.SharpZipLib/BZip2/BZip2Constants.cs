using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	internal sealed class BZip2Constants
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private BZip2Constants()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		public const int BaseBlockSize = 100000;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		public const int MaximumAlphaSize = 258;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		public const int MaximumCodeLength = 23;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		public const int RunA = 0;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		public const int RunB = 1;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		public const int GroupCount = 6;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		public const int GroupSize = 50;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		public const int NumberOfIterations = 4;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		public const int MaximumSelectors = 18002;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		public const int OvershootBytes = 20;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int[] RandomNumbers;
	}
}
