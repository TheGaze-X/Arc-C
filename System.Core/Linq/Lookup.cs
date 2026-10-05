using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[DefaultMember("Item")]
	public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		internal static Lookup<TKey, TElement> CreateForJoin(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000114")]
		private Lookup(IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000117")]
		internal int InternalGetHashCode(TKey key)
		{
			return 0;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		internal Lookup<TKey, TElement>.Grouping GetGrouping(TKey key, bool create)
		{
			return null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000119")]
		private void Resize()
		{
		}

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> comparer;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x0")]
		private Lookup<TKey, TElement>.Grouping[] groupings;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x0")]
		private Lookup<TKey, TElement>.Grouping lastGrouping;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x0")]
		private int count;

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		internal class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
		{
			// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600011A")]
			internal void Add(TElement element)
			{
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011B")]
			public IEnumerator<TElement> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011C")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000027")]
			public TKey Key
			{
				[Token(Token = "0x600011D")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600011E RID: 286 RVA: 0x000024A8 File Offset: 0x000006A8
			[Token(Token = "0x17000028")]
			private int Count
			{
				[Token(Token = "0x600011E")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600011F RID: 287 RVA: 0x000024C0 File Offset: 0x000006C0
			[Token(Token = "0x17000029")]
			private bool IsReadOnly
			{
				[Token(Token = "0x600011F")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000120")]
			private void Add(TElement item)
			{
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000121")]
			private void Clear()
			{
			}

			// Token: 0x06000122 RID: 290 RVA: 0x000024D8 File Offset: 0x000006D8
			[Token(Token = "0x6000122")]
			private bool Contains(TElement item)
			{
				return default(bool);
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000123")]
			private void CopyTo(TElement[] array, int arrayIndex)
			{
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000024F0 File Offset: 0x000006F0
			[Token(Token = "0x6000124")]
			private bool Remove(TElement item)
			{
				return default(bool);
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00002508 File Offset: 0x00000708
			[Token(Token = "0x6000125")]
			private int IndexOf(TElement item)
			{
				return 0;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000126")]
			private void Insert(int index, TElement item)
			{
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000127")]
			private void RemoveAt(int index)
			{
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000129 RID: 297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700002A")]
			private TElement Item
			{
				[Token(Token = "0x6000128")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000129")]
				set
				{
				}
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600012A")]
			public Grouping()
			{
			}

			// Token: 0x0400009C RID: 156
			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x0")]
			internal TKey key;

			// Token: 0x0400009D RID: 157
			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x0")]
			internal int hashCode;

			// Token: 0x0400009E RID: 158
			[Token(Token = "0x400009E")]
			[FieldOffset(Offset = "0x0")]
			internal TElement[] elements;

			// Token: 0x0400009F RID: 159
			[Token(Token = "0x400009F")]
			[FieldOffset(Offset = "0x0")]
			internal int count;

			// Token: 0x040000A0 RID: 160
			[Token(Token = "0x40000A0")]
			[FieldOffset(Offset = "0x0")]
			internal Lookup<TKey, TElement>.Grouping hashNext;

			// Token: 0x040000A1 RID: 161
			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x0")]
			internal Lookup<TKey, TElement>.Grouping next;
		}
	}
}
