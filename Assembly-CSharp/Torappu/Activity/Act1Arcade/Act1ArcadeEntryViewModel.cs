using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007949 RID: 31049
	[Token(Token = "0x2007949")]
	public class Act1ArcadeEntryViewModel : IHotfixable
	{
		// Token: 0x1700661D RID: 26141
		// (get) Token: 0x0602B90D RID: 178445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B90E RID: 178446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700661D")]
		public List<Act1ArcadeEntryGameEntryItemViewModel> itemViewModels
		{
			[Token(Token = "0x602B90D")]
			[Address(RVA = "0x2775FF0", Offset = "0x2774BF0", VA = "0x182775FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B90E")]
			[Address(RVA = "0x27761A0", Offset = "0x2774DA0", VA = "0x1827761A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700661E RID: 26142
		// (get) Token: 0x0602B90F RID: 178447 RVA: 0x000DC710 File Offset: 0x000DA910
		// (set) Token: 0x0602B910 RID: 178448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700661E")]
		public int allZoneScore
		{
			[Token(Token = "0x602B90F")]
			[Address(RVA = "0x2775ED0", Offset = "0x2774AD0", VA = "0x182775ED0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602B910")]
			[Address(RVA = "0x2776050", Offset = "0x2774C50", VA = "0x182776050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700661F RID: 26143
		// (get) Token: 0x0602B911 RID: 178449 RVA: 0x000DC728 File Offset: 0x000DA928
		// (set) Token: 0x0602B912 RID: 178450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700661F")]
		public int badgeBookEntryIconIndex
		{
			[Token(Token = "0x602B911")]
			[Address(RVA = "0x2775F30", Offset = "0x2774B30", VA = "0x182775F30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602B912")]
			[Address(RVA = "0x27760C0", Offset = "0x2774CC0", VA = "0x1827760C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006620 RID: 26144
		// (get) Token: 0x0602B913 RID: 178451 RVA: 0x000DC740 File Offset: 0x000DA940
		// (set) Token: 0x0602B914 RID: 178452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006620")]
		public bool hasBadgeBookTrackPoint
		{
			[Token(Token = "0x602B913")]
			[Address(RVA = "0x2775F90", Offset = "0x2774B90", VA = "0x182775F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B914")]
			[Address(RVA = "0x2776130", Offset = "0x2774D30", VA = "0x182776130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B915 RID: 178453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B915")]
		[Address(RVA = "0x2775970", Offset = "0x2774570", VA = "0x182775970")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602B916 RID: 178454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B916")]
		[Address(RVA = "0x2775E70", Offset = "0x2774A70", VA = "0x182775E70")]
		public Act1ArcadeEntryViewModel()
		{
		}

		// Token: 0x0403F050 RID: 258128
		[Token(Token = "0x403F050")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemViewModels;

		// Token: 0x0403F051 RID: 258129
		[Token(Token = "0x403F051")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemViewModels;

		// Token: 0x0403F052 RID: 258130
		[Token(Token = "0x403F052")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allZoneScore;

		// Token: 0x0403F053 RID: 258131
		[Token(Token = "0x403F053")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_allZoneScore;

		// Token: 0x0403F054 RID: 258132
		[Token(Token = "0x403F054")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_badgeBookEntryIconIndex;

		// Token: 0x0403F055 RID: 258133
		[Token(Token = "0x403F055")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_badgeBookEntryIconIndex;

		// Token: 0x0403F056 RID: 258134
		[Token(Token = "0x403F056")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasBadgeBookTrackPoint;

		// Token: 0x0403F057 RID: 258135
		[Token(Token = "0x403F057")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_hasBadgeBookTrackPoint;

		// Token: 0x0403F058 RID: 258136
		[Token(Token = "0x403F058")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F059 RID: 258137
		[Token(Token = "0x403F059")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
