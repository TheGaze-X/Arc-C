using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005660 RID: 22112
	[Token(Token = "0x2005660")]
	public class RL04AlchemyFragmentListItemRowViewModel : IRL04AlchemyFragmentListItemViewModel, IHotfixable
	{
		// Token: 0x060206F3 RID: 132851 RVA: 0x000B5E00 File Offset: 0x000B4000
		[Token(Token = "0x60206F3")]
		[Address(RVA = "0x1A935C0", Offset = "0x1A921C0", VA = "0x181A935C0", Slot = "4")]
		public RL04AlchemyFragmentListItemViewType GetViewType()
		{
			return RL04AlchemyFragmentListItemViewType.ROW_ITEM;
		}

		// Token: 0x060206F4 RID: 132852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206F4")]
		[Address(RVA = "0x1A93620", Offset = "0x1A92220", VA = "0x181A93620")]
		public RL04AlchemyFragmentListItemRowViewModel()
		{
		}

		// Token: 0x0402BEC3 RID: 179907
		[Token(Token = "0x402BEC3")]
		[FieldOffset(Offset = "0x10")]
		public List<RL04AlchemyFragmentListItemNormalViewModel> itemNormalViewList;

		// Token: 0x0402BEC4 RID: 179908
		[Token(Token = "0x402BEC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402BEC5 RID: 179909
		[Token(Token = "0x402BEC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
