using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public enum EResult
	{
		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		k_EResultNone,
		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		k_EResultOK,
		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		k_EResultFail,
		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		k_EResultNoConnection,
		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		k_EResultInvalidPassword = 5,
		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		k_EResultLoggedInElsewhere,
		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		k_EResultInvalidProtocolVer,
		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		k_EResultInvalidParam,
		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		k_EResultFileNotFound,
		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		k_EResultBusy,
		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		k_EResultInvalidState,
		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		k_EResultInvalidName,
		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		k_EResultInvalidEmail,
		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		k_EResultDuplicateName,
		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		k_EResultAccessDenied,
		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		k_EResultTimeout,
		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		k_EResultBanned,
		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		k_EResultAccountNotFound,
		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		k_EResultInvalidSteamID,
		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		k_EResultServiceUnavailable,
		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		k_EResultNotLoggedOn,
		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		k_EResultPending,
		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		k_EResultEncryptionFailure,
		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		k_EResultInsufficientPrivilege,
		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		k_EResultLimitExceeded,
		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		k_EResultRevoked,
		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		k_EResultExpired,
		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		k_EResultAlreadyRedeemed,
		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		k_EResultDuplicateRequest,
		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		k_EResultAlreadyOwned,
		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		k_EResultIPNotFound,
		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		k_EResultPersistFailed,
		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		k_EResultLockingFailed,
		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		k_EResultLogonSessionReplaced,
		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		k_EResultConnectFailed,
		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		k_EResultHandshakeFailed,
		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		k_EResultIOFailure,
		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		k_EResultRemoteDisconnect,
		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		k_EResultShoppingCartNotFound,
		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		k_EResultBlocked,
		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		k_EResultIgnored,
		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		k_EResultNoMatch,
		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		k_EResultAccountDisabled,
		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		k_EResultServiceReadOnly,
		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		k_EResultAccountNotFeatured,
		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		k_EResultAdministratorOK,
		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		k_EResultContentVersion,
		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		k_EResultTryAnotherCM,
		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		k_EResultPasswordRequiredToKickSession,
		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		k_EResultAlreadyLoggedInElsewhere,
		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		k_EResultSuspended,
		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		k_EResultCancelled,
		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		k_EResultDataCorruption,
		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		k_EResultDiskFull,
		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		k_EResultRemoteCallFailed,
		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		k_EResultPasswordUnset,
		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		k_EResultExternalAccountUnlinked,
		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		k_EResultPSNTicketInvalid,
		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		k_EResultExternalAccountAlreadyLinked,
		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		k_EResultRemoteFileConflict,
		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		k_EResultIllegalPassword,
		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		k_EResultSameAsPreviousValue,
		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		k_EResultAccountLogonDenied,
		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		k_EResultCannotUseOldPassword,
		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		k_EResultInvalidLoginAuthCode,
		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		k_EResultAccountLogonDeniedNoMail,
		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		k_EResultHardwareNotCapableOfIPT,
		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		k_EResultIPTInitError,
		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		k_EResultParentalControlRestricted,
		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		k_EResultFacebookQueryError,
		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		k_EResultExpiredLoginAuthCode,
		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		k_EResultIPLoginRestrictionFailed,
		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		k_EResultAccountLockedDown,
		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		k_EResultAccountLogonDeniedVerifiedEmailRequired,
		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		k_EResultNoMatchingURL,
		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		k_EResultBadResponse,
		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		k_EResultRequirePasswordReEntry,
		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		k_EResultValueOutOfRange,
		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		k_EResultUnexpectedError,
		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		k_EResultDisabled,
		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		k_EResultInvalidCEGSubmission,
		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		k_EResultRestrictedDevice,
		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		k_EResultRegionLocked,
		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		k_EResultRateLimitExceeded,
		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		k_EResultAccountLoginDeniedNeedTwoFactor,
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		k_EResultItemDeleted,
		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		k_EResultAccountLoginDeniedThrottle,
		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		k_EResultTwoFactorCodeMismatch,
		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		k_EResultTwoFactorActivationCodeMismatch,
		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		k_EResultAccountAssociatedToMultiplePartners,
		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		k_EResultNotModified,
		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		k_EResultNoMobileDevice,
		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		k_EResultTimeNotSynced,
		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		k_EResultSmsCodeFailed,
		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		k_EResultAccountLimitExceeded,
		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		k_EResultAccountActivityLimitExceeded,
		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		k_EResultPhoneActivityLimitExceeded,
		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		k_EResultRefundToWallet,
		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		k_EResultEmailSendFailure,
		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		k_EResultNotSettled,
		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		k_EResultNeedCaptcha,
		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		k_EResultGSLTDenied,
		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		k_EResultGSOwnerDenied,
		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		k_EResultInvalidItemType,
		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		k_EResultIPBanned,
		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		k_EResultGSLTExpired,
		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		k_EResultInsufficientFunds,
		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		k_EResultTooManyPending,
		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		k_EResultNoSiteLicensesFound,
		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		k_EResultWGNetworkSendExceeded,
		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		k_EResultAccountNotFriends,
		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		k_EResultLimitedUserAccount,
		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		k_EResultCantRemoveItem,
		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		k_EResultAccountDeleted,
		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		k_EResultExistingUserCancelledLicense,
		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		k_EResultCommunityCooldown,
		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		k_EResultNoLauncherSpecified,
		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		k_EResultMustAgreeToSSA,
		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		k_EResultLauncherMigrated,
		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		k_EResultSteamRealmMismatch,
		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		k_EResultInvalidSignature,
		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		k_EResultParseFailure,
		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		k_EResultNoVerifiedPhone,
		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		k_EResultInsufficientBattery,
		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		k_EResultChargerRequired,
		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		k_EResultCachedCredentialInvalid,
		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		K_EResultPhoneNumberIsVOIP,
		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		k_EResultNotSupported,
		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		k_EResultFamilySizeLimitExceeded
	}
}
