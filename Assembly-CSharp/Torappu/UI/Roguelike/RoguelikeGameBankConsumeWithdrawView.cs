using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054C3 RID: 21699
	[Token(Token = "0x20054C3")]
	public class RoguelikeGameBankConsumeWithdrawView : RoguelikeGameBankWithdrawlBaseView<RoguelikeBankConsumeWithdrawShopControllerBindings>
	{
		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x0601FEC1 RID: 130753 RVA: 0x000B3C10 File Offset: 0x000B1E10
		[Token(Token = "0x17004AC6")]
		public override RoguelikeGameBankWithdrawlViewType viewType
		{
			[Token(Token = "0x601FEC1")]
			[Address(RVA = "0x1A0C070", Offset = "0x1A0AC70", VA = "0x181A0C070", Slot = "10")]
			get
			{
				return RoguelikeGameBankWithdrawlViewType.NONE;
			}
		}

		// Token: 0x0601FEC2 RID: 130754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC2")]
		[Address(RVA = "0x1A0BAF0", Offset = "0x1A0A6F0", VA = "0x181A0BAF0", Slot = "9")]
		public override void Render(RoguelikeGameBankViewModel bankModel)
		{
		}

		// Token: 0x0601FEC3 RID: 130755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC3")]
		[Address(RVA = "0x1A0B650", Offset = "0x1A0A250", VA = "0x181A0B650", Slot = "12")]
		protected override void BindShopController(RoguelikeBankConsumeWithdrawShopControllerBindings bindings)
		{
		}

		// Token: 0x0601FEC4 RID: 130756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC4")]
		[Address(RVA = "0x1A0BE10", Offset = "0x1A0AA10", VA = "0x181A0BE10")]
		private void _InitIfNot(RoguelikeGameBankViewModel bankModel)
		{
		}

		// Token: 0x0601FEC5 RID: 130757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC5")]
		[Address(RVA = "0x1A0BA40", Offset = "0x1A0A640", VA = "0x181A0BA40")]
		public void OnBtnWithdraw()
		{
		}

		// Token: 0x0601FEC6 RID: 130758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC6")]
		[Address(RVA = "0x1A0B990", Offset = "0x1A0A590", VA = "0x181A0B990")]
		public void OnBtnCancel()
		{
		}

		// Token: 0x0601FEC7 RID: 130759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC7")]
		[Address(RVA = "0x1A0B780", Offset = "0x1A0A380", VA = "0x181A0B780")]
		public void IncrementCurrent()
		{
		}

		// Token: 0x0601FEC8 RID: 130760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC8")]
		[Address(RVA = "0x1A0B6D0", Offset = "0x1A0A2D0", VA = "0x181A0B6D0")]
		public void DecrementCurrent()
		{
		}

		// Token: 0x0601FEC9 RID: 130761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC9")]
		[Address(RVA = "0x1A0B830", Offset = "0x1A0A430", VA = "0x181A0B830")]
		public void MaxCurrent()
		{
		}

		// Token: 0x0601FECA RID: 130762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FECA")]
		[Address(RVA = "0x1A0B8E0", Offset = "0x1A0A4E0", VA = "0x181A0B8E0")]
		public void MinCurrent()
		{
		}

		// Token: 0x0601FECB RID: 130763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FECB")]
		[Address(RVA = "0x1A0BFF0", Offset = "0x1A0ABF0", VA = "0x181A0BFF0")]
		public RoguelikeGameBankConsumeWithdrawView()
		{
		}

		// Token: 0x0601FECC RID: 130764 RVA: 0x000B3C28 File Offset: 0x000B1E28
		[Token(Token = "0x601FECC")]
		[Address(RVA = "0x1A0BDB0", Offset = "0x1A0A9B0", VA = "0x181A0BDB0")]
		private RoguelikeGameBankWithdrawlViewType <>xLuaBaseProxy_get_viewType()
		{
			return RoguelikeGameBankWithdrawlViewType.NONE;
		}

		// Token: 0x0601FECD RID: 130765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FECD")]
		[Address(RVA = "0x1A0BD50", Offset = "0x1A0A950", VA = "0x181A0BD50")]
		private void <>xLuaBaseProxy_Render(RoguelikeGameBankViewModel P0)
		{
		}

		// Token: 0x0402B0F0 RID: 176368
		[Token(Token = "0x402B0F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textBankCount;

		// Token: 0x0402B0F1 RID: 176369
		[Token(Token = "0x402B0F1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textCurrentWithdraw;

		// Token: 0x0402B0F2 RID: 176370
		[Token(Token = "0x402B0F2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textWithdrawCaption;

		// Token: 0x0402B0F3 RID: 176371
		[Token(Token = "0x402B0F3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgItemIcon;

		// Token: 0x0402B0F4 RID: 176372
		[Token(Token = "0x402B0F4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _btnAlphaHandler;

		// Token: 0x0402B0F5 RID: 176373
		[Token(Token = "0x402B0F5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _btnInactiveAlpha;

		// Token: 0x0402B0F6 RID: 176374
		[Token(Token = "0x402B0F6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x0402B0F7 RID: 176375
		[Token(Token = "0x402B0F7")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402B0F8 RID: 176376
		[Token(Token = "0x402B0F8")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_finder;

		// Token: 0x0402B0F9 RID: 176377
		[Token(Token = "0x402B0F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402B0FA RID: 176378
		[Token(Token = "0x402B0FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B0FB RID: 176379
		[Token(Token = "0x402B0FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B0FC RID: 176380
		[Token(Token = "0x402B0FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B0FD RID: 176381
		[Token(Token = "0x402B0FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnWithdraw;

		// Token: 0x0402B0FE RID: 176382
		[Token(Token = "0x402B0FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnCancel;

		// Token: 0x0402B0FF RID: 176383
		[Token(Token = "0x402B0FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IncrementCurrent;

		// Token: 0x0402B100 RID: 176384
		[Token(Token = "0x402B100")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DecrementCurrent;

		// Token: 0x0402B101 RID: 176385
		[Token(Token = "0x402B101")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_MaxCurrent;

		// Token: 0x0402B102 RID: 176386
		[Token(Token = "0x402B102")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_MinCurrent;

		// Token: 0x0402B103 RID: 176387
		[Token(Token = "0x402B103")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
