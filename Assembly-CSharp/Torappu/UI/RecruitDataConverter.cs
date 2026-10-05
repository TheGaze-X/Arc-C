using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AF3 RID: 15091
	[Token(Token = "0x2003AF3")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RecruitDataConverter
	{
		// Token: 0x06017C90 RID: 97424 RVA: 0x00098238 File Offset: 0x00096438
		[Token(Token = "0x6017C90")]
		[Address(RVA = "0x10069C0", Offset = "0x10055C0", VA = "0x1810069C0")]
		public static bool IsRecruitBuildFinish(PlayerRecruit.NormalModel.SlotModel playerBuildSlot)
		{
			return default(bool);
		}

		// Token: 0x06017C91 RID: 97425 RVA: 0x00098250 File Offset: 0x00096450
		[Token(Token = "0x6017C91")]
		[Address(RVA = "0x1008490", Offset = "0x1007090", VA = "0x181008490")]
		private static bool _CheckIfNewbeeGachaPoolAvailable(string poolId, List<string> forbiddenGachaPoolList)
		{
			return default(bool);
		}

		// Token: 0x06017C92 RID: 97426 RVA: 0x00098268 File Offset: 0x00096468
		[Token(Token = "0x6017C92")]
		[Address(RVA = "0x10049F0", Offset = "0x10035F0", VA = "0x1810049F0")]
		public static bool CheckGachaPoolAvailable(string inputPoolId)
		{
			return default(bool);
		}

		// Token: 0x06017C93 RID: 97427 RVA: 0x00098280 File Offset: 0x00096480
		[Token(Token = "0x6017C93")]
		[Address(RVA = "0x1008250", Offset = "0x1006E50", VA = "0x181008250")]
		private static bool _CheckIfCustomGachaPoolAvailable(string poolId, List<string> forbiddenGachaPoolList)
		{
			return default(bool);
		}

		// Token: 0x06017C94 RID: 97428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C94")]
		[Address(RVA = "0x1006AC0", Offset = "0x10056C0", VA = "0x181006AC0")]
		public static List<GachaPoolClientData> LoadValidGachaPools()
		{
			return null;
		}

		// Token: 0x06017C95 RID: 97429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C95")]
		[Address(RVA = "0x1006DA0", Offset = "0x10059A0", VA = "0x181006DA0")]
		public static List<NewbeeGachaPoolClientData> LoadValidNewbeeGachaPools()
		{
			return null;
		}

		// Token: 0x06017C96 RID: 97430 RVA: 0x00098298 File Offset: 0x00096498
		[Token(Token = "0x6017C96")]
		[Address(RVA = "0x1006870", Offset = "0x1005470", VA = "0x181006870")]
		public static int GetSingleGachaPrice(string gachaPoolId)
		{
			return 0;
		}

		// Token: 0x06017C97 RID: 97431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C97")]
		[Address(RVA = "0x1005B20", Offset = "0x1004720", VA = "0x181005B20")]
		public static void GetAvailGachaSpecialTicket(string gachaPoolId, out ItemData targetItem, out int targetCount)
		{
		}

		// Token: 0x06017C98 RID: 97432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C98")]
		[Address(RVA = "0x1009420", Offset = "0x1008020", VA = "0x181009420")]
		private static void _GetNextAvailLimitTenGachaTicket(out ItemData targetItem, out int targetCount)
		{
		}

		// Token: 0x06017C99 RID: 97433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C99")]
		[Address(RVA = "0x10097A0", Offset = "0x10083A0", VA = "0x1810097A0")]
		private static void _GetNextAvailLinkageTenGachaTicket(string poolId, out ItemData targetItem, out int targetCount)
		{
		}

		// Token: 0x06017C9A RID: 97434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C9A")]
		[Address(RVA = "0x1009F30", Offset = "0x1008B30", VA = "0x181009F30")]
		private static void _GetNextAvailSingleTenGachaTicket(string poolId, out ItemData targetItem, out int targetCount)
		{
		}

		// Token: 0x06017C9B RID: 97435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C9B")]
		[Address(RVA = "0x1005C60", Offset = "0x1004860", VA = "0x181005C60")]
		public static void GetAvailSingleGachaSpecialTicket(string gachaPoolId, out ItemData targetItem, out int targetCount)
		{
		}

		// Token: 0x06017C9C RID: 97436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C9C")]
		[Address(RVA = "0x1009B50", Offset = "0x1008750", VA = "0x181009B50")]
		private static void _GetNextAvailNormalGachaTicket(string poolId, out ItemData targetItem, out int targetCount)
		{
		}

		// Token: 0x06017C9D RID: 97437 RVA: 0x000982B0 File Offset: 0x000964B0
		[Token(Token = "0x6017C9D")]
		[Address(RVA = "0x10065D0", Offset = "0x10051D0", VA = "0x1810065D0")]
		public static JObjectWrapper GetPlayerLinkageParam(string gachaPoolId)
		{
			return default(JObjectWrapper);
		}

		// Token: 0x06017C9E RID: 97438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C9E")]
		[Address(RVA = "0x1006310", Offset = "0x1004F10", VA = "0x181006310")]
		public static PlayerGacha.PlayerAttainGacha GetPlayerAttainParam(string gachaPoolId)
		{
			return null;
		}

		// Token: 0x06017C9F RID: 97439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C9F")]
		[Address(RVA = "0x1006780", Offset = "0x1005380", VA = "0x181006780")]
		public static PlayerGacha.PlayerSingleGacha GetPlayerSingleParam(string gachaPoolId)
		{
			return null;
		}

		// Token: 0x06017CA0 RID: 97440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CA0")]
		[Address(RVA = "0x1006400", Offset = "0x1005000", VA = "0x181006400")]
		public static PlayerGacha.PlayerDoubleGacha GetPlayerDoubleParam(string gachaPoolId)
		{
			return null;
		}

		// Token: 0x06017CA1 RID: 97441 RVA: 0x000982C8 File Offset: 0x000964C8
		[Token(Token = "0x6017CA1")]
		[Address(RVA = "0x10085D0", Offset = "0x10071D0", VA = "0x1810085D0")]
		public static bool _CheckIfNewbeeGachaPool(string poolId)
		{
			return default(bool);
		}

		// Token: 0x06017CA2 RID: 97442 RVA: 0x000982E0 File Offset: 0x000964E0
		[Token(Token = "0x6017CA2")]
		[Address(RVA = "0x10064F0", Offset = "0x10050F0", VA = "0x1810064F0")]
		public static int GetPlayerGachaCount(string gachaPoolId)
		{
			return 0;
		}

		// Token: 0x06017CA3 RID: 97443 RVA: 0x000982F8 File Offset: 0x000964F8
		[Token(Token = "0x6017CA3")]
		[Address(RVA = "0x1006260", Offset = "0x1004E60", VA = "0x181006260")]
		public static int GetLimitGachaLeastFree(PlayerGacha playerGacha, string poolId)
		{
			return 0;
		}

		// Token: 0x06017CA4 RID: 97444 RVA: 0x00098310 File Offset: 0x00096510
		[Token(Token = "0x6017CA4")]
		[Address(RVA = "0x1005D50", Offset = "0x1004950", VA = "0x181005D50")]
		public static bool GetCanFreeRecruit(PlayerGacha playerGacha, GachaPoolClientData poolClientData)
		{
			return default(bool);
		}

		// Token: 0x06017CA5 RID: 97445 RVA: 0x00098328 File Offset: 0x00096528
		[Token(Token = "0x6017CA5")]
		[Address(RVA = "0x100A450", Offset = "0x1009050", VA = "0x18100A450")]
		private static int _GetValidClassicTicketCount(string gachaPoolId)
		{
			return 0;
		}

		// Token: 0x06017CA6 RID: 97446 RVA: 0x00098340 File Offset: 0x00096540
		[Token(Token = "0x6017CA6")]
		[Address(RVA = "0x100A310", Offset = "0x1008F10", VA = "0x18100A310")]
		private static int _GetValidClassicTenTicketCount(string gachaPoolId)
		{
			return 0;
		}

		// Token: 0x06017CA7 RID: 97447 RVA: 0x00098358 File Offset: 0x00096558
		[Token(Token = "0x6017CA7")]
		[Address(RVA = "0x1005030", Offset = "0x1003C30", VA = "0x181005030")]
		public static RecruitDataConverter.SingleGachaPolicy CheckSingleGachaPolicy(string poolId)
		{
			return default(RecruitDataConverter.SingleGachaPolicy);
		}

		// Token: 0x06017CA8 RID: 97448 RVA: 0x00098370 File Offset: 0x00096570
		[Token(Token = "0x6017CA8")]
		[Address(RVA = "0x10086D0", Offset = "0x10072D0", VA = "0x1810086D0")]
		private static RecruitDataConverter.SingleGachaPolicy _CheckSingleGachaCost(string poolId, RecruitDataConverter.SingleGachaPolicy policy)
		{
			return default(RecruitDataConverter.SingleGachaPolicy);
		}

		// Token: 0x06017CA9 RID: 97449 RVA: 0x00098388 File Offset: 0x00096588
		[Token(Token = "0x6017CA9")]
		[Address(RVA = "0x1005320", Offset = "0x1003F20", VA = "0x181005320")]
		public static RecruitDataConverter.TenGachaPolicy CheckTenGachaPolicy(string poolId)
		{
			return default(RecruitDataConverter.TenGachaPolicy);
		}

		// Token: 0x06017CAA RID: 97450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CAA")]
		[Address(RVA = "0x1008F30", Offset = "0x1007B30", VA = "0x181008F30")]
		private static List<RecruitDataConverter.CombineGachaItemWithType> _GenerateDiamondShardOnlyList(string poolId, int gachaCount)
		{
			return null;
		}

		// Token: 0x06017CAB RID: 97451 RVA: 0x000983A0 File Offset: 0x000965A0
		[Token(Token = "0x6017CAB")]
		[Address(RVA = "0x1008910", Offset = "0x1007510", VA = "0x181008910")]
		private static RecruitDataConverter.TenGachaPolicy _CheckTenGachaCost(string poolId, RecruitDataConverter.TenGachaPolicy policy)
		{
			return default(RecruitDataConverter.TenGachaPolicy);
		}

		// Token: 0x06017CAC RID: 97452 RVA: 0x000983B8 File Offset: 0x000965B8
		[Token(Token = "0x6017CAC")]
		[Address(RVA = "0x1009080", Offset = "0x1007C80", VA = "0x181009080")]
		private static RecruitDataConverter.GachaPolicyType _GetGachaPolicyType(string poolId)
		{
			return RecruitDataConverter.GachaPolicyType.NONE;
		}

		// Token: 0x06017CAD RID: 97453 RVA: 0x000983D0 File Offset: 0x000965D0
		[Token(Token = "0x6017CAD")]
		[Address(RVA = "0x100A590", Offset = "0x1009190", VA = "0x18100A590")]
		private static bool _TryCalculateCombineGachaList(string poolId, out List<RecruitDataConverter.CombineGachaItemWithType> combineItemList, out int needDSNum)
		{
			return default(bool);
		}

		// Token: 0x06017CAE RID: 97454 RVA: 0x000983E8 File Offset: 0x000965E8
		[Token(Token = "0x6017CAE")]
		[Address(RVA = "0x1007B70", Offset = "0x1006770", VA = "0x181007B70")]
		private static RecruitDataConverter.SingleGachaPolicy _CheckClassicSingleGachaCost(string poolId, RecruitDataConverter.SingleGachaPolicy policy)
		{
			return default(RecruitDataConverter.SingleGachaPolicy);
		}

		// Token: 0x06017CAF RID: 97455 RVA: 0x00098400 File Offset: 0x00096600
		[Token(Token = "0x6017CAF")]
		[Address(RVA = "0x1007CB0", Offset = "0x10068B0", VA = "0x181007CB0")]
		private static RecruitDataConverter.TenGachaPolicy _CheckClassicTenGachaCost(string poolId, RecruitDataConverter.TenGachaPolicy policy)
		{
			return default(RecruitDataConverter.TenGachaPolicy);
		}

		// Token: 0x06017CB0 RID: 97456 RVA: 0x00098418 File Offset: 0x00096618
		[Token(Token = "0x6017CB0")]
		[Address(RVA = "0x1004CD0", Offset = "0x10038D0", VA = "0x181004CD0")]
		public static bool CheckIfClassicTypeGacha(GachaPoolClientData data)
		{
			return default(bool);
		}

		// Token: 0x06017CB1 RID: 97457 RVA: 0x00098430 File Offset: 0x00096630
		[Token(Token = "0x6017CB1")]
		[Address(RVA = "0x1004FC0", Offset = "0x1003BC0", VA = "0x181004FC0")]
		public static bool CheckIfSpecialGacha(GachaPoolClientData data)
		{
			return default(bool);
		}

		// Token: 0x06017CB2 RID: 97458 RVA: 0x00098448 File Offset: 0x00096648
		[Token(Token = "0x6017CB2")]
		[Address(RVA = "0x1004E50", Offset = "0x1003A50", VA = "0x181004E50")]
		public static bool CheckIfReturnGacha(GachaPoolClientData data)
		{
			return default(bool);
		}

		// Token: 0x06017CB3 RID: 97459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CB3")]
		[Address(RVA = "0x1005780", Offset = "0x1004380", VA = "0x181005780")]
		public static List<GachaDetailData.GachaAvailChar.GachaPerAvail> GenerateSpecialGachaAvailCharList(List<GachaDetailData.GachaAvailChar.GachaPerAvail> originInfo, string poolId)
		{
			return null;
		}

		// Token: 0x06017CB4 RID: 97460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CB4")]
		[Address(RVA = "0x1005550", Offset = "0x1004150", VA = "0x181005550")]
		public static List<GachaDetailData.GachaAvailChar.GachaPerAvail> GenerateGachaAvailListWithOverrideCharId(List<GachaDetailData.GachaAvailChar.GachaPerAvail> originData, Dictionary<string, List<string>> overrideInfo)
		{
			return null;
		}

		// Token: 0x06017CB5 RID: 97461 RVA: 0x00098460 File Offset: 0x00096660
		[Token(Token = "0x6017CB5")]
		[Address(RVA = "0x1004C40", Offset = "0x1003840", VA = "0x181004C40")]
		public static bool CheckIfCanUseClassicTicket(GachaPoolClientData data)
		{
			return default(bool);
		}

		// Token: 0x06017CB6 RID: 97462 RVA: 0x00098478 File Offset: 0x00096678
		[Token(Token = "0x6017CB6")]
		[Address(RVA = "0x1004D50", Offset = "0x1003950", VA = "0x181004D50")]
		public static bool CheckIfFesClassicCharChosen(string poolId)
		{
			return default(bool);
		}

		// Token: 0x06017CB7 RID: 97463 RVA: 0x00098490 File Offset: 0x00096690
		[Token(Token = "0x6017CB7")]
		[Address(RVA = "0x1004EC0", Offset = "0x1003AC0", VA = "0x181004EC0")]
		public static bool CheckIfSpecialGachaCharChosen(string poolId)
		{
			return default(bool);
		}

		// Token: 0x06017CB8 RID: 97464 RVA: 0x000984A8 File Offset: 0x000966A8
		[Token(Token = "0x6017CB8")]
		[Address(RVA = "0x1004B40", Offset = "0x1003740", VA = "0x181004B40")]
		public static bool CheckIfBackflowCharChosen(string poolId)
		{
			return default(bool);
		}

		// Token: 0x06017CB9 RID: 97465 RVA: 0x000984C0 File Offset: 0x000966C0
		[Token(Token = "0x6017CB9")]
		[Address(RVA = "0x1007700", Offset = "0x1006300", VA = "0x181007700")]
		public static bool TryGetSpecialGachaChosenUpChars(string poolId, out GachaDetailData.GachaUpChar upChar)
		{
			return default(bool);
		}

		// Token: 0x06017CBA RID: 97466 RVA: 0x000984D8 File Offset: 0x000966D8
		[Token(Token = "0x6017CBA")]
		[Address(RVA = "0x1005EB0", Offset = "0x1004AB0", VA = "0x181005EB0")]
		public static GachaDetailData.GachaObjGroupType GetCurrentGachaObjGroupType(string poolId, GachaRuleType gachaRuleType)
		{
			return GachaDetailData.GachaObjGroupType.ALL;
		}

		// Token: 0x06017CBB RID: 97467 RVA: 0x000984F0 File Offset: 0x000966F0
		[Token(Token = "0x6017CBB")]
		[Address(RVA = "0x1007390", Offset = "0x1005F90", VA = "0x181007390")]
		public static bool TryGetFesClassicPickCharsAndSelectRule(GachaPoolClientData clientData, out RecruitDataConverter.FesClassicSelectCharInfo selectCharInfo)
		{
			return default(bool);
		}

		// Token: 0x06017CBC RID: 97468 RVA: 0x00098508 File Offset: 0x00096708
		[Token(Token = "0x6017CBC")]
		[Address(RVA = "0x1006F10", Offset = "0x1005B10", VA = "0x181006F10")]
		public static bool TryGetFesClassicChosenUpChars(string poolId, out GachaDetailData.GachaUpChar upChar)
		{
			return default(bool);
		}

		// Token: 0x06017CBD RID: 97469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CBD")]
		[Address(RVA = "0x10092B0", Offset = "0x1007EB0", VA = "0x1810092B0")]
		private static string _GetItemConstIdByType(ItemType type)
		{
			return null;
		}

		// Token: 0x06017CBE RID: 97470 RVA: 0x00098520 File Offset: 0x00096720
		[Token(Token = "0x6017CBE")]
		[Address(RVA = "0x1009360", Offset = "0x1007F60", VA = "0x181009360")]
		private static ItemType _GetItemTypeByTenGachaCost(RecruitDataConverter.TenGachaCost tenGachaCost)
		{
			return ItemType.NONE;
		}

		// Token: 0x0401CB95 RID: 117653
		[Token(Token = "0x401CB95")]
		private const string ClASSIC_FES_RARITY_PICK_CHAR_DICT = "rarityPickCharDict";

		// Token: 0x0401CB96 RID: 117654
		[Token(Token = "0x401CB96")]
		private const string FES_CLASSIC_CHOOSE_RULE_CONST = "chooseRuleConst";

		// Token: 0x0401CB97 RID: 117655
		[Token(Token = "0x401CB97")]
		private const string BOOL_HASFREECHAR = "hasFreeChar";

		// Token: 0x0401CB98 RID: 117656
		[Token(Token = "0x401CB98")]
		private const string INT_FREECOUNT = "freeCount";

		// Token: 0x0401CB99 RID: 117657
		[Token(Token = "0x401CB99")]
		private const string FES_CLASSIC_CHOSEN_PER_CHAR_PERCENT = "pickUpPerCharPercent";

		// Token: 0x0401CB9A RID: 117658
		[Token(Token = "0x401CB9A")]
		private const int TEN_GACHA_TKT_COST = 1;

		// Token: 0x0401CB9B RID: 117659
		[Token(Token = "0x401CB9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsRecruitBuildFinish;

		// Token: 0x0401CB9C RID: 117660
		[Token(Token = "0x401CB9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckIfNewbeeGachaPoolAvailable;

		// Token: 0x0401CB9D RID: 117661
		[Token(Token = "0x401CB9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckGachaPoolAvailable;

		// Token: 0x0401CB9E RID: 117662
		[Token(Token = "0x401CB9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfCustomGachaPoolAvailable;

		// Token: 0x0401CB9F RID: 117663
		[Token(Token = "0x401CB9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadValidGachaPools;

		// Token: 0x0401CBA0 RID: 117664
		[Token(Token = "0x401CBA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadValidNewbeeGachaPools;

		// Token: 0x0401CBA1 RID: 117665
		[Token(Token = "0x401CBA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSingleGachaPrice;

		// Token: 0x0401CBA2 RID: 117666
		[Token(Token = "0x401CBA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetAvailGachaSpecialTicket;

		// Token: 0x0401CBA3 RID: 117667
		[Token(Token = "0x401CBA3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetNextAvailLimitTenGachaTicket;

		// Token: 0x0401CBA4 RID: 117668
		[Token(Token = "0x401CBA4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetNextAvailLinkageTenGachaTicket;

		// Token: 0x0401CBA5 RID: 117669
		[Token(Token = "0x401CBA5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetNextAvailSingleTenGachaTicket;

		// Token: 0x0401CBA6 RID: 117670
		[Token(Token = "0x401CBA6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetAvailSingleGachaSpecialTicket;

		// Token: 0x0401CBA7 RID: 117671
		[Token(Token = "0x401CBA7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetNextAvailNormalGachaTicket;

		// Token: 0x0401CBA8 RID: 117672
		[Token(Token = "0x401CBA8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetPlayerLinkageParam;

		// Token: 0x0401CBA9 RID: 117673
		[Token(Token = "0x401CBA9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetPlayerAttainParam;

		// Token: 0x0401CBAA RID: 117674
		[Token(Token = "0x401CBAA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetPlayerSingleParam;

		// Token: 0x0401CBAB RID: 117675
		[Token(Token = "0x401CBAB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetPlayerDoubleParam;

		// Token: 0x0401CBAC RID: 117676
		[Token(Token = "0x401CBAC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckIfNewbeeGachaPool;

		// Token: 0x0401CBAD RID: 117677
		[Token(Token = "0x401CBAD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetPlayerGachaCount;

		// Token: 0x0401CBAE RID: 117678
		[Token(Token = "0x401CBAE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetLimitGachaLeastFree;

		// Token: 0x0401CBAF RID: 117679
		[Token(Token = "0x401CBAF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetCanFreeRecruit;

		// Token: 0x0401CBB0 RID: 117680
		[Token(Token = "0x401CBB0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetValidClassicTicketCount;

		// Token: 0x0401CBB1 RID: 117681
		[Token(Token = "0x401CBB1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetValidClassicTenTicketCount;

		// Token: 0x0401CBB2 RID: 117682
		[Token(Token = "0x401CBB2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckSingleGachaPolicy;

		// Token: 0x0401CBB3 RID: 117683
		[Token(Token = "0x401CBB3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CheckSingleGachaCost;

		// Token: 0x0401CBB4 RID: 117684
		[Token(Token = "0x401CBB4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CheckTenGachaPolicy;

		// Token: 0x0401CBB5 RID: 117685
		[Token(Token = "0x401CBB5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GenerateDiamondShardOnlyList;

		// Token: 0x0401CBB6 RID: 117686
		[Token(Token = "0x401CBB6")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CheckTenGachaCost;

		// Token: 0x0401CBB7 RID: 117687
		[Token(Token = "0x401CBB7")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__GetGachaPolicyType;

		// Token: 0x0401CBB8 RID: 117688
		[Token(Token = "0x401CBB8")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TryCalculateCombineGachaList;

		// Token: 0x0401CBB9 RID: 117689
		[Token(Token = "0x401CBB9")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CheckClassicSingleGachaCost;

		// Token: 0x0401CBBA RID: 117690
		[Token(Token = "0x401CBBA")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__CheckClassicTenGachaCost;

		// Token: 0x0401CBBB RID: 117691
		[Token(Token = "0x401CBBB")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckIfClassicTypeGacha;

		// Token: 0x0401CBBC RID: 117692
		[Token(Token = "0x401CBBC")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfSpecialGacha;

		// Token: 0x0401CBBD RID: 117693
		[Token(Token = "0x401CBBD")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CheckIfReturnGacha;

		// Token: 0x0401CBBE RID: 117694
		[Token(Token = "0x401CBBE")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GenerateSpecialGachaAvailCharList;

		// Token: 0x0401CBBF RID: 117695
		[Token(Token = "0x401CBBF")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GenerateGachaAvailListWithOverrideCharId;

		// Token: 0x0401CBC0 RID: 117696
		[Token(Token = "0x401CBC0")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckIfCanUseClassicTicket;

		// Token: 0x0401CBC1 RID: 117697
		[Token(Token = "0x401CBC1")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckIfFesClassicCharChosen;

		// Token: 0x0401CBC2 RID: 117698
		[Token(Token = "0x401CBC2")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckIfSpecialGachaCharChosen;

		// Token: 0x0401CBC3 RID: 117699
		[Token(Token = "0x401CBC3")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_CheckIfBackflowCharChosen;

		// Token: 0x0401CBC4 RID: 117700
		[Token(Token = "0x401CBC4")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TryGetSpecialGachaChosenUpChars;

		// Token: 0x0401CBC5 RID: 117701
		[Token(Token = "0x401CBC5")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetCurrentGachaObjGroupType;

		// Token: 0x0401CBC6 RID: 117702
		[Token(Token = "0x401CBC6")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_TryGetFesClassicPickCharsAndSelectRule;

		// Token: 0x0401CBC7 RID: 117703
		[Token(Token = "0x401CBC7")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_TryGetFesClassicChosenUpChars;

		// Token: 0x0401CBC8 RID: 117704
		[Token(Token = "0x401CBC8")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GetItemConstIdByType;

		// Token: 0x0401CBC9 RID: 117705
		[Token(Token = "0x401CBC9")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__GetItemTypeByTenGachaCost;

		// Token: 0x02003AF4 RID: 15092
		[Token(Token = "0x2003AF4")]
		public enum SingleGachaCost
		{
			// Token: 0x0401CBCB RID: 117707
			[Token(Token = "0x401CBCB")]
			DIAMOND,
			// Token: 0x0401CBCC RID: 117708
			[Token(Token = "0x401CBCC")]
			LIMIT_FREE,
			// Token: 0x0401CBCD RID: 117709
			[Token(Token = "0x401CBCD")]
			COMMON_TKT,
			// Token: 0x0401CBCE RID: 117710
			[Token(Token = "0x401CBCE")]
			CLASSIC_TKT,
			// Token: 0x0401CBCF RID: 117711
			[Token(Token = "0x401CBCF")]
			LIMIT_TICKET
		}

		// Token: 0x02003AF5 RID: 15093
		[Token(Token = "0x2003AF5")]
		public struct SingleGachaPolicy
		{
			// Token: 0x0401CBD0 RID: 117712
			[Token(Token = "0x401CBD0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RecruitDataConverter.SingleGachaPolicy DEFAULT;

			// Token: 0x0401CBD1 RID: 117713
			[Token(Token = "0x401CBD1")]
			[FieldOffset(Offset = "0x20")]
			public static readonly RecruitDataConverter.SingleGachaPolicy NEWBEE;

			// Token: 0x0401CBD2 RID: 117714
			[Token(Token = "0x401CBD2")]
			[FieldOffset(Offset = "0x0")]
			public bool isNewbee;

			// Token: 0x0401CBD3 RID: 117715
			[Token(Token = "0x401CBD3")]
			[FieldOffset(Offset = "0x4")]
			public RecruitDataConverter.SingleGachaCost cost;

			// Token: 0x0401CBD4 RID: 117716
			[Token(Token = "0x401CBD4")]
			[FieldOffset(Offset = "0x8")]
			public int limitLeastFree;

			// Token: 0x0401CBD5 RID: 117717
			[Token(Token = "0x401CBD5")]
			[FieldOffset(Offset = "0xC")]
			public int limitTktCount;

			// Token: 0x0401CBD6 RID: 117718
			[Token(Token = "0x401CBD6")]
			[FieldOffset(Offset = "0x10")]
			public string limitTktId;

			// Token: 0x0401CBD7 RID: 117719
			[Token(Token = "0x401CBD7")]
			[FieldOffset(Offset = "0x18")]
			public ItemType limitTktType;
		}

		// Token: 0x02003AF6 RID: 15094
		[Token(Token = "0x2003AF6")]
		public enum TenGachaCost
		{
			// Token: 0x0401CBD9 RID: 117721
			[Token(Token = "0x401CBD9")]
			DIAMOND,
			// Token: 0x0401CBDA RID: 117722
			[Token(Token = "0x401CBDA")]
			LIMIT_TKT,
			// Token: 0x0401CBDB RID: 117723
			[Token(Token = "0x401CBDB")]
			COMMON_TKT,
			// Token: 0x0401CBDC RID: 117724
			[Token(Token = "0x401CBDC")]
			SINGLE_10,
			// Token: 0x0401CBDD RID: 117725
			[Token(Token = "0x401CBDD")]
			CLASSIC_TKT,
			// Token: 0x0401CBDE RID: 117726
			[Token(Token = "0x401CBDE")]
			CLASSIC_10,
			// Token: 0x0401CBDF RID: 117727
			[Token(Token = "0x401CBDF")]
			LIMIT_10,
			// Token: 0x0401CBE0 RID: 117728
			[Token(Token = "0x401CBE0")]
			COMBINE_10,
			// Token: 0x0401CBE1 RID: 117729
			[Token(Token = "0x401CBE1")]
			COMBINE_10_WITH_DIAMOND
		}

		// Token: 0x02003AF7 RID: 15095
		[Token(Token = "0x2003AF7")]
		public struct TenGachaPolicy
		{
			// Token: 0x170038F7 RID: 14583
			// (get) Token: 0x06017CC0 RID: 97472 RVA: 0x00098538 File Offset: 0x00096738
			[Token(Token = "0x170038F7")]
			public int usedDiamondShardNum
			{
				[Token(Token = "0x6017CC0")]
				[Address(RVA = "0x100E3E0", Offset = "0x100CFE0", VA = "0x18100E3E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0401CBE2 RID: 117730
			[Token(Token = "0x401CBE2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RecruitDataConverter.TenGachaPolicy DEFAULT;

			// Token: 0x0401CBE3 RID: 117731
			[Token(Token = "0x401CBE3")]
			[FieldOffset(Offset = "0x10")]
			public static readonly RecruitDataConverter.TenGachaPolicy NEWBEE;

			// Token: 0x0401CBE4 RID: 117732
			[Token(Token = "0x401CBE4")]
			[FieldOffset(Offset = "0x0")]
			public bool isNewbee;

			// Token: 0x0401CBE5 RID: 117733
			[Token(Token = "0x401CBE5")]
			[FieldOffset(Offset = "0x4")]
			public RecruitDataConverter.TenGachaCost cost;

			// Token: 0x0401CBE6 RID: 117734
			[Token(Token = "0x401CBE6")]
			[FieldOffset(Offset = "0x8")]
			public List<RecruitDataConverter.CombineGachaItemWithType> combineItemList;
		}

		// Token: 0x02003AF8 RID: 15096
		[Token(Token = "0x2003AF8")]
		private enum GachaPolicyType
		{
			// Token: 0x0401CBE8 RID: 117736
			[Token(Token = "0x401CBE8")]
			NONE,
			// Token: 0x0401CBE9 RID: 117737
			[Token(Token = "0x401CBE9")]
			NORMAL,
			// Token: 0x0401CBEA RID: 117738
			[Token(Token = "0x401CBEA")]
			NEWBEE,
			// Token: 0x0401CBEB RID: 117739
			[Token(Token = "0x401CBEB")]
			CLASSIC
		}

		// Token: 0x02003AF9 RID: 15097
		[Token(Token = "0x2003AF9")]
		public struct FesClassicSelectCharInfo
		{
			// Token: 0x0401CBEC RID: 117740
			[Token(Token = "0x401CBEC")]
			[FieldOffset(Offset = "0x0")]
			public List<string> rarity5Chars;

			// Token: 0x0401CBED RID: 117741
			[Token(Token = "0x401CBED")]
			[FieldOffset(Offset = "0x8")]
			public List<string> rarity6Chars;

			// Token: 0x0401CBEE RID: 117742
			[Token(Token = "0x401CBEE")]
			[FieldOffset(Offset = "0x10")]
			public string selectRuleText;
		}

		// Token: 0x02003AFA RID: 15098
		[Token(Token = "0x2003AFA")]
		public class CombineGachaItemWithType
		{
			// Token: 0x06017CC2 RID: 97474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CC2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CombineGachaItemWithType()
			{
			}

			// Token: 0x0401CBEF RID: 117743
			[Token(Token = "0x401CBEF")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0401CBF0 RID: 117744
			[Token(Token = "0x401CBF0")]
			[FieldOffset(Offset = "0x18")]
			public int count;

			// Token: 0x0401CBF1 RID: 117745
			[Token(Token = "0x401CBF1")]
			[FieldOffset(Offset = "0x1C")]
			public ItemType type;
		}
	}
}
