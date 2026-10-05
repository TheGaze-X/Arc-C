using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[CallbackIdentity(1701)]
	public struct GCMessageAvailable_t
	{
		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		public const int k_iCallback = 1701;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x0")]
		public uint m_nMessageSize;
	}
}
