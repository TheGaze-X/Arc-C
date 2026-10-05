using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Racing
{
	// Token: 0x02002974 RID: 10612
	[Token(Token = "0x2002974")]
	public class RacingAttributesData : IHotfixable
	{
		// Token: 0x060118F8 RID: 71928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118F8")]
		[Address(RVA = "0x95A170", Offset = "0x958D70", VA = "0x18095A170")]
		public RacingAttributesData()
		{
		}

		// Token: 0x060118F9 RID: 71929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118F9")]
		[Address(RVA = "0x95A060", Offset = "0x958C60", VA = "0x18095A060")]
		public RacingAttributesData(RacingEnemyData rawData)
		{
		}

		// Token: 0x060118FA RID: 71930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118FA")]
		[Address(RVA = "0x958A10", Offset = "0x957610", VA = "0x180958A10")]
		public void RegisterModifiersFromBB(Blackboard blackboard, Buff source)
		{
		}

		// Token: 0x060118FB RID: 71931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118FB")]
		[Address(RVA = "0x959410", Offset = "0x958010", VA = "0x180959410")]
		public void Reset(RacingEnemyData rawData)
		{
		}

		// Token: 0x060118FC RID: 71932 RVA: 0x0006BE50 File Offset: 0x0006A050
		[Token(Token = "0x60118FC")]
		[Address(RVA = "0x958910", Offset = "0x957510", VA = "0x180958910")]
		public FP GetValue(RacingAttribute attributeType)
		{
			return default(FP);
		}

		// Token: 0x060118FD RID: 71933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118FD")]
		[Address(RVA = "0x958800", Offset = "0x957400", VA = "0x180958800")]
		public void AddModifier(RacingAttributesData.RacingAttributeModifier modifier)
		{
		}

		// Token: 0x060118FE RID: 71934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118FE")]
		[Address(RVA = "0x959300", Offset = "0x957F00", VA = "0x180959300")]
		public void RemoveModifier(RacingAttributesData.RacingAttributeModifier modifier)
		{
		}

		// Token: 0x060118FF RID: 71935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118FF")]
		[Address(RVA = "0x959790", Offset = "0x958390", VA = "0x180959790")]
		public void UpdateModifiers()
		{
		}

		// Token: 0x06011900 RID: 71936 RVA: 0x0006BE68 File Offset: 0x0006A068
		[Token(Token = "0x6011900")]
		[Address(RVA = "0x959970", Offset = "0x958570", VA = "0x180959970")]
		private FP _CalculateAttributeValue(RacingAttribute attributeType)
		{
			return default(FP);
		}

		// Token: 0x040139FB RID: 80379
		[Token(Token = "0x40139FB")]
		[FieldOffset(Offset = "0x0")]
		private static List<RacingAttributesData.RacingAttributeModifier> s_sharedModifiers;

		// Token: 0x040139FC RID: 80380
		[Token(Token = "0x40139FC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<RacingAttribute, Vector2> s_attributeRanges;

		// Token: 0x040139FD RID: 80381
		[Token(Token = "0x40139FD")]
		[FieldOffset(Offset = "0x10")]
		private int m_dirtyMask;

		// Token: 0x040139FE RID: 80382
		[Token(Token = "0x40139FE")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<RacingAttributesData.RacingAttributeModifier>[] m_attributeModifiers;

		// Token: 0x040139FF RID: 80383
		[Token(Token = "0x40139FF")]
		[FieldOffset(Offset = "0x20")]
		private ObscuredFP[] m_rawData;

		// Token: 0x04013A00 RID: 80384
		[Token(Token = "0x4013A00")]
		[FieldOffset(Offset = "0x28")]
		private ObscuredFP[] m_cachedData;

		// Token: 0x04013A01 RID: 80385
		[Token(Token = "0x4013A01")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013A02 RID: 80386
		[Token(Token = "0x4013A02")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04013A03 RID: 80387
		[Token(Token = "0x4013A03")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterModifiersFromBB;

		// Token: 0x04013A04 RID: 80388
		[Token(Token = "0x4013A04")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04013A05 RID: 80389
		[Token(Token = "0x4013A05")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04013A06 RID: 80390
		[Token(Token = "0x4013A06")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AddModifier;

		// Token: 0x04013A07 RID: 80391
		[Token(Token = "0x4013A07")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RemoveModifier;

		// Token: 0x04013A08 RID: 80392
		[Token(Token = "0x4013A08")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateModifiers;

		// Token: 0x04013A09 RID: 80393
		[Token(Token = "0x4013A09")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CalculateAttributeValue;

		// Token: 0x02002975 RID: 10613
		[Token(Token = "0x2002975")]
		public struct RacingAttributeModifier
		{
			// Token: 0x170026C3 RID: 9923
			// (get) Token: 0x06011902 RID: 71938 RVA: 0x0006BE80 File Offset: 0x0006A080
			[Token(Token = "0x170026C3")]
			public bool isValid
			{
				[Token(Token = "0x6011902")]
				[Address(RVA = "0x958780", Offset = "0x957380", VA = "0x180958780")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06011903 RID: 71939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011903")]
			[Address(RVA = "0x9586F0", Offset = "0x9572F0", VA = "0x1809586F0")]
			public RacingAttributeModifier(RacingAttribute type, AttributeModifierData.AttributeModifier.FormulaItemType item, FP val, Buff src)
			{
			}

			// Token: 0x04013A0A RID: 80394
			[Token(Token = "0x4013A0A")]
			[FieldOffset(Offset = "0x0")]
			public RacingAttribute racingAttributeType;

			// Token: 0x04013A0B RID: 80395
			[Token(Token = "0x4013A0B")]
			[FieldOffset(Offset = "0x4")]
			public AttributeModifierData.AttributeModifier.FormulaItemType formulaItem;

			// Token: 0x04013A0C RID: 80396
			[Token(Token = "0x4013A0C")]
			[FieldOffset(Offset = "0x8")]
			public FP value;

			// Token: 0x04013A0D RID: 80397
			[Token(Token = "0x4013A0D")]
			[FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ObjectPtr<Buff> source;
		}
	}
}
