using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	public class LoadBattleReplayReponse : PlayerDeltaResponse
	{
		// Token: 0x06006248 RID: 25160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006248")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public LoadBattleReplayReponse()
		{
		}

		// Token: 0x04002DA4 RID: 11684
		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0x28")]
		public string battleReplay;
	}
}
