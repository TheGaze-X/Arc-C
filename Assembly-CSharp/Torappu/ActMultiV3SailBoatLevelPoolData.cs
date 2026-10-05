using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E51 RID: 3665
	[Token(Token = "0x2000E51")]
	public class ActMultiV3SailBoatLevelPoolData
	{
		// Token: 0x06006B1F RID: 27423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SailBoatLevelPoolData()
		{
		}

		// Token: 0x04004C4D RID: 19533
		[Token(Token = "0x4004C4D")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004C4E RID: 19534
		[Token(Token = "0x4004C4E")]
		[FieldOffset(Offset = "0x18")]
		public string startBlockPool;

		// Token: 0x04004C4F RID: 19535
		[Token(Token = "0x4004C4F")]
		[FieldOffset(Offset = "0x20")]
		public string midBlockPool;

		// Token: 0x04004C50 RID: 19536
		[Token(Token = "0x4004C50")]
		[FieldOffset(Offset = "0x28")]
		public string endBlockPool;
	}
}
