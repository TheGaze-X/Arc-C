using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC6 RID: 27334
	[Token(Token = "0x2006AC6")]
	public class TimelineProxy : ActArchiveCompProxy<ArchiveTimelineController>
	{
		// Token: 0x17005C69 RID: 23657
		// (get) Token: 0x0602719B RID: 160155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C69")]
		protected override string compType
		{
			[Token(Token = "0x602719B")]
			[Address(RVA = "0x22479C0", Offset = "0x22465C0", VA = "0x1822479C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602719C RID: 160156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602719C")]
		[Address(RVA = "0x2246FD0", Offset = "0x2245BD0", VA = "0x182246FD0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x0602719D RID: 160157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602719D")]
		[Address(RVA = "0x2247430", Offset = "0x2246030", VA = "0x182247430")]
		private void _onTimelineCategoryClicked(ActArchiveType archiveItemType)
		{
		}

		// Token: 0x0602719E RID: 160158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602719E")]
		[Address(RVA = "0x2247700", Offset = "0x2246300", VA = "0x182247700")]
		private void _onTimelineItemClicked(ActArchiveType archiveItemType, string archiveItemId)
		{
		}

		// Token: 0x0602719F RID: 160159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602719F")]
		[Address(RVA = "0x22473C0", Offset = "0x2245FC0", VA = "0x1822473C0")]
		public TimelineProxy()
		{
		}

		// Token: 0x0403750A RID: 226570
		[Token(Token = "0x403750A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403750B RID: 226571
		[Token(Token = "0x403750B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0403750C RID: 226572
		[Token(Token = "0x403750C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__onTimelineCategoryClicked;

		// Token: 0x0403750D RID: 226573
		[Token(Token = "0x403750D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__onTimelineItemClicked;

		// Token: 0x0403750E RID: 226574
		[Token(Token = "0x403750E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
