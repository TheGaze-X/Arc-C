using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006327 RID: 25383
	[Token(Token = "0x2006327")]
	public class AutoChessShopQuickAssistListOnlyItemViewModel : IAutoChessShopQuickAssistListItemViewModel, IHotfixable
	{
		// Token: 0x0602499F RID: 149919 RVA: 0x000C4C80 File Offset: 0x000C2E80
		[Token(Token = "0x602499F")]
		[Address(RVA = "0x1F79490", Offset = "0x1F78090", VA = "0x181F79490", Slot = "4")]
		public AutoChessShopQuickAssistListItemViewType GetViewType()
		{
			return AutoChessShopQuickAssistListItemViewType.TITLE_WITH_ITEM;
		}

		// Token: 0x060249A0 RID: 149920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60249A0")]
		[Address(RVA = "0x1F79430", Offset = "0x1F78030", VA = "0x181F79430", Slot = "5")]
		public AutoChessShopQuickAssistItemViewModel GetItemViewModel()
		{
			return null;
		}

		// Token: 0x060249A1 RID: 149921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249A1")]
		[Address(RVA = "0x1F794F0", Offset = "0x1F780F0", VA = "0x181F794F0")]
		public void LoadData(AutoChessShopQuickAssistItemViewModel viewModel)
		{
		}

		// Token: 0x060249A2 RID: 149922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249A2")]
		[Address(RVA = "0x1F79570", Offset = "0x1F78170", VA = "0x181F79570")]
		public AutoChessShopQuickAssistListOnlyItemViewModel()
		{
		}

		// Token: 0x04033111 RID: 209169
		[Token(Token = "0x4033111")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessShopQuickAssistItemViewModel m_itemViewModel;

		// Token: 0x04033112 RID: 209170
		[Token(Token = "0x4033112")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033113 RID: 209171
		[Token(Token = "0x4033113")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetItemViewModel;

		// Token: 0x04033114 RID: 209172
		[Token(Token = "0x4033114")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033115 RID: 209173
		[Token(Token = "0x4033115")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
