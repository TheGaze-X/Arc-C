using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012D5 RID: 4821
	[Token(Token = "0x20012D5")]
	public class SandboxV2ArchiveQuestTypeData
	{
		// Token: 0x0600724E RID: 29262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ArchiveQuestTypeData()
		{
		}

		// Token: 0x04006A82 RID: 27266
		[Token(Token = "0x4006A82")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ArchiveQuestType type;

		// Token: 0x04006A83 RID: 27267
		[Token(Token = "0x4006A83")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04006A84 RID: 27268
		[Token(Token = "0x4006A84")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;
	}
}
