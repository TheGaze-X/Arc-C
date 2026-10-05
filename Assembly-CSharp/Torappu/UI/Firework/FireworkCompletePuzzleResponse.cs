using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E54 RID: 20052
	[Token(Token = "0x2004E54")]
	public class FireworkCompletePuzzleResponse : PlayerDeltaResponse
	{
		// Token: 0x0601DED3 RID: 122579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DED3")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public FireworkCompletePuzzleResponse()
		{
		}

		// Token: 0x04027B98 RID: 162712
		[Token(Token = "0x4027B98")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> rewardItems;
	}
}
