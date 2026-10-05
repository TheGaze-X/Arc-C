using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x0200785B RID: 30811
	[Token(Token = "0x200785B")]
	public class Act1LockGetMilestoneRespone : PlayerDeltaResponse
	{
		// Token: 0x0602B326 RID: 176934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B326")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1LockGetMilestoneRespone()
		{
		}

		// Token: 0x0403E746 RID: 255814
		[Token(Token = "0x403E746")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> items;
	}
}
