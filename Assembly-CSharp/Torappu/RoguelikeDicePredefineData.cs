using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200118D RID: 4493
	[Token(Token = "0x200118D")]
	public class RoguelikeDicePredefineData
	{
		// Token: 0x06006F7C RID: 28540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeDicePredefineData()
		{
		}

		// Token: 0x04006044 RID: 24644
		[Token(Token = "0x4006044")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeId;

		// Token: 0x04006045 RID: 24645
		[Token(Token = "0x4006045")]
		[FieldOffset(Offset = "0x14")]
		public int modeGrade;

		// Token: 0x04006046 RID: 24646
		[Token(Token = "0x4006046")]
		[FieldOffset(Offset = "0x18")]
		public string predefinedId;

		// Token: 0x04006047 RID: 24647
		[Token(Token = "0x4006047")]
		[FieldOffset(Offset = "0x20")]
		public int initialDiceCount;
	}
}
