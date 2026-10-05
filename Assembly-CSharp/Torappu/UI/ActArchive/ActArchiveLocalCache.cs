using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF8 RID: 27384
	[Token(Token = "0x2006AF8")]
	public class ActArchiveLocalCache
	{
		// Token: 0x06027286 RID: 160390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027286")]
		[Address(RVA = "0x224D6E0", Offset = "0x224C2E0", VA = "0x18224D6E0")]
		public ActArchiveLocalCache()
		{
		}

		// Token: 0x04037648 RID: 226888
		[Token(Token = "0x4037648")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> localIntDict;

		// Token: 0x04037649 RID: 226889
		[Token(Token = "0x4037649")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> localStringDict;
	}
}
