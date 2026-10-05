using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002622 RID: 9762
	[Token(Token = "0x2002622")]
	public class UnitDataFlowConfig : MonoBehaviour
	{
		// Token: 0x0600FFA0 RID: 65440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFA0")]
		[Address(RVA = "0x786330", Offset = "0x784F30", VA = "0x180786330")]
		public void Init(BattleCharacterData dataSource, Dictionary<string, TalentData> talentMap)
		{
		}

		// Token: 0x0600FFA1 RID: 65441 RVA: 0x00061218 File Offset: 0x0005F418
		[Token(Token = "0x600FFA1")]
		[Address(RVA = "0x786090", Offset = "0x784C90", VA = "0x180786090")]
		public UnitDataFlowConfig.Delta GetDelta(Blackboard blackboardSource, UnitDataFlowConfig.DataType target, [Optional] string talentKey)
		{
			return default(UnitDataFlowConfig.Delta);
		}

		// Token: 0x0600FFA2 RID: 65442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFA2")]
		[Address(RVA = "0x786510", Offset = "0x785110", VA = "0x180786510")]
		public UnitDataFlowConfig()
		{
		}

		// Token: 0x04011BE6 RID: 72678
		[Token(Token = "0x4011BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnitDataFlowConfig.ModifierConfig[] _config;

		// Token: 0x04011BE7 RID: 72679
		[Token(Token = "0x4011BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<UnitDataFlowConfig.Modifier> m_modifiers;

		// Token: 0x02002623 RID: 9763
		[Token(Token = "0x2002623")]
		public enum ModifyType
		{
			// Token: 0x04011BE9 RID: 72681
			[Token(Token = "0x4011BE9")]
			ASSIGN,
			// Token: 0x04011BEA RID: 72682
			[Token(Token = "0x4011BEA")]
			ADDITION,
			// Token: 0x04011BEB RID: 72683
			[Token(Token = "0x4011BEB")]
			MULTIPLIER,
			// Token: 0x04011BEC RID: 72684
			[Token(Token = "0x4011BEC")]
			SCALE_TO_ONE,
			// Token: 0x04011BED RID: 72685
			[Token(Token = "0x4011BED")]
			ASSIGN_STR
		}

		// Token: 0x02002624 RID: 9764
		[Token(Token = "0x2002624")]
		public enum DataType
		{
			// Token: 0x04011BEF RID: 72687
			[Token(Token = "0x4011BEF")]
			TALENT,
			// Token: 0x04011BF0 RID: 72688
			[Token(Token = "0x4011BF0")]
			SKILL,
			// Token: 0x04011BF1 RID: 72689
			[Token(Token = "0x4011BF1")]
			TRAIT
		}

		// Token: 0x02002625 RID: 9765
		[Token(Token = "0x2002625")]
		public enum FormulaType
		{
			// Token: 0x04011BF3 RID: 72691
			[Token(Token = "0x4011BF3")]
			TWO,
			// Token: 0x04011BF4 RID: 72692
			[Token(Token = "0x4011BF4")]
			THREE
		}

		// Token: 0x02002626 RID: 9766
		[Token(Token = "0x2002626")]
		public struct Modifier
		{
			// Token: 0x0600FFA3 RID: 65443 RVA: 0x00061230 File Offset: 0x0005F430
			[Token(Token = "0x600FFA3")]
			[Address(RVA = "0x781D10", Offset = "0x780910", VA = "0x180781D10")]
			public bool IsNull()
			{
				return default(bool);
			}

			// Token: 0x0600FFA4 RID: 65444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFA4")]
			[Address(RVA = "0x781D40", Offset = "0x780940", VA = "0x180781D40")]
			private void _ModifyBlackboard(ref UnitDataFlowConfig.Delta result, Blackboard blackboard, UnitDataFlowConfig.DataType target)
			{
			}

			// Token: 0x0600FFA5 RID: 65445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFA5")]
			[Address(RVA = "0x781C80", Offset = "0x780880", VA = "0x180781C80")]
			public void Execute(ref UnitDataFlowConfig.Delta result, Blackboard blackboard, UnitDataFlowConfig.DataType target)
			{
			}

			// Token: 0x04011BF5 RID: 72693
			[Token(Token = "0x4011BF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UnitDataFlowConfig.FormulaType formulaType;

			// Token: 0x04011BF6 RID: 72694
			[Token(Token = "0x4011BF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public UnitDataFlowConfig.DataType target;

			// Token: 0x04011BF7 RID: 72695
			[Token(Token = "0x4011BF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string targetKey;

			// Token: 0x04011BF8 RID: 72696
			[Token(Token = "0x4011BF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string targetTalentKey;

			// Token: 0x04011BF9 RID: 72697
			[Token(Token = "0x4011BF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnitDataFlowConfig.ModifyType modifyType;

			// Token: 0x04011BFA RID: 72698
			[Token(Token = "0x4011BFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float modifyValue;

			// Token: 0x04011BFB RID: 72699
			[Token(Token = "0x4011BFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float modifyValue2;

			// Token: 0x04011BFC RID: 72700
			[Token(Token = "0x4011BFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string modifyValueStr;

			// Token: 0x04011BFD RID: 72701
			[Token(Token = "0x4011BFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string rangeId;

			// Token: 0x04011BFE RID: 72702
			[Token(Token = "0x4011BFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UnitDataFlowConfig.Modifier NULL;
		}

		// Token: 0x02002627 RID: 9767
		[Token(Token = "0x2002627")]
		public struct Delta
		{
			// Token: 0x0600FFA7 RID: 65447 RVA: 0x00061248 File Offset: 0x0005F448
			[Token(Token = "0x600FFA7")]
			[Address(RVA = "0x77B340", Offset = "0x779F40", VA = "0x18077B340")]
			public bool IsNull()
			{
				return default(bool);
			}

			// Token: 0x04011BFF RID: 72703
			[Token(Token = "0x4011BFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Blackboard blackboard;

			// Token: 0x04011C00 RID: 72704
			[Token(Token = "0x4011C00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string rangeId;

			// Token: 0x04011C01 RID: 72705
			[Token(Token = "0x4011C01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UnitDataFlowConfig.Delta NULL;
		}

		// Token: 0x02002628 RID: 9768
		[Token(Token = "0x2002628")]
		[Serializable]
		public class ModifierConfig
		{
			// Token: 0x170022DD RID: 8925
			// (get) Token: 0x0600FFA9 RID: 65449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170022DD")]
			private HelpItem helpInfo
			{
				[Token(Token = "0x600FFA9")]
				[Address(RVA = "0x780AA0", Offset = "0x77F6A0", VA = "0x180780AA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170022DE RID: 8926
			// (get) Token: 0x0600FFAA RID: 65450 RVA: 0x00061260 File Offset: 0x0005F460
			[Token(Token = "0x170022DE")]
			private bool ValidateSkillIndices
			{
				[Token(Token = "0x600FFAA")]
				[Address(RVA = "0x780A90", Offset = "0x77F690", VA = "0x180780A90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170022DF RID: 8927
			// (get) Token: 0x0600FFAB RID: 65451 RVA: 0x00061278 File Offset: 0x0005F478
			[Token(Token = "0x170022DF")]
			private bool IsFormulaType3
			{
				[Token(Token = "0x600FFAB")]
				[Address(RVA = "0x4E8070", Offset = "0x4E6C70", VA = "0x1804E8070")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170022E0 RID: 8928
			// (get) Token: 0x0600FFAC RID: 65452 RVA: 0x00061290 File Offset: 0x0005F490
			[Token(Token = "0x170022E0")]
			private bool IsTalentSource
			{
				[Token(Token = "0x600FFAC")]
				[Address(RVA = "0x780A70", Offset = "0x77F670", VA = "0x180780A70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170022E1 RID: 8929
			// (get) Token: 0x0600FFAD RID: 65453 RVA: 0x000612A8 File Offset: 0x0005F4A8
			[Token(Token = "0x170022E1")]
			private bool IsTalentSource2
			{
				[Token(Token = "0x600FFAD")]
				[Address(RVA = "0x780A50", Offset = "0x77F650", VA = "0x180780A50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170022E2 RID: 8930
			// (get) Token: 0x0600FFAE RID: 65454 RVA: 0x000612C0 File Offset: 0x0005F4C0
			[Token(Token = "0x170022E2")]
			private bool IsTalentTarget
			{
				[Token(Token = "0x600FFAE")]
				[Address(RVA = "0x780A80", Offset = "0x77F680", VA = "0x180780A80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600FFAF RID: 65455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFAF")]
			[Address(RVA = "0x780920", Offset = "0x77F520", VA = "0x180780920")]
			private void GetSource(UnitDataFlowConfig.DataType dataType, BattleCharacterData dataSource, Dictionary<string, TalentData> talentMap, ref Blackboard blackboard, ref string rangeIdToOverride, string sourceTalentKey)
			{
			}

			// Token: 0x0600FFB0 RID: 65456 RVA: 0x000612D8 File Offset: 0x0005F4D8
			[Token(Token = "0x600FFB0")]
			[Address(RVA = "0x7802E0", Offset = "0x77EEE0", VA = "0x1807802E0")]
			public UnitDataFlowConfig.Modifier CreateModifier(BattleCharacterData dataSource, Dictionary<string, TalentData> talentMap)
			{
				return default(UnitDataFlowConfig.Modifier);
			}

			// Token: 0x0600FFB1 RID: 65457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFB1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ModifierConfig()
			{
			}

			// Token: 0x04011C02 RID: 72706
			[Token(Token = "0x4011C02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private UnitDataFlowConfig.FormulaType _formulaType;

			// Token: 0x04011C03 RID: 72707
			[Token(Token = "0x4011C03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private bool _acceptEmptyBB;

			// Token: 0x04011C04 RID: 72708
			[Token(Token = "0x4011C04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[SerializeField]
			private bool _validateSkillIndices;

			// Token: 0x04011C05 RID: 72709
			[Token(Token = "0x4011C05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Inspect("ValidateSkillIndices")]
			private int[] _skillIndices;

			// Token: 0x04011C06 RID: 72710
			[Token(Token = "0x4011C06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Space]
			private UnitDataFlowConfig.DataType _source;

			// Token: 0x04011C07 RID: 72711
			[Token(Token = "0x4011C07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Inspect("IsTalentSource")]
			private string _sourceTalentKey;

			// Token: 0x04011C08 RID: 72712
			[Token(Token = "0x4011C08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private string _sourceKey;

			// Token: 0x04011C09 RID: 72713
			[Token(Token = "0x4011C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			[Space]
			[Inspect("IsFormulaType3")]
			private UnitDataFlowConfig.DataType _source2;

			// Token: 0x04011C0A RID: 72714
			[Token(Token = "0x4011C0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			[Inspect("IsTalentSource2")]
			private string _sourceTalentKey2;

			// Token: 0x04011C0B RID: 72715
			[Token(Token = "0x4011C0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[SerializeField]
			[Inspect("IsFormulaType3")]
			private string _sourceKey2;

			// Token: 0x04011C0C RID: 72716
			[Token(Token = "0x4011C0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[SerializeField]
			[Space]
			private UnitDataFlowConfig.DataType _target;

			// Token: 0x04011C0D RID: 72717
			[Token(Token = "0x4011C0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[SerializeField]
			[Inspect("IsTalentTarget")]
			private string _targetTalentKey;

			// Token: 0x04011C0E RID: 72718
			[Token(Token = "0x4011C0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[SerializeField]
			private string _targetKey;

			// Token: 0x04011C0F RID: 72719
			[Token(Token = "0x4011C0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[SerializeField]
			[Space]
			private bool _overrideRangeId;

			// Token: 0x04011C10 RID: 72720
			[Token(Token = "0x4011C10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[SerializeField]
			[Help("helpInfo")]
			private UnitDataFlowConfig.ModifyType _type;
		}
	}
}
