using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F8 RID: 31224
	[Token(Token = "0x20079F8")]
	public class Act13sideMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BC50 RID: 179280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC50")]
		[Address(RVA = "0x27B7C50", Offset = "0x27B6850", VA = "0x1827B7C50")]
		public Act13sideMissionStateBean()
		{
		}

		// Token: 0x0403F52F RID: 259375
		[Token(Token = "0x403F52F")]
		[FieldOffset(Offset = "0x10")]
		public Act13sideDailyMissionProperty dailyMissionProperty;

		// Token: 0x0403F530 RID: 259376
		[Token(Token = "0x403F530")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
