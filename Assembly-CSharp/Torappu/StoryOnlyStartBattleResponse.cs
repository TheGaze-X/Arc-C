using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	public class StoryOnlyStartBattleResponse : PlayerDeltaResponse, IAlertResponse
	{
		// Token: 0x0600656E RID: 25966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656E")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "5")]
		public List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public StoryOnlyStartBattleResponse()
		{
		}

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x30")]
		public List<CommonFinishBattleResponse.RewardModel> rewards;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x38")]
		public string[] unlockStages;

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[FieldOffset(Offset = "0x40")]
		public List<ServiceAlertStruct> alert;
	}
}
