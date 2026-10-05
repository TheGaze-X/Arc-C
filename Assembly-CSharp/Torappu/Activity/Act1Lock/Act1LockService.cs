using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007858 RID: 30808
	[Token(Token = "0x2007858")]
	public class Act1LockService
	{
		// Token: 0x0602B323 RID: 176931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B323")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1LockService()
		{
		}

		// Token: 0x0403E739 RID: 255801
		[Token(Token = "0x403E739")]
		public const string GET_MILESTONE = "/activity/interlock/milestone";

		// Token: 0x0403E73A RID: 255802
		[Token(Token = "0x403E73A")]
		public const string GET_MILESTONE_BATCH = "/activity/interlock/milestoneBatch";

		// Token: 0x0403E73B RID: 255803
		[Token(Token = "0x403E73B")]
		public const string REFRESH_SQUAD = "/activity/interlock/refreshSquad";

		// Token: 0x0403E73C RID: 255804
		[Token(Token = "0x403E73C")]
		public const string SET_SQUAD = "/activity/interlock/setSquad";

		// Token: 0x0403E73D RID: 255805
		[Token(Token = "0x403E73D")]
		public const string SET_DEFEND = "/activity/interlock/setDefend";

		// Token: 0x0403E73E RID: 255806
		[Token(Token = "0x403E73E")]
		public const string INTERLOCK_BATTLE_START = "activity/interlock/battleStart";

		// Token: 0x0403E73F RID: 255807
		[Token(Token = "0x403E73F")]
		public const string INTERLOCK_BATTLE_FINISH = "activity/interlock/battleFinish";

		// Token: 0x0403E740 RID: 255808
		[Token(Token = "0x403E740")]
		public const string FINAL_BATTLE_START = "activity/interlock/finalBattleStart";

		// Token: 0x0403E741 RID: 255809
		[Token(Token = "0x403E741")]
		public const string FINAL_BATTLE_FINISH = "activity/interlock/finalBattleFinish";
	}
}
