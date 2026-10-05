using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200763A RID: 30266
	[Token(Token = "0x200763A")]
	public class RetroCarCompetitionFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0602A99A RID: 174490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A99A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RetroCarCompetitionFinishRequest()
		{
		}

		// Token: 0x0403D563 RID: 251235
		[Token(Token = "0x403D563")]
		[FieldOffset(Offset = "0x20")]
		public string retroId;
	}
}
