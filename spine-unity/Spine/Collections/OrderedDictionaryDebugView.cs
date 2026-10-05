using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Spine.Collections
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	internal class OrderedDictionaryDebugView<TKey, TValue>
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60007B9")]
		public OrderedDictionaryDebugView(OrderedDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001D9")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public KeyValuePair<TKey, TValue>[] Items
		{
			[Token(Token = "0x60007BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x0")]
		private readonly OrderedDictionary<TKey, TValue> dictionary;
	}
}
