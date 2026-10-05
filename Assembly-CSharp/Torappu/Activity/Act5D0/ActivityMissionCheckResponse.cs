using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071E8 RID: 29160
	[Token(Token = "0x20071E8")]
	public class ActivityMissionCheckResponse : PlayerDeltaResponse
	{
		// Token: 0x060295DC RID: 169436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295DC")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityMissionCheckResponse()
		{
		}

		// Token: 0x0403B139 RID: 241977
		[Token(Token = "0x403B139")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
