using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	[CallbackIdentity(164)]
	public struct GameWebCallback_t
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000015")]
		public string m_szURL
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x4EDDB70", Offset = "0x4EDC770", VA = "0x184EDDB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x4EDE740", Offset = "0x4EDD340", VA = "0x184EDE740")]
			set
			{
			}
		}

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		public const int k_iCallback = 164;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x0")]
		private byte[] m_szURL_;
	}
}
