using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001216 RID: 4630
	[Token(Token = "0x2001216")]
	public class RoguelikeGameChoiceData
	{
		// Token: 0x06007014 RID: 28692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007014")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameChoiceData()
		{
		}

		// Token: 0x04006401 RID: 25601
		[Token(Token = "0x4006401")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006402 RID: 25602
		[Token(Token = "0x4006402")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04006403 RID: 25603
		[Token(Token = "0x4006403")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04006404 RID: 25604
		[Token(Token = "0x4006404")]
		[FieldOffset(Offset = "0x28")]
		public string lockedCoverDesc;

		// Token: 0x04006405 RID: 25605
		[Token(Token = "0x4006405")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeGameChoiceType type;

		// Token: 0x04006406 RID: 25606
		[Token(Token = "0x4006406")]
		[FieldOffset(Offset = "0x34")]
		public RoguelikeChoiceLeftDecoType leftDecoType;

		// Token: 0x04006407 RID: 25607
		[Token(Token = "0x4006407")]
		[FieldOffset(Offset = "0x38")]
		public string nextSceneId;

		// Token: 0x04006408 RID: 25608
		[Token(Token = "0x4006408")]
		[FieldOffset(Offset = "0x40")]
		public string icon;

		// Token: 0x04006409 RID: 25609
		[Token(Token = "0x4006409")]
		[FieldOffset(Offset = "0x48")]
		public RoguelikeChoiceDisplayData displayData;

		// Token: 0x0400640A RID: 25610
		[Token(Token = "0x400640A")]
		[FieldOffset(Offset = "0x50")]
		public bool forceShowWhenOnlyLeave;
	}
}
