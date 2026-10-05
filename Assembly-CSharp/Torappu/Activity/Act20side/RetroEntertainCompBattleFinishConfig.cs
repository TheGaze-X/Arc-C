using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200763D RID: 30269
	[Token(Token = "0x200763D")]
	public class RetroEntertainCompBattleFinishConfig : FinishBattleServiceConfig<RetroCarCompetitionFinishRequest, RetroCarCompetitionFinishResponse>
	{
		// Token: 0x0602A99E RID: 174494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A99E")]
		[Address(RVA = "0x26657B0", Offset = "0x26643B0", VA = "0x1826657B0")]
		public RetroEntertainCompBattleFinishConfig(string serviceCode, string retroId)
		{
		}

		// Token: 0x0602A99F RID: 174495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A99F")]
		[Address(RVA = "0x2665740", Offset = "0x2664340", VA = "0x182665740", Slot = "9")]
		public override void OnParseRequest(RetroCarCompetitionFinishRequest request)
		{
		}

		// Token: 0x0403D565 RID: 251237
		[Token(Token = "0x403D565")]
		[FieldOffset(Offset = "0x18")]
		private string m_retroId;
	}
}
