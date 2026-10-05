using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Serializable]
	public class Hashtable : IDictionary, ICollection, IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, System.ICloneable
	{
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000721")]
		private static System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Runtime.Serialization.SerializationInfo> SerializationInfoTable
		{
			[Token(Token = "0x6002CF0")]
			[Address(RVA = "0x4C650C0", Offset = "0x4C63CC0", VA = "0x184C650C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal Hashtable(bool trash)
		{
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x4C649A0", Offset = "0x4C635A0", VA = "0x184C649A0")]
		public Hashtable()
		{
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x4C648B0", Offset = "0x4C634B0", VA = "0x184C648B0")]
		public Hashtable(int capacity)
		{
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x4C64A40", Offset = "0x4C63640", VA = "0x184C64A40")]
		public Hashtable(int capacity, float loadFactor)
		{
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x4C649C0", Offset = "0x4C635C0", VA = "0x184C649C0")]
		public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
		{
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x4C643D0", Offset = "0x4C62FD0", VA = "0x184C643D0")]
		[System.Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
		public Hashtable(IHashCodeProvider hcp, IComparer comparer)
		{
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x4C64390", Offset = "0x4C62F90", VA = "0x184C64390")]
		public Hashtable(IEqualityComparer equalityComparer)
		{
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x4C64A00", Offset = "0x4C63600", VA = "0x184C64A00")]
		public Hashtable(int capacity, IEqualityComparer equalityComparer)
		{
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x4C648C0", Offset = "0x4C634C0", VA = "0x184C648C0")]
		public Hashtable(IDictionary d)
		{
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x4C64CF0", Offset = "0x4C638F0", VA = "0x184C64CF0")]
		public Hashtable(IDictionary d, float loadFactor)
		{
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x4C647E0", Offset = "0x4C633E0", VA = "0x184C647E0")]
		[System.Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
		public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
		{
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x4C64490", Offset = "0x4C63090", VA = "0x184C64490")]
		public Hashtable(IDictionary d, float loadFactor, IEqualityComparer equalityComparer)
		{
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x4C648F0", Offset = "0x4C634F0", VA = "0x184C648F0")]
		protected Hashtable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00018888 File Offset: 0x00016A88
		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x4C62D30", Offset = "0x4C61930", VA = "0x184C62D30")]
		private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
		{
			return 0U;
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x4C61D10", Offset = "0x4C60910", VA = "0x184C61D10", Slot = "23")]
		public virtual void Add(object key, object value)
		{
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D00")]
		[Address(RVA = "0x4C61D30", Offset = "0x4C60930", VA = "0x184C61D30", Slot = "24")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public virtual void Clear()
		{
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x4C61E50", Offset = "0x4C60A50", VA = "0x184C61E50", Slot = "25")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000188A0 File Offset: 0x00016AA0
		[Token(Token = "0x6002D02")]
		[Address(RVA = "0x4C62130", Offset = "0x4C60D30", VA = "0x184C62130", Slot = "26")]
		public virtual bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000188B8 File Offset: 0x00016AB8
		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x4C61F60", Offset = "0x4C60B60", VA = "0x184C61F60", Slot = "27")]
		public virtual bool ContainsKey(object key)
		{
			return default(bool);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x4C62290", Offset = "0x4C60E90", VA = "0x184C62290")]
		private void CopyKeys(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x4C62180", Offset = "0x4C60D80", VA = "0x184C62180")]
		private void CopyEntries(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x4C62330", Offset = "0x4C60F30", VA = "0x184C62330", Slot = "28")]
		public virtual void CopyTo(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x4C625F0", Offset = "0x4C611F0", VA = "0x184C625F0")]
		private void CopyValues(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x17000722 RID: 1826
		[Token(Token = "0x17000722")]
		public virtual object this[object key]
		{
			[Token(Token = "0x6002D08")]
			[Address(RVA = "0x4C64DD0", Offset = "0x4C639D0", VA = "0x184C64DD0", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D09")]
			[Address(RVA = "0x4C654C0", Offset = "0x4C640C0", VA = "0x184C654C0", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x4C64D10", Offset = "0x4C63910", VA = "0x184C64D10")]
		private void expand()
		{
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x4C65490", Offset = "0x4C64090", VA = "0x184C65490")]
		private void rehash()
		{
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0x4C64360", Offset = "0x4C62F60", VA = "0x184C64360")]
		private void UpdateVersion()
		{
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0x4C65340", Offset = "0x4C63F40", VA = "0x184C65340")]
		private void rehash(int newsize)
		{
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x4C642C0", Offset = "0x4C62EC0", VA = "0x184C642C0", Slot = "19")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x4C62690", Offset = "0x4C61290", VA = "0x184C62690", Slot = "31")]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000188D0 File Offset: 0x00016AD0
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x4C62730", Offset = "0x4C61330", VA = "0x184C62730", Slot = "32")]
		protected virtual int GetHash(object key)
		{
			return 0;
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x000188E8 File Offset: 0x00016AE8
		[Token(Token = "0x17000723")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6002D11")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x00018900 File Offset: 0x00016B00
		[Token(Token = "0x17000724")]
		public virtual bool IsFixedSize
		{
			[Token(Token = "0x6002D12")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x00018918 File Offset: 0x00016B18
		[Token(Token = "0x17000725")]
		public virtual bool IsSynchronized
		{
			[Token(Token = "0x6002D13")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00018930 File Offset: 0x00016B30
		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x4C633B0", Offset = "0x4C61FB0", VA = "0x184C633B0", Slot = "36")]
		protected virtual bool KeyEquals(object item, object key)
		{
			return default(bool);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000726")]
		public virtual ICollection Keys
		{
			[Token(Token = "0x6002D15")]
			[Address(RVA = "0x4C65030", Offset = "0x4C63C30", VA = "0x184C65030", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000727")]
		public virtual ICollection Values
		{
			[Token(Token = "0x6002D16")]
			[Address(RVA = "0x4C65190", Offset = "0x4C63D90", VA = "0x184C65190", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x4C62DC0", Offset = "0x4C619C0", VA = "0x184C62DC0")]
		private void Insert(object key, object nvalue, bool add)
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x4C65220", Offset = "0x4C63E20", VA = "0x184C65220")]
		private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode)
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x4C63F20", Offset = "0x4C62B20", VA = "0x184C63F20", Slot = "39")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public virtual void Remove(object key)
		{
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000728")]
		public virtual object SyncRoot
		{
			[Token(Token = "0x6002D1A")]
			[Address(RVA = "0x4C65110", Offset = "0x4C63D10", VA = "0x184C65110", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x00018948 File Offset: 0x00016B48
		[Token(Token = "0x17000729")]
		public virtual int Count
		{
			[Token(Token = "0x6002D1B")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x4C641F0", Offset = "0x4C62DF0", VA = "0x184C641F0")]
		public static Hashtable Synchronized(Hashtable table)
		{
			return null;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x4C627C0", Offset = "0x4C613C0", VA = "0x184C627C0", Slot = "42")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x4C63500", Offset = "0x4C62100", VA = "0x184C63500", Slot = "43")]
		public virtual void OnDeserialization(object sender)
		{
		}

		// Token: 0x040019C6 RID: 6598
		[Token(Token = "0x40019C6")]
		internal const int HashPrime = 101;

		// Token: 0x040019C7 RID: 6599
		[Token(Token = "0x40019C7")]
		private const int InitialSize = 3;

		// Token: 0x040019C8 RID: 6600
		[Token(Token = "0x40019C8")]
		private const string LoadFactorName = "LoadFactor";

		// Token: 0x040019C9 RID: 6601
		[Token(Token = "0x40019C9")]
		private const string VersionName = "Version";

		// Token: 0x040019CA RID: 6602
		[Token(Token = "0x40019CA")]
		private const string ComparerName = "Comparer";

		// Token: 0x040019CB RID: 6603
		[Token(Token = "0x40019CB")]
		private const string HashCodeProviderName = "HashCodeProvider";

		// Token: 0x040019CC RID: 6604
		[Token(Token = "0x40019CC")]
		private const string HashSizeName = "HashSize";

		// Token: 0x040019CD RID: 6605
		[Token(Token = "0x40019CD")]
		private const string KeysName = "Keys";

		// Token: 0x040019CE RID: 6606
		[Token(Token = "0x40019CE")]
		private const string ValuesName = "Values";

		// Token: 0x040019CF RID: 6607
		[Token(Token = "0x40019CF")]
		private const string KeyComparerName = "KeyComparer";

		// Token: 0x040019D0 RID: 6608
		[Token(Token = "0x40019D0")]
		[FieldOffset(Offset = "0x10")]
		private Hashtable.bucket[] _buckets;

		// Token: 0x040019D1 RID: 6609
		[Token(Token = "0x40019D1")]
		[FieldOffset(Offset = "0x18")]
		private int _count;

		// Token: 0x040019D2 RID: 6610
		[Token(Token = "0x40019D2")]
		[FieldOffset(Offset = "0x1C")]
		private int _occupancy;

		// Token: 0x040019D3 RID: 6611
		[Token(Token = "0x40019D3")]
		[FieldOffset(Offset = "0x20")]
		private int _loadsize;

		// Token: 0x040019D4 RID: 6612
		[Token(Token = "0x40019D4")]
		[FieldOffset(Offset = "0x24")]
		private float _loadFactor;

		// Token: 0x040019D5 RID: 6613
		[Token(Token = "0x40019D5")]
		[FieldOffset(Offset = "0x28")]
		private int _version;

		// Token: 0x040019D6 RID: 6614
		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isWriterInProgress;

		// Token: 0x040019D7 RID: 6615
		[Token(Token = "0x40019D7")]
		[FieldOffset(Offset = "0x30")]
		private ICollection _keys;

		// Token: 0x040019D8 RID: 6616
		[Token(Token = "0x40019D8")]
		[FieldOffset(Offset = "0x38")]
		private ICollection _values;

		// Token: 0x040019D9 RID: 6617
		[Token(Token = "0x40019D9")]
		[FieldOffset(Offset = "0x40")]
		private IEqualityComparer _keycomparer;

		// Token: 0x040019DA RID: 6618
		[Token(Token = "0x40019DA")]
		[FieldOffset(Offset = "0x48")]
		private object _syncRoot;

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[FieldOffset(Offset = "0x0")]
		private static System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable;

		// Token: 0x020005DF RID: 1503
		[Token(Token = "0x20005DF")]
		private struct bucket
		{
			// Token: 0x040019DC RID: 6620
			[Token(Token = "0x40019DC")]
			[FieldOffset(Offset = "0x0")]
			public object key;

			// Token: 0x040019DD RID: 6621
			[Token(Token = "0x40019DD")]
			[FieldOffset(Offset = "0x8")]
			public object val;

			// Token: 0x040019DE RID: 6622
			[Token(Token = "0x40019DE")]
			[FieldOffset(Offset = "0x10")]
			public int hash_coll;
		}

		// Token: 0x020005E0 RID: 1504
		[Token(Token = "0x20005E0")]
		[System.Serializable]
		private class KeyCollection : ICollection, IEnumerable
		{
			// Token: 0x06002D1F RID: 11551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D1F")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal KeyCollection(Hashtable hashtable)
			{
			}

			// Token: 0x06002D20 RID: 11552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D20")]
			[Address(RVA = "0x4C670B0", Offset = "0x4C65CB0", VA = "0x184C670B0", Slot = "9")]
			public virtual void CopyTo(System.Array array, int arrayIndex)
			{
			}

			// Token: 0x06002D21 RID: 11553 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002D21")]
			[Address(RVA = "0x4C67300", Offset = "0x4C65F00", VA = "0x184C67300", Slot = "10")]
			public virtual IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06002D22 RID: 11554 RVA: 0x00018960 File Offset: 0x00016B60
			[Token(Token = "0x1700072A")]
			public virtual bool IsSynchronized
			{
				[Token(Token = "0x6002D22")]
				[Address(RVA = "0x31EB4A0", Offset = "0x31EA0A0", VA = "0x1831EB4A0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700072B")]
			public virtual object SyncRoot
			{
				[Token(Token = "0x6002D23")]
				[Address(RVA = "0x4C673A0", Offset = "0x4C65FA0", VA = "0x184C673A0", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06002D24 RID: 11556 RVA: 0x00018978 File Offset: 0x00016B78
			[Token(Token = "0x1700072C")]
			public virtual int Count
			{
				[Token(Token = "0x6002D24")]
				[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0", Slot = "13")]
				get
				{
					return 0;
				}
			}

			// Token: 0x040019DF RID: 6623
			[Token(Token = "0x40019DF")]
			[FieldOffset(Offset = "0x10")]
			private Hashtable _hashtable;
		}

		// Token: 0x020005E1 RID: 1505
		[Token(Token = "0x20005E1")]
		[System.Serializable]
		private class ValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06002D25 RID: 11557 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D25")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal ValueCollection(Hashtable hashtable)
			{
			}

			// Token: 0x06002D26 RID: 11558 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D26")]
			[Address(RVA = "0x4C72160", Offset = "0x4C70D60", VA = "0x184C72160", Slot = "9")]
			public virtual void CopyTo(System.Array array, int arrayIndex)
			{
			}

			// Token: 0x06002D27 RID: 11559 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002D27")]
			[Address(RVA = "0x4C723B0", Offset = "0x4C70FB0", VA = "0x184C723B0", Slot = "10")]
			public virtual IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06002D28 RID: 11560 RVA: 0x00018990 File Offset: 0x00016B90
			[Token(Token = "0x1700072D")]
			public virtual bool IsSynchronized
			{
				[Token(Token = "0x6002D28")]
				[Address(RVA = "0x31EB4A0", Offset = "0x31EA0A0", VA = "0x1831EB4A0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700072E")]
			public virtual object SyncRoot
			{
				[Token(Token = "0x6002D29")]
				[Address(RVA = "0x4C673A0", Offset = "0x4C65FA0", VA = "0x184C673A0", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000189A8 File Offset: 0x00016BA8
			[Token(Token = "0x1700072F")]
			public virtual int Count
			{
				[Token(Token = "0x6002D2A")]
				[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0", Slot = "13")]
				get
				{
					return 0;
				}
			}

			// Token: 0x040019E0 RID: 6624
			[Token(Token = "0x40019E0")]
			[FieldOffset(Offset = "0x10")]
			private Hashtable _hashtable;
		}

		// Token: 0x020005E2 RID: 1506
		[Token(Token = "0x20005E2")]
		[System.Serializable]
		private class SyncHashtable : Hashtable, IEnumerable
		{
			// Token: 0x06002D2B RID: 11563 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0x4C70A90", Offset = "0x4C6F690", VA = "0x184C70A90")]
			internal SyncHashtable(Hashtable table)
			{
			}

			// Token: 0x06002D2C RID: 11564 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D2C")]
			[Address(RVA = "0x4C70A30", Offset = "0x4C6F630", VA = "0x184C70A30")]
			internal SyncHashtable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x06002D2D RID: 11565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D2D")]
			[Address(RVA = "0x4C708D0", Offset = "0x4C6F4D0", VA = "0x184C708D0", Slot = "42")]
			public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06002D2E RID: 11566 RVA: 0x000189C0 File Offset: 0x00016BC0
			[Token(Token = "0x17000730")]
			public override int Count
			{
				[Token(Token = "0x6002D2E")]
				[Address(RVA = "0x4C70AC0", Offset = "0x4C6F6C0", VA = "0x184C70AC0", Slot = "41")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000189D8 File Offset: 0x00016BD8
			[Token(Token = "0x17000731")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6002D2F")]
				[Address(RVA = "0x4C70B60", Offset = "0x4C6F760", VA = "0x184C70B60", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x06002D30 RID: 11568 RVA: 0x000189F0 File Offset: 0x00016BF0
			[Token(Token = "0x17000732")]
			public override bool IsFixedSize
			{
				[Token(Token = "0x6002D30")]
				[Address(RVA = "0x4C70B10", Offset = "0x4C6F710", VA = "0x184C70B10", Slot = "34")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06002D31 RID: 11569 RVA: 0x00018A08 File Offset: 0x00016C08
			[Token(Token = "0x17000733")]
			public override bool IsSynchronized
			{
				[Token(Token = "0x6002D31")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "35")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000734 RID: 1844
			[Token(Token = "0x17000734")]
			public override object this[object key]
			{
				[Token(Token = "0x6002D32")]
				[Address(RVA = "0x4C70BB0", Offset = "0x4C6F7B0", VA = "0x184C70BB0", Slot = "29")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002D33")]
				[Address(RVA = "0x4C70EA0", Offset = "0x4C6FAA0", VA = "0x184C70EA0", Slot = "30")]
				set
				{
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000735")]
			public override object SyncRoot
			{
				[Token(Token = "0x6002D34")]
				[Address(RVA = "0x4C70D30", Offset = "0x4C6F930", VA = "0x184C70D30", Slot = "40")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002D35 RID: 11573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D35")]
			[Address(RVA = "0x4C701F0", Offset = "0x4C6EDF0", VA = "0x184C701F0", Slot = "23")]
			public override void Add(object key, object value)
			{
			}

			// Token: 0x06002D36 RID: 11574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D36")]
			[Address(RVA = "0x4C70310", Offset = "0x4C6EF10", VA = "0x184C70310", Slot = "24")]
			public override void Clear()
			{
			}

			// Token: 0x06002D37 RID: 11575 RVA: 0x00018A20 File Offset: 0x00016C20
			[Token(Token = "0x6002D37")]
			[Address(RVA = "0x4C70700", Offset = "0x4C6F300", VA = "0x184C70700", Slot = "26")]
			public override bool Contains(object key)
			{
				return default(bool);
			}

			// Token: 0x06002D38 RID: 11576 RVA: 0x00018A38 File Offset: 0x00016C38
			[Token(Token = "0x6002D38")]
			[Address(RVA = "0x4C70640", Offset = "0x4C6F240", VA = "0x184C70640", Slot = "27")]
			public override bool ContainsKey(object key)
			{
				return default(bool);
			}

			// Token: 0x06002D39 RID: 11577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D39")]
			[Address(RVA = "0x4C70760", Offset = "0x4C6F360", VA = "0x184C70760", Slot = "28")]
			public override void CopyTo(System.Array array, int arrayIndex)
			{
			}

			// Token: 0x06002D3A RID: 11578 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002D3A")]
			[Address(RVA = "0x4C70410", Offset = "0x4C6F010", VA = "0x184C70410", Slot = "25")]
			public override object Clone()
			{
				return null;
			}

			// Token: 0x06002D3B RID: 11579 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002D3B")]
			[Address(RVA = "0x4C70880", Offset = "0x4C6F480", VA = "0x184C70880", Slot = "19")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002D3C RID: 11580 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002D3C")]
			[Address(RVA = "0x4C70880", Offset = "0x4C6F480", VA = "0x184C70880", Slot = "31")]
			public override IDictionaryEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06002D3D RID: 11581 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000736")]
			public override ICollection Keys
			{
				[Token(Token = "0x6002D3D")]
				[Address(RVA = "0x4C70C10", Offset = "0x4C6F810", VA = "0x184C70C10", Slot = "37")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000737")]
			public override ICollection Values
			{
				[Token(Token = "0x6002D3E")]
				[Address(RVA = "0x4C70D80", Offset = "0x4C6F980", VA = "0x184C70D80", Slot = "38")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002D3F RID: 11583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D3F")]
			[Address(RVA = "0x4C70920", Offset = "0x4C6F520", VA = "0x184C70920", Slot = "39")]
			public override void Remove(object key)
			{
			}

			// Token: 0x06002D40 RID: 11584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D40")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "43")]
			public override void OnDeserialization(object sender)
			{
			}

			// Token: 0x040019E1 RID: 6625
			[Token(Token = "0x40019E1")]
			[FieldOffset(Offset = "0x50")]
			protected Hashtable _table;
		}

		// Token: 0x020005E3 RID: 1507
		[Token(Token = "0x20005E3")]
		[System.Serializable]
		private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, System.ICloneable
		{
			// Token: 0x06002D41 RID: 11585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D41")]
			[Address(RVA = "0x4C61A10", Offset = "0x4C60610", VA = "0x184C61A10")]
			internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
			{
			}

			// Token: 0x06002D42 RID: 11586 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002D42")]
			[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "10")]
			public object Clone()
			{
				return null;
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06002D43 RID: 11587 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000738")]
			public virtual object Key
			{
				[Token(Token = "0x6002D43")]
				[Address(RVA = "0x4C61C30", Offset = "0x4C60830", VA = "0x184C61C30", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002D44 RID: 11588 RVA: 0x00018A50 File Offset: 0x00016C50
			[Token(Token = "0x6002D44")]
			[Address(RVA = "0x4C61800", Offset = "0x4C60400", VA = "0x184C61800", Slot = "12")]
			public virtual bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06002D45 RID: 11589 RVA: 0x00018A68 File Offset: 0x00016C68
			[Token(Token = "0x17000739")]
			public virtual DictionaryEntry Entry
			{
				[Token(Token = "0x6002D45")]
				[Address(RVA = "0x4C61B90", Offset = "0x4C60790", VA = "0x184C61B90", Slot = "13")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700073A")]
			public virtual object Current
			{
				[Token(Token = "0x6002D46")]
				[Address(RVA = "0x4C61A80", Offset = "0x4C60680", VA = "0x184C61A80", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06002D47 RID: 11591 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700073B")]
			public virtual object Value
			{
				[Token(Token = "0x6002D47")]
				[Address(RVA = "0x4C61CA0", Offset = "0x4C608A0", VA = "0x184C61CA0", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002D48 RID: 11592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D48")]
			[Address(RVA = "0x4C61940", Offset = "0x4C60540", VA = "0x184C61940", Slot = "16")]
			public virtual void Reset()
			{
			}

			// Token: 0x040019E2 RID: 6626
			[Token(Token = "0x40019E2")]
			[FieldOffset(Offset = "0x10")]
			private Hashtable _hashtable;

			// Token: 0x040019E3 RID: 6627
			[Token(Token = "0x40019E3")]
			[FieldOffset(Offset = "0x18")]
			private int _bucket;

			// Token: 0x040019E4 RID: 6628
			[Token(Token = "0x40019E4")]
			[FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x040019E5 RID: 6629
			[Token(Token = "0x40019E5")]
			[FieldOffset(Offset = "0x20")]
			private bool _current;

			// Token: 0x040019E6 RID: 6630
			[Token(Token = "0x40019E6")]
			[FieldOffset(Offset = "0x24")]
			private int _getObjectRetType;

			// Token: 0x040019E7 RID: 6631
			[Token(Token = "0x40019E7")]
			[FieldOffset(Offset = "0x28")]
			private object _currentKey;

			// Token: 0x040019E8 RID: 6632
			[Token(Token = "0x40019E8")]
			[FieldOffset(Offset = "0x30")]
			private object _currentValue;
		}

		// Token: 0x020005E4 RID: 1508
		[Token(Token = "0x20005E4")]
		internal class HashtableDebugView
		{
		}
	}
}
