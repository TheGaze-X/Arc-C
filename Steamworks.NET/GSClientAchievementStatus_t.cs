using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[CallbackIdentity(206)]
	public struct GSClientAchievementStatus_t
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000007")]
		public string m_pchAchievement
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x4EDDA70", Offset = "0x4EDC670", VA = "0x184EDDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x4EDDB10", Offset = "0x4EDC710", VA = "0x184EDDB10")]
			set
			{
			}
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		public const int k_iCallback = 206;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_pchAchievement_;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUnlocked;
	}
}
