using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058EB RID: 22763
	[Token(Token = "0x20058EB")]
	public class ConfirmShareMissionResponse : PlayerDeltaResponse
	{
		// Token: 0x06021311 RID: 135953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021311")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ConfirmShareMissionResponse()
		{
		}

		// Token: 0x0402D363 RID: 185187
		[Token(Token = "0x402D363")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
