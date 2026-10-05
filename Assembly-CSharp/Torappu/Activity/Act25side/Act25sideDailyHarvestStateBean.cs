using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007505 RID: 29957
	[Token(Token = "0x2007505")]
	public class Act25sideDailyHarvestStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3AB RID: 172971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3AB")]
		[Address(RVA = "0x25DBD60", Offset = "0x25DA960", VA = "0x1825DBD60")]
		public Act25sideDailyHarvestStateBean()
		{
		}

		// Token: 0x0403CAE6 RID: 248550
		[Token(Token = "0x403CAE6")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403CAE7 RID: 248551
		[Token(Token = "0x403CAE7")]
		[FieldOffset(Offset = "0x18")]
		public Act25sideDailyHarvestProperty prop;

		// Token: 0x0403CAE8 RID: 248552
		[Token(Token = "0x403CAE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
