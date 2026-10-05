using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	public class EventDescriptorCollection : ICollection, IEnumerable, IList
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x51458A0", Offset = "0x51444A0", VA = "0x1851458A0")]
		public EventDescriptorCollection(EventDescriptor[] events)
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x5145930", Offset = "0x5144530", VA = "0x185145930")]
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x51459D0", Offset = "0x51445D0", VA = "0x1851459D0")]
		private EventDescriptorCollection(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000060F0 File Offset: 0x000042F0
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000215")]
		public int Count
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000216 RID: 534
		[Token(Token = "0x17000216")]
		public virtual EventDescriptor this[int index]
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x5145B30", Offset = "0x5144730", VA = "0x185145B30", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000217 RID: 535
		[Token(Token = "0x17000217")]
		public virtual EventDescriptor this[string name]
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x5145AE0", Offset = "0x51446E0", VA = "0x185145AE0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x5143F30", Offset = "0x5142B30", VA = "0x185143F30")]
		public int Add(EventDescriptor value)
		{
			return 0;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x5144020", Offset = "0x5142C20", VA = "0x185144020")]
		public void Clear()
		{
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x5144080", Offset = "0x5142C80", VA = "0x185144080")]
		public bool Contains(EventDescriptor value)
		{
			return default(bool);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x5144E00", Offset = "0x5143A00", VA = "0x185144E00", Slot = "4")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x51440E0", Offset = "0x5142CE0", VA = "0x1851440E0")]
		private void EnsureEventsOwned()
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x51441A0", Offset = "0x5142DA0", VA = "0x1851441A0")]
		private void EnsureSize(int sizeNeeded)
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x51442C0", Offset = "0x5142EC0", VA = "0x1851442C0", Slot = "22")]
		public virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x51444D0", Offset = "0x51430D0", VA = "0x1851444D0")]
		public int IndexOf(EventDescriptor value)
		{
			return 0;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x5144530", Offset = "0x5143130", VA = "0x185144530")]
		public void Insert(int index, EventDescriptor value)
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x5144AD0", Offset = "0x51436D0", VA = "0x185144AD0")]
		public void Remove(EventDescriptor value)
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x5144A00", Offset = "0x5143600", VA = "0x185144A00")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x5144420", Offset = "0x5143020", VA = "0x185144420")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x5144C20", Offset = "0x5143820", VA = "0x185144C20", Slot = "23")]
		public virtual EventDescriptorCollection Sort()
		{
			return null;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x5144CC0", Offset = "0x51438C0", VA = "0x185144CC0", Slot = "24")]
		public virtual EventDescriptorCollection Sort(string[] names)
		{
			return null;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x5144B80", Offset = "0x5143780", VA = "0x185144B80", Slot = "25")]
		public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			return null;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x5144D60", Offset = "0x5143960", VA = "0x185144D60", Slot = "26")]
		public virtual EventDescriptorCollection Sort(IComparer comparer)
		{
			return null;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x51446D0", Offset = "0x51432D0", VA = "0x1851446D0")]
		protected void InternalSort(string[] names)
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x5144650", Offset = "0x5143250", VA = "0x185144650")]
		protected void InternalSort(IComparer sorter)
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x17000218")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000219")]
		private object SyncRoot
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x1700021A")]
		private int Count
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x5144E50", Offset = "0x5143A50", VA = "0x185144E50", Slot = "8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700021B")]
		private object Item
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x5145570", Offset = "0x5144170", VA = "0x185145570", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x51455C0", Offset = "0x51441C0", VA = "0x1851455C0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x5144F00", Offset = "0x5143B00", VA = "0x185144F00", Slot = "11")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x5145080", Offset = "0x5143C80", VA = "0x185145080", Slot = "12")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x5144020", Offset = "0x5142C20", VA = "0x185144020", Slot = "13")]
		private void Clear()
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x5145170", Offset = "0x5143D70", VA = "0x185145170", Slot = "16")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x5145260", Offset = "0x5143E60", VA = "0x185145260", Slot = "17")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x5145420", Offset = "0x5144020", VA = "0x185145420", Slot = "18")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x5145410", Offset = "0x5144010", VA = "0x185145410", Slot = "19")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x1700021C")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x37002B0", Offset = "0x36FEEB0", VA = "0x1837002B0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x1700021D")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x37002B0", Offset = "0x36FEEB0", VA = "0x1837002B0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x10")]
		private EventDescriptor[] _events;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x18")]
		private string[] _namedSort;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x20")]
		private readonly IComparer _comparer;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x28")]
		private bool _eventsOwned;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x29")]
		private bool _needSort;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x2A")]
		private readonly bool _readOnly;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EventDescriptorCollection Empty;

		// Token: 0x0200019C RID: 412
		[Token(Token = "0x200019C")]
		private class ArraySubsetEnumerator : IEnumerator
		{
			// Token: 0x06000AAB RID: 2731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x51395C0", Offset = "0x51381C0", VA = "0x1851395C0")]
			public ArraySubsetEnumerator(Array array, int count)
			{
			}

			// Token: 0x06000AAC RID: 2732 RVA: 0x000061F8 File Offset: 0x000043F8
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x51395A0", Offset = "0x51381A0", VA = "0x1851395A0", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x504A5E0", Offset = "0x50491E0", VA = "0x18504A5E0", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700021E")]
			public object Current
			{
				[Token(Token = "0x6000AAE")]
				[Address(RVA = "0x5139610", Offset = "0x5138210", VA = "0x185139610", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x040006AE RID: 1710
			[Token(Token = "0x40006AE")]
			[FieldOffset(Offset = "0x10")]
			private readonly Array _array;

			// Token: 0x040006AF RID: 1711
			[Token(Token = "0x40006AF")]
			[FieldOffset(Offset = "0x18")]
			private readonly int _total;

			// Token: 0x040006B0 RID: 1712
			[Token(Token = "0x40006B0")]
			[FieldOffset(Offset = "0x1C")]
			private int _current;
		}
	}
}
