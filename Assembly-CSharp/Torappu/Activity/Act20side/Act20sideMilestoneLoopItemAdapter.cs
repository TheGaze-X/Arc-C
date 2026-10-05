using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007688 RID: 30344
	[Token(Token = "0x2007688")]
	public class Act20sideMilestoneLoopItemAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x0602AAE3 RID: 174819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AAE3")]
		[Address(RVA = "0x2676AD0", Offset = "0x26756D0", VA = "0x182676AD0", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x0602AAE4 RID: 174820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AAE4")]
		[Address(RVA = "0x2676D00", Offset = "0x2675900", VA = "0x182676D00")]
		public IList<UIRecycleLayoutAdapter.IVirtualView> InstVirtView()
		{
			return null;
		}

		// Token: 0x0602AAE5 RID: 174821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAE5")]
		[Address(RVA = "0x2676EE0", Offset = "0x2675AE0", VA = "0x182676EE0")]
		public Act20sideMilestoneLoopItemAdapter()
		{
		}

		// Token: 0x0403D7D9 RID: 251865
		[Token(Token = "0x403D7D9")]
		public const int ROW_NUM = 4;

		// Token: 0x0403D7DA RID: 251866
		[Token(Token = "0x403D7DA")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Act20sideMilestoneLoopItemView loopItemPrefab;

		// Token: 0x0403D7DB RID: 251867
		[Token(Token = "0x403D7DB")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<Act20sideMilestoneLoopItemViewModel> viewModelList;

		// Token: 0x0403D7DC RID: 251868
		[Token(Token = "0x403D7DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0403D7DD RID: 251869
		[Token(Token = "0x403D7DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InstVirtView;

		// Token: 0x0403D7DE RID: 251870
		[Token(Token = "0x403D7DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
