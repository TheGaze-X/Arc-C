using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200274F RID: 10063
	[Token(Token = "0x200274F")]
	public class AutoChessGarrisonManager : IHotfixable
	{
		// Token: 0x06010640 RID: 67136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010640")]
		[Address(RVA = "0x81BE50", Offset = "0x81AA50", VA = "0x18081BE50")]
		private void _RegisterBondIdExecuters(string key, Func<AutoChessGarrisonManager.TriggerSnapShot, bool> getter)
		{
		}

		// Token: 0x06010641 RID: 67137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010641")]
		[Address(RVA = "0x81BF00", Offset = "0x81AB00", VA = "0x18081BF00")]
		private void _RegisterBondIdExecuters(string key, Action<AutoChessGarrisonManager.TriggerSnapShot, List<string>> getter)
		{
		}

		// Token: 0x06010642 RID: 67138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010642")]
		[Address(RVA = "0x81BDA0", Offset = "0x81A9A0", VA = "0x18081BDA0")]
		private void _RegisterBondAddCountExecuters(string key, Func<AutoChessGarrisonManager.TriggerSnapShot, int> getter)
		{
		}

		// Token: 0x06010643 RID: 67139 RVA: 0x00063E28 File Offset: 0x00062028
		[Token(Token = "0x6010643")]
		[Address(RVA = "0x819360", Offset = "0x817F60", VA = "0x180819360")]
		private bool _BondCheckCharacterSameRow(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return default(bool);
		}

		// Token: 0x06010644 RID: 67140 RVA: 0x00063E40 File Offset: 0x00062040
		[Token(Token = "0x6010644")]
		[Address(RVA = "0x8191E0", Offset = "0x817DE0", VA = "0x1808191E0")]
		private bool _BondCheckCharacterSameCol(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return default(bool);
		}

		// Token: 0x06010645 RID: 67141 RVA: 0x00063E58 File Offset: 0x00062058
		[Token(Token = "0x6010645")]
		[Address(RVA = "0x819020", Offset = "0x817C20", VA = "0x180819020")]
		private bool _BondCheckCharacterSameColOrRow(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return default(bool);
		}

		// Token: 0x06010646 RID: 67142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010646")]
		[Address(RVA = "0x81B250", Offset = "0x819E50", VA = "0x18081B250")]
		private void _GetBondIdsById(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x06010647 RID: 67143 RVA: 0x00063E70 File Offset: 0x00062070
		[Token(Token = "0x6010647")]
		[Address(RVA = "0x819B70", Offset = "0x818770", VA = "0x180819B70")]
		private bool _BondCheckTargetCharacterInHand(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return default(bool);
		}

		// Token: 0x06010648 RID: 67144 RVA: 0x00063E88 File Offset: 0x00062088
		[Token(Token = "0x6010648")]
		[Address(RVA = "0x8194E0", Offset = "0x8180E0", VA = "0x1808194E0")]
		private bool _BondCheckSpecifiedBondCharacterInHand(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return default(bool);
		}

		// Token: 0x06010649 RID: 67145 RVA: 0x00063EA0 File Offset: 0x000620A0
		[Token(Token = "0x6010649")]
		[Address(RVA = "0x819810", Offset = "0x818410", VA = "0x180819810")]
		private bool _BondCheckSpecifiedProfessionInHand(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return default(bool);
		}

		// Token: 0x0601064A RID: 67146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601064A")]
		[Address(RVA = "0x81B8A0", Offset = "0x81A4A0", VA = "0x18081B8A0")]
		private void _GetBondIdsSelf(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x0601064B RID: 67147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601064B")]
		[Address(RVA = "0x81B650", Offset = "0x81A250", VA = "0x18081B650")]
		private void _GetBondIdsSelfAndInfront(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x0601064C RID: 67148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601064C")]
		[Address(RVA = "0x81B3D0", Offset = "0x819FD0", VA = "0x18081B3D0")]
		private void _GetBondIdsSelfAndBehind(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x0601064D RID: 67149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601064D")]
		[Address(RVA = "0x81AF70", Offset = "0x819B70", VA = "0x18081AF70")]
		private void _GetBondIdsAllInfront(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x0601064E RID: 67150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601064E")]
		[Address(RVA = "0x81B150", Offset = "0x819D50", VA = "0x18081B150")]
		private void _GetBondIdsAllInhand(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x0601064F RID: 67151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601064F")]
		[Address(RVA = "0x81A900", Offset = "0x819500", VA = "0x18081A900")]
		private void _GetBondIdsActivedMaxStack(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x06010650 RID: 67152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010650")]
		[Address(RVA = "0x81ACD0", Offset = "0x8198D0", VA = "0x18081ACD0")]
		private void _GetBondIdsActivedRandomN(AutoChessGarrisonManager.TriggerSnapShot snapShot, List<string> names)
		{
		}

		// Token: 0x06010651 RID: 67153 RVA: 0x00063EB8 File Offset: 0x000620B8
		[Token(Token = "0x6010651")]
		[Address(RVA = "0x819D40", Offset = "0x818940", VA = "0x180819D40")]
		private int _GetBondAddCountByBB(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return 0;
		}

		// Token: 0x06010652 RID: 67154 RVA: 0x00063ED0 File Offset: 0x000620D0
		[Token(Token = "0x6010652")]
		[Address(RVA = "0x81A430", Offset = "0x819030", VA = "0x18081A430")]
		private int _GetBondAddCountByCharLevel(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return 0;
		}

		// Token: 0x06010653 RID: 67155 RVA: 0x00063EE8 File Offset: 0x000620E8
		[Token(Token = "0x6010653")]
		[Address(RVA = "0x81A800", Offset = "0x819400", VA = "0x18081A800")]
		private int _GetBondAddCountByShopLevel(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return 0;
		}

		// Token: 0x06010654 RID: 67156 RVA: 0x00063F00 File Offset: 0x00062100
		[Token(Token = "0x6010654")]
		[Address(RVA = "0x81A0C0", Offset = "0x818CC0", VA = "0x18081A0C0")]
		private int _GetBondAddCountByCharCountSameRow(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return 0;
		}

		// Token: 0x06010655 RID: 67157 RVA: 0x00063F18 File Offset: 0x00062118
		[Token(Token = "0x6010655")]
		[Address(RVA = "0x819F90", Offset = "0x818B90", VA = "0x180819F90")]
		private int _GetBondAddCountByCharCountSameCol(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return 0;
		}

		// Token: 0x06010656 RID: 67158 RVA: 0x00063F30 File Offset: 0x00062130
		[Token(Token = "0x6010656")]
		[Address(RVA = "0x819E70", Offset = "0x818A70", VA = "0x180819E70")]
		private int _GetBondAddCountByCharCountInBattle(AutoChessGarrisonManager.TriggerSnapShot snapShot)
		{
			return 0;
		}

		// Token: 0x06010657 RID: 67159 RVA: 0x00063F48 File Offset: 0x00062148
		[Token(Token = "0x6010657")]
		[Address(RVA = "0x81A1F0", Offset = "0x818DF0", VA = "0x18081A1F0")]
		private int _GetBondAddCountByCharGained(AutoChessGarrisonManager.TriggerSnapShot triggerSnapShot)
		{
			return 0;
		}

		// Token: 0x06010658 RID: 67160 RVA: 0x00063F60 File Offset: 0x00062160
		[Token(Token = "0x6010658")]
		[Address(RVA = "0x81A540", Offset = "0x819140", VA = "0x18081A540")]
		private int _GetBondAddCountByChessGained(AutoChessGarrisonManager.TriggerSnapShot triggerSnapShot)
		{
			return 0;
		}

		// Token: 0x06010659 RID: 67161 RVA: 0x00063F78 File Offset: 0x00062178
		[Token(Token = "0x6010659")]
		[Address(RVA = "0x81A6B0", Offset = "0x8192B0", VA = "0x18081A6B0")]
		private int _GetBondAddCountByGoldSpend(AutoChessGarrisonManager.TriggerSnapShot triggerSnapShot)
		{
			return 0;
		}

		// Token: 0x0601065A RID: 67162 RVA: 0x00063F90 File Offset: 0x00062190
		[Token(Token = "0x601065A")]
		[Address(RVA = "0x81BA30", Offset = "0x81A630", VA = "0x18081BA30")]
		private int _GetDifferentChessLevelCntFilterBond(AutoChessGarrisonManager.TriggerSnapShot triggerSnapShot)
		{
			return 0;
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x0601065B RID: 67163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023D8")]
		private AutoChessPlayerDataModel.ScenePlayerData dataModel
		{
			[Token(Token = "0x601065B")]
			[Address(RVA = "0x81D480", Offset = "0x81C080", VA = "0x18081D480")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601065C RID: 67164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601065C")]
		[Address(RVA = "0x818EE0", Offset = "0x817AE0", VA = "0x180818EE0")]
		public void Start()
		{
		}

		// Token: 0x0601065D RID: 67165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601065D")]
		[Address(RVA = "0x818F40", Offset = "0x817B40", VA = "0x180818F40")]
		public void TriggerGarrisonStatusRefresh(Character target, Blackboard blackboard)
		{
		}

		// Token: 0x0601065E RID: 67166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601065E")]
		[Address(RVA = "0x81C8B0", Offset = "0x81B4B0", VA = "0x18081C8B0")]
		private void _TriggerGarrisonStatusRefresh(Character target, Blackboard blackboard)
		{
		}

		// Token: 0x0601065F RID: 67167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601065F")]
		[Address(RVA = "0x81BFB0", Offset = "0x81ABB0", VA = "0x18081BFB0")]
		private void _RegisterExecuters()
		{
		}

		// Token: 0x06010660 RID: 67168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010660")]
		[Address(RVA = "0x81D250", Offset = "0x81BE50", VA = "0x18081D250")]
		public AutoChessGarrisonManager()
		{
		}

		// Token: 0x04012559 RID: 75097
		[Token(Token = "0x4012559")]
		private const string CONDITION_KEY = "conditionkey";

		// Token: 0x0401255A RID: 75098
		[Token(Token = "0x401255A")]
		private const string CONDITION_CHECK_COUNT_KEY = "check_count";

		// Token: 0x0401255B RID: 75099
		[Token(Token = "0x401255B")]
		private const string BOND_TYPE_KEY = "bond_type";

		// Token: 0x0401255C RID: 75100
		[Token(Token = "0x401255C")]
		private const string BOND_ADD_TYPE_KEY = "bond_add_type";

		// Token: 0x0401255D RID: 75101
		[Token(Token = "0x401255D")]
		private const string BOND_ID_KEY = "bond_id";

		// Token: 0x0401255E RID: 75102
		[Token(Token = "0x401255E")]
		private const string BOND_ADD_COUNT_KEY = "bond_add_count";

		// Token: 0x0401255F RID: 75103
		[Token(Token = "0x401255F")]
		private const string BOND_ADD_COUNT_MULTI_KEY = "bond_add_count_multi";

		// Token: 0x04012560 RID: 75104
		[Token(Token = "0x4012560")]
		private const string BOND_RANDOM_COUNT_KEY = "bond_random_count";

		// Token: 0x04012561 RID: 75105
		[Token(Token = "0x4012561")]
		private const string BOND_ADD_MAX_PER_BATTLE = "max_add_count_per_battle";

		// Token: 0x04012562 RID: 75106
		[Token(Token = "0x4012562")]
		private const string BOND_ADD_STATE_KEY = "garrison_key";

		// Token: 0x04012563 RID: 75107
		[Token(Token = "0x4012563")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Func<AutoChessGarrisonManager.TriggerSnapShot, bool>> m_bondTriggerConditionExecuters;

		// Token: 0x04012564 RID: 75108
		[Token(Token = "0x4012564")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Action<AutoChessGarrisonManager.TriggerSnapShot, List<string>>> m_bondIdExecuters;

		// Token: 0x04012565 RID: 75109
		[Token(Token = "0x4012565")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Func<AutoChessGarrisonManager.TriggerSnapShot, int>> m_bondAddCountExecuters;

		// Token: 0x04012566 RID: 75110
		[Token(Token = "0x4012566")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_tmpBondIdSharedList;

		// Token: 0x04012567 RID: 75111
		[Token(Token = "0x4012567")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_tmpBondIdAddedList;

		// Token: 0x04012568 RID: 75112
		[Token(Token = "0x4012568")]
		[FieldOffset(Offset = "0x38")]
		private AutoChessGarrisonManager.TriggerSnapShot m_triggerSnapShot;

		// Token: 0x04012569 RID: 75113
		[Token(Token = "0x4012569")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<int> m_chessLevelHashSet;

		// Token: 0x0401256A RID: 75114
		[Token(Token = "0x401256A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RegisterBondIdExecuters;

		// Token: 0x0401256B RID: 75115
		[Token(Token = "0x401256B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1__RegisterBondIdExecuters;

		// Token: 0x0401256C RID: 75116
		[Token(Token = "0x401256C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterBondAddCountExecuters;

		// Token: 0x0401256D RID: 75117
		[Token(Token = "0x401256D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__BondCheckCharacterSameRow;

		// Token: 0x0401256E RID: 75118
		[Token(Token = "0x401256E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__BondCheckCharacterSameCol;

		// Token: 0x0401256F RID: 75119
		[Token(Token = "0x401256F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__BondCheckCharacterSameColOrRow;

		// Token: 0x04012570 RID: 75120
		[Token(Token = "0x4012570")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetBondIdsById;

		// Token: 0x04012571 RID: 75121
		[Token(Token = "0x4012571")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__BondCheckTargetCharacterInHand;

		// Token: 0x04012572 RID: 75122
		[Token(Token = "0x4012572")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__BondCheckSpecifiedBondCharacterInHand;

		// Token: 0x04012573 RID: 75123
		[Token(Token = "0x4012573")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BondCheckSpecifiedProfessionInHand;

		// Token: 0x04012574 RID: 75124
		[Token(Token = "0x4012574")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetBondIdsSelf;

		// Token: 0x04012575 RID: 75125
		[Token(Token = "0x4012575")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetBondIdsSelfAndInfront;

		// Token: 0x04012576 RID: 75126
		[Token(Token = "0x4012576")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetBondIdsSelfAndBehind;

		// Token: 0x04012577 RID: 75127
		[Token(Token = "0x4012577")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetBondIdsAllInfront;

		// Token: 0x04012578 RID: 75128
		[Token(Token = "0x4012578")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetBondIdsAllInhand;

		// Token: 0x04012579 RID: 75129
		[Token(Token = "0x4012579")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetBondIdsActivedMaxStack;

		// Token: 0x0401257A RID: 75130
		[Token(Token = "0x401257A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetBondIdsActivedRandomN;

		// Token: 0x0401257B RID: 75131
		[Token(Token = "0x401257B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByBB;

		// Token: 0x0401257C RID: 75132
		[Token(Token = "0x401257C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByCharLevel;

		// Token: 0x0401257D RID: 75133
		[Token(Token = "0x401257D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByShopLevel;

		// Token: 0x0401257E RID: 75134
		[Token(Token = "0x401257E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByCharCountSameRow;

		// Token: 0x0401257F RID: 75135
		[Token(Token = "0x401257F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByCharCountSameCol;

		// Token: 0x04012580 RID: 75136
		[Token(Token = "0x4012580")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByCharCountInBattle;

		// Token: 0x04012581 RID: 75137
		[Token(Token = "0x4012581")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByCharGained;

		// Token: 0x04012582 RID: 75138
		[Token(Token = "0x4012582")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByChessGained;

		// Token: 0x04012583 RID: 75139
		[Token(Token = "0x4012583")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GetBondAddCountByGoldSpend;

		// Token: 0x04012584 RID: 75140
		[Token(Token = "0x4012584")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GetDifferentChessLevelCntFilterBond;

		// Token: 0x04012585 RID: 75141
		[Token(Token = "0x4012585")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_dataModel;

		// Token: 0x04012586 RID: 75142
		[Token(Token = "0x4012586")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04012587 RID: 75143
		[Token(Token = "0x4012587")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_TriggerGarrisonStatusRefresh;

		// Token: 0x04012588 RID: 75144
		[Token(Token = "0x4012588")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TriggerGarrisonStatusRefresh;

		// Token: 0x04012589 RID: 75145
		[Token(Token = "0x4012589")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RegisterExecuters;

		// Token: 0x0401258A RID: 75146
		[Token(Token = "0x401258A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002750 RID: 10064
		[Token(Token = "0x2002750")]
		private struct TriggerSnapShot
		{
			// Token: 0x0401258B RID: 75147
			[Token(Token = "0x401258B")]
			[FieldOffset(Offset = "0x0")]
			public Character target;

			// Token: 0x0401258C RID: 75148
			[Token(Token = "0x401258C")]
			[FieldOffset(Offset = "0x8")]
			public Blackboard blackboard;
		}
	}
}
