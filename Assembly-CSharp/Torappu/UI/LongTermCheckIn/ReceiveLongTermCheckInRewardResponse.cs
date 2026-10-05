using System;
using Il2CppDummyDll;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049C2 RID: 18882
	[Token(Token = "0x20049C2")]
	public class ReceiveLongTermCheckInRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0601C716 RID: 116502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C716")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ReceiveLongTermCheckInRewardResponse()
		{
		}

		// Token: 0x04025453 RID: 152659
		[Token(Token = "0x4025453")]
		[FieldOffset(Offset = "0x28")]
		public RewardItemModel[] rewards;
	}
}
