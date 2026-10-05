using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[CallbackIdentity(4701)]
	public struct SteamInventoryFullUpdate_t
	{
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		public const int k_iCallback = 4701;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;
	}
}
