using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200616E RID: 24942
	[Token(Token = "0x200616E")]
	public class BossRushService : IHotfixable
	{
		// Token: 0x06023FFD RID: 147453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FFD")]
		[Address(RVA = "0x1EAB230", Offset = "0x1EA9E30", VA = "0x181EAB230")]
		public BossRushService()
		{
		}

		// Token: 0x04032027 RID: 204839
		[Token(Token = "0x4032027")]
		public const string BOSS_RUSH_RELIC_SELECT = "/activity/bossRush/relicSelect";

		// Token: 0x04032028 RID: 204840
		[Token(Token = "0x4032028")]
		public const string BOSS_RUSH_RELIC_UPGRADE = "/activity/bossRush/relicUpgrade";

		// Token: 0x04032029 RID: 204841
		[Token(Token = "0x4032029")]
		public const string BOSS_RUSH_BATTLE_START = "/activity/bossRush/battleStart";

		// Token: 0x0403202A RID: 204842
		[Token(Token = "0x403202A")]
		public const string BOSS_RUSH_BATTLE_FINISH = "/activity/bossRush/battleFinish";

		// Token: 0x0403202B RID: 204843
		[Token(Token = "0x403202B")]
		public const string BOSS_RUSH_REWARD_MILE_STONE = "/activity/rewardMilestone";

		// Token: 0x0403202C RID: 204844
		[Token(Token = "0x403202C")]
		public const string BOSS_RUSH_REWARD_ALL_MILE_STONE = "/activity/rewardAllMilestone";

		// Token: 0x0403202D RID: 204845
		[Token(Token = "0x403202D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
