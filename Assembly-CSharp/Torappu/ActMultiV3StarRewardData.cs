using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E4C RID: 3660
	[Token(Token = "0x2000E4C")]
	public class ActMultiV3StarRewardData
	{
		// Token: 0x06006B1A RID: 27418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3StarRewardData()
		{
		}

		// Token: 0x04004C38 RID: 19512
		[Token(Token = "0x4004C38")]
		[FieldOffset(Offset = "0x10")]
		public int starNum;

		// Token: 0x04004C39 RID: 19513
		[Token(Token = "0x4004C39")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemBundle> rewards;

		// Token: 0x04004C3A RID: 19514
		[Token(Token = "0x4004C3A")]
		[FieldOffset(Offset = "0x20")]
		public int dailyMissionPoint;
	}
}
