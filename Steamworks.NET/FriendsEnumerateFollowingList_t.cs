using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[CallbackIdentity(346)]
	public struct FriendsEnumerateFollowingList_t
	{
		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		public const int k_iCallback = 346;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID[] m_rgSteamID;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		public int m_nResultsReturned;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x14")]
		public int m_nTotalResultCount;
	}
}
