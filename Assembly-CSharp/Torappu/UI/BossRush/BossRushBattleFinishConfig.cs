using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200617C RID: 24956
	[Token(Token = "0x200617C")]
	public class BossRushBattleFinishConfig : FinishBattleServiceConfig<BossRushFinishBattleRequest, BossRushFinishBattleResponse>
	{
		// Token: 0x06024011 RID: 147473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024011")]
		[Address(RVA = "0x1E9EE60", Offset = "0x1E9DA60", VA = "0x181E9EE60", Slot = "9")]
		public override void OnParseRequest(BossRushFinishBattleRequest request)
		{
		}

		// Token: 0x06024012 RID: 147474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024012")]
		[Address(RVA = "0x1E9EED0", Offset = "0x1E9DAD0", VA = "0x181E9EED0")]
		public BossRushBattleFinishConfig(string serviceCode, string activityId)
		{
		}

		// Token: 0x0403204B RID: 204875
		[Token(Token = "0x403204B")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;
	}
}
