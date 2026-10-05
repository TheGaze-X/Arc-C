using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005768 RID: 22376
	[Token(Token = "0x2005768")]
	public class RL02EndingFrameNewsReportViewModel : RL02EndingFrameReportViewModel
	{
		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x06020C4A RID: 134218 RVA: 0x000B7288 File Offset: 0x000B5488
		[Token(Token = "0x17004CD4")]
		public override RL02ReportController.ReportViewType viewType
		{
			[Token(Token = "0x6020C4A")]
			[Address(RVA = "0x1B1FC10", Offset = "0x1B1E810", VA = "0x181B1FC10", Slot = "4")]
			get
			{
				return RL02ReportController.ReportViewType.NONE;
			}
		}

		// Token: 0x06020C4B RID: 134219 RVA: 0x000B72A0 File Offset: 0x000B54A0
		[Token(Token = "0x6020C4B")]
		[Address(RVA = "0x1B1F800", Offset = "0x1B1E400", VA = "0x181B1F800", Slot = "5")]
		protected override bool LoadData(string topicId, RL02EndingFrameViewModel dataSource)
		{
			return default(bool);
		}

		// Token: 0x06020C4C RID: 134220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C4C")]
		[Address(RVA = "0x1B1FA80", Offset = "0x1B1E680", VA = "0x181B1FA80")]
		private void _TryAddViewModel(RL02EndingFrameNewsReportViewModel.NewsItemModel itemModel, RL02EndingFrameViewModel.Special newsGroupModel)
		{
		}

		// Token: 0x06020C4D RID: 134221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C4D")]
		[Address(RVA = "0x1B1FB70", Offset = "0x1B1E770", VA = "0x181B1FB70")]
		public RL02EndingFrameNewsReportViewModel()
		{
		}

		// Token: 0x0402C7FB RID: 182267
		[Token(Token = "0x402C7FB")]
		[FieldOffset(Offset = "0x18")]
		public List<RL02EndingFrameNewsReportViewModel.NewsItemModel> items;

		// Token: 0x0402C7FC RID: 182268
		[Token(Token = "0x402C7FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C7FD RID: 182269
		[Token(Token = "0x402C7FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C7FE RID: 182270
		[Token(Token = "0x402C7FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryAddViewModel;

		// Token: 0x0402C7FF RID: 182271
		[Token(Token = "0x402C7FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005769 RID: 22377
		[Token(Token = "0x2005769")]
		public enum NewsType
		{
			// Token: 0x0402C801 RID: 182273
			[Token(Token = "0x402C801")]
			NONE,
			// Token: 0x0402C802 RID: 182274
			[Token(Token = "0x402C802")]
			COMMU,
			// Token: 0x0402C803 RID: 182275
			[Token(Token = "0x402C803")]
			HIDDEN,
			// Token: 0x0402C804 RID: 182276
			[Token(Token = "0x402C804")]
			KNIGHT,
			// Token: 0x0402C805 RID: 182277
			[Token(Token = "0x402C805")]
			PRACTICE,
			// Token: 0x0402C806 RID: 182278
			[Token(Token = "0x402C806")]
			GOLD
		}

		// Token: 0x0200576A RID: 22378
		[Token(Token = "0x200576A")]
		public abstract class NewsItemModel
		{
			// Token: 0x17004CD5 RID: 19669
			// (get) Token: 0x06020C4E RID: 134222
			[Token(Token = "0x17004CD5")]
			public abstract RL02EndingFrameNewsReportViewModel.NewsType type { [Token(Token = "0x6020C4E")] get; }

			// Token: 0x06020C4F RID: 134223
			[Token(Token = "0x6020C4F")]
			public abstract bool LoadData(RL02EndingText endingText, RL02EndingFrameViewModel.Special newsData);

			// Token: 0x06020C50 RID: 134224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C50")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected NewsItemModel()
			{
			}
		}

		// Token: 0x0200576B RID: 22379
		[Token(Token = "0x200576B")]
		public class NewsCommuItemModel : RL02EndingFrameNewsReportViewModel.NewsItemModel
		{
			// Token: 0x17004CD6 RID: 19670
			// (get) Token: 0x06020C51 RID: 134225 RVA: 0x000B72B8 File Offset: 0x000B54B8
			[Token(Token = "0x17004CD6")]
			public override RL02EndingFrameNewsReportViewModel.NewsType type
			{
				[Token(Token = "0x6020C51")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
				get
				{
					return RL02EndingFrameNewsReportViewModel.NewsType.NONE;
				}
			}

			// Token: 0x06020C52 RID: 134226 RVA: 0x000B72D0 File Offset: 0x000B54D0
			[Token(Token = "0x6020C52")]
			[Address(RVA = "0x1B197F0", Offset = "0x1B183F0", VA = "0x181B197F0", Slot = "5")]
			public override bool LoadData(RL02EndingText endingText, RL02EndingFrameViewModel.Special newsData)
			{
				return default(bool);
			}

			// Token: 0x06020C53 RID: 134227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C53")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsCommuItemModel()
			{
			}

			// Token: 0x0402C807 RID: 182279
			[Token(Token = "0x402C807")]
			[FieldOffset(Offset = "0x10")]
			public int goldCount;

			// Token: 0x0402C808 RID: 182280
			[Token(Token = "0x402C808")]
			[FieldOffset(Offset = "0x14")]
			public bool empty;
		}

		// Token: 0x0200576C RID: 22380
		[Token(Token = "0x200576C")]
		public class NewsHiddenItemModel : RL02EndingFrameNewsReportViewModel.NewsItemModel
		{
			// Token: 0x17004CD7 RID: 19671
			// (get) Token: 0x06020C54 RID: 134228 RVA: 0x000B72E8 File Offset: 0x000B54E8
			[Token(Token = "0x17004CD7")]
			public override RL02EndingFrameNewsReportViewModel.NewsType type
			{
				[Token(Token = "0x6020C54")]
				[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
				get
				{
					return RL02EndingFrameNewsReportViewModel.NewsType.NONE;
				}
			}

			// Token: 0x06020C55 RID: 134229 RVA: 0x000B7300 File Offset: 0x000B5500
			[Token(Token = "0x6020C55")]
			[Address(RVA = "0x1B19880", Offset = "0x1B18480", VA = "0x181B19880", Slot = "5")]
			public override bool LoadData(RL02EndingText endingText, RL02EndingFrameViewModel.Special newsData)
			{
				return default(bool);
			}

			// Token: 0x06020C56 RID: 134230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C56")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsHiddenItemModel()
			{
			}

			// Token: 0x0402C809 RID: 182281
			[Token(Token = "0x402C809")]
			[FieldOffset(Offset = "0x10")]
			public int[] count;

			// Token: 0x0402C80A RID: 182282
			[Token(Token = "0x402C80A")]
			[FieldOffset(Offset = "0x18")]
			public bool passed;
		}

		// Token: 0x0200576D RID: 22381
		[Token(Token = "0x200576D")]
		public class NewsKnightItemModel : RL02EndingFrameNewsReportViewModel.NewsItemModel
		{
			// Token: 0x17004CD8 RID: 19672
			// (get) Token: 0x06020C57 RID: 134231 RVA: 0x000B7318 File Offset: 0x000B5518
			[Token(Token = "0x17004CD8")]
			public override RL02EndingFrameNewsReportViewModel.NewsType type
			{
				[Token(Token = "0x6020C57")]
				[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
				get
				{
					return RL02EndingFrameNewsReportViewModel.NewsType.NONE;
				}
			}

			// Token: 0x06020C58 RID: 134232 RVA: 0x000B7330 File Offset: 0x000B5530
			[Token(Token = "0x6020C58")]
			[Address(RVA = "0x1B1A020", Offset = "0x1B18C20", VA = "0x181B1A020", Slot = "5")]
			public override bool LoadData(RL02EndingText endingText, RL02EndingFrameViewModel.Special newsData)
			{
				return default(bool);
			}

			// Token: 0x06020C59 RID: 134233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C59")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsKnightItemModel()
			{
			}

			// Token: 0x0402C80B RID: 182283
			[Token(Token = "0x402C80B")]
			[FieldOffset(Offset = "0x10")]
			public int battleCount;

			// Token: 0x0402C80C RID: 182284
			[Token(Token = "0x402C80C")]
			[FieldOffset(Offset = "0x14")]
			public bool passed;
		}

		// Token: 0x0200576E RID: 22382
		[Token(Token = "0x200576E")]
		public class NewsPracticeItemModel : RL02EndingFrameNewsReportViewModel.NewsItemModel
		{
			// Token: 0x17004CD9 RID: 19673
			// (get) Token: 0x06020C5A RID: 134234 RVA: 0x000B7348 File Offset: 0x000B5548
			[Token(Token = "0x17004CD9")]
			public override RL02EndingFrameNewsReportViewModel.NewsType type
			{
				[Token(Token = "0x6020C5A")]
				[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "4")]
				get
				{
					return RL02EndingFrameNewsReportViewModel.NewsType.NONE;
				}
			}

			// Token: 0x06020C5B RID: 134235 RVA: 0x000B7360 File Offset: 0x000B5560
			[Token(Token = "0x6020C5B")]
			[Address(RVA = "0x1B1A060", Offset = "0x1B18C60", VA = "0x181B1A060", Slot = "5")]
			public override bool LoadData(RL02EndingText endingText, RL02EndingFrameViewModel.Special newsData)
			{
				return default(bool);
			}

			// Token: 0x06020C5C RID: 134236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C5C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsPracticeItemModel()
			{
			}

			// Token: 0x0402C80D RID: 182285
			[Token(Token = "0x402C80D")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			// Token: 0x0402C80E RID: 182286
			[Token(Token = "0x402C80E")]
			[FieldOffset(Offset = "0x14")]
			public bool heavyCost;
		}

		// Token: 0x0200576F RID: 22383
		[Token(Token = "0x200576F")]
		public class NewsGoldItemModel : RL02EndingFrameNewsReportViewModel.NewsItemModel
		{
			// Token: 0x17004CDA RID: 19674
			// (get) Token: 0x06020C5D RID: 134237 RVA: 0x000B7378 File Offset: 0x000B5578
			[Token(Token = "0x17004CDA")]
			public override RL02EndingFrameNewsReportViewModel.NewsType type
			{
				[Token(Token = "0x6020C5D")]
				[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "4")]
				get
				{
					return RL02EndingFrameNewsReportViewModel.NewsType.NONE;
				}
			}

			// Token: 0x06020C5E RID: 134238 RVA: 0x000B7390 File Offset: 0x000B5590
			[Token(Token = "0x6020C5E")]
			[Address(RVA = "0x1B19830", Offset = "0x1B18430", VA = "0x181B19830", Slot = "5")]
			public override bool LoadData(RL02EndingText endingText, RL02EndingFrameViewModel.Special newsData)
			{
				return default(bool);
			}

			// Token: 0x06020C5F RID: 134239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C5F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsGoldItemModel()
			{
			}

			// Token: 0x0402C80F RID: 182287
			[Token(Token = "0x402C80F")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			// Token: 0x0402C810 RID: 182288
			[Token(Token = "0x402C810")]
			[FieldOffset(Offset = "0x14")]
			public bool heavyCost;
		}
	}
}
