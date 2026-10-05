using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054BB RID: 21691
	[Token(Token = "0x20054BB")]
	public class RoguelikeCommonShopBankViewBinder : DataBinder<RoguelikeGameBankProperty>
	{
		// Token: 0x0601FE6A RID: 130666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE6A")]
		[Address(RVA = "0x1A040B0", Offset = "0x1A02CB0", VA = "0x181A040B0")]
		public void InitBankViews(List<RoguelikeGameShopBaseView> viewList)
		{
		}

		// Token: 0x0601FE6B RID: 130667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE6B")]
		[Address(RVA = "0x1A041F0", Offset = "0x1A02DF0", VA = "0x181A041F0", Slot = "7")]
		public override void OnValueChanged(RoguelikeGameBankProperty property)
		{
		}

		// Token: 0x0601FE6C RID: 130668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE6C")]
		[Address(RVA = "0x1A04350", Offset = "0x1A02F50", VA = "0x181A04350")]
		public RoguelikeCommonShopBankViewBinder()
		{
		}

		// Token: 0x0402B096 RID: 176278
		[Token(Token = "0x402B096")]
		[FieldOffset(Offset = "0x20")]
		private List<RoguelikeGameShopBaseView> m_bankViewList;

		// Token: 0x0402B097 RID: 176279
		[Token(Token = "0x402B097")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitBankViews;

		// Token: 0x0402B098 RID: 176280
		[Token(Token = "0x402B098")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B099 RID: 176281
		[Token(Token = "0x402B099")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
