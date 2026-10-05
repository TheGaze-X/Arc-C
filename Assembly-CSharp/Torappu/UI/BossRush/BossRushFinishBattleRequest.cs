using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200617A RID: 24954
	[Token(Token = "0x200617A")]
	public class BossRushFinishBattleRequest : CommonFinishBattleRequest
	{
		// Token: 0x0602400F RID: 147471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602400F")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BossRushFinishBattleRequest()
		{
		}

		// Token: 0x04032044 RID: 204868
		[Token(Token = "0x4032044")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}
