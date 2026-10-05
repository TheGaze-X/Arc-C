using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[CallbackIdentity(165)]
	public struct StoreAuthURLResponse_t
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000016")]
		public string m_szURL
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x4EDDB70", Offset = "0x4EDC770", VA = "0x184EDDB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x4F18F20", Offset = "0x4F17B20", VA = "0x184F18F20")]
			set
			{
			}
		}

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		public const int k_iCallback = 165;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x0")]
		private byte[] m_szURL_;
	}
}
