using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041B5 RID: 16821
	[Token(Token = "0x20041B5")]
	public struct SandboxV2DungeonReadArchiveCurDayInfoItemData
	{
		// Token: 0x06019F0D RID: 106253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F0D")]
		[Address(RVA = "0x12DF220", Offset = "0x12DDE20", VA = "0x1812DF220")]
		public SandboxV2DungeonReadArchiveCurDayInfoItemData(int day, int useAp, int maxAp, string title)
		{
		}

		// Token: 0x04020A90 RID: 133776
		[Token(Token = "0x4020A90")]
		[FieldOffset(Offset = "0x0")]
		public readonly int curDay;

		// Token: 0x04020A91 RID: 133777
		[Token(Token = "0x4020A91")]
		[FieldOffset(Offset = "0x4")]
		public readonly int maxApCount;

		// Token: 0x04020A92 RID: 133778
		[Token(Token = "0x4020A92")]
		[FieldOffset(Offset = "0x8")]
		public readonly int usedApCount;

		// Token: 0x04020A93 RID: 133779
		[Token(Token = "0x4020A93")]
		[FieldOffset(Offset = "0x10")]
		public readonly string dayTitle;
	}
}
