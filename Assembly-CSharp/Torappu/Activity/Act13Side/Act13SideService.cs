using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079CF RID: 31183
	[Token(Token = "0x20079CF")]
	public class Act13SideService : IHotfixable
	{
		// Token: 0x0602BBDA RID: 179162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBDA")]
		[Address(RVA = "0x2799B40", Offset = "0x2798740", VA = "0x182799B40")]
		public Act13SideService()
		{
		}

		// Token: 0x0403F46E RID: 259182
		[Token(Token = "0x403F46E")]
		public const string DAILY_MISSION_RANDOM = "/activity/act13side/dailyMissionRandom";

		// Token: 0x0403F46F RID: 259183
		[Token(Token = "0x403F46F")]
		public const string DAILY_MISSION_ACCEPT = "/activity/act13side/dailyMissionAccept";

		// Token: 0x0403F470 RID: 259184
		[Token(Token = "0x403F470")]
		public const string DAILY_MISSION_CANCEL = "/activity/act13side/dailyMissionCancel";

		// Token: 0x0403F471 RID: 259185
		[Token(Token = "0x403F471")]
		public const string DAILY_MISSION_COMMIT = "/activity/act13side/dailyMissionCommit";

		// Token: 0x0403F472 RID: 259186
		[Token(Token = "0x403F472")]
		public const string DAILY_MISSION_REPLACE = "/activity/act13side/dailyMissionReplace";

		// Token: 0x0403F473 RID: 259187
		[Token(Token = "0x403F473")]
		public const string LONG_MISSION_COMMIT = "/activity/act13side/longMissionCommit";

		// Token: 0x0403F474 RID: 259188
		[Token(Token = "0x403F474")]
		public const string CLEAR_FLAG = "/activity/act13side/clearFlag";

		// Token: 0x0403F475 RID: 259189
		[Token(Token = "0x403F475")]
		public const string LONG_MISSION_ALL_COMMIT = "/activity/act13side/longMissionCommitBatch";

		// Token: 0x0403F476 RID: 259190
		[Token(Token = "0x403F476")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
