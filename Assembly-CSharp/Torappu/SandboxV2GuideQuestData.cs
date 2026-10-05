using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012BB RID: 4795
	[Token(Token = "0x20012BB")]
	public class SandboxV2GuideQuestData
	{
		// Token: 0x06007237 RID: 29239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007237")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2GuideQuestData()
		{
		}

		// Token: 0x040069F1 RID: 27121
		[Token(Token = "0x40069F1")]
		[FieldOffset(Offset = "0x10")]
		public string questId;

		// Token: 0x040069F2 RID: 27122
		[Token(Token = "0x40069F2")]
		[FieldOffset(Offset = "0x18")]
		public string storyId;

		// Token: 0x040069F3 RID: 27123
		[Token(Token = "0x40069F3")]
		[FieldOffset(Offset = "0x20")]
		public string triggerKey;
	}
}
