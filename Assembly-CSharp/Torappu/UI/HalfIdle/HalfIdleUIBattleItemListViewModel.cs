using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x0200675A RID: 26458
	[Token(Token = "0x200675A")]
	public class HalfIdleUIBattleItemListViewModel : IHotfixable
	{
		// Token: 0x06025F78 RID: 155512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F78")]
		[Address(RVA = "0x20F5550", Offset = "0x20F4150", VA = "0x1820F5550")]
		public void UpdateData()
		{
		}

		// Token: 0x06025F79 RID: 155513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F79")]
		[Address(RVA = "0x20F5750", Offset = "0x20F4350", VA = "0x1820F5750")]
		public void _InitIfNot()
		{
		}

		// Token: 0x06025F7A RID: 155514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F7A")]
		[Address(RVA = "0x20F59F0", Offset = "0x20F45F0", VA = "0x1820F59F0")]
		public HalfIdleUIBattleItemListViewModel()
		{
		}

		// Token: 0x04035686 RID: 218758
		[Token(Token = "0x4035686")]
		[FieldOffset(Offset = "0x10")]
		public bool panelVisibility;

		// Token: 0x04035687 RID: 218759
		[Token(Token = "0x4035687")]
		[FieldOffset(Offset = "0x11")]
		public bool isPanelShow;

		// Token: 0x04035688 RID: 218760
		[Token(Token = "0x4035688")]
		[FieldOffset(Offset = "0x12")]
		public bool isAllItemFull;

		// Token: 0x04035689 RID: 218761
		[Token(Token = "0x4035689")]
		[FieldOffset(Offset = "0x13")]
		public bool gainNewItem;

		// Token: 0x0403568A RID: 218762
		[Token(Token = "0x403568A")]
		[FieldOffset(Offset = "0x18")]
		public List<HalfIdleUIBattleItemViewModel> itemViewModelList;

		// Token: 0x0403568B RID: 218763
		[Token(Token = "0x403568B")]
		[FieldOffset(Offset = "0x20")]
		public int initSeqNum;

		// Token: 0x0403568C RID: 218764
		[Token(Token = "0x403568C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403568D RID: 218765
		[Token(Token = "0x403568D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403568E RID: 218766
		[Token(Token = "0x403568E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
