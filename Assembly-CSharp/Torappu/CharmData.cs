using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F6F RID: 3951
	[Token(Token = "0x2000F6F")]
	public class CharmData
	{
		// Token: 0x06006CA0 RID: 27808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA0")]
		[Address(RVA = "0x2100000", Offset = "0x20FEC00", VA = "0x182100000")]
		public CharmData()
		{
		}

		// Token: 0x040053E9 RID: 21481
		[Token(Token = "0x40053E9")]
		[FieldOffset(Offset = "0x10")]
		public List<CharmItemData> charmList;
	}
}
