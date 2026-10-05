using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005973 RID: 22899
	[Token(Token = "0x2005973")]
	public class CrisisV2MissionItemModel : IHotfixable, IComparable<CrisisV2MissionItemModel>
	{
		// Token: 0x06021654 RID: 136788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021654")]
		[Address(RVA = "0x1BC8E20", Offset = "0x1BC7A20", VA = "0x181BC8E20")]
		public CrisisV2MissionItemModel(string id, CrisisV2MissionType type)
		{
		}

		// Token: 0x06021655 RID: 136789 RVA: 0x000BA108 File Offset: 0x000B8308
		[Token(Token = "0x6021655")]
		[Address(RVA = "0x1BC8CC0", Offset = "0x1BC78C0", VA = "0x181BC8CC0", Slot = "4")]
		public int CompareTo(CrisisV2MissionItemModel obj)
		{
			return 0;
		}

		// Token: 0x0402D8B6 RID: 186550
		[Token(Token = "0x402D8B6")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2MissionInfo missionInfo;

		// Token: 0x0402D8B7 RID: 186551
		[Token(Token = "0x402D8B7")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0402D8B8 RID: 186552
		[Token(Token = "0x402D8B8")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x0402D8B9 RID: 186553
		[Token(Token = "0x402D8B9")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x0402D8BA RID: 186554
		[Token(Token = "0x402D8BA")]
		[FieldOffset(Offset = "0x30")]
		public List<CrisisV2TimeLimitItemModel> rewardList;

		// Token: 0x0402D8BB RID: 186555
		[Token(Token = "0x402D8BB")]
		[FieldOffset(Offset = "0x38")]
		public CrisisV2MissionItemModel.MissionSortType missionSortType;

		// Token: 0x0402D8BC RID: 186556
		[Token(Token = "0x402D8BC")]
		[FieldOffset(Offset = "0x3C")]
		public CrisisV2MissionItemModel.SortState missionState;

		// Token: 0x0402D8BD RID: 186557
		[Token(Token = "0x402D8BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D8BE RID: 186558
		[Token(Token = "0x402D8BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x02005974 RID: 22900
		[Token(Token = "0x2005974")]
		public enum SortState
		{
			// Token: 0x0402D8C0 RID: 186560
			[Token(Token = "0x402D8C0")]
			COMPLETE,
			// Token: 0x0402D8C1 RID: 186561
			[Token(Token = "0x402D8C1")]
			UNLOCK,
			// Token: 0x0402D8C2 RID: 186562
			[Token(Token = "0x402D8C2")]
			CLAIMED
		}

		// Token: 0x02005975 RID: 22901
		[Token(Token = "0x2005975")]
		public enum MissionSortType
		{
			// Token: 0x0402D8C4 RID: 186564
			[Token(Token = "0x402D8C4")]
			SORT_TREASURE,
			// Token: 0x0402D8C5 RID: 186565
			[Token(Token = "0x402D8C5")]
			SORT_CHALLENGE,
			// Token: 0x0402D8C6 RID: 186566
			[Token(Token = "0x402D8C6")]
			SORT_RUNEPACK
		}
	}
}
