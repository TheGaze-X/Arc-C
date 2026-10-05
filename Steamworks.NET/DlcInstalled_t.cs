using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[CallbackIdentity(1005)]
	public struct DlcInstalled_t
	{
		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		public const int k_iCallback = 1005;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
}
