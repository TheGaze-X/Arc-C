using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C05 RID: 3077
	[Token(Token = "0x2000C05")]
	public class PlayerTrainingCampStage
	{
		// Token: 0x06006899 RID: 26777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006899")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerTrainingCampStage()
		{
		}

		// Token: 0x04003EC7 RID: 16071
		[Token(Token = "0x4003EC7")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04003EC8 RID: 16072
		[Token(Token = "0x4003EC8")]
		[FieldOffset(Offset = "0x18")]
		public int state;

		// Token: 0x04003EC9 RID: 16073
		[Token(Token = "0x4003EC9")]
		[FieldOffset(Offset = "0x20")]
		public long rts;
	}
}
