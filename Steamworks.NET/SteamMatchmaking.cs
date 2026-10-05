using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public static class SteamMatchmaking
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x000052C4 File Offset: 0x000034C4
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x4EC81F0", Offset = "0x4EC6DF0", VA = "0x184EC81F0")]
		public static int GetFavoriteGameCount()
		{
			return 0;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000052DC File Offset: 0x000034DC
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4EC8240", Offset = "0x4EC6E40", VA = "0x184EC8240")]
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			return default(bool);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000052F4 File Offset: 0x000034F4
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x4EC7A20", Offset = "0x4EC6620", VA = "0x184EC7A20")]
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return 0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000530C File Offset: 0x0000350C
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4EC8C30", Offset = "0x4EC7830", VA = "0x184EC8C30")]
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return default(bool);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00005324 File Offset: 0x00003524
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4EC8D10", Offset = "0x4EC7910", VA = "0x184EC8D10")]
		public static SteamAPICall_t RequestLobbyList()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4EC7E50", Offset = "0x4EC6A50", VA = "0x184EC7E50")]
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x4EC7CD0", Offset = "0x4EC68D0", VA = "0x184EC7CD0")]
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x4EC7BB0", Offset = "0x4EC67B0", VA = "0x184EC7BB0")]
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x4EC7B60", Offset = "0x4EC6760", VA = "0x184EC7B60")]
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4EC7B10", Offset = "0x4EC6710", VA = "0x184EC7B10")]
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x4EC7E00", Offset = "0x4EC6A00", VA = "0x184EC7E00")]
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x4EC7AC0", Offset = "0x4EC66C0", VA = "0x184EC7AC0")]
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000533C File Offset: 0x0000353C
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x4EC82F0", Offset = "0x4EC6EF0", VA = "0x184EC82F0")]
		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			return default(CSteamID);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00005354 File Offset: 0x00003554
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4EC8020", Offset = "0x4EC6C20", VA = "0x184EC8020")]
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4EC8B50", Offset = "0x4EC7750", VA = "0x184EC8B50")]
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4EC8BE0", Offset = "0x4EC77E0", VA = "0x184EC8BE0")]
		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00005384 File Offset: 0x00003584
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4EC8AF0", Offset = "0x4EC76F0", VA = "0x184EC8AF0")]
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			return default(bool);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000539C File Offset: 0x0000359C
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4EC8AA0", Offset = "0x4EC76A0", VA = "0x184EC8AA0")]
		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return 0;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000053B4 File Offset: 0x000035B4
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4EC87C0", Offset = "0x4EC73C0", VA = "0x184EC87C0")]
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x4EC85F0", Offset = "0x4EC71F0", VA = "0x184EC85F0")]
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000053CC File Offset: 0x000035CC
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x4EC8E80", Offset = "0x4EC7A80", VA = "0x184EC8E80")]
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000053E4 File Offset: 0x000035E4
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x4EC85A0", Offset = "0x4EC71A0", VA = "0x184EC85A0")]
		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			return 0;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x4EC8420", Offset = "0x4EC7020", VA = "0x184EC8420")]
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			return default(bool);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x4EC80C0", Offset = "0x4EC6CC0", VA = "0x184EC80C0")]
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return default(bool);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x4EC8860", Offset = "0x4EC7460", VA = "0x184EC8860")]
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			return null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4EC9140", Offset = "0x4EC7D40", VA = "0x184EC9140")]
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4EC8DA0", Offset = "0x4EC79A0", VA = "0x184EC8DA0")]
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			return default(bool);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00005444 File Offset: 0x00003644
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4EC8380", Offset = "0x4EC6F80", VA = "0x184EC8380")]
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return 0;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x4EC8CC0", Offset = "0x4EC78C0", VA = "0x184EC8CC0")]
		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			return default(bool);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4EC9050", Offset = "0x4EC7C50", VA = "0x184EC9050")]
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00005474 File Offset: 0x00003674
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4EC8730", Offset = "0x4EC7330", VA = "0x184EC8730")]
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			return default(bool);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x4EC9310", Offset = "0x4EC7F10", VA = "0x184EC9310")]
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			return default(bool);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000054A4 File Offset: 0x000036A4
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x4EC89C0", Offset = "0x4EC75C0", VA = "0x184EC89C0")]
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			return 0;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000054BC File Offset: 0x000036BC
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x4EC93D0", Offset = "0x4EC7FD0", VA = "0x184EC93D0")]
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			return default(bool);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4EC90E0", Offset = "0x4EC7CE0", VA = "0x184EC90E0")]
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return default(bool);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4EC8A10", Offset = "0x4EC7610", VA = "0x184EC8A10")]
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x4EC9370", Offset = "0x4EC7F70", VA = "0x184EC9370")]
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			return default(bool);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x4EC8E20", Offset = "0x4EC7A20", VA = "0x184EC8E20")]
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			return default(bool);
		}
	}
}
