using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[CallbackIdentity(4110)]
	public struct MusicPlayerWantsLooped_t
	{
		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		public const int k_iCallback = 4110;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bLooped;
	}
}
