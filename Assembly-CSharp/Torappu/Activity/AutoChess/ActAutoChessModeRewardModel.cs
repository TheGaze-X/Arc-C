using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200713A RID: 28986
	[Token(Token = "0x200713A")]
	public class ActAutoChessModeRewardModel : IHotfixable, IComparable
	{
		// Token: 0x0602926B RID: 168555 RVA: 0x000D49E8 File Offset: 0x000D2BE8
		[Token(Token = "0x602926B")]
		[Address(RVA = "0x248BD90", Offset = "0x248A990", VA = "0x18248BD90", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0602926C RID: 168556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602926C")]
		[Address(RVA = "0x248BED0", Offset = "0x248AAD0", VA = "0x18248BED0")]
		public ActAutoChessModeRewardModel()
		{
		}

		// Token: 0x0403AC61 RID: 240737
		[Token(Token = "0x403AC61")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessModeType type;

		// Token: 0x0403AC62 RID: 240738
		[Token(Token = "0x403AC62")]
		[FieldOffset(Offset = "0x14")]
		public float factor;

		// Token: 0x0403AC63 RID: 240739
		[Token(Token = "0x403AC63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403AC64 RID: 240740
		[Token(Token = "0x403AC64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
