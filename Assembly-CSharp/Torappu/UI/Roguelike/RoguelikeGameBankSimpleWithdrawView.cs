using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054D0 RID: 21712
	[Token(Token = "0x20054D0")]
	public class RoguelikeGameBankSimpleWithdrawView : RoguelikeGameBankWithdrawlBaseView<RoguelikeBankWithdrawControllerBindings>
	{
		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x0601FF01 RID: 130817 RVA: 0x000B3C88 File Offset: 0x000B1E88
		[Token(Token = "0x17004AC7")]
		public override RoguelikeGameBankWithdrawlViewType viewType
		{
			[Token(Token = "0x601FF01")]
			[Address(RVA = "0x1A0DB70", Offset = "0x1A0C770", VA = "0x181A0DB70", Slot = "10")]
			get
			{
				return RoguelikeGameBankWithdrawlViewType.NONE;
			}
		}

		// Token: 0x0601FF02 RID: 130818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF02")]
		[Address(RVA = "0x1A0D750", Offset = "0x1A0C350", VA = "0x181A0D750", Slot = "9")]
		public override void Render(RoguelikeGameBankViewModel bankModel)
		{
		}

		// Token: 0x0601FF03 RID: 130819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF03")]
		[Address(RVA = "0x1A0D4C0", Offset = "0x1A0C0C0", VA = "0x181A0D4C0", Slot = "12")]
		protected override void BindShopController(RoguelikeBankWithdrawControllerBindings bindings)
		{
		}

		// Token: 0x0601FF04 RID: 130820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF04")]
		[Address(RVA = "0x1A0D5F0", Offset = "0x1A0C1F0", VA = "0x181A0D5F0")]
		public void OnBtnWithdraw()
		{
		}

		// Token: 0x0601FF05 RID: 130821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF05")]
		[Address(RVA = "0x1A0D540", Offset = "0x1A0C140", VA = "0x181A0D540")]
		public void OnBtnCancel()
		{
		}

		// Token: 0x0601FF06 RID: 130822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF06")]
		[Address(RVA = "0x1A0D6A0", Offset = "0x1A0C2A0", VA = "0x181A0D6A0")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0601FF07 RID: 130823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF07")]
		[Address(RVA = "0x1A0DAF0", Offset = "0x1A0C6F0", VA = "0x181A0DAF0")]
		public RoguelikeGameBankSimpleWithdrawView()
		{
		}

		// Token: 0x0601FF08 RID: 130824 RVA: 0x000B3CA0 File Offset: 0x000B1EA0
		[Token(Token = "0x601FF08")]
		[Address(RVA = "0x1A0BDB0", Offset = "0x1A0A9B0", VA = "0x181A0BDB0")]
		private RoguelikeGameBankWithdrawlViewType <>xLuaBaseProxy_get_viewType()
		{
			return RoguelikeGameBankWithdrawlViewType.NONE;
		}

		// Token: 0x0601FF09 RID: 130825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF09")]
		[Address(RVA = "0x1A0BD50", Offset = "0x1A0A950", VA = "0x181A0BD50")]
		private void <>xLuaBaseProxy_Render(RoguelikeGameBankViewModel P0)
		{
		}

		// Token: 0x0402B15E RID: 176478
		[Token(Token = "0x402B15E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCurrent;

		// Token: 0x0402B15F RID: 176479
		[Token(Token = "0x402B15F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textTarget;

		// Token: 0x0402B160 RID: 176480
		[Token(Token = "0x402B160")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _btnAlphaHandler;

		// Token: 0x0402B161 RID: 176481
		[Token(Token = "0x402B161")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _btnInactiveAlpha;

		// Token: 0x0402B162 RID: 176482
		[Token(Token = "0x402B162")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x0402B163 RID: 176483
		[Token(Token = "0x402B163")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x0402B164 RID: 176484
		[Token(Token = "0x402B164")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _toggleConfirmText;

		// Token: 0x0402B165 RID: 176485
		[Token(Token = "0x402B165")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textTips;

		// Token: 0x0402B166 RID: 176486
		[Token(Token = "0x402B166")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402B167 RID: 176487
		[Token(Token = "0x402B167")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B168 RID: 176488
		[Token(Token = "0x402B168")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B169 RID: 176489
		[Token(Token = "0x402B169")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnWithdraw;

		// Token: 0x0402B16A RID: 176490
		[Token(Token = "0x402B16A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnCancel;

		// Token: 0x0402B16B RID: 176491
		[Token(Token = "0x402B16B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x0402B16C RID: 176492
		[Token(Token = "0x402B16C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
