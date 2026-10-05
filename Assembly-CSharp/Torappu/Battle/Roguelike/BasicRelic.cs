using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x02002924 RID: 10532
	[Token(Token = "0x2002924")]
	public abstract class BasicRelic : IHotfixable
	{
		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x06011772 RID: 71538
		[Token(Token = "0x170026A0")]
		public abstract BasicRelic.RelicType relicType { [Token(Token = "0x6011772")] get; }

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x06011773 RID: 71539 RVA: 0x0006B730 File Offset: 0x00069930
		// (set) Token: 0x06011774 RID: 71540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170026A1")]
		public int stackLayer
		{
			[Token(Token = "0x6011773")]
			[Address(RVA = "0x9379C0", Offset = "0x9365C0", VA = "0x1809379C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6011774")]
			[Address(RVA = "0x937B20", Offset = "0x936720", VA = "0x180937B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x06011775 RID: 71541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06011776 RID: 71542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170026A2")]
		public RoguelikeBuff data
		{
			[Token(Token = "0x6011775")]
			[Address(RVA = "0x937900", Offset = "0x936500", VA = "0x180937900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6011776")]
			[Address(RVA = "0x937A20", Offset = "0x936620", VA = "0x180937A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x06011777 RID: 71543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06011778 RID: 71544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170026A3")]
		private protected RoguelikeBattleManager m_roguelikeManager
		{
			[Token(Token = "0x6011777")]
			[Address(RVA = "0x937960", Offset = "0x936560", VA = "0x180937960")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6011778")]
			[Address(RVA = "0x937AA0", Offset = "0x9366A0", VA = "0x180937AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x06011779 RID: 71545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026A4")]
		protected Blackboard blackboard
		{
			[Token(Token = "0x6011779")]
			[Address(RVA = "0x937850", Offset = "0x936450", VA = "0x180937850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601177A RID: 71546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601177A")]
		[Address(RVA = "0x9374E0", Offset = "0x9360E0", VA = "0x1809374E0")]
		public void Init(RoguelikeBuff data, int stackLayer, RoguelikeBattleManager manager)
		{
		}

		// Token: 0x0601177B RID: 71547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601177B")]
		[Address(RVA = "0x9369B0", Offset = "0x9355B0", VA = "0x1809369B0")]
		protected void ApplyAdditionsToAttribute(AttributesData attributes, int stackLayer = 1)
		{
		}

		// Token: 0x0601177C RID: 71548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601177C")]
		[Address(RVA = "0x9370D0", Offset = "0x935CD0", VA = "0x1809370D0")]
		protected void ApplyMultipliersToAttribute(AttributesData attributes, int stackLayer = 1)
		{
		}

		// Token: 0x0601177D RID: 71549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601177D")]
		[Address(RVA = "0x936CD0", Offset = "0x9358D0", VA = "0x180936CD0")]
		protected void ApplyFinalScalersToAttribute(AttributesData attributes, int stackLayer = 1)
		{
		}

		// Token: 0x0601177E RID: 71550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601177E")]
		[Address(RVA = "0x937730", Offset = "0x936330", VA = "0x180937730", Slot = "5")]
		public virtual void OnInit()
		{
		}

		// Token: 0x0601177F RID: 71551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601177F")]
		[Address(RVA = "0x9373F0", Offset = "0x935FF0", VA = "0x1809373F0", Slot = "6")]
		protected virtual void DoPreProcess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011780 RID: 71552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011780")]
		[Address(RVA = "0x937450", Offset = "0x936050", VA = "0x180937450")]
		public void DoPreprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011781 RID: 71553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011781")]
		[Address(RVA = "0x937790", Offset = "0x936390", VA = "0x180937790", Slot = "7")]
		public virtual void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011782 RID: 71554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011782")]
		[Address(RVA = "0x9376D0", Offset = "0x9362D0", VA = "0x1809376D0", Slot = "8")]
		public virtual void LatePreprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011783 RID: 71555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011783")]
		[Address(RVA = "0x9377F0", Offset = "0x9363F0", VA = "0x1809377F0")]
		protected BasicRelic()
		{
		}

		// Token: 0x04013860 RID: 79968
		[Token(Token = "0x4013860")]
		[FieldOffset(Offset = "0x10")]
		protected BasicRelic.RelicTargetSelector m_selector;

		// Token: 0x04013864 RID: 79972
		[Token(Token = "0x4013864")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stackLayer;

		// Token: 0x04013865 RID: 79973
		[Token(Token = "0x4013865")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_stackLayer;

		// Token: 0x04013866 RID: 79974
		[Token(Token = "0x4013866")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04013867 RID: 79975
		[Token(Token = "0x4013867")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x04013868 RID: 79976
		[Token(Token = "0x4013868")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_m_roguelikeManager;

		// Token: 0x04013869 RID: 79977
		[Token(Token = "0x4013869")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_m_roguelikeManager;

		// Token: 0x0401386A RID: 79978
		[Token(Token = "0x401386A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x0401386B RID: 79979
		[Token(Token = "0x401386B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401386C RID: 79980
		[Token(Token = "0x401386C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyAdditionsToAttribute;

		// Token: 0x0401386D RID: 79981
		[Token(Token = "0x401386D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyMultipliersToAttribute;

		// Token: 0x0401386E RID: 79982
		[Token(Token = "0x401386E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyFinalScalersToAttribute;

		// Token: 0x0401386F RID: 79983
		[Token(Token = "0x401386F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013870 RID: 79984
		[Token(Token = "0x4013870")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x04013871 RID: 79985
		[Token(Token = "0x4013871")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x04013872 RID: 79986
		[Token(Token = "0x4013872")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x04013873 RID: 79987
		[Token(Token = "0x4013873")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LatePreprocess;

		// Token: 0x04013874 RID: 79988
		[Token(Token = "0x4013874")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002925 RID: 10533
		[Token(Token = "0x2002925")]
		public enum RelicType
		{
			// Token: 0x04013876 RID: 79990
			[Token(Token = "0x4013876")]
			NONE,
			// Token: 0x04013877 RID: 79991
			[Token(Token = "0x4013877")]
			LEVEL_OPTIONS,
			// Token: 0x04013878 RID: 79992
			[Token(Token = "0x4013878")]
			CHARACTER,
			// Token: 0x04013879 RID: 79993
			[Token(Token = "0x4013879")]
			GLOBAL_BUFF = 4,
			// Token: 0x0401387A RID: 79994
			[Token(Token = "0x401387A")]
			ENEMY = 8,
			// Token: 0x0401387B RID: 79995
			[Token(Token = "0x401387B")]
			CARD = 16,
			// Token: 0x0401387C RID: 79996
			[Token(Token = "0x401387C")]
			LEVEL_PREDEFINE = 32,
			// Token: 0x0401387D RID: 79997
			[Token(Token = "0x401387D")]
			MISC = 64,
			// Token: 0x0401387E RID: 79998
			[Token(Token = "0x401387E")]
			ENV_SYSTEM = 128
		}

		// Token: 0x02002926 RID: 10534
		[Token(Token = "0x2002926")]
		public struct RelicInOut
		{
			// Token: 0x0401387F RID: 79999
			[Token(Token = "0x401387F")]
			[FieldOffset(Offset = "0x0")]
			public AttributesData attribute;

			// Token: 0x04013880 RID: 80000
			[Token(Token = "0x4013880")]
			[FieldOffset(Offset = "0x8")]
			public Character character;

			// Token: 0x04013881 RID: 80001
			[Token(Token = "0x4013881")]
			[FieldOffset(Offset = "0x10")]
			public LevelData.EnemyData enemyData;

			// Token: 0x04013882 RID: 80002
			[Token(Token = "0x4013882")]
			[FieldOffset(Offset = "0x18")]
			public List<LevelData.GlobalBuffData> globalBuffs;

			// Token: 0x04013883 RID: 80003
			[Token(Token = "0x4013883")]
			[FieldOffset(Offset = "0x20")]
			public LevelData.Options levelOptions;

			// Token: 0x04013884 RID: 80004
			[Token(Token = "0x4013884")]
			[FieldOffset(Offset = "0x28")]
			public Deck.Card card;

			// Token: 0x04013885 RID: 80005
			[Token(Token = "0x4013885")]
			[FieldOffset(Offset = "0x30")]
			public RelicLevelPredefinedData predefinedData;

			// Token: 0x04013886 RID: 80006
			[Token(Token = "0x4013886")]
			[FieldOffset(Offset = "0x38")]
			public List<GlobalEnvSystemData> envSystems;
		}

		// Token: 0x02002927 RID: 10535
		[Token(Token = "0x2002927")]
		public class RelicTargetSelector : IHotfixable
		{
			// Token: 0x170026A5 RID: 9893
			// (get) Token: 0x06011784 RID: 71556 RVA: 0x0006B748 File Offset: 0x00069948
			[Token(Token = "0x170026A5")]
			private bool hasExtraFilterForCharGlobalBuff
			{
				[Token(Token = "0x6011784")]
				[Address(RVA = "0x946070", Offset = "0x944C70", VA = "0x180946070")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170026A6 RID: 9894
			// (get) Token: 0x06011785 RID: 71557 RVA: 0x0006B760 File Offset: 0x00069960
			[Token(Token = "0x170026A6")]
			private bool hasExtraFilterForEnemyGlobalBuff
			{
				[Token(Token = "0x6011785")]
				[Address(RVA = "0x946120", Offset = "0x944D20", VA = "0x180946120")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06011786 RID: 71558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011786")]
			[Address(RVA = "0x945980", Offset = "0x944580", VA = "0x180945980")]
			public RelicTargetSelector(Blackboard blackboard)
			{
			}

			// Token: 0x06011787 RID: 71559 RVA: 0x0006B778 File Offset: 0x00069978
			[Token(Token = "0x6011787")]
			[Address(RVA = "0x945130", Offset = "0x943D30", VA = "0x180945130")]
			public bool Verify(BattleCharacterData data)
			{
				return default(bool);
			}

			// Token: 0x06011788 RID: 71560 RVA: 0x0006B790 File Offset: 0x00069990
			[Token(Token = "0x6011788")]
			[Address(RVA = "0x9458E0", Offset = "0x9444E0", VA = "0x1809458E0")]
			private bool _VerifyExtraProfession(BattleCharacterData data)
			{
				return default(bool);
			}

			// Token: 0x06011789 RID: 71561 RVA: 0x0006B7A8 File Offset: 0x000699A8
			[Token(Token = "0x6011789")]
			[Address(RVA = "0x9457C0", Offset = "0x9443C0", VA = "0x1809457C0")]
			public bool Verify(Character character)
			{
				return default(bool);
			}

			// Token: 0x0601178A RID: 71562 RVA: 0x0006B7C0 File Offset: 0x000699C0
			[Token(Token = "0x601178A")]
			[Address(RVA = "0x945850", Offset = "0x944450", VA = "0x180945850")]
			public bool Verify(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x0601178B RID: 71563 RVA: 0x0006B7D8 File Offset: 0x000699D8
			[Token(Token = "0x601178B")]
			[Address(RVA = "0x945340", Offset = "0x943F40", VA = "0x180945340")]
			public bool Verify(Unit unit, Blackboard blackboard)
			{
				return default(bool);
			}

			// Token: 0x0601178C RID: 71564 RVA: 0x0006B7F0 File Offset: 0x000699F0
			[Token(Token = "0x601178C")]
			[Address(RVA = "0x9450C0", Offset = "0x943CC0", VA = "0x1809450C0")]
			public bool VerifyProfession(ProfessionCategory profession)
			{
				return default(bool);
			}

			// Token: 0x0601178D RID: 71565 RVA: 0x0006B808 File Offset: 0x00069A08
			[Token(Token = "0x601178D")]
			[Address(RVA = "0x9455C0", Offset = "0x9441C0", VA = "0x1809455C0")]
			public bool Verify(LevelData.EnemyData enemyData)
			{
				return default(bool);
			}

			// Token: 0x0601178E RID: 71566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601178E")]
			[Address(RVA = "0x944E40", Offset = "0x943A40", VA = "0x180944E40")]
			public void PreprocessGlobalBuffData(LevelData.GlobalBuffData globalBuffData)
			{
			}

			// Token: 0x04013887 RID: 80007
			[Token(Token = "0x4013887")]
			private const string SELECTOR_PREFIX = "selector.";

			// Token: 0x04013888 RID: 80008
			[Token(Token = "0x4013888")]
			private const string BOSS_OPTION_KEY = "boss_option";

			// Token: 0x04013889 RID: 80009
			[Token(Token = "0x4013889")]
			private const string BOSS_ONLY_KEY = "boss";

			// Token: 0x0401388A RID: 80010
			[Token(Token = "0x401388A")]
			public const string BOSS_EXCLUDE_KEY = "not_boss";

			// Token: 0x0401388B RID: 80011
			[Token(Token = "0x401388B")]
			[FieldOffset(Offset = "0x10")]
			private ProfessionCategory m_professionCategory;

			// Token: 0x0401388C RID: 80012
			[Token(Token = "0x401388C")]
			[FieldOffset(Offset = "0x18")]
			private List<string> m_subProfessions;

			// Token: 0x0401388D RID: 80013
			[Token(Token = "0x401388D")]
			[FieldOffset(Offset = "0x20")]
			private BuildableType m_buildableMask;

			// Token: 0x0401388E RID: 80014
			[Token(Token = "0x401388E")]
			[FieldOffset(Offset = "0x24")]
			private RarityRankMask m_rarityRankMask;

			// Token: 0x0401388F RID: 80015
			[Token(Token = "0x401388F")]
			[FieldOffset(Offset = "0x28")]
			private List<string> m_charIds;

			// Token: 0x04013890 RID: 80016
			[Token(Token = "0x4013890")]
			[FieldOffset(Offset = "0x30")]
			private BasicRelic.RelicTargetSelector.BossFilterOption m_bossOption;

			// Token: 0x04013891 RID: 80017
			[Token(Token = "0x4013891")]
			[FieldOffset(Offset = "0x38")]
			private List<string> m_enemyTags;

			// Token: 0x04013892 RID: 80018
			[Token(Token = "0x4013892")]
			[FieldOffset(Offset = "0x40")]
			private List<string> m_enemyIds;

			// Token: 0x04013893 RID: 80019
			[Token(Token = "0x4013893")]
			[FieldOffset(Offset = "0x48")]
			private List<string> m_enemyExcludeIds;

			// Token: 0x04013894 RID: 80020
			[Token(Token = "0x4013894")]
			[FieldOffset(Offset = "0x50")]
			private EnemyLevelMask m_enemyLevelMask;

			// Token: 0x04013895 RID: 80021
			[Token(Token = "0x4013895")]
			[FieldOffset(Offset = "0x54")]
			private SideType m_sideType;

			// Token: 0x04013896 RID: 80022
			[Token(Token = "0x4013896")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hasExtraFilterForCharGlobalBuff;

			// Token: 0x04013897 RID: 80023
			[Token(Token = "0x4013897")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_hasExtraFilterForEnemyGlobalBuff;

			// Token: 0x04013898 RID: 80024
			[Token(Token = "0x4013898")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04013899 RID: 80025
			[Token(Token = "0x4013899")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Verify;

			// Token: 0x0401389A RID: 80026
			[Token(Token = "0x401389A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__VerifyExtraProfession;

			// Token: 0x0401389B RID: 80027
			[Token(Token = "0x401389B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix1_Verify;

			// Token: 0x0401389C RID: 80028
			[Token(Token = "0x401389C")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix2_Verify;

			// Token: 0x0401389D RID: 80029
			[Token(Token = "0x401389D")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix3_Verify;

			// Token: 0x0401389E RID: 80030
			[Token(Token = "0x401389E")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_VerifyProfession;

			// Token: 0x0401389F RID: 80031
			[Token(Token = "0x401389F")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix4_Verify;

			// Token: 0x040138A0 RID: 80032
			[Token(Token = "0x40138A0")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_PreprocessGlobalBuffData;

			// Token: 0x02002928 RID: 10536
			[Token(Token = "0x2002928")]
			private enum BossFilterOption
			{
				// Token: 0x040138A2 RID: 80034
				[Token(Token = "0x40138A2")]
				ALL,
				// Token: 0x040138A3 RID: 80035
				[Token(Token = "0x40138A3")]
				BOSS_ONLY,
				// Token: 0x040138A4 RID: 80036
				[Token(Token = "0x40138A4")]
				BOSS_EXCLUDE
			}
		}
	}
}
