using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073B1 RID: 29617
	[Token(Token = "0x20073B1")]
	public class Act42D0RewardStageItemViewModel : IComparable<Act42D0RewardStageItemViewModel>, IHotfixable
	{
		// Token: 0x06029DAF RID: 171439 RVA: 0x000D6CB0 File Offset: 0x000D4EB0
		[Token(Token = "0x6029DAF")]
		[Address(RVA = "0x2573C00", Offset = "0x2572800", VA = "0x182573C00", Slot = "4")]
		public int CompareTo(Act42D0RewardStageItemViewModel other)
		{
			return 0;
		}

		// Token: 0x06029DB0 RID: 171440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DB0")]
		[Address(RVA = "0x2573C80", Offset = "0x2572880", VA = "0x182573C80")]
		public Act42D0RewardStageItemViewModel()
		{
		}

		// Token: 0x0403BFB6 RID: 245686
		[Token(Token = "0x403BFB6")]
		[FieldOffset(Offset = "0x10")]
		public bool isGained;

		// Token: 0x0403BFB7 RID: 245687
		[Token(Token = "0x403BFB7")]
		[FieldOffset(Offset = "0x14")]
		public int milestoneCount;

		// Token: 0x0403BFB8 RID: 245688
		[Token(Token = "0x403BFB8")]
		[FieldOffset(Offset = "0x18")]
		public int ratingLevel;

		// Token: 0x0403BFB9 RID: 245689
		[Token(Token = "0x403BFB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403BFBA RID: 245690
		[Token(Token = "0x403BFBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
