using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200734B RID: 29515
	[Token(Token = "0x200734B")]
	public class Act42D0ChallengeBattleFinishConfig : FinishBattleServiceConfig<Act42D0ChallengeBattleFinishRequest, Act42D0ChallengeBattleFinishResponse>
	{
		// Token: 0x06029BC4 RID: 170948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BC4")]
		[Address(RVA = "0x2554B10", Offset = "0x2553710", VA = "0x182554B10")]
		public Act42D0ChallengeBattleFinishConfig(string serviceCode, string activityId)
		{
		}

		// Token: 0x06029BC5 RID: 170949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BC5")]
		[Address(RVA = "0x2554AA0", Offset = "0x25536A0", VA = "0x182554AA0", Slot = "9")]
		public override void OnParseRequest(Act42D0ChallengeBattleFinishRequest request)
		{
		}

		// Token: 0x0403BBCF RID: 244687
		[Token(Token = "0x403BBCF")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;
	}
}
