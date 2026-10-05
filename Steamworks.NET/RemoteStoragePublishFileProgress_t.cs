using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[CallbackIdentity(1329)]
	public struct RemoteStoragePublishFileProgress_t
	{
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		public const int k_iCallback = 1329;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x0")]
		public double m_dPercentFile;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bPreview;
	}
}
