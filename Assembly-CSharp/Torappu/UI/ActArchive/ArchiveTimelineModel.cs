using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C3F RID: 27711
	[Token(Token = "0x2006C3F")]
	public class ArchiveTimelineModel
	{
		// Token: 0x060278E3 RID: 162019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278E3")]
		[Address(RVA = "0x22C0100", Offset = "0x22BED00", VA = "0x1822C0100")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060278E4 RID: 162020 RVA: 0x000CEB38 File Offset: 0x000CCD38
		[Token(Token = "0x60278E4")]
		[Address(RVA = "0x22BFF20", Offset = "0x22BEB20", VA = "0x1822BFF20")]
		public int GetFirstUncheckedItem()
		{
			return 0;
		}

		// Token: 0x060278E5 RID: 162021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278E5")]
		[Address(RVA = "0x22C05B0", Offset = "0x22BF1B0", VA = "0x1822C05B0")]
		public ArchiveTimelineModel()
		{
		}

		// Token: 0x04038169 RID: 229737
		[Token(Token = "0x4038169")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, TimelineItemModel> timelineItemList;

		// Token: 0x0403816A RID: 229738
		[Token(Token = "0x403816A")]
		[FieldOffset(Offset = "0x18")]
		public TimelineCategoryModel timelineCategory;
	}
}
