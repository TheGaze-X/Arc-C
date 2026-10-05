using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public static class SteamMatchmakingServers
	{
		// Token: 0x060002CD RID: 717 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x4EC7680", Offset = "0x4EC6280", VA = "0x184EC7680")]
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000554C File Offset: 0x0000374C
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x4EC7790", Offset = "0x4EC6390", VA = "0x184EC7790")]
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00005564 File Offset: 0x00003764
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x4EC7460", Offset = "0x4EC6060", VA = "0x184EC7460")]
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4EC7350", Offset = "0x4EC5F50", VA = "0x184EC7350")]
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x4EC7570", Offset = "0x4EC6170", VA = "0x184EC7570")]
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x4EC7840", Offset = "0x4EC6440", VA = "0x184EC7840")]
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x4EC7300", Offset = "0x4EC5F00", VA = "0x184EC7300")]
		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x4EC6EF0", Offset = "0x4EC5AF0", VA = "0x184EC6EF0")]
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x4EC6E00", Offset = "0x4EC5A00", VA = "0x184EC6E00")]
		public static void CancelQuery(HServerListRequest hRequest)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x4EC7250", Offset = "0x4EC5E50", VA = "0x184EC7250")]
		public static void RefreshQuery(HServerListRequest hRequest)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x4EC7060", Offset = "0x4EC5C60", VA = "0x184EC7060")]
		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			return default(bool);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x4EC6EA0", Offset = "0x4EC5AA0", VA = "0x184EC6EA0")]
		public static int GetServerCount(HServerListRequest hRequest)
		{
			return 0;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4EC72A0", Offset = "0x4EC5EA0", VA = "0x184EC72A0")]
		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x4EC70B0", Offset = "0x4EC5CB0", VA = "0x184EC70B0")]
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x4EC7180", Offset = "0x4EC5D80", VA = "0x184EC7180")]
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x4EC7950", Offset = "0x4EC6550", VA = "0x184EC7950")]
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x4EC6E50", Offset = "0x4EC5A50", VA = "0x184EC6E50")]
		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
		}
	}
}
