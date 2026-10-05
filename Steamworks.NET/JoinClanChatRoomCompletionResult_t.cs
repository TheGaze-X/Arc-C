using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[CallbackIdentity(342)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		public const int k_iCallback = 342;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x8")]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}
