using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B46 RID: 2886
	[Token(Token = "0x2000B46")]
	public class CharmStatus
	{
		// Token: 0x060067F2 RID: 26610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067F2")]
		[Address(RVA = "0x1EE78F0", Offset = "0x1EE64F0", VA = "0x181EE78F0")]
		public CharmStatus()
		{
		}

		// Token: 0x04003C45 RID: 15429
		[Token(Token = "0x4003C45")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> charms;

		// Token: 0x04003C46 RID: 15430
		[Token(Token = "0x4003C46")]
		[FieldOffset(Offset = "0x18")]
		public List<string> squad;
	}
}
