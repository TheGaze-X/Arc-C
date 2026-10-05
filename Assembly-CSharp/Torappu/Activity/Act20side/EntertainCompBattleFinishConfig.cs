using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200763C RID: 30268
	[Token(Token = "0x200763C")]
	public class EntertainCompBattleFinishConfig : FinishBattleServiceConfig<CarCompetitionFinishRequest, CarCompetitionFinishResponse>
	{
		// Token: 0x0602A99C RID: 174492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A99C")]
		[Address(RVA = "0x2664380", Offset = "0x2662F80", VA = "0x182664380")]
		public EntertainCompBattleFinishConfig(string serviceCode, string activityId)
		{
		}

		// Token: 0x0602A99D RID: 174493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A99D")]
		[Address(RVA = "0x2664310", Offset = "0x2662F10", VA = "0x182664310", Slot = "9")]
		public override void OnParseRequest(CarCompetitionFinishRequest request)
		{
		}

		// Token: 0x0403D564 RID: 251236
		[Token(Token = "0x403D564")]
		[FieldOffset(Offset = "0x18")]
		private string m_activityId;
	}
}
