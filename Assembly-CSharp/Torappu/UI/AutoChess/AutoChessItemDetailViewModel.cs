using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006341 RID: 25409
	[Token(Token = "0x2006341")]
	public class AutoChessItemDetailViewModel : IHotfixable
	{
		// Token: 0x17005689 RID: 22153
		// (get) Token: 0x06024A85 RID: 150149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024A86 RID: 150150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005689")]
		public AutoChessItemDetailItemViewModel itemViewModel
		{
			[Token(Token = "0x6024A85")]
			[Address(RVA = "0x1F80010", Offset = "0x1F7EC10", VA = "0x181F80010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024A86")]
			[Address(RVA = "0x1F801A0", Offset = "0x1F7EDA0", VA = "0x181F801A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700568A RID: 22154
		// (get) Token: 0x06024A87 RID: 150151 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024A88 RID: 150152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700568A")]
		public AutoChessItemDetailItemViewModel prevItemViewModel
		{
			[Token(Token = "0x6024A87")]
			[Address(RVA = "0x1F800D0", Offset = "0x1F7ECD0", VA = "0x181F800D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024A88")]
			[Address(RVA = "0x1F80290", Offset = "0x1F7EE90", VA = "0x181F80290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700568B RID: 22155
		// (get) Token: 0x06024A89 RID: 150153 RVA: 0x000C5298 File Offset: 0x000C3498
		// (set) Token: 0x06024A8A RID: 150154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700568B")]
		public int moveSeqNum
		{
			[Token(Token = "0x6024A89")]
			[Address(RVA = "0x1F80070", Offset = "0x1F7EC70", VA = "0x181F80070")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A8A")]
			[Address(RVA = "0x1F80220", Offset = "0x1F7EE20", VA = "0x181F80220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700568C RID: 22156
		// (get) Token: 0x06024A8B RID: 150155 RVA: 0x000C52B0 File Offset: 0x000C34B0
		// (set) Token: 0x06024A8C RID: 150156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700568C")]
		public bool isMoveRight
		{
			[Token(Token = "0x6024A8B")]
			[Address(RVA = "0x1F7FFB0", Offset = "0x1F7EBB0", VA = "0x181F7FFB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024A8C")]
			[Address(RVA = "0x1F80130", Offset = "0x1F7ED30", VA = "0x181F80130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06024A8D RID: 150157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A8D")]
		[Address(RVA = "0x1F7F720", Offset = "0x1F7E320", VA = "0x181F7F720")]
		public void LoadData(string actId, string initFocusChessId)
		{
		}

		// Token: 0x06024A8E RID: 150158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A8E")]
		[Address(RVA = "0x1F7FBE0", Offset = "0x1F7E7E0", VA = "0x181F7FBE0")]
		public void MoveRight()
		{
		}

		// Token: 0x06024A8F RID: 150159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A8F")]
		[Address(RVA = "0x1F7FB30", Offset = "0x1F7E730", VA = "0x181F7FB30")]
		public void MoveLeft()
		{
		}

		// Token: 0x06024A90 RID: 150160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A90")]
		[Address(RVA = "0x1F7FDA0", Offset = "0x1F7E9A0", VA = "0x181F7FDA0")]
		private void _ShowItemByIndex(int index)
		{
		}

		// Token: 0x06024A91 RID: 150161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A91")]
		[Address(RVA = "0x1F7FC90", Offset = "0x1F7E890", VA = "0x181F7FC90")]
		private void _MoveItem(int delta)
		{
		}

		// Token: 0x06024A92 RID: 150162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A92")]
		[Address(RVA = "0x1F7FF50", Offset = "0x1F7EB50", VA = "0x181F7FF50")]
		public AutoChessItemDetailViewModel()
		{
		}

		// Token: 0x04033256 RID: 209494
		[Token(Token = "0x4033256")]
		[FieldOffset(Offset = "0x10")]
		private ActAutoChessData m_actData;

		// Token: 0x04033257 RID: 209495
		[Token(Token = "0x4033257")]
		[FieldOffset(Offset = "0x18")]
		private int m_showItemIdx;

		// Token: 0x04033258 RID: 209496
		[Token(Token = "0x4033258")]
		[FieldOffset(Offset = "0x20")]
		private List<ActAutoChessData.ActAutoChessTrapShopChessData> m_itemDatas;

		// Token: 0x0403325D RID: 209501
		[Token(Token = "0x403325D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemViewModel;

		// Token: 0x0403325E RID: 209502
		[Token(Token = "0x403325E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemViewModel;

		// Token: 0x0403325F RID: 209503
		[Token(Token = "0x403325F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_prevItemViewModel;

		// Token: 0x04033260 RID: 209504
		[Token(Token = "0x4033260")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_prevItemViewModel;

		// Token: 0x04033261 RID: 209505
		[Token(Token = "0x4033261")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_moveSeqNum;

		// Token: 0x04033262 RID: 209506
		[Token(Token = "0x4033262")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_moveSeqNum;

		// Token: 0x04033263 RID: 209507
		[Token(Token = "0x4033263")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isMoveRight;

		// Token: 0x04033264 RID: 209508
		[Token(Token = "0x4033264")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isMoveRight;

		// Token: 0x04033265 RID: 209509
		[Token(Token = "0x4033265")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033266 RID: 209510
		[Token(Token = "0x4033266")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_MoveRight;

		// Token: 0x04033267 RID: 209511
		[Token(Token = "0x4033267")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_MoveLeft;

		// Token: 0x04033268 RID: 209512
		[Token(Token = "0x4033268")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowItemByIndex;

		// Token: 0x04033269 RID: 209513
		[Token(Token = "0x4033269")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__MoveItem;

		// Token: 0x0403326A RID: 209514
		[Token(Token = "0x403326A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
