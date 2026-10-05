using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007956 RID: 31062
	[Token(Token = "0x2007956")]
	public class Act1ArcadeMilestoneGroupViewModel : TemplateActivityMilestoneGroupViewModel
	{
		// Token: 0x1700662F RID: 26159
		// (get) Token: 0x0602B950 RID: 178512 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B951 RID: 178513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700662F")]
		public string avatarLvFormat
		{
			[Token(Token = "0x602B950")]
			[Address(RVA = "0x277DE40", Offset = "0x277CA40", VA = "0x18277DE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B951")]
			[Address(RVA = "0x277DF00", Offset = "0x277CB00", VA = "0x18277DF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006630 RID: 26160
		// (get) Token: 0x0602B952 RID: 178514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B953 RID: 178515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006630")]
		public string themeLvFormat
		{
			[Token(Token = "0x602B952")]
			[Address(RVA = "0x277DEA0", Offset = "0x277CAA0", VA = "0x18277DEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B953")]
			[Address(RVA = "0x277DF80", Offset = "0x277CB80", VA = "0x18277DF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B954 RID: 178516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B954")]
		[Address(RVA = "0x277DC20", Offset = "0x277C820", VA = "0x18277DC20")]
		public Act1ArcadeMilestoneGroupViewModel(object param)
		{
		}

		// Token: 0x0403F0A1 RID: 258209
		[Token(Token = "0x403F0A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avatarLvFormat;

		// Token: 0x0403F0A2 RID: 258210
		[Token(Token = "0x403F0A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_avatarLvFormat;

		// Token: 0x0403F0A3 RID: 258211
		[Token(Token = "0x403F0A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_themeLvFormat;

		// Token: 0x0403F0A4 RID: 258212
		[Token(Token = "0x403F0A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_themeLvFormat;

		// Token: 0x0403F0A5 RID: 258213
		[Token(Token = "0x403F0A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007957 RID: 31063
		[Token(Token = "0x2007957")]
		public class Plugin : ITemplateActivityMilestonePlugin
		{
			// Token: 0x0602B955 RID: 178517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B955")]
			[Address(RVA = "0x2791CB0", Offset = "0x27908B0", VA = "0x182791CB0", Slot = "4")]
			public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x0602B956 RID: 178518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B956")]
			[Address(RVA = "0x2791F80", Offset = "0x2790B80", VA = "0x182791F80", Slot = "5")]
			public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x0602B957 RID: 178519 RVA: 0x000DC7D0 File Offset: 0x000DA9D0
			[Token(Token = "0x602B957")]
			[Address(RVA = "0x2301B80", Offset = "0x2300780", VA = "0x182301B80", Slot = "6")]
			public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
			{
				return 0;
			}

			// Token: 0x0602B958 RID: 178520 RVA: 0x000DC7E8 File Offset: 0x000DA9E8
			[Token(Token = "0x602B958")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
			{
				return default(bool);
			}

			// Token: 0x0602B959 RID: 178521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B959")]
			[Address(RVA = "0x2791C40", Offset = "0x2790840", VA = "0x182791C40", Slot = "8")]
			public string GetMilestoneId(string actId)
			{
				return null;
			}

			// Token: 0x0602B95A RID: 178522 RVA: 0x000DC800 File Offset: 0x000DAA00
			[Token(Token = "0x602B95A")]
			[Address(RVA = "0x2791F50", Offset = "0x2790B50", VA = "0x182791F50", Slot = "9")]
			public int UpdateMilestoneCount(string actId)
			{
				return 0;
			}

			// Token: 0x0602B95B RID: 178523 RVA: 0x000DC818 File Offset: 0x000DAA18
			[Token(Token = "0x602B95B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			public bool NeedFocusToIdx()
			{
				return default(bool);
			}

			// Token: 0x0602B95C RID: 178524 RVA: 0x000DC830 File Offset: 0x000DAA30
			[Token(Token = "0x602B95C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
			public bool IsMilestoneUnlock(string actId)
			{
				return default(bool);
			}

			// Token: 0x0602B95D RID: 178525 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B95D")]
			[Address(RVA = "0x2791BB0", Offset = "0x27907B0", VA = "0x182791BB0", Slot = "11")]
			public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602B95E RID: 178526 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B95E")]
			[Address(RVA = "0x2791B40", Offset = "0x2790740", VA = "0x182791B40", Slot = "12")]
			public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602B95F RID: 178527 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B95F")]
			[Address(RVA = "0x2791C70", Offset = "0x2790870", VA = "0x182791C70", Slot = "14")]
			public string GetMilestoneLockedToastDesc(string actId)
			{
				return null;
			}

			// Token: 0x0602B960 RID: 178528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B960")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Plugin()
			{
			}
		}
	}
}
