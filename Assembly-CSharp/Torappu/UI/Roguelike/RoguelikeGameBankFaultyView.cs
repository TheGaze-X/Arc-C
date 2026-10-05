using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054C9 RID: 21705
	[Token(Token = "0x20054C9")]
	public class RoguelikeGameBankFaultyView : RoguelikeGameShopBaseView
	{
		// Token: 0x0601FEE5 RID: 130789 RVA: 0x000B3C58 File Offset: 0x000B1E58
		[Token(Token = "0x601FEE5")]
		[Address(RVA = "0x1A0C780", Offset = "0x1A0B380", VA = "0x181A0C780", Slot = "7")]
		public override RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x0601FEE6 RID: 130790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE6")]
		[Address(RVA = "0x1A0C940", Offset = "0x1A0B540", VA = "0x181A0C940", Slot = "9")]
		public override void Render(RoguelikeGameBankViewModel bankModel)
		{
		}

		// Token: 0x0601FEE7 RID: 130791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE7")]
		[Address(RVA = "0x1A0C700", Offset = "0x1A0B300", VA = "0x181A0C700")]
		public void BindShopController(RoguelikeBankFaultyControllerBindings bindings)
		{
		}

		// Token: 0x0601FEE8 RID: 130792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE8")]
		[Address(RVA = "0x1A0C7E0", Offset = "0x1A0B3E0", VA = "0x181A0C7E0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FEE9 RID: 130793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE9")]
		[Address(RVA = "0x1A0C890", Offset = "0x1A0B490", VA = "0x181A0C890")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0601FEEA RID: 130794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEEA")]
		[Address(RVA = "0x1A0CA50", Offset = "0x1A0B650", VA = "0x181A0CA50")]
		public RoguelikeGameBankFaultyView()
		{
		}

		// Token: 0x0601FEEB RID: 130795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEEB")]
		[Address(RVA = "0x1A0BD50", Offset = "0x1A0A950", VA = "0x181A0BD50")]
		private void <>xLuaBaseProxy_Render(RoguelikeGameBankViewModel P0)
		{
		}

		// Token: 0x0402B130 RID: 176432
		[Token(Token = "0x402B130")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textBankCurrent;

		// Token: 0x0402B131 RID: 176433
		[Token(Token = "0x402B131")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeBankFaultyControllerBindings m_controllerBindings;

		// Token: 0x0402B132 RID: 176434
		[Token(Token = "0x402B132")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402B133 RID: 176435
		[Token(Token = "0x402B133")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B134 RID: 176436
		[Token(Token = "0x402B134")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B135 RID: 176437
		[Token(Token = "0x402B135")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B136 RID: 176438
		[Token(Token = "0x402B136")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x0402B137 RID: 176439
		[Token(Token = "0x402B137")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
