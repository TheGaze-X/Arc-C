using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040AF RID: 16559
	[Token(Token = "0x20040AF")]
	public class SandboxV2AdminMainInventoryItemModel : IHotfixable
	{
		// Token: 0x060199DB RID: 104923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199DB")]
		[Address(RVA = "0x12745C0", Offset = "0x12731C0", VA = "0x1812745C0")]
		public SandboxV2AdminMainInventoryItemModel(SandboxPermItemData item, UIItemViewModel vm)
		{
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x060199DC RID: 104924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060199DD RID: 104925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D20")]
		public SandboxPermItemData itemData
		{
			[Token(Token = "0x60199DC")]
			[Address(RVA = "0x12746E0", Offset = "0x12732E0", VA = "0x1812746E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60199DD")]
			[Address(RVA = "0x12747A0", Offset = "0x12733A0", VA = "0x1812747A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x060199DE RID: 104926 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060199DF RID: 104927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D21")]
		public UIItemViewModel viewModel
		{
			[Token(Token = "0x60199DE")]
			[Address(RVA = "0x1274740", Offset = "0x1273340", VA = "0x181274740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60199DF")]
			[Address(RVA = "0x1274820", Offset = "0x1273420", VA = "0x181274820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x04020007 RID: 131079
		[Token(Token = "0x4020007")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2FoodVariantInfo? foodVariantInfo;

		// Token: 0x04020008 RID: 131080
		[Token(Token = "0x4020008")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04020009 RID: 131081
		[Token(Token = "0x4020009")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemData;

		// Token: 0x0402000A RID: 131082
		[Token(Token = "0x402000A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_itemData;

		// Token: 0x0402000B RID: 131083
		[Token(Token = "0x402000B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x0402000C RID: 131084
		[Token(Token = "0x402000C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_viewModel;
	}
}
