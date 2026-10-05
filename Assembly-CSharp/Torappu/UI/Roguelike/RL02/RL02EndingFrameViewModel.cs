using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005771 RID: 22385
	[Token(Token = "0x2005771")]
	public class RL02EndingFrameViewModel : RoguelikeEndingFrameViewModel
	{
		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x06020C63 RID: 134243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CDC")]
		public List<RL02ReportController.ReportViewType> displayViewTypes
		{
			[Token(Token = "0x6020C63")]
			[Address(RVA = "0x1B21200", Offset = "0x1B1FE00", VA = "0x181B21200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020C64 RID: 134244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C64")]
		[Address(RVA = "0x1B20920", Offset = "0x1B1F520", VA = "0x181B20920")]
		public void ProcessViewModel()
		{
		}

		// Token: 0x06020C65 RID: 134245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C65")]
		[Address(RVA = "0x1B20FE0", Offset = "0x1B1FBE0", VA = "0x181B20FE0")]
		private void _TryAddViewModel(RL02EndingFrameReportViewModel viewModel)
		{
		}

		// Token: 0x06020C66 RID: 134246 RVA: 0x000B73D8 File Offset: 0x000B55D8
		[Token(Token = "0x6020C66")]
		[Address(RVA = "0x1B20EB0", Offset = "0x1B1FAB0", VA = "0x181B20EB0")]
		private int _GetViewTypeIndex(RL02ReportController.ReportViewType viewType)
		{
			return 0;
		}

		// Token: 0x06020C67 RID: 134247 RVA: 0x000B73F0 File Offset: 0x000B55F0
		[Token(Token = "0x6020C67")]
		[Address(RVA = "0x1B20840", Offset = "0x1B1F440", VA = "0x181B20840")]
		public RL02ReportController.ReportViewType GetPrevViewType(RL02ReportController.ReportViewType viewType)
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C68 RID: 134248 RVA: 0x000B7408 File Offset: 0x000B5608
		[Token(Token = "0x6020C68")]
		[Address(RVA = "0x1B20750", Offset = "0x1B1F350", VA = "0x181B20750")]
		public RL02ReportController.ReportViewType GetNextViewType(RL02ReportController.ReportViewType viewType)
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C69 RID: 134249 RVA: 0x000B7420 File Offset: 0x000B5620
		[Token(Token = "0x6020C69")]
		[Address(RVA = "0x1B20680", Offset = "0x1B1F280", VA = "0x181B20680")]
		public RL02ReportController.ReportViewType GetLastViewType()
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C6A RID: 134250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C6A")]
		[Address(RVA = "0x1B205D0", Offset = "0x1B1F1D0", VA = "0x181B205D0")]
		public RL02EndingFrameReportViewModel GetCurrReportViewModel(RL02ReportController.ReportViewType viewType)
		{
			return null;
		}

		// Token: 0x06020C6B RID: 134251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C6B")]
		[Address(RVA = "0x1B21150", Offset = "0x1B1FD50", VA = "0x181B21150")]
		public RL02EndingFrameViewModel()
		{
		}

		// Token: 0x0402C814 RID: 182292
		[Token(Token = "0x402C814")]
		[FieldOffset(Offset = "0x28")]
		public RL02EndingFrameViewModel.Brief brief;

		// Token: 0x0402C815 RID: 182293
		[Token(Token = "0x402C815")]
		[FieldOffset(Offset = "0x30")]
		public List<RL02EndingFrameViewModel.Troop> troopChars;

		// Token: 0x0402C816 RID: 182294
		[Token(Token = "0x402C816")]
		[FieldOffset(Offset = "0x38")]
		public RL02EndingFrameViewModel.San san;

		// Token: 0x0402C817 RID: 182295
		[Token(Token = "0x402C817")]
		[FieldOffset(Offset = "0x40")]
		public List<string> virtue;

		// Token: 0x0402C818 RID: 182296
		[Token(Token = "0x402C818")]
		[FieldOffset(Offset = "0x48")]
		public RL02EndingFrameViewModel.Mutation mutation;

		// Token: 0x0402C819 RID: 182297
		[Token(Token = "0x402C819")]
		[FieldOffset(Offset = "0x50")]
		public List<RL02EndingFrameViewModel.Dice> dice;

		// Token: 0x0402C81A RID: 182298
		[Token(Token = "0x402C81A")]
		[FieldOffset(Offset = "0x58")]
		public RL02EndingFrameViewModel.Special special;

		// Token: 0x0402C81B RID: 182299
		[Token(Token = "0x402C81B")]
		[FieldOffset(Offset = "0x60")]
		private List<RL02EndingFrameReportViewModel> m_viewModelList;

		// Token: 0x0402C81C RID: 182300
		[Token(Token = "0x402C81C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayViewTypes;

		// Token: 0x0402C81D RID: 182301
		[Token(Token = "0x402C81D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ProcessViewModel;

		// Token: 0x0402C81E RID: 182302
		[Token(Token = "0x402C81E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryAddViewModel;

		// Token: 0x0402C81F RID: 182303
		[Token(Token = "0x402C81F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetViewTypeIndex;

		// Token: 0x0402C820 RID: 182304
		[Token(Token = "0x402C820")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPrevViewType;

		// Token: 0x0402C821 RID: 182305
		[Token(Token = "0x402C821")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetNextViewType;

		// Token: 0x0402C822 RID: 182306
		[Token(Token = "0x402C822")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetLastViewType;

		// Token: 0x0402C823 RID: 182307
		[Token(Token = "0x402C823")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCurrReportViewModel;

		// Token: 0x0402C824 RID: 182308
		[Token(Token = "0x402C824")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005772 RID: 22386
		[Token(Token = "0x2005772")]
		public class EndProperty
		{
			// Token: 0x06020C6C RID: 134252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C6C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EndProperty()
			{
			}

			// Token: 0x0402C825 RID: 182309
			[Token(Token = "0x402C825")]
			[FieldOffset(Offset = "0x10")]
			public int hp;

			// Token: 0x0402C826 RID: 182310
			[Token(Token = "0x402C826")]
			[FieldOffset(Offset = "0x14")]
			public int hpMax;

			// Token: 0x0402C827 RID: 182311
			[Token(Token = "0x402C827")]
			[FieldOffset(Offset = "0x18")]
			public int gold;

			// Token: 0x0402C828 RID: 182312
			[Token(Token = "0x402C828")]
			[FieldOffset(Offset = "0x1C")]
			public int populationCost;

			// Token: 0x0402C829 RID: 182313
			[Token(Token = "0x402C829")]
			[FieldOffset(Offset = "0x20")]
			public int populationMax;
		}

		// Token: 0x02005773 RID: 22387
		[Token(Token = "0x2005773")]
		public class Brief
		{
			// Token: 0x06020C6D RID: 134253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C6D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Brief()
			{
			}

			// Token: 0x0402C82A RID: 182314
			[Token(Token = "0x402C82A")]
			[FieldOffset(Offset = "0x10")]
			public bool over;

			// Token: 0x0402C82B RID: 182315
			[Token(Token = "0x402C82B")]
			[FieldOffset(Offset = "0x14")]
			public int success;

			// Token: 0x0402C82C RID: 182316
			[Token(Token = "0x402C82C")]
			[FieldOffset(Offset = "0x18")]
			public string ending;

			// Token: 0x0402C82D RID: 182317
			[Token(Token = "0x402C82D")]
			[FieldOffset(Offset = "0x20")]
			public string theme;

			// Token: 0x0402C82E RID: 182318
			[Token(Token = "0x402C82E")]
			[FieldOffset(Offset = "0x28")]
			public RoguelikeTopicMode mode;

			// Token: 0x0402C82F RID: 182319
			[Token(Token = "0x402C82F")]
			[FieldOffset(Offset = "0x30")]
			public string predefined;

			// Token: 0x0402C830 RID: 182320
			[Token(Token = "0x402C830")]
			[FieldOffset(Offset = "0x38")]
			public string band;

			// Token: 0x0402C831 RID: 182321
			[Token(Token = "0x402C831")]
			[FieldOffset(Offset = "0x40")]
			public int level;

			// Token: 0x0402C832 RID: 182322
			[Token(Token = "0x402C832")]
			[FieldOffset(Offset = "0x48")]
			public long startTs;

			// Token: 0x0402C833 RID: 182323
			[Token(Token = "0x402C833")]
			[FieldOffset(Offset = "0x50")]
			public long endTs;

			// Token: 0x0402C834 RID: 182324
			[Token(Token = "0x402C834")]
			[FieldOffset(Offset = "0x58")]
			public string endZoneId;

			// Token: 0x0402C835 RID: 182325
			[Token(Token = "0x402C835")]
			[FieldOffset(Offset = "0x60")]
			public RL02EndingFrameViewModel.EndProperty endProperty;
		}

		// Token: 0x02005774 RID: 22388
		[Token(Token = "0x2005774")]
		public class Troop
		{
			// Token: 0x06020C6E RID: 134254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C6E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Troop()
			{
			}

			// Token: 0x0402C836 RID: 182326
			[Token(Token = "0x402C836")]
			[FieldOffset(Offset = "0x10")]
			public string instId;

			// Token: 0x0402C837 RID: 182327
			[Token(Token = "0x402C837")]
			[FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x0402C838 RID: 182328
			[Token(Token = "0x402C838")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeCharState type;

			// Token: 0x0402C839 RID: 182329
			[Token(Token = "0x402C839")]
			[FieldOffset(Offset = "0x24")]
			public bool isUpgrade;

			// Token: 0x0402C83A RID: 182330
			[Token(Token = "0x402C83A")]
			[FieldOffset(Offset = "0x28")]
			public int evolvePhase;

			// Token: 0x0402C83B RID: 182331
			[Token(Token = "0x402C83B")]
			[FieldOffset(Offset = "0x2C")]
			public int level;
		}

		// Token: 0x02005775 RID: 22389
		[Token(Token = "0x2005775")]
		public class Zone
		{
			// Token: 0x06020C6F RID: 134255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C6F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Zone()
			{
			}

			// Token: 0x0402C83C RID: 182332
			[Token(Token = "0x402C83C")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x0402C83D RID: 182333
			[Token(Token = "0x402C83D")]
			[FieldOffset(Offset = "0x18")]
			public int san;
		}

		// Token: 0x02005776 RID: 22390
		[Token(Token = "0x2005776")]
		public class San
		{
			// Token: 0x06020C70 RID: 134256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C70")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public San()
			{
			}

			// Token: 0x0402C83E RID: 182334
			[Token(Token = "0x402C83E")]
			[FieldOffset(Offset = "0x10")]
			public int end;

			// Token: 0x0402C83F RID: 182335
			[Token(Token = "0x402C83F")]
			[FieldOffset(Offset = "0x18")]
			public List<RL02EndingFrameViewModel.Zone> zone;
		}

		// Token: 0x02005777 RID: 22391
		[Token(Token = "0x2005777")]
		public class Mutation
		{
			// Token: 0x06020C71 RID: 134257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C71")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Mutation()
			{
			}

			// Token: 0x0402C840 RID: 182336
			[Token(Token = "0x402C840")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0402C841 RID: 182337
			[Token(Token = "0x402C841")]
			[FieldOffset(Offset = "0x18")]
			public List<string> chars;
		}

		// Token: 0x02005778 RID: 22392
		[Token(Token = "0x2005778")]
		public class Dice
		{
			// Token: 0x06020C72 RID: 134258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C72")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Dice()
			{
			}

			// Token: 0x0402C842 RID: 182338
			[Token(Token = "0x402C842")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0402C843 RID: 182339
			[Token(Token = "0x402C843")]
			[FieldOffset(Offset = "0x18")]
			public int result;
		}

		// Token: 0x02005779 RID: 22393
		[Token(Token = "0x2005779")]
		public class NewsCommu
		{
			// Token: 0x06020C73 RID: 134259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C73")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsCommu()
			{
			}

			// Token: 0x0402C844 RID: 182340
			[Token(Token = "0x402C844")]
			[FieldOffset(Offset = "0x10")]
			public int gold;

			// Token: 0x0402C845 RID: 182341
			[Token(Token = "0x402C845")]
			[FieldOffset(Offset = "0x14")]
			public bool empty;
		}

		// Token: 0x0200577A RID: 22394
		[Token(Token = "0x200577A")]
		public class NewsGold
		{
			// Token: 0x06020C74 RID: 134260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C74")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsGold()
			{
			}

			// Token: 0x0402C846 RID: 182342
			[Token(Token = "0x402C846")]
			[FieldOffset(Offset = "0x10")]
			public int count;
		}

		// Token: 0x0200577B RID: 22395
		[Token(Token = "0x200577B")]
		public class NewsPractice
		{
			// Token: 0x06020C75 RID: 134261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C75")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsPractice()
			{
			}

			// Token: 0x0402C847 RID: 182343
			[Token(Token = "0x402C847")]
			[FieldOffset(Offset = "0x10")]
			public int count;
		}

		// Token: 0x0200577C RID: 22396
		[Token(Token = "0x200577C")]
		public class NewsKnight
		{
			// Token: 0x06020C76 RID: 134262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C76")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsKnight()
			{
			}

			// Token: 0x0402C848 RID: 182344
			[Token(Token = "0x402C848")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			// Token: 0x0402C849 RID: 182345
			[Token(Token = "0x402C849")]
			[FieldOffset(Offset = "0x14")]
			public bool pass;
		}

		// Token: 0x0200577D RID: 22397
		[Token(Token = "0x200577D")]
		public class NewsHidden
		{
			// Token: 0x06020C77 RID: 134263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C77")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NewsHidden()
			{
			}

			// Token: 0x0402C84A RID: 182346
			[Token(Token = "0x402C84A")]
			[FieldOffset(Offset = "0x10")]
			public int battle;

			// Token: 0x0402C84B RID: 182347
			[Token(Token = "0x402C84B")]
			[FieldOffset(Offset = "0x14")]
			public int elite;

			// Token: 0x0402C84C RID: 182348
			[Token(Token = "0x402C84C")]
			[FieldOffset(Offset = "0x18")]
			public int boss;

			// Token: 0x0402C84D RID: 182349
			[Token(Token = "0x402C84D")]
			[FieldOffset(Offset = "0x1C")]
			public int wish;

			// Token: 0x0402C84E RID: 182350
			[Token(Token = "0x402C84E")]
			[FieldOffset(Offset = "0x20")]
			public bool pass;
		}

		// Token: 0x0200577E RID: 22398
		[Token(Token = "0x200577E")]
		public class Special
		{
			// Token: 0x06020C78 RID: 134264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C78")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Special()
			{
			}

			// Token: 0x0402C84F RID: 182351
			[Token(Token = "0x402C84F")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "rob")]
			public RL02EndingFrameViewModel.NewsCommu commu;

			// Token: 0x0402C850 RID: 182352
			[Token(Token = "0x402C850")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "draw")]
			public RL02EndingFrameViewModel.NewsGold gold;

			// Token: 0x0402C851 RID: 182353
			[Token(Token = "0x402C851")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty(PropertyName = "row")]
			public RL02EndingFrameViewModel.NewsPractice practice;

			// Token: 0x0402C852 RID: 182354
			[Token(Token = "0x402C852")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty(PropertyName = "knight")]
			public RL02EndingFrameViewModel.NewsKnight knight;

			// Token: 0x0402C853 RID: 182355
			[Token(Token = "0x402C853")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty(PropertyName = "teleport")]
			public RL02EndingFrameViewModel.NewsHidden hidden;
		}
	}
}
