using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A09 RID: 31241
	[Token(Token = "0x2007A09")]
	public class Act13sidePrestigeRewardStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BCA3 RID: 179363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCA3")]
		[Address(RVA = "0x27BD160", Offset = "0x27BBD60", VA = "0x1827BD160")]
		public Act13sidePrestigeRewardStateBean()
		{
		}

		// Token: 0x0403F5B4 RID: 259508
		[Token(Token = "0x403F5B4")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403F5B5 RID: 259509
		[Token(Token = "0x403F5B5")]
		[FieldOffset(Offset = "0x18")]
		public Act13SideData.OrgData orgData;

		// Token: 0x0403F5B6 RID: 259510
		[Token(Token = "0x403F5B6")]
		[FieldOffset(Offset = "0x20")]
		public Act13SideData.PrestigeRank currentRank;

		// Token: 0x0403F5B7 RID: 259511
		[Token(Token = "0x403F5B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
