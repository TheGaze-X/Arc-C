using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CBC RID: 19644
	[Token(Token = "0x2004CBC")]
	public class GroceryHomeViewModel : IHotfixable
	{
		// Token: 0x0601D6F5 RID: 120565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6F5")]
		[Address(RVA = "0x16F8620", Offset = "0x16F7220", VA = "0x1816F8620")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601D6F6 RID: 120566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6F6")]
		[Address(RVA = "0x16F8980", Offset = "0x16F7580", VA = "0x1816F8980")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601D6F7 RID: 120567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6F7")]
		[Address(RVA = "0x16F8DB0", Offset = "0x16F79B0", VA = "0x1816F8DB0")]
		private void _LoadGoodData(Act27SideData gameData)
		{
		}

		// Token: 0x0601D6F8 RID: 120568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6F8")]
		[Address(RVA = "0x16F9300", Offset = "0x16F7F00", VA = "0x1816F9300")]
		private void _RefreshMileStoneData(PlayerActivity.PlayerAct27SideActivity playerData)
		{
		}

		// Token: 0x0601D6F9 RID: 120569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6F9")]
		[Address(RVA = "0x16F9000", Offset = "0x16F7C00", VA = "0x1816F9000")]
		private void _RefreshGoodData(PlayerActivity.PlayerAct27SideActivity playerData, long currTs, long endTs)
		{
		}

		// Token: 0x0601D6FA RID: 120570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6FA")]
		[Address(RVA = "0x16F9430", Offset = "0x16F8030", VA = "0x1816F9430")]
		public GroceryHomeViewModel()
		{
		}

		// Token: 0x04026C8A RID: 158858
		[Token(Token = "0x4026C8A")]
		[FieldOffset(Offset = "0x10")]
		public bool isGoodPanelShow;

		// Token: 0x04026C8B RID: 158859
		[Token(Token = "0x4026C8B")]
		[FieldOffset(Offset = "0x18")]
		public string mileStonePointName;

		// Token: 0x04026C8C RID: 158860
		[Token(Token = "0x4026C8C")]
		[FieldOffset(Offset = "0x20")]
		public int mileStonePoint;

		// Token: 0x04026C8D RID: 158861
		[Token(Token = "0x4026C8D")]
		[FieldOffset(Offset = "0x24")]
		public int nextMileStonePoint;

		// Token: 0x04026C8E RID: 158862
		[Token(Token = "0x4026C8E")]
		[FieldOffset(Offset = "0x28")]
		public int currentDay;

		// Token: 0x04026C8F RID: 158863
		[Token(Token = "0x4026C8F")]
		[FieldOffset(Offset = "0x2C")]
		public bool hasStageLockedOnlyGoodGroup;

		// Token: 0x04026C90 RID: 158864
		[Token(Token = "0x4026C90")]
		[FieldOffset(Offset = "0x30")]
		public GroceryHomeViewModel.State currState;

		// Token: 0x04026C91 RID: 158865
		[Token(Token = "0x4026C91")]
		[FieldOffset(Offset = "0x38")]
		public UIItemViewModel dailyReward;

		// Token: 0x04026C92 RID: 158866
		[Token(Token = "0x4026C92")]
		[FieldOffset(Offset = "0x40")]
		public List<GroceryHomeShopModel> shopModelList;

		// Token: 0x04026C93 RID: 158867
		[Token(Token = "0x4026C93")]
		[FieldOffset(Offset = "0x48")]
		public List<GroceryHomeGoodItemModel> goodModelList;

		// Token: 0x04026C94 RID: 158868
		[Token(Token = "0x4026C94")]
		[FieldOffset(Offset = "0x50")]
		public List<GroceryHomeLaunchPanelGoodGroupModel> launchGoodGroupList;

		// Token: 0x04026C95 RID: 158869
		[Token(Token = "0x4026C95")]
		[FieldOffset(Offset = "0x58")]
		public string nextSaleTimeDesc;

		// Token: 0x04026C96 RID: 158870
		[Token(Token = "0x4026C96")]
		[FieldOffset(Offset = "0x60")]
		public bool showNextSaleTimeDesc;

		// Token: 0x04026C97 RID: 158871
		[Token(Token = "0x4026C97")]
		[FieldOffset(Offset = "0x68")]
		public string actId;

		// Token: 0x04026C98 RID: 158872
		[Token(Token = "0x4026C98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026C99 RID: 158873
		[Token(Token = "0x4026C99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04026C9A RID: 158874
		[Token(Token = "0x4026C9A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadGoodData;

		// Token: 0x04026C9B RID: 158875
		[Token(Token = "0x4026C9B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshMileStoneData;

		// Token: 0x04026C9C RID: 158876
		[Token(Token = "0x4026C9C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshGoodData;

		// Token: 0x04026C9D RID: 158877
		[Token(Token = "0x4026C9D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CBD RID: 19645
		[Token(Token = "0x2004CBD")]
		public enum State
		{
			// Token: 0x04026C9F RID: 158879
			[Token(Token = "0x4026C9F")]
			BEFORE_SALE,
			// Token: 0x04026CA0 RID: 158880
			[Token(Token = "0x4026CA0")]
			PURCHASE,
			// Token: 0x04026CA1 RID: 158881
			[Token(Token = "0x4026CA1")]
			SELL,
			// Token: 0x04026CA2 RID: 158882
			[Token(Token = "0x4026CA2")]
			BEFORE_SETTLE,
			// Token: 0x04026CA3 RID: 158883
			[Token(Token = "0x4026CA3")]
			AFTER_SETTLE,
			// Token: 0x04026CA4 RID: 158884
			[Token(Token = "0x4026CA4")]
			REWARD_ONLY
		}
	}
}
