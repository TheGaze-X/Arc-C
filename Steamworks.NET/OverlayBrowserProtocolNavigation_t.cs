using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[CallbackIdentity(349)]
	public struct OverlayBrowserProtocolNavigation_t
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000005")]
		public string rgchURI
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x4EDDB70", Offset = "0x4EDC770", VA = "0x184EDDB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x4F0C7D0", Offset = "0x4F0B3D0", VA = "0x184F0C7D0")]
			set
			{
			}
		}

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		public const int k_iCallback = 349;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x0")]
		private byte[] rgchURI_;
	}
}
