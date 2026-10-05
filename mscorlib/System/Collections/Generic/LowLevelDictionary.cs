using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	internal class LowLevelDictionary<TKey, TValue>
	{
		// Token: 0x06002EFF RID: 12031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFF")]
		public LowLevelDictionary()
		{
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F00")]
		public LowLevelDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x170007A6 RID: 1958
		[Token(Token = "0x170007A6")]
		public TKey this[TKey key]
		{
			[Token(Token = "0x6002F01")]
			set
			{
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F02")]
		public void Clear(int capacity = 17)
		{
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00019770 File Offset: 0x00017970
		[Token(Token = "0x6002F03")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F04")]
		private LowLevelDictionary<TKey, TValue>.Entry Find(TKey key)
		{
			return null;
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F05")]
		private LowLevelDictionary<TKey, TValue>.Entry UncheckedAdd(TKey key, TValue value)
		{
			return null;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F06")]
		private void ExpandBuckets()
		{
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00019788 File Offset: 0x00017988
		[Token(Token = "0x6002F07")]
		private int GetBucket(TKey key, int numBuckets = 0)
		{
			return 0;
		}

		// Token: 0x04001A5D RID: 6749
		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x0")]
		private LowLevelDictionary<TKey, TValue>.Entry[] _buckets;

		// Token: 0x04001A5E RID: 6750
		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x0")]
		private int _numEntries;

		// Token: 0x04001A5F RID: 6751
		[Token(Token = "0x4001A5F")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001A60 RID: 6752
		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x02000616 RID: 1558
		[Token(Token = "0x2000616")]
		private sealed class Entry
		{
			// Token: 0x06002F08 RID: 12040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F08")]
			public Entry()
			{
			}

			// Token: 0x04001A61 RID: 6753
			[Token(Token = "0x4001A61")]
			[FieldOffset(Offset = "0x0")]
			public TKey _key;

			// Token: 0x04001A62 RID: 6754
			[Token(Token = "0x4001A62")]
			[FieldOffset(Offset = "0x0")]
			public TValue _value;

			// Token: 0x04001A63 RID: 6755
			[Token(Token = "0x4001A63")]
			[FieldOffset(Offset = "0x0")]
			public LowLevelDictionary<TKey, TValue>.Entry _next;
		}

		// Token: 0x02000617 RID: 1559
		[Token(Token = "0x2000617")]
		private sealed class DefaultComparer<T> : IEqualityComparer<T>
		{
			// Token: 0x06002F09 RID: 12041 RVA: 0x000197A0 File Offset: 0x000179A0
			[Token(Token = "0x6002F09")]
			public bool Equals(T x, T y)
			{
				return default(bool);
			}

			// Token: 0x06002F0A RID: 12042 RVA: 0x000197B8 File Offset: 0x000179B8
			[Token(Token = "0x6002F0A")]
			public int GetHashCode(T obj)
			{
				return 0;
			}

			// Token: 0x06002F0B RID: 12043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F0B")]
			public DefaultComparer()
			{
			}
		}
	}
}
