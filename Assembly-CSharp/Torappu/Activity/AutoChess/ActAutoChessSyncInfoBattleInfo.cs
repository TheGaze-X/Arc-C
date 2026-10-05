using System;
using Il2CppDummyDll;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070E4 RID: 28900
	[Token(Token = "0x20070E4")]
	public class ActAutoChessSyncInfoBattleInfo
	{
		// Token: 0x06029166 RID: 168294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029166")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActAutoChessSyncInfoBattleInfo()
		{
		}

		// Token: 0x0403AA25 RID: 240165
		[Token(Token = "0x403AA25")]
		[FieldOffset(Offset = "0x10")]
		public string sceneId;

		// Token: 0x0403AA26 RID: 240166
		[Token(Token = "0x403AA26")]
		[FieldOffset(Offset = "0x18")]
		public string address;

		// Token: 0x0403AA27 RID: 240167
		[Token(Token = "0x403AA27")]
		[FieldOffset(Offset = "0x20")]
		public string token;

		// Token: 0x0403AA28 RID: 240168
		[Token(Token = "0x403AA28")]
		[FieldOffset(Offset = "0x28")]
		public string modeId;

		// Token: 0x0403AA29 RID: 240169
		[Token(Token = "0x403AA29")]
		[FieldOffset(Offset = "0x30")]
		public long endTime;

		// Token: 0x0403AA2A RID: 240170
		[Token(Token = "0x403AA2A")]
		[FieldOffset(Offset = "0x38")]
		public int curRound;
	}
}
