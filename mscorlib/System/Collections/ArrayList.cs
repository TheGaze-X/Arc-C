using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005D9 RID: 1497
	[Token(Token = "0x20005D9")]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
	[System.Serializable]
	public class ArrayList : IList, ICollection, IEnumerable, System.ICloneable
	{
		// Token: 0x06002C91 RID: 11409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x4C59D90", Offset = "0x4C58990", VA = "0x184C59D90")]
		public ArrayList()
		{
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x4C59DE0", Offset = "0x4C589E0", VA = "0x184C59DE0")]
		public ArrayList(int capacity)
		{
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x4C59EE0", Offset = "0x4C58AE0", VA = "0x184C59EE0")]
		public ArrayList(ICollection c)
		{
		}

		// Token: 0x1700070B RID: 1803
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070B")]
		public virtual int Capacity
		{
			[Token(Token = "0x6002C94")]
			[Address(RVA = "0x4C5A180", Offset = "0x4C58D80", VA = "0x184C5A180", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x00018678 File Offset: 0x00016878
		[Token(Token = "0x1700070C")]
		public virtual int Count
		{
			[Token(Token = "0x6002C95")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x00018690 File Offset: 0x00016890
		[Token(Token = "0x1700070D")]
		public virtual bool IsFixedSize
		{
			[Token(Token = "0x6002C96")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000186A8 File Offset: 0x000168A8
		[Token(Token = "0x1700070E")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6002C97")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x000186C0 File Offset: 0x000168C0
		[Token(Token = "0x1700070F")]
		public virtual bool IsSynchronized
		{
			[Token(Token = "0x6002C98")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000710")]
		public virtual object SyncRoot
		{
			[Token(Token = "0x6002C99")]
			[Address(RVA = "0x4C5A100", Offset = "0x4C58D00", VA = "0x184C5A100", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000711 RID: 1809
		[Token(Token = "0x17000711")]
		public virtual object this[int index]
		{
			[Token(Token = "0x6002C9A")]
			[Address(RVA = "0x4C5A040", Offset = "0x4C58C40", VA = "0x184C5A040", Slot = "27")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C9B")]
			[Address(RVA = "0x4C5A2A0", Offset = "0x4C58EA0", VA = "0x184C5A2A0", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C9C")]
		[Address(RVA = "0x4C58840", Offset = "0x4C57440", VA = "0x184C58840")]
		public static ArrayList Adapter(IList list)
		{
			return null;
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000186D8 File Offset: 0x000168D8
		[Token(Token = "0x6002C9D")]
		[Address(RVA = "0x4C58960", Offset = "0x4C57560", VA = "0x184C58960", Slot = "29")]
		public virtual int Add(object value)
		{
			return 0;
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C9E")]
		[Address(RVA = "0x4C58900", Offset = "0x4C57500", VA = "0x184C58900", Slot = "30")]
		public virtual void AddRange(ICollection c)
		{
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C9F")]
		[Address(RVA = "0x420C910", Offset = "0x420B510", VA = "0x18420C910", Slot = "31")]
		public virtual void Clear()
		{
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002CA0")]
		[Address(RVA = "0x4C58A20", Offset = "0x4C57620", VA = "0x184C58A20", Slot = "32")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000186F0 File Offset: 0x000168F0
		[Token(Token = "0x6002CA1")]
		[Address(RVA = "0x4C58BB0", Offset = "0x4C577B0", VA = "0x184C58BB0", Slot = "33")]
		public virtual bool Contains(object item)
		{
			return default(bool);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA2")]
		[Address(RVA = "0x4C58E90", Offset = "0x4C57A90", VA = "0x184C58E90", Slot = "34")]
		public virtual void CopyTo(System.Array array)
		{
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA3")]
		[Address(RVA = "0x4C58DD0", Offset = "0x4C579D0", VA = "0x184C58DD0", Slot = "35")]
		public virtual void CopyTo(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA4")]
		[Address(RVA = "0x4C58C90", Offset = "0x4C57890", VA = "0x184C58C90", Slot = "36")]
		public virtual void CopyTo(int index, System.Array array, int arrayIndex, int count)
		{
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA5")]
		[Address(RVA = "0x4C58EE0", Offset = "0x4C57AE0", VA = "0x184C58EE0")]
		private void EnsureCapacity(int min)
		{
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002CA6")]
		[Address(RVA = "0x4C58F60", Offset = "0x4C57B60", VA = "0x184C58F60", Slot = "37")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00018708 File Offset: 0x00016908
		[Token(Token = "0x6002CA7")]
		[Address(RVA = "0x4C590A0", Offset = "0x4C57CA0", VA = "0x184C590A0", Slot = "38")]
		public virtual int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA8")]
		[Address(RVA = "0x4C592C0", Offset = "0x4C57EC0", VA = "0x184C592C0", Slot = "39")]
		public virtual void Insert(int index, object value)
		{
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x4C590D0", Offset = "0x4C57CD0", VA = "0x184C590D0", Slot = "40")]
		public virtual void InsertRange(int index, ICollection c)
		{
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002CAA")]
		[Address(RVA = "0x4C59420", Offset = "0x4C58020", VA = "0x184C59420")]
		public static ArrayList ReadOnly(ArrayList list)
		{
			return null;
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CAB")]
		[Address(RVA = "0x4C597B0", Offset = "0x4C583B0", VA = "0x184C597B0", Slot = "41")]
		public virtual void Remove(object obj)
		{
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CAC")]
		[Address(RVA = "0x4C594E0", Offset = "0x4C580E0", VA = "0x184C594E0", Slot = "42")]
		public virtual void RemoveAt(int index)
		{
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CAD")]
		[Address(RVA = "0x4C595D0", Offset = "0x4C581D0", VA = "0x184C595D0", Slot = "43")]
		public virtual void RemoveRange(int index, int count)
		{
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CAE")]
		[Address(RVA = "0x4C59830", Offset = "0x4C58430", VA = "0x184C59830", Slot = "44")]
		public virtual void Reverse()
		{
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CAF")]
		[Address(RVA = "0x4C598A0", Offset = "0x4C584A0", VA = "0x184C598A0", Slot = "45")]
		public virtual void Reverse(int index, int count)
		{
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x4C59A30", Offset = "0x4C58630", VA = "0x184C59A30", Slot = "46")]
		public virtual void Sort(IComparer comparer)
		{
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x4C59AB0", Offset = "0x4C586B0", VA = "0x184C59AB0", Slot = "47")]
		public virtual void Sort(int index, int count, IComparer comparer)
		{
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x4C59C10", Offset = "0x4C58810", VA = "0x184C59C10", Slot = "48")]
		public virtual object[] ToArray()
		{
			return null;
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002CB3")]
		[Address(RVA = "0x4C59CA0", Offset = "0x4C588A0", VA = "0x184C59CA0", Slot = "49")]
		public virtual System.Array ToArray(System.Type type)
		{
			return null;
		}

		// Token: 0x040019BA RID: 6586
		[Token(Token = "0x40019BA")]
		[FieldOffset(Offset = "0x10")]
		private object[] _items;

		// Token: 0x040019BB RID: 6587
		[Token(Token = "0x40019BB")]
		[FieldOffset(Offset = "0x18")]
		private int _size;

		// Token: 0x040019BC RID: 6588
		[Token(Token = "0x40019BC")]
		[FieldOffset(Offset = "0x1C")]
		private int _version;

		// Token: 0x040019BD RID: 6589
		[Token(Token = "0x40019BD")]
		[FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private object _syncRoot;

		// Token: 0x020005DA RID: 1498
		[Token(Token = "0x20005DA")]
		[System.Serializable]
		private class IListWrapper : ArrayList
		{
			// Token: 0x06002CB4 RID: 11444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CB4")]
			[Address(RVA = "0x4C66B90", Offset = "0x4C65790", VA = "0x184C66B90")]
			internal IListWrapper(IList list)
			{
			}

			// Token: 0x17000712 RID: 1810
			// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000712")]
			public override int Capacity
			{
				[Token(Token = "0x6002CB5")]
				[Address(RVA = "0x4C66E00", Offset = "0x4C65A00", VA = "0x184C66E00", Slot = "21")]
				set
				{
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x00018720 File Offset: 0x00016920
			[Token(Token = "0x17000713")]
			public override int Count
			{
				[Token(Token = "0x6002CB6")]
				[Address(RVA = "0x4C66C10", Offset = "0x4C65810", VA = "0x184C66C10", Slot = "22")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x00018738 File Offset: 0x00016938
			[Token(Token = "0x17000714")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6002CB7")]
				[Address(RVA = "0x4C66CB0", Offset = "0x4C658B0", VA = "0x184C66CB0", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x00018750 File Offset: 0x00016950
			[Token(Token = "0x17000715")]
			public override bool IsFixedSize
			{
				[Token(Token = "0x6002CB8")]
				[Address(RVA = "0x4C66C60", Offset = "0x4C65860", VA = "0x184C66C60", Slot = "23")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x00018768 File Offset: 0x00016968
			[Token(Token = "0x17000716")]
			public override bool IsSynchronized
			{
				[Token(Token = "0x6002CB9")]
				[Address(RVA = "0x4C66D00", Offset = "0x4C65900", VA = "0x184C66D00", Slot = "25")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000717 RID: 1815
			[Token(Token = "0x17000717")]
			public override object this[int index]
			{
				[Token(Token = "0x6002CBA")]
				[Address(RVA = "0x4C66D50", Offset = "0x4C65950", VA = "0x184C66D50", Slot = "27")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002CBB")]
				[Address(RVA = "0x4C66EB0", Offset = "0x4C65AB0", VA = "0x184C66EB0", Slot = "28")]
				set
				{
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000718")]
			public override object SyncRoot
			{
				[Token(Token = "0x6002CBC")]
				[Address(RVA = "0x4C66DB0", Offset = "0x4C659B0", VA = "0x184C66DB0", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002CBD RID: 11453 RVA: 0x00018780 File Offset: 0x00016980
			[Token(Token = "0x6002CBD")]
			[Address(RVA = "0x4C65560", Offset = "0x4C64160", VA = "0x184C65560", Slot = "29")]
			public override int Add(object obj)
			{
				return 0;
			}

			// Token: 0x06002CBE RID: 11454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CBE")]
			[Address(RVA = "0x4C654E0", Offset = "0x4C640E0", VA = "0x184C654E0", Slot = "30")]
			public override void AddRange(ICollection c)
			{
			}

			// Token: 0x06002CBF RID: 11455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CBF")]
			[Address(RVA = "0x4C655C0", Offset = "0x4C641C0", VA = "0x184C655C0", Slot = "31")]
			public override void Clear()
			{
			}

			// Token: 0x06002CC0 RID: 11456 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CC0")]
			[Address(RVA = "0x4C65680", Offset = "0x4C64280", VA = "0x184C65680", Slot = "32")]
			public override object Clone()
			{
				return null;
			}

			// Token: 0x06002CC1 RID: 11457 RVA: 0x00018798 File Offset: 0x00016998
			[Token(Token = "0x6002CC1")]
			[Address(RVA = "0x4C656F0", Offset = "0x4C642F0", VA = "0x184C656F0", Slot = "33")]
			public override bool Contains(object obj)
			{
				return default(bool);
			}

			// Token: 0x06002CC2 RID: 11458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CC2")]
			[Address(RVA = "0x4C657E0", Offset = "0x4C643E0", VA = "0x184C657E0", Slot = "35")]
			public override void CopyTo(System.Array array, int index)
			{
			}

			// Token: 0x06002CC3 RID: 11459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CC3")]
			[Address(RVA = "0x4C65850", Offset = "0x4C64450", VA = "0x184C65850", Slot = "36")]
			public override void CopyTo(int index, System.Array array, int arrayIndex, int count)
			{
			}

			// Token: 0x06002CC4 RID: 11460 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CC4")]
			[Address(RVA = "0x4C65BA0", Offset = "0x4C647A0", VA = "0x184C65BA0", Slot = "37")]
			public override IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002CC5 RID: 11461 RVA: 0x000187B0 File Offset: 0x000169B0
			[Token(Token = "0x6002CC5")]
			[Address(RVA = "0x4C65BF0", Offset = "0x4C647F0", VA = "0x184C65BF0", Slot = "38")]
			public override int IndexOf(object value)
			{
				return 0;
			}

			// Token: 0x06002CC6 RID: 11462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CC6")]
			[Address(RVA = "0x4C65FE0", Offset = "0x4C64BE0", VA = "0x184C65FE0", Slot = "39")]
			public override void Insert(int index, object obj)
			{
			}

			// Token: 0x06002CC7 RID: 11463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CC7")]
			[Address(RVA = "0x4C65C50", Offset = "0x4C64850", VA = "0x184C65C50", Slot = "40")]
			public override void InsertRange(int index, ICollection c)
			{
			}

			// Token: 0x06002CC8 RID: 11464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CC8")]
			[Address(RVA = "0x4C597B0", Offset = "0x4C583B0", VA = "0x184C597B0", Slot = "41")]
			public override void Remove(object value)
			{
			}

			// Token: 0x06002CC9 RID: 11465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CC9")]
			[Address(RVA = "0x4C66050", Offset = "0x4C64C50", VA = "0x184C66050", Slot = "42")]
			public override void RemoveAt(int index)
			{
			}

			// Token: 0x06002CCA RID: 11466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CCA")]
			[Address(RVA = "0x4C660B0", Offset = "0x4C64CB0", VA = "0x184C660B0", Slot = "43")]
			public override void RemoveRange(int index, int count)
			{
			}

			// Token: 0x06002CCB RID: 11467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CCB")]
			[Address(RVA = "0x4C662D0", Offset = "0x4C64ED0", VA = "0x184C662D0", Slot = "45")]
			public override void Reverse(int index, int count)
			{
			}

			// Token: 0x06002CCC RID: 11468 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CCC")]
			[Address(RVA = "0x4C666E0", Offset = "0x4C652E0", VA = "0x184C666E0", Slot = "47")]
			public override void Sort(int index, int count, IComparer comparer)
			{
			}

			// Token: 0x06002CCD RID: 11469 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CCD")]
			[Address(RVA = "0x4C66990", Offset = "0x4C65590", VA = "0x184C66990", Slot = "48")]
			public override object[] ToArray()
			{
				return null;
			}

			// Token: 0x06002CCE RID: 11470 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CCE")]
			[Address(RVA = "0x4C66A80", Offset = "0x4C65680", VA = "0x184C66A80", Slot = "49")]
			public override System.Array ToArray(System.Type type)
			{
				return null;
			}

			// Token: 0x040019BE RID: 6590
			[Token(Token = "0x40019BE")]
			[FieldOffset(Offset = "0x28")]
			private IList _list;
		}

		// Token: 0x020005DB RID: 1499
		[Token(Token = "0x20005DB")]
		[System.Serializable]
		private class ReadOnlyArrayList : ArrayList
		{
			// Token: 0x06002CCF RID: 11471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CCF")]
			[Address(RVA = "0x4C6ABD0", Offset = "0x4C697D0", VA = "0x184C6ABD0")]
			internal ReadOnlyArrayList(ArrayList l)
			{
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x000187C8 File Offset: 0x000169C8
			[Token(Token = "0x17000719")]
			public override int Count
			{
				[Token(Token = "0x6002CD0")]
				[Address(RVA = "0x4C6AC40", Offset = "0x4C69840", VA = "0x184C6AC40", Slot = "22")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000187E0 File Offset: 0x000169E0
			[Token(Token = "0x1700071A")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6002CD1")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000187F8 File Offset: 0x000169F8
			[Token(Token = "0x1700071B")]
			public override bool IsFixedSize
			{
				[Token(Token = "0x6002CD2")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "23")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x00018810 File Offset: 0x00016A10
			[Token(Token = "0x1700071C")]
			public override bool IsSynchronized
			{
				[Token(Token = "0x6002CD3")]
				[Address(RVA = "0x4C6AC90", Offset = "0x4C69890", VA = "0x184C6AC90", Slot = "25")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700071D RID: 1821
			[Token(Token = "0x1700071D")]
			public override object this[int index]
			{
				[Token(Token = "0x6002CD4")]
				[Address(RVA = "0x4C6ACE0", Offset = "0x4C698E0", VA = "0x184C6ACE0", Slot = "27")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002CD5")]
				[Address(RVA = "0x4C6ADE0", Offset = "0x4C699E0", VA = "0x184C6ADE0", Slot = "28")]
				set
				{
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700071E")]
			public override object SyncRoot
			{
				[Token(Token = "0x6002CD6")]
				[Address(RVA = "0x4C6AD30", Offset = "0x4C69930", VA = "0x184C6AD30", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002CD7 RID: 11479 RVA: 0x00018828 File Offset: 0x00016A28
			[Token(Token = "0x6002CD7")]
			[Address(RVA = "0x4C6A3E0", Offset = "0x4C68FE0", VA = "0x184C6A3E0", Slot = "29")]
			public override int Add(object obj)
			{
				return 0;
			}

			// Token: 0x06002CD8 RID: 11480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CD8")]
			[Address(RVA = "0x4C6A380", Offset = "0x4C68F80", VA = "0x184C6A380", Slot = "30")]
			public override void AddRange(ICollection c)
			{
			}

			// Token: 0x1700071F RID: 1823
			// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700071F")]
			public override int Capacity
			{
				[Token(Token = "0x6002CD9")]
				[Address(RVA = "0x4C6AD80", Offset = "0x4C69980", VA = "0x184C6AD80", Slot = "21")]
				set
				{
				}
			}

			// Token: 0x06002CDA RID: 11482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CDA")]
			[Address(RVA = "0x4C6A440", Offset = "0x4C69040", VA = "0x184C6A440", Slot = "31")]
			public override void Clear()
			{
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CDB")]
			[Address(RVA = "0x4C6A4A0", Offset = "0x4C690A0", VA = "0x184C6A4A0", Slot = "32")]
			public override object Clone()
			{
				return null;
			}

			// Token: 0x06002CDC RID: 11484 RVA: 0x00018840 File Offset: 0x00016A40
			[Token(Token = "0x6002CDC")]
			[Address(RVA = "0x4C6A690", Offset = "0x4C69290", VA = "0x184C6A690", Slot = "33")]
			public override bool Contains(object obj)
			{
				return default(bool);
			}

			// Token: 0x06002CDD RID: 11485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CDD")]
			[Address(RVA = "0x4C6A770", Offset = "0x4C69370", VA = "0x184C6A770", Slot = "35")]
			public override void CopyTo(System.Array array, int index)
			{
			}

			// Token: 0x06002CDE RID: 11486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CDE")]
			[Address(RVA = "0x4C6A6F0", Offset = "0x4C692F0", VA = "0x184C6A6F0", Slot = "36")]
			public override void CopyTo(int index, System.Array array, int arrayIndex, int count)
			{
			}

			// Token: 0x06002CDF RID: 11487 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CDF")]
			[Address(RVA = "0x4C6A7D0", Offset = "0x4C693D0", VA = "0x184C6A7D0", Slot = "37")]
			public override IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002CE0 RID: 11488 RVA: 0x00018858 File Offset: 0x00016A58
			[Token(Token = "0x6002CE0")]
			[Address(RVA = "0x4C6A820", Offset = "0x4C69420", VA = "0x184C6A820", Slot = "38")]
			public override int IndexOf(object value)
			{
				return 0;
			}

			// Token: 0x06002CE1 RID: 11489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CE1")]
			[Address(RVA = "0x4C6A8E0", Offset = "0x4C694E0", VA = "0x184C6A8E0", Slot = "39")]
			public override void Insert(int index, object obj)
			{
			}

			// Token: 0x06002CE2 RID: 11490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CE2")]
			[Address(RVA = "0x4C6A880", Offset = "0x4C69480", VA = "0x184C6A880", Slot = "40")]
			public override void InsertRange(int index, ICollection c)
			{
			}

			// Token: 0x06002CE3 RID: 11491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CE3")]
			[Address(RVA = "0x4C6AA00", Offset = "0x4C69600", VA = "0x184C6AA00", Slot = "41")]
			public override void Remove(object value)
			{
			}

			// Token: 0x06002CE4 RID: 11492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CE4")]
			[Address(RVA = "0x4C6A940", Offset = "0x4C69540", VA = "0x184C6A940", Slot = "42")]
			public override void RemoveAt(int index)
			{
			}

			// Token: 0x06002CE5 RID: 11493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CE5")]
			[Address(RVA = "0x4C6A9A0", Offset = "0x4C695A0", VA = "0x184C6A9A0", Slot = "43")]
			public override void RemoveRange(int index, int count)
			{
			}

			// Token: 0x06002CE6 RID: 11494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CE6")]
			[Address(RVA = "0x4C6AA60", Offset = "0x4C69660", VA = "0x184C6AA60", Slot = "45")]
			public override void Reverse(int index, int count)
			{
			}

			// Token: 0x06002CE7 RID: 11495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CE7")]
			[Address(RVA = "0x4C6AAC0", Offset = "0x4C696C0", VA = "0x184C6AAC0", Slot = "47")]
			public override void Sort(int index, int count, IComparer comparer)
			{
			}

			// Token: 0x06002CE8 RID: 11496 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CE8")]
			[Address(RVA = "0x4C6AB80", Offset = "0x4C69780", VA = "0x184C6AB80", Slot = "48")]
			public override object[] ToArray()
			{
				return null;
			}

			// Token: 0x06002CE9 RID: 11497 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CE9")]
			[Address(RVA = "0x4C6AB20", Offset = "0x4C69720", VA = "0x184C6AB20", Slot = "49")]
			public override System.Array ToArray(System.Type type)
			{
				return null;
			}

			// Token: 0x040019BF RID: 6591
			[Token(Token = "0x40019BF")]
			[FieldOffset(Offset = "0x28")]
			private ArrayList _list;
		}

		// Token: 0x020005DC RID: 1500
		[Token(Token = "0x20005DC")]
		[System.Serializable]
		private sealed class ArrayListEnumeratorSimple : IEnumerator, System.ICloneable
		{
			// Token: 0x06002CEA RID: 11498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CEA")]
			[Address(RVA = "0x4C58620", Offset = "0x4C57220", VA = "0x184C58620")]
			internal ArrayListEnumeratorSimple(ArrayList list)
			{
			}

			// Token: 0x06002CEB RID: 11499 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002CEB")]
			[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "7")]
			public object Clone()
			{
				return null;
			}

			// Token: 0x06002CEC RID: 11500 RVA: 0x00018870 File Offset: 0x00016A70
			[Token(Token = "0x6002CEC")]
			[Address(RVA = "0x4C582C0", Offset = "0x4C56EC0", VA = "0x184C582C0", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06002CED RID: 11501 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000720")]
			public object Current
			{
				[Token(Token = "0x6002CED")]
				[Address(RVA = "0x4C58730", Offset = "0x4C57330", VA = "0x184C58730", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002CEE RID: 11502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002CEE")]
			[Address(RVA = "0x4C584D0", Offset = "0x4C570D0", VA = "0x184C584D0", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x040019C0 RID: 6592
			[Token(Token = "0x40019C0")]
			[FieldOffset(Offset = "0x10")]
			private ArrayList _list;

			// Token: 0x040019C1 RID: 6593
			[Token(Token = "0x40019C1")]
			[FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x040019C2 RID: 6594
			[Token(Token = "0x40019C2")]
			[FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x040019C3 RID: 6595
			[Token(Token = "0x40019C3")]
			[FieldOffset(Offset = "0x20")]
			private object _currentElement;

			// Token: 0x040019C4 RID: 6596
			[Token(Token = "0x40019C4")]
			[FieldOffset(Offset = "0x28")]
			private bool _isArrayList;

			// Token: 0x040019C5 RID: 6597
			[Token(Token = "0x40019C5")]
			[FieldOffset(Offset = "0x0")]
			private static object s_dummyObject;
		}

		// Token: 0x020005DD RID: 1501
		[Token(Token = "0x20005DD")]
		internal class ArrayListDebugView
		{
		}
	}
}
