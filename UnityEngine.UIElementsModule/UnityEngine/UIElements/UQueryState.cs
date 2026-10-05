using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public struct UQueryState<T> : IEnumerable<T>, IEnumerable, IEquatable<UQueryState<T>> where T : VisualElement
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000532")]
		internal UQueryState(VisualElement element, List<RuleMatcher> matchers)
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000533")]
		public UQueryState<T> RebuildOn(VisualElement element)
		{
			return default(UQueryState<T>);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000534")]
		private T Single(UQuery.SingleQueryMatcher matcher)
		{
			return null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000535")]
		public T First()
		{
			return null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000536")]
		public void ToList(List<T> results)
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000537")]
		public UQueryState<T>.Enumerator GetEnumerator()
		{
			return default(UQueryState<T>.Enumerator);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000538")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000539")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x600053A")]
		public bool Equals(UQueryState<T> other)
		{
			return default(bool);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x600053B")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x600053C")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x0")]
		private static UQueryState<T>.ActionQueryMatcher s_Action;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x0")]
		private readonly VisualElement m_Element;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x0")]
		internal readonly List<RuleMatcher> m_Matchers;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly UQueryState<T>.ListQueryMatcher<T> s_List;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly UQueryState<T>.ListQueryMatcher<VisualElement> s_EnumerationList;

		// Token: 0x020000B3 RID: 179
		[Token(Token = "0x20000B3")]
		private class ListQueryMatcher<TElement> : UQuery.UQueryMatcher where TElement : VisualElement
		{
			// Token: 0x17000132 RID: 306
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x0000212A File Offset: 0x0000032A
			// (set) Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000132")]
			public List<TElement> matches
			{
				[Token(Token = "0x600053E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600053F")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x000045F0 File Offset: 0x000027F0
			[Token(Token = "0x6000540")]
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				return default(bool);
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000541")]
			public void Reset()
			{
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000542")]
			public ListQueryMatcher()
			{
			}
		}

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000B4")]
		private class ActionQueryMatcher : UQuery.UQueryMatcher
		{
			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000133")]
			internal Action<T> callBack
			{
				[Token(Token = "0x6000543")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x00004608 File Offset: 0x00002808
			[Token(Token = "0x6000544")]
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				return default(bool);
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000545")]
			public ActionQueryMatcher()
			{
			}
		}

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000546")]
			internal Enumerator(UQueryState<T> queryState)
			{
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000134")]
			public T Current
			{
				[Token(Token = "0x6000547")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000135")]
			private object Current
			{
				[Token(Token = "0x6000548")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x00004620 File Offset: 0x00002820
			[Token(Token = "0x6000549")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600054A")]
			public void Reset()
			{
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600054B")]
			public void Dispose()
			{
			}

			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			[FieldOffset(Offset = "0x0")]
			private List<VisualElement> iterationList;

			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			[FieldOffset(Offset = "0x0")]
			private int currentIndex;
		}
	}
}
