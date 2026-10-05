using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007724 RID: 30500
	[Token(Token = "0x2007724")]
	public class Act1VHalfIdleCharUpgradeRewardViewModel : IHotfixable
	{
		// Token: 0x0602ADAD RID: 175533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADAD")]
		[Address(RVA = "0x269CFB0", Offset = "0x269BBB0", VA = "0x18269CFB0")]
		public Act1VHalfIdleCharUpgradeRewardViewModel()
		{
		}

		// Token: 0x0403DC4F RID: 253007
		[Token(Token = "0x403DC4F")]
		[FieldOffset(Offset = "0x10")]
		public EvolvePhase evolvePhase;

		// Token: 0x0403DC50 RID: 253008
		[Token(Token = "0x403DC50")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel itemViewModel;

		// Token: 0x0403DC51 RID: 253009
		[Token(Token = "0x403DC51")]
		[FieldOffset(Offset = "0x20")]
		public bool completed;

		// Token: 0x0403DC52 RID: 253010
		[Token(Token = "0x403DC52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
