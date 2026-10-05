using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054C2 RID: 21698
	[Token(Token = "0x20054C2")]
	public class RoguelikeGameBankBinderView : DataBinder<RoguelikeGameBankProperty>
	{
		// Token: 0x0601FEBF RID: 130751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEBF")]
		[Address(RVA = "0x1A0B480", Offset = "0x1A0A080", VA = "0x181A0B480", Slot = "7")]
		public override void OnValueChanged(RoguelikeGameBankProperty property)
		{
		}

		// Token: 0x0601FEC0 RID: 130752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEC0")]
		[Address(RVA = "0x1A0B5E0", Offset = "0x1A0A1E0", VA = "0x181A0B5E0")]
		public RoguelikeGameBankBinderView()
		{
		}

		// Token: 0x0402B0ED RID: 176365
		[Token(Token = "0x402B0ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeGameShopBaseView[] _shopViewList;

		// Token: 0x0402B0EE RID: 176366
		[Token(Token = "0x402B0EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B0EF RID: 176367
		[Token(Token = "0x402B0EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
