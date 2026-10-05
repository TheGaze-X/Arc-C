using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public enum EAuthSessionResponse
	{
		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		k_EAuthSessionResponseOK,
		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		k_EAuthSessionResponseUserNotConnectedToSteam,
		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		k_EAuthSessionResponseNoLicenseOrExpired,
		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		k_EAuthSessionResponseVACBanned,
		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		k_EAuthSessionResponseLoggedInElseWhere,
		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		k_EAuthSessionResponseVACCheckTimedOut,
		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		k_EAuthSessionResponseAuthTicketCanceled,
		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		k_EAuthSessionResponseAuthTicketInvalid,
		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		k_EAuthSessionResponsePublisherIssuedBan,
		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		k_EAuthSessionResponseAuthTicketNetworkIdentityFailure
	}
}
