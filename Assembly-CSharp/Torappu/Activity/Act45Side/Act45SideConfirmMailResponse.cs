using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072B7 RID: 29367
	[Token(Token = "0x20072B7")]
	public class Act45SideConfirmMailResponse : PlayerDeltaResponse
	{
		// Token: 0x0602991D RID: 170269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602991D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act45SideConfirmMailResponse()
		{
		}

		// Token: 0x0403B706 RID: 243462
		[Token(Token = "0x403B706")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> rewards;
	}
}
