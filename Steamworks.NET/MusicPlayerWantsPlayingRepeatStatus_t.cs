using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[CallbackIdentity(4114)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		public const int k_iCallback = 4114;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x0")]
		public int m_nPlayingRepeatStatus;
	}
}
