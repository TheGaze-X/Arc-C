using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EB4 RID: 3764
	[Token(Token = "0x2000EB4")]
	public class Act5FunChoiceRewardData
	{
		// Token: 0x06006B86 RID: 27526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B86")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunChoiceRewardData()
		{
		}

		// Token: 0x04004F99 RID: 20377
		[Token(Token = "0x4004F99")]
		[FieldOffset(Offset = "0x10")]
		public string choiceId;

		// Token: 0x04004F9A RID: 20378
		[Token(Token = "0x4004F9A")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04004F9B RID: 20379
		[Token(Token = "0x4004F9B")]
		[FieldOffset(Offset = "0x20")]
		public float percentage;

		// Token: 0x04004F9C RID: 20380
		[Token(Token = "0x4004F9C")]
		[FieldOffset(Offset = "0x24")]
		public bool isSpecialStyle;
	}
}
