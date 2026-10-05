using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x20007A3")]
	public class ListMailBoxCommonRequest
	{
		// Token: 0x06006423 RID: 25635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006423")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ListMailBoxCommonRequest()
		{
		}

		// Token: 0x04003088 RID: 12424
		[Token(Token = "0x4003088")]
		[FieldOffset(Offset = "0x10")]
		public List<long> mailIdList;
	}
}
