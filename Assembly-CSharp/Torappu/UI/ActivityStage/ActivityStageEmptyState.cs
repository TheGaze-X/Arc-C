using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006D1C RID: 27932
	[Token(Token = "0x2006D1C")]
	public class ActivityStageEmptyState : State
	{
		// Token: 0x06027D58 RID: 163160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027D58")]
		[Address(RVA = "0x22F63F0", Offset = "0x22F4FF0", VA = "0x1822F63F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027D59 RID: 163161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D59")]
		[Address(RVA = "0x22F6450", Offset = "0x22F5050", VA = "0x1822F6450")]
		public ActivityStageEmptyState()
		{
		}

		// Token: 0x0403877F RID: 231295
		[Token(Token = "0x403877F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038780 RID: 231296
		[Token(Token = "0x4038780")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
