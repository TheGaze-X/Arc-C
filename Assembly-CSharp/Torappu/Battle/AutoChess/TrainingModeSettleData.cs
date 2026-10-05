using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002732 RID: 10034
	[Token(Token = "0x2002732")]
	public class TrainingModeSettleData
	{
		// Token: 0x0601048C RID: 66700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601048C")]
		[Address(RVA = "0x80B8E0", Offset = "0x80A4E0", VA = "0x18080B8E0")]
		public TrainingModeSettleData()
		{
		}

		// Token: 0x0401235F RID: 74591
		[Token(Token = "0x401235F")]
		[FieldOffset(Offset = "0x10")]
		public DateTime gameStartTime;

		// Token: 0x04012360 RID: 74592
		[Token(Token = "0x4012360")]
		[FieldOffset(Offset = "0x18")]
		public bool gameWin;

		// Token: 0x04012361 RID: 74593
		[Token(Token = "0x4012361")]
		[FieldOffset(Offset = "0x1C")]
		public int finishRound;

		// Token: 0x04012362 RID: 74594
		[Token(Token = "0x4012362")]
		[FieldOffset(Offset = "0x20")]
		public List<TrainingModeSettleData.TrainingChess> trainingChesses;

		// Token: 0x04012363 RID: 74595
		[Token(Token = "0x4012363")]
		[FieldOffset(Offset = "0x28")]
		public List<GarrisonBond> playerBondStatus;

		// Token: 0x02002733 RID: 10035
		[Token(Token = "0x2002733")]
		public class TrainingChess
		{
			// Token: 0x0601048D RID: 66701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601048D")]
			[Address(RVA = "0x80B850", Offset = "0x80A450", VA = "0x18080B850")]
			public TrainingChess()
			{
			}

			// Token: 0x04012364 RID: 74596
			[Token(Token = "0x4012364")]
			[FieldOffset(Offset = "0x10")]
			public string chessId;

			// Token: 0x04012365 RID: 74597
			[Token(Token = "0x4012365")]
			[FieldOffset(Offset = "0x18")]
			public List<string> equipChesses;
		}
	}
}
