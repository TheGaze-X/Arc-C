using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[CallbackIdentity(3420)]
	public struct WorkshopEULAStatus_t
	{
		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		public const int k_iCallback = 3420;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_nAppID;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x8")]
		public uint m_unVersion;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0xC")]
		public RTime32 m_rtAction;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bAccepted;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x11")]
		public bool m_bNeedsAction;
	}
}
