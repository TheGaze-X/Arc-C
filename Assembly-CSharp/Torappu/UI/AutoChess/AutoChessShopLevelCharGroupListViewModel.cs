using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006338 RID: 25400
	[Token(Token = "0x2006338")]
	public class AutoChessShopLevelCharGroupListViewModel : IHotfixable
	{
		// Token: 0x17005672 RID: 22130
		// (get) Token: 0x06024A2C RID: 150060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005672")]
		public List<AutoChessShopLevelCharGroupItemViewModel> charGroupViewList
		{
			[Token(Token = "0x6024A2C")]
			[Address(RVA = "0x1F88470", Offset = "0x1F87070", VA = "0x181F88470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005673 RID: 22131
		// (get) Token: 0x06024A2D RID: 150061 RVA: 0x000C5070 File Offset: 0x000C3270
		[Token(Token = "0x17005673")]
		public int charListRefreshSequenceNum
		{
			[Token(Token = "0x6024A2D")]
			[Address(RVA = "0x1F884D0", Offset = "0x1F870D0", VA = "0x181F884D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005674 RID: 22132
		// (get) Token: 0x06024A2E RID: 150062 RVA: 0x000C5088 File Offset: 0x000C3288
		[Token(Token = "0x17005674")]
		public int detailCharListRefreshSequenceNum
		{
			[Token(Token = "0x6024A2E")]
			[Address(RVA = "0x1F88530", Offset = "0x1F87130", VA = "0x181F88530")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005675 RID: 22133
		// (get) Token: 0x06024A2F RID: 150063 RVA: 0x000C50A0 File Offset: 0x000C32A0
		[Token(Token = "0x17005675")]
		public int quickEditCharListRefreshSequenceNum
		{
			[Token(Token = "0x6024A2F")]
			[Address(RVA = "0x1F88590", Offset = "0x1F87190", VA = "0x181F88590")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06024A30 RID: 150064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A30")]
		[Address(RVA = "0x1F877E0", Offset = "0x1F863E0", VA = "0x181F877E0")]
		public void LoadData(string actId, ActAutoChessData actData, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPool, int iSequenceNum)
		{
		}

		// Token: 0x06024A31 RID: 150065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A31")]
		[Address(RVA = "0x1F87EF0", Offset = "0x1F86AF0", VA = "0x181F87EF0")]
		public void RefreshPlayerData(string actId, AutoChessShopStatus status, bool needResetCharChessList, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPool, Dictionary<int, int> shopLv2DiyCharCntDict)
		{
		}

		// Token: 0x06024A32 RID: 150066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A32")]
		[Address(RVA = "0x1F88180", Offset = "0x1F86D80", VA = "0x181F88180")]
		public void RefreshViewStatus(AutoChessShopStatus shopStatus)
		{
		}

		// Token: 0x06024A33 RID: 150067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A33")]
		[Address(RVA = "0x1F88090", Offset = "0x1F86C90", VA = "0x181F88090")]
		public void RefreshViewQuickEditType(AutoChessShopQuickEditType editType)
		{
		}

		// Token: 0x06024A34 RID: 150068 RVA: 0x000C50B8 File Offset: 0x000C32B8
		[Token(Token = "0x6024A34")]
		[Address(RVA = "0x1F87DA0", Offset = "0x1F869A0", VA = "0x181F87DA0")]
		public bool RefreshMultiEditChessSelectSkillId(string actId, int chessLevel, string chessId, string skillId)
		{
			return default(bool);
		}

		// Token: 0x06024A35 RID: 150069 RVA: 0x000C50D0 File Offset: 0x000C32D0
		[Token(Token = "0x6024A35")]
		[Address(RVA = "0x1F87C50", Offset = "0x1F86850", VA = "0x181F87C50")]
		public bool RefreshMultiEditChessSelectModuleId(string actId, int chessLevel, string chessId, string moduleId)
		{
			return default(bool);
		}

		// Token: 0x06024A36 RID: 150070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A36")]
		[Address(RVA = "0x1F87B60", Offset = "0x1F86760", VA = "0x181F87B60")]
		public void RefreshChessSelectTag(string actId, string curSelectChessId)
		{
		}

		// Token: 0x06024A37 RID: 150071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A37")]
		[Address(RVA = "0x1F876D0", Offset = "0x1F862D0", VA = "0x181F876D0")]
		public AutoChessShopCharChessCardViewModel GetCharItemCardViewModel(int chessLevel, string chessId)
		{
			return null;
		}

		// Token: 0x06024A38 RID: 150072 RVA: 0x000C50E8 File Offset: 0x000C32E8
		[Token(Token = "0x6024A38")]
		[Address(RVA = "0x1F88270", Offset = "0x1F86E70", VA = "0x181F88270")]
		public int TryGetCharChessCardViewModel(int chessLevel, string charId, out AutoChessShopCharChessCardViewModel cardViewModel)
		{
			return 0;
		}

		// Token: 0x06024A39 RID: 150073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A39")]
		[Address(RVA = "0x1F883C0", Offset = "0x1F86FC0", VA = "0x181F883C0")]
		public AutoChessShopLevelCharGroupListViewModel()
		{
		}

		// Token: 0x040331E3 RID: 209379
		[Token(Token = "0x40331E3")]
		[FieldOffset(Offset = "0x10")]
		private List<AutoChessShopLevelCharGroupItemViewModel> m_charGroupViewList;

		// Token: 0x040331E4 RID: 209380
		[Token(Token = "0x40331E4")]
		[FieldOffset(Offset = "0x18")]
		private int m_charListRefreshSequenceNum;

		// Token: 0x040331E5 RID: 209381
		[Token(Token = "0x40331E5")]
		[FieldOffset(Offset = "0x1C")]
		private int m_detailCharListRefreshSequenceNum;

		// Token: 0x040331E6 RID: 209382
		[Token(Token = "0x40331E6")]
		[FieldOffset(Offset = "0x20")]
		private int m_quickEditCharListRefreshSequenceNum;

		// Token: 0x040331E7 RID: 209383
		[Token(Token = "0x40331E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charGroupViewList;

		// Token: 0x040331E8 RID: 209384
		[Token(Token = "0x40331E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charListRefreshSequenceNum;

		// Token: 0x040331E9 RID: 209385
		[Token(Token = "0x40331E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_detailCharListRefreshSequenceNum;

		// Token: 0x040331EA RID: 209386
		[Token(Token = "0x40331EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_quickEditCharListRefreshSequenceNum;

		// Token: 0x040331EB RID: 209387
		[Token(Token = "0x40331EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040331EC RID: 209388
		[Token(Token = "0x40331EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040331ED RID: 209389
		[Token(Token = "0x40331ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshViewStatus;

		// Token: 0x040331EE RID: 209390
		[Token(Token = "0x40331EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshViewQuickEditType;

		// Token: 0x040331EF RID: 209391
		[Token(Token = "0x40331EF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshMultiEditChessSelectSkillId;

		// Token: 0x040331F0 RID: 209392
		[Token(Token = "0x40331F0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshMultiEditChessSelectModuleId;

		// Token: 0x040331F1 RID: 209393
		[Token(Token = "0x40331F1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshChessSelectTag;

		// Token: 0x040331F2 RID: 209394
		[Token(Token = "0x40331F2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCharItemCardViewModel;

		// Token: 0x040331F3 RID: 209395
		[Token(Token = "0x40331F3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryGetCharChessCardViewModel;

		// Token: 0x040331F4 RID: 209396
		[Token(Token = "0x40331F4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
