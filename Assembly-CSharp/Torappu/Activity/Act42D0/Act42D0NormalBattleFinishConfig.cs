using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007348 RID: 29512
	[Token(Token = "0x2007348")]
	public class Act42D0NormalBattleFinishConfig : FinishBattleServiceConfig<Act42D0NormalBattleFinishRequest, Act42D0NormalBattleFinishResponse>
	{
		// Token: 0x06029BBC RID: 170940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BBC")]
		[Address(RVA = "0x2560C90", Offset = "0x255F890", VA = "0x182560C90")]
		public Act42D0NormalBattleFinishConfig(string serviceCode, string activityId)
		{
		}

		// Token: 0x06029BBD RID: 170941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BBD")]
		[Address(RVA = "0x2560C20", Offset = "0x255F820", VA = "0x182560C20", Slot = "9")]
		public override void OnParseRequest(Act42D0NormalBattleFinishRequest request)
		{
		}

		// Token: 0x0403BBC6 RID: 244678
		[Token(Token = "0x403BBC6")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;
	}
}
