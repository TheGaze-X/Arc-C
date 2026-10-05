using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public class EnableStateWithKey<TEnumKey> where TEnumKey : struct
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Token(Token = "0x6000553")]
		public bool SetState(TEnumKey key, bool isEnable)
		{
			return default(bool);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x6000554")]
		public bool IsEnable()
		{
			return default(bool);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000555")]
		public void Reset()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000556")]
		public EnableStateWithKey()
		{
		}

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x0")]
		private ListSet<int> m_keys;
	}
}
