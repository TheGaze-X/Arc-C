using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[CallbackIdentity(117)]
	public struct IPCFailure_t
	{
		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		public const int k_iCallback = 117;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x0")]
		public byte m_eFailureType;
	}
}
