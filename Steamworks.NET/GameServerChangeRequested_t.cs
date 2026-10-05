using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[CallbackIdentity(332)]
	public struct GameServerChangeRequested_t
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000002")]
		public string m_rgchServer
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x4EDDB70", Offset = "0x4EDC770", VA = "0x184EDDB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x4EDDC30", Offset = "0x4EDC830", VA = "0x184EDDC30")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000003")]
		public string m_rgchPassword
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x4EDDA70", Offset = "0x4EDC670", VA = "0x184EDDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x4EDDC10", Offset = "0x4EDC810", VA = "0x184EDDC10")]
			set
			{
			}
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		public const int k_iCallback = 332;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		private byte[] m_rgchServer_;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchPassword_;
	}
}
