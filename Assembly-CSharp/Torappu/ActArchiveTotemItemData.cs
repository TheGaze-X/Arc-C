using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C4C RID: 3148
	[Token(Token = "0x2000C4C")]
	public class ActArchiveTotemItemData
	{
		// Token: 0x06006930 RID: 26928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006930")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveTotemItemData()
		{
		}

		// Token: 0x04004028 RID: 16424
		[Token(Token = "0x4004028")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004029 RID: 16425
		[Token(Token = "0x4004029")]
		[FieldOffset(Offset = "0x18")]
		public ActArchiveTotemType type;

		// Token: 0x0400402A RID: 16426
		[Token(Token = "0x400402A")]
		[FieldOffset(Offset = "0x20")]
		public string enrollConditionId;

		// Token: 0x0400402B RID: 16427
		[Token(Token = "0x400402B")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
