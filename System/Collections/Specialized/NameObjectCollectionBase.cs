using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Specialized
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	[Serializable]
	public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101E")]
		[Address(RVA = "0x5183390", Offset = "0x5181F90", VA = "0x185183390")]
		protected NameObjectCollectionBase()
		{
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101F")]
		[Address(RVA = "0x51833F0", Offset = "0x5181FF0", VA = "0x1851833F0")]
		protected NameObjectCollectionBase(IEqualityComparer equalityComparer)
		{
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x5183350", Offset = "0x5181F50", VA = "0x185183350")]
		protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
		{
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x5183530", Offset = "0x5182130", VA = "0x185183530")]
		protected NameObjectCollectionBase(int capacity)
		{
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal NameObjectCollectionBase(DBNull dummy)
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x4A3BE10", Offset = "0x4A3AA10", VA = "0x184A3BE10")]
		protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x5181D00", Offset = "0x5180900", VA = "0x185181D00", Slot = "11")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x51824B0", Offset = "0x51810B0", VA = "0x1851824B0", Slot = "12")]
		public virtual void OnDeserialization(object sender)
		{
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x5182CD0", Offset = "0x51818D0", VA = "0x185182CD0")]
		private void Reset()
		{
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x5182DB0", Offset = "0x51819B0", VA = "0x185182DB0")]
		private void Reset(int capacity)
		{
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x5181B60", Offset = "0x5180760", VA = "0x185181B60")]
		private NameObjectCollectionBase.NameObjectEntry FindEntry(string key)
		{
			return null;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x17000344")]
		protected bool IsReadOnly
		{
			[Token(Token = "0x6001029")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600102A")]
		[Address(RVA = "0x5181320", Offset = "0x517FF20", VA = "0x185181320")]
		protected void BaseAdd(string name, object value)
		{
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x51817D0", Offset = "0x51803D0", VA = "0x1851817D0")]
		protected void BaseRemove(string name)
		{
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102C")]
		[Address(RVA = "0x5181650", Offset = "0x5180250", VA = "0x185181650")]
		protected object BaseGet(string name)
		{
			return null;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x5181A90", Offset = "0x5180690", VA = "0x185181A90")]
		protected void BaseSet(string name, object value)
		{
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x5181670", Offset = "0x5180270", VA = "0x185181670")]
		protected object BaseGet(int index)
		{
			return null;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102F")]
		[Address(RVA = "0x51814F0", Offset = "0x51800F0", VA = "0x1851814F0")]
		protected string BaseGetKey(int index)
		{
			return null;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x5181C70", Offset = "0x5180870", VA = "0x185181C70", Slot = "13")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x17000345")]
		public virtual int Count
		{
			[Token(Token = "0x6001031")]
			[Address(RVA = "0x4B16780", Offset = "0x4B15380", VA = "0x184B16780", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x5182EA0", Offset = "0x5181AA0", VA = "0x185182EA0", Slot = "4")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000346")]
		private object SyncRoot
		{
			[Token(Token = "0x6001033")]
			[Address(RVA = "0x5183220", Offset = "0x5181E20", VA = "0x185183220", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x17000347")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6001034")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x10")]
		private bool _readOnly;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x18")]
		private ArrayList _entriesArray;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x20")]
		private IEqualityComparer _keyComparer;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x28")]
		private Hashtable _entriesTable;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x30")]
		private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x38")]
		private SerializationInfo _serializationInfo;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x40")]
		private int _version;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x0")]
		private static StringComparer defaultComparer;

		// Token: 0x0200024D RID: 589
		[Token(Token = "0x200024D")]
		internal class NameObjectEntry
		{
			// Token: 0x06001036 RID: 4150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001036")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			internal NameObjectEntry(string name, object value)
			{
			}

			// Token: 0x0400084C RID: 2124
			[Token(Token = "0x400084C")]
			[FieldOffset(Offset = "0x10")]
			internal string Key;

			// Token: 0x0400084D RID: 2125
			[Token(Token = "0x400084D")]
			[FieldOffset(Offset = "0x18")]
			internal object Value;
		}

		// Token: 0x0200024E RID: 590
		[Token(Token = "0x200024E")]
		[Serializable]
		internal class NameObjectKeysEnumerator : IEnumerator
		{
			// Token: 0x06001037 RID: 4151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001037")]
			[Address(RVA = "0x51837A0", Offset = "0x51823A0", VA = "0x1851837A0")]
			internal NameObjectKeysEnumerator(NameObjectCollectionBase coll)
			{
			}

			// Token: 0x06001038 RID: 4152 RVA: 0x00007EF0 File Offset: 0x000060F0
			[Token(Token = "0x6001038")]
			[Address(RVA = "0x51835E0", Offset = "0x51821E0", VA = "0x1851835E0", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001039 RID: 4153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001039")]
			[Address(RVA = "0x5183700", Offset = "0x5182300", VA = "0x185183700", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000348")]
			public object Current
			{
				[Token(Token = "0x600103A")]
				[Address(RVA = "0x5183800", Offset = "0x5182400", VA = "0x185183800", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400084E RID: 2126
			[Token(Token = "0x400084E")]
			[FieldOffset(Offset = "0x10")]
			private int _pos;

			// Token: 0x0400084F RID: 2127
			[Token(Token = "0x400084F")]
			[FieldOffset(Offset = "0x18")]
			private NameObjectCollectionBase _coll;

			// Token: 0x04000850 RID: 2128
			[Token(Token = "0x4000850")]
			[FieldOffset(Offset = "0x20")]
			private int _version;
		}
	}
}
