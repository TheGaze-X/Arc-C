using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006336 RID: 25398
	[Token(Token = "0x2006336")]
	public class AutoChessShopLevelCharGroupItemViewModel : IHotfixable
	{
		// Token: 0x1700566C RID: 22124
		// (get) Token: 0x06024A15 RID: 150037 RVA: 0x000C4FF8 File Offset: 0x000C31F8
		// (set) Token: 0x06024A16 RID: 150038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700566C")]
		public int groupLevel
		{
			[Token(Token = "0x6024A15")]
			[Address(RVA = "0x1F6DB30", Offset = "0x1F6C730", VA = "0x181F6DB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A16")]
			[Address(RVA = "0x1F6DC50", Offset = "0x1F6C850", VA = "0x181F6DC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700566D RID: 22125
		// (get) Token: 0x06024A17 RID: 150039 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024A18 RID: 150040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700566D")]
		public AutoChessShopLevelTagViewModel levelTagViewModel
		{
			[Token(Token = "0x6024A17")]
			[Address(RVA = "0x1F6DBF0", Offset = "0x1F6C7F0", VA = "0x181F6DBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024A18")]
			[Address(RVA = "0x1F6DCC0", Offset = "0x1F6C8C0", VA = "0x181F6DCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700566E RID: 22126
		// (get) Token: 0x06024A19 RID: 150041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700566E")]
		public List<AutoChessShopLevelCharItemCardViewModel> levelCharItemCardViewModelList
		{
			[Token(Token = "0x6024A19")]
			[Address(RVA = "0x1F6DB90", Offset = "0x1F6C790", VA = "0x181F6DB90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024A1A RID: 150042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A1A")]
		[Address(RVA = "0x1F6C730", Offset = "0x1F6B330", VA = "0x181F6C730")]
		public void LoadData(string actId, ActAutoChessData.ActAutoChessShopLevelDisplayData displayData, Dictionary<string, ActAutoChessData.ActAutoChessGarrisonData> garrisonDict, Dictionary<string, ActAutoChessData.ActAutoChessBondInfo> bondInfoDict, ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> charShopChessDatas, Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> charChessDataDict, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPool)
		{
		}

		// Token: 0x06024A1B RID: 150043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A1B")]
		[Address(RVA = "0x1F6CA10", Offset = "0x1F6B610", VA = "0x181F6CA10")]
		public void RefreshByPlayerData(string actId, bool needResetList, AutoChessShopStatus status, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPool, Dictionary<int, int> shopLv2DiyCharCntDict)
		{
		}

		// Token: 0x06024A1C RID: 150044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A1C")]
		[Address(RVA = "0x1F6D0E0", Offset = "0x1F6BCE0", VA = "0x181F6D0E0")]
		public void RefreshDataByShopStatus(AutoChessShopStatus shopStatus)
		{
		}

		// Token: 0x06024A1D RID: 150045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A1D")]
		[Address(RVA = "0x1F6D270", Offset = "0x1F6BE70", VA = "0x181F6D270")]
		public void RefreshQuickEditType(AutoChessShopQuickEditType editType)
		{
		}

		// Token: 0x06024A1E RID: 150046 RVA: 0x000C5010 File Offset: 0x000C3210
		[Token(Token = "0x6024A1E")]
		[Address(RVA = "0x1F6CF60", Offset = "0x1F6BB60", VA = "0x181F6CF60")]
		public bool RefreshChessMultiEditSelectSkillId(string actId, string chessId, string skillId)
		{
			return default(bool);
		}

		// Token: 0x06024A1F RID: 150047 RVA: 0x000C5028 File Offset: 0x000C3228
		[Token(Token = "0x6024A1F")]
		[Address(RVA = "0x1F6CDE0", Offset = "0x1F6B9E0", VA = "0x181F6CDE0")]
		public bool RefreshChessMultiEditSelectModuleId(string actId, string chessId, string equipId)
		{
			return default(bool);
		}

		// Token: 0x06024A20 RID: 150048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A20")]
		[Address(RVA = "0x1F6CC60", Offset = "0x1F6B860", VA = "0x181F6CC60")]
		public void RefreshCharCardSelectTag(string actId, string curSelectingChessId)
		{
		}

		// Token: 0x06024A21 RID: 150049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A21")]
		[Address(RVA = "0x1F6C5A0", Offset = "0x1F6B1A0", VA = "0x181F6C5A0")]
		public AutoChessShopCharChessCardViewModel GetCharItemCardViewModel(string chessId)
		{
			return null;
		}

		// Token: 0x06024A22 RID: 150050 RVA: 0x000C5040 File Offset: 0x000C3240
		[Token(Token = "0x6024A22")]
		[Address(RVA = "0x1F6C360", Offset = "0x1F6AF60", VA = "0x181F6C360")]
		public int GetCharItemCardViewModelWithCharId(string charId, out AutoChessShopCharChessCardViewModel card)
		{
			return 0;
		}

		// Token: 0x06024A23 RID: 150051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A23")]
		[Address(RVA = "0x1F6D360", Offset = "0x1F6BF60", VA = "0x181F6D360")]
		private void _ResetLevelCharItemCardList(string actId, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPool)
		{
		}

		// Token: 0x06024A24 RID: 150052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A24")]
		[Address(RVA = "0x1F6DA80", Offset = "0x1F6C680", VA = "0x181F6DA80")]
		public AutoChessShopLevelCharGroupItemViewModel()
		{
		}

		// Token: 0x040331C3 RID: 209347
		[Token(Token = "0x40331C3")]
		[FieldOffset(Offset = "0x20")]
		private List<AutoChessShopLevelCharItemCardViewModel> m_levelCharItemCardViewModelList;

		// Token: 0x040331C4 RID: 209348
		[Token(Token = "0x40331C4")]
		[FieldOffset(Offset = "0x28")]
		private ActAutoChessData.ActAutoChessShopLevelDisplayData m_cachedShopLevelDisplayData;

		// Token: 0x040331C5 RID: 209349
		[Token(Token = "0x40331C5")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, ActAutoChessData.ActAutoChessGarrisonData> m_cachedGarrisonDict;

		// Token: 0x040331C6 RID: 209350
		[Token(Token = "0x40331C6")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, ActAutoChessData.ActAutoChessBondInfo> m_cachedBondInfoDict;

		// Token: 0x040331C7 RID: 209351
		[Token(Token = "0x40331C7")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> m_cachedCharShopChessDatas;

		// Token: 0x040331C8 RID: 209352
		[Token(Token = "0x40331C8")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> m_cachedCharChessDataDict;

		// Token: 0x040331C9 RID: 209353
		[Token(Token = "0x40331C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupLevel;

		// Token: 0x040331CA RID: 209354
		[Token(Token = "0x40331CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_groupLevel;

		// Token: 0x040331CB RID: 209355
		[Token(Token = "0x40331CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_levelTagViewModel;

		// Token: 0x040331CC RID: 209356
		[Token(Token = "0x40331CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_levelTagViewModel;

		// Token: 0x040331CD RID: 209357
		[Token(Token = "0x40331CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_levelCharItemCardViewModelList;

		// Token: 0x040331CE RID: 209358
		[Token(Token = "0x40331CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040331CF RID: 209359
		[Token(Token = "0x40331CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshByPlayerData;

		// Token: 0x040331D0 RID: 209360
		[Token(Token = "0x40331D0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshDataByShopStatus;

		// Token: 0x040331D1 RID: 209361
		[Token(Token = "0x40331D1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshQuickEditType;

		// Token: 0x040331D2 RID: 209362
		[Token(Token = "0x40331D2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshChessMultiEditSelectSkillId;

		// Token: 0x040331D3 RID: 209363
		[Token(Token = "0x40331D3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshChessMultiEditSelectModuleId;

		// Token: 0x040331D4 RID: 209364
		[Token(Token = "0x40331D4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RefreshCharCardSelectTag;

		// Token: 0x040331D5 RID: 209365
		[Token(Token = "0x40331D5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCharItemCardViewModel;

		// Token: 0x040331D6 RID: 209366
		[Token(Token = "0x40331D6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCharItemCardViewModelWithCharId;

		// Token: 0x040331D7 RID: 209367
		[Token(Token = "0x40331D7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetLevelCharItemCardList;

		// Token: 0x040331D8 RID: 209368
		[Token(Token = "0x40331D8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
