using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200060E RID: 1550
	[Token(Token = "0x200060E")]
	[System.Serializable]
	public readonly struct KeyValuePair<TKey, TValue>
	{
		// Token: 0x06002E92 RID: 11922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E92")]
		public KeyValuePair(TKey key, TValue value)
		{
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000795")]
		public TKey Key
		{
			[Token(Token = "0x6002E93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000796")]
		public TValue Value
		{
			[Token(Token = "0x6002E94")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002E95")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E96")]
		public void Deconstruct(out TKey key, out TValue value)
		{
		}

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x0")]
		private readonly TKey key;

		// Token: 0x04001A47 RID: 6727
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x0")]
		private readonly TValue value;
	}
}
