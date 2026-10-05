using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class DictionaryBuilder<K, V>
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		public DictionaryBuilder()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		public DictionaryBuilder(Dictionary<K, V> dic)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025D")]
		public DictionaryBuilder<K, V> Add(K key, V value)
		{
			return null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025E")]
		public Dictionary<K, V> Build()
		{
			return null;
		}

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<K, V> dictionary;
	}
}
