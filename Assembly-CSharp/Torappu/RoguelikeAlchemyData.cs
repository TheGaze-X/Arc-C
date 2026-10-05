using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011AC RID: 4524
	[Token(Token = "0x20011AC")]
	public class RoguelikeAlchemyData
	{
		// Token: 0x06006F97 RID: 28567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F97")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeAlchemyData()
		{
		}

		// Token: 0x040060DD RID: 24797
		[Token(Token = "0x40060DD")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeFragmentType> fragmentTypeList;

		// Token: 0x040060DE RID: 24798
		[Token(Token = "0x40060DE")]
		[FieldOffset(Offset = "0x18")]
		public int fragmentSquareSum;

		// Token: 0x040060DF RID: 24799
		[Token(Token = "0x40060DF")]
		[FieldOffset(Offset = "0x1C")]
		public AlchemyPoolRarityType poolRarity;

		// Token: 0x040060E0 RID: 24800
		[Token(Token = "0x40060E0")]
		[FieldOffset(Offset = "0x20")]
		public float relicProp;

		// Token: 0x040060E1 RID: 24801
		[Token(Token = "0x40060E1")]
		[FieldOffset(Offset = "0x24")]
		public float shieldProp;

		// Token: 0x040060E2 RID: 24802
		[Token(Token = "0x40060E2")]
		[FieldOffset(Offset = "0x28")]
		public float populationProp;

		// Token: 0x040060E3 RID: 24803
		[Token(Token = "0x40060E3")]
		[FieldOffset(Offset = "0x30")]
		public List<string> overrideConditionBandIds;

		// Token: 0x040060E4 RID: 24804
		[Token(Token = "0x40060E4")]
		[FieldOffset(Offset = "0x38")]
		public string overrideRecipeId;
	}
}
