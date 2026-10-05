using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001044 RID: 4164
	[Token(Token = "0x2001044")]
	public class BattleEquipPerLevelPack
	{
		// Token: 0x06006DAC RID: 28076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAC")]
		[Address(RVA = "0x20FEE70", Offset = "0x20FDA70", VA = "0x1820FEE70")]
		public BattleEquipPerLevelPack()
		{
		}

		// Token: 0x04005888 RID: 22664
		[Token(Token = "0x4005888")]
		[FieldOffset(Offset = "0x10")]
		public int equipLevel;

		// Token: 0x04005889 RID: 22665
		[Token(Token = "0x4005889")]
		[FieldOffset(Offset = "0x18")]
		public List<BattleUniEquipData> parts;

		// Token: 0x0400588A RID: 22666
		[Token(Token = "0x400588A")]
		[FieldOffset(Offset = "0x20")]
		public Blackboard attributeBlackboard;

		// Token: 0x0400588B RID: 22667
		[Token(Token = "0x400588B")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Blackboard> tokenAttributeBlackboard;
	}
}
