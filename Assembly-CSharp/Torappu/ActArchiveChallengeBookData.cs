using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C25 RID: 3109
	[Token(Token = "0x2000C25")]
	public class ActArchiveChallengeBookData
	{
		// Token: 0x06006904 RID: 26884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006904")]
		[Address(RVA = "0x1FF8430", Offset = "0x1FF7030", VA = "0x181FF8430")]
		public ActArchiveChallengeBookData()
		{
		}

		// Token: 0x04003FAB RID: 16299
		[Token(Token = "0x4003FAB")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveChallengeBookItemData> stories;
	}
}
