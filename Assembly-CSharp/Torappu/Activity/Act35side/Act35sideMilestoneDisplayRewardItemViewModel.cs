using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007478 RID: 29816
	[Token(Token = "0x2007478")]
	public class Act35sideMilestoneDisplayRewardItemViewModel : IHotfixable
	{
		// Token: 0x0602A0DF RID: 172255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0DF")]
		[Address(RVA = "0x25983B0", Offset = "0x2596FB0", VA = "0x1825983B0")]
		public Act35sideMilestoneDisplayRewardItemViewModel(int milestoneLv, string itemName)
		{
		}

		// Token: 0x0403C585 RID: 247173
		[Token(Token = "0x403C585")]
		[FieldOffset(Offset = "0x10")]
		public int milestoneLv;

		// Token: 0x0403C586 RID: 247174
		[Token(Token = "0x403C586")]
		[FieldOffset(Offset = "0x18")]
		public string itemName;

		// Token: 0x0403C587 RID: 247175
		[Token(Token = "0x403C587")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
