using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024A3 RID: 9379
	[Token(Token = "0x20024A3")]
	[RequireComponent(typeof(Ability))]
	public class Talent : BasicTalent
	{
		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x0600F112 RID: 61714 RVA: 0x00058C68 File Offset: 0x00056E68
		[Token(Token = "0x17001F4E")]
		public override bool attachInDummy
		{
			[Token(Token = "0x600F112")]
			[Address(RVA = "0x6983C0", Offset = "0x696FC0", VA = "0x1806983C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x0600F113 RID: 61715 RVA: 0x00058C80 File Offset: 0x00056E80
		[Token(Token = "0x17001F4F")]
		public override bool affectWhenNotRootTalent
		{
			[Token(Token = "0x600F113")]
			[Address(RVA = "0x697F70", Offset = "0x696B70", VA = "0x180697F70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600F114 RID: 61716 RVA: 0x00058C98 File Offset: 0x00056E98
		[Token(Token = "0x17001F50")]
		public override bool overrideDefaultRangeId
		{
			[Token(Token = "0x600F114")]
			[Address(RVA = "0x698480", Offset = "0x697080", VA = "0x180698480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600F115 RID: 61717 RVA: 0x00058CB0 File Offset: 0x00056EB0
		[Token(Token = "0x17001F51")]
		public override bool applyTalentScale
		{
			[Token(Token = "0x600F115")]
			[Address(RVA = "0x698200", Offset = "0x696E00", VA = "0x180698200", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x0600F116 RID: 61718 RVA: 0x00058CC8 File Offset: 0x00056EC8
		[Token(Token = "0x17001F52")]
		public bool scaleCertainMode
		{
			[Token(Token = "0x600F116")]
			[Address(RVA = "0x6985A0", Offset = "0x6971A0", VA = "0x1806985A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x0600F117 RID: 61719 RVA: 0x00058CE0 File Offset: 0x00056EE0
		[Token(Token = "0x17001F53")]
		public override int defaultModeIndex
		{
			[Token(Token = "0x600F117")]
			[Address(RVA = "0x698420", Offset = "0x697020", VA = "0x180698420", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x0600F118 RID: 61720 RVA: 0x00058CF8 File Offset: 0x00056EF8
		[Token(Token = "0x17001F54")]
		public override bool scaleCertainKeyFlag
		{
			[Token(Token = "0x600F118")]
			[Address(RVA = "0x6984E0", Offset = "0x6970E0", VA = "0x1806984E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x0600F119 RID: 61721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F55")]
		protected override string[] scaleCertainKeyList
		{
			[Token(Token = "0x600F119")]
			[Address(RVA = "0x698540", Offset = "0x697140", VA = "0x180698540", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x0600F11A RID: 61722 RVA: 0x00058D10 File Offset: 0x00056F10
		[Token(Token = "0x17001F56")]
		public override bool applyTalentRangeBySkill
		{
			[Token(Token = "0x600F11A")]
			[Address(RVA = "0x698090", Offset = "0x696C90", VA = "0x180698090", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x0600F11B RID: 61723 RVA: 0x00058D28 File Offset: 0x00056F28
		[Token(Token = "0x17001F57")]
		public override bool applyBlackboardBySkill
		{
			[Token(Token = "0x600F11B")]
			[Address(RVA = "0x697FD0", Offset = "0x696BD0", VA = "0x180697FD0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x0600F11C RID: 61724 RVA: 0x00058D40 File Offset: 0x00056F40
		[Token(Token = "0x17001F58")]
		public override bool applyStrBlackboardBySkill
		{
			[Token(Token = "0x600F11C")]
			[Address(RVA = "0x698030", Offset = "0x696C30", VA = "0x180698030", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600F11D RID: 61725 RVA: 0x00058D58 File Offset: 0x00056F58
		[Token(Token = "0x17001F59")]
		public override bool writeRangeIdToProjectileBlackboard
		{
			[Token(Token = "0x600F11D")]
			[Address(RVA = "0x698660", Offset = "0x697260", VA = "0x180698660", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x0600F11E RID: 61726 RVA: 0x00058D70 File Offset: 0x00056F70
		[Token(Token = "0x17001F5A")]
		private bool useAttackBlackboardModeIndex
		{
			[Token(Token = "0x600F11E")]
			[Address(RVA = "0x698600", Offset = "0x697200", VA = "0x180698600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x0600F11F RID: 61727 RVA: 0x00058D88 File Offset: 0x00056F88
		[Token(Token = "0x17001F5B")]
		private bool applyTalentScaleModeValid
		{
			[Token(Token = "0x600F11F")]
			[Address(RVA = "0x6980F0", Offset = "0x696CF0", VA = "0x1806980F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F120 RID: 61728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F120")]
		[Address(RVA = "0x697BE0", Offset = "0x6967E0", VA = "0x180697BE0", Slot = "22")]
		public override Blackboard GenerateAttackBlackboard(UnitMode mode)
		{
			return null;
		}

		// Token: 0x0600F121 RID: 61729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F121")]
		[Address(RVA = "0x697D10", Offset = "0x696910", VA = "0x180697D10", Slot = "23")]
		public override Blackboard GetSkillBlackboardFromRawData(TalentData talentData)
		{
			return null;
		}

		// Token: 0x0600F122 RID: 61730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F122")]
		[Address(RVA = "0x697EB0", Offset = "0x696AB0", VA = "0x180697EB0")]
		public Talent()
		{
		}

		// Token: 0x0600F123 RID: 61731 RVA: 0x00058DA0 File Offset: 0x00056FA0
		[Token(Token = "0x600F123")]
		[Address(RVA = "0x697E50", Offset = "0x696A50", VA = "0x180697E50")]
		private bool <>xLuaBaseProxy_get_attachInDummy()
		{
			return default(bool);
		}

		// Token: 0x0600F124 RID: 61732 RVA: 0x00058DB8 File Offset: 0x00056FB8
		[Token(Token = "0x600F124")]
		[Address(RVA = "0x697E00", Offset = "0x696A00", VA = "0x180697E00")]
		private bool <>xLuaBaseProxy_get_affectWhenNotRootTalent()
		{
			return default(bool);
		}

		// Token: 0x0600F125 RID: 61733 RVA: 0x00058DD0 File Offset: 0x00056FD0
		[Token(Token = "0x600F125")]
		[Address(RVA = "0x697E70", Offset = "0x696A70", VA = "0x180697E70")]
		private bool <>xLuaBaseProxy_get_overrideDefaultRangeId()
		{
			return default(bool);
		}

		// Token: 0x0600F126 RID: 61734 RVA: 0x00058DE8 File Offset: 0x00056FE8
		[Token(Token = "0x600F126")]
		[Address(RVA = "0x697E40", Offset = "0x696A40", VA = "0x180697E40")]
		private bool <>xLuaBaseProxy_get_applyTalentScale()
		{
			return default(bool);
		}

		// Token: 0x0600F127 RID: 61735 RVA: 0x00058E00 File Offset: 0x00057000
		[Token(Token = "0x600F127")]
		[Address(RVA = "0x697E60", Offset = "0x696A60", VA = "0x180697E60")]
		private int <>xLuaBaseProxy_get_defaultModeIndex()
		{
			return 0;
		}

		// Token: 0x0600F128 RID: 61736 RVA: 0x00058E18 File Offset: 0x00057018
		[Token(Token = "0x600F128")]
		[Address(RVA = "0x697E80", Offset = "0x696A80", VA = "0x180697E80")]
		private bool <>xLuaBaseProxy_get_scaleCertainKeyFlag()
		{
			return default(bool);
		}

		// Token: 0x0600F129 RID: 61737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F129")]
		[Address(RVA = "0x697E90", Offset = "0x696A90", VA = "0x180697E90")]
		private string[] <>xLuaBaseProxy_get_scaleCertainKeyList()
		{
			return null;
		}

		// Token: 0x0600F12A RID: 61738 RVA: 0x00058E30 File Offset: 0x00057030
		[Token(Token = "0x600F12A")]
		[Address(RVA = "0x697E30", Offset = "0x696A30", VA = "0x180697E30")]
		private bool <>xLuaBaseProxy_get_applyTalentRangeBySkill()
		{
			return default(bool);
		}

		// Token: 0x0600F12B RID: 61739 RVA: 0x00058E48 File Offset: 0x00057048
		[Token(Token = "0x600F12B")]
		[Address(RVA = "0x697E10", Offset = "0x696A10", VA = "0x180697E10")]
		private bool <>xLuaBaseProxy_get_applyBlackboardBySkill()
		{
			return default(bool);
		}

		// Token: 0x0600F12C RID: 61740 RVA: 0x00058E60 File Offset: 0x00057060
		[Token(Token = "0x600F12C")]
		[Address(RVA = "0x697E20", Offset = "0x696A20", VA = "0x180697E20")]
		private bool <>xLuaBaseProxy_get_applyStrBlackboardBySkill()
		{
			return default(bool);
		}

		// Token: 0x0600F12D RID: 61741 RVA: 0x00058E78 File Offset: 0x00057078
		[Token(Token = "0x600F12D")]
		[Address(RVA = "0x697EA0", Offset = "0x696AA0", VA = "0x180697EA0")]
		private bool <>xLuaBaseProxy_get_writeRangeIdToProjectileBlackboard()
		{
			return default(bool);
		}

		// Token: 0x0600F12E RID: 61742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F12E")]
		[Address(RVA = "0x697DE0", Offset = "0x6969E0", VA = "0x180697DE0")]
		private Blackboard <>xLuaBaseProxy_GenerateAttackBlackboard(UnitMode P0)
		{
			return null;
		}

		// Token: 0x0600F12F RID: 61743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F12F")]
		[Address(RVA = "0x697DF0", Offset = "0x6969F0", VA = "0x180697DF0")]
		private Blackboard <>xLuaBaseProxy_GetSkillBlackboardFromRawData(TalentData P0)
		{
			return null;
		}

		// Token: 0x04010AC6 RID: 68294
		[Token(Token = "0x4010AC6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _attachInDummy;

		// Token: 0x04010AC7 RID: 68295
		[Token(Token = "0x4010AC7")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Group("Detail")]
		private int _defaultModeIndex;

		// Token: 0x04010AC8 RID: 68296
		[Token(Token = "0x4010AC8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Detail")]
		private int _attackBlackboardModeIndex;

		// Token: 0x04010AC9 RID: 68297
		[Token(Token = "0x4010AC9")]
		[FieldOffset(Offset = "0x60")]
		[Group("Detail")]
		[Inspect("useAttackBlackboardModeIndex")]
		[SerializeField]
		private int[] _extraAttackBlackboardModeIndices;

		// Token: 0x04010ACA RID: 68298
		[Token(Token = "0x4010ACA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Detail")]
		private bool _overrideDefaultRangeId;

		// Token: 0x04010ACB RID: 68299
		[Token(Token = "0x4010ACB")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		[Group("Detail")]
		private bool _applyTalentScale;

		// Token: 0x04010ACC RID: 68300
		[Token(Token = "0x4010ACC")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		[Group("Detail")]
		private bool _influenceSkillBlackboard;

		// Token: 0x04010ACD RID: 68301
		[Token(Token = "0x4010ACD")]
		[FieldOffset(Offset = "0x6B")]
		[SerializeField]
		[Group("Detail")]
		private bool _applyTalentRange;

		// Token: 0x04010ACE RID: 68302
		[Token(Token = "0x4010ACE")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Group("Detail")]
		private bool _applyBlackboardBySkill;

		// Token: 0x04010ACF RID: 68303
		[Token(Token = "0x4010ACF")]
		[FieldOffset(Offset = "0x6D")]
		[SerializeField]
		[Group("Detail")]
		private bool _applyStrBlackboardBySkill;

		// Token: 0x04010AD0 RID: 68304
		[Token(Token = "0x4010AD0")]
		[FieldOffset(Offset = "0x6E")]
		[SerializeField]
		[Group("Detail")]
		private bool _writeRangeIdToProjectileBlackboard;

		// Token: 0x04010AD1 RID: 68305
		[Token(Token = "0x4010AD1")]
		[FieldOffset(Offset = "0x6F")]
		[SerializeField]
		[Group("Detail")]
		private bool _affectWhenNotRootTalent;

		// Token: 0x04010AD2 RID: 68306
		[Token(Token = "0x4010AD2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Inspect("applyTalentScaleEditor")]
		[Group("Detail")]
		private bool _scaleCertainKeyFlag;

		// Token: 0x04010AD3 RID: 68307
		[Token(Token = "0x4010AD3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Inspect("scaleCertainKeyFlag")]
		[Group("Detail")]
		private string[] _scaleCertainKeyList;

		// Token: 0x04010AD4 RID: 68308
		[Token(Token = "0x4010AD4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Inspect("applyTalentScaleEditor")]
		[Group("Detail")]
		private bool _scaleCertainMode;

		// Token: 0x04010AD5 RID: 68309
		[Token(Token = "0x4010AD5")]
		[FieldOffset(Offset = "0x88")]
		[Inspect("scaleCertainMode")]
		[Group("Detail")]
		[SerializeField]
		private List<int> _scaleModeIndices;

		// Token: 0x04010AD6 RID: 68310
		[Token(Token = "0x4010AD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x04010AD7 RID: 68311
		[Token(Token = "0x4010AD7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_affectWhenNotRootTalent;

		// Token: 0x04010AD8 RID: 68312
		[Token(Token = "0x4010AD8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_overrideDefaultRangeId;

		// Token: 0x04010AD9 RID: 68313
		[Token(Token = "0x4010AD9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_applyTalentScale;

		// Token: 0x04010ADA RID: 68314
		[Token(Token = "0x4010ADA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_scaleCertainMode;

		// Token: 0x04010ADB RID: 68315
		[Token(Token = "0x4010ADB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_defaultModeIndex;

		// Token: 0x04010ADC RID: 68316
		[Token(Token = "0x4010ADC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_scaleCertainKeyFlag;

		// Token: 0x04010ADD RID: 68317
		[Token(Token = "0x4010ADD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_scaleCertainKeyList;

		// Token: 0x04010ADE RID: 68318
		[Token(Token = "0x4010ADE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_applyTalentRangeBySkill;

		// Token: 0x04010ADF RID: 68319
		[Token(Token = "0x4010ADF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_applyBlackboardBySkill;

		// Token: 0x04010AE0 RID: 68320
		[Token(Token = "0x4010AE0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_applyStrBlackboardBySkill;

		// Token: 0x04010AE1 RID: 68321
		[Token(Token = "0x4010AE1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_writeRangeIdToProjectileBlackboard;

		// Token: 0x04010AE2 RID: 68322
		[Token(Token = "0x4010AE2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_useAttackBlackboardModeIndex;

		// Token: 0x04010AE3 RID: 68323
		[Token(Token = "0x4010AE3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_applyTalentScaleModeValid;

		// Token: 0x04010AE4 RID: 68324
		[Token(Token = "0x4010AE4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GenerateAttackBlackboard;

		// Token: 0x04010AE5 RID: 68325
		[Token(Token = "0x4010AE5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetSkillBlackboardFromRawData;

		// Token: 0x04010AE6 RID: 68326
		[Token(Token = "0x4010AE6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
