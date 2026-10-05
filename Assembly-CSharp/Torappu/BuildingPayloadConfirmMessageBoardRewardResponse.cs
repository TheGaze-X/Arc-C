using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000696 RID: 1686
	[Token(Token = "0x2000696")]
	public class BuildingPayloadConfirmMessageBoardRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x060062D2 RID: 25298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D2")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingPayloadConfirmMessageBoardRewardResponse()
		{
		}

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> reward;
	}
}
