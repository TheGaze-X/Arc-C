using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010E9 RID: 4329
	[Token(Token = "0x20010E9")]
	public class MedalRewardGroupData
	{
		// Token: 0x06006E8E RID: 28302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8E")]
		[Address(RVA = "0x2107B30", Offset = "0x2106730", VA = "0x182107B30")]
		public MedalRewardGroupData()
		{
		}

		// Token: 0x04005CC4 RID: 23748
		[Token(Token = "0x4005CC4")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005CC5 RID: 23749
		[Token(Token = "0x4005CC5")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x04005CC6 RID: 23750
		[Token(Token = "0x4005CC6")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemBundle> itemList;
	}
}
