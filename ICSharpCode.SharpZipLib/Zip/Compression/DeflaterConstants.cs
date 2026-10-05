using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class DeflaterConstants
	{
		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeflaterConstants()
		{
		}

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		public const bool DEBUGGING = false;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		public const int STORED_BLOCK = 0;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		public const int STATIC_TREES = 1;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		public const int DYN_TREES = 2;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		public const int PRESET_DICT = 32;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		public const int DEFAULT_MEM_LEVEL = 8;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		public const int MAX_MATCH = 258;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		public const int MIN_MATCH = 3;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		public const int MAX_WBITS = 15;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		public const int WSIZE = 32768;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		public const int WMASK = 32767;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		public const int HASH_BITS = 15;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		public const int HASH_SIZE = 32768;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		public const int HASH_MASK = 32767;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		public const int HASH_SHIFT = 5;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		public const int MIN_LOOKAHEAD = 262;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		public const int MAX_DIST = 32506;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		public const int PENDING_BUF_SIZE = 65536;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		public const int DEFLATE_STORED = 0;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		public const int DEFLATE_FAST = 1;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		public const int DEFLATE_SLOW = 2;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x0")]
		public static int MAX_BLOCK_SIZE;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x8")]
		public static int[] GOOD_LENGTH;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x10")]
		public static int[] MAX_LAZY;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x18")]
		public static int[] NICE_LENGTH;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x20")]
		public static int[] MAX_CHAIN;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x28")]
		public static int[] COMPR_FUNC;
	}
}
