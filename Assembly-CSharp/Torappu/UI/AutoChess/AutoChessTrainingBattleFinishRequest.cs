using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200626D RID: 25197
	[Token(Token = "0x200626D")]
	public class AutoChessTrainingBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x06024589 RID: 148873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024589")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public AutoChessTrainingBattleFinishRequest()
		{
		}

		// Token: 0x040328AC RID: 207020
		[Token(Token = "0x40328AC")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}
