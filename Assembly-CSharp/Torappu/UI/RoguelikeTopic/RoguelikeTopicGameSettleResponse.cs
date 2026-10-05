using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004544 RID: 17732
	[Token(Token = "0x2004544")]
	public class RoguelikeTopicGameSettleResponse : PlayerDeltaResponse
	{
		// Token: 0x0601B09C RID: 110748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B09C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeTopicGameSettleResponse()
		{
		}

		// Token: 0x04022BB0 RID: 142256
		[Token(Token = "0x4022BB0")]
		[FieldOffset(Offset = "0x28")]
		public GameSettleGameInfo game;

		// Token: 0x04022BB1 RID: 142257
		[Token(Token = "0x4022BB1")]
		[FieldOffset(Offset = "0x30")]
		public GameSettleOuterInfo outer;
	}
}
