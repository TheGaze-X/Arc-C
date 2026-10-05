using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	[CallbackIdentity(4011)]
	public struct MusicPlayerWantsVolume_t
	{
		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		public const int k_iCallback = 4011;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
}
