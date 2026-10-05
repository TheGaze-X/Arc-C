using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E63 RID: 3683
	[Token(Token = "0x2000E63")]
	public class ActVecBreakV2DefenseBasicData
	{
		// Token: 0x06006B32 RID: 27442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B32")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2DefenseBasicData()
		{
		}

		// Token: 0x04004D1A RID: 19738
		[Token(Token = "0x4004D1A")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004D1B RID: 19739
		[Token(Token = "0x4004D1B")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x04004D1C RID: 19740
		[Token(Token = "0x4004D1C")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04004D1D RID: 19741
		[Token(Token = "0x4004D1D")]
		[FieldOffset(Offset = "0x28")]
		public long startTs;
	}
}
