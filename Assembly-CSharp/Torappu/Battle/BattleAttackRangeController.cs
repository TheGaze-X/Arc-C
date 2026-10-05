using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023B5 RID: 9141
	[Token(Token = "0x20023B5")]
	public class BattleAttackRangeController : IHotfixable
	{
		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600E863 RID: 59491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D52")]
		public Dictionary<Character, List<Tile>> attackRangeTiles
		{
			[Token(Token = "0x600E863")]
			[Address(RVA = "0x5CEAF0", Offset = "0x5CD6F0", VA = "0x1805CEAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600E864 RID: 59492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D53")]
		public Dictionary<Character, List<Tile>> originAttackRangeTiles
		{
			[Token(Token = "0x600E864")]
			[Address(RVA = "0x5CEB50", Offset = "0x5CD750", VA = "0x1805CEB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E865 RID: 59493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E865")]
		[Address(RVA = "0x5CD1C0", Offset = "0x5CBDC0", VA = "0x1805CD1C0")]
		public void BindOwner(BattleAttackRangeController.IRangeListener listener, Character character)
		{
		}

		// Token: 0x0600E866 RID: 59494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E866")]
		[Address(RVA = "0x5CD100", Offset = "0x5CBD00", VA = "0x1805CD100")]
		public void AddRangeListener(BattleAttackRangeController.IRangeListener listener)
		{
		}

		// Token: 0x0600E867 RID: 59495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E867")]
		[Address(RVA = "0x5CD310", Offset = "0x5CBF10", VA = "0x1805CD310")]
		public void RemoveRangeListener(BattleAttackRangeController.IRangeListener listener)
		{
		}

		// Token: 0x0600E868 RID: 59496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E868")]
		[Address(RVA = "0x5CD3B0", Offset = "0x5CBFB0", VA = "0x1805CD3B0")]
		public void RemoveRangeListener(Character character)
		{
		}

		// Token: 0x0600E869 RID: 59497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E869")]
		[Address(RVA = "0x5CE740", Offset = "0x5CD340", VA = "0x1805CE740")]
		public BattleAttackRangeController()
		{
		}

		// Token: 0x0600E86A RID: 59498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E86A")]
		[Address(RVA = "0x5CD710", Offset = "0x5CC310", VA = "0x1805CD710")]
		private void _Init()
		{
		}

		// Token: 0x0600E86B RID: 59499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E86B")]
		[Address(RVA = "0x5CDE10", Offset = "0x5CCA10", VA = "0x1805CDE10")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E86C RID: 59500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E86C")]
		[Address(RVA = "0x5CE360", Offset = "0x5CCF60", VA = "0x1805CE360")]
		private void _OnUnitReborn(object arg)
		{
		}

		// Token: 0x0600E86D RID: 59501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E86D")]
		[Address(RVA = "0x5CE040", Offset = "0x5CCC40", VA = "0x1805CE040")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E86E RID: 59502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E86E")]
		[Address(RVA = "0x5CDBD0", Offset = "0x5CC7D0", VA = "0x1805CDBD0")]
		private void _OnUnitAttackRangeUpdated(object arg)
		{
		}

		// Token: 0x0600E86F RID: 59503 RVA: 0x00054D08 File Offset: 0x00052F08
		[Token(Token = "0x600E86F")]
		[Address(RVA = "0x5CE670", Offset = "0x5CD270", VA = "0x1805CE670")]
		private bool _ValidCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E870 RID: 59504 RVA: 0x00054D20 File Offset: 0x00052F20
		[Token(Token = "0x600E870")]
		[Address(RVA = "0x5CE590", Offset = "0x5CD190", VA = "0x1805CE590")]
		private bool _RefreshCharacterRangeTiles(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E871 RID: 59505 RVA: 0x00054D38 File Offset: 0x00052F38
		[Token(Token = "0x600E871")]
		[Address(RVA = "0x5CD550", Offset = "0x5CC150", VA = "0x1805CD550")]
		private bool _CheckAndUpdateTiles(Dictionary<Character, List<Tile>> tilesDict, List<Tile> charTiles, Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E872 RID: 59506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E872")]
		[Address(RVA = "0x5CD9C0", Offset = "0x5CC5C0", VA = "0x1805CD9C0")]
		private void _OnCharacterAttackRangeUpdate(Character character)
		{
		}

		// Token: 0x04010003 RID: 65539
		[Token(Token = "0x4010003")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Character, List<Tile>> m_attackRangeTiles;

		// Token: 0x04010004 RID: 65540
		[Token(Token = "0x4010004")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Character, List<Tile>> m_originAttackRangeTiles;

		// Token: 0x04010005 RID: 65541
		[Token(Token = "0x4010005")]
		[FieldOffset(Offset = "0x20")]
		private List<BattleAttackRangeController.IRangeListener> m_rangeListeners;

		// Token: 0x04010006 RID: 65542
		[Token(Token = "0x4010006")]
		[FieldOffset(Offset = "0x28")]
		private List<KeyValuePair<BattleAttackRangeController.IRangeListener, Character>> m_rangeListenersWithOwner;

		// Token: 0x04010007 RID: 65543
		[Token(Token = "0x4010007")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attackRangeTiles;

		// Token: 0x04010008 RID: 65544
		[Token(Token = "0x4010008")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_originAttackRangeTiles;

		// Token: 0x04010009 RID: 65545
		[Token(Token = "0x4010009")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindOwner;

		// Token: 0x0401000A RID: 65546
		[Token(Token = "0x401000A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddRangeListener;

		// Token: 0x0401000B RID: 65547
		[Token(Token = "0x401000B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RemoveRangeListener;

		// Token: 0x0401000C RID: 65548
		[Token(Token = "0x401000C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_RemoveRangeListener;

		// Token: 0x0401000D RID: 65549
		[Token(Token = "0x401000D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401000E RID: 65550
		[Token(Token = "0x401000E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0401000F RID: 65551
		[Token(Token = "0x401000F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x04010010 RID: 65552
		[Token(Token = "0x4010010")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnUnitReborn;

		// Token: 0x04010011 RID: 65553
		[Token(Token = "0x4010011")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x04010012 RID: 65554
		[Token(Token = "0x4010012")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnUnitAttackRangeUpdated;

		// Token: 0x04010013 RID: 65555
		[Token(Token = "0x4010013")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ValidCharacter;

		// Token: 0x04010014 RID: 65556
		[Token(Token = "0x4010014")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RefreshCharacterRangeTiles;

		// Token: 0x04010015 RID: 65557
		[Token(Token = "0x4010015")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckAndUpdateTiles;

		// Token: 0x04010016 RID: 65558
		[Token(Token = "0x4010016")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCharacterAttackRangeUpdate;

		// Token: 0x020023B6 RID: 9142
		[Token(Token = "0x20023B6")]
		public interface IRangeListener
		{
			// Token: 0x0600E873 RID: 59507
			[Token(Token = "0x600E873")]
			void OnCharacterAttackRangeUpdate(Character character, Dictionary<Character, List<Tile>> allRangeTiles);
		}
	}
}
