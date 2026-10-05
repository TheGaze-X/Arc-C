using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007139 RID: 28985
	[Token(Token = "0x2007139")]
	public class ActAutoChessSingleRoundRewardModel : IHotfixable, IComparable
	{
		// Token: 0x06029269 RID: 168553 RVA: 0x000D49D0 File Offset: 0x000D2BD0
		[Token(Token = "0x6029269")]
		[Address(RVA = "0x248E040", Offset = "0x248CC40", VA = "0x18248E040", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0602926A RID: 168554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602926A")]
		[Address(RVA = "0x248E110", Offset = "0x248CD10", VA = "0x18248E110")]
		public ActAutoChessSingleRoundRewardModel()
		{
		}

		// Token: 0x0403AC5D RID: 240733
		[Token(Token = "0x403AC5D")]
		[FieldOffset(Offset = "0x10")]
		public int round;

		// Token: 0x0403AC5E RID: 240734
		[Token(Token = "0x403AC5E")]
		[FieldOffset(Offset = "0x14")]
		public int reward;

		// Token: 0x0403AC5F RID: 240735
		[Token(Token = "0x403AC5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403AC60 RID: 240736
		[Token(Token = "0x403AC60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
