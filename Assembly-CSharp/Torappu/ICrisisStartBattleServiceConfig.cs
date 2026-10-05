using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	public interface ICrisisStartBattleServiceConfig : IStartBattleServiceConfig, IHotfixable
	{
		// Token: 0x0600631B RID: 25371
		[Token(Token = "0x600631B")]
		void SetParams(CrisisBattleStartBaseParams baseParams);
	}
}
