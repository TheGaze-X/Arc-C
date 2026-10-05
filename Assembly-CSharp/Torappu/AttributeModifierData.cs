using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000ED2 RID: 3794
	[Token(Token = "0x2000ED2")]
	[Serializable]
	public class AttributeModifierData : IHotfixable
	{
		// Token: 0x06006BB2 RID: 27570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB2")]
		[Address(RVA = "0x1FFE8F0", Offset = "0x1FFD4F0", VA = "0x181FFE8F0")]
		public AttributeModifierData DeepClone()
		{
			return null;
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB3")]
		[Address(RVA = "0x1FFEDA0", Offset = "0x1FFD9A0", VA = "0x181FFEDA0")]
		public AttributeModifierData()
		{
		}

		// Token: 0x0400503C RID: 20540
		[Token(Token = "0x400503C")]
		[FieldOffset(Offset = "0x10")]
		public List<AbnormalFlag> abnormalFlags;

		// Token: 0x0400503D RID: 20541
		[Token(Token = "0x400503D")]
		[FieldOffset(Offset = "0x18")]
		public List<AbnormalFlag> abnormalImmunes;

		// Token: 0x0400503E RID: 20542
		[Token(Token = "0x400503E")]
		[FieldOffset(Offset = "0x20")]
		public List<AbnormalFlag> abnormalAntis;

		// Token: 0x0400503F RID: 20543
		[Token(Token = "0x400503F")]
		[FieldOffset(Offset = "0x28")]
		public List<AbnormalCombo> abnormalCombos;

		// Token: 0x04005040 RID: 20544
		[Token(Token = "0x4005040")]
		[FieldOffset(Offset = "0x30")]
		public List<AbnormalCombo> abnormalComboImmunes;

		// Token: 0x04005041 RID: 20545
		[Token(Token = "0x4005041")]
		[FieldOffset(Offset = "0x38")]
		public AttributeModifierData.AttributeModifier[] attributeModifiers;

		// Token: 0x04005042 RID: 20546
		[Token(Token = "0x4005042")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DeepClone;

		// Token: 0x04005043 RID: 20547
		[Token(Token = "0x4005043")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000ED3 RID: 3795
		[Token(Token = "0x2000ED3")]
		[Serializable]
		public class AttributeModifier : IHotfixable
		{
			// Token: 0x06006BB4 RID: 27572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006BB4")]
			[Address(RVA = "0x1FFEEF0", Offset = "0x1FFDAF0", VA = "0x181FFEEF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06006BB5 RID: 27573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006BB5")]
			[Address(RVA = "0x1FFEE00", Offset = "0x1FFDA00", VA = "0x181FFEE00")]
			public AttributeModifierData.AttributeModifier DeepClone()
			{
				return null;
			}

			// Token: 0x06006BB6 RID: 27574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BB6")]
			[Address(RVA = "0x1FFEFC0", Offset = "0x1FFDBC0", VA = "0x181FFEFC0")]
			public AttributeModifier()
			{
			}

			// Token: 0x06006BB7 RID: 27575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006BB7")]
			[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
			private string <>xLuaBaseProxy_ToString()
			{
				return null;
			}

			// Token: 0x04005044 RID: 20548
			[Token(Token = "0x4005044")]
			[FieldOffset(Offset = "0x10")]
			public AttributeType attributeType;

			// Token: 0x04005045 RID: 20549
			[Token(Token = "0x4005045")]
			[FieldOffset(Offset = "0x14")]
			public AttributeModifierData.AttributeModifier.FormulaItemType formulaItem;

			// Token: 0x04005046 RID: 20550
			[Token(Token = "0x4005046")]
			[FieldOffset(Offset = "0x18")]
			public float value;

			// Token: 0x04005047 RID: 20551
			[Token(Token = "0x4005047")]
			[FieldOffset(Offset = "0x1C")]
			public bool loadFromBlackboard;

			// Token: 0x04005048 RID: 20552
			[Token(Token = "0x4005048")]
			[FieldOffset(Offset = "0x1D")]
			public bool fetchBaseValueFromSourceEntity;

			// Token: 0x04005049 RID: 20553
			[Token(Token = "0x4005049")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ToString;

			// Token: 0x0400504A RID: 20554
			[Token(Token = "0x400504A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DeepClone;

			// Token: 0x0400504B RID: 20555
			[Token(Token = "0x400504B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02000ED4 RID: 3796
			[Token(Token = "0x2000ED4")]
			public enum FormulaItemType
			{
				// Token: 0x0400504D RID: 20557
				[Token(Token = "0x400504D")]
				ADDITION,
				// Token: 0x0400504E RID: 20558
				[Token(Token = "0x400504E")]
				MULTIPLIER,
				// Token: 0x0400504F RID: 20559
				[Token(Token = "0x400504F")]
				FINAL_ADDITION,
				// Token: 0x04005050 RID: 20560
				[Token(Token = "0x4005050")]
				FINAL_SCALER
			}
		}
	}
}
