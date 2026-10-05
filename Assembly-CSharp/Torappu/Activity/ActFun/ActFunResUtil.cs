using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActFun
{
	// Token: 0x02007141 RID: 28993
	[Token(Token = "0x2007141")]
	public class ActFunResUtil : IHotfixable
	{
		// Token: 0x0602928B RID: 168587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602928B")]
		[Address(RVA = "0x248F1B0", Offset = "0x248DDB0", VA = "0x18248F1B0")]
		public static void RouteToActivityFromBattle()
		{
		}

		// Token: 0x0602928C RID: 168588 RVA: 0x000D4A48 File Offset: 0x000D2C48
		[Token(Token = "0x602928C")]
		[Address(RVA = "0x248F490", Offset = "0x248E090", VA = "0x18248F490")]
		private static UIPageStackParam _GenPageStackParamToActivityFromBattle(string activityId)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x0602928D RID: 168589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602928D")]
		[Address(RVA = "0x248F580", Offset = "0x248E180", VA = "0x18248F580")]
		public ActFunResUtil()
		{
		}

		// Token: 0x0403AC82 RID: 240770
		[Token(Token = "0x403AC82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RouteToActivityFromBattle;

		// Token: 0x0403AC83 RID: 240771
		[Token(Token = "0x403AC83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenPageStackParamToActivityFromBattle;

		// Token: 0x0403AC84 RID: 240772
		[Token(Token = "0x403AC84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
