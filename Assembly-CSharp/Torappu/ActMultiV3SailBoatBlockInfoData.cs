using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E53 RID: 3667
	[Token(Token = "0x2000E53")]
	public class ActMultiV3SailBoatBlockInfoData
	{
		// Token: 0x06006B22 RID: 27426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B22")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SailBoatBlockInfoData()
		{
		}

		// Token: 0x04004C56 RID: 19542
		[Token(Token = "0x4004C56")]
		[FieldOffset(Offset = "0x10")]
		public string blockId;

		// Token: 0x04004C57 RID: 19543
		[Token(Token = "0x4004C57")]
		[FieldOffset(Offset = "0x18")]
		public string blockLevelId;

		// Token: 0x04004C58 RID: 19544
		[Token(Token = "0x4004C58")]
		[FieldOffset(Offset = "0x20")]
		public ActMultiV3BlockDirType startDirType;

		// Token: 0x04004C59 RID: 19545
		[Token(Token = "0x4004C59")]
		[FieldOffset(Offset = "0x24")]
		public ActMultiV3BlockDirType endDirType;

		// Token: 0x04004C5A RID: 19546
		[Token(Token = "0x4004C5A")]
		[FieldOffset(Offset = "0x28")]
		public ActMultiV3BlockType blockType;
	}
}
