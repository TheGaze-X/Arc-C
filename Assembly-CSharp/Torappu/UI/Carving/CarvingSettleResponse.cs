using System;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060BC RID: 24764
	[Token(Token = "0x20060BC")]
	public class CarvingSettleResponse : PlayerDeltaResponse
	{
		// Token: 0x06023CCB RID: 146635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CCB")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CarvingSettleResponse()
		{
		}

		// Token: 0x04031A34 RID: 203316
		[Token(Token = "0x4031A34")]
		[FieldOffset(Offset = "0x28")]
		public string challengeId;

		// Token: 0x04031A35 RID: 203317
		[Token(Token = "0x4031A35")]
		[FieldOffset(Offset = "0x30")]
		public int score;

		// Token: 0x04031A36 RID: 203318
		[Token(Token = "0x4031A36")]
		[FieldOffset(Offset = "0x34")]
		public int oldRound;

		// Token: 0x04031A37 RID: 203319
		[Token(Token = "0x4031A37")]
		[FieldOffset(Offset = "0x38")]
		public int newRound;

		// Token: 0x04031A38 RID: 203320
		[Token(Token = "0x4031A38")]
		[FieldOffset(Offset = "0x3C")]
		public int pointStage;

		// Token: 0x04031A39 RID: 203321
		[Token(Token = "0x4031A39")]
		[FieldOffset(Offset = "0x40")]
		public int pointRound;

		// Token: 0x04031A3A RID: 203322
		[Token(Token = "0x4031A3A")]
		[FieldOffset(Offset = "0x44")]
		public int pointBefore;

		// Token: 0x04031A3B RID: 203323
		[Token(Token = "0x4031A3B")]
		[FieldOffset(Offset = "0x48")]
		public int pointAfter;
	}
}
