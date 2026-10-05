using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public static class SteamParties
	{
		// Token: 0x060002EC RID: 748 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x4ECE3E0", Offset = "0x4ECCFE0", VA = "0x184ECE3E0")]
		public static uint GetNumActiveBeacons()
		{
			return 0U;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x4ECE100", Offset = "0x4ECCD00", VA = "0x184ECE100")]
		public static PartyBeaconID_t GetBeaconByIndex(uint unIndex)
		{
			return default(PartyBeaconID_t);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x4ECE190", Offset = "0x4ECCD90", VA = "0x184ECE190")]
		public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata)
		{
			return default(bool);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000057D4 File Offset: 0x000039D4
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x4ECE490", Offset = "0x4ECD090", VA = "0x184ECE490")]
		public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000057EC File Offset: 0x000039EC
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x4ECE430", Offset = "0x4ECD030", VA = "0x184ECE430")]
		public static bool GetNumAvailableBeaconLocations(out uint puNumLocations)
		{
			return default(bool);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00005804 File Offset: 0x00003A04
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4ECE0A0", Offset = "0x4ECCCA0", VA = "0x184ECE0A0")]
		public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations)
		{
			return default(bool);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000581C File Offset: 0x00003A1C
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4ECDE20", Offset = "0x4ECCA20", VA = "0x184ECDE20")]
		public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4ECE520", Offset = "0x4ECD120", VA = "0x184ECE520")]
		public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x4ECDD20", Offset = "0x4ECC920", VA = "0x184ECDD20")]
		public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00005834 File Offset: 0x00003A34
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x4ECDD80", Offset = "0x4ECC980", VA = "0x184ECDD80")]
		public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000584C File Offset: 0x00003A4C
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x4ECE040", Offset = "0x4ECCC40", VA = "0x184ECE040")]
		public static bool DestroyBeacon(PartyBeaconID_t ulBeacon)
		{
			return default(bool);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00005864 File Offset: 0x00003A64
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x4ECE2C0", Offset = "0x4ECCEC0", VA = "0x184ECE2C0")]
		public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut)
		{
			return default(bool);
		}
	}
}
