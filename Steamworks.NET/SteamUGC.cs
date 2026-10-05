using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public static class SteamUGC
	{
		// Token: 0x060003DD RID: 989 RVA: 0x00006B84 File Offset: 0x00004D84
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x4ED39F0", Offset = "0x4ED25F0", VA = "0x184ED39F0")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00006B9C File Offset: 0x00004D9C
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x4ED36E0", Offset = "0x4ED22E0", VA = "0x184ED36E0")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00006BB4 File Offset: 0x00004DB4
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x4ED37B0", Offset = "0x4ED23B0", VA = "0x184ED37B0")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, [Optional] string pchCursor)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00006BCC File Offset: 0x00004DCC
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x4ED3950", Offset = "0x4ED2550", VA = "0x184ED3950")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x4ED5510", Offset = "0x4ED4110", VA = "0x184ED5510")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00006BFC File Offset: 0x00004DFC
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x4ED4930", Offset = "0x4ED3530", VA = "0x184ED4930")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00006C14 File Offset: 0x00004E14
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x4ED47C0", Offset = "0x4ED33C0", VA = "0x184ED47C0")]
		public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00006C2C File Offset: 0x00004E2C
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x4ED4B70", Offset = "0x4ED3770", VA = "0x184ED4B70")]
		public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00006C44 File Offset: 0x00004E44
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x4ED4A40", Offset = "0x4ED3640", VA = "0x184ED4A40")]
		public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00006C5C File Offset: 0x00004E5C
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x4ED4820", Offset = "0x4ED3420", VA = "0x184ED4820")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00006C74 File Offset: 0x00004E74
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x4ED45F0", Offset = "0x4ED31F0", VA = "0x184ED45F0")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00006C8C File Offset: 0x00004E8C
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x4ED4110", Offset = "0x4ED2D10", VA = "0x184ED4110")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x4ED49B0", Offset = "0x4ED35B0", VA = "0x184ED49B0")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00006CBC File Offset: 0x00004EBC
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x4ED4700", Offset = "0x4ED3300", VA = "0x184ED4700")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00006CD4 File Offset: 0x00004ED4
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x4ED3F70", Offset = "0x4ED2B70", VA = "0x184ED3F70")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00006CEC File Offset: 0x00004EEC
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x4ED4760", Offset = "0x4ED3360", VA = "0x184ED4760")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00006D04 File Offset: 0x00004F04
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x4ED4460", Offset = "0x4ED3060", VA = "0x184ED4460")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00006D1C File Offset: 0x00004F1C
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x4ED4290", Offset = "0x4ED2E90", VA = "0x184ED4290")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00006D34 File Offset: 0x00004F34
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x4ED3F10", Offset = "0x4ED2B10", VA = "0x184ED3F10")]
		public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00006D4C File Offset: 0x00004F4C
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x4ED4D00", Offset = "0x4ED3900", VA = "0x184ED4D00")]
		public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize)
		{
			return default(bool);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00006D64 File Offset: 0x00004F64
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x4ED41A0", Offset = "0x4ED2DA0", VA = "0x184ED41A0")]
		public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries)
		{
			return 0U;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00006D7C File Offset: 0x00004F7C
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x4ED5000", Offset = "0x4ED3C00", VA = "0x184ED5000")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00006D94 File Offset: 0x00004F94
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x4ED33E0", Offset = "0x4ED1FE0", VA = "0x184ED33E0")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00006DAC File Offset: 0x00004FAC
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x4ED3320", Offset = "0x4ED1F20", VA = "0x184ED3320")]
		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups)
		{
			return default(bool);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x4ED2B40", Offset = "0x4ED1740", VA = "0x184ED2B40")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00006DDC File Offset: 0x00004FDC
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x4ED65F0", Offset = "0x4ED51F0", VA = "0x184ED65F0")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00006DF4 File Offset: 0x00004FF4
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x4ED64D0", Offset = "0x4ED50D0", VA = "0x184ED64D0")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00006E0C File Offset: 0x0000500C
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4ED6530", Offset = "0x4ED5130", VA = "0x184ED6530")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00006E24 File Offset: 0x00005024
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x4ED6590", Offset = "0x4ED5190", VA = "0x184ED6590")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00006E3C File Offset: 0x0000503C
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4ED6470", Offset = "0x4ED5070", VA = "0x184ED6470")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00006E54 File Offset: 0x00005054
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x4ED6410", Offset = "0x4ED5010", VA = "0x184ED6410")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00006E6C File Offset: 0x0000506C
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x4ED66B0", Offset = "0x4ED52B0", VA = "0x184ED66B0")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00006E84 File Offset: 0x00005084
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x4ED6650", Offset = "0x4ED5250", VA = "0x184ED6650")]
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00006E9C File Offset: 0x0000509C
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x4ED6050", Offset = "0x4ED4C50", VA = "0x184ED6050")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00006EB4 File Offset: 0x000050B4
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x4ED5600", Offset = "0x4ED4200", VA = "0x184ED5600")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00006ECC File Offset: 0x000050CC
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x4ED55A0", Offset = "0x4ED41A0", VA = "0x184ED55A0")]
		public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery)
		{
			return default(bool);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00006EE4 File Offset: 0x000050E4
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x4ED56C0", Offset = "0x4ED42C0", VA = "0x184ED56C0")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00006EFC File Offset: 0x000050FC
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x4ED6180", Offset = "0x4ED4D80", VA = "0x184ED6180")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00006F14 File Offset: 0x00005114
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x4ED6710", Offset = "0x4ED5310", VA = "0x184ED6710")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00006F2C File Offset: 0x0000512C
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x4ED61E0", Offset = "0x4ED4DE0", VA = "0x184ED61E0")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00006F44 File Offset: 0x00005144
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x4ED6840", Offset = "0x4ED5440", VA = "0x184ED6840")]
		public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00006F5C File Offset: 0x0000515C
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x4ED68C0", Offset = "0x4ED54C0", VA = "0x184ED68C0")]
		public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00006F74 File Offset: 0x00005174
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x4ED3150", Offset = "0x4ED1D50", VA = "0x184ED3150")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00006F8C File Offset: 0x0000518C
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x4ED5470", Offset = "0x4ED4070", VA = "0x184ED5470")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00006FA4 File Offset: 0x000051A4
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x4ED3640", Offset = "0x4ED2240", VA = "0x184ED3640")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00006FBC File Offset: 0x000051BC
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x4ED6A30", Offset = "0x4ED5630", VA = "0x184ED6A30")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00006FD4 File Offset: 0x000051D4
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x4ED5D90", Offset = "0x4ED4990", VA = "0x184ED5D90")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00006FEC File Offset: 0x000051EC
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x4ED5920", Offset = "0x4ED4520", VA = "0x184ED5920")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00007004 File Offset: 0x00005204
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x4ED5EC0", Offset = "0x4ED4AC0", VA = "0x184ED5EC0")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000701C File Offset: 0x0000521C
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x4ED5A50", Offset = "0x4ED4650", VA = "0x184ED5A50")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00007034 File Offset: 0x00005234
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x4ED5FF0", Offset = "0x4ED4BF0", VA = "0x184ED5FF0")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000704C File Offset: 0x0000524C
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x4ED5CB0", Offset = "0x4ED48B0", VA = "0x184ED5CB0")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags, bool bAllowAdminTags = false)
		{
			return default(bool);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00007064 File Offset: 0x00005264
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x4ED57F0", Offset = "0x4ED43F0", VA = "0x184ED57F0")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000707C File Offset: 0x0000527C
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x4ED5B80", Offset = "0x4ED4780", VA = "0x184ED5B80")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00007094 File Offset: 0x00005294
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x4ED5660", Offset = "0x4ED4260", VA = "0x184ED5660")]
		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
		{
			return default(bool);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000070AC File Offset: 0x000052AC
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x4ED5050", Offset = "0x4ED3C50", VA = "0x184ED5050")]
		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000070C4 File Offset: 0x000052C4
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x4ED52E0", Offset = "0x4ED3EE0", VA = "0x184ED52E0")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000070DC File Offset: 0x000052DC
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x4ED2C70", Offset = "0x4ED1870", VA = "0x184ED2C70")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000070F4 File Offset: 0x000052F4
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x4ED2E40", Offset = "0x4ED1A40", VA = "0x184ED2E40")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000710C File Offset: 0x0000530C
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x4ED2F80", Offset = "0x4ED1B80", VA = "0x184ED2F80")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00007124 File Offset: 0x00005324
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x4ED6F70", Offset = "0x4ED5B70", VA = "0x184ED6F70")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000713C File Offset: 0x0000533C
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x4ED70B0", Offset = "0x4ED5CB0", VA = "0x184ED70B0")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00007154 File Offset: 0x00005354
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x4ED5410", Offset = "0x4ED4010", VA = "0x184ED5410")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000716C File Offset: 0x0000536C
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x4ED2A40", Offset = "0x4ED1640", VA = "0x184ED2A40")]
		public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid)
		{
			return default(bool);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00007184 File Offset: 0x00005384
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x4ED5140", Offset = "0x4ED3D40", VA = "0x184ED5140")]
		public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid)
		{
			return default(bool);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000719C File Offset: 0x0000539C
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x4ED6240", Offset = "0x4ED4E40", VA = "0x184ED6240")]
		public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax)
		{
			return default(bool);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000071B4 File Offset: 0x000053B4
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x4ED6CA0", Offset = "0x4ED58A0", VA = "0x184ED6CA0")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000071CC File Offset: 0x000053CC
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x4ED3E40", Offset = "0x4ED2A40", VA = "0x184ED3E40")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return EItemUpdateStatus.k_EItemUpdateStatusInvalid;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000071E4 File Offset: 0x000053E4
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4ED6940", Offset = "0x4ED5540", VA = "0x184ED6940")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000071FC File Offset: 0x000053FC
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x4ED4EE0", Offset = "0x4ED3AE0", VA = "0x184ED4EE0")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00007214 File Offset: 0x00005414
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x4ED30B0", Offset = "0x4ED1CB0", VA = "0x184ED30B0")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000722C File Offset: 0x0000542C
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x4ED5240", Offset = "0x4ED3E40", VA = "0x184ED5240")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00007244 File Offset: 0x00005444
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x4ED6E00", Offset = "0x4ED5A00", VA = "0x184ED6E00")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000725C File Offset: 0x0000545C
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x4ED6EE0", Offset = "0x4ED5AE0", VA = "0x184ED6EE0")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00007274 File Offset: 0x00005474
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x4ED3EC0", Offset = "0x4ED2AC0", VA = "0x184ED3EC0")]
		public static uint GetNumSubscribedItems()
		{
			return 0U;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000728C File Offset: 0x0000548C
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x4ED4CA0", Offset = "0x4ED38A0", VA = "0x184ED4CA0")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return 0U;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000072A4 File Offset: 0x000054A4
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x4ED3DF0", Offset = "0x4ED29F0", VA = "0x184ED3DF0")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return 0U;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000072BC File Offset: 0x000054BC
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x4ED3CD0", Offset = "0x4ED28D0", VA = "0x184ED3CD0")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000072D4 File Offset: 0x000054D4
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x4ED3C50", Offset = "0x4ED2850", VA = "0x184ED3C50")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000072EC File Offset: 0x000054EC
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x4ED3B60", Offset = "0x4ED2760", VA = "0x184ED3B60")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00007304 File Offset: 0x00005504
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x4ED3510", Offset = "0x4ED2110", VA = "0x184ED3510")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x4ED6E90", Offset = "0x4ED5A90", VA = "0x184ED6E90")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000731C File Offset: 0x0000551C
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x4ED6AD0", Offset = "0x4ED56D0", VA = "0x184ED6AD0")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00007334 File Offset: 0x00005534
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x4ED6C00", Offset = "0x4ED5800", VA = "0x184ED6C00")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000734C File Offset: 0x0000554C
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x4ED6B70", Offset = "0x4ED5770", VA = "0x184ED6B70")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00007364 File Offset: 0x00005564
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x4ED2AA0", Offset = "0x4ED16A0", VA = "0x184ED2AA0")]
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000737C File Offset: 0x0000557C
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x4ED51A0", Offset = "0x4ED3DA0", VA = "0x184ED51A0")]
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00007394 File Offset: 0x00005594
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x4ED29A0", Offset = "0x4ED15A0", VA = "0x184ED29A0")]
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000073AC File Offset: 0x000055AC
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x4ED50A0", Offset = "0x4ED3CA0", VA = "0x184ED50A0")]
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000073C4 File Offset: 0x000055C4
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x4ED3BC0", Offset = "0x4ED27C0", VA = "0x184ED3BC0")]
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000073DC File Offset: 0x000055DC
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x4ED3AD0", Offset = "0x4ED26D0", VA = "0x184ED3AD0")]
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000073F4 File Offset: 0x000055F4
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x4ED69E0", Offset = "0x4ED55E0", VA = "0x184ED69E0")]
		public static bool ShowWorkshopEULA()
		{
			return default(bool);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000740C File Offset: 0x0000560C
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x4ED4F70", Offset = "0x4ED3B70", VA = "0x184ED4F70")]
		public static SteamAPICall_t GetWorkshopEULAStatus()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00007424 File Offset: 0x00005624
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x4ED4E80", Offset = "0x4ED3A80", VA = "0x184ED4E80")]
		public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries)
		{
			return 0U;
		}
	}
}
