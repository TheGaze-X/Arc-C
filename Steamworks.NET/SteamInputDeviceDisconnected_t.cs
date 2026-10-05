using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[CallbackIdentity(2802)]
	public struct SteamInputDeviceDisconnected_t
	{
		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		public const int k_iCallback = 2802;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x0")]
		public InputHandle_t m_ulDisconnectedDeviceHandle;
	}
}
