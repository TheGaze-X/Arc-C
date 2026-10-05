using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ACA RID: 23242
	[Token(Token = "0x2005ACA")]
	public abstract class ShopGPDisplayPanelBase<T> : ShopGPDisplayPanelBase where T : AbstractShopGPPanelModel
	{
		// Token: 0x06021C89 RID: 138377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C89")]
		public sealed override void Render(AbstractShopGPPanelModel model)
		{
		}

		// Token: 0x06021C8A RID: 138378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C8A")]
		public sealed override void Show(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x06021C8B RID: 138379
		[Token(Token = "0x6021C8B")]
		protected abstract void OnRender(T panelModel);

		// Token: 0x06021C8C RID: 138380
		[Token(Token = "0x6021C8C")]
		protected abstract void SetShow(bool isShow, bool fastMode = false);

		// Token: 0x06021C8D RID: 138381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C8D")]
		protected ShopGPDisplayPanelBase()
		{
		}

		// Token: 0x0402E3DA RID: 189402
		[Token(Token = "0x402E3DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E3DB RID: 189403
		[Token(Token = "0x402E3DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0402E3DC RID: 189404
		[Token(Token = "0x402E3DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
