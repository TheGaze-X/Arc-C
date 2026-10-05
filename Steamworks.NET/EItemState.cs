using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	[Flags]
	public enum EItemState
	{
		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		k_EItemStateNone = 0,
		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		k_EItemStateSubscribed = 1,
		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		k_EItemStateLegacyItem = 2,
		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		k_EItemStateInstalled = 4,
		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		k_EItemStateNeedsUpdate = 8,
		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		k_EItemStateDownloading = 16,
		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		k_EItemStateDownloadPending = 32,
		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		k_EItemStateDisabledLocally = 64
	}
}
