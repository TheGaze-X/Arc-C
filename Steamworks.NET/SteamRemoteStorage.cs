using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public static class SteamRemoteStorage
	{
		// Token: 0x06000395 RID: 917 RVA: 0x0000659C File Offset: 0x0000479C
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x4ECFC50", Offset = "0x4ECE850", VA = "0x184ECFC50")]
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000065B4 File Offset: 0x000047B4
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4ECF5C0", Offset = "0x4ECE1C0", VA = "0x184ECF5C0")]
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			return 0;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000065CC File Offset: 0x000047CC
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x4ECF860", Offset = "0x4ECE460", VA = "0x184ECF860")]
		public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000065E4 File Offset: 0x000047E4
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x4ECF440", Offset = "0x4ECE040", VA = "0x184ECF440")]
		public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000065FC File Offset: 0x000047FC
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4ECF3C0", Offset = "0x4ECDFC0", VA = "0x184ECF3C0")]
		public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead)
		{
			return default(bool);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00006614 File Offset: 0x00004814
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4ECF180", Offset = "0x4ECDD80", VA = "0x184ECF180")]
		public static bool FileForget(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000662C File Offset: 0x0000482C
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x4ECEF40", Offset = "0x4ECDB40", VA = "0x184ECEF40")]
		public static bool FileDelete(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00006644 File Offset: 0x00004844
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x4ECF710", Offset = "0x4ECE310", VA = "0x184ECF710")]
		public static SteamAPICall_t FileShare(string pchFile)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000665C File Offset: 0x0000485C
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x4ED1020", Offset = "0x4ECFC20", VA = "0x184ED1020")]
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			return default(bool);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00006674 File Offset: 0x00004874
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x4ECFA80", Offset = "0x4ECE680", VA = "0x184ECFA80")]
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000668C File Offset: 0x0000488C
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4ECFBD0", Offset = "0x4ECE7D0", VA = "0x184ECFBD0")]
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000066A4 File Offset: 0x000048A4
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x4ECFA30", Offset = "0x4ECE630", VA = "0x184ECFA30")]
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000066BC File Offset: 0x000048BC
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x4ECF9E0", Offset = "0x4ECE5E0", VA = "0x184ECF9E0")]
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000066D4 File Offset: 0x000048D4
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4ECF060", Offset = "0x4ECDC60", VA = "0x184ECF060")]
		public static bool FileExists(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000066EC File Offset: 0x000048EC
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x4ECF2A0", Offset = "0x4ECDEA0", VA = "0x184ECF2A0")]
		public static bool FilePersisted(string pchFile)
		{
			return default(bool);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00006704 File Offset: 0x00004904
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x4ECFF30", Offset = "0x4ECEB30", VA = "0x184ECFF30")]
		public static int GetFileSize(string pchFile)
		{
			return 0;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000671C File Offset: 0x0000491C
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4ED0050", Offset = "0x4ECEC50", VA = "0x184ED0050")]
		public static long GetFileTimestamp(string pchFile)
		{
			return 0L;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00006734 File Offset: 0x00004934
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x4ED03E0", Offset = "0x4ECEFE0", VA = "0x184ED03E0")]
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			return ERemoteStoragePlatform.k_ERemoteStoragePlatformNone;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000674C File Offset: 0x0000494C
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4ECFE70", Offset = "0x4ECEA70", VA = "0x184ECFE70")]
		public static int GetFileCount()
		{
			return 0;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4ECFEC0", Offset = "0x4ECEAC0", VA = "0x184ECFEC0")]
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			return null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00006764 File Offset: 0x00004964
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4ED0380", Offset = "0x4ECEF80", VA = "0x184ED0380")]
		public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes)
		{
			return default(bool);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000677C File Offset: 0x0000497C
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4ED06D0", Offset = "0x4ECF2D0", VA = "0x184ED06D0")]
		public static bool IsCloudEnabledForAccount()
		{
			return default(bool);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00006794 File Offset: 0x00004994
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4ED0720", Offset = "0x4ECF320", VA = "0x184ED0720")]
		public static bool IsCloudEnabledForApp()
		{
			return default(bool);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4ED0FD0", Offset = "0x4ECFBD0", VA = "0x184ED0FD0")]
		public static void SetCloudEnabledForApp(bool bEnabled)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000067AC File Offset: 0x000049AC
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4ED1400", Offset = "0x4ED0000", VA = "0x184ED1400")]
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000067C4 File Offset: 0x000049C4
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x4ED05C0", Offset = "0x4ECF1C0", VA = "0x184ED05C0")]
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			return default(bool);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000067DC File Offset: 0x000049DC
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4ED0500", Offset = "0x4ECF100", VA = "0x184ED0500")]
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			return default(bool);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000067F4 File Offset: 0x000049F4
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x4ED14A0", Offset = "0x4ED00A0", VA = "0x184ED14A0")]
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			return 0;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000680C File Offset: 0x00004A0C
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x4ECFD90", Offset = "0x4ECE990", VA = "0x184ECFD90")]
		public static int GetCachedUGCCount()
		{
			return 0;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00006824 File Offset: 0x00004A24
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x4ECFDE0", Offset = "0x4ECE9E0", VA = "0x184ECFDE0")]
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			return default(UGCHandle_t);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000683C File Offset: 0x00004A3C
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x4ED0C00", Offset = "0x4ECF800", VA = "0x184ED0C00")]
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00006854 File Offset: 0x00004A54
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x4ECE990", Offset = "0x4ECD590", VA = "0x184ECE990")]
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000686C File Offset: 0x00004A6C
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x4ED16F0", Offset = "0x4ED02F0", VA = "0x184ED16F0")]
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			return default(bool);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00006884 File Offset: 0x00004A84
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x4ED1820", Offset = "0x4ED0420", VA = "0x184ED1820")]
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			return default(bool);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000689C File Offset: 0x00004A9C
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x4ED1B40", Offset = "0x4ED0740", VA = "0x184ED1B40")]
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			return default(bool);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000068B4 File Offset: 0x00004AB4
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x4ED15C0", Offset = "0x4ED01C0", VA = "0x184ED15C0")]
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			return default(bool);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000068CC File Offset: 0x00004ACC
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x4ED1C70", Offset = "0x4ED0870", VA = "0x184ED1C70")]
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000068E4 File Offset: 0x00004AE4
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x4ED1A80", Offset = "0x4ED0680", VA = "0x184ED1A80")]
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000068FC File Offset: 0x00004AFC
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x4ECE900", Offset = "0x4ECD500", VA = "0x184ECE900")]
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00006914 File Offset: 0x00004B14
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x4ED0250", Offset = "0x4ECEE50", VA = "0x184ED0250")]
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000692C File Offset: 0x00004B2C
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x4ECEA20", Offset = "0x4ECD620", VA = "0x184ECEA20")]
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00006944 File Offset: 0x00004B44
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x4ECECF0", Offset = "0x4ECD8F0", VA = "0x184ECECF0")]
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000695C File Offset: 0x00004B5C
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x4ED11F0", Offset = "0x4ECFDF0", VA = "0x184ED11F0")]
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00006974 File Offset: 0x00004B74
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4ECEEB0", Offset = "0x4ECDAB0", VA = "0x184ECEEB0")]
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000698C File Offset: 0x00004B8C
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x4ED1530", Offset = "0x4ED0130", VA = "0x184ED1530")]
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000069A4 File Offset: 0x00004BA4
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x4ED1950", Offset = "0x4ED0550", VA = "0x184ED1950")]
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			return default(bool);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000069BC File Offset: 0x00004BBC
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4ED02F0", Offset = "0x4ECEEF0", VA = "0x184ED02F0")]
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000069D4 File Offset: 0x00004BD4
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x4ED1CD0", Offset = "0x4ED08D0", VA = "0x184ED1CD0")]
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000069EC File Offset: 0x00004BEC
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x4ED0640", Offset = "0x4ECF240", VA = "0x184ED0640")]
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00006A04 File Offset: 0x00004C04
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4ECED80", Offset = "0x4ECD980", VA = "0x184ECED80")]
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00006A1C File Offset: 0x00004C1C
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4ED0770", Offset = "0x4ECF370", VA = "0x184ED0770")]
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00006A34 File Offset: 0x00004C34
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x4ED1150", Offset = "0x4ECFD50", VA = "0x184ED1150")]
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x4ECEB00", Offset = "0x4ECD700", VA = "0x184ECEB00")]
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00006A64 File Offset: 0x00004C64
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x4ECEBA0", Offset = "0x4ECD7A0", VA = "0x184ECEBA0")]
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00006A7C File Offset: 0x00004C7C
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x4ED1280", Offset = "0x4ECFE80", VA = "0x184ED1280")]
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00006A94 File Offset: 0x00004C94
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x4ED0180", Offset = "0x4ECED80", VA = "0x184ED0180")]
		public static int GetLocalFileChangeCount()
		{
			return 0;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x4ED01D0", Offset = "0x4ECEDD0", VA = "0x184ED01D0")]
		public static string GetLocalFileChange(int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType)
		{
			return null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00006AAC File Offset: 0x00004CAC
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x4ECE8B0", Offset = "0x4ECD4B0", VA = "0x184ECE8B0")]
		public static bool BeginFileWriteBatch()
		{
			return default(bool);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x4ECEAB0", Offset = "0x4ECD6B0", VA = "0x184ECEAB0")]
		public static bool EndFileWriteBatch()
		{
			return default(bool);
		}
	}
}
