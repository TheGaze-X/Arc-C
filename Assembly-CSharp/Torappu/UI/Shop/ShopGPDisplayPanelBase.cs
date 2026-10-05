using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC9 RID: 23241
	[Token(Token = "0x2005AC9")]
	public abstract class ShopGPDisplayPanelBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x06021C85 RID: 138373
		[Token(Token = "0x17004F1A")]
		protected abstract ShopGPPanelType type { [Token(Token = "0x6021C85")] get; }

		// Token: 0x06021C86 RID: 138374
		[Token(Token = "0x6021C86")]
		public abstract void Show(bool isShow, bool fastMode = false);

		// Token: 0x06021C87 RID: 138375
		[Token(Token = "0x6021C87")]
		public abstract void Render(AbstractShopGPPanelModel model);

		// Token: 0x06021C88 RID: 138376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C88")]
		[Address(RVA = "0x1C41AD0", Offset = "0x1C406D0", VA = "0x181C41AD0")]
		protected ShopGPDisplayPanelBase()
		{
		}

		// Token: 0x0402E3D8 RID: 189400
		[Token(Token = "0x402E3D8")]
		[FieldOffset(Offset = "0x18")]
		protected bool isShow;

		// Token: 0x0402E3D9 RID: 189401
		[Token(Token = "0x402E3D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
