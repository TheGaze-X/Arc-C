using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public static class SteamRemotePlay
	{
		// Token: 0x0600038D RID: 909 RVA: 0x000064F4 File Offset: 0x000046F4
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x4ECE770", Offset = "0x4ECD370", VA = "0x184ECE770")]
		public static uint GetSessionCount()
		{
			return 0U;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000650C File Offset: 0x0000470C
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x4ECE7C0", Offset = "0x4ECD3C0", VA = "0x184ECE7C0")]
		public static RemotePlaySessionID_t GetSessionID(int iSessionIndex)
		{
			return default(RemotePlaySessionID_t);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00006524 File Offset: 0x00004724
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x4ECE820", Offset = "0x4ECD420", VA = "0x184ECE820")]
		public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID)
		{
			return default(CSteamID);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x4ECE710", Offset = "0x4ECD310", VA = "0x184ECE710")]
		public static string GetSessionClientName(RemotePlaySessionID_t unSessionID)
		{
			return null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000653C File Offset: 0x0000473C
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x4ECE6C0", Offset = "0x4ECD2C0", VA = "0x184ECE6C0")]
		public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID)
		{
			return ESteamDeviceFormFactor.k_ESteamDeviceFormFactorUnknown;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00006554 File Offset: 0x00004754
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x4ECE580", Offset = "0x4ECD180", VA = "0x184ECE580")]
		public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY)
		{
			return default(bool);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000656C File Offset: 0x0000476C
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x4ECE660", Offset = "0x4ECD260", VA = "0x184ECE660")]
		public static bool BStartRemotePlayTogether(bool bShowOverlay = true)
		{
			return default(bool);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00006584 File Offset: 0x00004784
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x4ECE600", Offset = "0x4ECD200", VA = "0x184ECE600")]
		public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend)
		{
			return default(bool);
		}
	}
}
