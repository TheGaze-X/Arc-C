using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007277 RID: 29303
	[Token(Token = "0x2007277")]
	public class Act4D0GetRewardRequest
	{
		// Token: 0x0602981B RID: 170011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602981B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4D0GetRewardRequest()
		{
		}

		// Token: 0x0403B4EB RID: 242923
		[Token(Token = "0x403B4EB")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403B4EC RID: 242924
		[Token(Token = "0x403B4EC")]
		[FieldOffset(Offset = "0x18")]
		public string rewardId;
	}
}
