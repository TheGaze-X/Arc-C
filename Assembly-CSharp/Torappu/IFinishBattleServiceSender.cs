using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001415 RID: 5141
	[Token(Token = "0x2001415")]
	public interface IFinishBattleServiceSender
	{
		// Token: 0x060076C1 RID: 30401
		[Token(Token = "0x60076C1")]
		void SendFinishBattleService<TRequest, TResponse>(string serviceCode, TRequest request, bool isRetry) where TRequest : CommonFinishBattleRequest, new() where TResponse : CommonFinishBattleResponse;

		// Token: 0x060076C2 RID: 30402
		[Token(Token = "0x60076C2")]
		TRequest ParseCommonFinishBattleRequest<TRequest>() where TRequest : CommonFinishBattleRequest, new();
	}
}
