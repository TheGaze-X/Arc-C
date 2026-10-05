using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.Legion;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D6D RID: 23917
	[Token(Token = "0x2005D6D")]
	public class ClimbTowerSquadEditStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170051B0 RID: 20912
		// (get) Token: 0x06022A7D RID: 141949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A7E RID: 141950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B0")]
		public List<ClimbTowerSquadItemModel> charList
		{
			[Token(Token = "0x6022A7D")]
			[Address(RVA = "0x1D35160", Offset = "0x1D33D60", VA = "0x181D35160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022A7E")]
			[Address(RVA = "0x1D357B0", Offset = "0x1D343B0", VA = "0x181D357B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B1 RID: 20913
		// (get) Token: 0x06022A7F RID: 141951 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A80 RID: 141952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B1")]
		public List<TowerCurrent.TowerTrapInfo> trapList
		{
			[Token(Token = "0x6022A7F")]
			[Address(RVA = "0x1D35750", Offset = "0x1D34350", VA = "0x181D35750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022A80")]
			[Address(RVA = "0x1D35B70", Offset = "0x1D34770", VA = "0x181D35B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B2 RID: 20914
		// (get) Token: 0x06022A81 RID: 141953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A82 RID: 141954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B2")]
		public RuneTable.PackedRuneData runeData
		{
			[Token(Token = "0x6022A81")]
			[Address(RVA = "0x1D35570", Offset = "0x1D34170", VA = "0x181D35570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022A82")]
			[Address(RVA = "0x1D35A70", Offset = "0x1D34670", VA = "0x181D35A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B3 RID: 20915
		// (get) Token: 0x06022A83 RID: 141955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A84 RID: 141956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B3")]
		public ClimbTowerSingleLevelData layerData
		{
			[Token(Token = "0x6022A83")]
			[Address(RVA = "0x1D35510", Offset = "0x1D34110", VA = "0x181D35510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022A84")]
			[Address(RVA = "0x1D359F0", Offset = "0x1D345F0", VA = "0x181D359F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B4 RID: 20916
		// (get) Token: 0x06022A85 RID: 141957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A86 RID: 141958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B4")]
		public string towerId
		{
			[Token(Token = "0x6022A85")]
			[Address(RVA = "0x1D356F0", Offset = "0x1D342F0", VA = "0x181D356F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022A86")]
			[Address(RVA = "0x1D35AF0", Offset = "0x1D346F0", VA = "0x181D35AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B5 RID: 20917
		// (get) Token: 0x06022A87 RID: 141959 RVA: 0x000BE470 File Offset: 0x000BC670
		// (set) Token: 0x06022A88 RID: 141960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B5")]
		public int coord
		{
			[Token(Token = "0x6022A87")]
			[Address(RVA = "0x1D351C0", Offset = "0x1D33DC0", VA = "0x181D351C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6022A88")]
			[Address(RVA = "0x1D35830", Offset = "0x1D34430", VA = "0x181D35830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B6 RID: 20918
		// (get) Token: 0x06022A89 RID: 141961 RVA: 0x000BE488 File Offset: 0x000BC688
		// (set) Token: 0x06022A8A RID: 141962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B6")]
		public bool isTutorialTower
		{
			[Token(Token = "0x6022A89")]
			[Address(RVA = "0x1D354B0", Offset = "0x1D340B0", VA = "0x181D354B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022A8A")]
			[Address(RVA = "0x1D35980", Offset = "0x1D34580", VA = "0x181D35980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B7 RID: 20919
		// (get) Token: 0x06022A8B RID: 141963 RVA: 0x000BE4A0 File Offset: 0x000BC6A0
		// (set) Token: 0x06022A8C RID: 141964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B7")]
		public long gameStartTs
		{
			[Token(Token = "0x6022A8B")]
			[Address(RVA = "0x1D353F0", Offset = "0x1D33FF0", VA = "0x181D353F0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6022A8C")]
			[Address(RVA = "0x1D358A0", Offset = "0x1D344A0", VA = "0x181D358A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B8 RID: 20920
		// (get) Token: 0x06022A8D RID: 141965 RVA: 0x000BE4B8 File Offset: 0x000BC6B8
		// (set) Token: 0x06022A8E RID: 141966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051B8")]
		public bool isHardMode
		{
			[Token(Token = "0x6022A8D")]
			[Address(RVA = "0x1D35450", Offset = "0x1D34050", VA = "0x181D35450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022A8E")]
			[Address(RVA = "0x1D35910", Offset = "0x1D34510", VA = "0x181D35910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170051B9 RID: 20921
		// (get) Token: 0x06022A8F RID: 141967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051B9")]
		public ClimbTowerSquadItemModel focusCharModel
		{
			[Token(Token = "0x6022A8F")]
			[Address(RVA = "0x1D35220", Offset = "0x1D33E20", VA = "0x181D35220")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051BA RID: 20922
		// (get) Token: 0x06022A90 RID: 141968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051BA")]
		public string stageId
		{
			[Token(Token = "0x6022A90")]
			[Address(RVA = "0x1D355D0", Offset = "0x1D341D0", VA = "0x181D355D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022A91 RID: 141969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A91")]
		[Address(RVA = "0x1D33520", Offset = "0x1D32120", VA = "0x181D33520")]
		public ClimbTowerSquadItemModel FindSquadItemByCardId(int cardId)
		{
			return null;
		}

		// Token: 0x06022A92 RID: 141970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A92")]
		[Address(RVA = "0x1D336E0", Offset = "0x1D322E0", VA = "0x181D336E0")]
		public void InitData(bool isTutorial, UIPage page, List<CharacterCardViewModel> predefinedCharList)
		{
		}

		// Token: 0x06022A93 RID: 141971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A93")]
		[Address(RVA = "0x1D34A40", Offset = "0x1D33640", VA = "0x181D34A40")]
		private void _InitTrapAndRuneData(TowerCurrent playerTower, ClimbTowerSingleTowerData towerData)
		{
		}

		// Token: 0x06022A94 RID: 141972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A94")]
		[Address(RVA = "0x1D34620", Offset = "0x1D33220", VA = "0x181D34620")]
		public void UpdateEditStatus()
		{
		}

		// Token: 0x06022A95 RID: 141973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A95")]
		[Address(RVA = "0x1D331F0", Offset = "0x1D31DF0", VA = "0x181D331F0")]
		public SquadItemStruct[] CreateSquadToStartBattle()
		{
			return null;
		}

		// Token: 0x06022A96 RID: 141974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A96")]
		[Address(RVA = "0x1D34170", Offset = "0x1D32D70", VA = "0x181D34170")]
		public CommonStartBattleRequest.SquadModel ParseBattleStartRequestSquad()
		{
			return null;
		}

		// Token: 0x06022A97 RID: 141975 RVA: 0x000BE4D0 File Offset: 0x000BC6D0
		[Token(Token = "0x6022A97")]
		[Address(RVA = "0x1D348F0", Offset = "0x1D334F0", VA = "0x181D348F0")]
		private int _GetSkillIndexFromCardModel(CharacterCardViewModel cardViewModel)
		{
			return 0;
		}

		// Token: 0x06022A98 RID: 141976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A98")]
		[Address(RVA = "0x1D32E00", Offset = "0x1D31A00", VA = "0x181D32E00")]
		public List<LegionInput.ProfessionSkillPartPair> CreateProfessionSkillPart()
		{
			return null;
		}

		// Token: 0x06022A99 RID: 141977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A99")]
		[Address(RVA = "0x1D32BB0", Offset = "0x1D317B0", VA = "0x181D32BB0")]
		public List<LegionInput.PreGivenTrapInfo> CreateGivenTrapInfos()
		{
			return null;
		}

		// Token: 0x06022A9A RID: 141978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A9A")]
		[Address(RVA = "0x1D325B0", Offset = "0x1D311B0", VA = "0x181D325B0")]
		public BattlePlayerData CreateBattlePlayerData(List<RequestSquadSlot> squadSlots, LevelData levelData)
		{
			return null;
		}

		// Token: 0x06022A9B RID: 141979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A9B")]
		[Address(RVA = "0x1D35100", Offset = "0x1D33D00", VA = "0x181D35100")]
		public ClimbTowerSquadEditStateBean()
		{
		}

		// Token: 0x0402FA14 RID: 195092
		[Token(Token = "0x402FA14")]
		[FieldOffset(Offset = "0x18")]
		public ClimbTowerSquadEditStateBean.FocusParams focusParams;

		// Token: 0x0402FA1D RID: 195101
		[Token(Token = "0x402FA1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charList;

		// Token: 0x0402FA1E RID: 195102
		[Token(Token = "0x402FA1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charList;

		// Token: 0x0402FA1F RID: 195103
		[Token(Token = "0x402FA1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_trapList;

		// Token: 0x0402FA20 RID: 195104
		[Token(Token = "0x402FA20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_trapList;

		// Token: 0x0402FA21 RID: 195105
		[Token(Token = "0x402FA21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_runeData;

		// Token: 0x0402FA22 RID: 195106
		[Token(Token = "0x402FA22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_runeData;

		// Token: 0x0402FA23 RID: 195107
		[Token(Token = "0x402FA23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_layerData;

		// Token: 0x0402FA24 RID: 195108
		[Token(Token = "0x402FA24")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_layerData;

		// Token: 0x0402FA25 RID: 195109
		[Token(Token = "0x402FA25")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_towerId;

		// Token: 0x0402FA26 RID: 195110
		[Token(Token = "0x402FA26")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_towerId;

		// Token: 0x0402FA27 RID: 195111
		[Token(Token = "0x402FA27")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_coord;

		// Token: 0x0402FA28 RID: 195112
		[Token(Token = "0x402FA28")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_coord;

		// Token: 0x0402FA29 RID: 195113
		[Token(Token = "0x402FA29")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isTutorialTower;

		// Token: 0x0402FA2A RID: 195114
		[Token(Token = "0x402FA2A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_isTutorialTower;

		// Token: 0x0402FA2B RID: 195115
		[Token(Token = "0x402FA2B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_gameStartTs;

		// Token: 0x0402FA2C RID: 195116
		[Token(Token = "0x402FA2C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_gameStartTs;

		// Token: 0x0402FA2D RID: 195117
		[Token(Token = "0x402FA2D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isHardMode;

		// Token: 0x0402FA2E RID: 195118
		[Token(Token = "0x402FA2E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_isHardMode;

		// Token: 0x0402FA2F RID: 195119
		[Token(Token = "0x402FA2F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_focusCharModel;

		// Token: 0x0402FA30 RID: 195120
		[Token(Token = "0x402FA30")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0402FA31 RID: 195121
		[Token(Token = "0x402FA31")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_FindSquadItemByCardId;

		// Token: 0x0402FA32 RID: 195122
		[Token(Token = "0x402FA32")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402FA33 RID: 195123
		[Token(Token = "0x402FA33")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitTrapAndRuneData;

		// Token: 0x0402FA34 RID: 195124
		[Token(Token = "0x402FA34")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_UpdateEditStatus;

		// Token: 0x0402FA35 RID: 195125
		[Token(Token = "0x402FA35")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CreateSquadToStartBattle;

		// Token: 0x0402FA36 RID: 195126
		[Token(Token = "0x402FA36")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ParseBattleStartRequestSquad;

		// Token: 0x0402FA37 RID: 195127
		[Token(Token = "0x402FA37")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GetSkillIndexFromCardModel;

		// Token: 0x0402FA38 RID: 195128
		[Token(Token = "0x402FA38")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CreateProfessionSkillPart;

		// Token: 0x0402FA39 RID: 195129
		[Token(Token = "0x402FA39")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CreateGivenTrapInfos;

		// Token: 0x0402FA3A RID: 195130
		[Token(Token = "0x402FA3A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CreateBattlePlayerData;

		// Token: 0x0402FA3B RID: 195131
		[Token(Token = "0x402FA3B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D6E RID: 23918
		[Token(Token = "0x2005D6E")]
		public struct FocusParams
		{
			// Token: 0x0402FA3C RID: 195132
			[Token(Token = "0x402FA3C")]
			[FieldOffset(Offset = "0x0")]
			public bool focusByRelativePosition;

			// Token: 0x0402FA3D RID: 195133
			[Token(Token = "0x402FA3D")]
			[FieldOffset(Offset = "0x4")]
			public int focusCardId;

			// Token: 0x0402FA3E RID: 195134
			[Token(Token = "0x402FA3E")]
			[FieldOffset(Offset = "0x8")]
			public int viewIndex;

			// Token: 0x0402FA3F RID: 195135
			[Token(Token = "0x402FA3F")]
			[FieldOffset(Offset = "0xC")]
			public float columnIndex;
		}
	}
}
