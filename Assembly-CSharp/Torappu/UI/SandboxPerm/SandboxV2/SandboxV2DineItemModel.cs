using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200413A RID: 16698
	[Token(Token = "0x200413A")]
	public class SandboxV2DineItemModel
	{
		// Token: 0x06019C89 RID: 105609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C89")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DineItemModel()
		{
		}

		// Token: 0x0402058C RID: 132492
		[Token(Token = "0x402058C")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0402058D RID: 132493
		[Token(Token = "0x402058D")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel item;

		// Token: 0x0402058E RID: 132494
		[Token(Token = "0x402058E")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0402058F RID: 132495
		[Token(Token = "0x402058F")]
		[FieldOffset(Offset = "0x28")]
		public string usage;

		// Token: 0x04020590 RID: 132496
		[Token(Token = "0x4020590")]
		[FieldOffset(Offset = "0x30")]
		public int duration;

		// Token: 0x04020591 RID: 132497
		[Token(Token = "0x4020591")]
		[FieldOffset(Offset = "0x38")]
		public List<SandboxV2DineItemModel.AttributeInfo> attributes;

		// Token: 0x04020592 RID: 132498
		[Token(Token = "0x4020592")]
		[FieldOffset(Offset = "0x40")]
		public int stock;

		// Token: 0x04020593 RID: 132499
		[Token(Token = "0x4020593")]
		[FieldOffset(Offset = "0x44")]
		public bool isLast;

		// Token: 0x04020594 RID: 132500
		[Token(Token = "0x4020594")]
		[FieldOffset(Offset = "0x48")]
		public SandboxV2FoodVariantType variantType;

		// Token: 0x04020595 RID: 132501
		[Token(Token = "0x4020595")]
		[FieldOffset(Offset = "0x50")]
		public List<UIItemViewModel> subMatItems;

		// Token: 0x04020596 RID: 132502
		[Token(Token = "0x4020596")]
		[FieldOffset(Offset = "0x58")]
		public SandboxV2FoodData data;

		// Token: 0x04020597 RID: 132503
		[Token(Token = "0x4020597")]
		[FieldOffset(Offset = "0x60")]
		public int priorRecipeIndex;

		// Token: 0x04020598 RID: 132504
		[Token(Token = "0x4020598")]
		[FieldOffset(Offset = "0x68")]
		public List<string> subMatIds;

		// Token: 0x04020599 RID: 132505
		[Token(Token = "0x4020599")]
		[FieldOffset(Offset = "0x70")]
		public bool selected;

		// Token: 0x0200413B RID: 16699
		[Token(Token = "0x200413B")]
		public struct AttributeInfo
		{
			// Token: 0x0402059A RID: 132506
			[Token(Token = "0x402059A")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2FoodAttribute attribute;

			// Token: 0x0402059B RID: 132507
			[Token(Token = "0x402059B")]
			[FieldOffset(Offset = "0x4")]
			public bool isSub;
		}
	}
}
