using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	[CallbackIdentity(714)]
	public struct GamepadTextInputDismissed_t
	{
		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		public const int k_iCallback = 714;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bSubmitted;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x4")]
		public uint m_unSubmittedText;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_unAppID;
	}
}
