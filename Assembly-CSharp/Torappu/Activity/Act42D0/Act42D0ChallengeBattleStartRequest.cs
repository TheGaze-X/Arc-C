using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007346 RID: 29510
	[Token(Token = "0x2007346")]
	public class Act42D0ChallengeBattleStartRequest : CrisisStartBattleBaseRequest
	{
		// Token: 0x06029BBA RID: 170938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BBA")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Act42D0ChallengeBattleStartRequest()
		{
		}

		// Token: 0x0403BBC4 RID: 244676
		[Token(Token = "0x403BBC4")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403BBC5 RID: 244677
		[Token(Token = "0x403BBC5")]
		[FieldOffset(Offset = "0x28")]
		public string stageId;
	}
}
