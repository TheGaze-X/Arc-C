using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public enum UpdateMode
	{
		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		Nothing,
		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		OnlyAnimationStatus,
		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		OnlyEventTimelines = 4,
		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		EverythingExceptMesh = 2,
		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		FullUpdate
	}
}
