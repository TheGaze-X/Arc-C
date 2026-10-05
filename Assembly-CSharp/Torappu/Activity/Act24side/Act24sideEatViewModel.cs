using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007586 RID: 30086
	[Token(Token = "0x2007586")]
	public class Act24sideEatViewModel : IHotfixable
	{
		// Token: 0x0602A5B8 RID: 173496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5B8")]
		[Address(RVA = "0x25FF670", Offset = "0x25FE270", VA = "0x1825FF670")]
		public void LoadData(string actId, bool isInit)
		{
		}

		// Token: 0x0602A5B9 RID: 173497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A5B9")]
		[Address(RVA = "0x25FF5F0", Offset = "0x25FE1F0", VA = "0x1825FF5F0")]
		public Act24sideMealViewModel GetSelectedItem()
		{
			return null;
		}

		// Token: 0x0602A5BA RID: 173498 RVA: 0x000D8240 File Offset: 0x000D6440
		[Token(Token = "0x602A5BA")]
		[Address(RVA = "0x25FFD50", Offset = "0x25FE950", VA = "0x1825FFD50")]
		public bool SetSelectedItem(string mealId)
		{
			return default(bool);
		}

		// Token: 0x0602A5BB RID: 173499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5BB")]
		[Address(RVA = "0x25FFE70", Offset = "0x25FEA70", VA = "0x1825FFE70")]
		public Act24sideEatViewModel()
		{
		}

		// Token: 0x0403CEDC RID: 249564
		[Token(Token = "0x403CEDC")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403CEDD RID: 249565
		[Token(Token = "0x403CEDD")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Act24sideMealViewModel> mealList;

		// Token: 0x0403CEDE RID: 249566
		[Token(Token = "0x403CEDE")]
		[FieldOffset(Offset = "0x20")]
		public bool haveMealChanceToday;

		// Token: 0x0403CEDF RID: 249567
		[Token(Token = "0x403CEDF")]
		[FieldOffset(Offset = "0x21")]
		public bool currMealUsed;

		// Token: 0x0403CEE0 RID: 249568
		[Token(Token = "0x403CEE0")]
		[FieldOffset(Offset = "0x28")]
		public string currMealId;

		// Token: 0x0403CEE1 RID: 249569
		[Token(Token = "0x403CEE1")]
		[FieldOffset(Offset = "0x30")]
		public string selectedMealId;

		// Token: 0x0403CEE2 RID: 249570
		[Token(Token = "0x403CEE2")]
		[FieldOffset(Offset = "0x38")]
		public long playerGold;

		// Token: 0x0403CEE3 RID: 249571
		[Token(Token = "0x403CEE3")]
		[FieldOffset(Offset = "0x40")]
		public long actStartTime;

		// Token: 0x0403CEE4 RID: 249572
		[Token(Token = "0x403CEE4")]
		[FieldOffset(Offset = "0x48")]
		public long actEndTime;

		// Token: 0x0403CEE5 RID: 249573
		[Token(Token = "0x403CEE5")]
		[FieldOffset(Offset = "0x50")]
		public long nextRefreshTimestamp;

		// Token: 0x0403CEE6 RID: 249574
		[Token(Token = "0x403CEE6")]
		[FieldOffset(Offset = "0x58")]
		public bool isLastDay;

		// Token: 0x0403CEE7 RID: 249575
		[Token(Token = "0x403CEE7")]
		[FieldOffset(Offset = "0x5C")]
		public int sequenceNum;

		// Token: 0x0403CEE8 RID: 249576
		[Token(Token = "0x403CEE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CEE9 RID: 249577
		[Token(Token = "0x403CEE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSelectedItem;

		// Token: 0x0403CEEA RID: 249578
		[Token(Token = "0x403CEEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedItem;

		// Token: 0x0403CEEB RID: 249579
		[Token(Token = "0x403CEEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
