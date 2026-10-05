using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074CB RID: 29899
	[Token(Token = "0x20074CB")]
	public class Act25sideFinishInvestigationResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A29D RID: 172701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A29D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act25sideFinishInvestigationResponse()
		{
		}

		// Token: 0x0403C910 RID: 248080
		[Token(Token = "0x403C910")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
