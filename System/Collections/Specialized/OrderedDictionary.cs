using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Specialized
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	[Serializable]
	public class OrderedDictionary : IOrderedDictionary, IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		// Token: 0x06000FD5 RID: 4053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x5186CA0", Offset = "0x51858A0", VA = "0x185186CA0")]
		public OrderedDictionary()
		{
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x5186C60", Offset = "0x5185860", VA = "0x185186C60")]
		public OrderedDictionary(int capacity)
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x5186CD0", Offset = "0x51858D0", VA = "0x185186CD0")]
		public OrderedDictionary(int capacity, IEqualityComparer comparer)
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x36AC840", Offset = "0x36AB440", VA = "0x1836AC840")]
		protected OrderedDictionary(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x1700032B")]
		public int Count
		{
			[Token(Token = "0x6000FD9")]
			[Address(RVA = "0x5186D10", Offset = "0x5185910", VA = "0x185186D10", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x1700032C")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000FDA")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x1700032D")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000FDB")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x1700032E")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000FDC")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032F")]
		public ICollection Keys
		{
			[Token(Token = "0x6000FDD")]
			[Address(RVA = "0x5186E70", Offset = "0x5185A70", VA = "0x185186E70", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000330")]
		private ArrayList objectsArray
		{
			[Token(Token = "0x6000FDE")]
			[Address(RVA = "0x5186F70", Offset = "0x5185B70", VA = "0x185186F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000331")]
		private Hashtable objectsTable
		{
			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0x5187000", Offset = "0x5185C00", VA = "0x185187000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000332")]
		private object SyncRoot
		{
			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0x5186AE0", Offset = "0x51856E0", VA = "0x185186AE0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000333 RID: 819
		[Token(Token = "0x17000333")]
		public object this[int index]
		{
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x5186DC0", Offset = "0x51859C0", VA = "0x185186DC0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x5187370", Offset = "0x5185F70", VA = "0x185187370", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000334 RID: 820
		[Token(Token = "0x17000334")]
		public object this[object key]
		{
			[Token(Token = "0x6000FE3")]
			[Address(RVA = "0x5186D60", Offset = "0x5185960", VA = "0x185186D60", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FE4")]
			[Address(RVA = "0x51870A0", Offset = "0x5185CA0", VA = "0x1851870A0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000335")]
		public ICollection Values
		{
			[Token(Token = "0x6000FE5")]
			[Address(RVA = "0x5186EF0", Offset = "0x5185AF0", VA = "0x185186EF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x5185AC0", Offset = "0x51846C0", VA = "0x185185AC0", Slot = "14")]
		public void Add(object key, object value)
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x5185C30", Offset = "0x5184830", VA = "0x185185C30", Slot = "15")]
		public void Clear()
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x5185D20", Offset = "0x5184920", VA = "0x185185D20", Slot = "13")]
		public bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x5185D80", Offset = "0x5184980", VA = "0x185185D80", Slot = "20")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x51860A0", Offset = "0x5184CA0", VA = "0x1851860A0")]
		private int IndexOfKey(object key)
		{
			return 0;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x5186230", Offset = "0x5184E30", VA = "0x185186230", Slot = "7")]
		public void Insert(int index, object key, object value)
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x51867C0", Offset = "0x51853C0", VA = "0x1851867C0", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x51869B0", Offset = "0x51855B0", VA = "0x1851869B0", Slot = "19")]
		public void Remove(object key)
		{
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x5185DF0", Offset = "0x51849F0", VA = "0x185185DF0", Slot = "27")]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x5186B60", Offset = "0x5185760", VA = "0x185186B60", Slot = "24")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x5185EA0", Offset = "0x5184AA0", VA = "0x185185EA0", Slot = "28")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x5186C10", Offset = "0x5185810", VA = "0x185186C10", Slot = "26")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x5186420", Offset = "0x5185020", VA = "0x185186420", Slot = "29")]
		protected virtual void OnDeserialization(object sender)
		{
		}

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x10")]
		private ArrayList _objectsArray;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x18")]
		private Hashtable _objectsTable;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x20")]
		private int _initialCapacity;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x28")]
		private IEqualityComparer _comparer;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x30")]
		private bool _readOnly;

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x38")]
		private object _syncRoot;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x40")]
		private SerializationInfo _siInfo;

		// Token: 0x02000247 RID: 583
		[Token(Token = "0x2000247")]
		private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06000FF3 RID: 4083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FF3")]
			[Address(RVA = "0x5185180", Offset = "0x5183D80", VA = "0x185185180")]
			internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType)
			{
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000336")]
			public object Current
			{
				[Token(Token = "0x6000FF4")]
				[Address(RVA = "0x5185200", Offset = "0x5183E00", VA = "0x185185200", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00007D58 File Offset: 0x00005F58
			[Token(Token = "0x17000337")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6000FF5")]
				[Address(RVA = "0x5185420", Offset = "0x5184020", VA = "0x185185420", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000338")]
			public object Key
			{
				[Token(Token = "0x6000FF6")]
				[Address(RVA = "0x5185530", Offset = "0x5184130", VA = "0x185185530", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000339")]
			public object Value
			{
				[Token(Token = "0x6000FF7")]
				[Address(RVA = "0x51855C0", Offset = "0x51841C0", VA = "0x1851855C0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000FF8 RID: 4088 RVA: 0x00007D70 File Offset: 0x00005F70
			[Token(Token = "0x6000FF8")]
			[Address(RVA = "0x51850E0", Offset = "0x5183CE0", VA = "0x1851850E0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000FF9 RID: 4089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FF9")]
			[Address(RVA = "0x5185130", Offset = "0x5183D30", VA = "0x185185130", Slot = "9")]
			public void Reset()
			{
			}

			// Token: 0x0400083D RID: 2109
			[Token(Token = "0x400083D")]
			[FieldOffset(Offset = "0x10")]
			private int _objectReturnType;

			// Token: 0x0400083E RID: 2110
			[Token(Token = "0x400083E")]
			[FieldOffset(Offset = "0x18")]
			private IEnumerator _arrayEnumerator;
		}

		// Token: 0x02000248 RID: 584
		[Token(Token = "0x2000248")]
		private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06000FFA RID: 4090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FFA")]
			[Address(RVA = "0x1182440", Offset = "0x1181040", VA = "0x181182440")]
			public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys)
			{
			}

			// Token: 0x06000FFB RID: 4091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FFB")]
			[Address(RVA = "0x5185650", Offset = "0x5184250", VA = "0x185185650", Slot = "4")]
			private void CopyTo(Array array, int index)
			{
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00007D88 File Offset: 0x00005F88
			[Token(Token = "0x1700033A")]
			private int Count
			{
				[Token(Token = "0x6000FFC")]
				[Address(RVA = "0x4C5C450", Offset = "0x4C5B050", VA = "0x184C5C450", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00007DA0 File Offset: 0x00005FA0
			[Token(Token = "0x1700033B")]
			private bool IsSynchronized
			{
				[Token(Token = "0x6000FFD")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700033C")]
			private object SyncRoot
			{
				[Token(Token = "0x6000FFE")]
				[Address(RVA = "0x4C5BA80", Offset = "0x4C5A680", VA = "0x184C5BA80", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000FFF RID: 4095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0x5185A00", Offset = "0x5184600", VA = "0x185185A00", Slot = "8")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400083F RID: 2111
			[Token(Token = "0x400083F")]
			[FieldOffset(Offset = "0x10")]
			private ArrayList _objects;

			// Token: 0x04000840 RID: 2112
			[Token(Token = "0x4000840")]
			[FieldOffset(Offset = "0x18")]
			private bool _isKeys;
		}
	}
}
