using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	public static class SteamEncryptedAppTicket
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x0000800C File Offset: 0x0000620C
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x4F0B8B0", Offset = "0x4F0A4B0", VA = "0x184F0B8B0")]
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			return default(bool);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00008024 File Offset: 0x00006224
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x4F0BAE0", Offset = "0x4F0A6E0", VA = "0x184F0BAE0")]
		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0000803C File Offset: 0x0000623C
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x4F0BE10", Offset = "0x4F0AA10", VA = "0x184F0BE10")]
		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return 0U;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x4F0BEA0", Offset = "0x4F0AAA0", VA = "0x184F0BEA0")]
		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00008054 File Offset: 0x00006254
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x4F0BD80", Offset = "0x4F0A980", VA = "0x184F0BD80")]
		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return 0U;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000806C File Offset: 0x0000626C
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x4F0BCE0", Offset = "0x4F0A8E0", VA = "0x184F0BCE0")]
		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00008084 File Offset: 0x00006284
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x4F0BC40", Offset = "0x4F0A840", VA = "0x184F0BC40")]
		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(bool);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x4F0E0F0", Offset = "0x4F0CCF0", VA = "0x184F0E0F0")]
		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			return null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0000809C File Offset: 0x0000629C
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x4F0BB80", Offset = "0x4F0A780", VA = "0x184F0BB80")]
		public static bool BIsTicketSigned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, byte[] pubRSAKey, uint cubRSAKey)
		{
			return default(bool);
		}
	}
}
