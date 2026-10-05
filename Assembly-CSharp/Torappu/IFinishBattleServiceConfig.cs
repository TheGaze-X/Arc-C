using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001416 RID: 5142
	[Token(Token = "0x2001416")]
	public interface IFinishBattleServiceConfig
	{
		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060076C3 RID: 30403
		[Token(Token = "0x17000E52")]
		int overrideMaxRetryCount { [Token(Token = "0x60076C3")] get; }

		// Token: 0x060076C4 RID: 30404
		[Token(Token = "0x60076C4")]
		void SendFinishBattleService(IFinishBattleServiceSender input, bool isRetry);

		// Token: 0x060076C5 RID: 30405
		[Token(Token = "0x60076C5")]
		object TouchReqService();

		// Token: 0x060076C6 RID: 30406
		[Token(Token = "0x60076C6")]
		object TouchPostService();
	}
}
