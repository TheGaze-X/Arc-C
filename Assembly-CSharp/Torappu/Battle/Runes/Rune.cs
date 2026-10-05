using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes
{
	// Token: 0x020028BC RID: 10428
	[Token(Token = "0x20028BC")]
	public abstract class Rune : IComparable<Rune>, IHotfixable
	{
		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x06011583 RID: 71043 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06011584 RID: 71044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002654")]
		public RuneData rData
		{
			[Token(Token = "0x6011583")]
			[Address(RVA = "0x930C10", Offset = "0x92F810", VA = "0x180930C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6011584")]
			[Address(RVA = "0x930CD0", Offset = "0x92F8D0", VA = "0x180930CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x06011585 RID: 71045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002655")]
		public Blackboard blackboard
		{
			[Token(Token = "0x6011585")]
			[Address(RVA = "0x930B00", Offset = "0x92F700", VA = "0x180930B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x06011586 RID: 71046 RVA: 0x0006AB48 File Offset: 0x00068D48
		// (set) Token: 0x06011587 RID: 71047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002656")]
		public bool valid
		{
			[Token(Token = "0x6011586")]
			[Address(RVA = "0x930C70", Offset = "0x92F870", VA = "0x180930C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011587")]
			[Address(RVA = "0x930D50", Offset = "0x92F950", VA = "0x180930D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x06011588 RID: 71048
		[Token(Token = "0x17002657")]
		public abstract Rune.RuneTarget targetMask { [Token(Token = "0x6011588")] get; }

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x06011589 RID: 71049 RVA: 0x0006AB60 File Offset: 0x00068D60
		[Token(Token = "0x17002658")]
		public virtual int priorityQueue
		{
			[Token(Token = "0x6011589")]
			[Address(RVA = "0x930BB0", Offset = "0x92F7B0", VA = "0x180930BB0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601158A RID: 71050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601158A")]
		[Address(RVA = "0x930AA0", Offset = "0x92F6A0", VA = "0x180930AA0")]
		protected Rune()
		{
		}

		// Token: 0x0601158B RID: 71051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601158B")]
		[Address(RVA = "0x92E170", Offset = "0x92CD70", VA = "0x18092E170")]
		public void Init(RuneData data)
		{
		}

		// Token: 0x0601158C RID: 71052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601158C")]
		[Address(RVA = "0x92EDF0", Offset = "0x92D9F0", VA = "0x18092EDF0")]
		public static void Reset()
		{
		}

		// Token: 0x0601158D RID: 71053
		[Token(Token = "0x601158D")]
		public abstract void PreprocessLevelOptions(LevelData.Options options);

		// Token: 0x0601158E RID: 71054
		[Token(Token = "0x601158E")]
		public abstract void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData);

		// Token: 0x0601158F RID: 71055
		[Token(Token = "0x601158F")]
		public abstract void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character);

		// Token: 0x06011590 RID: 71056
		[Token(Token = "0x6011590")]
		public abstract void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy);

		// Token: 0x06011591 RID: 71057
		[Token(Token = "0x6011591")]
		public abstract void PreprocessTile(ref TileData tileData, GridPosition pos, Tile tile);

		// Token: 0x06011592 RID: 71058
		[Token(Token = "0x6011592")]
		public abstract void PreprocessDeck(IList<Deck.Card> cards);

		// Token: 0x06011593 RID: 71059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011593")]
		[Address(RVA = "0x92E6E0", Offset = "0x92D2E0", VA = "0x18092E6E0", Slot = "13")]
		public virtual void PreprocessBattlePlayerData(BattlePlayerData playerData)
		{
		}

		// Token: 0x06011594 RID: 71060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011594")]
		[Address(RVA = "0x92E7A0", Offset = "0x92D3A0", VA = "0x18092E7A0", Slot = "14")]
		public virtual void PreprocessRuneData(IEnumerable<Rune> runes)
		{
		}

		// Token: 0x06011595 RID: 71061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011595")]
		[Address(RVA = "0x92E740", Offset = "0x92D340", VA = "0x18092E740", Slot = "15")]
		public virtual void PreprocessDeckData(Deck deckData)
		{
		}

		// Token: 0x06011596 RID: 71062 RVA: 0x0006AB78 File Offset: 0x00068D78
		[Token(Token = "0x6011596")]
		[Address(RVA = "0x92F7E0", Offset = "0x92E3E0", VA = "0x18092F7E0")]
		public bool VerifySelf()
		{
			return default(bool);
		}

		// Token: 0x06011597 RID: 71063 RVA: 0x0006AB90 File Offset: 0x00068D90
		[Token(Token = "0x6011597")]
		[Address(RVA = "0x92E090", Offset = "0x92CC90", VA = "0x18092E090", Slot = "4")]
		public int CompareTo(Rune other)
		{
			return 0;
		}

		// Token: 0x06011598 RID: 71064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011598")]
		[Address(RVA = "0x92E2B0", Offset = "0x92CEB0", VA = "0x18092E2B0", Slot = "16")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06011599 RID: 71065 RVA: 0x0006ABA8 File Offset: 0x00068DA8
		[Token(Token = "0x6011599")]
		[Address(RVA = "0x92FC80", Offset = "0x92E880", VA = "0x18092FC80")]
		protected bool Verify(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601159A RID: 71066 RVA: 0x0006ABC0 File Offset: 0x00068DC0
		[Token(Token = "0x601159A")]
		[Address(RVA = "0x9302A0", Offset = "0x92EEA0", VA = "0x1809302A0")]
		protected bool Verify(Enemy enemy, LevelData.EnemyData enemyData)
		{
			return default(bool);
		}

		// Token: 0x0601159B RID: 71067 RVA: 0x0006ABD8 File Offset: 0x00068DD8
		[Token(Token = "0x601159B")]
		[Address(RVA = "0x9305A0", Offset = "0x92F1A0", VA = "0x1809305A0")]
		protected bool Verify(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x0601159C RID: 71068 RVA: 0x0006ABF0 File Offset: 0x00068DF0
		[Token(Token = "0x601159C")]
		[Address(RVA = "0x92F5B0", Offset = "0x92E1B0", VA = "0x18092F5B0")]
		private bool VerifyMapTag(MapData mapData)
		{
			return default(bool);
		}

		// Token: 0x0601159D RID: 71069 RVA: 0x0006AC08 File Offset: 0x00068E08
		[Token(Token = "0x601159D")]
		[Address(RVA = "0x92F710", Offset = "0x92E310", VA = "0x18092F710")]
		public bool VerifyPlayerDataSide(PlayerSide playerSide)
		{
			return default(bool);
		}

		// Token: 0x0601159E RID: 71070 RVA: 0x0006AC20 File Offset: 0x00068E20
		[Token(Token = "0x601159E")]
		[Address(RVA = "0x92F2A0", Offset = "0x92DEA0", VA = "0x18092F2A0")]
		private bool VerifyGroupTag(BattleCharacterData characterData)
		{
			return default(bool);
		}

		// Token: 0x0601159F RID: 71071 RVA: 0x0006AC38 File Offset: 0x00068E38
		[Token(Token = "0x601159F")]
		[Address(RVA = "0x92F3F0", Offset = "0x92DFF0", VA = "0x18092F3F0")]
		private bool VerifyHeightTypeMask(Character character)
		{
			return default(bool);
		}

		// Token: 0x060115A0 RID: 71072 RVA: 0x0006AC50 File Offset: 0x00068E50
		[Token(Token = "0x60115A0")]
		[Address(RVA = "0x92EF90", Offset = "0x92DB90", VA = "0x18092EF90")]
		private bool VerifyFilterTag(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x060115A1 RID: 71073 RVA: 0x0006AC68 File Offset: 0x00068E68
		[Token(Token = "0x60115A1")]
		[Address(RVA = "0x92FBA0", Offset = "0x92E7A0", VA = "0x18092FBA0")]
		private bool VerifyUnitSide(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x060115A2 RID: 71074 RVA: 0x0006AC80 File Offset: 0x00068E80
		[Token(Token = "0x60115A2")]
		[Address(RVA = "0x92EEB0", Offset = "0x92DAB0", VA = "0x18092EEB0")]
		private bool VerifyCharacterCardUid(Character charUnit)
		{
			return default(bool);
		}

		// Token: 0x060115A3 RID: 71075 RVA: 0x0006AC98 File Offset: 0x00068E98
		[Token(Token = "0x60115A3")]
		[Address(RVA = "0x930930", Offset = "0x92F530", VA = "0x180930930")]
		private bool _VerifyFilterTag(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x060115A4 RID: 71076 RVA: 0x0006ACB0 File Offset: 0x00068EB0
		[Token(Token = "0x60115A4")]
		[Address(RVA = "0x9307C0", Offset = "0x92F3C0", VA = "0x1809307C0")]
		private bool _VerifyFilterTagExclude(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x060115A5 RID: 71077 RVA: 0x0006ACC8 File Offset: 0x00068EC8
		[Token(Token = "0x60115A5")]
		[Address(RVA = "0x92F9C0", Offset = "0x92E5C0", VA = "0x18092F9C0")]
		private bool VerifySubProfession(Character character)
		{
			return default(bool);
		}

		// Token: 0x060115A6 RID: 71078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115A6")]
		[Address(RVA = "0x92D480", Offset = "0x92C080", VA = "0x18092D480")]
		protected void ApplyChangesToAttributes(AttributesData attributes, Func<FP, FP, FP> calcFunc)
		{
		}

		// Token: 0x060115A7 RID: 71079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115A7")]
		[Address(RVA = "0x92CE50", Offset = "0x92BA50", VA = "0x18092CE50")]
		protected void ApplyChangesToAbnormalImmune(AttributesData attributes)
		{
		}

		// Token: 0x060115A8 RID: 71080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115A8")]
		[Address(RVA = "0x92D1A0", Offset = "0x92BDA0", VA = "0x18092D1A0")]
		protected void ApplyChangesToAttributesAdd(AttributesData attributes)
		{
		}

		// Token: 0x060115A9 RID: 71081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115A9")]
		[Address(RVA = "0x92D310", Offset = "0x92BF10", VA = "0x18092D310")]
		protected void ApplyChangesToAttributesMul(AttributesData attributes)
		{
		}

		// Token: 0x060115AA RID: 71082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115AA")]
		[Address(RVA = "0x92EB40", Offset = "0x92D740", VA = "0x18092EB40")]
		protected void RegisterBlackboardInAdditiveByGroup()
		{
		}

		// Token: 0x060115AB RID: 71083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115AB")]
		[Address(RVA = "0x92E800", Offset = "0x92D400", VA = "0x18092E800")]
		protected void RegisterAdditiveAttribute(string groupKey, AttributeType type, FP value)
		{
		}

		// Token: 0x060115AC RID: 71084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115AC")]
		[Address(RVA = "0x92C490", Offset = "0x92B090", VA = "0x18092C490")]
		public static void ApplyAdditiveMulAttribute(ref Rune.CharacterInOut inOut)
		{
		}

		// Token: 0x060115AD RID: 71085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115AD")]
		[Address(RVA = "0x92C970", Offset = "0x92B570", VA = "0x18092C970")]
		public static void ApplyAdditiveMulAttribute(ref LevelData.EnemyData inOut)
		{
		}

		// Token: 0x060115AE RID: 71086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115AE")]
		[Address(RVA = "0x92DEA0", Offset = "0x92CAA0", VA = "0x18092DEA0")]
		protected void ApplyChangesToBlackboard(List<Blackboard.DataPair> targetBlackboard, Func<float, float, float> calcFunc)
		{
		}

		// Token: 0x060115AF RID: 71087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115AF")]
		[Address(RVA = "0x92D7C0", Offset = "0x92C3C0", VA = "0x18092D7C0")]
		protected void ApplyChangesToBlackboardAdd(List<Blackboard.DataPair> targetBlackboard)
		{
		}

		// Token: 0x060115B0 RID: 71088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115B0")]
		[Address(RVA = "0x92DD30", Offset = "0x92C930", VA = "0x18092DD30")]
		protected void ApplyChangesToBlackboardMul(List<Blackboard.DataPair> targetBlackboard)
		{
		}

		// Token: 0x060115B1 RID: 71089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115B1")]
		[Address(RVA = "0x92DBC0", Offset = "0x92C7C0", VA = "0x18092DBC0")]
		protected void ApplyChangesToBlackboardMax(List<Blackboard.DataPair> targetBlackboard)
		{
		}

		// Token: 0x060115B2 RID: 71090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115B2")]
		[Address(RVA = "0x92D930", Offset = "0x92C530", VA = "0x18092D930")]
		protected List<Blackboard.DataPair> ApplyChangesToBlackboardAssign(List<Blackboard.DataPair> targetBlackboard)
		{
			return null;
		}

		// Token: 0x060115B3 RID: 71091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115B3")]
		[Address(RVA = "0x92E310", Offset = "0x92CF10", VA = "0x18092E310")]
		protected static List<GridPosition> ParseGridPosList(Blackboard blackboard, string blackboardKey)
		{
			return null;
		}

		// Token: 0x04013620 RID: 79392
		[Token(Token = "0x4013620")]
		[FieldOffset(Offset = "0x0")]
		protected static ListDict<string, ListDict<AttributeType, FP>> m_additiveModifierCache;

		// Token: 0x04013621 RID: 79393
		[Token(Token = "0x4013621")]
		protected const string DEFAULT_GROUP_KEY = "@DEFAULT_GROUP";

		// Token: 0x04013623 RID: 79395
		[Token(Token = "0x4013623")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_rData;

		// Token: 0x04013624 RID: 79396
		[Token(Token = "0x4013624")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_rData;

		// Token: 0x04013625 RID: 79397
		[Token(Token = "0x4013625")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x04013626 RID: 79398
		[Token(Token = "0x4013626")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_valid;

		// Token: 0x04013627 RID: 79399
		[Token(Token = "0x4013627")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_valid;

		// Token: 0x04013628 RID: 79400
		[Token(Token = "0x4013628")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013629 RID: 79401
		[Token(Token = "0x4013629")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401362A RID: 79402
		[Token(Token = "0x401362A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401362B RID: 79403
		[Token(Token = "0x401362B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401362C RID: 79404
		[Token(Token = "0x401362C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x0401362D RID: 79405
		[Token(Token = "0x401362D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PreprocessRuneData;

		// Token: 0x0401362E RID: 79406
		[Token(Token = "0x401362E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PreprocessDeckData;

		// Token: 0x0401362F RID: 79407
		[Token(Token = "0x401362F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_VerifySelf;

		// Token: 0x04013630 RID: 79408
		[Token(Token = "0x4013630")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04013631 RID: 79409
		[Token(Token = "0x4013631")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013632 RID: 79410
		[Token(Token = "0x4013632")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Verify;

		// Token: 0x04013633 RID: 79411
		[Token(Token = "0x4013633")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_Verify;

		// Token: 0x04013634 RID: 79412
		[Token(Token = "0x4013634")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix2_Verify;

		// Token: 0x04013635 RID: 79413
		[Token(Token = "0x4013635")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_VerifyMapTag;

		// Token: 0x04013636 RID: 79414
		[Token(Token = "0x4013636")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_VerifyPlayerDataSide;

		// Token: 0x04013637 RID: 79415
		[Token(Token = "0x4013637")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_VerifyGroupTag;

		// Token: 0x04013638 RID: 79416
		[Token(Token = "0x4013638")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_VerifyHeightTypeMask;

		// Token: 0x04013639 RID: 79417
		[Token(Token = "0x4013639")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_VerifyFilterTag;

		// Token: 0x0401363A RID: 79418
		[Token(Token = "0x401363A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_VerifyUnitSide;

		// Token: 0x0401363B RID: 79419
		[Token(Token = "0x401363B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_VerifyCharacterCardUid;

		// Token: 0x0401363C RID: 79420
		[Token(Token = "0x401363C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__VerifyFilterTag;

		// Token: 0x0401363D RID: 79421
		[Token(Token = "0x401363D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__VerifyFilterTagExclude;

		// Token: 0x0401363E RID: 79422
		[Token(Token = "0x401363E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_VerifySubProfession;

		// Token: 0x0401363F RID: 79423
		[Token(Token = "0x401363F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ApplyChangesToAttributes;

		// Token: 0x04013640 RID: 79424
		[Token(Token = "0x4013640")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_ApplyChangesToAbnormalImmune;

		// Token: 0x04013641 RID: 79425
		[Token(Token = "0x4013641")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ApplyChangesToAttributesAdd;

		// Token: 0x04013642 RID: 79426
		[Token(Token = "0x4013642")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ApplyChangesToAttributesMul;

		// Token: 0x04013643 RID: 79427
		[Token(Token = "0x4013643")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_RegisterBlackboardInAdditiveByGroup;

		// Token: 0x04013644 RID: 79428
		[Token(Token = "0x4013644")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_RegisterAdditiveAttribute;

		// Token: 0x04013645 RID: 79429
		[Token(Token = "0x4013645")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ApplyAdditiveMulAttribute;

		// Token: 0x04013646 RID: 79430
		[Token(Token = "0x4013646")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix1_ApplyAdditiveMulAttribute;

		// Token: 0x04013647 RID: 79431
		[Token(Token = "0x4013647")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ApplyChangesToBlackboard;

		// Token: 0x04013648 RID: 79432
		[Token(Token = "0x4013648")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_ApplyChangesToBlackboardAdd;

		// Token: 0x04013649 RID: 79433
		[Token(Token = "0x4013649")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_ApplyChangesToBlackboardMul;

		// Token: 0x0401364A RID: 79434
		[Token(Token = "0x401364A")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ApplyChangesToBlackboardMax;

		// Token: 0x0401364B RID: 79435
		[Token(Token = "0x401364B")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_ApplyChangesToBlackboardAssign;

		// Token: 0x0401364C RID: 79436
		[Token(Token = "0x401364C")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ParseGridPosList;

		// Token: 0x020028BD RID: 10429
		[Token(Token = "0x20028BD")]
		public enum RuneTarget
		{
			// Token: 0x0401364E RID: 79438
			[Token(Token = "0x401364E")]
			NONE,
			// Token: 0x0401364F RID: 79439
			[Token(Token = "0x401364F")]
			LEVEL_OPTIONS,
			// Token: 0x04013650 RID: 79440
			[Token(Token = "0x4013650")]
			CHARACTER,
			// Token: 0x04013651 RID: 79441
			[Token(Token = "0x4013651")]
			ENEMY = 4,
			// Token: 0x04013652 RID: 79442
			[Token(Token = "0x4013652")]
			LEVEL_DATA = 8,
			// Token: 0x04013653 RID: 79443
			[Token(Token = "0x4013653")]
			MAP = 16,
			// Token: 0x04013654 RID: 79444
			[Token(Token = "0x4013654")]
			CARD = 32,
			// Token: 0x04013655 RID: 79445
			[Token(Token = "0x4013655")]
			BATTLE_PLAYER_DATA = 64,
			// Token: 0x04013656 RID: 79446
			[Token(Token = "0x4013656")]
			RUNE_DATA_PRE = 128,
			// Token: 0x04013657 RID: 79447
			[Token(Token = "0x4013657")]
			DECK_DATA = 256
		}

		// Token: 0x020028BE RID: 10430
		[Token(Token = "0x20028BE")]
		protected static class Priorities
		{
			// Token: 0x04013658 RID: 79448
			[Token(Token = "0x4013658")]
			public const int LOW = 100;

			// Token: 0x04013659 RID: 79449
			[Token(Token = "0x4013659")]
			public const int DEFAULT = 500;

			// Token: 0x0401365A RID: 79450
			[Token(Token = "0x401365A")]
			public const int HIGH = 1000;
		}

		// Token: 0x020028BF RID: 10431
		[Token(Token = "0x20028BF")]
		public struct CharacterInOut
		{
			// Token: 0x0401365B RID: 79451
			[Token(Token = "0x401365B")]
			[FieldOffset(Offset = "0x0")]
			public AttributesData attributes;

			// Token: 0x0401365C RID: 79452
			[Token(Token = "0x401365C")]
			[FieldOffset(Offset = "0x8")]
			public bool excludedFromBattle;
		}

		// Token: 0x020028C0 RID: 10432
		[Token(Token = "0x20028C0")]
		public class RuneLevelExtraOutput
		{
			// Token: 0x060115B4 RID: 71092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60115B4")]
			[Address(RVA = "0x928D90", Offset = "0x927990", VA = "0x180928D90")]
			public RuneLevelExtraOutput(LevelData levelData)
			{
			}

			// Token: 0x060115B5 RID: 71093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60115B5")]
			[Address(RVA = "0x928FE0", Offset = "0x927BE0", VA = "0x180928FE0")]
			public RuneLevelExtraOutput()
			{
			}

			// Token: 0x0401365D RID: 79453
			[Token(Token = "0x401365D")]
			[FieldOffset(Offset = "0x10")]
			public List<LevelData.GlobalBuffData> globalBuffs;

			// Token: 0x0401365E RID: 79454
			[Token(Token = "0x401365E")]
			[FieldOffset(Offset = "0x18")]
			public List<GlobalEnvSystemData> globalEnvSystemDatas;

			// Token: 0x0401365F RID: 79455
			[Token(Token = "0x401365F")]
			[FieldOffset(Offset = "0x20")]
			public List<LevelScriptRuneData> levelScriptRuneDatas;

			// Token: 0x04013660 RID: 79456
			[Token(Token = "0x4013660")]
			[FieldOffset(Offset = "0x28")]
			public List<GridPosition> extraDisableLocations;

			// Token: 0x04013661 RID: 79457
			[Token(Token = "0x4013661")]
			[FieldOffset(Offset = "0x30")]
			public List<string> enabledHiddenGroups;

			// Token: 0x04013662 RID: 79458
			[Token(Token = "0x4013662")]
			[FieldOffset(Offset = "0x38")]
			public List<string> disabledHiddenGroups;
		}
	}
}
