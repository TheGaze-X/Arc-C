using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public static class SteamGameSearch
	{
		// Token: 0x060002DE RID: 734 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x4EAFDD0", Offset = "0x4EAE9D0", VA = "0x184EAFDD0")]
		public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4EB0320", Offset = "0x4EAEF20", VA = "0x184EB0320")]
		public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x4EB02C0", Offset = "0x4EAEEC0", VA = "0x184EB02C0")]
		public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00005684 File Offset: 0x00003884
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x4EAFD80", Offset = "0x4EAE980", VA = "0x184EAFD80")]
		public static EGameSearchErrorCode_t AcceptGame()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x4EAFFF0", Offset = "0x4EAEBF0", VA = "0x184EAFFF0")]
		public static EGameSearchErrorCode_t DeclineGame()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000056B4 File Offset: 0x000038B4
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x4EB01B0", Offset = "0x4EAEDB0", VA = "0x184EB01B0")]
		public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000056CC File Offset: 0x000038CC
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x4EB0040", Offset = "0x4EAEC40", VA = "0x184EB0040")]
		public static EGameSearchErrorCode_t EndGameSearch()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000056E4 File Offset: 0x000038E4
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x4EB04D0", Offset = "0x4EAF0D0", VA = "0x184EB04D0")]
		public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000056FC File Offset: 0x000038FC
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x4EB03A0", Offset = "0x4EAEFA0", VA = "0x184EB03A0")]
		public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00005714 File Offset: 0x00003914
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x4EB0130", Offset = "0x4EAED30", VA = "0x184EB0130")]
		public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000572C File Offset: 0x0000392C
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x4EB00E0", Offset = "0x4EAECE0", VA = "0x184EB00E0")]
		public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00005744 File Offset: 0x00003944
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x4EAFFA0", Offset = "0x4EAEBA0", VA = "0x184EAFFA0")]
		public static EGameSearchErrorCode_t CancelRequestPlayersForGame()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x4EB06A0", Offset = "0x4EAF2A0", VA = "0x184EB06A0")]
		public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00005774 File Offset: 0x00003974
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x4EB0090", Offset = "0x4EAEC90", VA = "0x184EB0090")]
		public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID)
		{
			return (EGameSearchErrorCode_t)0;
		}
	}
}
