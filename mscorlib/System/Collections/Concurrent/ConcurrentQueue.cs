using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Collections.Concurrent
{
	// Token: 0x020005E6 RID: 1510
	[Token(Token = "0x20005E6")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Serializable]
	public class ConcurrentQueue<T> : System.Collections.Generic.IEnumerable<T>, IEnumerable, ICollection, System.Collections.Generic.IReadOnlyCollection<T>
	{
		// Token: 0x06002D4A RID: 11594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4A")]
		public ConcurrentQueue()
		{
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4B")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x00018A80 File Offset: 0x00016C80
		[Token(Token = "0x1700073C")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002D4C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700073D")]
		private object SyncRoot
		{
			[Token(Token = "0x6002D4D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D4E")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x00018A98 File Offset: 0x00016C98
		[Token(Token = "0x1700073E")]
		public bool IsEmpty
		{
			[Token(Token = "0x6002D4F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D50")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x00018AB0 File Offset: 0x00016CB0
		[Token(Token = "0x1700073F")]
		public int Count
		{
			[Token(Token = "0x6002D51")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00018AC8 File Offset: 0x00016CC8
		[Token(Token = "0x6002D52")]
		private static int GetCount(ConcurrentQueue<T>.Segment s, int head, int tail)
		{
			return 0;
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00018AE0 File Offset: 0x00016CE0
		[Token(Token = "0x6002D53")]
		private static long GetCount(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			return 0L;
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D54")]
		public void CopyTo(T[] array, int index)
		{
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D55")]
		public System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D56")]
		private void SnapForObservation(out ConcurrentQueue<T>.Segment head, out int headHead, out ConcurrentQueue<T>.Segment tail, out int tailTail)
		{
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D57")]
		private T GetItemWhenAvailable(ConcurrentQueue<T>.Segment segment, int i)
		{
			return null;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D58")]
		private System.Collections.Generic.IEnumerator<T> Enumerate(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			return null;
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D59")]
		public void Enqueue(T item)
		{
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5A")]
		private void EnqueueSlow(T item)
		{
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00018AF8 File Offset: 0x00016CF8
		[Token(Token = "0x6002D5B")]
		public bool TryDequeue(out T result)
		{
			return default(bool);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00018B10 File Offset: 0x00016D10
		[Token(Token = "0x6002D5C")]
		private bool TryDequeueSlow(out T item)
		{
			return default(bool);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00018B28 File Offset: 0x00016D28
		[Token(Token = "0x6002D5D")]
		private bool TryPeek(out T result, bool resultUsed)
		{
			return default(bool);
		}

		// Token: 0x040019E9 RID: 6633
		[Token(Token = "0x40019E9")]
		private const int InitialSegmentLength = 32;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		private const int MaxSegmentLength = 1048576;

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object _crossSegmentLock;

		// Token: 0x040019EC RID: 6636
		[Token(Token = "0x40019EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ConcurrentQueue<T>.Segment _tail;

		// Token: 0x040019ED RID: 6637
		[Token(Token = "0x40019ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ConcurrentQueue<T>.Segment _head;

		// Token: 0x020005E7 RID: 1511
		[Token(Token = "0x20005E7")]
		[System.Diagnostics.DebuggerDisplay("Capacity = {Capacity}")]
		internal sealed class Segment
		{
			// Token: 0x06002D5E RID: 11614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D5E")]
			public Segment(int boundedLength)
			{
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00018B40 File Offset: 0x00016D40
			[Token(Token = "0x17000740")]
			internal int Capacity
			{
				[Token(Token = "0x6002D5F")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06002D60 RID: 11616 RVA: 0x00018B58 File Offset: 0x00016D58
			[Token(Token = "0x17000741")]
			internal int FreezeOffset
			{
				[Token(Token = "0x6002D60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06002D61 RID: 11617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D61")]
			internal void EnsureFrozenForEnqueues()
			{
			}

			// Token: 0x06002D62 RID: 11618 RVA: 0x00018B70 File Offset: 0x00016D70
			[Token(Token = "0x6002D62")]
			public bool TryDequeue(out T item)
			{
				return default(bool);
			}

			// Token: 0x06002D63 RID: 11619 RVA: 0x00018B88 File Offset: 0x00016D88
			[Token(Token = "0x6002D63")]
			public bool TryPeek(out T result, bool resultUsed)
			{
				return default(bool);
			}

			// Token: 0x06002D64 RID: 11620 RVA: 0x00018BA0 File Offset: 0x00016DA0
			[Token(Token = "0x6002D64")]
			public bool TryEnqueue(T item)
			{
				return default(bool);
			}

			// Token: 0x040019EE RID: 6638
			[Token(Token = "0x40019EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal readonly ConcurrentQueue<T>.Segment.Slot[] _slots;

			// Token: 0x040019EF RID: 6639
			[Token(Token = "0x40019EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal readonly int _slotsMask;

			// Token: 0x040019F0 RID: 6640
			[Token(Token = "0x40019F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal PaddedHeadAndTail _headAndTail;

			// Token: 0x040019F1 RID: 6641
			[Token(Token = "0x40019F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool _preservedForObservation;

			// Token: 0x040019F2 RID: 6642
			[Token(Token = "0x40019F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool _frozenForEnqueues;

			// Token: 0x040019F3 RID: 6643
			[Token(Token = "0x40019F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ConcurrentQueue<T>.Segment _nextSegment;

			// Token: 0x020005E8 RID: 1512
			[Token(Token = "0x20005E8")]
			[System.Diagnostics.DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
			[StructLayout(3)]
			internal struct Slot
			{
				// Token: 0x040019F4 RID: 6644
				[Token(Token = "0x40019F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public T Item;

				// Token: 0x040019F5 RID: 6645
				[Token(Token = "0x40019F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int SequenceNumber;
			}
		}
	}
}
