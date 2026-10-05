using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[CallbackIdentity(1331)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		public const int k_iCallback = 1331;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
