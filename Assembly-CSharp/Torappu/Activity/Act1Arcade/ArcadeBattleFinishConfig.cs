using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200791D RID: 31005
	[Token(Token = "0x200791D")]
	public class ArcadeBattleFinishConfig : FinishBattleServiceConfig<ArcadeFinishBattleRequest, ArcadeFinishBattleResponse>
	{
		// Token: 0x0602B7F0 RID: 178160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7F0")]
		[Address(RVA = "0x277AB30", Offset = "0x2779730", VA = "0x18277AB30", Slot = "9")]
		public override void OnParseRequest(ArcadeFinishBattleRequest request)
		{
		}

		// Token: 0x0602B7F1 RID: 178161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7F1")]
		[Address(RVA = "0x277ABA0", Offset = "0x27797A0", VA = "0x18277ABA0")]
		public ArcadeBattleFinishConfig(string activityId, string serviceCode)
		{
		}

		// Token: 0x0403EE32 RID: 257586
		[Token(Token = "0x403EE32")]
		[FieldOffset(Offset = "0x18")]
		private string m_activityId;
	}
}
