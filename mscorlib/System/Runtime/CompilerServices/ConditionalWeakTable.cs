using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	public sealed class ConditionalWeakTable<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable where TKey : class where TValue : class
	{
		// Token: 0x06002356 RID: 9046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002356")]
		public ConditionalWeakTable()
		{
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002357")]
		protected override void Finalize()
		{
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002358")]
		private void RehashWithoutResize()
		{
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002359")]
		private void RecomputeSize()
		{
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235A")]
		private void Rehash()
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235B")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00014160 File Offset: 0x00012360
		[Token(Token = "0x600235C")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00014178 File Offset: 0x00012378
		[Token(Token = "0x600235D")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600235E")]
		public TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			return null;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600235F")]
		private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002360")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400141B RID: 5147
		[Token(Token = "0x400141B")]
		private const int INITIAL_SIZE = 13;

		// Token: 0x0400141C RID: 5148
		[Token(Token = "0x400141C")]
		private const float LOAD_FACTOR = 0.7f;

		// Token: 0x0400141D RID: 5149
		[Token(Token = "0x400141D")]
		private const float COMPACT_FACTOR = 0.5f;

		// Token: 0x0400141E RID: 5150
		[Token(Token = "0x400141E")]
		private const float EXPAND_FACTOR = 1.1f;

		// Token: 0x0400141F RID: 5151
		[Token(Token = "0x400141F")]
		[FieldOffset(Offset = "0x0")]
		private Ephemeron[] data;

		// Token: 0x04001420 RID: 5152
		[Token(Token = "0x4001420")]
		[FieldOffset(Offset = "0x0")]
		private object _lock;

		// Token: 0x04001421 RID: 5153
		[Token(Token = "0x4001421")]
		[FieldOffset(Offset = "0x0")]
		private int size;

		// Token: 0x020004C8 RID: 1224
		// (Invoke) Token: 0x06002362 RID: 9058
		[Token(Token = "0x20004C8")]
		public delegate TValue CreateValueCallback(TKey key);

		// Token: 0x020004C9 RID: 1225
		[Token(Token = "0x20004C9")]
		private sealed class Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator
		{
			// Token: 0x06002363 RID: 9059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002363")]
			public Enumerator(ConditionalWeakTable<TKey, TValue> table)
			{
			}

			// Token: 0x06002364 RID: 9060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002364")]
			protected override void Finalize()
			{
			}

			// Token: 0x06002365 RID: 9061 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002365")]
			public void Dispose()
			{
			}

			// Token: 0x06002366 RID: 9062 RVA: 0x00014190 File Offset: 0x00012390
			[Token(Token = "0x6002366")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700048D RID: 1165
			// (get) Token: 0x06002367 RID: 9063 RVA: 0x000141A8 File Offset: 0x000123A8
			[Token(Token = "0x1700048D")]
			public System.Collections.Generic.KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6002367")]
				get
				{
					return default(System.Collections.Generic.KeyValuePair<TKey, TValue>);
				}
			}

			// Token: 0x1700048E RID: 1166
			// (get) Token: 0x06002368 RID: 9064 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700048E")]
			private object Current
			{
				[Token(Token = "0x6002368")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002369 RID: 9065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002369")]
			public void Reset()
			{
			}

			// Token: 0x04001422 RID: 5154
			[Token(Token = "0x4001422")]
			[FieldOffset(Offset = "0x0")]
			private ConditionalWeakTable<TKey, TValue> _table;

			// Token: 0x04001423 RID: 5155
			[Token(Token = "0x4001423")]
			[FieldOffset(Offset = "0x0")]
			private int _currentIndex;

			// Token: 0x04001424 RID: 5156
			[Token(Token = "0x4001424")]
			[FieldOffset(Offset = "0x0")]
			private System.Collections.Generic.KeyValuePair<TKey, TValue> _current;
		}
	}
}
