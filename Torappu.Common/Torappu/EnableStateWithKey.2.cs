using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public class EnableStateWithKey
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x00005C24 File Offset: 0x00003E24
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x55164A0", Offset = "0x55150A0", VA = "0x1855164A0")]
		public bool SetState(string key, bool isEnable)
		{
			return default(bool);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x5516400", Offset = "0x5515000", VA = "0x185516400")]
		public bool IsEnable()
		{
			return default(bool);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x5516450", Offset = "0x5515050", VA = "0x185516450")]
		public void Reset()
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x5516560", Offset = "0x5515160", VA = "0x185516560")]
		public EnableStateWithKey()
		{
		}

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<string> m_keys;
	}
}
