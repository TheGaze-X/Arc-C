using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012DA RID: 4826
	[Token(Token = "0x20012DA")]
	public class SandboxV2ArchiveAchievementData
	{
		// Token: 0x06007256 RID: 29270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007256")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ArchiveAchievementData()
		{
		}

		// Token: 0x04006A9A RID: 27290
		[Token(Token = "0x4006A9A")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006A9B RID: 27291
		[Token(Token = "0x4006A9B")]
		[FieldOffset(Offset = "0x18")]
		public List<string> achievementType;

		// Token: 0x04006A9C RID: 27292
		[Token(Token = "0x4006A9C")]
		[FieldOffset(Offset = "0x20")]
		public int raritySortId;

		// Token: 0x04006A9D RID: 27293
		[Token(Token = "0x4006A9D")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x04006A9E RID: 27294
		[Token(Token = "0x4006A9E")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04006A9F RID: 27295
		[Token(Token = "0x4006A9F")]
		[FieldOffset(Offset = "0x30")]
		public string desc;
	}
}
