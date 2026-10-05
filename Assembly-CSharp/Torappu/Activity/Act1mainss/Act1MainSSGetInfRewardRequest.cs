using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007840 RID: 30784
	[Token(Token = "0x2007840")]
	public class Act1MainSSGetInfRewardRequest
	{
		// Token: 0x0602B2D4 RID: 176852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2D4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1MainSSGetInfRewardRequest()
		{
		}

		// Token: 0x0403E6A4 RID: 255652
		[Token(Token = "0x403E6A4")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403E6A5 RID: 255653
		[Token(Token = "0x403E6A5")]
		[FieldOffset(Offset = "0x18")]
		public int rewardCount;
	}
}
