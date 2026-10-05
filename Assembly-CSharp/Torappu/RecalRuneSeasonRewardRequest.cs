using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007D8 RID: 2008
	[Token(Token = "0x20007D8")]
	public class RecalRuneSeasonRewardRequest
	{
		// Token: 0x06006463 RID: 25699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006463")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneSeasonRewardRequest()
		{
		}

		// Token: 0x040030F8 RID: 12536
		[Token(Token = "0x40030F8")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x040030F9 RID: 12537
		[Token(Token = "0x40030F9")]
		[FieldOffset(Offset = "0x18")]
		public RecalRuneRewardType rewardType;
	}
}
