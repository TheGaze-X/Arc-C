using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004829 RID: 18473
	[Token(Token = "0x2004829")]
	public class MonopolyCommonGameEventResponse : PlayerDeltaResponse
	{
		// Token: 0x0601BEC4 RID: 114372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEC4")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public MonopolyCommonGameEventResponse()
		{
		}

		// Token: 0x04024675 RID: 149109
		[Token(Token = "0x4024675")]
		[FieldOffset(Offset = "0x28")]
		public bool taskProgressed;

		// Token: 0x04024676 RID: 149110
		[Token(Token = "0x4024676")]
		[FieldOffset(Offset = "0x29")]
		public bool combo;

		// Token: 0x04024677 RID: 149111
		[Token(Token = "0x4024677")]
		[FieldOffset(Offset = "0x30")]
		public List<string> beforeTaskIdList;
	}
}
