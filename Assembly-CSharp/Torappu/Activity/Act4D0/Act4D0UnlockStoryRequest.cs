using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007279 RID: 29305
	[Token(Token = "0x2007279")]
	public class Act4D0UnlockStoryRequest
	{
		// Token: 0x0602981D RID: 170013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602981D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4D0UnlockStoryRequest()
		{
		}

		// Token: 0x0403B4ED RID: 242925
		[Token(Token = "0x403B4ED")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403B4EE RID: 242926
		[Token(Token = "0x403B4EE")]
		[FieldOffset(Offset = "0x18")]
		public string rewardId;
	}
}
