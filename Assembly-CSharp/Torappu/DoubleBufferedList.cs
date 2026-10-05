using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	[Serializable]
	public class DoubleBufferedList<T> : IEnumerable<T>, IEnumerable, IHotfixable
	{
		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x0002E9B0 File Offset: 0x0002CBB0
		[Token(Token = "0x17000C8F")]
		public int count
		{
			[Token(Token = "0x6005A80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06005A81 RID: 23169 RVA: 0x0002E9C8 File Offset: 0x0002CBC8
		[Token(Token = "0x17000C90")]
		public bool isEmpty
		{
			[Token(Token = "0x6005A81")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		[Token(Token = "0x17000C91")]
		public bool isInLoop
		{
			[Token(Token = "0x6005A82")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A83")]
		public DoubleBufferedList()
		{
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A84")]
		public DoubleBufferedList(int capacity)
		{
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A85")]
		public virtual void Add(T element)
		{
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x0002E9F8 File Offset: 0x0002CBF8
		[Token(Token = "0x6005A86")]
		public bool Remove(T element)
		{
			return default(bool);
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A87")]
		public void Clear()
		{
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A88")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x0002EA10 File Offset: 0x0002CC10
		[Token(Token = "0x6005A89")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8A")]
		public IEnumerator<T> GetInversedEnumerator()
		{
			return null;
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8B")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A8C")]
		private void _ForwardEnumeratorOnDispose(DoubleBufferedList<T>.ForwardEnumerator enumerator)
		{
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A8D")]
		private void _BackwardEnumeratorOnDispose(DoubleBufferedList<T>.BackwardEnumerator enumerator)
		{
		}

		// Token: 0x04002040 RID: 8256
		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_internalList;

		// Token: 0x04002041 RID: 8257
		[Token(Token = "0x4002041")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_cachedBuffer;

		// Token: 0x04002042 RID: 8258
		[Token(Token = "0x4002042")]
		[FieldOffset(Offset = "0x0")]
		private ushort m_eCounter;

		// Token: 0x04002043 RID: 8259
		[Token(Token = "0x4002043")]
		[FieldOffset(Offset = "0x0")]
		private Stack<DoubleBufferedList<T>.ForwardEnumerator> m_forwardEnumeratorPool;

		// Token: 0x04002044 RID: 8260
		[Token(Token = "0x4002044")]
		[FieldOffset(Offset = "0x0")]
		private Stack<DoubleBufferedList<T>.BackwardEnumerator> m_backwardEnumeratorPool;

		// Token: 0x04002045 RID: 8261
		[Token(Token = "0x4002045")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04002046 RID: 8262
		[Token(Token = "0x4002046")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04002047 RID: 8263
		[Token(Token = "0x4002047")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInLoop;

		// Token: 0x04002048 RID: 8264
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Add;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Remove;

		// Token: 0x0400204C RID: 8268
		[Token(Token = "0x400204C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400204D RID: 8269
		[Token(Token = "0x400204D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEnumerator;

		// Token: 0x0400204E RID: 8270
		[Token(Token = "0x400204E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Contains;

		// Token: 0x0400204F RID: 8271
		[Token(Token = "0x400204F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetInversedEnumerator;

		// Token: 0x04002050 RID: 8272
		[Token(Token = "0x4002050")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge GetEnumerator;

		// Token: 0x04002051 RID: 8273
		[Token(Token = "0x4002051")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ForwardEnumeratorOnDispose;

		// Token: 0x04002052 RID: 8274
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__BackwardEnumeratorOnDispose;

		// Token: 0x02000549 RID: 1353
		[Token(Token = "0x2000549")]
		protected class ForwardEnumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x06005A8E RID: 23182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C92")]
			public T Current
			{
				[Token(Token = "0x6005A8E")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x06005A8F RID: 23183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C93")]
			private object Current
			{
				[Token(Token = "0x6005A8F")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A90 RID: 23184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A90")]
			public ForwardEnumerator(IList<T> items, Action<DoubleBufferedList<T>.ForwardEnumerator> onDisposed)
			{
			}

			// Token: 0x06005A91 RID: 23185 RVA: 0x0002EA28 File Offset: 0x0002CC28
			[Token(Token = "0x6005A91")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06005A92 RID: 23186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A92")]
			public void Reset()
			{
			}

			// Token: 0x06005A93 RID: 23187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A93")]
			public void Reset(IList<T> items)
			{
			}

			// Token: 0x06005A94 RID: 23188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A94")]
			public void Dispose()
			{
			}

			// Token: 0x04002053 RID: 8275
			[Token(Token = "0x4002053")]
			[FieldOffset(Offset = "0x0")]
			private IList<T> m_items;

			// Token: 0x04002054 RID: 8276
			[Token(Token = "0x4002054")]
			[FieldOffset(Offset = "0x0")]
			private int m_cursor;

			// Token: 0x04002055 RID: 8277
			[Token(Token = "0x4002055")]
			[FieldOffset(Offset = "0x0")]
			private bool m_disposed;

			// Token: 0x04002056 RID: 8278
			[Token(Token = "0x4002056")]
			[FieldOffset(Offset = "0x0")]
			private Action<DoubleBufferedList<T>.ForwardEnumerator> m_onDisposed;
		}

		// Token: 0x0200054A RID: 1354
		[Token(Token = "0x200054A")]
		protected class BackwardEnumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x06005A95 RID: 23189 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C94")]
			public T Current
			{
				[Token(Token = "0x6005A95")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x06005A96 RID: 23190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C95")]
			private object Current
			{
				[Token(Token = "0x6005A96")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A97 RID: 23191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A97")]
			public BackwardEnumerator(IList<T> items, Action<DoubleBufferedList<T>.BackwardEnumerator> onDisposed)
			{
			}

			// Token: 0x06005A98 RID: 23192 RVA: 0x0002EA40 File Offset: 0x0002CC40
			[Token(Token = "0x6005A98")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06005A99 RID: 23193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A99")]
			public void Reset()
			{
			}

			// Token: 0x06005A9A RID: 23194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A9A")]
			public void Reset(IList<T> items)
			{
			}

			// Token: 0x06005A9B RID: 23195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A9B")]
			public void Dispose()
			{
			}

			// Token: 0x04002057 RID: 8279
			[Token(Token = "0x4002057")]
			[FieldOffset(Offset = "0x0")]
			private IList<T> m_items;

			// Token: 0x04002058 RID: 8280
			[Token(Token = "0x4002058")]
			[FieldOffset(Offset = "0x0")]
			private int m_cursor;

			// Token: 0x04002059 RID: 8281
			[Token(Token = "0x4002059")]
			[FieldOffset(Offset = "0x0")]
			private bool m_disposed;

			// Token: 0x0400205A RID: 8282
			[Token(Token = "0x400205A")]
			[FieldOffset(Offset = "0x0")]
			private Action<DoubleBufferedList<T>.BackwardEnumerator> m_onDisposed;
		}
	}
}
