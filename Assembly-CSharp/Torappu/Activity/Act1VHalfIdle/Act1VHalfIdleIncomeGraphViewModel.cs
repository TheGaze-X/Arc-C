using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077B8 RID: 30648
	[Token(Token = "0x20077B8")]
	public class Act1VHalfIdleIncomeGraphViewModel : IHotfixable
	{
		// Token: 0x0602B05F RID: 176223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B05F")]
		[Address(RVA = "0x26D2790", Offset = "0x26D1390", VA = "0x1826D2790")]
		public void LoadStageData(string actId, string stageId)
		{
		}

		// Token: 0x0602B060 RID: 176224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B060")]
		[Address(RVA = "0x26D2260", Offset = "0x26D0E60", VA = "0x1826D2260")]
		public void LoadSettleData(string actId, string stageId)
		{
		}

		// Token: 0x0602B061 RID: 176225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B061")]
		[Address(RVA = "0x26D1DF0", Offset = "0x26D09F0", VA = "0x1826D1DF0")]
		public void LoadHarvestData(string actId)
		{
		}

		// Token: 0x0602B062 RID: 176226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B062")]
		[Address(RVA = "0x26D2C40", Offset = "0x26D1840", VA = "0x1826D2C40")]
		public Act1VHalfIdleIncomeGraphViewModel()
		{
		}

		// Token: 0x0403E1E3 RID: 254435
		[Token(Token = "0x403E1E3")]
		[FieldOffset(Offset = "0x10")]
		public bool showFrameDeco;

		// Token: 0x0403E1E4 RID: 254436
		[Token(Token = "0x403E1E4")]
		[FieldOffset(Offset = "0x11")]
		public bool showReplaceOption;

		// Token: 0x0403E1E5 RID: 254437
		[Token(Token = "0x403E1E5")]
		[FieldOffset(Offset = "0x14")]
		public Act1VHalfIdleIncomeGraphViewModel.GraphStyle graphStyle;

		// Token: 0x0403E1E6 RID: 254438
		[Token(Token = "0x403E1E6")]
		[FieldOffset(Offset = "0x18")]
		public int graphMaxValue;

		// Token: 0x0403E1E7 RID: 254439
		[Token(Token = "0x403E1E7")]
		[FieldOffset(Offset = "0x20")]
		public List<Act1VHalfIdleIncomeGraphItemViewModel> itemViewModels;

		// Token: 0x0403E1E8 RID: 254440
		[Token(Token = "0x403E1E8")]
		[FieldOffset(Offset = "0x28")]
		public int compareAnimSeqNum;

		// Token: 0x0403E1E9 RID: 254441
		[Token(Token = "0x403E1E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadStageData;

		// Token: 0x0403E1EA RID: 254442
		[Token(Token = "0x403E1EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadSettleData;

		// Token: 0x0403E1EB RID: 254443
		[Token(Token = "0x403E1EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadHarvestData;

		// Token: 0x0403E1EC RID: 254444
		[Token(Token = "0x403E1EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077B9 RID: 30649
		[Token(Token = "0x20077B9")]
		public enum GraphStyle
		{
			// Token: 0x0403E1EE RID: 254446
			[Token(Token = "0x403E1EE")]
			INCOME_ONLY,
			// Token: 0x0403E1EF RID: 254447
			[Token(Token = "0x403E1EF")]
			COMPARE
		}
	}
}
