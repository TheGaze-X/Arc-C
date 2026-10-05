using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[CallbackIdentity(331)]
	public struct GameOverlayActivated_t
	{
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		public const int k_iCallback = 331;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		public byte m_bActive;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x1")]
		public bool m_bUserInitiated;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_nAppID;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x8")]
		public uint m_dwOverlayPID;
	}
}
