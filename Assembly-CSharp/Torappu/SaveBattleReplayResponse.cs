using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000618 RID: 1560
	[Token(Token = "0x2000618")]
	public class SaveBattleReplayResponse : PlayerDeltaResponse
	{
		// Token: 0x06006246 RID: 25158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006246")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SaveBattleReplayResponse()
		{
		}

		// Token: 0x04002DA2 RID: 11682
		[Token(Token = "0x4002DA2")]
		[FieldOffset(Offset = "0x28")]
		public int result;
	}
}
