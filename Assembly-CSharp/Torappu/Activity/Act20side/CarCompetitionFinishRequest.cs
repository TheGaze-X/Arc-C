using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007638 RID: 30264
	[Token(Token = "0x2007638")]
	public class CarCompetitionFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0602A998 RID: 174488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A998")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public CarCompetitionFinishRequest()
		{
		}

		// Token: 0x0403D55C RID: 251228
		[Token(Token = "0x403D55C")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}
