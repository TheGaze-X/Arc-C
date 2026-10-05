using System;
using Il2CppDummyDll;

namespace System.Dynamic.Utils
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	internal sealed class CacheDict<TKey, TValue>
	{
		// Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038F")]
		internal CacheDict(int size)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x6000390")]
		private static int AlignSize(int size)
		{
			return 0;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000391")]
		internal bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000392")]
		internal void Add(TKey key, TValue value)
		{
		}

		// Token: 0x170000B5 RID: 181
		[Token(Token = "0x170000B5")]
		internal TKey this[TKey key]
		{
			[Token(Token = "0x6000393")]
			set
			{
			}
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _mask;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x0")]
		private readonly CacheDict<TKey, TValue>.Entry[] _entries;

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		private sealed class Entry
		{
			// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000394")]
			internal Entry(int hash, TKey key, TValue value)
			{
			}

			// Token: 0x04000164 RID: 356
			[Token(Token = "0x4000164")]
			[FieldOffset(Offset = "0x0")]
			internal readonly int _hash;

			// Token: 0x04000165 RID: 357
			[Token(Token = "0x4000165")]
			[FieldOffset(Offset = "0x0")]
			internal readonly TKey _key;

			// Token: 0x04000166 RID: 358
			[Token(Token = "0x4000166")]
			[FieldOffset(Offset = "0x0")]
			internal readonly TValue _value;
		}
	}
}
