using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054EF RID: 21743
	[Token(Token = "0x20054EF")]
	public class RoguelikeGoodsObjDiscountView : RoguelikeGoodsObjPlugin
	{
		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x0601FFBB RID: 131003 RVA: 0x000B4180 File Offset: 0x000B2380
		[Token(Token = "0x17004AFA")]
		public override RoguelikeShopGoodPluginType pluginType
		{
			[Token(Token = "0x601FFBB")]
			[Address(RVA = "0x1A1BC50", Offset = "0x1A1A850", VA = "0x181A1BC50", Slot = "4")]
			get
			{
				return RoguelikeShopGoodPluginType.NONE;
			}
		}

		// Token: 0x0601FFBC RID: 131004 RVA: 0x000B4198 File Offset: 0x000B2398
		[Token(Token = "0x601FFBC")]
		[Address(RVA = "0x1A1B7D0", Offset = "0x1A1A3D0", VA = "0x181A1B7D0", Slot = "5")]
		public override bool NeedShowPlugin(RoguelikeGoodsViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601FFBD RID: 131005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFBD")]
		[Address(RVA = "0x1A1B880", Offset = "0x1A1A480", VA = "0x181A1B880", Slot = "6")]
		public override void Render(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFBE RID: 131006 RVA: 0x000B41B0 File Offset: 0x000B23B0
		[Token(Token = "0x601FFBE")]
		[Address(RVA = "0x1A1BB30", Offset = "0x1A1A730", VA = "0x181A1BB30")]
		private bool _HasDiscountPrice(RoguelikeGoodsViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601FFBF RID: 131007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFBF")]
		[Address(RVA = "0x1A1BBB0", Offset = "0x1A1A7B0", VA = "0x181A1BBB0")]
		public RoguelikeGoodsObjDiscountView()
		{
		}

		// Token: 0x0402B274 RID: 176756
		[Token(Token = "0x402B274")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _priceIconImage;

		// Token: 0x0402B275 RID: 176757
		[Token(Token = "0x402B275")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _originPrice;

		// Token: 0x0402B276 RID: 176758
		[Token(Token = "0x402B276")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _currentPrice;

		// Token: 0x0402B277 RID: 176759
		[Token(Token = "0x402B277")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _recyclePanel;

		// Token: 0x0402B278 RID: 176760
		[Token(Token = "0x402B278")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_finder;

		// Token: 0x0402B279 RID: 176761
		[Token(Token = "0x402B279")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedPriceId;

		// Token: 0x0402B27A RID: 176762
		[Token(Token = "0x402B27A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginType;

		// Token: 0x0402B27B RID: 176763
		[Token(Token = "0x402B27B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NeedShowPlugin;

		// Token: 0x0402B27C RID: 176764
		[Token(Token = "0x402B27C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B27D RID: 176765
		[Token(Token = "0x402B27D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HasDiscountPrice;

		// Token: 0x0402B27E RID: 176766
		[Token(Token = "0x402B27E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
