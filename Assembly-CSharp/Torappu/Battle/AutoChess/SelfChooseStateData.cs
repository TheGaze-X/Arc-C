using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002720 RID: 10016
	[Token(Token = "0x2002720")]
	public class SelfChooseStateData
	{
		// Token: 0x0601047A RID: 66682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601047A")]
		[Address(RVA = "0x80B320", Offset = "0x809F20", VA = "0x18080B320")]
		public SelfChooseStateData()
		{
		}

		// Token: 0x04012322 RID: 74530
		[Token(Token = "0x4012322")]
		[FieldOffset(Offset = "0x10")]
		public string eventId;

		// Token: 0x04012323 RID: 74531
		[Token(Token = "0x4012323")]
		[FieldOffset(Offset = "0x18")]
		public List<ChooseStateSlot> options;
	}
}
