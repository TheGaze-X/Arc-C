using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D34 RID: 19764
	[Token(Token = "0x2004D34")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class GroceryUtil
	{
		// Token: 0x0601D968 RID: 121192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D968")]
		[Address(RVA = "0x1733260", Offset = "0x1731E60", VA = "0x181733260")]
		public static Act27SideData GetAct27SideData(string actId)
		{
			return null;
		}

		// Token: 0x0601D969 RID: 121193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D969")]
		[Address(RVA = "0x17335B0", Offset = "0x17321B0", VA = "0x1817335B0")]
		public static Act27SideData.Act27SideGoodLaunchData GetGoodLaunchDataByGroupId(Act27SideData actData, string groupId)
		{
			return null;
		}

		// Token: 0x0601D96A RID: 121194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D96A")]
		[Address(RVA = "0x17336E0", Offset = "0x17322E0", VA = "0x1817336E0")]
		public static Sprite GetLaunchGoodIcon(string goodIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601D96B RID: 121195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D96B")]
		[Address(RVA = "0x1733340", Offset = "0x1731F40", VA = "0x181733340")]
		public static Sprite GetCommonShopIcon(string shopIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601D96C RID: 121196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D96C")]
		[Address(RVA = "0x1733770", Offset = "0x1732370", VA = "0x181733770")]
		public static Sprite GetShopBeforeInquireIcon(string shopIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601D96D RID: 121197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D96D")]
		[Address(RVA = "0x1733800", Offset = "0x1732400", VA = "0x181733800")]
		public static Sprite GetShopInquireIcon(string shopIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601D96E RID: 121198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D96E")]
		[Address(RVA = "0x1733520", Offset = "0x1732120", VA = "0x181733520")]
		public static Sprite GetGoodIcon(string goodIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601D96F RID: 121199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D96F")]
		[Address(RVA = "0x17333D0", Offset = "0x1731FD0", VA = "0x1817333D0")]
		public static string GetCustomerCountDesc(int[] countArray)
		{
			return null;
		}

		// Token: 0x0601D970 RID: 121200 RVA: 0x000AC098 File Offset: 0x000AA298
		[Token(Token = "0x601D970")]
		[Address(RVA = "0x17331C0", Offset = "0x1731DC0", VA = "0x1817331C0")]
		public static bool CheckIfGroceryUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x0402712B RID: 160043
		[Token(Token = "0x402712B")]
		private const string SHOP_INQUIRE_ICON = "inquire_{0}";

		// Token: 0x0402712C RID: 160044
		[Token(Token = "0x402712C")]
		private const string SHOP_BEFORE_INQUIRE_ICON = "before_inquire_{0}";

		// Token: 0x0402712D RID: 160045
		[Token(Token = "0x402712D")]
		public const string SELL_CUSTOMER_COUNT_UNKNOWN = "???";

		// Token: 0x0402712E RID: 160046
		[Token(Token = "0x402712E")]
		private const string SELL_CUSTOMER_COUNT_RANGE = "{0}-{1}";

		// Token: 0x0402712F RID: 160047
		[Token(Token = "0x402712F")]
		public const int SHOP_MAX_COUNT = 2;

		// Token: 0x04027130 RID: 160048
		[Token(Token = "0x4027130")]
		public const int SELL_RESULT_DISPLAY_NUM = 3;

		// Token: 0x04027131 RID: 160049
		[Token(Token = "0x4027131")]
		public const float INQUIRE_BUTTON_FADE_OUT_DUR = 0.5f;

		// Token: 0x04027132 RID: 160050
		[Token(Token = "0x4027132")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct27SideData;

		// Token: 0x04027133 RID: 160051
		[Token(Token = "0x4027133")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGoodLaunchDataByGroupId;

		// Token: 0x04027134 RID: 160052
		[Token(Token = "0x4027134")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetLaunchGoodIcon;

		// Token: 0x04027135 RID: 160053
		[Token(Token = "0x4027135")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCommonShopIcon;

		// Token: 0x04027136 RID: 160054
		[Token(Token = "0x4027136")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetShopBeforeInquireIcon;

		// Token: 0x04027137 RID: 160055
		[Token(Token = "0x4027137")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetShopInquireIcon;

		// Token: 0x04027138 RID: 160056
		[Token(Token = "0x4027138")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetGoodIcon;

		// Token: 0x04027139 RID: 160057
		[Token(Token = "0x4027139")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCustomerCountDesc;

		// Token: 0x0402713A RID: 160058
		[Token(Token = "0x402713A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfGroceryUnlock;
	}
}
