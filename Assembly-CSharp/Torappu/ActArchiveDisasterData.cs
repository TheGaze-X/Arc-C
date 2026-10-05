using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C32 RID: 3122
	[Token(Token = "0x2000C32")]
	public class ActArchiveDisasterData
	{
		// Token: 0x06006910 RID: 26896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006910")]
		[Address(RVA = "0x1FF8940", Offset = "0x1FF7540", VA = "0x181FF8940")]
		public ActArchiveDisasterData()
		{
		}

		// Token: 0x04003FD9 RID: 16345
		[Token(Token = "0x4003FD9")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveDisasterItemData> disasters;
	}
}
