using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[CallbackIdentity(211)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		public const int k_iCallback = 211;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x4")]
		public int m_cPlayersThatDontLikeCandidate;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x8")]
		public int m_cPlayersThatCandidateDoesntLike;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0xC")]
		public int m_cClanPlayersThatDontLikeCandidate;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDCandidate;
	}
}
