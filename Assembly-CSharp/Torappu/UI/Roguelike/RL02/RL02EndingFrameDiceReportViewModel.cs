using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005765 RID: 22373
	[Token(Token = "0x2005765")]
	public class RL02EndingFrameDiceReportViewModel : RL02EndingFrameReportViewModel
	{
		// Token: 0x17004CD2 RID: 19666
		// (get) Token: 0x06020C43 RID: 134211 RVA: 0x000B71F8 File Offset: 0x000B53F8
		[Token(Token = "0x17004CD2")]
		public override RL02ReportController.ReportViewType viewType
		{
			[Token(Token = "0x6020C43")]
			[Address(RVA = "0x1B1E920", Offset = "0x1B1D520", VA = "0x181B1E920", Slot = "4")]
			get
			{
				return RL02ReportController.ReportViewType.NONE;
			}
		}

		// Token: 0x06020C44 RID: 134212 RVA: 0x000B7210 File Offset: 0x000B5410
		[Token(Token = "0x6020C44")]
		[Address(RVA = "0x1B1DFE0", Offset = "0x1B1CBE0", VA = "0x181B1DFE0", Slot = "5")]
		protected override bool LoadData(string topicId, RL02EndingFrameViewModel dataSource)
		{
			return default(bool);
		}

		// Token: 0x06020C45 RID: 134213 RVA: 0x000B7228 File Offset: 0x000B5428
		[Token(Token = "0x6020C45")]
		[Address(RVA = "0x1B1E6E0", Offset = "0x1B1D2E0", VA = "0x181B1E6E0")]
		private int _Compare(RL02EndingFrameDiceReportViewModel.DiceResultInfo lhs, RL02EndingFrameDiceReportViewModel.DiceResultInfo rhs)
		{
			return 0;
		}

		// Token: 0x06020C46 RID: 134214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C46")]
		[Address(RVA = "0x1B1E850", Offset = "0x1B1D450", VA = "0x181B1E850")]
		public RL02EndingFrameDiceReportViewModel()
		{
		}

		// Token: 0x0402C7E8 RID: 182248
		[Token(Token = "0x402C7E8")]
		[FieldOffset(Offset = "0x18")]
		public int[] diceRollTimes;

		// Token: 0x0402C7E9 RID: 182249
		[Token(Token = "0x402C7E9")]
		[FieldOffset(Offset = "0x20")]
		public int diceRollTotalTimes;

		// Token: 0x0402C7EA RID: 182250
		[Token(Token = "0x402C7EA")]
		[FieldOffset(Offset = "0x28")]
		public RL02EndingFrameDiceReportViewModel.DiceResultInfo bestDiceResultInfo;

		// Token: 0x0402C7EB RID: 182251
		[Token(Token = "0x402C7EB")]
		[FieldOffset(Offset = "0x50")]
		public RL02EndingFrameDiceReportViewModel.DiceResultInfo worstDiceResultInfo;

		// Token: 0x0402C7EC RID: 182252
		[Token(Token = "0x402C7EC")]
		[FieldOffset(Offset = "0x78")]
		public RL02EndingFrameDiceReportViewModel.DiceResultType diceResultType;

		// Token: 0x0402C7ED RID: 182253
		[Token(Token = "0x402C7ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C7EE RID: 182254
		[Token(Token = "0x402C7EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C7EF RID: 182255
		[Token(Token = "0x402C7EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Compare;

		// Token: 0x0402C7F0 RID: 182256
		[Token(Token = "0x402C7F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005766 RID: 22374
		[Token(Token = "0x2005766")]
		public struct DiceResultInfo
		{
			// Token: 0x17004CD3 RID: 19667
			// (get) Token: 0x06020C49 RID: 134217 RVA: 0x000B7270 File Offset: 0x000B5470
			[Token(Token = "0x17004CD3")]
			public bool isValid
			{
				[Token(Token = "0x6020C49")]
				[Address(RVA = "0x1B18570", Offset = "0x1B17170", VA = "0x181B18570")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0402C7F1 RID: 182257
			[Token(Token = "0x402C7F1")]
			[FieldOffset(Offset = "0x0")]
			public string resultEventId;

			// Token: 0x0402C7F2 RID: 182258
			[Token(Token = "0x402C7F2")]
			[FieldOffset(Offset = "0x8")]
			public int resultNum;

			// Token: 0x0402C7F3 RID: 182259
			[Token(Token = "0x402C7F3")]
			[FieldOffset(Offset = "0xC")]
			public int index;

			// Token: 0x0402C7F4 RID: 182260
			[Token(Token = "0x402C7F4")]
			[FieldOffset(Offset = "0x10")]
			public DiceResultClass resultClass;

			// Token: 0x0402C7F5 RID: 182261
			[Token(Token = "0x402C7F5")]
			[FieldOffset(Offset = "0x18")]
			public string resultSceneName;

			// Token: 0x0402C7F6 RID: 182262
			[Token(Token = "0x402C7F6")]
			[FieldOffset(Offset = "0x20")]
			public string resultDesc;
		}

		// Token: 0x02005767 RID: 22375
		[Token(Token = "0x2005767")]
		public enum DiceResultType
		{
			// Token: 0x0402C7F8 RID: 182264
			[Token(Token = "0x402C7F8")]
			GOOD,
			// Token: 0x0402C7F9 RID: 182265
			[Token(Token = "0x402C7F9")]
			NORMAL,
			// Token: 0x0402C7FA RID: 182266
			[Token(Token = "0x402C7FA")]
			BAD
		}
	}
}
