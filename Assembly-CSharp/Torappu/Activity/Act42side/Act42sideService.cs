using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072F4 RID: 29428
	[Token(Token = "0x20072F4")]
	public class Act42sideService
	{
		// Token: 0x06029A54 RID: 170580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A54")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act42sideService()
		{
		}

		// Token: 0x0403B91C RID: 243996
		[Token(Token = "0x403B91C")]
		public const string DAILY_REWARD = "/activity/act42side/getDailyRewards";

		// Token: 0x0403B91D RID: 243997
		[Token(Token = "0x403B91D")]
		public const string TRUST_TOKEN = "/activity/act42side/getDailyTrustedItem";

		// Token: 0x0403B91E RID: 243998
		[Token(Token = "0x403B91E")]
		public const string ACCEPT_TASK = "/activity/act42side/acceptTask";

		// Token: 0x0403B91F RID: 243999
		[Token(Token = "0x403B91F")]
		public const string SUBMIT_TASK = "/activity/act42side/confirmTask";
	}
}
