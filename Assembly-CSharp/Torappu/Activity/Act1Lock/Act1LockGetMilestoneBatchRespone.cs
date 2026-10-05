using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x0200785D RID: 30813
	[Token(Token = "0x200785D")]
	public class Act1LockGetMilestoneBatchRespone : PlayerDeltaResponse
	{
		// Token: 0x0602B328 RID: 176936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B328")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1LockGetMilestoneBatchRespone()
		{
		}

		// Token: 0x0403E748 RID: 255816
		[Token(Token = "0x403E748")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> items;
	}
}
