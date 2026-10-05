using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000620 RID: 1568
	[Token(Token = "0x2000620")]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	internal class LowLevelList<T>
	{
		// Token: 0x06002F42 RID: 12098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F42")]
		public LowLevelList()
		{
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F43")]
		public LowLevelList(int capacity)
		{
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x000198F0 File Offset: 0x00017AF0
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B1")]
		public int Capacity
		{
			[Token(Token = "0x6002F44")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F45")]
			set
			{
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x00019908 File Offset: 0x00017B08
		[Token(Token = "0x170007B2")]
		public int Count
		{
			[Token(Token = "0x6002F46")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007B3 RID: 1971
		[Token(Token = "0x170007B3")]
		public T this[int index]
		{
			[Token(Token = "0x6002F47")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F48")]
			set
			{
			}
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F49")]
		public void Add(T item)
		{
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4A")]
		private void EnsureCapacity(int min)
		{
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4B")]
		public void AddRange(IEnumerable<T> collection)
		{
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4C")]
		public void Clear()
		{
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00019920 File Offset: 0x00017B20
		[Token(Token = "0x6002F4D")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4E")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00019938 File Offset: 0x00017B38
		[Token(Token = "0x6002F4F")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F50")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F51")]
		public void InsertRange(int index, IEnumerable<T> collection)
		{
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00019950 File Offset: 0x00017B50
		[Token(Token = "0x6002F52")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00019968 File Offset: 0x00017B68
		[Token(Token = "0x6002F53")]
		public int RemoveAll(System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F54")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F55")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		private const int _defaultCapacity = 4;

		// Token: 0x04001A7A RID: 6778
		[Token(Token = "0x4001A7A")]
		[FieldOffset(Offset = "0x0")]
		protected T[] _items;

		// Token: 0x04001A7B RID: 6779
		[Token(Token = "0x4001A7B")]
		[FieldOffset(Offset = "0x0")]
		protected int _size;

		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x0")]
		protected int _version;

		// Token: 0x04001A7D RID: 6781
		[Token(Token = "0x4001A7D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly T[] s_emptyArray;
	}
}
