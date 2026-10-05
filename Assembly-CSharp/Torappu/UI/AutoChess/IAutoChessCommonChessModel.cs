using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062B9 RID: 25273
	[Token(Token = "0x20062B9")]
	public interface IAutoChessCommonChessModel
	{
		// Token: 0x060246AE RID: 149166
		[Token(Token = "0x60246AE")]
		int GetLevel();

		// Token: 0x060246AF RID: 149167
		[Token(Token = "0x60246AF")]
		string GetCharId();

		// Token: 0x060246B0 RID: 149168
		[Token(Token = "0x60246B0")]
		string GetTmplId();

		// Token: 0x060246B1 RID: 149169
		[Token(Token = "0x60246B1")]
		EvolvePhase GetGoldenEvolvePhase();
	}
}
