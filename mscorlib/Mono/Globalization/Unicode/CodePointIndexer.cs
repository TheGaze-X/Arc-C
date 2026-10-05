using System;
using Il2CppDummyDll;

namespace Mono.Globalization.Unicode
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	internal class CodePointIndexer
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4AAA4E0", Offset = "0x4AA90E0", VA = "0x184AAA4E0")]
		public CodePointIndexer(int[] starts, int[] ends, int defaultIndex, int defaultCP)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4AAA460", Offset = "0x4AA9060", VA = "0x184AAA460")]
		public int ToIndex(int cp)
		{
			return 0;
		}

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x10")]
		private readonly CodePointIndexer.TableRange[] ranges;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x18")]
		public readonly int TotalCount;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x1C")]
		private int defaultIndex;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x20")]
		private int defaultCP;

		// Token: 0x02000050 RID: 80
		[Token(Token = "0x2000050")]
		[System.Serializable]
		internal struct TableRange
		{
			// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x4ABB3D0", Offset = "0x4AB9FD0", VA = "0x184ABB3D0")]
			public TableRange(int start, int end, int indexStart)
			{
			}

			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x0")]
			public readonly int Start;

			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			[FieldOffset(Offset = "0x4")]
			public readonly int End;

			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x8")]
			public readonly int Count;

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0xC")]
			public readonly int IndexStart;

			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			[FieldOffset(Offset = "0x10")]
			public readonly int IndexEnd;
		}
	}
}
