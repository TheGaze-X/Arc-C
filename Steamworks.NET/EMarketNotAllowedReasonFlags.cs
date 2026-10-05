using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	[Flags]
	public enum EMarketNotAllowedReasonFlags
	{
		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		k_EMarketNotAllowedReason_None = 0,
		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		k_EMarketNotAllowedReason_TemporaryFailure = 1,
		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		k_EMarketNotAllowedReason_AccountDisabled = 2,
		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		k_EMarketNotAllowedReason_AccountLockedDown = 4,
		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		k_EMarketNotAllowedReason_AccountLimited = 8,
		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		k_EMarketNotAllowedReason_TradeBanned = 16,
		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		k_EMarketNotAllowedReason_AccountNotTrusted = 32,
		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		k_EMarketNotAllowedReason_SteamGuardNotEnabled = 64,
		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128,
		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		k_EMarketNotAllowedReason_RecentPasswordReset = 256,
		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		k_EMarketNotAllowedReason_NewPaymentMethod = 512,
		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		k_EMarketNotAllowedReason_InvalidCookie = 1024,
		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		k_EMarketNotAllowedReason_UsingNewDevice = 2048,
		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		k_EMarketNotAllowedReason_RecentSelfRefund = 4096,
		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192,
		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		k_EMarketNotAllowedReason_NoRecentPurchases = 16384,
		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		k_EMarketNotAllowedReason_AcceptedWalletGift = 32768
	}
}
