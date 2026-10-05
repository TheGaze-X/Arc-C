using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001154 RID: 4436
	[Token(Token = "0x2001154")]
	public class RoguelikeActivityData
	{
		// Token: 0x06006F2E RID: 28462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2E")]
		[Address(RVA = "0x2110310", Offset = "0x210EF10", VA = "0x182110310")]
		public RoguelikeActivityData()
		{
		}

		// Token: 0x04005F0D RID: 24333
		[Token(Token = "0x4005F0D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeActivityBasicData> basicDatas;

		// Token: 0x04005F0E RID: 24334
		[Token(Token = "0x4005F0E")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeActivityTable activityTable;
	}
}
