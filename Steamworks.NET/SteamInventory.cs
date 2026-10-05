using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public static class SteamInventory
	{
		// Token: 0x06000281 RID: 641 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x4EC5EF0", Offset = "0x4EC4AF0", VA = "0x184EC5EF0")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00004F7C File Offset: 0x0000317C
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x4EC5E10", Offset = "0x4EC4A10", VA = "0x184EC5E10")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00004F94 File Offset: 0x00003194
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x4EC5C30", Offset = "0x4EC4830", VA = "0x184EC5C30")]
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00004FAC File Offset: 0x000031AC
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x4EC5F40", Offset = "0x4EC4B40", VA = "0x184EC5F40")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return 0U;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x4EC5240", Offset = "0x4EC3E40", VA = "0x184EC5240")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x4EC53B0", Offset = "0x4EC3FB0", VA = "0x184EC53B0")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00004FDC File Offset: 0x000031DC
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x4EC5540", Offset = "0x4EC4140", VA = "0x184EC5540")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x4EC59A0", Offset = "0x4EC45A0", VA = "0x184EC59A0")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4EC6430", Offset = "0x4EC5030", VA = "0x184EC6430")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00005024 File Offset: 0x00003224
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4EC5320", Offset = "0x4EC3F20", VA = "0x184EC5320")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x4EC54B0", Offset = "0x4EC40B0", VA = "0x184EC54B0")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x4EC5F90", Offset = "0x4EC4B90", VA = "0x184EC5F90")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x4EC5160", Offset = "0x4EC3D60", VA = "0x184EC5160")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x4EC51C0", Offset = "0x4EC3DC0", VA = "0x184EC51C0")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000509C File Offset: 0x0000329C
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4EC52A0", Offset = "0x4EC3EA0", VA = "0x184EC52A0")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x4EC5400", Offset = "0x4EC4000", VA = "0x184EC5400")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x4EC6D10", Offset = "0x4EC5910", VA = "0x184EC6D10")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4EC63E0", Offset = "0x4EC4FE0", VA = "0x184EC63E0")]
		public static void SendItemDropHeartbeat()
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x4EC6DA0", Offset = "0x4EC59A0", VA = "0x184EC6DA0")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000050FC File Offset: 0x000032FC
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4EC6C50", Offset = "0x4EC5850", VA = "0x184EC6C50")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4EC6120", Offset = "0x4EC4D20", VA = "0x184EC6120")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4EC5680", Offset = "0x4EC4280", VA = "0x184EC5680")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00005144 File Offset: 0x00003344
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4EC5750", Offset = "0x4EC4350", VA = "0x184EC5750")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000515C File Offset: 0x0000335C
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x4EC62C0", Offset = "0x4EC4EC0", VA = "0x184EC62C0")]
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x4EC55A0", Offset = "0x4EC41A0", VA = "0x184EC55A0")]
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x4EC6AA0", Offset = "0x4EC56A0", VA = "0x184EC6AA0")]
		public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000051A4 File Offset: 0x000033A4
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x4EC6350", Offset = "0x4EC4F50", VA = "0x184EC6350")]
		public static SteamAPICall_t RequestPrices()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x4EC5BE0", Offset = "0x4EC47E0", VA = "0x184EC5BE0")]
		public static uint GetNumItemsWithPrices()
		{
			return 0U;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000051D4 File Offset: 0x000033D4
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x4EC5A20", Offset = "0x4EC4620", VA = "0x184EC5A20")]
		public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength)
		{
			return default(bool);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x4EC5920", Offset = "0x4EC4520", VA = "0x184EC5920")]
		public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice)
		{
			return default(bool);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00005204 File Offset: 0x00003404
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x4EC6B60", Offset = "0x4EC5760", VA = "0x184EC6B60")]
		public static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4EC6170", Offset = "0x4EC4D70", VA = "0x184EC6170")]
		public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName)
		{
			return default(bool);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x4EC64B0", Offset = "0x4EC50B0", VA = "0x184EC64B0")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue)
		{
			return default(bool);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x4EC67F0", Offset = "0x4EC53F0", VA = "0x184EC67F0")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00005264 File Offset: 0x00003464
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4EC66A0", Offset = "0x4EC52A0", VA = "0x184EC66A0")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue)
		{
			return default(bool);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000527C File Offset: 0x0000347C
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x4EC6940", Offset = "0x4EC5540", VA = "0x184EC6940")]
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue)
		{
			return default(bool);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x4EC6BF0", Offset = "0x4EC57F0", VA = "0x184EC6BF0")]
		public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4EC5FF0", Offset = "0x4EC4BF0", VA = "0x184EC5FF0")]
		public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			return default(bool);
		}
	}
}
