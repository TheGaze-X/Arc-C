using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public static class SteamGameServerInventory
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x4EB4CC0", Offset = "0x4EB38C0", VA = "0x184EB4CC0")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4EB4BE0", Offset = "0x4EB37E0", VA = "0x184EB4BE0")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4EB4A10", Offset = "0x4EB3610", VA = "0x184EB4A10")]
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4EB4D10", Offset = "0x4EB3910", VA = "0x184EB4D10")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return 0U;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003284 File Offset: 0x00001484
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4EB4050", Offset = "0x4EB2C50", VA = "0x184EB4050")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4EB41C0", Offset = "0x4EB2DC0", VA = "0x184EB41C0")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4EB4350", Offset = "0x4EB2F50", VA = "0x184EB4350")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4EB4790", Offset = "0x4EB3390", VA = "0x184EB4790")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000032CC File Offset: 0x000014CC
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4EB51E0", Offset = "0x4EB3DE0", VA = "0x184EB51E0")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4EB4130", Offset = "0x4EB2D30", VA = "0x184EB4130")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4EB42C0", Offset = "0x4EB2EC0", VA = "0x184EB42C0")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4EB4D60", Offset = "0x4EB3960", VA = "0x184EB4D60")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4EB3F70", Offset = "0x4EB2B70", VA = "0x184EB3F70")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4EB3FD0", Offset = "0x4EB2BD0", VA = "0x184EB3FD0")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4EB40B0", Offset = "0x4EB2CB0", VA = "0x184EB40B0")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4EB4210", Offset = "0x4EB2E10", VA = "0x184EB4210")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4EB5AC0", Offset = "0x4EB46C0", VA = "0x184EB5AC0")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4EB5190", Offset = "0x4EB3D90", VA = "0x184EB5190")]
		public static void SendItemDropHeartbeat()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x4EB5B50", Offset = "0x4EB4750", VA = "0x184EB5B50")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4EB5A00", Offset = "0x4EB4600", VA = "0x184EB5A00")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x4EB4EE0", Offset = "0x4EB3AE0", VA = "0x184EB4EE0")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000033EC File Offset: 0x000015EC
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4EB4480", Offset = "0x4EB3080", VA = "0x184EB4480")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x4EB4540", Offset = "0x4EB3140", VA = "0x184EB4540")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4EB5070", Offset = "0x4EB3C70", VA = "0x184EB5070")]
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4EB43A0", Offset = "0x4EB2FA0", VA = "0x184EB43A0")]
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4EB5850", Offset = "0x4EB4450", VA = "0x184EB5850")]
		public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4EB5100", Offset = "0x4EB3D00", VA = "0x184EB5100")]
		public static SteamAPICall_t RequestPrices()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4EB49C0", Offset = "0x4EB35C0", VA = "0x184EB49C0")]
		public static uint GetNumItemsWithPrices()
		{
			return 0U;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4EB4810", Offset = "0x4EB3410", VA = "0x184EB4810")]
		public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4EB4710", Offset = "0x4EB3310", VA = "0x184EB4710")]
		public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice)
		{
			return default(bool);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4EB5910", Offset = "0x4EB4510", VA = "0x184EB5910")]
		public static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4EB4F30", Offset = "0x4EB3B30", VA = "0x184EB4F30")]
		public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName)
		{
			return default(bool);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4EB5260", Offset = "0x4EB3E60", VA = "0x184EB5260")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue)
		{
			return default(bool);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4EB5700", Offset = "0x4EB4300", VA = "0x184EB5700")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue)
		{
			return default(bool);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4EB55B0", Offset = "0x4EB41B0", VA = "0x184EB55B0")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue)
		{
			return default(bool);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4EB5450", Offset = "0x4EB4050", VA = "0x184EB5450")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue)
		{
			return default(bool);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4EB59A0", Offset = "0x4EB45A0", VA = "0x184EB59A0")]
		public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4EB4DB0", Offset = "0x4EB39B0", VA = "0x184EB4DB0")]
		public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			return default(bool);
		}
	}
}
