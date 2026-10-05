using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public static class SteamParentalSettings
	{
		// Token: 0x06000387 RID: 903 RVA: 0x00006464 File Offset: 0x00004664
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x4ECDC80", Offset = "0x4ECC880", VA = "0x184ECDC80")]
		public static bool BIsParentalLockEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000647C File Offset: 0x0000467C
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x4ECDCD0", Offset = "0x4ECC8D0", VA = "0x184ECDCD0")]
		public static bool BIsParentalLockLocked()
		{
			return default(bool);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00006494 File Offset: 0x00004694
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x4ECDB40", Offset = "0x4ECC740", VA = "0x184ECDB40")]
		public static bool BIsAppBlocked(AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000064AC File Offset: 0x000046AC
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x4ECDB90", Offset = "0x4ECC790", VA = "0x184ECDB90")]
		public static bool BIsAppInBlockList(AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000064C4 File Offset: 0x000046C4
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x4ECDBE0", Offset = "0x4ECC7E0", VA = "0x184ECDBE0")]
		public static bool BIsFeatureBlocked(EParentalFeature eFeature)
		{
			return default(bool);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000064DC File Offset: 0x000046DC
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x4ECDC30", Offset = "0x4ECC830", VA = "0x184ECDC30")]
		public static bool BIsFeatureInBlockList(EParentalFeature eFeature)
		{
			return default(bool);
		}
	}
}
