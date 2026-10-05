using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public static class SteamGameServerUGC
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4EBAB40", Offset = "0x4EB9740", VA = "0x184EBAB40")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4EBA830", Offset = "0x4EB9430", VA = "0x184EBA830")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4EBA900", Offset = "0x4EB9500", VA = "0x184EBA900")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, [Optional] string pchCursor)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4EBAAA0", Offset = "0x4EB96A0", VA = "0x184EBAAA0")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4EBC660", Offset = "0x4EBB260", VA = "0x184EBC660")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x4EBBA80", Offset = "0x4EBA680", VA = "0x184EBBA80")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4EBB910", Offset = "0x4EBA510", VA = "0x184EBB910")]
		public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x4EBBCC0", Offset = "0x4EBA8C0", VA = "0x184EBBCC0")]
		public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4EBBB90", Offset = "0x4EBA790", VA = "0x184EBBB90")]
		public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4EBB970", Offset = "0x4EBA570", VA = "0x184EBB970")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4EBB740", Offset = "0x4EBA340", VA = "0x184EBB740")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4EBB260", Offset = "0x4EB9E60", VA = "0x184EBB260")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4EBBB00", Offset = "0x4EBA700", VA = "0x184EBBB00")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4EBB850", Offset = "0x4EBA450", VA = "0x184EBB850")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4EBB0C0", Offset = "0x4EB9CC0", VA = "0x184EBB0C0")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4EBB8B0", Offset = "0x4EBA4B0", VA = "0x184EBB8B0")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4EBB3E0", Offset = "0x4EB9FE0", VA = "0x184EBB3E0")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4EBB570", Offset = "0x4EBA170", VA = "0x184EBB570")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4EBB060", Offset = "0x4EB9C60", VA = "0x184EBB060")]
		public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index)
		{
			return 0U;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4EBBE50", Offset = "0x4EBAA50", VA = "0x184EBBE50")]
		public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize)
		{
			return default(bool);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4EBB2F0", Offset = "0x4EB9EF0", VA = "0x184EBB2F0")]
		public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries)
		{
			return 0U;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x4EBC150", Offset = "0x4EBAD50", VA = "0x184EBC150")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000410C File Offset: 0x0000230C
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4EBA530", Offset = "0x4EB9130", VA = "0x184EBA530")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4EBA470", Offset = "0x4EB9070", VA = "0x184EBA470")]
		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups)
		{
			return default(bool);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4EB9C90", Offset = "0x4EB8890", VA = "0x184EB9C90")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4EBD740", Offset = "0x4EBC340", VA = "0x184EBD740")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4EBD620", Offset = "0x4EBC220", VA = "0x184EBD620")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4EBD680", Offset = "0x4EBC280", VA = "0x184EBD680")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4EBD6E0", Offset = "0x4EBC2E0", VA = "0x184EBD6E0")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4EBD5C0", Offset = "0x4EBC1C0", VA = "0x184EBD5C0")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4EBD560", Offset = "0x4EBC160", VA = "0x184EBD560")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4EBD800", Offset = "0x4EBC400", VA = "0x184EBD800")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4EBD7A0", Offset = "0x4EBC3A0", VA = "0x184EBD7A0")]
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4EBD1A0", Offset = "0x4EBBDA0", VA = "0x184EBD1A0")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4EBC750", Offset = "0x4EBB350", VA = "0x184EBC750")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4EBC6F0", Offset = "0x4EBB2F0", VA = "0x184EBC6F0")]
		public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery)
		{
			return default(bool);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4EBC810", Offset = "0x4EBB410", VA = "0x184EBC810")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4EBD2D0", Offset = "0x4EBBED0", VA = "0x184EBD2D0")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4EBD860", Offset = "0x4EBC460", VA = "0x184EBD860")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4EBD330", Offset = "0x4EBBF30", VA = "0x184EBD330")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4EBD990", Offset = "0x4EBC590", VA = "0x184EBD990")]
		public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4EBDA10", Offset = "0x4EBC610", VA = "0x184EBDA10")]
		public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd)
		{
			return default(bool);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4EBA2A0", Offset = "0x4EB8EA0", VA = "0x184EBA2A0")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4EBC5C0", Offset = "0x4EBB1C0", VA = "0x184EBC5C0")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4EBA790", Offset = "0x4EB9390", VA = "0x184EBA790")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4EBDB80", Offset = "0x4EBC780", VA = "0x184EBDB80")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4EBCEE0", Offset = "0x4EBBAE0", VA = "0x184EBCEE0")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004364 File Offset: 0x00002564
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4EBCA70", Offset = "0x4EBB670", VA = "0x184EBCA70")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000437C File Offset: 0x0000257C
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4EBD010", Offset = "0x4EBBC10", VA = "0x184EBD010")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4EBCBA0", Offset = "0x4EBB7A0", VA = "0x184EBCBA0")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x4EBD140", Offset = "0x4EBBD40", VA = "0x184EBD140")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x4EBCE00", Offset = "0x4EBBA00", VA = "0x184EBCE00")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags, bool bAllowAdminTags = false)
		{
			return default(bool);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x4EBC940", Offset = "0x4EBB540", VA = "0x184EBC940")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4EBCCD0", Offset = "0x4EBB8D0", VA = "0x184EBCCD0")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4EBC7B0", Offset = "0x4EBB3B0", VA = "0x184EBC7B0")]
		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
		{
			return default(bool);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4EBC1A0", Offset = "0x4EBADA0", VA = "0x184EBC1A0")]
		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			return default(bool);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000443C File Offset: 0x0000263C
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4EBC430", Offset = "0x4EBB030", VA = "0x184EBC430")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4EB9DC0", Offset = "0x4EB89C0", VA = "0x184EB9DC0")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000446C File Offset: 0x0000266C
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4EB9F90", Offset = "0x4EB8B90", VA = "0x184EB9F90")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4EBA0D0", Offset = "0x4EB8CD0", VA = "0x184EBA0D0")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000449C File Offset: 0x0000269C
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x4EBE0C0", Offset = "0x4EBCCC0", VA = "0x184EBE0C0")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x4EBE200", Offset = "0x4EBCE00", VA = "0x184EBE200")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4EBC560", Offset = "0x4EBB160", VA = "0x184EBC560")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4EB9B90", Offset = "0x4EB8790", VA = "0x184EB9B90")]
		public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid)
		{
			return default(bool);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4EBC290", Offset = "0x4EBAE90", VA = "0x184EBC290")]
		public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid)
		{
			return default(bool);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4EBD390", Offset = "0x4EBBF90", VA = "0x184EBD390")]
		public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax)
		{
			return default(bool);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4EBDDF0", Offset = "0x4EBC9F0", VA = "0x184EBDDF0")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4EBAF90", Offset = "0x4EB9B90", VA = "0x184EBAF90")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return EItemUpdateStatus.k_EItemUpdateStatusInvalid;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x4EBDA90", Offset = "0x4EBC690", VA = "0x184EBDA90")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x4EBC030", Offset = "0x4EBAC30", VA = "0x184EBC030")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x4EBA200", Offset = "0x4EB8E00", VA = "0x184EBA200")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4EBC390", Offset = "0x4EBAF90", VA = "0x184EBC390")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4EBDF50", Offset = "0x4EBCB50", VA = "0x184EBDF50")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x4EBE030", Offset = "0x4EBCC30", VA = "0x184EBE030")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4EBB010", Offset = "0x4EB9C10", VA = "0x184EBB010")]
		public static uint GetNumSubscribedItems()
		{
			return 0U;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x4EBBDF0", Offset = "0x4EBA9F0", VA = "0x184EBBDF0")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return 0U;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x4EBAF40", Offset = "0x4EB9B40", VA = "0x184EBAF40")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return 0U;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4EBAE20", Offset = "0x4EB9A20", VA = "0x184EBAE20")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4EBADA0", Offset = "0x4EB99A0", VA = "0x184EBADA0")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4EBACB0", Offset = "0x4EB98B0", VA = "0x184EBACB0")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x4EBA660", Offset = "0x4EB9260", VA = "0x184EBA660")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x4EBDFE0", Offset = "0x4EBCBE0", VA = "0x184EBDFE0")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4EBDC20", Offset = "0x4EBC820", VA = "0x184EBDC20")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x4EBDD50", Offset = "0x4EBC950", VA = "0x184EBDD50")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4EBDCC0", Offset = "0x4EBC8C0", VA = "0x184EBDCC0")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x4EB9BF0", Offset = "0x4EB87F0", VA = "0x184EB9BF0")]
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x4EBC2F0", Offset = "0x4EBAEF0", VA = "0x184EBC2F0")]
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4EB9AF0", Offset = "0x4EB86F0", VA = "0x184EB9AF0")]
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4EBC1F0", Offset = "0x4EBADF0", VA = "0x184EBC1F0")]
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4EBAD10", Offset = "0x4EB9910", VA = "0x184EBAD10")]
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4EBAC20", Offset = "0x4EB9820", VA = "0x184EBAC20")]
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4EBDB30", Offset = "0x4EBC730", VA = "0x184EBDB30")]
		public static bool ShowWorkshopEULA()
		{
			return default(bool);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4EBC0C0", Offset = "0x4EBACC0", VA = "0x184EBC0C0")]
		public static SteamAPICall_t GetWorkshopEULAStatus()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000479C File Offset: 0x0000299C
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4EBBFD0", Offset = "0x4EBABD0", VA = "0x184EBBFD0")]
		public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries)
		{
			return 0U;
		}
	}
}
