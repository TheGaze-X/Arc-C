using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	internal sealed class LocalDataStoreElement
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x4D1E920", Offset = "0x4D1D520", VA = "0x184D1E920")]
		public LocalDataStoreElement(long cookie)
		{
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		public object Value
		{
			[Token(Token = "0x6000D92")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x17000128")]
		public long Cookie
		{
			[Token(Token = "0x6000D94")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x10")]
		private object m_value;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x18")]
		private long m_cookie;
	}
}
