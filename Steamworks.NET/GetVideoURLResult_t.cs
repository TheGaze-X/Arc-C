using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[CallbackIdentity(4611)]
	public struct GetVideoURLResult_t
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000019")]
		public string m_rgchURL
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x4EDDA70", Offset = "0x4EDC670", VA = "0x184EDDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x4EDDB50", Offset = "0x4EDC750", VA = "0x184EDDB50")]
			set
			{
			}
		}

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		public const int k_iCallback = 4611;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchURL_;
	}
}
