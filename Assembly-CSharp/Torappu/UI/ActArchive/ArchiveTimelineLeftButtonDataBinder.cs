using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C3B RID: 27707
	[Token(Token = "0x2006C3B")]
	public class ArchiveTimelineLeftButtonDataBinder : DataBinder<TimelineProperty>
	{
		// Token: 0x17005D5C RID: 23900
		// (set) Token: 0x060278D5 RID: 162005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D5C")]
		public ArchiveTimelineController controller
		{
			[Token(Token = "0x60278D5")]
			[Address(RVA = "0x22BFE50", Offset = "0x22BEA50", VA = "0x1822BFE50")]
			set
			{
			}
		}

		// Token: 0x060278D6 RID: 162006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278D6")]
		[Address(RVA = "0x22BFCA0", Offset = "0x22BE8A0", VA = "0x1822BFCA0", Slot = "7")]
		public override void OnValueChanged(TimelineProperty property)
		{
		}

		// Token: 0x060278D7 RID: 162007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278D7")]
		[Address(RVA = "0x22BFDE0", Offset = "0x22BE9E0", VA = "0x1822BFDE0")]
		public ArchiveTimelineLeftButtonDataBinder()
		{
		}

		// Token: 0x0403814F RID: 229711
		[Token(Token = "0x403814F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveTimelineCategoryBtn _btnMusic;

		// Token: 0x04038150 RID: 229712
		[Token(Token = "0x4038150")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArchiveTimelineCategoryBtn _btnPic;

		// Token: 0x04038151 RID: 229713
		[Token(Token = "0x4038151")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveTimelineCategoryBtn _btnAvg;

		// Token: 0x04038152 RID: 229714
		[Token(Token = "0x4038152")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveTimelineCategoryBtn _btnStory;

		// Token: 0x04038153 RID: 229715
		[Token(Token = "0x4038153")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveTimelineCategoryBtn _btnNews;

		// Token: 0x04038154 RID: 229716
		[Token(Token = "0x4038154")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04038155 RID: 229717
		[Token(Token = "0x4038155")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038156 RID: 229718
		[Token(Token = "0x4038156")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
