using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E58 RID: 3672
	[Token(Token = "0x2000E58")]
	public class ServerActRecruitOnlyData
	{
		// Token: 0x06006B27 RID: 27431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B27")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ServerActRecruitOnlyData()
		{
		}

		// Token: 0x04004CDA RID: 19674
		[Token(Token = "0x4004CDA")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04004CDB RID: 19675
		[Token(Token = "0x4004CDB")]
		[FieldOffset(Offset = "0x18")]
		public int tagId;

		// Token: 0x04004CDC RID: 19676
		[Token(Token = "0x4004CDC")]
		[FieldOffset(Offset = "0x1C")]
		public int tagTimes;

		// Token: 0x04004CDD RID: 19677
		[Token(Token = "0x4004CDD")]
		[FieldOffset(Offset = "0x20")]
		public long startTime;

		// Token: 0x04004CDE RID: 19678
		[Token(Token = "0x4004CDE")]
		[FieldOffset(Offset = "0x28")]
		public long endTime;
	}
}
