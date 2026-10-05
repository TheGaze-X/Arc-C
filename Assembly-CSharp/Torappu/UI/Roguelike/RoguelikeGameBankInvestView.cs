using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054CC RID: 21708
	[Token(Token = "0x20054CC")]
	public class RoguelikeGameBankInvestView : RoguelikeGameShopBaseView
	{
		// Token: 0x0601FEF0 RID: 130800 RVA: 0x000B3C70 File Offset: 0x000B1E70
		[Token(Token = "0x601FEF0")]
		[Address(RVA = "0x1A0CB70", Offset = "0x1A0B770", VA = "0x181A0CB70", Slot = "7")]
		public override RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x0601FEF1 RID: 130801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF1")]
		[Address(RVA = "0x1A0CDE0", Offset = "0x1A0B9E0", VA = "0x181A0CDE0", Slot = "9")]
		public override void Render(RoguelikeGameBankViewModel bankModel)
		{
		}

		// Token: 0x0601FEF2 RID: 130802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF2")]
		[Address(RVA = "0x1A0CAF0", Offset = "0x1A0B6F0", VA = "0x181A0CAF0")]
		public void BindShopController(RoguelikeBankInvestControllerBindings bindings)
		{
		}

		// Token: 0x0601FEF3 RID: 130803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF3")]
		[Address(RVA = "0x1A0CC80", Offset = "0x1A0B880", VA = "0x181A0CC80")]
		public void OnInvest()
		{
		}

		// Token: 0x0601FEF4 RID: 130804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF4")]
		[Address(RVA = "0x1A0CBD0", Offset = "0x1A0B7D0", VA = "0x181A0CBD0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FEF5 RID: 130805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF5")]
		[Address(RVA = "0x1A0CD30", Offset = "0x1A0B930", VA = "0x181A0CD30")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0601FEF6 RID: 130806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF6")]
		[Address(RVA = "0x1A0D030", Offset = "0x1A0BC30", VA = "0x181A0D030")]
		public RoguelikeGameBankInvestView()
		{
		}

		// Token: 0x0601FEF7 RID: 130807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF7")]
		[Address(RVA = "0x1A0BD50", Offset = "0x1A0A950", VA = "0x181A0BD50")]
		private void <>xLuaBaseProxy_Render(RoguelikeGameBankViewModel P0)
		{
		}

		// Token: 0x0402B13F RID: 176447
		[Token(Token = "0x402B13F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCurrent;

		// Token: 0x0402B140 RID: 176448
		[Token(Token = "0x402B140")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textTarget;

		// Token: 0x0402B141 RID: 176449
		[Token(Token = "0x402B141")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _btnAlphaHandler;

		// Token: 0x0402B142 RID: 176450
		[Token(Token = "0x402B142")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _btnInactiveAlpha;

		// Token: 0x0402B143 RID: 176451
		[Token(Token = "0x402B143")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x0402B144 RID: 176452
		[Token(Token = "0x402B144")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoStateToggle _toggleConfirmText;

		// Token: 0x0402B145 RID: 176453
		[Token(Token = "0x402B145")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeBankInvestControllerBindings m_controllerBindings;

		// Token: 0x0402B146 RID: 176454
		[Token(Token = "0x402B146")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402B147 RID: 176455
		[Token(Token = "0x402B147")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B148 RID: 176456
		[Token(Token = "0x402B148")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B149 RID: 176457
		[Token(Token = "0x402B149")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInvest;

		// Token: 0x0402B14A RID: 176458
		[Token(Token = "0x402B14A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B14B RID: 176459
		[Token(Token = "0x402B14B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x0402B14C RID: 176460
		[Token(Token = "0x402B14C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
