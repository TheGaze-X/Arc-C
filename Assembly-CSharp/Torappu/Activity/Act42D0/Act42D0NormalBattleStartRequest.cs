using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007343 RID: 29507
	[Token(Token = "0x2007343")]
	public class Act42D0NormalBattleStartRequest : CrisisStartBattleBaseRequest
	{
		// Token: 0x06029BB5 RID: 170933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BB5")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Act42D0NormalBattleStartRequest()
		{
		}

		// Token: 0x0403BBBC RID: 244668
		[Token(Token = "0x403BBBC")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403BBBD RID: 244669
		[Token(Token = "0x403BBBD")]
		[FieldOffset(Offset = "0x28")]
		public string stageId;

		// Token: 0x0403BBBE RID: 244670
		[Token(Token = "0x403BBBE")]
		[FieldOffset(Offset = "0x30")]
		public List<string> buffs;
	}
}
