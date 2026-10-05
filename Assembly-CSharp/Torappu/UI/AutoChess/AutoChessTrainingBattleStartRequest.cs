using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006268 RID: 25192
	[Token(Token = "0x2006268")]
	public class AutoChessTrainingBattleStartRequest
	{
		// Token: 0x0602457B RID: 148859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602457B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessTrainingBattleStartRequest()
		{
		}

		// Token: 0x040328A6 RID: 207014
		[Token(Token = "0x40328A6")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040328A7 RID: 207015
		[Token(Token = "0x40328A7")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;
	}
}
