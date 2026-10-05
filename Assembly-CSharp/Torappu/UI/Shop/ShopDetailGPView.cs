using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AAB RID: 23211
	[Token(Token = "0x2005AAB")]
	public class ShopDetailGPView : ShopDetailCommonView, IHotfixable
	{
		// Token: 0x06021C1C RID: 138268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C1C")]
		[Address(RVA = "0x1C3A940", Offset = "0x1C39540", VA = "0x181C3A940", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021C1D RID: 138269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C1D")]
		[Address(RVA = "0x1C3B8E0", Offset = "0x1C3A4E0", VA = "0x181C3B8E0", Slot = "5")]
		public override void OnClick()
		{
		}

		// Token: 0x06021C1E RID: 138270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C1E")]
		[Address(RVA = "0x1C3BE90", Offset = "0x1C3AA90", VA = "0x181C3BE90")]
		private void _BuyItemWithGpTicket()
		{
		}

		// Token: 0x06021C1F RID: 138271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C1F")]
		[Address(RVA = "0x1C3BA60", Offset = "0x1C3A660", VA = "0x181C3BA60")]
		private void _ApplyImgInfo(DetailGPViewModel gpModel)
		{
		}

		// Token: 0x06021C20 RID: 138272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C20")]
		[Address(RVA = "0x1C3BF30", Offset = "0x1C3AB30", VA = "0x181C3BF30")]
		public ShopDetailGPView()
		{
		}

		// Token: 0x06021C21 RID: 138273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C21")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x06021C22 RID: 138274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C22")]
		[Address(RVA = "0x1C1EA20", Offset = "0x1C1D620", VA = "0x181C1EA20")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402E2EC RID: 189164
		[Token(Token = "0x402E2EC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ShopDetailItemView _itemDetailView;

		// Token: 0x0402E2ED RID: 189165
		[Token(Token = "0x402E2ED")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ScrollRect _itemScrollRect;

		// Token: 0x0402E2EE RID: 189166
		[Token(Token = "0x402E2EE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E2EF RID: 189167
		[Token(Token = "0x402E2EF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image _spriteImage;

		// Token: 0x0402E2F0 RID: 189168
		[Token(Token = "0x402E2F0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _groupPicContainer;

		// Token: 0x0402E2F1 RID: 189169
		[Token(Token = "0x402E2F1")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ShopDetailGroupPicView _groupPicViewPrefab;

		// Token: 0x0402E2F2 RID: 189170
		[Token(Token = "0x402E2F2")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Vector2 _groupPicCellSize;

		// Token: 0x0402E2F3 RID: 189171
		[Token(Token = "0x402E2F3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Gp Ticket")]
		private GameObject[] _panelGpTicket;

		// Token: 0x0402E2F4 RID: 189172
		[Token(Token = "0x402E2F4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Gp Ticket")]
		private GameObject[] _panelNormal;

		// Token: 0x0402E2F5 RID: 189173
		[Token(Token = "0x402E2F5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Gp Ticket")]
		private Text _textGpTicketPrice;

		// Token: 0x0402E2F6 RID: 189174
		[Token(Token = "0x402E2F6")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Gp Ticket")]
		private Image _imgGpTicketPriceIcon;

		// Token: 0x0402E2F7 RID: 189175
		[Token(Token = "0x402E2F7")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Remain")]
		private GameObject _panelRemain;

		// Token: 0x0402E2F8 RID: 189176
		[Token(Token = "0x402E2F8")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Remain")]
		private Text _remainCount;

		// Token: 0x0402E2F9 RID: 189177
		[Token(Token = "0x402E2F9")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIStringEvent _onPreviewClick;

		// Token: 0x0402E2FA RID: 189178
		[Token(Token = "0x402E2FA")]
		[FieldOffset(Offset = "0x118")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402E2FB RID: 189179
		[Token(Token = "0x402E2FB")]
		[FieldOffset(Offset = "0x128")]
		private ShopDetailGroupPicView m_groupPicView;

		// Token: 0x0402E2FC RID: 189180
		[Token(Token = "0x402E2FC")]
		[FieldOffset(Offset = "0x130")]
		private List<Sprite> m_groupSprites;

		// Token: 0x0402E2FD RID: 189181
		[Token(Token = "0x402E2FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E2FE RID: 189182
		[Token(Token = "0x402E2FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E2FF RID: 189183
		[Token(Token = "0x402E2FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BuyItemWithGpTicket;

		// Token: 0x0402E300 RID: 189184
		[Token(Token = "0x402E300")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyImgInfo;

		// Token: 0x0402E301 RID: 189185
		[Token(Token = "0x402E301")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
