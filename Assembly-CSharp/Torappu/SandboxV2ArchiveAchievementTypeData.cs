using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012DB RID: 4827
	[Token(Token = "0x20012DB")]
	public class SandboxV2ArchiveAchievementTypeData : IComparable<SandboxV2ArchiveAchievementTypeData>
	{
		// Token: 0x06007257 RID: 29271 RVA: 0x00032D90 File Offset: 0x00030F90
		[Token(Token = "0x6007257")]
		[Address(RVA = "0x220E430", Offset = "0x220D030", VA = "0x18220E430", Slot = "4")]
		public int CompareTo(SandboxV2ArchiveAchievementTypeData other)
		{
			return 0;
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007258")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ArchiveAchievementTypeData()
		{
		}

		// Token: 0x04006AA0 RID: 27296
		[Token(Token = "0x4006AA0")]
		[FieldOffset(Offset = "0x10")]
		public string achievementType;

		// Token: 0x04006AA1 RID: 27297
		[Token(Token = "0x4006AA1")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04006AA2 RID: 27298
		[Token(Token = "0x4006AA2")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;
	}
}
