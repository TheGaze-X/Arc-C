using System;
using Il2CppDummyDll;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E27 RID: 15911
	[Token(Token = "0x2003E27")]
	public abstract class SquadCustomFinishBattleServiceConfig<TReq, TRes> : FinishBattleServiceConfig<TReq, TRes> where TReq : DefaultFinishBattleRequest, new() where TRes : DefaultFinishBattleResponse, new()
	{
		// Token: 0x06018BC7 RID: 101319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BC7")]
		public SquadCustomFinishBattleServiceConfig(string serviceCode)
		{
		}
	}
}
