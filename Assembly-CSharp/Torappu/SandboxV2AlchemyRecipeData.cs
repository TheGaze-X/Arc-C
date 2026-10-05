using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012A1 RID: 4769
	[Token(Token = "0x20012A1")]
	public class SandboxV2AlchemyRecipeData
	{
		// Token: 0x06007219 RID: 29209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007219")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2AlchemyRecipeData()
		{
		}

		// Token: 0x04006916 RID: 26902
		[Token(Token = "0x4006916")]
		[FieldOffset(Offset = "0x10")]
		public string recipeId;

		// Token: 0x04006917 RID: 26903
		[Token(Token = "0x4006917")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2AlchemyMaterialData> materials;

		// Token: 0x04006918 RID: 26904
		[Token(Token = "0x4006918")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;

		// Token: 0x04006919 RID: 26905
		[Token(Token = "0x4006919")]
		[FieldOffset(Offset = "0x28")]
		public int onceAlchemyRatio;

		// Token: 0x0400691A RID: 26906
		[Token(Token = "0x400691A")]
		[FieldOffset(Offset = "0x2C")]
		public int recipeLevel;

		// Token: 0x0400691B RID: 26907
		[Token(Token = "0x400691B")]
		[FieldOffset(Offset = "0x30")]
		public string unlockDesc;
	}
}
