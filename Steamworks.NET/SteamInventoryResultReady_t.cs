using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[CallbackIdentity(4700)]
	public struct SteamInventoryResultReady_t
	{
		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		public const int k_iCallback = 4700;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
}
