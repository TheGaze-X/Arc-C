using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[CallbackIdentity(201)]
	public struct GSClientApprove_t
	{
		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		public const int k_iCallback = 201;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_OwnerSteamID;
	}
}
