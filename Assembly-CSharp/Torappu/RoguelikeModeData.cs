using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200117D RID: 4477
	[Token(Token = "0x200117D")]
	public class RoguelikeModeData
	{
		// Token: 0x06006F6B RID: 28523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeModeData()
		{
		}

		// Token: 0x04005FF9 RID: 24569
		[Token(Token = "0x4005FF9")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005FFA RID: 24570
		[Token(Token = "0x4005FFA")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04005FFB RID: 24571
		[Token(Token = "0x4005FFB")]
		[FieldOffset(Offset = "0x20")]
		public int canUnlockItem;

		// Token: 0x04005FFC RID: 24572
		[Token(Token = "0x4005FFC")]
		[FieldOffset(Offset = "0x24")]
		public float scoreFactor;

		// Token: 0x04005FFD RID: 24573
		[Token(Token = "0x4005FFD")]
		[FieldOffset(Offset = "0x28")]
		public List<string> itemPools;

		// Token: 0x04005FFE RID: 24574
		[Token(Token = "0x4005FFE")]
		[FieldOffset(Offset = "0x30")]
		public string difficultyDesc;

		// Token: 0x04005FFF RID: 24575
		[Token(Token = "0x4005FFF")]
		[FieldOffset(Offset = "0x38")]
		public string ruleDesc;

		// Token: 0x04006000 RID: 24576
		[Token(Token = "0x4006000")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x04006001 RID: 24577
		[Token(Token = "0x4006001")]
		[FieldOffset(Offset = "0x48")]
		public string unlockMode;

		// Token: 0x04006002 RID: 24578
		[Token(Token = "0x4006002")]
		[FieldOffset(Offset = "0x50")]
		public string color;
	}
}
