using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A07 RID: 31239
	[Token(Token = "0x2007A07")]
	public class Act13sidePrestigePromoteStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BC9D RID: 179357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC9D")]
		[Address(RVA = "0x27BCE00", Offset = "0x27BBA00", VA = "0x1827BCE00")]
		public Act13sidePrestigePromoteStateBean()
		{
		}

		// Token: 0x0403F5A8 RID: 259496
		[Token(Token = "0x403F5A8")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403F5A9 RID: 259497
		[Token(Token = "0x403F5A9")]
		[FieldOffset(Offset = "0x18")]
		public string orgId;

		// Token: 0x0403F5AA RID: 259498
		[Token(Token = "0x403F5AA")]
		[FieldOffset(Offset = "0x20")]
		public Act13SideData.PrestigeRank lastRank;

		// Token: 0x0403F5AB RID: 259499
		[Token(Token = "0x403F5AB")]
		[FieldOffset(Offset = "0x24")]
		public Act13SideData.PrestigeRank currentRank;

		// Token: 0x0403F5AC RID: 259500
		[Token(Token = "0x403F5AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
