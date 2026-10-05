using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A5F RID: 27231
	[Token(Token = "0x2006A5F")]
	public class StageMixStoryRecycleList : UIRecycleLayoutAdapter
	{
		// Token: 0x06026EB0 RID: 159408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026EB0")]
		[Address(RVA = "0x2223B70", Offset = "0x2222770", VA = "0x182223B70", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06026EB1 RID: 159409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EB1")]
		[Address(RVA = "0x2223F40", Offset = "0x2222B40", VA = "0x182223F40")]
		public void NotifyRebuild()
		{
		}

		// Token: 0x06026EB2 RID: 159410 RVA: 0x000CCB58 File Offset: 0x000CAD58
		[Token(Token = "0x6026EB2")]
		[Address(RVA = "0x2223CA0", Offset = "0x22228A0", VA = "0x182223CA0")]
		public float GetPositionOfItem(int index)
		{
			return 0f;
		}

		// Token: 0x06026EB3 RID: 159411 RVA: 0x000CCB70 File Offset: 0x000CAD70
		[Token(Token = "0x6026EB3")]
		[Address(RVA = "0x2223DD0", Offset = "0x22229D0", VA = "0x182223DD0")]
		public float GetSizeOfItem(int index)
		{
			return 0f;
		}

		// Token: 0x06026EB4 RID: 159412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EB4")]
		[Address(RVA = "0x2223FD0", Offset = "0x2222BD0", VA = "0x182223FD0")]
		public void UpdateViews()
		{
		}

		// Token: 0x06026EB5 RID: 159413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EB5")]
		[Address(RVA = "0x22241E0", Offset = "0x2222DE0", VA = "0x1822241E0")]
		public StageMixStoryRecycleList()
		{
		}

		// Token: 0x040370BD RID: 225469
		[Token(Token = "0x40370BD")]
		[FieldOffset(Offset = "0x18")]
		public List<UIRecycleLayoutAdapter.IVirtualView> views;

		// Token: 0x040370BE RID: 225470
		[Token(Token = "0x40370BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x040370BF RID: 225471
		[Token(Token = "0x40370BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyRebuild;

		// Token: 0x040370C0 RID: 225472
		[Token(Token = "0x40370C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPositionOfItem;

		// Token: 0x040370C1 RID: 225473
		[Token(Token = "0x40370C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSizeOfItem;

		// Token: 0x040370C2 RID: 225474
		[Token(Token = "0x40370C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateViews;

		// Token: 0x040370C3 RID: 225475
		[Token(Token = "0x40370C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
