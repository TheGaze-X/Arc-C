using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[CallbackIdentity(202)]
	public struct GSClientDeny_t
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000006")]
		public string m_rgchOptionalText
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x4ED76A0", Offset = "0x4ED62A0", VA = "0x184ED76A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x4EDDB30", Offset = "0x4EDC730", VA = "0x184EDDB30")]
			set
			{
			}
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		public const int k_iCallback = 202;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchOptionalText_;
	}
}
