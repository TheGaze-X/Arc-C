using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public static class Enumerable
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			return null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		private static IEnumerable<TResult> JoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000051")]
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000052")]
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
		{
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		public static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		public static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		public static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4F24C90", Offset = "0x4F23890", VA = "0x184F24C90")]
		public static IEnumerable<int> Range(int start, int count)
		{
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4F24C10", Offset = "0x4F23810", VA = "0x184F24C10")]
		private static IEnumerable<int> RangeIterator(int start, int count)
		{
			return null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count)
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		public static IEnumerable<TResult> Empty<TResult>()
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000068")]
		public static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			return default(bool);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000069")]
		public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(bool);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x600006A")]
		public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(bool);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600006B")]
		public static int Count<TSource>(this IEnumerable<TSource> source)
		{
			return 0;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600006C")]
		public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return 0;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600006D")]
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600006E")]
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4F24D60", Offset = "0x4F23960", VA = "0x184F24D60")]
		public static int Sum(this IEnumerable<int> source)
		{
			return 0;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x4F24F10", Offset = "0x4F23B10", VA = "0x184F24F10")]
		public static float Sum(this IEnumerable<float> source)
		{
			return 0f;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000071")]
		public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return 0;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000072")]
		public static float Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			return 0f;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4F249B0", Offset = "0x4F235B0", VA = "0x184F249B0")]
		public static int Min(this IEnumerable<int> source)
		{
			return 0;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000074")]
		public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return 0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4F24750", Offset = "0x4F23350", VA = "0x184F24750")]
		public static int Max(this IEnumerable<int> source)
		{
			return 0;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000076")]
		public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return 0;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000077")]
			public Iterator()
			{
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000D")]
			public TSource Current
			{
				[Token(Token = "0x6000078")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000079 RID: 121
			[Token(Token = "0x6000079")]
			public abstract Enumerable.Iterator<TSource> Clone();

			// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600007A")]
			public virtual void Dispose()
			{
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600007B")]
			public IEnumerator<TSource> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600007C RID: 124
			[Token(Token = "0x600007C")]
			public abstract bool MoveNext();

			// Token: 0x0600007D RID: 125
			[Token(Token = "0x600007D")]
			public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

			// Token: 0x0600007E RID: 126
			[Token(Token = "0x600007E")]
			public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000E")]
			private object Current
			{
				[Token(Token = "0x600007F")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000080")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000081")]
			private void Reset()
			{
			}

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x0")]
			private int threadId;

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x0")]
			internal int state;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x0")]
			internal TSource current;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		private class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000082")]
			public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
			{
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000083")]
			public override Enumerable.Iterator<TSource> Clone()
			{
				return null;
			}

			// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000084")]
			public override void Dispose()
			{
			}

			// Token: 0x06000085 RID: 133 RVA: 0x000022C8 File Offset: 0x000004C8
			[Token(Token = "0x6000085")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000086")]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000087")]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> enumerator;
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		private class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000088")]
			public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
			{
			}

			// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000089")]
			public override Enumerable.Iterator<TSource> Clone()
			{
				return null;
			}

			// Token: 0x0600008A RID: 138 RVA: 0x000022E0 File Offset: 0x000004E0
			[Token(Token = "0x600008A")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600008B")]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600008C")]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x0")]
			private TSource[] source;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x0")]
			private int index;
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		private class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600008D")]
			public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
			{
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600008E")]
			public override Enumerable.Iterator<TSource> Clone()
			{
				return null;
			}

			// Token: 0x0600008F RID: 143 RVA: 0x000022F8 File Offset: 0x000004F8
			[Token(Token = "0x600008F")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000090")]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000091")]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource> source;

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource>.Enumerator enumerator;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		private class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000092")]
			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000093")]
			public override Enumerable.Iterator<TResult> Clone()
			{
				return null;
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000094")]
			public override void Dispose()
			{
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002310 File Offset: 0x00000510
			[Token(Token = "0x6000095")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000096")]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000097")]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}

			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> enumerator;
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		private class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x06000098 RID: 152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000098")]
			public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000099")]
			public override Enumerable.Iterator<TResult> Clone()
			{
				return null;
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00002328 File Offset: 0x00000528
			[Token(Token = "0x600009A")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009B")]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009C")]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x0")]
			private TSource[] source;

			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x0")]
			private int index;
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		private class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600009D")]
			public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009E")]
			public override Enumerable.Iterator<TResult> Clone()
			{
				return null;
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00002340 File Offset: 0x00000540
			[Token(Token = "0x600009F")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000A0")]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000A1")]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource> source;

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource>.Enumerator enumerator;
		}
	}
}
