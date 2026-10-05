using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	[CallbackIdentity(1101)]
	[StructLayout(2)]
	public struct UserStatsReceived_t
	{
		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		public const int k_iCallback = 1101;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_steamIDUser;
	}
}
