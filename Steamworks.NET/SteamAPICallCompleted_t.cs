using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	[CallbackIdentity(703)]
	public struct SteamAPICallCompleted_t
	{
		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		public const int k_iCallback = 703;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hAsyncCall;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x8")]
		public int m_iCallback;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xC")]
		public uint m_cubParam;
	}
}
