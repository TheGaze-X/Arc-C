using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EDD RID: 28381
	[Token(Token = "0x2006EDD")]
	public class ActMultiV3BattleFinishResponse : PlayerDeltaResponse
	{
		// Token: 0x06028565 RID: 165221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028565")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActMultiV3BattleFinishResponse()
		{
		}

		// Token: 0x04039559 RID: 234841
		[Token(Token = "0x4039559")]
		[FieldOffset(Offset = "0x28")]
		public BattleFinishRspData data;
	}
}
