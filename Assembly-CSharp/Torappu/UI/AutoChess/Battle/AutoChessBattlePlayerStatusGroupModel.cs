using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064E7 RID: 25831
	[Token(Token = "0x20064E7")]
	public class AutoChessBattlePlayerStatusGroupModel : IHotfixable
	{
		// Token: 0x17005784 RID: 22404
		// (get) Token: 0x060251C5 RID: 152005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005784")]
		public List<AutoChessBattlePlayerStatusModel> displayPlayerList
		{
			[Token(Token = "0x60251C5")]
			[Address(RVA = "0x2011410", Offset = "0x2010010", VA = "0x182011410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17005785 RID: 22405
		// (get) Token: 0x060251C6 RID: 152006 RVA: 0x000C6750 File Offset: 0x000C4950
		// (set) Token: 0x060251C7 RID: 152007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005785")]
		public int selfPlayerIdx
		{
			[Token(Token = "0x60251C6")]
			[Address(RVA = "0x20116C0", Offset = "0x20102C0", VA = "0x1820116C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60251C7")]
			[Address(RVA = "0x2011B00", Offset = "0x2010700", VA = "0x182011B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005786 RID: 22406
		// (get) Token: 0x060251C8 RID: 152008 RVA: 0x000C6768 File Offset: 0x000C4968
		// (set) Token: 0x060251C9 RID: 152009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005786")]
		public bool canObserveOther
		{
			[Token(Token = "0x60251C8")]
			[Address(RVA = "0x20113B0", Offset = "0x200FFB0", VA = "0x1820113B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60251C9")]
			[Address(RVA = "0x2011940", Offset = "0x2010540", VA = "0x182011940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005787 RID: 22407
		// (get) Token: 0x060251CA RID: 152010 RVA: 0x000C6780 File Offset: 0x000C4980
		// (set) Token: 0x060251CB RID: 152011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005787")]
		public bool canObLeft
		{
			[Token(Token = "0x60251CA")]
			[Address(RVA = "0x20112F0", Offset = "0x200FEF0", VA = "0x1820112F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60251CB")]
			[Address(RVA = "0x2011860", Offset = "0x2010460", VA = "0x182011860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005788 RID: 22408
		// (get) Token: 0x060251CC RID: 152012 RVA: 0x000C6798 File Offset: 0x000C4998
		// (set) Token: 0x060251CD RID: 152013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005788")]
		public bool canObRight
		{
			[Token(Token = "0x60251CC")]
			[Address(RVA = "0x2011350", Offset = "0x200FF50", VA = "0x182011350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60251CD")]
			[Address(RVA = "0x20118D0", Offset = "0x20104D0", VA = "0x1820118D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005789 RID: 22409
		// (get) Token: 0x060251CE RID: 152014 RVA: 0x000C67B0 File Offset: 0x000C49B0
		// (set) Token: 0x060251CF RID: 152015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005789")]
		public bool inBattle
		{
			[Token(Token = "0x60251CE")]
			[Address(RVA = "0x20114D0", Offset = "0x20100D0", VA = "0x1820114D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60251CF")]
			[Address(RVA = "0x2011A20", Offset = "0x2010620", VA = "0x182011A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700578A RID: 22410
		// (get) Token: 0x060251D0 RID: 152016 RVA: 0x000C67C8 File Offset: 0x000C49C8
		// (set) Token: 0x060251D1 RID: 152017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700578A")]
		public int alivePlayerCount
		{
			[Token(Token = "0x60251D0")]
			[Address(RVA = "0x2011230", Offset = "0x200FE30", VA = "0x182011230")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60251D1")]
			[Address(RVA = "0x2011780", Offset = "0x2010380", VA = "0x182011780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700578B RID: 22411
		// (get) Token: 0x060251D2 RID: 152018 RVA: 0x000C67E0 File Offset: 0x000C49E0
		// (set) Token: 0x060251D3 RID: 152019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700578B")]
		public int alivePrepReadyPlayerCount
		{
			[Token(Token = "0x60251D2")]
			[Address(RVA = "0x2011290", Offset = "0x200FE90", VA = "0x182011290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60251D3")]
			[Address(RVA = "0x20117F0", Offset = "0x20103F0", VA = "0x1820117F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700578C RID: 22412
		// (get) Token: 0x060251D4 RID: 152020 RVA: 0x000C67F8 File Offset: 0x000C49F8
		// (set) Token: 0x060251D5 RID: 152021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700578C")]
		public bool showEmoji
		{
			[Token(Token = "0x60251D4")]
			[Address(RVA = "0x2011720", Offset = "0x2010320", VA = "0x182011720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60251D5")]
			[Address(RVA = "0x2011B70", Offset = "0x2010770", VA = "0x182011B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700578D RID: 22413
		// (get) Token: 0x060251D6 RID: 152022 RVA: 0x000C6810 File Offset: 0x000C4A10
		// (set) Token: 0x060251D7 RID: 152023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700578D")]
		public float emojiCD
		{
			[Token(Token = "0x60251D6")]
			[Address(RVA = "0x2011470", Offset = "0x2010070", VA = "0x182011470")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60251D7")]
			[Address(RVA = "0x20119B0", Offset = "0x20105B0", VA = "0x1820119B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700578E RID: 22414
		// (get) Token: 0x060251D8 RID: 152024 RVA: 0x000C6828 File Offset: 0x000C4A28
		// (set) Token: 0x060251D9 RID: 152025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700578E")]
		public bool isObPanelVisible
		{
			[Token(Token = "0x60251D8")]
			[Address(RVA = "0x2011600", Offset = "0x2010200", VA = "0x182011600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60251D9")]
			[Address(RVA = "0x2011A90", Offset = "0x2010690", VA = "0x182011A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700578F RID: 22415
		// (get) Token: 0x060251DA RID: 152026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700578F")]
		public AutoChessBattlePlayerStatusModel obTargetPlayer
		{
			[Token(Token = "0x60251DA")]
			[Address(RVA = "0x2011660", Offset = "0x2010260", VA = "0x182011660")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005790 RID: 22416
		// (get) Token: 0x060251DB RID: 152027 RVA: 0x000C6840 File Offset: 0x000C4A40
		[Token(Token = "0x17005790")]
		public bool isObOverview
		{
			[Token(Token = "0x60251DB")]
			[Address(RVA = "0x20115A0", Offset = "0x20101A0", VA = "0x1820115A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005791 RID: 22417
		// (get) Token: 0x060251DC RID: 152028 RVA: 0x000C6858 File Offset: 0x000C4A58
		[Token(Token = "0x17005791")]
		public bool isAvatarListVisible
		{
			[Token(Token = "0x60251DC")]
			[Address(RVA = "0x2011530", Offset = "0x2010130", VA = "0x182011530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060251DD RID: 152029 RVA: 0x000C6870 File Offset: 0x000C4A70
		[Token(Token = "0x60251DD")]
		[Address(RVA = "0x200F490", Offset = "0x200E090", VA = "0x18200F490")]
		public AutoChessBattlePlayerStatusGroupModel.BossGrpStatus CalcBossGrpStatus(int targetPlayerIdx)
		{
			return AutoChessBattlePlayerStatusGroupModel.BossGrpStatus.NONE;
		}

		// Token: 0x060251DE RID: 152030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60251DE")]
		[Address(RVA = "0x200F910", Offset = "0x200E510", VA = "0x18200F910")]
		public AutoChessBattlePlayerStatusModel FindSelfStatusModel()
		{
			return null;
		}

		// Token: 0x060251DF RID: 152031 RVA: 0x000C6888 File Offset: 0x000C4A88
		[Token(Token = "0x60251DF")]
		[Address(RVA = "0x200F5F0", Offset = "0x200E1F0", VA = "0x18200F5F0")]
		public bool CheckIfCancelObValid()
		{
			return default(bool);
		}

		// Token: 0x060251E0 RID: 152032 RVA: 0x000C68A0 File Offset: 0x000C4AA0
		[Token(Token = "0x60251E0")]
		[Address(RVA = "0x200F710", Offset = "0x200E310", VA = "0x18200F710")]
		public int FindFirstAvailObTarget()
		{
			return 0;
		}

		// Token: 0x060251E1 RID: 152033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60251E1")]
		[Address(RVA = "0x2010290", Offset = "0x200EE90", VA = "0x182010290")]
		private AutoChessBattlePlayerStatusModel _FindPlayerStatusModel(int playerIdx)
		{
			return null;
		}

		// Token: 0x060251E2 RID: 152034 RVA: 0x000C68B8 File Offset: 0x000C4AB8
		[Token(Token = "0x60251E2")]
		[Address(RVA = "0x200F9D0", Offset = "0x200E5D0", VA = "0x18200F9D0")]
		public AutoChessBattleUIViewModel.AutoChessGiveUpTipType GetGiveUpTipType(bool isHiddenBoss)
		{
			return AutoChessBattleUIViewModel.AutoChessGiveUpTipType.GIVE_UP_VIOLATION;
		}

		// Token: 0x060251E3 RID: 152035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251E3")]
		[Address(RVA = "0x200FB40", Offset = "0x200E740", VA = "0x18200FB40")]
		public void Update(AutoChessData autoChessData, AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
		}

		// Token: 0x060251E4 RID: 152036 RVA: 0x000C68D0 File Offset: 0x000C4AD0
		[Token(Token = "0x60251E4")]
		[Address(RVA = "0x20108B0", Offset = "0x200F4B0", VA = "0x1820108B0")]
		private bool _UpdateObPanelVisible(AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
			return default(bool);
		}

		// Token: 0x060251E5 RID: 152037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251E5")]
		[Address(RVA = "0x2010590", Offset = "0x200F190", VA = "0x182010590")]
		private void _UpdateBattleObInfo(AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
		}

		// Token: 0x060251E6 RID: 152038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251E6")]
		[Address(RVA = "0x2010980", Offset = "0x200F580", VA = "0x182010980")]
		private void _UpdatePlayerList(AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
		}

		// Token: 0x060251E7 RID: 152039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251E7")]
		[Address(RVA = "0x20103F0", Offset = "0x200EFF0", VA = "0x1820103F0")]
		private void _UpdateAliveAndReadyPlayerCount(Dictionary<int, AutoChessPlayerDataModel.ScenePlayerData> allPlayerDatas)
		{
		}

		// Token: 0x060251E8 RID: 152040 RVA: 0x000C68E8 File Offset: 0x000C4AE8
		[Token(Token = "0x60251E8")]
		[Address(RVA = "0x2010040", Offset = "0x200EC40", VA = "0x182010040")]
		private AutoChessBattlePlayerStatusGroupModel.ActionState _CalcPlayerActionState(AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus, AutoChessPlayerDataModel.ScenePlayerData playerInfo)
		{
			return AutoChessBattlePlayerStatusGroupModel.ActionState.IDLE;
		}

		// Token: 0x060251E9 RID: 152041 RVA: 0x000C6900 File Offset: 0x000C4B00
		[Token(Token = "0x60251E9")]
		[Address(RVA = "0x200FF30", Offset = "0x200EB30", VA = "0x18200FF30")]
		private AutoChessBattlePlayerStatusGroupModel.ActionState _CalcActionStateInSpPrepare(AutoChessDataCenter dataCenter, AutoChessPlayerDataModel.ScenePlayerData playerInfo)
		{
			return AutoChessBattlePlayerStatusGroupModel.ActionState.IDLE;
		}

		// Token: 0x060251EA RID: 152042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251EA")]
		[Address(RVA = "0x20110B0", Offset = "0x200FCB0", VA = "0x1820110B0")]
		public AutoChessBattlePlayerStatusGroupModel()
		{
		}

		// Token: 0x0403403B RID: 213051
		[Token(Token = "0x403403B")]
		[FieldOffset(Offset = "0x10")]
		private ActAutoChessModeType m_modeType;

		// Token: 0x0403403C RID: 213052
		[Token(Token = "0x403403C")]
		[FieldOffset(Offset = "0x14")]
		private bool m_inBossRound;

		// Token: 0x0403403D RID: 213053
		[Token(Token = "0x403403D")]
		[FieldOffset(Offset = "0x18")]
		private int m_playerViewIdx;

		// Token: 0x0403403E RID: 213054
		[Token(Token = "0x403403E")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_canDisplayAvatar;

		// Token: 0x0403403F RID: 213055
		[Token(Token = "0x403403F")]
		[FieldOffset(Offset = "0x20")]
		private int m_leftBattleObIdx;

		// Token: 0x04034040 RID: 213056
		[Token(Token = "0x4034040")]
		[FieldOffset(Offset = "0x24")]
		private int m_rightBattleObIdx;

		// Token: 0x04034041 RID: 213057
		[Token(Token = "0x4034041")]
		[FieldOffset(Offset = "0x28")]
		private AutoChessGameStatus.AutoChessBattleMapLayer m_mapLayer;

		// Token: 0x04034042 RID: 213058
		[Token(Token = "0x4034042")]
		[FieldOffset(Offset = "0x30")]
		private AutoChessBattlePlayerStatusModel m_obTargetPlayer;

		// Token: 0x04034043 RID: 213059
		[Token(Token = "0x4034043")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, string> m_playerGroupDict;

		// Token: 0x04034044 RID: 213060
		[Token(Token = "0x4034044")]
		[FieldOffset(Offset = "0x40")]
		private List<AutoChessBattlePlayerStatusModel> m_playerStatusList;

		// Token: 0x0403404E RID: 213070
		[Token(Token = "0x403404E")]
		[FieldOffset(Offset = "0x64")]
		public SeqNumSource emojiOpenNum;

		// Token: 0x0403404F RID: 213071
		[Token(Token = "0x403404F")]
		[FieldOffset(Offset = "0x70")]
		public SeqNumSource emojiReqNum;

		// Token: 0x04034052 RID: 213074
		[Token(Token = "0x4034052")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayPlayerList;

		// Token: 0x04034053 RID: 213075
		[Token(Token = "0x4034053")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selfPlayerIdx;

		// Token: 0x04034054 RID: 213076
		[Token(Token = "0x4034054")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_selfPlayerIdx;

		// Token: 0x04034055 RID: 213077
		[Token(Token = "0x4034055")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canObserveOther;

		// Token: 0x04034056 RID: 213078
		[Token(Token = "0x4034056")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_canObserveOther;

		// Token: 0x04034057 RID: 213079
		[Token(Token = "0x4034057")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_canObLeft;

		// Token: 0x04034058 RID: 213080
		[Token(Token = "0x4034058")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_canObLeft;

		// Token: 0x04034059 RID: 213081
		[Token(Token = "0x4034059")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_canObRight;

		// Token: 0x0403405A RID: 213082
		[Token(Token = "0x403405A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_canObRight;

		// Token: 0x0403405B RID: 213083
		[Token(Token = "0x403405B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_inBattle;

		// Token: 0x0403405C RID: 213084
		[Token(Token = "0x403405C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_inBattle;

		// Token: 0x0403405D RID: 213085
		[Token(Token = "0x403405D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_alivePlayerCount;

		// Token: 0x0403405E RID: 213086
		[Token(Token = "0x403405E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_alivePlayerCount;

		// Token: 0x0403405F RID: 213087
		[Token(Token = "0x403405F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_alivePrepReadyPlayerCount;

		// Token: 0x04034060 RID: 213088
		[Token(Token = "0x4034060")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_alivePrepReadyPlayerCount;

		// Token: 0x04034061 RID: 213089
		[Token(Token = "0x4034061")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_showEmoji;

		// Token: 0x04034062 RID: 213090
		[Token(Token = "0x4034062")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_showEmoji;

		// Token: 0x04034063 RID: 213091
		[Token(Token = "0x4034063")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_emojiCD;

		// Token: 0x04034064 RID: 213092
		[Token(Token = "0x4034064")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_emojiCD;

		// Token: 0x04034065 RID: 213093
		[Token(Token = "0x4034065")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_isObPanelVisible;

		// Token: 0x04034066 RID: 213094
		[Token(Token = "0x4034066")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_isObPanelVisible;

		// Token: 0x04034067 RID: 213095
		[Token(Token = "0x4034067")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_obTargetPlayer;

		// Token: 0x04034068 RID: 213096
		[Token(Token = "0x4034068")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_isObOverview;

		// Token: 0x04034069 RID: 213097
		[Token(Token = "0x4034069")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_isAvatarListVisible;

		// Token: 0x0403406A RID: 213098
		[Token(Token = "0x403406A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CalcBossGrpStatus;

		// Token: 0x0403406B RID: 213099
		[Token(Token = "0x403406B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_FindSelfStatusModel;

		// Token: 0x0403406C RID: 213100
		[Token(Token = "0x403406C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CheckIfCancelObValid;

		// Token: 0x0403406D RID: 213101
		[Token(Token = "0x403406D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_FindFirstAvailObTarget;

		// Token: 0x0403406E RID: 213102
		[Token(Token = "0x403406E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__FindPlayerStatusModel;

		// Token: 0x0403406F RID: 213103
		[Token(Token = "0x403406F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetGiveUpTipType;

		// Token: 0x04034070 RID: 213104
		[Token(Token = "0x4034070")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04034071 RID: 213105
		[Token(Token = "0x4034071")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateObPanelVisible;

		// Token: 0x04034072 RID: 213106
		[Token(Token = "0x4034072")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__UpdateBattleObInfo;

		// Token: 0x04034073 RID: 213107
		[Token(Token = "0x4034073")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__UpdatePlayerList;

		// Token: 0x04034074 RID: 213108
		[Token(Token = "0x4034074")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__UpdateAliveAndReadyPlayerCount;

		// Token: 0x04034075 RID: 213109
		[Token(Token = "0x4034075")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__CalcPlayerActionState;

		// Token: 0x04034076 RID: 213110
		[Token(Token = "0x4034076")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__CalcActionStateInSpPrepare;

		// Token: 0x04034077 RID: 213111
		[Token(Token = "0x4034077")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064E8 RID: 25832
		[Token(Token = "0x20064E8")]
		public enum ActionState
		{
			// Token: 0x04034079 RID: 213113
			[Token(Token = "0x4034079")]
			IDLE,
			// Token: 0x0403407A RID: 213114
			[Token(Token = "0x403407A")]
			MOVING,
			// Token: 0x0403407B RID: 213115
			[Token(Token = "0x403407B")]
			COMPLETE
		}

		// Token: 0x020064E9 RID: 25833
		[Token(Token = "0x20064E9")]
		public enum BossGrpStatus
		{
			// Token: 0x0403407D RID: 213117
			[Token(Token = "0x403407D")]
			NONE,
			// Token: 0x0403407E RID: 213118
			[Token(Token = "0x403407E")]
			MAJOR,
			// Token: 0x0403407F RID: 213119
			[Token(Token = "0x403407F")]
			MINOR
		}
	}
}
