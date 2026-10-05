using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Serializable]
	public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x06002E97 RID: 11927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E97")]
		public List()
		{
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E98")]
		public List(int capacity)
		{
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E99")]
		public List(IEnumerable<T> collection)
		{
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000193E0 File Offset: 0x000175E0
		// (set) Token: 0x06002E9B RID: 11931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000797")]
		public int Capacity
		{
			[Token(Token = "0x6002E9A")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E9B")]
			set
			{
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x000193F8 File Offset: 0x000175F8
		[Token(Token = "0x17000798")]
		public int Count
		{
			[Token(Token = "0x6002E9C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00019410 File Offset: 0x00017610
		[Token(Token = "0x17000799")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002E9D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x00019428 File Offset: 0x00017628
		[Token(Token = "0x1700079A")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002E9E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00019440 File Offset: 0x00017640
		[Token(Token = "0x1700079B")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002E9F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x00019458 File Offset: 0x00017658
		[Token(Token = "0x1700079C")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700079D")]
		private object SyncRoot
		{
			[Token(Token = "0x6002EA1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700079E RID: 1950
		[Token(Token = "0x1700079E")]
		public T this[int index]
		{
			[Token(Token = "0x6002EA2")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA3")]
			set
			{
			}
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00019470 File Offset: 0x00017670
		[Token(Token = "0x6002EA4")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079F")]
		private object Item
		{
			[Token(Token = "0x6002EA5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA6")]
			set
			{
			}
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA7")]
		[MethodImpl(256)]
		public void Add(T item)
		{
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA8")]
		[MethodImpl(8)]
		private void AddWithResize(T item)
		{
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00019488 File Offset: 0x00017688
		[Token(Token = "0x6002EA9")]
		private int Add(object item)
		{
			return 0;
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAA")]
		public void AddRange(IEnumerable<T> collection)
		{
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EAB")]
		public System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
		{
			return null;
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x000194A0 File Offset: 0x000176A0
		[Token(Token = "0x6002EAC")]
		public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x000194B8 File Offset: 0x000176B8
		[Token(Token = "0x6002EAD")]
		public int BinarySearch(T item)
		{
			return 0;
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x000194D0 File Offset: 0x000176D0
		[Token(Token = "0x6002EAE")]
		public int BinarySearch(T item, IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAF")]
		[MethodImpl(256)]
		public void Clear()
		{
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000194E8 File Offset: 0x000176E8
		[Token(Token = "0x6002EB0")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00019500 File Offset: 0x00017700
		[Token(Token = "0x6002EB1")]
		private bool Contains(object item)
		{
			return default(bool);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EB2")]
		public List<TOutput> ConvertAll<TOutput>(System.Converter<T, TOutput> converter)
		{
			return null;
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB3")]
		public void CopyTo(T[] array)
		{
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB4")]
		private void CopyTo(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB5")]
		public void CopyTo(int index, T[] array, int arrayIndex, int count)
		{
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB6")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB7")]
		private void EnsureCapacity(int min)
		{
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00019518 File Offset: 0x00017718
		[Token(Token = "0x6002EB8")]
		public bool Exists(System.Predicate<T> match)
		{
			return default(bool);
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EB9")]
		public T Find(System.Predicate<T> match)
		{
			return null;
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EBA")]
		public List<T> FindAll(System.Predicate<T> match)
		{
			return null;
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00019530 File Offset: 0x00017730
		[Token(Token = "0x6002EBB")]
		public int FindIndex(System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x00019548 File Offset: 0x00017748
		[Token(Token = "0x6002EBC")]
		public int FindIndex(int startIndex, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00019560 File Offset: 0x00017760
		[Token(Token = "0x6002EBD")]
		public int FindIndex(int startIndex, int count, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EBE")]
		public T FindLast(System.Predicate<T> match)
		{
			return null;
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x00019578 File Offset: 0x00017778
		[Token(Token = "0x6002EBF")]
		public int FindLastIndex(System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00019590 File Offset: 0x00017790
		[Token(Token = "0x6002EC0")]
		public int FindLastIndex(int startIndex, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000195A8 File Offset: 0x000177A8
		[Token(Token = "0x6002EC1")]
		public int FindLastIndex(int startIndex, int count, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC2")]
		public void ForEach(System.Action<T> action)
		{
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000195C0 File Offset: 0x000177C0
		[Token(Token = "0x6002EC3")]
		public List<T>.Enumerator GetEnumerator()
		{
			return default(List<T>.Enumerator);
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EC4")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EC5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EC6")]
		public List<T> GetRange(int index, int count)
		{
			return null;
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x000195D8 File Offset: 0x000177D8
		[Token(Token = "0x6002EC7")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x000195F0 File Offset: 0x000177F0
		[Token(Token = "0x6002EC8")]
		private int IndexOf(object item)
		{
			return 0;
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00019608 File Offset: 0x00017808
		[Token(Token = "0x6002EC9")]
		public int IndexOf(T item, int index)
		{
			return 0;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00019620 File Offset: 0x00017820
		[Token(Token = "0x6002ECA")]
		public int IndexOf(T item, int index, int count)
		{
			return 0;
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECB")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECC")]
		private void Insert(int index, object item)
		{
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECD")]
		public void InsertRange(int index, IEnumerable<T> collection)
		{
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00019638 File Offset: 0x00017838
		[Token(Token = "0x6002ECE")]
		public int LastIndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00019650 File Offset: 0x00017850
		[Token(Token = "0x6002ECF")]
		public int LastIndexOf(T item, int index)
		{
			return 0;
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00019668 File Offset: 0x00017868
		[Token(Token = "0x6002ED0")]
		public int LastIndexOf(T item, int index, int count)
		{
			return 0;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00019680 File Offset: 0x00017880
		[Token(Token = "0x6002ED1")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED2")]
		private void Remove(object item)
		{
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00019698 File Offset: 0x00017898
		[Token(Token = "0x6002ED3")]
		public int RemoveAll(System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED4")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED5")]
		public void RemoveRange(int index, int count)
		{
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED6")]
		public void Reverse()
		{
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED7")]
		public void Reverse(int index, int count)
		{
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED8")]
		public void Sort()
		{
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED9")]
		public void Sort(IComparer<T> comparer)
		{
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDA")]
		public void Sort(int index, int count, IComparer<T> comparer)
		{
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDB")]
		public void Sort(System.Comparison<T> comparison)
		{
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EDC")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDD")]
		public void TrimExcess()
		{
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000196B0 File Offset: 0x000178B0
		[Token(Token = "0x6002EDE")]
		public bool TrueForAll(System.Predicate<T> match)
		{
			return default(bool);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDF")]
		private void AddEnumerable(IEnumerable<T> enumerable)
		{
		}

		// Token: 0x04001A48 RID: 6728
		[Token(Token = "0x4001A48")]
		private const int DefaultCapacity = 4;

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x0")]
		private T[] _items;

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private object _syncRoot;

		// Token: 0x04001A4D RID: 6733
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly T[] s_emptyArray;

		// Token: 0x02000610 RID: 1552
		[Token(Token = "0x2000610")]
		[System.Serializable]
		public struct Enumerator : IEnumerator<T>, System.IDisposable, IEnumerator
		{
			// Token: 0x06002EE1 RID: 12001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EE1")]
			internal Enumerator(List<T> list)
			{
			}

			// Token: 0x06002EE2 RID: 12002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EE2")]
			public void Dispose()
			{
			}

			// Token: 0x06002EE3 RID: 12003 RVA: 0x000196C8 File Offset: 0x000178C8
			[Token(Token = "0x6002EE3")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06002EE4 RID: 12004 RVA: 0x000196E0 File Offset: 0x000178E0
			[Token(Token = "0x6002EE4")]
			private bool MoveNextRare()
			{
				return default(bool);
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007A0")]
			public T Current
			{
				[Token(Token = "0x6002EE5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007A1")]
			private object Current
			{
				[Token(Token = "0x6002EE6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002EE7 RID: 12007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EE7")]
			private void Reset()
			{
			}

			// Token: 0x04001A4E RID: 6734
			[Token(Token = "0x4001A4E")]
			[FieldOffset(Offset = "0x0")]
			private List<T> _list;

			// Token: 0x04001A4F RID: 6735
			[Token(Token = "0x4001A4F")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001A50 RID: 6736
			[Token(Token = "0x4001A50")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04001A51 RID: 6737
			[Token(Token = "0x4001A51")]
			[FieldOffset(Offset = "0x0")]
			private T _current;
		}
	}
}
