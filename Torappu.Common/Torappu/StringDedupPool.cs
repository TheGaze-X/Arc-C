using System;
using System.Collections.Concurrent;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public class StringDedupPool : IDedupPool
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x5526F40", Offset = "0x5525B40", VA = "0x185526F40", Slot = "4")]
		public string Dedup(string s)
		{
			return null;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x5526EF0", Offset = "0x5525AF0", VA = "0x185526EF0")]
		public void Clear()
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x5526FB0", Offset = "0x5525BB0", VA = "0x185526FB0")]
		public StringDedupPool()
		{
		}

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x10")]
		private readonly ConcurrentDictionary<string, string> _pool;
	}
}
