using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013E1 RID: 5089
	[Token(Token = "0x20013E1")]
	public class EnumIntStructDictionary<TKey, TValue> where TKey : struct where TValue : struct
	{
		// Token: 0x17000E2F RID: 3631
		[Token(Token = "0x17000E2F")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6007426")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007427")]
			set
			{
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00033A68 File Offset: 0x00031C68
		[Token(Token = "0x6007428")]
		public EnumIntStructDictionary<TKey, TValue>.KeyValueEnumerator GetEnumerator()
		{
			return default(EnumIntStructDictionary<TKey, TValue>.KeyValueEnumerator);
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06007429 RID: 29737 RVA: 0x00033A80 File Offset: 0x00031C80
		[Token(Token = "0x17000E30")]
		public int Count
		{
			[Token(Token = "0x6007429")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742A")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742B")]
		public void Add(KeyValuePair<TKey, TValue> pair)
		{
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742C")]
		public void Clear()
		{
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x00033A98 File Offset: 0x00031C98
		[Token(Token = "0x600742D")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x00033AB0 File Offset: 0x00031CB0
		[Token(Token = "0x600742E")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x00033AC8 File Offset: 0x00031CC8
		[Token(Token = "0x600742F")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007430")]
		public EnumIntStructDictionary()
		{
		}

		// Token: 0x040071BD RID: 29117
		[Token(Token = "0x40071BD")]
		[FieldOffset(Offset = "0x0")]
		private LocalGenericPool<StructWrapper<TValue>> m_wrapperPool;

		// Token: 0x040071BE RID: 29118
		[Token(Token = "0x40071BE")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, StructWrapper<TValue>> m_impl;

		// Token: 0x020013E2 RID: 5090
		[Token(Token = "0x20013E2")]
		public struct KeyValueEnumerator
		{
			// Token: 0x06007431 RID: 29745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007431")]
			public KeyValueEnumerator(Dictionary<int, StructWrapper<TValue>> dictionary)
			{
			}

			// Token: 0x06007432 RID: 29746 RVA: 0x00033AE0 File Offset: 0x00031CE0
			[Token(Token = "0x6007432")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E31 RID: 3633
			// (get) Token: 0x06007433 RID: 29747 RVA: 0x00033AF8 File Offset: 0x00031CF8
			[Token(Token = "0x17000E31")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6007433")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			// Token: 0x06007434 RID: 29748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007434")]
			public void Dispose()
			{
			}

			// Token: 0x040071BF RID: 29119
			[Token(Token = "0x40071BF")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<int, StructWrapper<TValue>>.Enumerator m_enumerator;
		}
	}
}
