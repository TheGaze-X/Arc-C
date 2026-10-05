using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[DebuggerDisplay("Count={Count}")]
	public class ExposedList<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000273 RID: 627 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000273")]
		public ExposedList()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000274")]
		public ExposedList(IEnumerable<T> collection)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000275")]
		public ExposedList(int capacity)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000276")]
		internal ExposedList(T[] data, int size)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000277")]
		public void Add(T item)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000278")]
		public void GrowIfNeeded(int addedCount)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000279")]
		public ExposedList<T> Resize(int newSize)
		{
			return null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027A")]
		public void EnsureCapacity(int min)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027B")]
		private void CheckRange(int index, int count)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027C")]
		private void AddCollection(ICollection<T> collection)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027D")]
		private void AddEnumerable(IEnumerable<T> enumerable)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027E")]
		public void AddRange(ExposedList<T> list)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027F")]
		public void AddRange(IEnumerable<T> collection)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x6000280")]
		public int BinarySearch(T item)
		{
			return 0;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x6000281")]
		public int BinarySearch(T item, IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000030D4 File Offset: 0x000012D4
		[Token(Token = "0x6000282")]
		public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000283")]
		public void Clear(bool clearArray = true)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000030EC File Offset: 0x000012EC
		[Token(Token = "0x6000284")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000285")]
		public ExposedList<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
		{
			return null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000286")]
		public void CopyTo(T[] array)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000287")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000288")]
		public void CopyTo(int index, T[] array, int arrayIndex, int count)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x6000289")]
		public bool Exists(Predicate<T> match)
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028A")]
		public T Find(Predicate<T> match)
		{
			return null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600028B")]
		private static void CheckMatch(Predicate<T> match)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028C")]
		public ExposedList<T> FindAll(Predicate<T> match)
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028D")]
		private ExposedList<T> FindAllList(Predicate<T> match)
		{
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x600028E")]
		public int FindIndex(Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x600028F")]
		public int FindIndex(int startIndex, Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x6000290")]
		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x6000291")]
		private int GetIndex(int startIndex, int count, Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000292")]
		public T FindLast(Predicate<T> match)
		{
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x6000293")]
		public int FindLastIndex(Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x6000294")]
		public int FindLastIndex(int startIndex, Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x6000295")]
		public int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x6000296")]
		private int GetLastIndex(int startIndex, int count, Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000297")]
		public void ForEach(Action<T> action)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x6000298")]
		public ExposedList<T>.Enumerator GetEnumerator()
		{
			return default(ExposedList<T>.Enumerator);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000299")]
		public ExposedList<T> GetRange(int index, int count)
		{
			return null;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x600029A")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x600029B")]
		public int IndexOf(T item, int index)
		{
			return 0;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x600029C")]
		public int IndexOf(T item, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029D")]
		private void Shift(int start, int delta)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029E")]
		private void CheckIndex(int index)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029F")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A0")]
		private void CheckCollection(IEnumerable<T> collection)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A1")]
		public void InsertRange(int index, IEnumerable<T> collection)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A2")]
		private void InsertCollection(int index, ICollection<T> collection)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A3")]
		private void InsertEnumeration(int index, IEnumerable<T> enumerable)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x60002A4")]
		public int LastIndexOf(T item)
		{
			return 0;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x60002A5")]
		public int LastIndexOf(T item, int index)
		{
			return 0;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x60002A6")]
		public int LastIndexOf(T item, int index, int count)
		{
			return 0;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003284 File Offset: 0x00001484
		[Token(Token = "0x60002A7")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x60002A8")]
		public int RemoveAll(Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A9")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002AA")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002AB")]
		public void RemoveRange(int index, int count)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002AC")]
		public void Reverse()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002AD")]
		public void Reverse(int index, int count)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002AE")]
		public void Sort()
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002AF")]
		public void Sort(IComparer<T> comparer)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002B0")]
		public void Sort(Comparison<T> comparison)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002B1")]
		public void Sort(int index, int count, IComparer<T> comparer)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002B2")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002B3")]
		public void TrimExcess()
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x60002B4")]
		public bool TrueForAll(Predicate<T> match)
		{
			return default(bool);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000032CC File Offset: 0x000014CC
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000D6")]
		public int Capacity
		{
			[Token(Token = "0x60002B5")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002B6")]
			set
			{
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002B7")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002B8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x0")]
		public T[] Items;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x0")]
		public int Count;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		private const int DefaultCapacity = 4;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly T[] EmptyArray;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x0")]
		private int version;

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x060002BA RID: 698 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002BA")]
			internal Enumerator(ExposedList<T> l)
			{
			}

			// Token: 0x060002BB RID: 699 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002BB")]
			public void Dispose()
			{
			}

			// Token: 0x060002BC RID: 700 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002BC")]
			private void VerifyState()
			{
			}

			// Token: 0x060002BD RID: 701 RVA: 0x000032E4 File Offset: 0x000014E4
			[Token(Token = "0x60002BD")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002BE RID: 702 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x170000D7")]
			public T Current
			{
				[Token(Token = "0x60002BE")]
				get
				{
					return null;
				}
			}

			// Token: 0x060002BF RID: 703 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002BF")]
			private void Reset()
			{
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x170000D8")]
			private object Current
			{
				[Token(Token = "0x60002C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x0")]
			private ExposedList<T> l;

			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x0")]
			private int next;

			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x0")]
			private int ver;

			// Token: 0x040001BC RID: 444
			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x0")]
			private T current;
		}
	}
}
