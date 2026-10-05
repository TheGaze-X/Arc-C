using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[CallbackIdentity(4109)]
	public struct MusicPlayerWantsShuffled_t
	{
		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		public const int k_iCallback = 4109;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bShuffled;
	}
}
