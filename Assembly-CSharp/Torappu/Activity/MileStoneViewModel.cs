using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D3E RID: 27966
	[Token(Token = "0x2006D3E")]
	public class MileStoneViewModel : IComparable<MileStoneViewModel>, IHotfixable
	{
		// Token: 0x06027DCE RID: 163278 RVA: 0x000CFB70 File Offset: 0x000CDD70
		[Token(Token = "0x6027DCE")]
		[Address(RVA = "0x22F8E50", Offset = "0x22F7A50", VA = "0x1822F8E50", Slot = "4")]
		public int CompareTo(MileStoneViewModel other)
		{
			return 0;
		}

		// Token: 0x06027DCF RID: 163279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DCF")]
		[Address(RVA = "0x22F8ED0", Offset = "0x22F7AD0", VA = "0x1822F8ED0")]
		public MileStoneViewModel()
		{
		}

		// Token: 0x04038823 RID: 231459
		[Token(Token = "0x4038823")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04038824 RID: 231460
		[Token(Token = "0x4038824")]
		[FieldOffset(Offset = "0x18")]
		public int orderId;

		// Token: 0x04038825 RID: 231461
		[Token(Token = "0x4038825")]
		[FieldOffset(Offset = "0x1C")]
		public MileStoneViewModel.PartType type;

		// Token: 0x04038826 RID: 231462
		[Token(Token = "0x4038826")]
		[FieldOffset(Offset = "0x20")]
		public MileStoneViewModel.State state;

		// Token: 0x04038827 RID: 231463
		[Token(Token = "0x4038827")]
		[FieldOffset(Offset = "0x24")]
		public int count;

		// Token: 0x04038828 RID: 231464
		[Token(Token = "0x4038828")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle rewardItem;

		// Token: 0x04038829 RID: 231465
		[Token(Token = "0x4038829")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403882A RID: 231466
		[Token(Token = "0x403882A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D3F RID: 27967
		[Token(Token = "0x2006D3F")]
		public enum State
		{
			// Token: 0x0403882C RID: 231468
			[Token(Token = "0x403882C")]
			FINISH,
			// Token: 0x0403882D RID: 231469
			[Token(Token = "0x403882D")]
			AVAIL,
			// Token: 0x0403882E RID: 231470
			[Token(Token = "0x403882E")]
			NOTAVAIL
		}

		// Token: 0x02006D40 RID: 27968
		[Token(Token = "0x2006D40")]
		public enum PartType
		{
			// Token: 0x04038830 RID: 231472
			[Token(Token = "0x4038830")]
			PART1,
			// Token: 0x04038831 RID: 231473
			[Token(Token = "0x4038831")]
			PART2,
			// Token: 0x04038832 RID: 231474
			[Token(Token = "0x4038832")]
			GAP
		}
	}
}
