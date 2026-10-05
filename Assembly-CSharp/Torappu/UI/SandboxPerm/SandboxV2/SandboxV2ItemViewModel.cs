using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004128 RID: 16680
	[Token(Token = "0x2004128")]
	public static class SandboxV2ItemViewModel
	{
		// Token: 0x06019C48 RID: 105544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019C48")]
		[Address(RVA = "0x12B5830", Offset = "0x12B4430", VA = "0x1812B5830")]
		public static SandboxV2ItemViewModel.SandboxV2ItemPlugin sbv2(this UIItemViewModel itemViewModel)
		{
			return null;
		}

		// Token: 0x06019C49 RID: 105545 RVA: 0x0009F588 File Offset: 0x0009D788
		[Token(Token = "0x6019C49")]
		[Address(RVA = "0x12B57D0", Offset = "0x12B43D0", VA = "0x1812B57D0")]
		public static SandboxV2FoodVariantShowType GetFoodSubType(this UIItemViewModel itemViewModel)
		{
			return SandboxV2FoodVariantShowType.NONE;
		}

		// Token: 0x02004129 RID: 16681
		[Token(Token = "0x2004129")]
		public class SandboxV2ItemPlugin : IItemViewModelPlugin, IHotfixable
		{
			// Token: 0x06019C4A RID: 105546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C4A")]
			[Address(RVA = "0x12B5770", Offset = "0x12B4370", VA = "0x1812B5770")]
			public SandboxV2ItemPlugin()
			{
			}

			// Token: 0x040204FB RID: 132347
			[Token(Token = "0x40204FB")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2FoodVariantShowType foodVariantShowType;

			// Token: 0x040204FC RID: 132348
			[Token(Token = "0x40204FC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
