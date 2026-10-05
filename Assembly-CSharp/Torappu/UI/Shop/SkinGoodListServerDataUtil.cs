using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B5D RID: 23389
	[Token(Token = "0x2005B5D")]
	public class SkinGoodListServerDataUtil : Singleton<SkinGoodListServerDataUtil>
	{
		// Token: 0x06021F32 RID: 139058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F32")]
		[Address(RVA = "0x1C7AA20", Offset = "0x1C79620", VA = "0x181C7AA20")]
		private SkinGoodListServerDataUtil()
		{
		}

		// Token: 0x06021F33 RID: 139059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F33")]
		[Address(RVA = "0x1C7A320", Offset = "0x1C78F20", VA = "0x181C7A320")]
		public static void LoadShopSkinData(string charId, ref List<ShopSkinItemViewModel> result)
		{
		}

		// Token: 0x06021F34 RID: 139060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F34")]
		[Address(RVA = "0x1C7A0F0", Offset = "0x1C78CF0", VA = "0x181C7A0F0")]
		public static void LoadShopSkinData(HashSet<string> onShowSkinIds, ref List<ShopSkinItemViewModel> result)
		{
		}

		// Token: 0x06021F35 RID: 139061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021F35")]
		[Address(RVA = "0x1C79FF0", Offset = "0x1C78BF0", VA = "0x181C79FF0")]
		public static List<ShopSkinItemViewModel> GetAllShopSkinData()
		{
			return null;
		}

		// Token: 0x06021F36 RID: 139062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F36")]
		[Address(RVA = "0x1C79F60", Offset = "0x1C78B60", VA = "0x181C79F60")]
		public static void ClearCacheAfterBuySkin()
		{
		}

		// Token: 0x06021F37 RID: 139063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F37")]
		[Address(RVA = "0x1C7A5C0", Offset = "0x1C791C0", VA = "0x181C7A5C0")]
		public static void ResetDataInSkinShop(GetSkinGoodListResponse response)
		{
		}

		// Token: 0x06021F38 RID: 139064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F38")]
		[Address(RVA = "0x1C7A530", Offset = "0x1C79130", VA = "0x181C7A530")]
		public static void RequestSkinGoodListIfNeeded(Action onFinished)
		{
		}

		// Token: 0x06021F39 RID: 139065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F39")]
		[Address(RVA = "0x1C7A6F0", Offset = "0x1C792F0", VA = "0x181C7A6F0")]
		private void _RequestSkinGoodListIfNeeded(Action onFinished)
		{
		}

		// Token: 0x0402E824 RID: 190500
		[Token(Token = "0x402E824")]
		[FieldOffset(Offset = "0x10")]
		private SkinGoodListDataFromServer m_goodListDataFromServer;

		// Token: 0x0402E825 RID: 190501
		[Token(Token = "0x402E825")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402E826 RID: 190502
		[Token(Token = "0x402E826")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadShopSkinData;

		// Token: 0x0402E827 RID: 190503
		[Token(Token = "0x402E827")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_LoadShopSkinData;

		// Token: 0x0402E828 RID: 190504
		[Token(Token = "0x402E828")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAllShopSkinData;

		// Token: 0x0402E829 RID: 190505
		[Token(Token = "0x402E829")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearCacheAfterBuySkin;

		// Token: 0x0402E82A RID: 190506
		[Token(Token = "0x402E82A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetDataInSkinShop;

		// Token: 0x0402E82B RID: 190507
		[Token(Token = "0x402E82B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RequestSkinGoodListIfNeeded;

		// Token: 0x0402E82C RID: 190508
		[Token(Token = "0x402E82C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RequestSkinGoodListIfNeeded;
	}
}
