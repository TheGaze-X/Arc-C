using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001219 RID: 4633
	[Token(Token = "0x2001219")]
	public class RoguelikeGameNodeSubTypeData
	{
		// Token: 0x06007017 RID: 28695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007017")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameNodeSubTypeData()
		{
		}

		// Token: 0x04006414 RID: 25620
		[Token(Token = "0x4006414")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeEventType eventType;

		// Token: 0x04006415 RID: 25621
		[Token(Token = "0x4006415")]
		[FieldOffset(Offset = "0x14")]
		public int subTypeId;

		// Token: 0x04006416 RID: 25622
		[Token(Token = "0x4006416")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x04006417 RID: 25623
		[Token(Token = "0x4006417")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04006418 RID: 25624
		[Token(Token = "0x4006418")]
		[FieldOffset(Offset = "0x28")]
		public string description;
	}
}
