using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001191 RID: 4497
	[Token(Token = "0x2001191")]
	public class RoguelikeChaosPredefineData
	{
		// Token: 0x06006F81 RID: 28545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F81")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeChaosPredefineData()
		{
		}

		// Token: 0x0400605A RID: 24666
		[Token(Token = "0x400605A")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeId;

		// Token: 0x0400605B RID: 24667
		[Token(Token = "0x400605B")]
		[FieldOffset(Offset = "0x14")]
		public int modeGrade;

		// Token: 0x0400605C RID: 24668
		[Token(Token = "0x400605C")]
		[FieldOffset(Offset = "0x18")]
		public string predefinedId;

		// Token: 0x0400605D RID: 24669
		[Token(Token = "0x400605D")]
		[FieldOffset(Offset = "0x20")]
		public string chaosRuleId;
	}
}
