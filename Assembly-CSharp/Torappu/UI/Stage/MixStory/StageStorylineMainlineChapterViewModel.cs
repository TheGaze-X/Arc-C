using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A77 RID: 27255
	[Token(Token = "0x2006A77")]
	public class StageStorylineMainlineChapterViewModel : IHotfixable
	{
		// Token: 0x17005BE2 RID: 23522
		// (get) Token: 0x06026F50 RID: 159568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BE2")]
		public List<ChapterViewModel> chapterList
		{
			[Token(Token = "0x6026F50")]
			[Address(RVA = "0x2228DB0", Offset = "0x22279B0", VA = "0x182228DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BE3 RID: 23523
		// (get) Token: 0x06026F51 RID: 159569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BE3")]
		public Dictionary<string, List<StageStorylineStorySetViewModel>> chapterId2ZoneListMap
		{
			[Token(Token = "0x6026F51")]
			[Address(RVA = "0x2228D50", Offset = "0x2227950", VA = "0x182228D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026F52 RID: 159570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F52")]
		[Address(RVA = "0x2227F10", Offset = "0x2226B10", VA = "0x182227F10")]
		public void RefreshMainlineChapterData(Dictionary<string, StageStorylineStorySetViewModel> storySets, Dictionary<string, ZoneViewModel> zoneDict)
		{
		}

		// Token: 0x06026F53 RID: 159571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F53")]
		[Address(RVA = "0x2228810", Offset = "0x2227410", VA = "0x182228810")]
		private void _RefreshChapterCurGoingMainlineStageId(Dictionary<string, ZoneViewModel> zoneDict)
		{
		}

		// Token: 0x06026F54 RID: 159572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026F54")]
		[Address(RVA = "0x2228680", Offset = "0x2227280", VA = "0x182228680")]
		private ChapterViewModel _CreateChapterViewModel(string chapterId)
		{
			return null;
		}

		// Token: 0x06026F55 RID: 159573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026F55")]
		[Address(RVA = "0x2227DD0", Offset = "0x22269D0", VA = "0x182227DD0")]
		public static string GetMainlineZoneIdFromModel(StageStorylineStorySetViewModel model)
		{
			return null;
		}

		// Token: 0x06026F56 RID: 159574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026F56")]
		[Address(RVA = "0x2227C90", Offset = "0x2226890", VA = "0x182227C90")]
		private static string GetMainlineRetroZoneIdFromModel(StageStorylineStorySetViewModel model)
		{
			return null;
		}

		// Token: 0x06026F57 RID: 159575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F57")]
		[Address(RVA = "0x2228C50", Offset = "0x2227850", VA = "0x182228C50")]
		public StageStorylineMainlineChapterViewModel()
		{
		}

		// Token: 0x040371AC RID: 225708
		[Token(Token = "0x40371AC")]
		[FieldOffset(Offset = "0x10")]
		private List<ChapterViewModel> m_chapterList;

		// Token: 0x040371AD RID: 225709
		[Token(Token = "0x40371AD")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, List<StageStorylineStorySetViewModel>> m_chapterId2ZoneListMap;

		// Token: 0x040371AE RID: 225710
		[Token(Token = "0x40371AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chapterList;

		// Token: 0x040371AF RID: 225711
		[Token(Token = "0x40371AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_chapterId2ZoneListMap;

		// Token: 0x040371B0 RID: 225712
		[Token(Token = "0x40371B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshMainlineChapterData;

		// Token: 0x040371B1 RID: 225713
		[Token(Token = "0x40371B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshChapterCurGoingMainlineStageId;

		// Token: 0x040371B2 RID: 225714
		[Token(Token = "0x40371B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateChapterViewModel;

		// Token: 0x040371B3 RID: 225715
		[Token(Token = "0x40371B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetMainlineZoneIdFromModel;

		// Token: 0x040371B4 RID: 225716
		[Token(Token = "0x40371B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetMainlineRetroZoneIdFromModel;

		// Token: 0x040371B5 RID: 225717
		[Token(Token = "0x40371B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
