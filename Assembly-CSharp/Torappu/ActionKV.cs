using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	[Serializable]
	public class ActionKV<TKey>
	{
		// Token: 0x06004C73 RID: 19571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C73")]
		public ActionKV()
		{
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C74")]
		public ActionKV(TKey key, ActionArray value)
		{
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C75")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x0002D1B0 File Offset: 0x0002B3B0
		[Token(Token = "0x6004C76")]
		public static implicit operator KeyValuePair<TKey, ActionArray>(ActionKV<TKey> kv)
		{
			return default(KeyValuePair<TKey, ActionArray>);
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C77")]
		public static implicit operator ActionKV<TKey>(KeyValuePair<TKey, ActionArray> kv)
		{
			return null;
		}

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x0")]
		public TKey key;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x0")]
		public ActionArray value;
	}
}
