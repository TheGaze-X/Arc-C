using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006326 RID: 25382
	[Token(Token = "0x2006326")]
	public class AutoChessShopQuickAssistListTitleWithItemViewModel : IAutoChessShopQuickAssistListItemViewModel, IHotfixable
	{
		// Token: 0x06024999 RID: 149913 RVA: 0x000C4C68 File Offset: 0x000C2E68
		[Token(Token = "0x6024999")]
		[Address(RVA = "0x1F79630", Offset = "0x1F78230", VA = "0x181F79630", Slot = "4")]
		public AutoChessShopQuickAssistListItemViewType GetViewType()
		{
			return AutoChessShopQuickAssistListItemViewType.TITLE_WITH_ITEM;
		}

		// Token: 0x0602499A RID: 149914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602499A")]
		[Address(RVA = "0x1F795D0", Offset = "0x1F781D0", VA = "0x181F795D0", Slot = "5")]
		public AutoChessShopQuickAssistItemViewModel GetItemViewModel()
		{
			return null;
		}

		// Token: 0x17005640 RID: 22080
		// (get) Token: 0x0602499B RID: 149915 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602499C RID: 149916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005640")]
		public AutoChessShopLevelTagViewModel titleViewModel
		{
			[Token(Token = "0x602499B")]
			[Address(RVA = "0x1F79800", Offset = "0x1F78400", VA = "0x181F79800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602499C")]
			[Address(RVA = "0x1F79860", Offset = "0x1F78460", VA = "0x181F79860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602499D RID: 149917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602499D")]
		[Address(RVA = "0x1F79690", Offset = "0x1F78290", VA = "0x181F79690")]
		public void LoadData(AutoChessShopLevelTagViewModel tagViewModel, AutoChessShopQuickAssistItemViewModel viewModel)
		{
		}

		// Token: 0x0602499E RID: 149918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602499E")]
		[Address(RVA = "0x1F797A0", Offset = "0x1F783A0", VA = "0x181F797A0")]
		public AutoChessShopQuickAssistListTitleWithItemViewModel()
		{
		}

		// Token: 0x0403310A RID: 209162
		[Token(Token = "0x403310A")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessShopQuickAssistItemViewModel m_itemViewModel;

		// Token: 0x0403310B RID: 209163
		[Token(Token = "0x403310B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403310C RID: 209164
		[Token(Token = "0x403310C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetItemViewModel;

		// Token: 0x0403310D RID: 209165
		[Token(Token = "0x403310D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_titleViewModel;

		// Token: 0x0403310E RID: 209166
		[Token(Token = "0x403310E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_titleViewModel;

		// Token: 0x0403310F RID: 209167
		[Token(Token = "0x403310F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033110 RID: 209168
		[Token(Token = "0x4033110")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
