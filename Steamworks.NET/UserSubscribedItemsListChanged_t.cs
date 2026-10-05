using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[CallbackIdentity(3418)]
	public struct UserSubscribedItemsListChanged_t
	{
		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		public const int k_iCallback = 3418;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
}
