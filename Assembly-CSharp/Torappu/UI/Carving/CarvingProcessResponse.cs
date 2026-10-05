using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060B6 RID: 24758
	[Token(Token = "0x20060B6")]
	public class CarvingProcessResponse : PlayerDeltaResponse
	{
		// Token: 0x06023CC6 RID: 146630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CC6")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CarvingProcessResponse()
		{
		}

		// Token: 0x04031A27 RID: 203303
		[Token(Token = "0x4031A27")]
		[FieldOffset(Offset = "0x28")]
		public int score;

		// Token: 0x04031A28 RID: 203304
		[Token(Token = "0x4031A28")]
		[FieldOffset(Offset = "0x2C")]
		public bool isTaskFinished;

		// Token: 0x04031A29 RID: 203305
		[Token(Token = "0x4031A29")]
		[FieldOffset(Offset = "0x30")]
		public List<CarvingProcessFrame> frames;
	}
}
