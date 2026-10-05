using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A66 RID: 2662
	[Token(Token = "0x2000A66")]
	public class PlayerBuildingMessageLeave
	{
		// Token: 0x06006725 RID: 26405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006725")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingMessageLeave()
		{
		}

		// Token: 0x0400388D RID: 14477
		[Token(Token = "0x400388D")]
		[FieldOffset(Offset = "0x10")]
		public bool inUse;

		// Token: 0x0400388E RID: 14478
		[Token(Token = "0x400388E")]
		[FieldOffset(Offset = "0x18")]
		public long lastVisitTs;

		// Token: 0x0400388F RID: 14479
		[Token(Token = "0x400388F")]
		[FieldOffset(Offset = "0x20")]
		public long lastShowTs;

		// Token: 0x04003890 RID: 14480
		[Token(Token = "0x4003890")]
		[FieldOffset(Offset = "0x28")]
		public long lastUpdateSpTs;

		// Token: 0x04003891 RID: 14481
		[Token(Token = "0x4003891")]
		[FieldOffset(Offset = "0x30")]
		public PlayerBuildingMessageLeaveSP sp;
	}
}
