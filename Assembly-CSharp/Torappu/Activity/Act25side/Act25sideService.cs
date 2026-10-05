using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074C3 RID: 29891
	[Token(Token = "0x20074C3")]
	public class Act25sideService
	{
		// Token: 0x0602A295 RID: 172693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A295")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act25sideService()
		{
		}

		// Token: 0x0403C900 RID: 248064
		[Token(Token = "0x403C900")]
		public const string DAILY_REFRESH = "/act25side/dailyRefresh";

		// Token: 0x0403C901 RID: 248065
		[Token(Token = "0x403C901")]
		public const string DAILY_HARVSET = "/act25side/harvest";

		// Token: 0x0403C902 RID: 248066
		[Token(Token = "0x403C902")]
		public const string INVESTIGATE = "/act25side/investigate";

		// Token: 0x0403C903 RID: 248067
		[Token(Token = "0x403C903")]
		public const string FINISH_INVESTIGATE = "/act25side/finishInvestigation";

		// Token: 0x0403C904 RID: 248068
		[Token(Token = "0x403C904")]
		public const string BATTLE_START = "/act25side/battleStart";

		// Token: 0x0403C905 RID: 248069
		[Token(Token = "0x403C905")]
		public const string BATTLE_FINISH = "/act25side/battleFinish";
	}
}
