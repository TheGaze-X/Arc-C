using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002164 RID: 8548
	[Token(Token = "0x2002164")]
	public class Attributes
	{
		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x0600D267 RID: 53863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001941")]
		public ObscuredFP[] rawData
		{
			[Token(Token = "0x600D267")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D268")]
		[Address(RVA = "0x352AC70", Offset = "0x3529870", VA = "0x18352AC70")]
		public Attributes()
		{
		}

		// Token: 0x0600D269 RID: 53865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D269")]
		[Address(RVA = "0x352AE70", Offset = "0x3529A70", VA = "0x18352AE70")]
		public Attributes(AttributesData rawData)
		{
		}

		// Token: 0x0600D26A RID: 53866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D26A")]
		[Address(RVA = "0x3529D40", Offset = "0x3528940", VA = "0x183529D40")]
		public void Reset(AttributesData rawData)
		{
		}

		// Token: 0x0600D26B RID: 53867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D26B")]
		[Address(RVA = "0x3529A20", Offset = "0x3528620", VA = "0x183529A20")]
		public void OverwriteRawData(AttributeType attributeType, FP rawValue, bool refresh)
		{
		}

		// Token: 0x0600D26C RID: 53868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D26C")]
		[Address(RVA = "0x3529590", Offset = "0x3528190", VA = "0x183529590")]
		public void OverrideDataRange(AttributeType attributeType, FP? min, FP? max, bool refresh = true)
		{
		}

		// Token: 0x0600D26D RID: 53869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D26D")]
		[Address(RVA = "0x35285B0", Offset = "0x35271B0", VA = "0x1835285B0")]
		public void ClearDataRangeOverride(AttributeType attributeType, bool refresh = true)
		{
		}

		// Token: 0x0600D26E RID: 53870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D26E")]
		[Address(RVA = "0x3529780", Offset = "0x3528380", VA = "0x183529780")]
		public void OverwriteAllAttributesRawData(AttributesData attributesData, bool refresh)
		{
		}

		// Token: 0x0600D26F RID: 53871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D26F")]
		[Address(RVA = "0x3528290", Offset = "0x3526E90", VA = "0x183528290")]
		public void AddModifier(Attributes.IAttributesModifier modifier)
		{
		}

		// Token: 0x0600D270 RID: 53872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D270")]
		[Address(RVA = "0x3529B00", Offset = "0x3528700", VA = "0x183529B00")]
		public void RemoveModifier(Attributes.IAttributesModifier modifier)
		{
		}

		// Token: 0x0600D271 RID: 53873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D271")]
		[Address(RVA = "0x35281A0", Offset = "0x3526DA0", VA = "0x1835281A0")]
		public void AddModifierToSingleAttribute(Attributes.IAttributesModifier modifier, AttributeType attributeType)
		{
		}

		// Token: 0x0600D272 RID: 53874 RVA: 0x0004BC90 File Offset: 0x00049E90
		[Token(Token = "0x600D272")]
		[Address(RVA = "0x3529300", Offset = "0x3527F00", VA = "0x183529300")]
		public FP GetValue(AttributeType attributeType)
		{
			return default(FP);
		}

		// Token: 0x0600D273 RID: 53875 RVA: 0x0004BCA8 File Offset: 0x00049EA8
		[Token(Token = "0x600D273")]
		[Address(RVA = "0x3529200", Offset = "0x3527E00", VA = "0x183529200")]
		public FP GetRawValue(AttributeType attributeType)
		{
			return default(FP);
		}

		// Token: 0x0600D274 RID: 53876 RVA: 0x0004BCC0 File Offset: 0x00049EC0
		[Token(Token = "0x600D274")]
		[Address(RVA = "0x3529290", Offset = "0x3527E90", VA = "0x183529290")]
		public int GetValueRoundToInt(AttributeType attributeType)
		{
			return 0;
		}

		// Token: 0x0600D275 RID: 53877 RVA: 0x0004BCD8 File Offset: 0x00049ED8
		[Token(Token = "0x600D275")]
		[Address(RVA = "0x3528EF0", Offset = "0x3527AF0", VA = "0x183528EF0")]
		public bool GetAbnormalFlag(AbnormalFlag abnormalFlag)
		{
			return default(bool);
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x0004BCF0 File Offset: 0x00049EF0
		[Token(Token = "0x600D276")]
		[Address(RVA = "0x3528FD0", Offset = "0x3527BD0", VA = "0x183528FD0")]
		public bool GetAbnormalImmune(AbnormalFlag abnormalFlag)
		{
			return default(bool);
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x0004BD08 File Offset: 0x00049F08
		[Token(Token = "0x600D277")]
		[Address(RVA = "0x3528A00", Offset = "0x3527600", VA = "0x183528A00")]
		public bool GetAbnormalCombo(AbnormalCombo abnormalCombo)
		{
			return default(bool);
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x0004BD20 File Offset: 0x00049F20
		[Token(Token = "0x600D278")]
		[Address(RVA = "0x3528990", Offset = "0x3527590", VA = "0x183528990")]
		public bool GetAbnormalAnti(AbnormalFlag abnormalFlag)
		{
			return default(bool);
		}

		// Token: 0x0600D279 RID: 53881 RVA: 0x0004BD38 File Offset: 0x00049F38
		[Token(Token = "0x600D279")]
		[Address(RVA = "0x3528CD0", Offset = "0x35278D0", VA = "0x183528CD0")]
		public bool GetAbnormalFlagWithImmune(AbnormalFlag abnormalFlag, AbnormalFlag abnormalImmune, AbnormalCombo abnormalComboImmune)
		{
			return default(bool);
		}

		// Token: 0x0600D27A RID: 53882 RVA: 0x0004BD50 File Offset: 0x00049F50
		[Token(Token = "0x600D27A")]
		[Address(RVA = "0x3528C50", Offset = "0x3527850", VA = "0x183528C50")]
		public bool GetAbnormalFlagWithImmuneFlag(AbnormalFlag abnormalFlag, AbnormalFlag abnormalImmune)
		{
			return default(bool);
		}

		// Token: 0x0600D27B RID: 53883 RVA: 0x0004BD68 File Offset: 0x00049F68
		[Token(Token = "0x600D27B")]
		[Address(RVA = "0x3528AA0", Offset = "0x35276A0", VA = "0x183528AA0")]
		public bool GetAbnormalFlagWithImmuneCombo(AbnormalFlag abnormalFlag, AbnormalCombo abnormalComboImmune)
		{
			return default(bool);
		}

		// Token: 0x0600D27C RID: 53884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D27C")]
		[Address(RVA = "0x35293E0", Offset = "0x3527FE0", VA = "0x1835293E0")]
		public void MarkAttributeDirty(AttributeType attributeType)
		{
		}

		// Token: 0x0600D27D RID: 53885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D27D")]
		[Address(RVA = "0x35294C0", Offset = "0x35280C0", VA = "0x1835294C0")]
		public void MarkAttributesDirty(long attributeMask)
		{
		}

		// Token: 0x0600D27E RID: 53886 RVA: 0x0004BD80 File Offset: 0x00049F80
		[Token(Token = "0x600D27E")]
		[Address(RVA = "0x3528540", Offset = "0x3527140", VA = "0x183528540")]
		public bool CheckAbnormalImmune(AbnormalFlag abnormalFlag)
		{
			return default(bool);
		}

		// Token: 0x0600D27F RID: 53887 RVA: 0x0004BD98 File Offset: 0x00049F98
		[Token(Token = "0x600D27F")]
		[Address(RVA = "0x35284D0", Offset = "0x35270D0", VA = "0x1835284D0")]
		public bool CheckAbnormalComboImmune(AbnormalCombo abnormalCombo)
		{
			return default(bool);
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D280")]
		[Address(RVA = "0x3528660", Offset = "0x3527260", VA = "0x183528660")]
		public AttributesData Dump()
		{
			return null;
		}

		// Token: 0x0600D281 RID: 53889 RVA: 0x0004BDB0 File Offset: 0x00049FB0
		[Token(Token = "0x600D281")]
		[Address(RVA = "0x352A5B0", Offset = "0x35291B0", VA = "0x18352A5B0")]
		private FP _CalculateAttributeValue(AttributeType attributeType)
		{
			return default(FP);
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x0004BDC8 File Offset: 0x00049FC8
		[Token(Token = "0x600D282")]
		[Address(RVA = "0x3529120", Offset = "0x3527D20", VA = "0x183529120")]
		private FP GetMinValue(AttributeType attributeType)
		{
			return default(FP);
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x0004BDE0 File Offset: 0x00049FE0
		[Token(Token = "0x600D283")]
		[Address(RVA = "0x3529040", Offset = "0x3527C40", VA = "0x183529040")]
		private FP GetMaxValue(AttributeType attributeType)
		{
			return default(FP);
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D284")]
		[Address(RVA = "0x352AC50", Offset = "0x3529850", VA = "0x18352AC50")]
		private void _MarkAbnormalFlagDirty(AbnormalFlag abnormalFlag)
		{
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D285")]
		[Address(RVA = "0x352AC30", Offset = "0x3529830", VA = "0x18352AC30")]
		private void _MarkAbnormalComboDirty(AbnormalCombo abnormalCombo)
		{
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D286")]
		[Address(RVA = "0x352A3B0", Offset = "0x3528FB0", VA = "0x18352A3B0")]
		private void _CalculateAbnormalDirtyByModifier(Attributes.IAttributesModifier modifier)
		{
		}

		// Token: 0x0400E0CF RID: 57551
		[Token(Token = "0x400E0CF")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<Attributes.IAttributesModifier> m_abnormalFlagModifiers;

		// Token: 0x0400E0D0 RID: 57552
		[Token(Token = "0x400E0D0")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<Attributes.IAttributesModifier>[] m_attributeModifiers;

		// Token: 0x0400E0D1 RID: 57553
		[Token(Token = "0x400E0D1")]
		[FieldOffset(Offset = "0x20")]
		private short[] m_abnormalFlagsCounter;

		// Token: 0x0400E0D2 RID: 57554
		[Token(Token = "0x400E0D2")]
		[FieldOffset(Offset = "0x28")]
		private short[] m_abnormalImmuneCounter;

		// Token: 0x0400E0D3 RID: 57555
		[Token(Token = "0x400E0D3")]
		[FieldOffset(Offset = "0x30")]
		private short[] m_abnormalAntiCounter;

		// Token: 0x0400E0D4 RID: 57556
		[Token(Token = "0x400E0D4")]
		[FieldOffset(Offset = "0x38")]
		private Attributes.AbnormalComboManager m_abnormalComboMgr;

		// Token: 0x0400E0D5 RID: 57557
		[Token(Token = "0x400E0D5")]
		[FieldOffset(Offset = "0x40")]
		private ObscuredFP[] m_rawData;

		// Token: 0x0400E0D6 RID: 57558
		[Token(Token = "0x400E0D6")]
		[FieldOffset(Offset = "0x48")]
		private TSVector2[] m_dataRange;

		// Token: 0x0400E0D7 RID: 57559
		[Token(Token = "0x400E0D7")]
		[FieldOffset(Offset = "0x50")]
		private ObscuredFP[] m_cachedData;

		// Token: 0x0400E0D8 RID: 57560
		[Token(Token = "0x400E0D8")]
		[FieldOffset(Offset = "0x58")]
		private TSVector2?[] m_overrideDataRange;

		// Token: 0x0400E0D9 RID: 57561
		[Token(Token = "0x400E0D9")]
		[FieldOffset(Offset = "0x60")]
		private long m_dirtyMask;

		// Token: 0x0400E0DA RID: 57562
		[Token(Token = "0x400E0DA")]
		[FieldOffset(Offset = "0x68")]
		public Action<AttributeType, FP> onAttributeMarkedDirty;

		// Token: 0x0400E0DB RID: 57563
		[Token(Token = "0x400E0DB")]
		[FieldOffset(Offset = "0x70")]
		public Action<AbnormalFlag> onAbnormalFlagDirty;

		// Token: 0x0400E0DC RID: 57564
		[Token(Token = "0x400E0DC")]
		[FieldOffset(Offset = "0x78")]
		public Action<AbnormalCombo> onAbnormalComboDirty;

		// Token: 0x02002165 RID: 8549
		[Token(Token = "0x2002165")]
		public interface IAttributesModifier
		{
			// Token: 0x17001942 RID: 6466
			// (get) Token: 0x0600D287 RID: 53895
			[Token(Token = "0x17001942")]
			long attributeMask { [Token(Token = "0x600D287")] get; }

			// Token: 0x17001943 RID: 6467
			// (get) Token: 0x0600D288 RID: 53896
			[Token(Token = "0x17001943")]
			long abnormalFlagMask { [Token(Token = "0x600D288")] get; }

			// Token: 0x17001944 RID: 6468
			// (get) Token: 0x0600D289 RID: 53897
			[Token(Token = "0x17001944")]
			long abnormalImmuneMask { [Token(Token = "0x600D289")] get; }

			// Token: 0x17001945 RID: 6469
			// (get) Token: 0x0600D28A RID: 53898
			[Token(Token = "0x17001945")]
			long abnormalAntiMask { [Token(Token = "0x600D28A")] get; }

			// Token: 0x17001946 RID: 6470
			// (get) Token: 0x0600D28B RID: 53899
			[Token(Token = "0x17001946")]
			long abnormalComboMask { [Token(Token = "0x600D28B")] get; }

			// Token: 0x17001947 RID: 6471
			// (get) Token: 0x0600D28C RID: 53900
			[Token(Token = "0x17001947")]
			long abnormalComboImmuneMask { [Token(Token = "0x600D28C")] get; }

			// Token: 0x0600D28D RID: 53901
			[Token(Token = "0x600D28D")]
			bool GetValue(AttributeType attributeType, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler);
		}

		// Token: 0x02002166 RID: 8550
		[Token(Token = "0x2002166")]
		private class AbnormalComboManager
		{
			// Token: 0x0600D28E RID: 53902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D28E")]
			[Address(RVA = "0x35249C0", Offset = "0x35235C0", VA = "0x1835249C0")]
			public void Reset()
			{
			}

			// Token: 0x0600D28F RID: 53903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D28F")]
			[Address(RVA = "0x3524860", Offset = "0x3523460", VA = "0x183524860")]
			public void PushMask(long comboMask, long immuneMask)
			{
			}

			// Token: 0x0600D290 RID: 53904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D290")]
			[Address(RVA = "0x3524700", Offset = "0x3523300", VA = "0x183524700")]
			public void PopMask(long comboMask, long immuneMask)
			{
			}

			// Token: 0x0600D291 RID: 53905 RVA: 0x0004BDF8 File Offset: 0x00049FF8
			[Token(Token = "0x600D291")]
			[Address(RVA = "0x3524610", Offset = "0x3523210", VA = "0x183524610")]
			public bool GetAbnormalFlag(AbnormalFlag abnormalFlag)
			{
				return default(bool);
			}

			// Token: 0x0600D292 RID: 53906 RVA: 0x0004BE10 File Offset: 0x0004A010
			[Token(Token = "0x600D292")]
			[Address(RVA = "0x35244D0", Offset = "0x35230D0", VA = "0x1835244D0")]
			public bool GetAbnormalFlagWithImmuneComboFlag(AbnormalFlag abnormalFlag, AbnormalCombo abnormalComboImmune)
			{
				return default(bool);
			}

			// Token: 0x0600D293 RID: 53907 RVA: 0x0004BE28 File Offset: 0x0004A028
			[Token(Token = "0x600D293")]
			[Address(RVA = "0x3524670", Offset = "0x3523270", VA = "0x183524670")]
			public bool GetComboFlag(AbnormalCombo abnormalCombo)
			{
				return default(bool);
			}

			// Token: 0x0600D294 RID: 53908 RVA: 0x0004BE40 File Offset: 0x0004A040
			[Token(Token = "0x600D294")]
			[Address(RVA = "0x3524460", Offset = "0x3523060", VA = "0x183524460")]
			public bool CheckAbnormalComboImmune(AbnormalCombo abnormalCombo)
			{
				return default(bool);
			}

			// Token: 0x0600D295 RID: 53909 RVA: 0x0004BE58 File Offset: 0x0004A058
			[Token(Token = "0x600D295")]
			[Address(RVA = "0x3524AD0", Offset = "0x35236D0", VA = "0x183524AD0")]
			private bool _UpdateAbnormalCombo(int index, long pow2Mask)
			{
				return default(bool);
			}

			// Token: 0x0600D296 RID: 53910 RVA: 0x0004BE70 File Offset: 0x0004A070
			[Token(Token = "0x600D296")]
			[Address(RVA = "0x3524A20", Offset = "0x3523620", VA = "0x183524A20")]
			private long _GenerateAbnormalFlagMaskFromComboMask(long abnormalComboMask)
			{
				return 0L;
			}

			// Token: 0x0600D297 RID: 53911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D297")]
			[Address(RVA = "0x3524C00", Offset = "0x3523800", VA = "0x183524C00")]
			public AbnormalComboManager()
			{
			}

			// Token: 0x0400E0DD RID: 57565
			[Token(Token = "0x400E0DD")]
			[FieldOffset(Offset = "0x0")]
			private static readonly long[] ABNORMAL_COMBO_TO_FLAG_MASK;

			// Token: 0x0400E0DE RID: 57566
			[Token(Token = "0x400E0DE")]
			[FieldOffset(Offset = "0x10")]
			private short[] m_abnormalComboCounter;

			// Token: 0x0400E0DF RID: 57567
			[Token(Token = "0x400E0DF")]
			[FieldOffset(Offset = "0x18")]
			private short[] m_abnormalComboImmuneCounter;

			// Token: 0x0400E0E0 RID: 57568
			[Token(Token = "0x400E0E0")]
			[FieldOffset(Offset = "0x20")]
			private long m_abnormalComboMask;

			// Token: 0x0400E0E1 RID: 57569
			[Token(Token = "0x400E0E1")]
			[FieldOffset(Offset = "0x28")]
			private long m_abnormalFlagMask;
		}
	}
}
