using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C27 RID: 3111
	[Token(Token = "0x2000C27")]
	public class ActArchiveChaosData
	{
		// Token: 0x06006906 RID: 26886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006906")]
		[Address(RVA = "0x1FF84C0", Offset = "0x1FF70C0", VA = "0x181FF84C0")]
		public ActArchiveChaosData()
		{
		}

		// Token: 0x04003FB0 RID: 16304
		[Token(Token = "0x4003FB0")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveChaosItemData> chaos;
	}
}
