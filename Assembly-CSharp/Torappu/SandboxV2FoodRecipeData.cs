using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012A4 RID: 4772
	[Token(Token = "0x20012A4")]
	public class SandboxV2FoodRecipeData
	{
		// Token: 0x06007220 RID: 29216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007220")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2FoodRecipeData()
		{
		}

		// Token: 0x04006926 RID: 26918
		[Token(Token = "0x4006926")]
		[FieldOffset(Offset = "0x10")]
		public string foodId;

		// Token: 0x04006927 RID: 26919
		[Token(Token = "0x4006927")]
		[FieldOffset(Offset = "0x18")]
		public List<string> mats;
	}
}
