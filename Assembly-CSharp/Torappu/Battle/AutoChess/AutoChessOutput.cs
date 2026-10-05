using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200270D RID: 9997
	[Token(Token = "0x200270D")]
	public class AutoChessOutput
	{
		// Token: 0x06010467 RID: 66663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010467")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessOutput()
		{
		}

		// Token: 0x040122D1 RID: 74449
		[Token(Token = "0x40122D1")]
		[FieldOffset(Offset = "0x10")]
		public bool isFromUserPause;

		// Token: 0x040122D2 RID: 74450
		[Token(Token = "0x40122D2")]
		[FieldOffset(Offset = "0x18")]
		public TrainingModeSettleData trainingSettleData;
	}
}
