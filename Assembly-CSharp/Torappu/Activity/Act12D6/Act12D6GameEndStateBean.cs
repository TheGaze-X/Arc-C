using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B02 RID: 31490
	[Token(Token = "0x2007B02")]
	public class Act12D6GameEndStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602C181 RID: 180609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C181")]
		[Address(RVA = "0x27EEA30", Offset = "0x27ED630", VA = "0x1827EEA30")]
		public Act12D6GameEndStateBean()
		{
		}

		// Token: 0x0403FE87 RID: 261767
		[Token(Token = "0x403FE87")]
		[FieldOffset(Offset = "0x10")]
		public Act12D6GameEndViewModel viewModel;

		// Token: 0x0403FE88 RID: 261768
		[Token(Token = "0x403FE88")]
		[FieldOffset(Offset = "0x18")]
		public int cacheUnlockRelicOutBuffTokenCnt;

		// Token: 0x0403FE89 RID: 261769
		[Token(Token = "0x403FE89")]
		[FieldOffset(Offset = "0x1C")]
		public int cacheUnlockRelicMilestoneTokenCnt;

		// Token: 0x0403FE8A RID: 261770
		[Token(Token = "0x403FE8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
