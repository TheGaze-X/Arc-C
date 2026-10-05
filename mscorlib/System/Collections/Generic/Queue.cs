using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000619 RID: 1561
	[Token(Token = "0x2000619")]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Runtime.CompilerServices.TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(QueueDebugView<>))]
	[System.Serializable]
	public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06002F0F RID: 12047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0F")]
		public Queue()
		{
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F10")]
		public Queue(int capacity)
		{
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F11")]
		public Queue(IEnumerable<T> collection)
		{
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x000197E8 File Offset: 0x000179E8
		[Token(Token = "0x170007A7")]
		public int Count
		{
			[Token(Token = "0x6002F12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00019800 File Offset: 0x00017A00
		[Token(Token = "0x170007A8")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002F13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007A9")]
		private object SyncRoot
		{
			[Token(Token = "0x6002F14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F15")]
		public void Clear()
		{
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F16")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F17")]
		public void Enqueue(T item)
		{
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00019818 File Offset: 0x00017A18
		[Token(Token = "0x6002F18")]
		public Queue<T>.Enumerator GetEnumerator()
		{
			return default(Queue<T>.Enumerator);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F19")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F1A")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F1B")]
		public T Dequeue()
		{
			return null;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F1C")]
		public T Peek()
		{
			return null;
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00019830 File Offset: 0x00017A30
		[Token(Token = "0x6002F1D")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F1E")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1F")]
		private void SetCapacity(int capacity)
		{
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F20")]
		private void MoveNext(ref int index)
		{
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F21")]
		private void ThrowForEmptyQueue()
		{
		}

		// Token: 0x04001A64 RID: 6756
		[Token(Token = "0x4001A64")]
		[FieldOffset(Offset = "0x0")]
		private T[] _array;

		// Token: 0x04001A65 RID: 6757
		[Token(Token = "0x4001A65")]
		[FieldOffset(Offset = "0x0")]
		private int _head;

		// Token: 0x04001A66 RID: 6758
		[Token(Token = "0x4001A66")]
		[FieldOffset(Offset = "0x0")]
		private int _tail;

		// Token: 0x04001A67 RID: 6759
		[Token(Token = "0x4001A67")]
		[FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04001A68 RID: 6760
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001A69 RID: 6761
		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private object _syncRoot;

		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		private const int MinimumGrow = 4;

		// Token: 0x04001A6B RID: 6763
		[Token(Token = "0x4001A6B")]
		private const int GrowFactor = 200;

		// Token: 0x0200061A RID: 1562
		[Token(Token = "0x200061A")]
		[System.Serializable]
		public struct Enumerator : IEnumerator<T>, System.IDisposable, IEnumerator
		{
			// Token: 0x06002F22 RID: 12066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F22")]
			internal Enumerator(Queue<T> q)
			{
			}

			// Token: 0x06002F23 RID: 12067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F23")]
			public void Dispose()
			{
			}

			// Token: 0x06002F24 RID: 12068 RVA: 0x00019848 File Offset: 0x00017A48
			[Token(Token = "0x6002F24")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06002F25 RID: 12069 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007AA")]
			public T Current
			{
				[Token(Token = "0x6002F25")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002F26 RID: 12070 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F26")]
			private void ThrowEnumerationNotStartedOrEnded()
			{
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06002F27 RID: 12071 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007AB")]
			private object Current
			{
				[Token(Token = "0x6002F27")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002F28 RID: 12072 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F28")]
			private void Reset()
			{
			}

			// Token: 0x04001A6C RID: 6764
			[Token(Token = "0x4001A6C")]
			[FieldOffset(Offset = "0x0")]
			private readonly Queue<T> _q;

			// Token: 0x04001A6D RID: 6765
			[Token(Token = "0x4001A6D")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _version;

			// Token: 0x04001A6E RID: 6766
			[Token(Token = "0x4001A6E")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001A6F RID: 6767
			[Token(Token = "0x4001A6F")]
			[FieldOffset(Offset = "0x0")]
			private T _currentElement;
		}
	}
}
