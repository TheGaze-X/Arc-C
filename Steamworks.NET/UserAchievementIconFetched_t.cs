using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	[CallbackIdentity(1109)]
	public struct UserAchievementIconFetched_t
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000018")]
		public string m_rgchAchievementName
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x4EDDA70", Offset = "0x4EDC670", VA = "0x184EDDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x4EDDB10", Offset = "0x4EDC710", VA = "0x184EDDB10")]
			set
			{
			}
		}

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		public const int k_iCallback = 1109;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x0")]
		public CGameID m_nGameID;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchAchievementName_;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bAchieved;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x14")]
		public int m_nIconHandle;
	}
}
