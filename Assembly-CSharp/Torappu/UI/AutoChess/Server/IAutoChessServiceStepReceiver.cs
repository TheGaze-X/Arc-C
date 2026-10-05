using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063D3 RID: 25555
	[Token(Token = "0x20063D3")]
	public interface IAutoChessServiceStepReceiver
	{
		// Token: 0x06024D8F RID: 150927
		[Token(Token = "0x6024D8F")]
		void RevStep(AutoChessBattleStepData step);

		// Token: 0x06024D90 RID: 150928
		[Token(Token = "0x6024D90")]
		void ResetStep();
	}
}
