using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	[CallbackIdentity(1103)]
	public struct UserAchievementStored_t
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000017")]
		public string m_rgchAchievementName
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x4ED76A0", Offset = "0x4ED62A0", VA = "0x184ED76A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x4EDDB30", Offset = "0x4EDC730", VA = "0x184EDDB30")]
			set
			{
			}
		}

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		public const int k_iCallback = 1103;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bGroupAchievement;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchAchievementName_;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x18")]
		public uint m_nCurProgress;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_nMaxProgress;
	}
}
