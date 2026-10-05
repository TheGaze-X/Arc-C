using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Serializable]
	public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000367")]
		public ReadOnlyCollectionBuilder()
		{
		}

		// Token: 0x170000AA RID: 170
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AA")]
		public int Capacity
		{
			[Token(Token = "0x6000368")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x170000AB")]
		public int Count
		{
			[Token(Token = "0x6000369")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600036A")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036B")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036C")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x170000AC RID: 172
		[Token(Token = "0x170000AC")]
		public T this[int index]
		{
			[Token(Token = "0x600036D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036E")]
			set
			{
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036F")]
		public void Add(T item)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000370")]
		public void Clear()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000371")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000372")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x170000AD")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000373")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000374")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000376")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x170000AE")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000377")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000378")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000379")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600037A")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037B")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x170000AF")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600037C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037D")]
		private void Remove(object value)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B0")]
		private object Item
		{
			[Token(Token = "0x600037E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600037F")]
			set
			{
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000380")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x170000B1")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000381")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B2")]
		private object SyncRoot
		{
			[Token(Token = "0x6000382")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			return null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000385")]
		private void EnsureCapacity(int min)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000386")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000387")]
		private static void ValidateNullValue(object value, string argument)
		{
		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x0")]
		private T[] _items;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		[Serializable]
		private class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000388")]
			internal Enumerator(ReadOnlyCollectionBuilder<T> builder)
			{
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B3")]
			public T Current
			{
				[Token(Token = "0x6000389")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600038A")]
			public void Dispose()
			{
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B4")]
			private object Current
			{
				[Token(Token = "0x600038B")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00002C10 File Offset: 0x00000E10
			[Token(Token = "0x600038C")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600038D")]
			private void Reset()
			{
			}

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x0")]
			private readonly ReadOnlyCollectionBuilder<T> _builder;

			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _version;

			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			[FieldOffset(Offset = "0x0")]
			private T _current;
		}
	}
}
