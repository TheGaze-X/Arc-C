using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[CallbackIdentity(5303)]
	public struct ReservationNotificationCallback_t
	{
		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		public const int k_iCallback = 5303;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x0")]
		public PartyBeaconID_t m_ulBeaconID;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDJoiner;
	}
}
