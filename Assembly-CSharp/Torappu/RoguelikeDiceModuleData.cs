using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001189 RID: 4489
	[Token(Token = "0x2001189")]
	public class RoguelikeDiceModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06006F77 RID: 28535 RVA: 0x000326B8 File Offset: 0x000308B8
		[Token(Token = "0x17000D3C")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F77")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F78")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeDiceModuleData()
		{
		}

		// Token: 0x0400602D RID: 24621
		[Token(Token = "0x400602D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeDiceData> dice;

		// Token: 0x0400602E RID: 24622
		[Token(Token = "0x400602E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeDiceRuleData> diceEvents;

		// Token: 0x0400602F RID: 24623
		[Token(Token = "0x400602F")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> diceChoices;

		// Token: 0x04006030 RID: 24624
		[Token(Token = "0x4006030")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RoguelikeDiceRuleGroupData> diceRuleGroups;

		// Token: 0x04006031 RID: 24625
		[Token(Token = "0x4006031")]
		[FieldOffset(Offset = "0x30")]
		public List<RoguelikeDicePredefineData> dicePredefines;
	}
}
