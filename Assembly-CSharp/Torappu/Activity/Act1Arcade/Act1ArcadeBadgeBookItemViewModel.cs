using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200793C RID: 31036
	[Token(Token = "0x200793C")]
	public class Act1ArcadeBadgeBookItemViewModel : IComparable<Act1ArcadeBadgeBookItemViewModel>, IHotfixable
	{
		// Token: 0x0602B8B1 RID: 178353 RVA: 0x000DC668 File Offset: 0x000DA868
		[Token(Token = "0x602B8B1")]
		[Address(RVA = "0x276B4D0", Offset = "0x276A0D0", VA = "0x18276B4D0", Slot = "4")]
		public int CompareTo(Act1ArcadeBadgeBookItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0602B8B2 RID: 178354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8B2")]
		[Address(RVA = "0x276B570", Offset = "0x276A170", VA = "0x18276B570")]
		public Act1ArcadeBadgeBookItemViewModel()
		{
		}

		// Token: 0x0403EFA5 RID: 257957
		[Token(Token = "0x403EFA5")]
		[FieldOffset(Offset = "0x10")]
		public string badgeId;

		// Token: 0x0403EFA6 RID: 257958
		[Token(Token = "0x403EFA6")]
		[FieldOffset(Offset = "0x18")]
		public ActArcadeData.BadgeType badgeType;

		// Token: 0x0403EFA7 RID: 257959
		[Token(Token = "0x403EFA7")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x0403EFA8 RID: 257960
		[Token(Token = "0x403EFA8")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0403EFA9 RID: 257961
		[Token(Token = "0x403EFA9")]
		[FieldOffset(Offset = "0x28")]
		public string buffRangeDesc;

		// Token: 0x0403EFAA RID: 257962
		[Token(Token = "0x403EFAA")]
		[FieldOffset(Offset = "0x30")]
		public bool hasScore;

		// Token: 0x0403EFAB RID: 257963
		[Token(Token = "0x403EFAB")]
		[FieldOffset(Offset = "0x38")]
		public string scoreZoneId;

		// Token: 0x0403EFAC RID: 257964
		[Token(Token = "0x403EFAC")]
		[FieldOffset(Offset = "0x40")]
		public List<Act1ArcadeBadgeBookItemTierViewModel> tiers;

		// Token: 0x0403EFAD RID: 257965
		[Token(Token = "0x403EFAD")]
		[FieldOffset(Offset = "0x48")]
		public int score;

		// Token: 0x0403EFAE RID: 257966
		[Token(Token = "0x403EFAE")]
		[FieldOffset(Offset = "0x4C")]
		public int currentTier;

		// Token: 0x0403EFAF RID: 257967
		[Token(Token = "0x403EFAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403EFB0 RID: 257968
		[Token(Token = "0x403EFB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
