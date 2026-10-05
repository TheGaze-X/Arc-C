using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001029 RID: 4137
	[Token(Token = "0x2001029")]
	public class MagazineLeafConst
	{
		// Token: 0x06006D7A RID: 28026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7A")]
		[Address(RVA = "0x2106DB0", Offset = "0x21059B0", VA = "0x182106DB0")]
		public MagazineLeafConst()
		{
		}

		// Token: 0x040057DD RID: 22493
		[Token(Token = "0x40057DD")]
		[FieldOffset(Offset = "0x10")]
		public List<ItemBundle> sysUnlockRewards;

		// Token: 0x040057DE RID: 22494
		[Token(Token = "0x40057DE")]
		[FieldOffset(Offset = "0x18")]
		public int leafDisplayMaxNum;

		// Token: 0x040057DF RID: 22495
		[Token(Token = "0x40057DF")]
		[FieldOffset(Offset = "0x20")]
		public long skinDefaultGainTime;

		// Token: 0x040057E0 RID: 22496
		[Token(Token = "0x40057E0")]
		[FieldOffset(Offset = "0x28")]
		public string defaultLeafId;
	}
}
