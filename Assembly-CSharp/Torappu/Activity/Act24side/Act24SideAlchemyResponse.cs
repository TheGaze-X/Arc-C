using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200754E RID: 30030
	[Token(Token = "0x200754E")]
	public class Act24SideAlchemyResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A4D0 RID: 173264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D0")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act24SideAlchemyResponse()
		{
		}

		// Token: 0x0403CD28 RID: 249128
		[Token(Token = "0x403CD28")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> rewards;
	}
}
