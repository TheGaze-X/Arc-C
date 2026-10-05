using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F1 RID: 31217
	[Token(Token = "0x20079F1")]
	public class Act13sideDailyMissionSearchStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BC2A RID: 179242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC2A")]
		[Address(RVA = "0x27B2410", Offset = "0x27B1010", VA = "0x1827B2410")]
		public Act13sideDailyMissionSearchStateBean()
		{
		}

		// Token: 0x0403F4F8 RID: 259320
		[Token(Token = "0x403F4F8")]
		[FieldOffset(Offset = "0x10")]
		public Act13sideDailySearchProperty property;

		// Token: 0x0403F4F9 RID: 259321
		[Token(Token = "0x403F4F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
