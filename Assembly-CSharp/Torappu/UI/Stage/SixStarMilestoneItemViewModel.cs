using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200682B RID: 26667
	[Token(Token = "0x200682B")]
	public class SixStarMilestoneItemViewModel : IHotfixable, IComparable
	{
		// Token: 0x06026324 RID: 156452 RVA: 0x000CA4D0 File Offset: 0x000C86D0
		[Token(Token = "0x6026324")]
		[Address(RVA = "0x213A7C0", Offset = "0x21393C0", VA = "0x18213A7C0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06026325 RID: 156453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026325")]
		[Address(RVA = "0x213A8D0", Offset = "0x21394D0", VA = "0x18213A8D0")]
		public SixStarMilestoneItemViewModel()
		{
		}

		// Token: 0x04035D28 RID: 220456
		[Token(Token = "0x4035D28")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04035D29 RID: 220457
		[Token(Token = "0x4035D29")]
		[FieldOffset(Offset = "0x18")]
		public int point;

		// Token: 0x04035D2A RID: 220458
		[Token(Token = "0x4035D2A")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04035D2B RID: 220459
		[Token(Token = "0x4035D2B")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSixStarMilestoneState state;

		// Token: 0x04035D2C RID: 220460
		[Token(Token = "0x4035D2C")]
		[FieldOffset(Offset = "0x24")]
		public SixStarMilestoneRewardType rewardType;

		// Token: 0x04035D2D RID: 220461
		[Token(Token = "0x4035D2D")]
		[FieldOffset(Offset = "0x28")]
		public string stageName;

		// Token: 0x04035D2E RID: 220462
		[Token(Token = "0x4035D2E")]
		[FieldOffset(Offset = "0x30")]
		public List<ItemBundle> rewardList;

		// Token: 0x04035D2F RID: 220463
		[Token(Token = "0x4035D2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04035D30 RID: 220464
		[Token(Token = "0x4035D30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
