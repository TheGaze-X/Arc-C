using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200061C RID: 1564
	[Token(Token = "0x200061C")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(StackDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Runtime.CompilerServices.TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[System.Serializable]
	public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06002F29 RID: 12073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F29")]
		public Stack()
		{
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2A")]
		public Stack(int capacity)
		{
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x00019860 File Offset: 0x00017A60
		[Token(Token = "0x170007AC")]
		public int Count
		{
			[Token(Token = "0x6002F2B")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x00019878 File Offset: 0x00017A78
		[Token(Token = "0x170007AD")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002F2C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007AE")]
		private object SyncRoot
		{
			[Token(Token = "0x6002F2D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2E")]
		public void Clear()
		{
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00019890 File Offset: 0x00017A90
		[Token(Token = "0x6002F2F")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F30")]
		private void CopyTo(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x000198A8 File Offset: 0x00017AA8
		[Token(Token = "0x6002F31")]
		public Stack<T>.Enumerator GetEnumerator()
		{
			return default(Stack<T>.Enumerator);
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F32")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F33")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F34")]
		public T Peek()
		{
			return null;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F35")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000198C0 File Offset: 0x00017AC0
		[Token(Token = "0x6002F36")]
		public bool TryPop(out T result)
		{
			return default(bool);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F37")]
		public void Push(T item)
		{
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F38")]
		[MethodImpl(8)]
		private void PushWithResize(T item)
		{
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F39")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3A")]
		private void ThrowForEmptyStack()
		{
		}

		// Token: 0x04001A70 RID: 6768
		[Token(Token = "0x4001A70")]
		[FieldOffset(Offset = "0x0")]
		private T[] _array;

		// Token: 0x04001A71 RID: 6769
		[Token(Token = "0x4001A71")]
		[FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04001A72 RID: 6770
		[Token(Token = "0x4001A72")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001A73 RID: 6771
		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private object _syncRoot;

		// Token: 0x04001A74 RID: 6772
		[Token(Token = "0x4001A74")]
		private const int DefaultCapacity = 4;

		// Token: 0x0200061D RID: 1565
		[Token(Token = "0x200061D")]
		[System.Serializable]
		public struct Enumerator : IEnumerator<T>, System.IDisposable, IEnumerator
		{
			// Token: 0x06002F3B RID: 12091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F3B")]
			internal Enumerator(Stack<T> stack)
			{
			}

			// Token: 0x06002F3C RID: 12092 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F3C")]
			public void Dispose()
			{
			}

			// Token: 0x06002F3D RID: 12093 RVA: 0x000198D8 File Offset: 0x00017AD8
			[Token(Token = "0x6002F3D")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06002F3E RID: 12094 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007AF")]
			public T Current
			{
				[Token(Token = "0x6002F3E")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002F3F RID: 12095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F3F")]
			private void ThrowEnumerationNotStartedOrEnded()
			{
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x06002F40 RID: 12096 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007B0")]
			private object Current
			{
				[Token(Token = "0x6002F40")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002F41 RID: 12097 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F41")]
			private void Reset()
			{
			}

			// Token: 0x04001A75 RID: 6773
			[Token(Token = "0x4001A75")]
			[FieldOffset(Offset = "0x0")]
			private readonly Stack<T> _stack;

			// Token: 0x04001A76 RID: 6774
			[Token(Token = "0x4001A76")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _version;

			// Token: 0x04001A77 RID: 6775
			[Token(Token = "0x4001A77")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001A78 RID: 6776
			[Token(Token = "0x4001A78")]
			[FieldOffset(Offset = "0x0")]
			private T _currentElement;
		}
	}
}
