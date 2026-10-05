using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040DD RID: 16605
	[Token(Token = "0x20040DD")]
	public class SandboxV2AdminMainShopItemHolder : IHotfixable
	{
		// Token: 0x06019AF4 RID: 105204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AF4")]
		[Address(RVA = "0x1283A40", Offset = "0x1282640", VA = "0x181283A40")]
		public SandboxV2AdminMainShopItemHolder()
		{
		}

		// Token: 0x040201F3 RID: 131571
		[Token(Token = "0x40201F3")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2AdminMainShopItemView itemView;

		// Token: 0x040201F4 RID: 131572
		[Token(Token = "0x40201F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
