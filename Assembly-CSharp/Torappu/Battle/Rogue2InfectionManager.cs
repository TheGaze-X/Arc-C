using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002349 RID: 9033
	[Token(Token = "0x2002349")]
	public class Rogue2InfectionManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x0600E47B RID: 58491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C9B")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E47B")]
			[Address(RVA = "0x5A8BB0", Offset = "0x5A77B0", VA = "0x1805A8BB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E47C")]
		[Address(RVA = "0x5A5A30", Offset = "0x5A4630", VA = "0x1805A5A30", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E47D")]
		[Address(RVA = "0x5A5960", Offset = "0x5A4560", VA = "0x1805A5960", Slot = "10")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E47E")]
		[Address(RVA = "0x5A7C20", Offset = "0x5A6820", VA = "0x1805A7C20")]
		private void _OnGameReady(object arg)
		{
		}

		// Token: 0x0600E47F RID: 58495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E47F")]
		[Address(RVA = "0x5A7410", Offset = "0x5A6010", VA = "0x1805A7410")]
		private void _OnCharacterLocate(object arg)
		{
		}

		// Token: 0x0600E480 RID: 58496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E480")]
		[Address(RVA = "0x5A7B20", Offset = "0x5A6720", VA = "0x1805A7B20")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E481 RID: 58497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E481")]
		[Address(RVA = "0x5A8300", Offset = "0x5A6F00", VA = "0x1805A8300")]
		private void _RegisterOriginalCharBuff(uint uniqueId, Blackboard bb)
		{
		}

		// Token: 0x0600E482 RID: 58498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E482")]
		[Address(RVA = "0x5A6F80", Offset = "0x5A5B80", VA = "0x1805A6F80")]
		private void _GenerateInfectionBuffData()
		{
		}

		// Token: 0x0600E483 RID: 58499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E483")]
		[Address(RVA = "0x5A5DB0", Offset = "0x5A49B0", VA = "0x1805A5DB0")]
		private void _CheckAndCreateInfectionCardBuff(string buffKey)
		{
		}

		// Token: 0x0600E484 RID: 58500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E484")]
		[Address(RVA = "0x5A6890", Offset = "0x5A5490", VA = "0x1805A6890")]
		private void _CreateCardEffect(List<uint> uids, Deck.Card.CardEffectType effectType)
		{
		}

		// Token: 0x0600E485 RID: 58501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E485")]
		[Address(RVA = "0x5A7F90", Offset = "0x5A6B90", VA = "0x1805A7F90")]
		private void _OnOriginallyAscendedCharacterBorn(Character character)
		{
		}

		// Token: 0x0600E486 RID: 58502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E486")]
		[Address(RVA = "0x5A80C0", Offset = "0x5A6CC0", VA = "0x1805A80C0")]
		private void _OnOriginallyInfectedCharacterBorn(Character character, int infectionCount)
		{
		}

		// Token: 0x0600E487 RID: 58503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E487")]
		[Address(RVA = "0x5A77B0", Offset = "0x5A63B0", VA = "0x1805A77B0")]
		private void _OnClearCharacterBorn(Character character)
		{
		}

		// Token: 0x0600E488 RID: 58504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E488")]
		[Address(RVA = "0x5A6D40", Offset = "0x5A5940", VA = "0x1805A6D40")]
		private void _DoActiveInfection(Character character)
		{
		}

		// Token: 0x0600E489 RID: 58505 RVA: 0x00052AB8 File Offset: 0x00050CB8
		[Token(Token = "0x600E489")]
		[Address(RVA = "0x5A86E0", Offset = "0x5A72E0", VA = "0x1805A86E0")]
		private bool _TryInfectCharacterOnTile(Character source, GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600E48A RID: 58506 RVA: 0x00052AD0 File Offset: 0x00050CD0
		[Token(Token = "0x600E48A")]
		[Address(RVA = "0x5A6C50", Offset = "0x5A5850", VA = "0x1805A6C50")]
		private bool _DecAndCheckIfInfectionCountZero(uint uid)
		{
			return default(bool);
		}

		// Token: 0x0600E48B RID: 58507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E48B")]
		[Address(RVA = "0x5A7210", Offset = "0x5A5E10", VA = "0x1805A7210")]
		private void _Infect(Character character)
		{
		}

		// Token: 0x0600E48C RID: 58508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E48C")]
		[Address(RVA = "0x5A5AF0", Offset = "0x5A46F0", VA = "0x1805A5AF0")]
		private void _Ascend(Character character)
		{
		}

		// Token: 0x0600E48D RID: 58509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E48D")]
		[Address(RVA = "0x5A6130", Offset = "0x5A4D30", VA = "0x1805A6130")]
		private List<Character> _CollectOriginallyInfectedCharactersInRange(Character source)
		{
			return null;
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x00052AE8 File Offset: 0x00050CE8
		[Token(Token = "0x600E48E")]
		[Address(RVA = "0x5A85A0", Offset = "0x5A71A0", VA = "0x1805A85A0")]
		private bool _TryGetCardBuffKey(string coreBuffKey, out string cardBuffKey)
		{
			return default(bool);
		}

		// Token: 0x0600E48F RID: 58511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E48F")]
		[Address(RVA = "0x5A6A50", Offset = "0x5A5650", VA = "0x1805A6A50")]
		private void _CreateInfectionProjectile(Entity source, Entity target)
		{
		}

		// Token: 0x0600E490 RID: 58512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E490")]
		[Address(RVA = "0x5A7070", Offset = "0x5A5C70", VA = "0x1805A7070")]
		private BuffData _GetBuffData(string buffKey)
		{
			return null;
		}

		// Token: 0x0600E491 RID: 58513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E491")]
		[Address(RVA = "0x5A66D0", Offset = "0x5A52D0", VA = "0x1805A66D0")]
		private void _CreateCardEffectDeckBuff(Deck.Card card, Deck.Card.CardEffectType effectType)
		{
		}

		// Token: 0x0600E492 RID: 58514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E492")]
		[Address(RVA = "0x5A8940", Offset = "0x5A7540", VA = "0x1805A8940")]
		public Rogue2InfectionManager()
		{
		}

		// Token: 0x0600E493 RID: 58515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E493")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E494 RID: 58516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E494")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E495")]
		[Address(RVA = "0x550BC0", Offset = "0x54F7C0", VA = "0x180550BC0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0400FBAE RID: 64430
		[Token(Token = "0x400FBAE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _maxInfectionCount;

		// Token: 0x0400FBAF RID: 64431
		[Token(Token = "0x400FBAF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GridPosition> _gridCheckList;

		// Token: 0x0400FBB0 RID: 64432
		[Token(Token = "0x400FBB0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Rogue2InfectionManager.CardBuffReplacePair> _cardBuffKeys;

		// Token: 0x0400FBB1 RID: 64433
		[Token(Token = "0x400FBB1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x0400FBB2 RID: 64434
		[Token(Token = "0x400FBB2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _projectileAbilityName;

		// Token: 0x0400FBB3 RID: 64435
		[Token(Token = "0x400FBB3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _mutationEffectDeckBuffKey;

		// Token: 0x0400FBB4 RID: 64436
		[Token(Token = "0x400FBB4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _ascensionEffectDeckBuffKey;

		// Token: 0x0400FBB5 RID: 64437
		[Token(Token = "0x400FBB5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<BuffData> _infectionBuffDataList;

		// Token: 0x0400FBB6 RID: 64438
		[Token(Token = "0x400FBB6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuffData _originalInfectedEffectBuffData;

		// Token: 0x0400FBB7 RID: 64439
		[Token(Token = "0x400FBB7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuffData _ascensionBuffData;

		// Token: 0x0400FBB8 RID: 64440
		[Token(Token = "0x400FBB8")]
		[FieldOffset(Offset = "0x78")]
		private Blackboard m_infectedBlackboard;

		// Token: 0x0400FBB9 RID: 64441
		[Token(Token = "0x400FBB9")]
		[FieldOffset(Offset = "0x80")]
		[Inspect]
		[ReadOnly]
		private int m_maxInfectionCount;

		// Token: 0x0400FBBA RID: 64442
		[Token(Token = "0x400FBBA")]
		[FieldOffset(Offset = "0x88")]
		[Inspect]
		[ReadOnly]
		private readonly Dictionary<uint, int> m_originallyInfectedCharUid;

		// Token: 0x0400FBBB RID: 64443
		[Token(Token = "0x400FBBB")]
		[FieldOffset(Offset = "0x90")]
		[Inspect]
		[ReadOnly]
		private readonly List<uint> m_originallyAscendedCharUid;

		// Token: 0x0400FBBC RID: 64444
		[Token(Token = "0x400FBBC")]
		[FieldOffset(Offset = "0x98")]
		[Inspect]
		[ReadOnly]
		private readonly List<uint> m_infectedCharUid;

		// Token: 0x0400FBBD RID: 64445
		[Token(Token = "0x400FBBD")]
		[FieldOffset(Offset = "0xA0")]
		[Inspect]
		[ReadOnly]
		private readonly List<uint> m_ascendedCharUid;

		// Token: 0x0400FBBE RID: 64446
		[Token(Token = "0x400FBBE")]
		[FieldOffset(Offset = "0xA8")]
		[Inspect]
		[ReadOnly]
		private BuffData m_infectedBuffData;

		// Token: 0x0400FBBF RID: 64447
		[Token(Token = "0x400FBBF")]
		private const float NEARBY_DISTANCE = 1.5f;

		// Token: 0x0400FBC0 RID: 64448
		[Token(Token = "0x400FBC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FBC1 RID: 64449
		[Token(Token = "0x400FBC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FBC2 RID: 64450
		[Token(Token = "0x400FBC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400FBC3 RID: 64451
		[Token(Token = "0x400FBC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnGameReady;

		// Token: 0x0400FBC4 RID: 64452
		[Token(Token = "0x400FBC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCharacterLocate;

		// Token: 0x0400FBC5 RID: 64453
		[Token(Token = "0x400FBC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400FBC6 RID: 64454
		[Token(Token = "0x400FBC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RegisterOriginalCharBuff;

		// Token: 0x0400FBC7 RID: 64455
		[Token(Token = "0x400FBC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateInfectionBuffData;

		// Token: 0x0400FBC8 RID: 64456
		[Token(Token = "0x400FBC8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckAndCreateInfectionCardBuff;

		// Token: 0x0400FBC9 RID: 64457
		[Token(Token = "0x400FBC9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateCardEffect;

		// Token: 0x0400FBCA RID: 64458
		[Token(Token = "0x400FBCA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnOriginallyAscendedCharacterBorn;

		// Token: 0x0400FBCB RID: 64459
		[Token(Token = "0x400FBCB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnOriginallyInfectedCharacterBorn;

		// Token: 0x0400FBCC RID: 64460
		[Token(Token = "0x400FBCC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClearCharacterBorn;

		// Token: 0x0400FBCD RID: 64461
		[Token(Token = "0x400FBCD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoActiveInfection;

		// Token: 0x0400FBCE RID: 64462
		[Token(Token = "0x400FBCE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryInfectCharacterOnTile;

		// Token: 0x0400FBCF RID: 64463
		[Token(Token = "0x400FBCF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DecAndCheckIfInfectionCountZero;

		// Token: 0x0400FBD0 RID: 64464
		[Token(Token = "0x400FBD0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__Infect;

		// Token: 0x0400FBD1 RID: 64465
		[Token(Token = "0x400FBD1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__Ascend;

		// Token: 0x0400FBD2 RID: 64466
		[Token(Token = "0x400FBD2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CollectOriginallyInfectedCharactersInRange;

		// Token: 0x0400FBD3 RID: 64467
		[Token(Token = "0x400FBD3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryGetCardBuffKey;

		// Token: 0x0400FBD4 RID: 64468
		[Token(Token = "0x400FBD4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CreateInfectionProjectile;

		// Token: 0x0400FBD5 RID: 64469
		[Token(Token = "0x400FBD5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetBuffData;

		// Token: 0x0400FBD6 RID: 64470
		[Token(Token = "0x400FBD6")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CreateCardEffectDeckBuff;

		// Token: 0x0400FBD7 RID: 64471
		[Token(Token = "0x400FBD7")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200234A RID: 9034
		[Token(Token = "0x200234A")]
		[Serializable]
		private class CardBuffReplacePair
		{
			// Token: 0x0600E496 RID: 58518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E496")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CardBuffReplacePair()
			{
			}

			// Token: 0x0400FBD8 RID: 64472
			[Token(Token = "0x400FBD8")]
			[FieldOffset(Offset = "0x10")]
			public string coreBuffKey;

			// Token: 0x0400FBD9 RID: 64473
			[Token(Token = "0x400FBD9")]
			[FieldOffset(Offset = "0x18")]
			public string cardBuffKey;
		}
	}
}
