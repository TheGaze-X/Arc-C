using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E2")]
		public HashSet()
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E3")]
		public HashSet(IEqualityComparer<T> comparer)
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E4")]
		public HashSet(int capacity)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E5")]
		public HashSet(IEnumerable<T> collection)
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E6")]
		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E7")]
		protected HashSet(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E8")]
		private void CopyFrom(HashSet<T> source)
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E9")]
		public HashSet(int capacity, IEqualityComparer<T> comparer)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EA")]
		private void Add(T item)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EB")]
		public void Clear()
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x60003EC")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003ED")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x60003EE")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x170000B7")]
		public int Count
		{
			[Token(Token = "0x60003EF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x170000B8")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60003F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x60003F1")]
		public HashSet<T>.Enumerator GetEnumerator()
		{
			return default(HashSet<T>.Enumerator);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F4")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F5")]
		public virtual void OnDeserialization(object sender)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x60003F6")]
		public bool Add(T item)
		{
			return default(bool);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F7")]
		public void UnionWith(IEnumerable<T> other)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F8")]
		public void SymmetricExceptWith(IEnumerable<T> other)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x60003F9")]
		public bool IsSubsetOf(IEnumerable<T> other)
		{
			return default(bool);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x60003FA")]
		public bool SetEquals(IEnumerable<T> other)
		{
			return default(bool);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FB")]
		public void CopyTo(T[] array)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FC")]
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x60003FD")]
		public int RemoveWhere(Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		public IEqualityComparer<T> Comparer
		{
			[Token(Token = "0x60003FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FF")]
		public void TrimExcess()
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x6000400")]
		private int Initialize(int capacity)
		{
			return 0;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000401")]
		private void IncreaseCapacity()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000402")]
		private void SetCapacity(int newSize)
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000403")]
		private bool AddIfNotPresent(T value)
		{
			return default(bool);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000404")]
		private void AddValue(int index, int hashCode, T value)
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x6000405")]
		private bool ContainsAllElements(IEnumerable<T> other)
		{
			return default(bool);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x6000406")]
		private bool IsSubsetOfHashSetWithSameEC(HashSet<T> other)
		{
			return default(bool);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x6000407")]
		private int InternalIndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000408")]
		private void SymmetricExceptWithUniqueHashSet(HashSet<T> other)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000409")]
		private void SymmetricExceptWithEnumerable(IEnumerable<T> other)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x600040A")]
		private bool AddOrGetLocation(T value, out int location)
		{
			return default(bool);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x600040B")]
		private HashSet<T>.ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
		{
			return default(HashSet<T>.ElementCount);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x600040C")]
		private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			return default(bool);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x600040D")]
		private int InternalGetHashCode(T item)
		{
			return 0;
		}

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		private const int Lower31BitMask = 2147483647;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		private const int StackAllocThreshold = 100;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		private const int ShrinkThreshold = 3;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		private const string CapacityName = "Capacity";

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		private const string ElementsName = "Elements";

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		private const string ComparerName = "Comparer";

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		private const string VersionName = "Version";

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x0")]
		private int[] _buckets;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x0")]
		private HashSet<T>.Slot[] _slots;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x0")]
		private int _count;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x0")]
		private int _lastIndex;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x0")]
		private int _freeList;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<T> _comparer;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x0")]
		private SerializationInfo _siInfo;

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x2000079")]
		internal struct ElementCount
		{
			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x0")]
			internal int uniqueCount;

			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x0")]
			internal int unfoundCount;
		}

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		internal struct Slot
		{
			// Token: 0x04000182 RID: 386
			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x0")]
			internal int hashCode;

			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x0")]
			internal int next;

			// Token: 0x04000184 RID: 388
			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x0")]
			internal T value;
		}

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040E")]
			internal Enumerator(HashSet<T> set)
			{
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040F")]
			public void Dispose()
			{
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x00003168 File Offset: 0x00001368
			[Token(Token = "0x6000410")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000BA")]
			public T Current
			{
				[Token(Token = "0x6000411")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000BB")]
			private object Current
			{
				[Token(Token = "0x6000412")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000413")]
			private void Reset()
			{
			}

			// Token: 0x04000185 RID: 389
			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x0")]
			private HashSet<T> _set;

			// Token: 0x04000186 RID: 390
			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04000188 RID: 392
			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x0")]
			private T _current;
		}
	}
}
