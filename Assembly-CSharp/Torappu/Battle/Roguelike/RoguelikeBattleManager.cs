using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200291F RID: 10527
	[Token(Token = "0x200291F")]
	public class RoguelikeBattleManager : IHotfixable
	{
		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x06011735 RID: 71477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002692")]
		public FP[] attributeAdditons
		{
			[Token(Token = "0x6011735")]
			[Address(RVA = "0x94B9F0", Offset = "0x94A5F0", VA = "0x18094B9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x06011736 RID: 71478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002693")]
		public FP[] attributeMultipliers
		{
			[Token(Token = "0x6011736")]
			[Address(RVA = "0x94BAF0", Offset = "0x94A6F0", VA = "0x18094BAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x06011737 RID: 71479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002694")]
		public FP[] attributeFinalScalers
		{
			[Token(Token = "0x6011737")]
			[Address(RVA = "0x94BA70", Offset = "0x94A670", VA = "0x18094BA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x06011738 RID: 71480 RVA: 0x0006B550 File Offset: 0x00069750
		// (set) Token: 0x06011739 RID: 71481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002695")]
		public FP lifePointModifierScale
		{
			[Token(Token = "0x6011738")]
			[Address(RVA = "0x94C040", Offset = "0x94AC40", VA = "0x18094C040")]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x6011739")]
			[Address(RVA = "0x94C1C0", Offset = "0x94ADC0", VA = "0x18094C1C0")]
			set
			{
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0601173A RID: 71482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002696")]
		public List<string> enabledHiddenGroups
		{
			[Token(Token = "0x601173A")]
			[Address(RVA = "0x94BDB0", Offset = "0x94A9B0", VA = "0x18094BDB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0601173B RID: 71483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002697")]
		public List<string> disabledHiddenGroups
		{
			[Token(Token = "0x601173B")]
			[Address(RVA = "0x94BCE0", Offset = "0x94A8E0", VA = "0x18094BCE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x0601173C RID: 71484 RVA: 0x0006B568 File Offset: 0x00069768
		[Token(Token = "0x17002698")]
		public bool isBattleSnapshotEmpty
		{
			[Token(Token = "0x601173C")]
			[Address(RVA = "0x94BEF0", Offset = "0x94AAF0", VA = "0x18094BEF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x0601173D RID: 71485 RVA: 0x0006B580 File Offset: 0x00069780
		[Token(Token = "0x17002699")]
		public RoguelikeBattleSnapshot battleSnapshot
		{
			[Token(Token = "0x601173D")]
			[Address(RVA = "0x94BBF0", Offset = "0x94A7F0", VA = "0x18094BBF0")]
			get
			{
				return default(RoguelikeBattleSnapshot);
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0601173E RID: 71486 RVA: 0x0006B598 File Offset: 0x00069798
		[Token(Token = "0x1700269A")]
		public int characterInCandleHolderCnt
		{
			[Token(Token = "0x601173E")]
			[Address(RVA = "0x94BC70", Offset = "0x94A870", VA = "0x18094BC70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0601173F RID: 71487 RVA: 0x0006B5B0 File Offset: 0x000697B0
		[Token(Token = "0x1700269B")]
		public int gold
		{
			[Token(Token = "0x601173F")]
			[Address(RVA = "0x94BE80", Offset = "0x94AA80", VA = "0x18094BE80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x06011740 RID: 71488 RVA: 0x0006B5C8 File Offset: 0x000697C8
		[Token(Token = "0x1700269C")]
		public int remainPopulation
		{
			[Token(Token = "0x6011740")]
			[Address(RVA = "0x94C140", Offset = "0x94AD40", VA = "0x18094C140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x06011741 RID: 71489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700269D")]
		public BattlePlayerData battlePlayerData
		{
			[Token(Token = "0x6011741")]
			[Address(RVA = "0x94BB70", Offset = "0x94A770", VA = "0x18094BB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x06011742 RID: 71490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700269E")]
		public LevelData levelData
		{
			[Token(Token = "0x6011742")]
			[Address(RVA = "0x94BFC0", Offset = "0x94ABC0", VA = "0x18094BFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x06011743 RID: 71491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700269F")]
		public IEnumerable<BasicRelic> relics
		{
			[Token(Token = "0x6011743")]
			[Address(RVA = "0x94C0C0", Offset = "0x94ACC0", VA = "0x18094C0C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011744 RID: 71492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011744")]
		[Address(RVA = "0x94B6D0", Offset = "0x94A2D0", VA = "0x18094B6D0")]
		public RoguelikeBattleManager()
		{
		}

		// Token: 0x06011745 RID: 71493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011745")]
		[Address(RVA = "0x9478B0", Offset = "0x9464B0", VA = "0x1809478B0")]
		public void Init(RoguelikeInput input, BattlePlayerData playerData, LevelData levelData, RoguelikeOutput output)
		{
		}

		// Token: 0x06011746 RID: 71494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011746")]
		[Address(RVA = "0x94A800", Offset = "0x949400", VA = "0x18094A800")]
		private void _RegisterRelicClasses()
		{
		}

		// Token: 0x06011747 RID: 71495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011747")]
		private void _Register<T>(string key) where T : BasicRelic
		{
		}

		// Token: 0x06011748 RID: 71496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011748")]
		[Address(RVA = "0x949FF0", Offset = "0x948BF0", VA = "0x180949FF0")]
		private BasicRelic _CreateInternal(RoguelikeBuff data, int stackLayer = 1)
		{
			return null;
		}

		// Token: 0x06011749 RID: 71497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011749")]
		[Address(RVA = "0x94A1F0", Offset = "0x948DF0", VA = "0x18094A1F0")]
		private void _CreateRelic(RoguelikeBuff data, int stackLayer = 1)
		{
		}

		// Token: 0x0601174A RID: 71498 RVA: 0x0006B5E0 File Offset: 0x000697E0
		[Token(Token = "0x601174A")]
		[Address(RVA = "0x94B240", Offset = "0x949E40", VA = "0x18094B240")]
		private int _TryRecalculateStackLayerInBattle(RoguelikeBuff data, int stackLayer)
		{
			return 0;
		}

		// Token: 0x0601174B RID: 71499 RVA: 0x0006B5F8 File Offset: 0x000697F8
		[Token(Token = "0x601174B")]
		[Address(RVA = "0x946ED0", Offset = "0x945AD0", VA = "0x180946ED0")]
		protected bool CheckExtraCondition(Blackboard blackboard, out bool checkSatisfied)
		{
			return default(bool);
		}

		// Token: 0x0601174C RID: 71500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601174C")]
		[Address(RVA = "0x949E50", Offset = "0x948A50", VA = "0x180949E50")]
		private void _CreateCharBuff(RoguelikeGameCharBuffBattleData charBuffData)
		{
		}

		// Token: 0x0601174D RID: 71501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601174D")]
		[Address(RVA = "0x949650", Offset = "0x948250", VA = "0x180949650")]
		private void _ApplyFinalAttributes(AttributesData attributes)
		{
		}

		// Token: 0x0601174E RID: 71502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601174E")]
		[Address(RVA = "0x949990", Offset = "0x948590", VA = "0x180949990")]
		private void _ClearAttributeCache()
		{
		}

		// Token: 0x0601174F RID: 71503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601174F")]
		[Address(RVA = "0x9485A0", Offset = "0x9471A0", VA = "0x1809485A0")]
		public void PreProcessCharacter(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011750 RID: 71504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011750")]
		[Address(RVA = "0x948780", Offset = "0x947380", VA = "0x180948780")]
		public void PreprocessDeckCard(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011751 RID: 71505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011751")]
		[Address(RVA = "0x948940", Offset = "0x947540", VA = "0x180948940")]
		public void PreprocessEnemy(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011752 RID: 71506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011752")]
		[Address(RVA = "0x948CE0", Offset = "0x9478E0", VA = "0x180948CE0")]
		public List<LevelData.GlobalBuffData> PreprocessGlobalBuff()
		{
			return null;
		}

		// Token: 0x06011753 RID: 71507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011753")]
		[Address(RVA = "0x948A90", Offset = "0x947690", VA = "0x180948A90")]
		public List<GlobalEnvSystemData> PreprocessEnvSystems()
		{
			return null;
		}

		// Token: 0x06011754 RID: 71508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011754")]
		[Address(RVA = "0x948F30", Offset = "0x947B30", VA = "0x180948F30")]
		public LevelData.Options PreprocessLevelOptions(LevelData.Options originOptions, int hp, int shield)
		{
			return null;
		}

		// Token: 0x06011755 RID: 71509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011755")]
		[Address(RVA = "0x949180", Offset = "0x947D80", VA = "0x180949180")]
		public LevelData.PredefinedData PreprocessLevelPredefines(LevelData.PredefinedData predefinedData)
		{
			return null;
		}

		// Token: 0x06011756 RID: 71510 RVA: 0x0006B610 File Offset: 0x00069810
		[Token(Token = "0x6011756")]
		[Address(RVA = "0x9471E0", Offset = "0x945DE0", VA = "0x1809471E0")]
		public bool ContainsCharacterRelic()
		{
			return default(bool);
		}

		// Token: 0x06011757 RID: 71511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011757")]
		[Address(RVA = "0x9483B0", Offset = "0x946FB0", VA = "0x1809483B0")]
		public void OnApplyingGlobalModifier(ref Modifier modifier)
		{
		}

		// Token: 0x06011758 RID: 71512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011758")]
		[Address(RVA = "0x94A5F0", Offset = "0x9491F0", VA = "0x18094A5F0")]
		private void _OnModifyLifePoint(ref Modifier modifier)
		{
		}

		// Token: 0x06011759 RID: 71513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011759")]
		[Address(RVA = "0x949AD0", Offset = "0x9486D0", VA = "0x180949AD0")]
		private void _CollectCharacterInCandleHolder()
		{
		}

		// Token: 0x0601175A RID: 71514 RVA: 0x0006B628 File Offset: 0x00069828
		[Token(Token = "0x601175A")]
		[Address(RVA = "0x947780", Offset = "0x946380", VA = "0x180947780")]
		public bool FilterCharacterInCandleHolder(string id, uint uid)
		{
			return default(bool);
		}

		// Token: 0x0601175B RID: 71515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601175B")]
		[Address(RVA = "0x94A750", Offset = "0x949350", VA = "0x18094A750")]
		private void _ParseBattleSnapshot(string battleSnapshotStr)
		{
		}

		// Token: 0x0601175C RID: 71516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601175C")]
		[Address(RVA = "0x947320", Offset = "0x945F20", VA = "0x180947320")]
		public void FetchGameOverBattleSnapshot()
		{
		}

		// Token: 0x0601175D RID: 71517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601175D")]
		[Address(RVA = "0x9494D0", Offset = "0x9480D0", VA = "0x1809494D0")]
		public void RecordFinishedEnemy(Enemy enemy, Entity.FinishReason reason)
		{
		}

		// Token: 0x040137E7 RID: 79847
		[Token(Token = "0x40137E7")]
		public const string RELIC_DYNAMIC_ABILITY_KEY = "char_ability_new";

		// Token: 0x040137E8 RID: 79848
		[Token(Token = "0x40137E8")]
		public const string ENEMY_RELIC_DYNAMIC_ABILITY_KEY = "enemy_ability_new";

		// Token: 0x040137E9 RID: 79849
		[Token(Token = "0x40137E9")]
		public const string RELIC_INSERT_TOKEN_KEY = "misc_insert_token_card";

		// Token: 0x040137EA RID: 79850
		[Token(Token = "0x40137EA")]
		public const string RELIC_RANDOM_INSERT_TOKEN_KEY = "misc_random_insert_token_card";

		// Token: 0x040137EB RID: 79851
		[Token(Token = "0x40137EB")]
		public const string RELIC_INSERT_TOKEN_INST = "level_insert_token_inst";

		// Token: 0x040137EC RID: 79852
		[Token(Token = "0x40137EC")]
		public const string RELIC_DYNAMIC_ABILITY_KEY_AT_ROOT = "char_ability_new_at_root";

		// Token: 0x040137ED RID: 79853
		[Token(Token = "0x40137ED")]
		public const string RELIC_CHAR_SHARED_DATA = "char_shared_data";

		// Token: 0x040137EE RID: 79854
		[Token(Token = "0x40137EE")]
		public const string RELIC_BUFF_STACK_RES_KEY = "stack_by_res";

		// Token: 0x040137EF RID: 79855
		[Token(Token = "0x40137EF")]
		public const string RELIC_BUFF_STACK_RES_CNT_KEY = "stack_by_res_cnt";

		// Token: 0x040137F0 RID: 79856
		[Token(Token = "0x40137F0")]
		public const string RELIC_BUFF_RELIANCE_RELICS = "reliance_relics";

		// Token: 0x040137F1 RID: 79857
		[Token(Token = "0x40137F1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string RELIC_LEVEL_HIDDEN_GROUP_ENABLE;

		// Token: 0x040137F2 RID: 79858
		[Token(Token = "0x40137F2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string RELIC_LEVEL_HIDDEN_GROUP_DISABLE;

		// Token: 0x040137F3 RID: 79859
		[Token(Token = "0x40137F3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string ROGUE_SPECIAL_FRAGMENT;

		// Token: 0x040137F4 RID: 79860
		[Token(Token = "0x40137F4")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string RELIC_MISC_ADD_ENV_SYSTEM;

		// Token: 0x040137F5 RID: 79861
		[Token(Token = "0x40137F5")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string RELIC_GLOBAL_BUFF_NORMAL;

		// Token: 0x040137F6 RID: 79862
		[Token(Token = "0x40137F6")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string RELIC_GLOBAL_BUFF_STACK;

		// Token: 0x040137F7 RID: 79863
		[Token(Token = "0x40137F7")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string RELIC_GLOBAL_BUFF_STACK_BASE_ONE;

		// Token: 0x040137F8 RID: 79864
		[Token(Token = "0x40137F8")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string RELIC_GLOBAL_BUFF_LAYER;

		// Token: 0x040137F9 RID: 79865
		[Token(Token = "0x40137F9")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string ROGUELIKE_CHARACTER_IN_CANDLE;

		// Token: 0x040137FA RID: 79866
		[Token(Token = "0x40137FA")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Type> m_relicClasses;

		// Token: 0x040137FB RID: 79867
		[Token(Token = "0x40137FB")]
		[FieldOffset(Offset = "0x18")]
		private RoguelikeBattleSnapshot m_battleSnapshotInput;

		// Token: 0x040137FC RID: 79868
		[Token(Token = "0x40137FC")]
		[FieldOffset(Offset = "0x20")]
		private RoguelikeBattleSnapshot m_battleSnapshotOutput;

		// Token: 0x040137FD RID: 79869
		[Token(Token = "0x40137FD")]
		[FieldOffset(Offset = "0x28")]
		private List<BasicRelic> m_relics;

		// Token: 0x040137FE RID: 79870
		[Token(Token = "0x40137FE")]
		[FieldOffset(Offset = "0x30")]
		private List<BasicCharBuff> m_charBuffs;

		// Token: 0x040137FF RID: 79871
		[Token(Token = "0x40137FF")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_enabledHiddenGroups;

		// Token: 0x04013800 RID: 79872
		[Token(Token = "0x4013800")]
		[FieldOffset(Offset = "0x40")]
		private List<string> m_disabledHiddenGroups;

		// Token: 0x04013801 RID: 79873
		[Token(Token = "0x4013801")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<LevelData.ActionID, int> m_killedEnemies;

		// Token: 0x04013802 RID: 79874
		[Token(Token = "0x4013802")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, int> m_hasCandleHolderBuffCharDict;

		// Token: 0x04013803 RID: 79875
		[Token(Token = "0x4013803")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, List<uint>> m_inCandleHolderCharList;

		// Token: 0x04013804 RID: 79876
		[Token(Token = "0x4013804")]
		[FieldOffset(Offset = "0x60")]
		private int m_characterInCandleHolderCnt;

		// Token: 0x04013805 RID: 79877
		[Token(Token = "0x4013805")]
		[FieldOffset(Offset = "0x68")]
		private string m_goldKey;

		// Token: 0x04013806 RID: 79878
		[Token(Token = "0x4013806")]
		[FieldOffset(Offset = "0x70")]
		private string m_shieldKey;

		// Token: 0x04013807 RID: 79879
		[Token(Token = "0x4013807")]
		[FieldOffset(Offset = "0x78")]
		private int m_gold;

		// Token: 0x04013808 RID: 79880
		[Token(Token = "0x4013808")]
		[FieldOffset(Offset = "0x7C")]
		private int m_shield;

		// Token: 0x04013809 RID: 79881
		[Token(Token = "0x4013809")]
		[FieldOffset(Offset = "0x80")]
		private int m_remainPopulation;

		// Token: 0x0401380A RID: 79882
		[Token(Token = "0x401380A")]
		[FieldOffset(Offset = "0x88")]
		private string m_fragmentKey;

		// Token: 0x0401380B RID: 79883
		[Token(Token = "0x401380B")]
		[FieldOffset(Offset = "0x90")]
		private int m_fragment;

		// Token: 0x0401380C RID: 79884
		[Token(Token = "0x401380C")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeInput m_input;

		// Token: 0x0401380D RID: 79885
		[Token(Token = "0x401380D")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeOutput m_output;

		// Token: 0x0401380E RID: 79886
		[Token(Token = "0x401380E")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeBattleManager.RoguelikeRelicValidator m_validator;

		// Token: 0x0401380F RID: 79887
		[Token(Token = "0x401380F")]
		[FieldOffset(Offset = "0xB0")]
		private FP[] m_attributeAdditions;

		// Token: 0x04013810 RID: 79888
		[Token(Token = "0x4013810")]
		[FieldOffset(Offset = "0xB8")]
		private FP[] m_attributeMultipliers;

		// Token: 0x04013811 RID: 79889
		[Token(Token = "0x4013811")]
		[FieldOffset(Offset = "0xC0")]
		private FP[] m_attributeFinalScalers;

		// Token: 0x04013812 RID: 79890
		[Token(Token = "0x4013812")]
		[FieldOffset(Offset = "0xC8")]
		private FP m_lifePointModifierScale;

		// Token: 0x04013813 RID: 79891
		[Token(Token = "0x4013813")]
		[FieldOffset(Offset = "0xD0")]
		private BattlePlayerData m_playerData;

		// Token: 0x04013814 RID: 79892
		[Token(Token = "0x4013814")]
		[FieldOffset(Offset = "0xD8")]
		private LevelData m_levelData;

		// Token: 0x04013815 RID: 79893
		[Token(Token = "0x4013815")]
		private const string CONDITIONKEY = "condition_key";

		// Token: 0x04013816 RID: 79894
		[Token(Token = "0x4013816")]
		private const string CONDITIONVALUE = "condition_value";

		// Token: 0x04013817 RID: 79895
		[Token(Token = "0x4013817")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_attributeAdditons;

		// Token: 0x04013818 RID: 79896
		[Token(Token = "0x4013818")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_attributeMultipliers;

		// Token: 0x04013819 RID: 79897
		[Token(Token = "0x4013819")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_attributeFinalScalers;

		// Token: 0x0401381A RID: 79898
		[Token(Token = "0x401381A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_lifePointModifierScale;

		// Token: 0x0401381B RID: 79899
		[Token(Token = "0x401381B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_lifePointModifierScale;

		// Token: 0x0401381C RID: 79900
		[Token(Token = "0x401381C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_enabledHiddenGroups;

		// Token: 0x0401381D RID: 79901
		[Token(Token = "0x401381D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_disabledHiddenGroups;

		// Token: 0x0401381E RID: 79902
		[Token(Token = "0x401381E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isBattleSnapshotEmpty;

		// Token: 0x0401381F RID: 79903
		[Token(Token = "0x401381F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_battleSnapshot;

		// Token: 0x04013820 RID: 79904
		[Token(Token = "0x4013820")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_characterInCandleHolderCnt;

		// Token: 0x04013821 RID: 79905
		[Token(Token = "0x4013821")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_gold;

		// Token: 0x04013822 RID: 79906
		[Token(Token = "0x4013822")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_remainPopulation;

		// Token: 0x04013823 RID: 79907
		[Token(Token = "0x4013823")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_battlePlayerData;

		// Token: 0x04013824 RID: 79908
		[Token(Token = "0x4013824")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_levelData;

		// Token: 0x04013825 RID: 79909
		[Token(Token = "0x4013825")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_relics;

		// Token: 0x04013826 RID: 79910
		[Token(Token = "0x4013826")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013827 RID: 79911
		[Token(Token = "0x4013827")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013828 RID: 79912
		[Token(Token = "0x4013828")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RegisterRelicClasses;

		// Token: 0x04013829 RID: 79913
		[Token(Token = "0x4013829")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__Register;

		// Token: 0x0401382A RID: 79914
		[Token(Token = "0x401382A")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CreateInternal;

		// Token: 0x0401382B RID: 79915
		[Token(Token = "0x401382B")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CreateRelic;

		// Token: 0x0401382C RID: 79916
		[Token(Token = "0x401382C")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TryRecalculateStackLayerInBattle;

		// Token: 0x0401382D RID: 79917
		[Token(Token = "0x401382D")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckExtraCondition;

		// Token: 0x0401382E RID: 79918
		[Token(Token = "0x401382E")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CreateCharBuff;

		// Token: 0x0401382F RID: 79919
		[Token(Token = "0x401382F")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ApplyFinalAttributes;

		// Token: 0x04013830 RID: 79920
		[Token(Token = "0x4013830")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__ClearAttributeCache;

		// Token: 0x04013831 RID: 79921
		[Token(Token = "0x4013831")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_PreProcessCharacter;

		// Token: 0x04013832 RID: 79922
		[Token(Token = "0x4013832")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_PreprocessDeckCard;

		// Token: 0x04013833 RID: 79923
		[Token(Token = "0x4013833")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x04013834 RID: 79924
		[Token(Token = "0x4013834")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_PreprocessGlobalBuff;

		// Token: 0x04013835 RID: 79925
		[Token(Token = "0x4013835")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_PreprocessEnvSystems;

		// Token: 0x04013836 RID: 79926
		[Token(Token = "0x4013836")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x04013837 RID: 79927
		[Token(Token = "0x4013837")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_PreprocessLevelPredefines;

		// Token: 0x04013838 RID: 79928
		[Token(Token = "0x4013838")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ContainsCharacterRelic;

		// Token: 0x04013839 RID: 79929
		[Token(Token = "0x4013839")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OnApplyingGlobalModifier;

		// Token: 0x0401383A RID: 79930
		[Token(Token = "0x401383A")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__OnModifyLifePoint;

		// Token: 0x0401383B RID: 79931
		[Token(Token = "0x401383B")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__CollectCharacterInCandleHolder;

		// Token: 0x0401383C RID: 79932
		[Token(Token = "0x401383C")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_FilterCharacterInCandleHolder;

		// Token: 0x0401383D RID: 79933
		[Token(Token = "0x401383D")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__ParseBattleSnapshot;

		// Token: 0x0401383E RID: 79934
		[Token(Token = "0x401383E")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_FetchGameOverBattleSnapshot;

		// Token: 0x0401383F RID: 79935
		[Token(Token = "0x401383F")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_RecordFinishedEnemy;

		// Token: 0x02002920 RID: 10528
		[Token(Token = "0x2002920")]
		public class RoguelikeRelicValidator
		{
			// Token: 0x0601175F RID: 71519 RVA: 0x0006B640 File Offset: 0x00069840
			[Token(Token = "0x601175F")]
			[Address(RVA = "0x94D5E0", Offset = "0x94C1E0", VA = "0x18094D5E0")]
			public bool Verify(RoguelikeBuff data, RoguelikeInput inout)
			{
				return default(bool);
			}

			// Token: 0x06011760 RID: 71520 RVA: 0x0006B658 File Offset: 0x00069858
			[Token(Token = "0x6011760")]
			[Address(RVA = "0x94D750", Offset = "0x94C350", VA = "0x18094D750")]
			private bool _ValidateEventType(RoguelikeBuff data, RoguelikeInput input)
			{
				return default(bool);
			}

			// Token: 0x06011761 RID: 71521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011761")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoguelikeRelicValidator()
			{
			}

			// Token: 0x04013840 RID: 79936
			[Token(Token = "0x4013840")]
			private const string VALIDATION_PREFIX = "validator.";

			// Token: 0x04013841 RID: 79937
			[Token(Token = "0x4013841")]
			private const string ROGUELIKE_EVENTTYPE = "roguelike_event_type";

			// Token: 0x04013842 RID: 79938
			[Token(Token = "0x4013842")]
			private const string ROGUELIKE_SKY_ZONE_EVENTTYPE = "roguelike_sky_zone_event_type";
		}

		// Token: 0x02002921 RID: 10529
		[Token(Token = "0x2002921")]
		private enum ConditionType
		{
			// Token: 0x04013844 RID: 79940
			[Token(Token = "0x4013844")]
			OVERWEIGHT,
			// Token: 0x04013845 RID: 79941
			[Token(Token = "0x4013845")]
			FULLSTOMACH
		}
	}
}
