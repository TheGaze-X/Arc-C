using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CEF RID: 19695
	[Token(Token = "0x2004CEF")]
	public class GroceryOrderResultViewModel : IHotfixable
	{
		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x0601D856 RID: 120918 RVA: 0x000ABD68 File Offset: 0x000A9F68
		// (set) Token: 0x0601D857 RID: 120919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004558")]
		public int purchaseTotalCost
		{
			[Token(Token = "0x601D856")]
			[Address(RVA = "0x17130E0", Offset = "0x1711CE0", VA = "0x1817130E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D857")]
			[Address(RVA = "0x1713140", Offset = "0x1711D40", VA = "0x181713140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x0601D858 RID: 120920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004559")]
		public List<GroceryOrderResultGoodItemViewModel> goodItemViewModelList
		{
			[Token(Token = "0x601D858")]
			[Address(RVA = "0x1713080", Offset = "0x1711C80", VA = "0x181713080")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D859 RID: 120921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D859")]
		[Address(RVA = "0x1712530", Offset = "0x1711130", VA = "0x181712530")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x0601D85A RID: 120922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D85A")]
		[Address(RVA = "0x1712C70", Offset = "0x1711870", VA = "0x181712C70")]
		private void _LoadGoodItems(Act27SideData.Act27SideGoodLaunchData launchData, Act27SideData actData, Dictionary<string, Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PurchaseInfo>> allPurchaseInfo)
		{
		}

		// Token: 0x0601D85B RID: 120923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D85B")]
		[Address(RVA = "0x1712A90", Offset = "0x1711690", VA = "0x181712A90")]
		private void _LoadGoodItemData(string goodId, Act27SideData actData, Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PurchaseInfo> purchaseInfos)
		{
		}

		// Token: 0x0601D85C RID: 120924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D85C")]
		[Address(RVA = "0x1712E60", Offset = "0x1711A60", VA = "0x181712E60")]
		private void _RefreshMyShopTotalCost()
		{
		}

		// Token: 0x0601D85D RID: 120925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D85D")]
		[Address(RVA = "0x1712FD0", Offset = "0x1711BD0", VA = "0x181712FD0")]
		public GroceryOrderResultViewModel()
		{
		}

		// Token: 0x04026F24 RID: 159524
		[Token(Token = "0x4026F24")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x04026F25 RID: 159525
		[Token(Token = "0x4026F25")]
		[FieldOffset(Offset = "0x20")]
		private string m_groupId;

		// Token: 0x04026F26 RID: 159526
		[Token(Token = "0x4026F26")]
		[FieldOffset(Offset = "0x28")]
		private string m_myShopId;

		// Token: 0x04026F27 RID: 159527
		[Token(Token = "0x4026F27")]
		[FieldOffset(Offset = "0x30")]
		private List<GroceryOrderResultGoodItemViewModel> m_goodItemViewModelList;

		// Token: 0x04026F28 RID: 159528
		[Token(Token = "0x4026F28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_purchaseTotalCost;

		// Token: 0x04026F29 RID: 159529
		[Token(Token = "0x4026F29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_purchaseTotalCost;

		// Token: 0x04026F2A RID: 159530
		[Token(Token = "0x4026F2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_goodItemViewModelList;

		// Token: 0x04026F2B RID: 159531
		[Token(Token = "0x4026F2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026F2C RID: 159532
		[Token(Token = "0x4026F2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadGoodItems;

		// Token: 0x04026F2D RID: 159533
		[Token(Token = "0x4026F2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadGoodItemData;

		// Token: 0x04026F2E RID: 159534
		[Token(Token = "0x4026F2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshMyShopTotalCost;

		// Token: 0x04026F2F RID: 159535
		[Token(Token = "0x4026F2F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
