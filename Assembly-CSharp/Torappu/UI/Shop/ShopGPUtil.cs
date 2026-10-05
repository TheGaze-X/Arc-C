using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE1 RID: 23265
	[Token(Token = "0x2005AE1")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ShopGPUtil
	{
		// Token: 0x06021D1B RID: 138523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D1B")]
		public static T LoadShopGPPanelView<T>(ShopGPPanelType type, ILoadAsset assetLoader) where T : ShopGPDisplayPanelBase
		{
			return null;
		}

		// Token: 0x06021D1C RID: 138524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D1C")]
		[Address(RVA = "0x1C558D0", Offset = "0x1C544D0", VA = "0x181C558D0")]
		public static string GetShopGPPanelViewPath(ShopGPPanelType type)
		{
			return null;
		}

		// Token: 0x06021D1D RID: 138525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D1D")]
		[Address(RVA = "0x1C55960", Offset = "0x1C54560", VA = "0x181C55960")]
		public static Sprite LoadShopGPTabIcon(string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06021D1E RID: 138526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D1E")]
		[Address(RVA = "0x1C559E0", Offset = "0x1C545E0", VA = "0x181C559E0")]
		public static Sprite LoadShopGPTabMarker(string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06021D1F RID: 138527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D1F")]
		[Address(RVA = "0x1C55A60", Offset = "0x1C54660", VA = "0x181C55A60")]
		private static Sprite _LoadAutopackSprite(string spriteId, string hubPath, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0402E4D5 RID: 189653
		[Token(Token = "0x402E4D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadShopGPPanelView;

		// Token: 0x0402E4D6 RID: 189654
		[Token(Token = "0x402E4D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShopGPPanelViewPath;

		// Token: 0x0402E4D7 RID: 189655
		[Token(Token = "0x402E4D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadShopGPTabIcon;

		// Token: 0x0402E4D8 RID: 189656
		[Token(Token = "0x402E4D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadShopGPTabMarker;

		// Token: 0x0402E4D9 RID: 189657
		[Token(Token = "0x402E4D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadAutopackSprite;
	}
}
