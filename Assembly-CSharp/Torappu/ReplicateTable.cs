using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001133 RID: 4403
	[Token(Token = "0x2001133")]
	public class ReplicateTable
	{
		// Token: 0x06006F09 RID: 28425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F09")]
		[Address(RVA = "0x210F3B0", Offset = "0x210DFB0", VA = "0x18210F3B0")]
		public ReplicateTable()
		{
		}

		// Token: 0x04005E61 RID: 24161
		[Token(Token = "0x4005E61")]
		[FieldOffset(Offset = "0x10")]
		public List<ReplicateData> replicateList;
	}
}
