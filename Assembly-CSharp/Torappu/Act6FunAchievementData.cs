using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EC1 RID: 3777
	[Token(Token = "0x2000EC1")]
	public class Act6FunAchievementData
	{
		// Token: 0x06006B91 RID: 27537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B91")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act6FunAchievementData()
		{
		}

		// Token: 0x04004FDA RID: 20442
		[Token(Token = "0x4004FDA")]
		[FieldOffset(Offset = "0x10")]
		public string achievementId;

		// Token: 0x04004FDB RID: 20443
		[Token(Token = "0x4004FDB")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004FDC RID: 20444
		[Token(Token = "0x4004FDC")]
		[FieldOffset(Offset = "0x1C")]
		public Act6FunAchievementType achievementType;

		// Token: 0x04004FDD RID: 20445
		[Token(Token = "0x4004FDD")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04004FDE RID: 20446
		[Token(Token = "0x4004FDE")]
		[FieldOffset(Offset = "0x28")]
		public string coverDesc;
	}
}
