using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[CallbackIdentity(337)]
	public struct GameRichPresenceJoinRequested_t
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000004")]
		public string m_rgchConnect
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x4EDDA70", Offset = "0x4EDC670", VA = "0x184EDDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x4EDDB50", Offset = "0x4EDC750", VA = "0x184EDDB50")]
			set
			{
			}
		}

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		public const int k_iCallback = 337;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchConnect_;
	}
}
