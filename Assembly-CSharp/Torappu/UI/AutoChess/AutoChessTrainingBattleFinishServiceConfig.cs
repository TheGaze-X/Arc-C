using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200626F RID: 25199
	[Token(Token = "0x200626F")]
	public class AutoChessTrainingBattleFinishServiceConfig : FinishBattleServiceConfig<AutoChessTrainingBattleFinishRequest, AutoChessTrainingBattleFinishResponse>
	{
		// Token: 0x0602458F RID: 148879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602458F")]
		[Address(RVA = "0x1F2EF90", Offset = "0x1F2DB90", VA = "0x181F2EF90")]
		public AutoChessTrainingBattleFinishServiceConfig(string serviceCode, string actId)
		{
		}

		// Token: 0x06024590 RID: 148880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024590")]
		[Address(RVA = "0x1F2EF20", Offset = "0x1F2DB20", VA = "0x181F2EF20", Slot = "9")]
		public override void OnParseRequest(AutoChessTrainingBattleFinishRequest request)
		{
		}

		// Token: 0x040328AD RID: 207021
		[Token(Token = "0x40328AD")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;
	}
}
