using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	internal class IntervalTree<T> where T : IInterval
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000035B4 File Offset: 0x000017B4
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A1")]
		public bool dirty
		{
			[Token(Token = "0x6000240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000241")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000242")]
		public void Add(T item)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000243")]
		public void IntersectsWith(long value, List<T> results)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000244")]
		public void IntersectsWithRange(long start, long end, List<T> results)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000245")]
		public void UpdateIntervals()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000246")]
		private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000247")]
		private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000248")]
		private void Rebuild()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x6000249")]
		private int Rebuild(int start, int end)
		{
			return 0;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600024A")]
		public void Clear()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600024B")]
		public IntervalTree()
		{
		}

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		private const int kMinNodeSize = 10;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		private const int kInvalidNode = -1;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		private const long kCenterUnknown = 9223372036854775807L;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<IntervalTree<T>.Entry> m_Entries;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<IntervalTreeNode> m_Nodes;

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		internal struct Entry
		{
			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x0")]
			public long intervalStart;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x0")]
			public long intervalEnd;

			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x0")]
			public T item;
		}
	}
}
