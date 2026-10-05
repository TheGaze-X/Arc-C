using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012A7 RID: 4775
	[Token(Token = "0x20012A7")]
	public class SandboxV2FoodData
	{
		// Token: 0x06007222 RID: 29218 RVA: 0x00032CB8 File Offset: 0x00030EB8
		[Token(Token = "0x6007222")]
		[Address(RVA = "0x2210190", Offset = "0x220ED90", VA = "0x182210190")]
		public bool ShouldSerializerecipes()
		{
			return default(bool);
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007223")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2FoodData()
		{
		}

		// Token: 0x04006930 RID: 26928
		[Token(Token = "0x4006930")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006931 RID: 26929
		[Token(Token = "0x4006931")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2FoodAttribute> attributes;

		// Token: 0x04006932 RID: 26930
		[Token(Token = "0x4006932")]
		[FieldOffset(Offset = "0x20")]
		public List<SandboxV2FoodRecipeData> recipes;

		// Token: 0x04006933 RID: 26931
		[Token(Token = "0x4006933")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2FoodVariantData> variants;

		// Token: 0x04006934 RID: 26932
		[Token(Token = "0x4006934")]
		[FieldOffset(Offset = "0x30")]
		public int duration;

		// Token: 0x04006935 RID: 26933
		[Token(Token = "0x4006935")]
		[FieldOffset(Offset = "0x34")]
		public int sortId;
	}
}
