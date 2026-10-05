using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[CallbackIdentity(4705)]
	public struct SteamInventoryRequestPricesResult_t
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000008")]
		public string m_rgchCurrency
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x4EDDA70", Offset = "0x4EDC670", VA = "0x184EDDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x4F0E290", Offset = "0x4F0CE90", VA = "0x184F0E290")]
			set
			{
			}
		}

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		public const int k_iCallback = 4705;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_result;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchCurrency_;
	}
}
