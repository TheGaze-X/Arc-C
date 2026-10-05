using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200626C RID: 25196
	[Token(Token = "0x200626C")]
	public class AutoChessMultiBattleFinishServiceConfig : FinishBattleServiceConfig<AutoChessMultiBattleFinishRequest, AutoChessMultiBattleFinishResponse>
	{
		// Token: 0x06024587 RID: 148871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024587")]
		[Address(RVA = "0x1F2A9D0", Offset = "0x1F295D0", VA = "0x181F2A9D0")]
		public AutoChessMultiBattleFinishServiceConfig(string serviceCode, string actId, string sceneId)
		{
		}

		// Token: 0x06024588 RID: 148872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024588")]
		[Address(RVA = "0x1F2A950", Offset = "0x1F29550", VA = "0x181F2A950", Slot = "9")]
		public override void OnParseRequest(AutoChessMultiBattleFinishRequest request)
		{
		}

		// Token: 0x040328AA RID: 207018
		[Token(Token = "0x40328AA")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x040328AB RID: 207019
		[Token(Token = "0x40328AB")]
		[FieldOffset(Offset = "0x20")]
		private string m_sceneId;
	}
}
