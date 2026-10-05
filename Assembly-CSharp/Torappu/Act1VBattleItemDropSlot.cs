using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CA6 RID: 3238
	[Token(Token = "0x2000CA6")]
	public class Act1VBattleItemDropSlot
	{
		// Token: 0x06006982 RID: 27010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006982")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VBattleItemDropSlot()
		{
		}

		// Token: 0x04004227 RID: 16935
		[Token(Token = "0x4004227")]
		[FieldOffset(Offset = "0x10")]
		public float prob;

		// Token: 0x04004228 RID: 16936
		[Token(Token = "0x4004228")]
		[FieldOffset(Offset = "0x18")]
		public List<Act1VWeightedBattleItemPool> itemPools;
	}
}
