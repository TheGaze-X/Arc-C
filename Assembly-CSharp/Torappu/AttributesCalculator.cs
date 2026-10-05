using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;

namespace Torappu
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	public static class AttributesCalculator
	{
		// Token: 0x06004D7A RID: 19834 RVA: 0x0002D990 File Offset: 0x0002BB90
		[Token(Token = "0x6004D7A")]
		[Address(RVA = "0x187E640", Offset = "0x187D240", VA = "0x18187E640")]
		private static bool _TryGetRawData(CharacterData data, AttributesCalculator.Input input, out AttributesData attributes)
		{
			return default(bool);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x0002D9A8 File Offset: 0x0002BBA8
		[Token(Token = "0x6004D7B")]
		[Address(RVA = "0x187D060", Offset = "0x187BC60", VA = "0x18187D060")]
		public static bool TryGetBasicData(CharacterData data, AttributesCalculator.Input input, out AttributesData attributes)
		{
			return default(bool);
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7C")]
		[Address(RVA = "0x187E4A0", Offset = "0x187D0A0", VA = "0x18187E4A0")]
		private static void _ResetFormulaItems()
		{
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		[Token(Token = "0x6004D7D")]
		[Address(RVA = "0x187D220", Offset = "0x187BE20", VA = "0x18187D220")]
		public static bool TryGetFinalData(CharacterData data, AttributesCalculator.Input input, string charKey, bool isToken, out AttributesData attributes)
		{
			return default(bool);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x187CA40", Offset = "0x187B640", VA = "0x18187CA40")]
		public static void FetchUniEquipAttributesDelta(List<CharacterData.UniqueEquipPair> queries, string charKey, bool isToken, out AttributesCalculator.AttributeRawDelta attriRawDelta, ref long attributeMask)
		{
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7F")]
		[Address(RVA = "0x187C7D0", Offset = "0x187B3D0", VA = "0x18187C7D0")]
		public static void FetchUniEquipAttributeAddition(List<CharacterData.UniqueEquipPair> uniEquipQueries, string charKey, bool isToken, FP[] finalEquipAdditions, ref long attributeMask)
		{
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D80")]
		[Address(RVA = "0x187C670", Offset = "0x187B270", VA = "0x18187C670")]
		private static void FetchEquipAttributesAdd(Blackboard blackboard, FP[] finalEquipAdditions, ref long attributeMask)
		{
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		[Token(Token = "0x6004D81")]
		[Address(RVA = "0x187CF00", Offset = "0x187BB00", VA = "0x18187CF00")]
		public static long LoadAttributeModifiers(FP[] m_attributeAdditions, FP[] m_attributeMultipliers, FP[] m_attributeFinalAdditions, FP[] m_attributeFinalScalers, IList<AttributeModifierData.AttributeModifier> modifiers)
		{
			return 0L;
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		[Token(Token = "0x6004D82")]
		[Address(RVA = "0x187CD50", Offset = "0x187B950", VA = "0x18187CD50")]
		public static long LoadAbnormalFlags(IList<AbnormalFlag> flags)
		{
			return 0L;
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x0002DA08 File Offset: 0x0002BC08
		[Token(Token = "0x6004D83")]
		[Address(RVA = "0x187CBA0", Offset = "0x187B7A0", VA = "0x18187CBA0")]
		public static long LoadAbnormalCombos(IList<AbnormalCombo> combos)
		{
			return 0L;
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x0002DA20 File Offset: 0x0002BC20
		[Token(Token = "0x6004D84")]
		[Address(RVA = "0x187E030", Offset = "0x187CC30", VA = "0x18187E030")]
		private static long _LoadAttributeModifiers(FP[] m_attributeAdditions, FP[] m_attributeMultipliers, FP[] m_attributeFinalAdditions, FP[] m_attributeFinalScalers, IList<AttributeModifierData.AttributeModifier> modifiers)
		{
			return 0L;
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D85")]
		[Address(RVA = "0x187DEA0", Offset = "0x187CAA0", VA = "0x18187DEA0")]
		private static List<ExternalBuff> _CollectExternalBuffs(CharacterData data, AttributesCalculator.Input input)
		{
			return null;
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x0002DA38 File Offset: 0x0002BC38
		[Token(Token = "0x6004D86")]
		[Address(RVA = "0x187DD90", Offset = "0x187C990", VA = "0x18187DD90")]
		private static FP _CalculateFinalAttribute(FP rawValue, FP addition, FP multiplier, FP finalAddition, FP finalScaler, FP equipAddValue, TSVector2 range)
		{
			return default(FP);
		}

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ExternalBuff> s_sharedBuffList;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FP[] s_multipliers;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static FP[] s_additions;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static FP[] s_finalAdditions;

		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static FP[] s_finalScalers;

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static FP[] s_finalEquipAdditions;

		// Token: 0x020004C1 RID: 1217
		[Token(Token = "0x20004C1")]
		public struct Input
		{
			// Token: 0x06004D88 RID: 19848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D88")]
			[Address(RVA = "0x1889800", Offset = "0x1888400", VA = "0x181889800")]
			public Input(PlayerCharacter playerChar)
			{
			}

			// Token: 0x06004D89 RID: 19849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D89")]
			[Address(RVA = "0x18895D0", Offset = "0x18881D0", VA = "0x1818895D0")]
			public Input(BattleLogger.CharInfo charInfo)
			{
			}

			// Token: 0x06004D8A RID: 19850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D8A")]
			[Address(RVA = "0x1889760", Offset = "0x1888360", VA = "0x181889760")]
			public Input(int iLevel, EvolvePhase iEvolvePhase, int iPotentialRank, int iFavorPoint, [Optional] List<CharacterData.UniqueEquipPair> equipQueries)
			{
			}

			// Token: 0x06004D8B RID: 19851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D8B")]
			[Address(RVA = "0x1889A80", Offset = "0x1888680", VA = "0x181889A80")]
			public Input(BattleCharacterData charBattleData)
			{
			}

			// Token: 0x06004D8C RID: 19852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D8C")]
			[Address(RVA = "0x18899D0", Offset = "0x18885D0", VA = "0x1818899D0")]
			public Input(CharacterInst.Metadata charMeta, CharacterData.UniqueEquipPair[] equipQueries)
			{
			}

			// Token: 0x06004D8D RID: 19853 RVA: 0x0002DA50 File Offset: 0x0002BC50
			[Token(Token = "0x6004D8D")]
			[Address(RVA = "0x1889AC0", Offset = "0x18886C0", VA = "0x181889AC0")]
			public static implicit operator AttributesCalculator.Input(PlayerCharacter playerChar)
			{
				return default(AttributesCalculator.Input);
			}

			// Token: 0x040011A4 RID: 4516
			[Token(Token = "0x40011A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EvolvePhase evolvePhase;

			// Token: 0x040011A5 RID: 4517
			[Token(Token = "0x40011A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int level;

			// Token: 0x040011A6 RID: 4518
			[Token(Token = "0x40011A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int potentialRank;

			// Token: 0x040011A7 RID: 4519
			[Token(Token = "0x40011A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int favorBattlePhase;

			// Token: 0x040011A8 RID: 4520
			[Token(Token = "0x40011A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<CharacterData.UniqueEquipPair> uniEquipQueries;
		}

		// Token: 0x020004C2 RID: 1218
		[Token(Token = "0x20004C2")]
		public class AttributeRawDelta
		{
			// Token: 0x06004D8E RID: 19854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004D8E")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public AttributeRawDelta(FP[] delta)
			{
			}

			// Token: 0x17000204 RID: 516
			[Token(Token = "0x17000204")]
			public FP this[AttributeType attributeType]
			{
				[Token(Token = "0x6004D8F")]
				[Address(RVA = "0x187C640", Offset = "0x187B240", VA = "0x18187C640")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x040011A9 RID: 4521
			[Token(Token = "0x40011A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private FP[] m_delta;
		}
	}
}
