using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A59 RID: 31321
	[Token(Token = "0x2007A59")]
	public class Act12sideService : IHotfixable
	{
		// Token: 0x0602BE11 RID: 179729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE11")]
		[Address(RVA = "0x27C4560", Offset = "0x27C3160", VA = "0x1827C4560")]
		public Act12sideService()
		{
		}

		// Token: 0x0403F8BB RID: 260283
		[Token(Token = "0x403F8BB")]
		public const string GET_CHARM_FIRST_REWARD = "/activity/tryGetCharmFirstReward";

		// Token: 0x0403F8BC RID: 260284
		[Token(Token = "0x403F8BC")]
		public const string RECYCLE_CHARMS = "/activity/recycleCharms";

		// Token: 0x0403F8BD RID: 260285
		[Token(Token = "0x403F8BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
