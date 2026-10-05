using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x0200783A RID: 30778
	[Token(Token = "0x200783A")]
	public class Act1VHalfIdleMilestoneSnapshot : MilestoneSnapshot
	{
		// Token: 0x0602B2C3 RID: 176835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2C3")]
		[Address(RVA = "0x26F9960", Offset = "0x26F8560", VA = "0x1826F9960")]
		public void Init(List<Act1VHalfIdleMilestoneItemData> milestoneList)
		{
		}

		// Token: 0x1700650C RID: 25868
		// (get) Token: 0x0602B2C4 RID: 176836 RVA: 0x000DB0C0 File Offset: 0x000D92C0
		[Token(Token = "0x1700650C")]
		protected override int milestoneCount
		{
			[Token(Token = "0x602B2C4")]
			[Address(RVA = "0x26F9BF0", Offset = "0x26F87F0", VA = "0x1826F9BF0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602B2C5 RID: 176837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2C5")]
		[Address(RVA = "0x26F9B00", Offset = "0x26F8700", VA = "0x1826F9B00", Slot = "5")]
		protected override MilestoneSnapshot.IMilestoneItem _GetMilestoneItemAt(int idx)
		{
			return null;
		}

		// Token: 0x0602B2C6 RID: 176838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2C6")]
		[Address(RVA = "0x26F9B90", Offset = "0x26F8790", VA = "0x1826F9B90")]
		public Act1VHalfIdleMilestoneSnapshot()
		{
		}

		// Token: 0x0403E688 RID: 255624
		[Token(Token = "0x403E688")]
		[FieldOffset(Offset = "0x28")]
		private List<Act1VHalfIdleMilestoneSnapshot.MilestoneItem> m_milestoneList;

		// Token: 0x0403E689 RID: 255625
		[Token(Token = "0x403E689")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403E68A RID: 255626
		[Token(Token = "0x403E68A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_milestoneCount;

		// Token: 0x0403E68B RID: 255627
		[Token(Token = "0x403E68B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetMilestoneItemAt;

		// Token: 0x0403E68C RID: 255628
		[Token(Token = "0x403E68C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200783B RID: 30779
		[Token(Token = "0x200783B")]
		private class MilestoneItem : MilestoneSnapshot.IMilestoneItem
		{
			// Token: 0x1700650D RID: 25869
			// (get) Token: 0x0602B2C7 RID: 176839 RVA: 0x000DB0D8 File Offset: 0x000D92D8
			[Token(Token = "0x1700650D")]
			public int level
			{
				[Token(Token = "0x602B2C7")]
				[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700650E RID: 25870
			// (get) Token: 0x0602B2C8 RID: 176840 RVA: 0x000DB0F0 File Offset: 0x000D92F0
			[Token(Token = "0x1700650E")]
			public int point
			{
				[Token(Token = "0x602B2C8")]
				[Address(RVA = "0x2704800", Offset = "0x2703400", VA = "0x182704800", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B2C9 RID: 176841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B2C9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MilestoneItem()
			{
			}

			// Token: 0x0403E68D RID: 255629
			[Token(Token = "0x403E68D")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleMilestoneItemData baseData;
		}
	}
}
