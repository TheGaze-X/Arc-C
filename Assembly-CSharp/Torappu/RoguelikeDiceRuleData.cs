using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200118C RID: 4492
	[Token(Token = "0x200118C")]
	public class RoguelikeDiceRuleData
	{
		// Token: 0x06006F7B RID: 28539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeDiceRuleData()
		{
		}

		// Token: 0x0400603A RID: 24634
		[Token(Token = "0x400603A")]
		[FieldOffset(Offset = "0x10")]
		public int dicePointMax;

		// Token: 0x0400603B RID: 24635
		[Token(Token = "0x400603B")]
		[FieldOffset(Offset = "0x14")]
		public DiceResultClass diceResultClass;

		// Token: 0x0400603C RID: 24636
		[Token(Token = "0x400603C")]
		[FieldOffset(Offset = "0x18")]
		public string diceGroupId;

		// Token: 0x0400603D RID: 24637
		[Token(Token = "0x400603D")]
		[FieldOffset(Offset = "0x20")]
		public string diceEventId;

		// Token: 0x0400603E RID: 24638
		[Token(Token = "0x400603E")]
		[FieldOffset(Offset = "0x28")]
		public string resultDesc;

		// Token: 0x0400603F RID: 24639
		[Token(Token = "0x400603F")]
		[FieldOffset(Offset = "0x30")]
		public DiceResultShowType showType;

		// Token: 0x04006040 RID: 24640
		[Token(Token = "0x4006040")]
		[FieldOffset(Offset = "0x34")]
		public bool canReroll;

		// Token: 0x04006041 RID: 24641
		[Token(Token = "0x4006041")]
		[FieldOffset(Offset = "0x38")]
		public string diceEndingScene;

		// Token: 0x04006042 RID: 24642
		[Token(Token = "0x4006042")]
		[FieldOffset(Offset = "0x40")]
		public string diceEndingDesc;

		// Token: 0x04006043 RID: 24643
		[Token(Token = "0x4006043")]
		[FieldOffset(Offset = "0x48")]
		public string sound;
	}
}
