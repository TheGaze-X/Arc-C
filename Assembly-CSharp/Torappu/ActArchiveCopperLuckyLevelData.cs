using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C31 RID: 3121
	[Token(Token = "0x2000C31")]
	public class ActArchiveCopperLuckyLevelData
	{
		// Token: 0x0600690F RID: 26895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveCopperLuckyLevelData()
		{
		}

		// Token: 0x04003FD5 RID: 16341
		[Token(Token = "0x4003FD5")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeCopperLuckyLevel luckyLevel;

		// Token: 0x04003FD6 RID: 16342
		[Token(Token = "0x4003FD6")]
		[FieldOffset(Offset = "0x18")]
		public string luckyName;

		// Token: 0x04003FD7 RID: 16343
		[Token(Token = "0x4003FD7")]
		[FieldOffset(Offset = "0x20")]
		public string luckyDesc;

		// Token: 0x04003FD8 RID: 16344
		[Token(Token = "0x4003FD8")]
		[FieldOffset(Offset = "0x28")]
		public string luckyUsage;
	}
}
