using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200407B RID: 16507
	[Token(Token = "0x200407B")]
	public class SandboxV2CookFoodListItemModel : SandboxV2AdminMainListItemModel
	{
		// Token: 0x06019884 RID: 104580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019884")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2CookFoodListItemModel()
		{
		}

		// Token: 0x0401FD53 RID: 130387
		[Token(Token = "0x401FD53")]
		[FieldOffset(Offset = "0x30")]
		public SandboxV2FoodData data;

		// Token: 0x0401FD54 RID: 130388
		[Token(Token = "0x401FD54")]
		[FieldOffset(Offset = "0x38")]
		public SandboxV2FoodAttribute attribute;

		// Token: 0x0401FD55 RID: 130389
		[Token(Token = "0x401FD55")]
		[FieldOffset(Offset = "0x3C")]
		public bool canCook;

		// Token: 0x0401FD56 RID: 130390
		[Token(Token = "0x401FD56")]
		[FieldOffset(Offset = "0x40")]
		public int priorRecipeIndex;
	}
}
