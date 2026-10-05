using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED6 RID: 28374
	[Token(Token = "0x2006ED6")]
	public class ActMultiV3FinishGuideBattleServiceConfig : FinishBattleServiceConfig<ActMultiV3GuideBattleFinishRequest, ActMultiV3GuideBattleFinishResponse>
	{
		// Token: 0x06028553 RID: 165203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028553")]
		[Address(RVA = "0x238BAC0", Offset = "0x238A6C0", VA = "0x18238BAC0")]
		public ActMultiV3FinishGuideBattleServiceConfig(string serviceCode, string actId)
		{
		}

		// Token: 0x06028554 RID: 165204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028554")]
		[Address(RVA = "0x238B9B0", Offset = "0x238A5B0", VA = "0x18238B9B0", Slot = "9")]
		public override void OnParseRequest(ActMultiV3GuideBattleFinishRequest request)
		{
		}

		// Token: 0x04039549 RID: 234825
		[Token(Token = "0x4039549")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;
	}
}
