using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006235 RID: 25141
	[Token(Token = "0x2006235")]
	public interface IAutoChessPrepareStateHandler : IHotfixable
	{
		// Token: 0x06024457 RID: 148567
		[Token(Token = "0x6024457")]
		void OnDataChanged(AutoChessPrepareModel model);
	}
}
