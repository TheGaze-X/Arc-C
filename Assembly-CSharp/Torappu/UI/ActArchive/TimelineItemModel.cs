using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C3D RID: 27709
	[Token(Token = "0x2006C3D")]
	public class TimelineItemModel : IHotfixable
	{
		// Token: 0x17005D61 RID: 23905
		// (get) Token: 0x060278DE RID: 162014 RVA: 0x000CEB08 File Offset: 0x000CCD08
		[Token(Token = "0x17005D61")]
		public bool isUnlockedAndUnchecked
		{
			[Token(Token = "0x60278DE")]
			[Address(RVA = "0x22CFB10", Offset = "0x22CE710", VA = "0x1822CFB10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060278DF RID: 162015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278DF")]
		[Address(RVA = "0x22CEF00", Offset = "0x22CDB00", VA = "0x1822CEF00")]
		public void LoadData(ActArchiveTimelineItemData timelineItemData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060278E0 RID: 162016 RVA: 0x000CEB20 File Offset: 0x000CCD20
		[Token(Token = "0x60278E0")]
		[Address(RVA = "0x22CEE80", Offset = "0x22CDA80", VA = "0x1822CEE80")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060278E1 RID: 162017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278E1")]
		[Address(RVA = "0x22CFAB0", Offset = "0x22CE6B0", VA = "0x1822CFAB0")]
		public TimelineItemModel()
		{
		}

		// Token: 0x04038158 RID: 229720
		[Token(Token = "0x4038158")]
		[FieldOffset(Offset = "0x10")]
		public TimelineResModel<MusicItemModel> musicItem;

		// Token: 0x04038159 RID: 229721
		[Token(Token = "0x4038159")]
		[FieldOffset(Offset = "0x18")]
		public TimelineResModel<PicItemModel> picItem;

		// Token: 0x0403815A RID: 229722
		[Token(Token = "0x403815A")]
		[FieldOffset(Offset = "0x20")]
		public TimelineResModel<AvgItemModel> avgItem;

		// Token: 0x0403815B RID: 229723
		[Token(Token = "0x403815B")]
		[FieldOffset(Offset = "0x28")]
		public TimelineResModel<StoryItemModel> storyItem;

		// Token: 0x0403815C RID: 229724
		[Token(Token = "0x403815C")]
		[FieldOffset(Offset = "0x30")]
		public TimelineResModel<NewsItemModel> newsItem;

		// Token: 0x0403815D RID: 229725
		[Token(Token = "0x403815D")]
		[FieldOffset(Offset = "0x38")]
		public int timelineSortId;

		// Token: 0x0403815E RID: 229726
		[Token(Token = "0x403815E")]
		[FieldOffset(Offset = "0x40")]
		public string timelineTitle;

		// Token: 0x0403815F RID: 229727
		[Token(Token = "0x403815F")]
		[FieldOffset(Offset = "0x48")]
		public string timelineDesc;

		// Token: 0x04038160 RID: 229728
		[Token(Token = "0x4038160")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlockedAndUnchecked;

		// Token: 0x04038161 RID: 229729
		[Token(Token = "0x4038161")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038162 RID: 229730
		[Token(Token = "0x4038162")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04038163 RID: 229731
		[Token(Token = "0x4038163")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
