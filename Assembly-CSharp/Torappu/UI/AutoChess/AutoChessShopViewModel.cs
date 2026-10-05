using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.CharSelect;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200633C RID: 25404
	[Token(Token = "0x200633C")]
	public class AutoChessShopViewModel : IHotfixable
	{
		// Token: 0x17005678 RID: 22136
		// (get) Token: 0x06024A44 RID: 150084 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024A45 RID: 150085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005678")]
		public string activityId
		{
			[Token(Token = "0x6024A44")]
			[Address(RVA = "0x1F91C70", Offset = "0x1F90870", VA = "0x181F91C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024A45")]
			[Address(RVA = "0x1F92340", Offset = "0x1F90F40", VA = "0x181F92340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005679 RID: 22137
		// (get) Token: 0x06024A46 RID: 150086 RVA: 0x000C5148 File Offset: 0x000C3348
		// (set) Token: 0x06024A47 RID: 150087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005679")]
		public int curAssistCnt
		{
			[Token(Token = "0x6024A46")]
			[Address(RVA = "0x1F91E50", Offset = "0x1F90A50", VA = "0x181F91E50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A47")]
			[Address(RVA = "0x1F923C0", Offset = "0x1F90FC0", VA = "0x181F923C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700567A RID: 22138
		// (get) Token: 0x06024A48 RID: 150088 RVA: 0x000C5160 File Offset: 0x000C3360
		// (set) Token: 0x06024A49 RID: 150089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700567A")]
		public int maxCanAssistCnt
		{
			[Token(Token = "0x6024A48")]
			[Address(RVA = "0x1F92160", Offset = "0x1F90D60", VA = "0x181F92160")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A49")]
			[Address(RVA = "0x1F92610", Offset = "0x1F91210", VA = "0x181F92610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700567B RID: 22139
		// (get) Token: 0x06024A4A RID: 150090 RVA: 0x000C5178 File Offset: 0x000C3378
		// (set) Token: 0x06024A4B RID: 150091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700567B")]
		public int notTopicCharCnt
		{
			[Token(Token = "0x6024A4A")]
			[Address(RVA = "0x1F92220", Offset = "0x1F90E20", VA = "0x181F92220")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A4B")]
			[Address(RVA = "0x1F92680", Offset = "0x1F91280", VA = "0x181F92680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700567C RID: 22140
		// (get) Token: 0x06024A4C RID: 150092 RVA: 0x000C5190 File Offset: 0x000C3390
		// (set) Token: 0x06024A4D RID: 150093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700567C")]
		public AutoChessShopQuickEditType curQuickEditType
		{
			[Token(Token = "0x6024A4C")]
			[Address(RVA = "0x1F91EB0", Offset = "0x1F90AB0", VA = "0x181F91EB0")]
			[CompilerGenerated]
			get
			{
				return AutoChessShopQuickEditType.NONE;
			}
			[Token(Token = "0x6024A4D")]
			[Address(RVA = "0x1F92430", Offset = "0x1F91030", VA = "0x181F92430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700567D RID: 22141
		// (get) Token: 0x06024A4E RID: 150094 RVA: 0x000C51A8 File Offset: 0x000C33A8
		// (set) Token: 0x06024A4F RID: 150095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700567D")]
		public AutoChessShopBaseCharListView.FocusParams focusCharListParams
		{
			[Token(Token = "0x6024A4E")]
			[Address(RVA = "0x1F91FD0", Offset = "0x1F90BD0", VA = "0x181F91FD0")]
			[CompilerGenerated]
			get
			{
				return default(AutoChessShopBaseCharListView.FocusParams);
			}
			[Token(Token = "0x6024A4F")]
			[Address(RVA = "0x1F92510", Offset = "0x1F91110", VA = "0x181F92510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700567E RID: 22142
		// (get) Token: 0x06024A50 RID: 150096 RVA: 0x000C51C0 File Offset: 0x000C33C0
		// (set) Token: 0x06024A51 RID: 150097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700567E")]
		public AutoChessShopTrapListView.FocusParams focusTrapListParams
		{
			[Token(Token = "0x6024A50")]
			[Address(RVA = "0x1F92050", Offset = "0x1F90C50", VA = "0x181F92050")]
			[CompilerGenerated]
			get
			{
				return default(AutoChessShopTrapListView.FocusParams);
			}
			[Token(Token = "0x6024A51")]
			[Address(RVA = "0x1F925A0", Offset = "0x1F911A0", VA = "0x181F925A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700567F RID: 22143
		// (get) Token: 0x06024A52 RID: 150098 RVA: 0x000C51D8 File Offset: 0x000C33D8
		// (set) Token: 0x06024A53 RID: 150099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700567F")]
		public int curSelectingShopLevel
		{
			[Token(Token = "0x6024A52")]
			[Address(RVA = "0x1F91F10", Offset = "0x1F90B10", VA = "0x181F91F10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A53")]
			[Address(RVA = "0x1F924A0", Offset = "0x1F910A0", VA = "0x181F924A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005680 RID: 22144
		// (get) Token: 0x06024A54 RID: 150100 RVA: 0x000C51F0 File Offset: 0x000C33F0
		// (set) Token: 0x06024A55 RID: 150101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005680")]
		public AutoChessShopStatus shopStatus
		{
			[Token(Token = "0x6024A54")]
			[Address(RVA = "0x1F92280", Offset = "0x1F90E80", VA = "0x181F92280")]
			[CompilerGenerated]
			get
			{
				return AutoChessShopStatus.NONE;
			}
			[Token(Token = "0x6024A55")]
			[Address(RVA = "0x1F926F0", Offset = "0x1F912F0", VA = "0x181F926F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005681 RID: 22145
		// (get) Token: 0x06024A56 RID: 150102 RVA: 0x000C5208 File Offset: 0x000C3408
		[Token(Token = "0x17005681")]
		public bool hasNotTopicChar
		{
			[Token(Token = "0x6024A56")]
			[Address(RVA = "0x1F920B0", Offset = "0x1F90CB0", VA = "0x181F920B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005682 RID: 22146
		// (get) Token: 0x06024A57 RID: 150103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005682")]
		public List<AutoChessShopMenuLevelItemViewModel> menuLevelItemViewModelList
		{
			[Token(Token = "0x6024A57")]
			[Address(RVA = "0x1F921C0", Offset = "0x1F90DC0", VA = "0x181F921C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005683 RID: 22147
		// (get) Token: 0x06024A58 RID: 150104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005683")]
		public AutoChessShopLevelCharGroupListViewModel charListViewModel
		{
			[Token(Token = "0x6024A58")]
			[Address(RVA = "0x1F91DF0", Offset = "0x1F909F0", VA = "0x181F91DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005684 RID: 22148
		// (get) Token: 0x06024A59 RID: 150105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005684")]
		public AutoChessShopLevelTrapGroupListViewModel trapListViewModel
		{
			[Token(Token = "0x6024A59")]
			[Address(RVA = "0x1F922E0", Offset = "0x1F90EE0", VA = "0x181F922E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005685 RID: 22149
		// (get) Token: 0x06024A5A RID: 150106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005685")]
		public AutoChessCharSelectDetailViewModel detailViewModel
		{
			[Token(Token = "0x6024A5A")]
			[Address(RVA = "0x1F91F70", Offset = "0x1F90B70", VA = "0x181F91F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005686 RID: 22150
		// (get) Token: 0x06024A5B RID: 150107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005686")]
		public string cachedSingleEditCharChessId
		{
			[Token(Token = "0x6024A5B")]
			[Address(RVA = "0x1F91D90", Offset = "0x1F90990", VA = "0x181F91D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005687 RID: 22151
		// (get) Token: 0x06024A5C RID: 150108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005687")]
		public Dictionary<string, Deploy> cachedMultiEditCharChessInfoDict
		{
			[Token(Token = "0x6024A5C")]
			[Address(RVA = "0x1F91CD0", Offset = "0x1F908D0", VA = "0x181F91CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005688 RID: 22152
		// (get) Token: 0x06024A5D RID: 150109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005688")]
		public List<string> cachedPlayerDiyCharChessIdList
		{
			[Token(Token = "0x6024A5D")]
			[Address(RVA = "0x1F91D30", Offset = "0x1F90930", VA = "0x181F91D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024A5E RID: 150110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A5E")]
		[Address(RVA = "0x1F8EA80", Offset = "0x1F8D680", VA = "0x181F8EA80")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06024A5F RID: 150111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A5F")]
		[Address(RVA = "0x1F8F0A0", Offset = "0x1F8DCA0", VA = "0x181F8F0A0")]
		public void RefreshByPlayerData(bool needResetCharChessList, AutoChessShopBaseCharListView.FocusParams focusCharParams)
		{
		}

		// Token: 0x06024A60 RID: 150112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A60")]
		[Address(RVA = "0x1F8FF00", Offset = "0x1F8EB00", VA = "0x181F8FF00")]
		public void RefreshSelectShopLevel(int selectShopLevel)
		{
		}

		// Token: 0x06024A61 RID: 150113 RVA: 0x000C5220 File Offset: 0x000C3420
		[Token(Token = "0x6024A61")]
		[Address(RVA = "0x1F900A0", Offset = "0x1F8ECA0", VA = "0x181F900A0")]
		public bool RefreshShopStatus(AutoChessShopStatus status)
		{
			return default(bool);
		}

		// Token: 0x06024A62 RID: 150114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A62")]
		[Address(RVA = "0x1F8FD70", Offset = "0x1F8E970", VA = "0x181F8FD70")]
		public void RefreshQuickEditType(AutoChessShopQuickEditType newQuickEditType)
		{
		}

		// Token: 0x06024A63 RID: 150115 RVA: 0x000C5238 File Offset: 0x000C3438
		[Token(Token = "0x6024A63")]
		[Address(RVA = "0x1F8FBA0", Offset = "0x1F8E7A0", VA = "0x181F8FBA0")]
		public bool RefreshMultiEditChessSelectSkillId(string actId, int chessLevel, string chessId, string skillId)
		{
			return default(bool);
		}

		// Token: 0x06024A64 RID: 150116 RVA: 0x000C5250 File Offset: 0x000C3450
		[Token(Token = "0x6024A64")]
		[Address(RVA = "0x1F8F9D0", Offset = "0x1F8E5D0", VA = "0x181F8F9D0")]
		public bool RefreshMultiEditChessSelectModuleId(string actId, int chessLevel, string chessId, string moduleId)
		{
			return default(bool);
		}

		// Token: 0x06024A65 RID: 150117 RVA: 0x000C5268 File Offset: 0x000C3468
		[Token(Token = "0x6024A65")]
		[Address(RVA = "0x1F8F4C0", Offset = "0x1F8E0C0", VA = "0x181F8F4C0")]
		public bool RefreshCharChessSelectId(string chessId, AutoChessShopBaseCharListView.FocusParams focusParams)
		{
			return default(bool);
		}

		// Token: 0x06024A66 RID: 150118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A66")]
		[Address(RVA = "0x1F8F790", Offset = "0x1F8E390", VA = "0x181F8F790")]
		public void RefreshChessEditSkillAndModeCachedDict(string chessId)
		{
		}

		// Token: 0x06024A67 RID: 150119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A67")]
		[Address(RVA = "0x1F8E050", Offset = "0x1F8CC50", VA = "0x181F8E050")]
		public ActAutoChessData.ActAutoChessCharShopChessData GetChessCharShopData(string chessId)
		{
			return null;
		}

		// Token: 0x06024A68 RID: 150120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A68")]
		[Address(RVA = "0x1F8DE60", Offset = "0x1F8CA60", VA = "0x181F8DE60")]
		public AutoChessShopCharChessCardViewModel GetCharChessCardViewModel(string chessId)
		{
			return null;
		}

		// Token: 0x06024A69 RID: 150121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A69")]
		[Address(RVA = "0x1F8F930", Offset = "0x1F8E530", VA = "0x181F8F930")]
		public void RefreshFocusTrapListParams(AutoChessShopTrapListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024A6A RID: 150122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A6A")]
		[Address(RVA = "0x1F8F860", Offset = "0x1F8E460", VA = "0x181F8F860")]
		public void RefreshFocusCharListParams(AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024A6B RID: 150123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A6B")]
		[Address(RVA = "0x1F8E9B0", Offset = "0x1F8D5B0", VA = "0x181F8E9B0")]
		public List<string> GetShopLvDiyChessSlotIdList(int shopLv)
		{
			return null;
		}

		// Token: 0x06024A6C RID: 150124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A6C")]
		[Address(RVA = "0x1F8E5F0", Offset = "0x1F8D1F0", VA = "0x181F8E5F0")]
		public List<TemplateCharSelectCharInputData> GetCurShopLvAlreadySelectedDiyCharList(int shopLv)
		{
			return null;
		}

		// Token: 0x06024A6D RID: 150125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A6D")]
		[Address(RVA = "0x1F8E120", Offset = "0x1F8CD20", VA = "0x181F8E120")]
		public Dictionary<string, DiyCharDeploy> GetCurPlayerDiyChessCharInfos()
		{
			return null;
		}

		// Token: 0x06024A6E RID: 150126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A6E")]
		[Address(RVA = "0x1F90680", Offset = "0x1F8F280", VA = "0x181F90680")]
		private void _InitMenuData(AutoChessShopStatus status)
		{
		}

		// Token: 0x06024A6F RID: 150127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A6F")]
		[Address(RVA = "0x1F91790", Offset = "0x1F90390", VA = "0x181F91790")]
		private void _TryResetEditCharSkillAndModeCachedDict()
		{
		}

		// Token: 0x06024A70 RID: 150128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A70")]
		[Address(RVA = "0x1F912B0", Offset = "0x1F8FEB0", VA = "0x181F912B0")]
		private void _RefreshDetailViewModel(string chessId, bool forceUpdate)
		{
		}

		// Token: 0x06024A71 RID: 150129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A71")]
		[Address(RVA = "0x1F91100", Offset = "0x1F8FD00", VA = "0x181F91100")]
		private void _RefreshChessEditSkillAndModeCachedDict(string chessId, string equipId, int skillIndex)
		{
		}

		// Token: 0x06024A72 RID: 150130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A72")]
		[Address(RVA = "0x1F91590", Offset = "0x1F90190", VA = "0x181F91590")]
		private void _RefreshMenuLevelItemSelectState(int selectingShopLevel)
		{
		}

		// Token: 0x06024A73 RID: 150131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A73")]
		[Address(RVA = "0x1F916A0", Offset = "0x1F902A0", VA = "0x181F916A0")]
		private void _RefreshMenuLevelItemShopType(AutoChessShopStatus status)
		{
		}

		// Token: 0x06024A74 RID: 150132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A74")]
		[Address(RVA = "0x1F91440", Offset = "0x1F90040", VA = "0x181F91440")]
		private void _RefreshMenuLevelItemCurDiyCharCnt(Dictionary<int, int> shopLv2DiyCharCntDict)
		{
		}

		// Token: 0x06024A75 RID: 150133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A75")]
		[Address(RVA = "0x1F90A50", Offset = "0x1F8F650", VA = "0x181F90A50")]
		private void _RefreshCachedAssistInfos(Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> playerChessPool)
		{
		}

		// Token: 0x06024A76 RID: 150134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A76")]
		[Address(RVA = "0x1F90D80", Offset = "0x1F8F980", VA = "0x181F90D80")]
		private void _RefreshCachedDiyChessInfos(Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> playerChessPool)
		{
		}

		// Token: 0x06024A77 RID: 150135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A77")]
		[Address(RVA = "0x1F904A0", Offset = "0x1F8F0A0", VA = "0x181F904A0")]
		private List<string> _GetAllShopLevelCharDiySlotIds()
		{
			return null;
		}

		// Token: 0x06024A78 RID: 150136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A78")]
		[Address(RVA = "0x1F918C0", Offset = "0x1F904C0", VA = "0x181F918C0")]
		public AutoChessShopViewModel()
		{
		}

		// Token: 0x04033208 RID: 209416
		[Token(Token = "0x4033208")]
		[FieldOffset(Offset = "0x58")]
		private List<AutoChessShopMenuLevelItemViewModel> m_menuLevelItemViewModelList;

		// Token: 0x04033209 RID: 209417
		[Token(Token = "0x4033209")]
		[FieldOffset(Offset = "0x60")]
		private AutoChessShopLevelCharGroupListViewModel m_charListViewModel;

		// Token: 0x0403320A RID: 209418
		[Token(Token = "0x403320A")]
		[FieldOffset(Offset = "0x68")]
		private AutoChessShopLevelTrapGroupListViewModel m_trapListViewModel;

		// Token: 0x0403320B RID: 209419
		[Token(Token = "0x403320B")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessCharSelectDetailViewModel m_detailViewModel;

		// Token: 0x0403320C RID: 209420
		[Token(Token = "0x403320C")]
		[FieldOffset(Offset = "0x78")]
		private ActAutoChessData m_cachedData;

		// Token: 0x0403320D RID: 209421
		[Token(Token = "0x403320D")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<int, int> m_cachedPlayerShopLv2DiyCharCntDict;

		// Token: 0x0403320E RID: 209422
		[Token(Token = "0x403320E")]
		[FieldOffset(Offset = "0x88")]
		private List<string> m_cachedPlayerDiyCharChessIdList;

		// Token: 0x0403320F RID: 209423
		[Token(Token = "0x403320F")]
		[FieldOffset(Offset = "0x90")]
		private int m_sequenceNum;

		// Token: 0x04033210 RID: 209424
		[Token(Token = "0x4033210")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedSingleEditCharChessId;

		// Token: 0x04033211 RID: 209425
		[Token(Token = "0x4033211")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<string, Deploy> m_cachedMultiEditCharChessInfoDict;

		// Token: 0x04033212 RID: 209426
		[Token(Token = "0x4033212")]
		private const int DEFAULT_SELECT_SHOP_CHAR_LEVEL = 1;

		// Token: 0x04033213 RID: 209427
		[Token(Token = "0x4033213")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04033214 RID: 209428
		[Token(Token = "0x4033214")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x04033215 RID: 209429
		[Token(Token = "0x4033215")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curAssistCnt;

		// Token: 0x04033216 RID: 209430
		[Token(Token = "0x4033216")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_curAssistCnt;

		// Token: 0x04033217 RID: 209431
		[Token(Token = "0x4033217")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxCanAssistCnt;

		// Token: 0x04033218 RID: 209432
		[Token(Token = "0x4033218")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_maxCanAssistCnt;

		// Token: 0x04033219 RID: 209433
		[Token(Token = "0x4033219")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_notTopicCharCnt;

		// Token: 0x0403321A RID: 209434
		[Token(Token = "0x403321A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_notTopicCharCnt;

		// Token: 0x0403321B RID: 209435
		[Token(Token = "0x403321B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_curQuickEditType;

		// Token: 0x0403321C RID: 209436
		[Token(Token = "0x403321C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_curQuickEditType;

		// Token: 0x0403321D RID: 209437
		[Token(Token = "0x403321D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_focusCharListParams;

		// Token: 0x0403321E RID: 209438
		[Token(Token = "0x403321E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_focusCharListParams;

		// Token: 0x0403321F RID: 209439
		[Token(Token = "0x403321F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_focusTrapListParams;

		// Token: 0x04033220 RID: 209440
		[Token(Token = "0x4033220")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_focusTrapListParams;

		// Token: 0x04033221 RID: 209441
		[Token(Token = "0x4033221")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_curSelectingShopLevel;

		// Token: 0x04033222 RID: 209442
		[Token(Token = "0x4033222")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_curSelectingShopLevel;

		// Token: 0x04033223 RID: 209443
		[Token(Token = "0x4033223")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_shopStatus;

		// Token: 0x04033224 RID: 209444
		[Token(Token = "0x4033224")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_shopStatus;

		// Token: 0x04033225 RID: 209445
		[Token(Token = "0x4033225")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_hasNotTopicChar;

		// Token: 0x04033226 RID: 209446
		[Token(Token = "0x4033226")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_menuLevelItemViewModelList;

		// Token: 0x04033227 RID: 209447
		[Token(Token = "0x4033227")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_charListViewModel;

		// Token: 0x04033228 RID: 209448
		[Token(Token = "0x4033228")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_trapListViewModel;

		// Token: 0x04033229 RID: 209449
		[Token(Token = "0x4033229")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_detailViewModel;

		// Token: 0x0403322A RID: 209450
		[Token(Token = "0x403322A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_cachedSingleEditCharChessId;

		// Token: 0x0403322B RID: 209451
		[Token(Token = "0x403322B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_cachedMultiEditCharChessInfoDict;

		// Token: 0x0403322C RID: 209452
		[Token(Token = "0x403322C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_cachedPlayerDiyCharChessIdList;

		// Token: 0x0403322D RID: 209453
		[Token(Token = "0x403322D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403322E RID: 209454
		[Token(Token = "0x403322E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RefreshByPlayerData;

		// Token: 0x0403322F RID: 209455
		[Token(Token = "0x403322F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RefreshSelectShopLevel;

		// Token: 0x04033230 RID: 209456
		[Token(Token = "0x4033230")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_RefreshShopStatus;

		// Token: 0x04033231 RID: 209457
		[Token(Token = "0x4033231")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_RefreshQuickEditType;

		// Token: 0x04033232 RID: 209458
		[Token(Token = "0x4033232")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_RefreshMultiEditChessSelectSkillId;

		// Token: 0x04033233 RID: 209459
		[Token(Token = "0x4033233")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_RefreshMultiEditChessSelectModuleId;

		// Token: 0x04033234 RID: 209460
		[Token(Token = "0x4033234")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_RefreshCharChessSelectId;

		// Token: 0x04033235 RID: 209461
		[Token(Token = "0x4033235")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_RefreshChessEditSkillAndModeCachedDict;

		// Token: 0x04033236 RID: 209462
		[Token(Token = "0x4033236")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetChessCharShopData;

		// Token: 0x04033237 RID: 209463
		[Token(Token = "0x4033237")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetCharChessCardViewModel;

		// Token: 0x04033238 RID: 209464
		[Token(Token = "0x4033238")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_RefreshFocusTrapListParams;

		// Token: 0x04033239 RID: 209465
		[Token(Token = "0x4033239")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_RefreshFocusCharListParams;

		// Token: 0x0403323A RID: 209466
		[Token(Token = "0x403323A")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetShopLvDiyChessSlotIdList;

		// Token: 0x0403323B RID: 209467
		[Token(Token = "0x403323B")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetCurShopLvAlreadySelectedDiyCharList;

		// Token: 0x0403323C RID: 209468
		[Token(Token = "0x403323C")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetCurPlayerDiyChessCharInfos;

		// Token: 0x0403323D RID: 209469
		[Token(Token = "0x403323D")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__InitMenuData;

		// Token: 0x0403323E RID: 209470
		[Token(Token = "0x403323E")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__TryResetEditCharSkillAndModeCachedDict;

		// Token: 0x0403323F RID: 209471
		[Token(Token = "0x403323F")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__RefreshDetailViewModel;

		// Token: 0x04033240 RID: 209472
		[Token(Token = "0x4033240")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__RefreshChessEditSkillAndModeCachedDict;

		// Token: 0x04033241 RID: 209473
		[Token(Token = "0x4033241")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__RefreshMenuLevelItemSelectState;

		// Token: 0x04033242 RID: 209474
		[Token(Token = "0x4033242")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__RefreshMenuLevelItemShopType;

		// Token: 0x04033243 RID: 209475
		[Token(Token = "0x4033243")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__RefreshMenuLevelItemCurDiyCharCnt;

		// Token: 0x04033244 RID: 209476
		[Token(Token = "0x4033244")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__RefreshCachedAssistInfos;

		// Token: 0x04033245 RID: 209477
		[Token(Token = "0x4033245")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__RefreshCachedDiyChessInfos;

		// Token: 0x04033246 RID: 209478
		[Token(Token = "0x4033246")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__GetAllShopLevelCharDiySlotIds;

		// Token: 0x04033247 RID: 209479
		[Token(Token = "0x4033247")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
