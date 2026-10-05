using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.FlatBuffers
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public struct Table
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00004368 File Offset: 0x00002568
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000099")]
		public int bb_pos
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009A")]
		public ByteBuffer bb
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009B")]
		public ByteBuffer ByteBuffer
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x544F480", Offset = "0x544E080", VA = "0x18544F480")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x544F410", Offset = "0x544E010", VA = "0x18544F410")]
		public Table(int _i, ByteBuffer _bb)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x544EE60", Offset = "0x544DA60", VA = "0x18544EE60")]
		public int __offset(int vtableOffset)
		{
			return 0;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x544EDF0", Offset = "0x544D9F0", VA = "0x18544EDF0")]
		public static int __offset(int vtableOffset, int offset, ByteBuffer bb)
		{
			return 0;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x544ED80", Offset = "0x544D980", VA = "0x18544ED80")]
		public int __indirect(int offset)
		{
			return 0;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x544ED50", Offset = "0x544D950", VA = "0x18544ED50")]
		public static int __indirect(int offset, ByteBuffer bb)
		{
			return 0;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x544EF40", Offset = "0x544DB40", VA = "0x18544EF40")]
		public string __string(int offset)
		{
			return null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x544F220", Offset = "0x544DE20", VA = "0x18544F220")]
		public int __vector_len(int offset)
		{
			return 0;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x544F2B0", Offset = "0x544DEB0", VA = "0x18544F2B0")]
		public int __vector(int offset)
		{
			return 0;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x544F080", Offset = "0x544DC80", VA = "0x18544F080")]
		public ArraySegment<byte>? __vector_as_arraysegment(int offset)
		{
			return null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A6")]
		public T[] __vector_as_array<T>(int offset) where T : struct
		{
			return null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A7")]
		public T __union<T>(int offset) where T : struct, IFlatbufferObject
		{
			return null;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x544EC40", Offset = "0x544D840", VA = "0x18544EC40")]
		public static bool __has_identifier(ByteBuffer bb, string ident)
		{
			return default(bool);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x544EAF0", Offset = "0x544D6F0", VA = "0x18544EAF0")]
		public static int CompareStrings(int offset_1, int offset_2, ByteBuffer bb)
		{
			return 0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x544E9D0", Offset = "0x544D5D0", VA = "0x18544E9D0")]
		public static int CompareStrings(int offset_1, byte[] key, ByteBuffer bb)
		{
			return 0;
		}

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StringDedupEntry s_dedupEntry;
	}
}
