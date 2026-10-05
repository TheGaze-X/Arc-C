using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	[CallbackIdentity(4002)]
	public struct VolumeHasChanged_t
	{
		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		public const int k_iCallback = 4002;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
}
