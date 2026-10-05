using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class SteamFriends
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4EAEC60", Offset = "0x4EAD860", VA = "0x184EAEC60")]
		public static string GetPersonaName()
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4EAFA00", Offset = "0x4EAE600", VA = "0x184EAFA00")]
		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4EAECB0", Offset = "0x4EAD8B0", VA = "0x184EAECB0")]
		public static EPersonaState GetPersonaState()
		{
			return EPersonaState.k_EPersonaStateOffline;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4EAE330", Offset = "0x4EACF30", VA = "0x184EAE330")]
		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			return 0;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4EAE160", Offset = "0x4EACD60", VA = "0x184EAE160")]
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			return default(CSteamID);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4EAE6C0", Offset = "0x4EAD2C0", VA = "0x184EAE6C0")]
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			return EFriendRelationship.k_EFriendRelationshipNone;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4EAE670", Offset = "0x4EAD270", VA = "0x184EAE670")]
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			return EPersonaState.k_EPersonaStateOffline;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4EAE610", Offset = "0x4EAD210", VA = "0x184EAE610")]
		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4EAE420", Offset = "0x4EAD020", VA = "0x184EAE420")]
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			return default(bool);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4EAE5A0", Offset = "0x4EAD1A0", VA = "0x184EAE5A0")]
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4EAE910", Offset = "0x4EAD510", VA = "0x184EAE910")]
		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4EAED00", Offset = "0x4EAD900", VA = "0x184EAED00")]
		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4EAE960", Offset = "0x4EAD560", VA = "0x184EAE960")]
		public static int GetFriendsGroupCount()
		{
			return 0;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4EAE9B0", Offset = "0x4EAD5B0", VA = "0x184EAE9B0")]
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			return default(FriendsGroupID_t);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4EAEB10", Offset = "0x4EAD710", VA = "0x184EAEB10")]
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4EAEA40", Offset = "0x4EAD640", VA = "0x184EAEA40")]
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			return 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4EAEA90", Offset = "0x4EAD690", VA = "0x184EAEA90")]
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4EAEF00", Offset = "0x4EADB00", VA = "0x184EAEF00")]
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			return default(bool);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4EADD60", Offset = "0x4EAC960", VA = "0x184EADD60")]
		public static int GetClanCount()
		{
			return 0;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4EADB50", Offset = "0x4EAC750", VA = "0x184EADB50")]
		public static CSteamID GetClanByIndex(int iClan)
		{
			return default(CSteamID);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4EADDB0", Offset = "0x4EAC9B0", VA = "0x184EADDB0")]
		public static string GetClanName(CSteamID steamIDClan)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4EADF90", Offset = "0x4EACB90", VA = "0x184EADF90")]
		public static string GetClanTag(CSteamID steamIDClan)
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4EADAC0", Offset = "0x4EAC6C0", VA = "0x184EADAC0")]
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			return default(bool);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4EAD8F0", Offset = "0x4EAC4F0", VA = "0x184EAD8F0")]
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4EAE2E0", Offset = "0x4EACEE0", VA = "0x184EAE2E0")]
		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			return 0;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4EAE380", Offset = "0x4EACF80", VA = "0x184EAE380")]
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			return default(CSteamID);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4EAF270", Offset = "0x4EADE70", VA = "0x184EAF270")]
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4EAF950", Offset = "0x4EAE550", VA = "0x184EAF950")]
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4EAD6E0", Offset = "0x4EAC2E0", VA = "0x184EAD6E0")]
		public static void ActivateGameOverlay(string pchDialog)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4EAD4A0", Offset = "0x4EAC0A0", VA = "0x184EAD4A0")]
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4EAD5C0", Offset = "0x4EAC1C0", VA = "0x184EAD5C0")]
		public static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4EAD440", Offset = "0x4EAC040", VA = "0x184EAD440")]
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x4EAFB50", Offset = "0x4EAE750", VA = "0x184EAFB50")]
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4EAD3A0", Offset = "0x4EABFA0", VA = "0x184EAD3A0")]
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4EAEE60", Offset = "0x4EADA60", VA = "0x184EAEE60")]
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x4EAEBC0", Offset = "0x4EAD7C0", VA = "0x184EAEBC0")]
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4EAEB70", Offset = "0x4EAD770", VA = "0x184EAEB70")]
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4EAF7C0", Offset = "0x4EAE3C0", VA = "0x184EAF7C0")]
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			return default(bool);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4EAF650", Offset = "0x4EAE250", VA = "0x184EAF650")]
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x4EADF00", Offset = "0x4EACB00", VA = "0x184EADF00")]
		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			return default(CSteamID);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4EADEB0", Offset = "0x4EACAB0", VA = "0x184EADEB0")]
		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			return 0;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4EADE10", Offset = "0x4EACA10", VA = "0x184EADE10")]
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			return default(CSteamID);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4EAEEB0", Offset = "0x4EADAB0", VA = "0x184EAEEB0")]
		public static uint GetUserRestrictions()
		{
			return 0U;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x4EAFBA0", Offset = "0x4EAE7A0", VA = "0x184EAFBA0")]
		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4EAD850", Offset = "0x4EAC450", VA = "0x184EAD850")]
		public static void ClearRichPresence()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4EAE7D0", Offset = "0x4EAD3D0", VA = "0x184EAE7D0")]
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4EAE780", Offset = "0x4EAD380", VA = "0x184EAE780")]
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4EAE710", Offset = "0x4EAD310", VA = "0x184EAE710")]
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			return null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4EAF770", Offset = "0x4EAE370", VA = "0x184EAF770")]
		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4EAEF60", Offset = "0x4EADB60", VA = "0x184EAEF60")]
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			return default(bool);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4EADFF0", Offset = "0x4EACBF0", VA = "0x184EADFF0")]
		public static int GetCoplayFriendCount()
		{
			return 0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4EAE040", Offset = "0x4EACC40", VA = "0x184EAE040")]
		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			return default(CSteamID);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4EAE290", Offset = "0x4EACE90", VA = "0x184EAE290")]
		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4EAE200", Offset = "0x4EACE00", VA = "0x184EAE200")]
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			return default(AppId_t);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4EAF2D0", Offset = "0x4EADED0", VA = "0x184EAF2D0")]
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4EAF360", Offset = "0x4EADF60", VA = "0x184EAF360")]
		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			return default(bool);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4EADBE0", Offset = "0x4EAC7E0", VA = "0x184EADBE0")]
		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			return 0;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4EADA20", Offset = "0x4EAC620", VA = "0x184EADA20")]
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			return default(CSteamID);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4EAF820", Offset = "0x4EAE420", VA = "0x184EAF820")]
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			return default(bool);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4EADC30", Offset = "0x4EAC830", VA = "0x184EADC30")]
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			return 0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4EAF090", Offset = "0x4EADC90", VA = "0x184EAF090")]
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			return default(bool);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4EAF0F0", Offset = "0x4EADCF0", VA = "0x184EAF0F0")]
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4EAF3B0", Offset = "0x4EADFB0", VA = "0x184EAF3B0")]
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4EAD8A0", Offset = "0x4EAC4A0", VA = "0x184EAD8A0")]
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4EAF9B0", Offset = "0x4EAE5B0", VA = "0x184EAF9B0")]
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			return default(bool);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4EAF520", Offset = "0x4EAE120", VA = "0x184EAF520")]
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			return default(bool);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4EAE480", Offset = "0x4EAD080", VA = "0x184EAE480")]
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return 0;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4EAE0D0", Offset = "0x4EACCD0", VA = "0x184EAE0D0")]
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4EAF1E0", Offset = "0x4EADDE0", VA = "0x184EAF1E0")]
		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x4EAD990", Offset = "0x4EAC590", VA = "0x184EAD990")]
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4EAF190", Offset = "0x4EADD90", VA = "0x184EAF190")]
		public static bool IsClanPublic(CSteamID steamIDClan)
		{
			return default(bool);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4EAF140", Offset = "0x4EADD40", VA = "0x184EAF140")]
		public static bool IsClanOfficialGameGroup(CSteamID steamIDClan)
		{
			return default(bool);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4EAEC10", Offset = "0x4EAD810", VA = "0x184EAEC10")]
		public static int GetNumChatsWithUnreadPriorityMessages()
		{
			return 0;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4EAD3F0", Offset = "0x4EABFF0", VA = "0x184EAD3F0")]
		public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4EAF400", Offset = "0x4EAE000", VA = "0x184EAF400")]
		public static bool RegisterProtocolInOverlayBrowser(string pchProtocol)
		{
			return default(bool);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x4EAD290", Offset = "0x4EABE90", VA = "0x184EAD290")]
		public static void ActivateGameOverlayInviteDialogConnectString(string pchConnectString)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x4EAF6E0", Offset = "0x4EAE2E0", VA = "0x184EAF6E0")]
		public static SteamAPICall_t RequestEquippedProfileItems(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4EAD7F0", Offset = "0x4EAC3F0", VA = "0x184EAD7F0")]
		public static bool BHasEquippedProfileItem(CSteamID steamID, ECommunityProfileItemType itemType)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x4EAED60", Offset = "0x4EAD960", VA = "0x184EAED60")]
		public static string GetProfileItemPropertyString(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop)
		{
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x4EAEDE0", Offset = "0x4EAD9E0", VA = "0x184EAEDE0")]
		public static uint GetProfileItemPropertyUint(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop)
		{
			return 0U;
		}
	}
}
