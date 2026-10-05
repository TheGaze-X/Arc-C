using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[CallbackIdentity(350)]
	public struct EquippedProfileItemsChanged_t
	{
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		public const int k_iCallback = 350;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamID;
	}
}
