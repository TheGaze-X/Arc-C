using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011AD RID: 4525
	[Token(Token = "0x20011AD")]
	public class RoguelikeAlchemyFormulationData
	{
		// Token: 0x06006F98 RID: 28568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F98")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeAlchemyFormulationData()
		{
		}

		// Token: 0x040060E5 RID: 24805
		[Token(Token = "0x40060E5")]
		[FieldOffset(Offset = "0x10")]
		public List<string> fragmentIds;

		// Token: 0x040060E6 RID: 24806
		[Token(Token = "0x40060E6")]
		[FieldOffset(Offset = "0x18")]
		public string rewardId;

		// Token: 0x040060E7 RID: 24807
		[Token(Token = "0x40060E7")]
		[FieldOffset(Offset = "0x20")]
		public int rewardCount;

		// Token: 0x040060E8 RID: 24808
		[Token(Token = "0x40060E8")]
		[FieldOffset(Offset = "0x24")]
		public RoguelikeGameItemType rewardItemType;
	}
}
