using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054C6 RID: 21702
	[Token(Token = "0x20054C6")]
	public class RoguelikeGameBankEntryView : RoguelikeGameShopBaseView
	{
		// Token: 0x0601FED6 RID: 130774 RVA: 0x000B3C40 File Offset: 0x000B1E40
		[Token(Token = "0x601FED6")]
		[Address(RVA = "0x1A0C150", Offset = "0x1A0AD50", VA = "0x181A0C150", Slot = "7")]
		public override RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x0601FED7 RID: 130775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED7")]
		[Address(RVA = "0x1A0C470", Offset = "0x1A0B070", VA = "0x181A0C470", Slot = "9")]
		public override void Render(RoguelikeGameBankViewModel bankModel)
		{
		}

		// Token: 0x0601FED8 RID: 130776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED8")]
		[Address(RVA = "0x1A0C0D0", Offset = "0x1A0ACD0", VA = "0x181A0C0D0")]
		public void BindShopController(RoguelikeBankEntryControllerBindings bindings)
		{
		}

		// Token: 0x0601FED9 RID: 130777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED9")]
		[Address(RVA = "0x1A0C3C0", Offset = "0x1A0AFC0", VA = "0x181A0C3C0")]
		public void OnOpenWithdraw()
		{
		}

		// Token: 0x0601FEDA RID: 130778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEDA")]
		[Address(RVA = "0x1A0C310", Offset = "0x1A0AF10", VA = "0x181A0C310")]
		public void OnOpenInvest()
		{
		}

		// Token: 0x0601FEDB RID: 130779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEDB")]
		[Address(RVA = "0x1A0C1B0", Offset = "0x1A0ADB0", VA = "0x181A0C1B0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FEDC RID: 130780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEDC")]
		[Address(RVA = "0x1A0C260", Offset = "0x1A0AE60", VA = "0x181A0C260")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0601FEDD RID: 130781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEDD")]
		[Address(RVA = "0x1A0C660", Offset = "0x1A0B260", VA = "0x181A0C660")]
		public RoguelikeGameBankEntryView()
		{
		}

		// Token: 0x0601FEDE RID: 130782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEDE")]
		[Address(RVA = "0x1A0BD50", Offset = "0x1A0A950", VA = "0x181A0BD50")]
		private void <>xLuaBaseProxy_Render(RoguelikeGameBankViewModel P0)
		{
		}

		// Token: 0x0402B117 RID: 176407
		[Token(Token = "0x402B117")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textBankCurrent;

		// Token: 0x0402B118 RID: 176408
		[Token(Token = "0x402B118")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _btnWithdrawGo;

		// Token: 0x0402B119 RID: 176409
		[Token(Token = "0x402B119")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _faultyIconGo;

		// Token: 0x0402B11A RID: 176410
		[Token(Token = "0x402B11A")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeBankEntryControllerBindings m_controllerBindings;

		// Token: 0x0402B11B RID: 176411
		[Token(Token = "0x402B11B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402B11C RID: 176412
		[Token(Token = "0x402B11C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B11D RID: 176413
		[Token(Token = "0x402B11D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B11E RID: 176414
		[Token(Token = "0x402B11E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOpenWithdraw;

		// Token: 0x0402B11F RID: 176415
		[Token(Token = "0x402B11F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenInvest;

		// Token: 0x0402B120 RID: 176416
		[Token(Token = "0x402B120")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B121 RID: 176417
		[Token(Token = "0x402B121")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x0402B122 RID: 176418
		[Token(Token = "0x402B122")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
