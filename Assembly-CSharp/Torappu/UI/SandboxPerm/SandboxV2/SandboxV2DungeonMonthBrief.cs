using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041C4 RID: 16836
	[Token(Token = "0x20041C4")]
	public struct SandboxV2DungeonMonthBrief
	{
		// Token: 0x04020B13 RID: 133907
		[Token(Token = "0x4020B13")]
		[FieldOffset(Offset = "0x0")]
		public SandboxV2DungeonMonthBrief.Status status;

		// Token: 0x04020B14 RID: 133908
		[Token(Token = "0x4020B14")]
		[FieldOffset(Offset = "0x8")]
		public TimeSpan remainTime;

		// Token: 0x04020B15 RID: 133909
		[Token(Token = "0x4020B15")]
		[FieldOffset(Offset = "0x10")]
		public bool isLast;

		// Token: 0x04020B16 RID: 133910
		[Token(Token = "0x4020B16")]
		[FieldOffset(Offset = "0x11")]
		public bool complete;

		// Token: 0x04020B17 RID: 133911
		[Token(Token = "0x4020B17")]
		[FieldOffset(Offset = "0x14")]
		public int rushCount;

		// Token: 0x04020B18 RID: 133912
		[Token(Token = "0x4020B18")]
		[FieldOffset(Offset = "0x18")]
		public int completeCount;

		// Token: 0x020041C5 RID: 16837
		[Token(Token = "0x20041C5")]
		public enum Status
		{
			// Token: 0x04020B1A RID: 133914
			[Token(Token = "0x4020B1A")]
			OFFLINE,
			// Token: 0x04020B1B RID: 133915
			[Token(Token = "0x4020B1B")]
			BEFORE_STARTING,
			// Token: 0x04020B1C RID: 133916
			[Token(Token = "0x4020B1C")]
			UPDATING,
			// Token: 0x04020B1D RID: 133917
			[Token(Token = "0x4020B1D")]
			UPDATING_IDLE,
			// Token: 0x04020B1E RID: 133918
			[Token(Token = "0x4020B1E")]
			FULL_STORE
		}
	}
}
