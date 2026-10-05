using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200118A RID: 4490
	[Token(Token = "0x200118A")]
	public class RoguelikeDiceData
	{
		// Token: 0x06006F79 RID: 28537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F79")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeDiceData()
		{
		}

		// Token: 0x04006032 RID: 24626
		[Token(Token = "0x4006032")]
		[FieldOffset(Offset = "0x10")]
		public string diceId;

		// Token: 0x04006033 RID: 24627
		[Token(Token = "0x4006033")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x04006034 RID: 24628
		[Token(Token = "0x4006034")]
		[FieldOffset(Offset = "0x20")]
		public int isUpgradeDice;

		// Token: 0x04006035 RID: 24629
		[Token(Token = "0x4006035")]
		[FieldOffset(Offset = "0x28")]
		public string upgradeDiceId;

		// Token: 0x04006036 RID: 24630
		[Token(Token = "0x4006036")]
		[FieldOffset(Offset = "0x30")]
		public int diceFaceCount;

		// Token: 0x04006037 RID: 24631
		[Token(Token = "0x4006037")]
		[FieldOffset(Offset = "0x38")]
		public string battleDiceId;
	}
}
