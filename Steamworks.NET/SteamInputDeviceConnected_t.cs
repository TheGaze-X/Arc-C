using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[CallbackIdentity(2801)]
	public struct SteamInputDeviceConnected_t
	{
		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		public const int k_iCallback = 2801;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x0")]
		public InputHandle_t m_ulConnectedDeviceHandle;
	}
}
