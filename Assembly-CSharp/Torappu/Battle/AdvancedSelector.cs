using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024DD RID: 9437
	[Token(Token = "0x20024DD")]
	public class AdvancedSelector : RangeSelector, IExcludeTarget
	{
		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600F31A RID: 62234 RVA: 0x00059940 File Offset: 0x00057B40
		[Token(Token = "0x17001FA0")]
		public bool limitTargetNum
		{
			[Token(Token = "0x600F31A")]
			[Address(RVA = "0x6A3690", Offset = "0x6A2290", VA = "0x1806A3690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x0600F31B RID: 62235 RVA: 0x00059958 File Offset: 0x00057B58
		[Token(Token = "0x17001FA1")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F31B")]
			[Address(RVA = "0x6A3990", Offset = "0x6A2590", VA = "0x1806A3990", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x0600F31C RID: 62236 RVA: 0x00059970 File Offset: 0x00057B70
		[Token(Token = "0x17001FA2")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F31C")]
			[Address(RVA = "0x6A3930", Offset = "0x6A2530", VA = "0x1806A3930", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x0600F31D RID: 62237 RVA: 0x00059988 File Offset: 0x00057B88
		[Token(Token = "0x17001FA3")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F31D")]
			[Address(RVA = "0x6A38D0", Offset = "0x6A24D0", VA = "0x1806A38D0", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x0600F31E RID: 62238 RVA: 0x000599A0 File Offset: 0x00057BA0
		[Token(Token = "0x17001FA4")]
		protected int maxTargetNum
		{
			[Token(Token = "0x600F31E")]
			[Address(RVA = "0x6A36F0", Offset = "0x6A22F0", VA = "0x1806A36F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x0600F31F RID: 62239 RVA: 0x000599B8 File Offset: 0x00057BB8
		[Token(Token = "0x17001FA5")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F31F")]
			[Address(RVA = "0x6A35D0", Offset = "0x6A21D0", VA = "0x1806A35D0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600F320 RID: 62240 RVA: 0x000599D0 File Offset: 0x00057BD0
		[Token(Token = "0x17001FA6")]
		protected override bool ignoreAllyTargetFree
		{
			[Token(Token = "0x600F320")]
			[Address(RVA = "0x6A34A0", Offset = "0x6A20A0", VA = "0x1806A34A0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x0600F321 RID: 62241 RVA: 0x000599E8 File Offset: 0x00057BE8
		[Token(Token = "0x17001FA7")]
		protected override bool ignoreHealFree
		{
			[Token(Token = "0x600F321")]
			[Address(RVA = "0x6A3500", Offset = "0x6A2100", VA = "0x1806A3500", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x0600F322 RID: 62242 RVA: 0x00059A00 File Offset: 0x00057C00
		[Token(Token = "0x17001FA8")]
		protected override bool forceIgnoreCamouflage
		{
			[Token(Token = "0x600F322")]
			[Address(RVA = "0x6A3440", Offset = "0x6A2040", VA = "0x1806A3440", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x0600F323 RID: 62243 RVA: 0x00059A18 File Offset: 0x00057C18
		[Token(Token = "0x17001FA9")]
		protected override bool ignoreHitRange
		{
			[Token(Token = "0x600F323")]
			[Address(RVA = "0x6A3560", Offset = "0x6A2160", VA = "0x1806A3560", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x0600F324 RID: 62244 RVA: 0x00059A30 File Offset: 0x00057C30
		[Token(Token = "0x17001FAA")]
		protected override bool onlyIgnoreSomeOfTargetFreeCase
		{
			[Token(Token = "0x600F324")]
			[Address(RVA = "0x6A37B0", Offset = "0x6A23B0", VA = "0x1806A37B0", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x0600F325 RID: 62245 RVA: 0x00059A48 File Offset: 0x00057C48
		[Token(Token = "0x17001FAB")]
		protected bool needProfessionMask
		{
			[Token(Token = "0x600F325")]
			[Address(RVA = "0x6A3750", Offset = "0x6A2350", VA = "0x1806A3750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x0600F326 RID: 62246 RVA: 0x00059A60 File Offset: 0x00057C60
		[Token(Token = "0x17001FAC")]
		protected override AbnormalFlag abnormalFlag
		{
			[Token(Token = "0x600F326")]
			[Address(RVA = "0x6A32B0", Offset = "0x6A1EB0", VA = "0x1806A32B0", Slot = "32")]
			get
			{
				return AbnormalFlag.STUNNED;
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x0600F327 RID: 62247 RVA: 0x00059A78 File Offset: 0x00057C78
		[Token(Token = "0x17001FAD")]
		protected override AbnormalCombo abnormalCombo
		{
			[Token(Token = "0x600F327")]
			[Address(RVA = "0x6A3250", Offset = "0x6A1E50", VA = "0x1806A3250", Slot = "33")]
			get
			{
				return AbnormalCombo.SLEEPING;
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x0600F328 RID: 62248 RVA: 0x00059A90 File Offset: 0x00057C90
		[Token(Token = "0x17001FAE")]
		protected override ProfessionCategory professionMask
		{
			[Token(Token = "0x600F328")]
			[Address(RVA = "0x6A3820", Offset = "0x6A2420", VA = "0x1806A3820", Slot = "34")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x0600F329 RID: 62249 RVA: 0x00059AA8 File Offset: 0x00057CA8
		[Token(Token = "0x17001FAF")]
		private bool filterTypeAllAndLimitTargetNum
		{
			[Token(Token = "0x600F329")]
			[Address(RVA = "0x6A33D0", Offset = "0x6A1FD0", VA = "0x1806A33D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x0600F32A RID: 62250 RVA: 0x00059AC0 File Offset: 0x00057CC0
		[Token(Token = "0x17001FB0")]
		protected bool isAlly
		{
			[Token(Token = "0x600F32A")]
			[Address(RVA = "0x6A3630", Offset = "0x6A2230", VA = "0x1806A3630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x0600F32B RID: 62251 RVA: 0x00059AD8 File Offset: 0x00057CD8
		[Token(Token = "0x17001FB1")]
		protected bool dontExcludeOwner
		{
			[Token(Token = "0x600F32B")]
			[Address(RVA = "0x6A3370", Offset = "0x6A1F70", VA = "0x1806A3370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x0600F32C RID: 62252 RVA: 0x00059AF0 File Offset: 0x00057CF0
		[Token(Token = "0x17001FB2")]
		protected override bool checkUnitType
		{
			[Token(Token = "0x600F32C")]
			[Address(RVA = "0x6A3310", Offset = "0x6A1F10", VA = "0x1806A3310", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x0600F32D RID: 62253 RVA: 0x00059B08 File Offset: 0x00057D08
		[Token(Token = "0x17001FB3")]
		protected override UnitTypeMask unitTypeMask
		{
			[Token(Token = "0x600F32D")]
			[Address(RVA = "0x6A39F0", Offset = "0x6A25F0", VA = "0x1806A39F0", Slot = "36")]
			get
			{
				return UnitTypeMask.NONE;
			}
		}

		// Token: 0x0600F32E RID: 62254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F32E")]
		[Address(RVA = "0x6A2BC0", Offset = "0x6A17C0", VA = "0x1806A2BC0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F32F RID: 62255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F32F")]
		[Address(RVA = "0x6A2CD0", Offset = "0x6A18D0", VA = "0x1806A2CD0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F330 RID: 62256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F330")]
		[Address(RVA = "0x6A2790", Offset = "0x6A1390", VA = "0x1806A2790", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F331 RID: 62257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F331")]
		[Address(RVA = "0x6A2730", Offset = "0x6A1330", VA = "0x1806A2730", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F332 RID: 62258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F332")]
		[Address(RVA = "0x6A2620", Offset = "0x6A1220", VA = "0x1806A2620", Slot = "39")]
		protected override void Awake()
		{
		}

		// Token: 0x0600F333 RID: 62259 RVA: 0x00059B20 File Offset: 0x00057D20
		[Token(Token = "0x600F333")]
		[Address(RVA = "0x6A2E70", Offset = "0x6A1A70", VA = "0x1806A2E70", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F334 RID: 62260 RVA: 0x00059B38 File Offset: 0x00057D38
		[Token(Token = "0x600F334")]
		[Address(RVA = "0x6A2F30", Offset = "0x6A1B30", VA = "0x1806A2F30")]
		private bool _CheckAbilityInputTargetValid()
		{
			return default(bool);
		}

		// Token: 0x0600F335 RID: 62261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F335")]
		[Address(RVA = "0x6A2580", Offset = "0x6A1180", VA = "0x1806A2580", Slot = "40")]
		public void AddExcludeTarget(Entity target)
		{
		}

		// Token: 0x0600F336 RID: 62262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F336")]
		[Address(RVA = "0x6A26B0", Offset = "0x6A12B0", VA = "0x1806A26B0", Slot = "41")]
		public void ClearExcludeTarget()
		{
		}

		// Token: 0x0600F337 RID: 62263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F337")]
		[Address(RVA = "0x6A3120", Offset = "0x6A1D20", VA = "0x1806A3120")]
		public AdvancedSelector()
		{
		}

		// Token: 0x0600F338 RID: 62264 RVA: 0x00059B50 File Offset: 0x00057D50
		[Token(Token = "0x600F338")]
		[Address(RVA = "0x6A2E10", Offset = "0x6A1A10", VA = "0x1806A2E10")]
		private bool <>xLuaBaseProxy_get_ignoreAllyTargetFree()
		{
			return default(bool);
		}

		// Token: 0x0600F339 RID: 62265 RVA: 0x00059B68 File Offset: 0x00057D68
		[Token(Token = "0x600F339")]
		[Address(RVA = "0x6A2E20", Offset = "0x6A1A20", VA = "0x1806A2E20")]
		private bool <>xLuaBaseProxy_get_ignoreHealFree()
		{
			return default(bool);
		}

		// Token: 0x0600F33A RID: 62266 RVA: 0x00059B80 File Offset: 0x00057D80
		[Token(Token = "0x600F33A")]
		[Address(RVA = "0x6A2E00", Offset = "0x6A1A00", VA = "0x1806A2E00")]
		private bool <>xLuaBaseProxy_get_forceIgnoreCamouflage()
		{
			return default(bool);
		}

		// Token: 0x0600F33B RID: 62267 RVA: 0x00059B98 File Offset: 0x00057D98
		[Token(Token = "0x600F33B")]
		[Address(RVA = "0x6A2E30", Offset = "0x6A1A30", VA = "0x1806A2E30")]
		private bool <>xLuaBaseProxy_get_ignoreHitRange()
		{
			return default(bool);
		}

		// Token: 0x0600F33C RID: 62268 RVA: 0x00059BB0 File Offset: 0x00057DB0
		[Token(Token = "0x600F33C")]
		[Address(RVA = "0x6A2E40", Offset = "0x6A1A40", VA = "0x1806A2E40")]
		private bool <>xLuaBaseProxy_get_onlyIgnoreSomeOfTargetFreeCase()
		{
			return default(bool);
		}

		// Token: 0x0600F33D RID: 62269 RVA: 0x00059BC8 File Offset: 0x00057DC8
		[Token(Token = "0x600F33D")]
		[Address(RVA = "0x6A2DE0", Offset = "0x6A19E0", VA = "0x1806A2DE0")]
		private AbnormalFlag <>xLuaBaseProxy_get_abnormalFlag()
		{
			return AbnormalFlag.STUNNED;
		}

		// Token: 0x0600F33E RID: 62270 RVA: 0x00059BE0 File Offset: 0x00057DE0
		[Token(Token = "0x600F33E")]
		[Address(RVA = "0x6A2DD0", Offset = "0x6A19D0", VA = "0x1806A2DD0")]
		private AbnormalCombo <>xLuaBaseProxy_get_abnormalCombo()
		{
			return AbnormalCombo.SLEEPING;
		}

		// Token: 0x0600F33F RID: 62271 RVA: 0x00059BF8 File Offset: 0x00057DF8
		[Token(Token = "0x600F33F")]
		[Address(RVA = "0x6A2E50", Offset = "0x6A1A50", VA = "0x1806A2E50")]
		private ProfessionCategory <>xLuaBaseProxy_get_professionMask()
		{
			return ProfessionCategory.NONE;
		}

		// Token: 0x0600F340 RID: 62272 RVA: 0x00059C10 File Offset: 0x00057E10
		[Token(Token = "0x600F340")]
		[Address(RVA = "0x6A2DF0", Offset = "0x6A19F0", VA = "0x1806A2DF0")]
		private bool <>xLuaBaseProxy_get_checkUnitType()
		{
			return default(bool);
		}

		// Token: 0x0600F341 RID: 62273 RVA: 0x00059C28 File Offset: 0x00057E28
		[Token(Token = "0x600F341")]
		[Address(RVA = "0x6A2E60", Offset = "0x6A1A60", VA = "0x1806A2E60")]
		private UnitTypeMask <>xLuaBaseProxy_get_unitTypeMask()
		{
			return UnitTypeMask.NONE;
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F342")]
		[Address(RVA = "0x6A2DA0", Offset = "0x6A19A0", VA = "0x1806A2DA0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F343 RID: 62275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F343")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F344 RID: 62276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F344")]
		[Address(RVA = "0x6A2D90", Offset = "0x6A1990", VA = "0x1806A2D90")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x0600F345 RID: 62277 RVA: 0x00059C40 File Offset: 0x00057E40
		[Token(Token = "0x600F345")]
		[Address(RVA = "0x6A2DC0", Offset = "0x6A19C0", VA = "0x1806A2DC0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010CFB RID: 68859
		[Token(Token = "0x4010CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04010CFC RID: 68860
		[Token(Token = "0x4010CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private MotionMask _targetMotion;

		// Token: 0x04010CFD RID: 68861
		[Token(Token = "0x4010CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Enum(true, EnumDisplay.Checkbox)]
		private EntityCategory _targetCategory;

		// Token: 0x04010CFE RID: 68862
		[Token(Token = "0x4010CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		protected FilterUtil.FilterType _postFilter;

		// Token: 0x04010CFF RID: 68863
		[Token(Token = "0x4010CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _ignoreTargetFree;

		// Token: 0x04010D00 RID: 68864
		[Token(Token = "0x4010D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[SerializeField]
		[Inspect("ignoreTargetFree")]
		public bool _onlyIgnoreSomeOfTargetFreeCase;

		// Token: 0x04010D01 RID: 68865
		[Token(Token = "0x4010D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Inspect("onlyIgnoreSomeOfTargetFreeCase")]
		public AbnormalFlag _abnormalFlag;

		// Token: 0x04010D02 RID: 68866
		[Token(Token = "0x4010D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Inspect("onlyIgnoreSomeOfTargetFreeCase")]
		public AbnormalCombo _abnormalCombo;

		// Token: 0x04010D03 RID: 68867
		[Token(Token = "0x4010D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool _ignoreAllyTargetFree;

		// Token: 0x04010D04 RID: 68868
		[Token(Token = "0x4010D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		[SerializeField]
		private bool _ignoreHealFree;

		// Token: 0x04010D05 RID: 68869
		[Token(Token = "0x4010D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		[SerializeField]
		private bool _forceIgnoreCamouflage;

		// Token: 0x04010D06 RID: 68870
		[Token(Token = "0x4010D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBF")]
		[SerializeField]
		private bool _needProfessionMask;

		// Token: 0x04010D07 RID: 68871
		[Token(Token = "0x4010D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Enum(true, EnumDisplay.Checkbox)]
		[Inspect("needProfessionMask")]
		public ProfessionCategory _professionMask;

		// Token: 0x04010D08 RID: 68872
		[Token(Token = "0x4010D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private bool _limitTargetNum;

		// Token: 0x04010D09 RID: 68873
		[Token(Token = "0x4010D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string _maxTargetKey;

		// Token: 0x04010D0A RID: 68874
		[Token(Token = "0x4010D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Inspect("filterTypeAllAndLimitTargetNum")]
		private int _maxNum;

		// Token: 0x04010D0B RID: 68875
		[Token(Token = "0x4010D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Inspect("isAlly")]
		protected bool _excludeOwner;

		// Token: 0x04010D0C RID: 68876
		[Token(Token = "0x4010D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		[SerializeField]
		protected bool _sortByTauntAtLast;

		// Token: 0x04010D0D RID: 68877
		[Token(Token = "0x4010D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
		[SerializeField]
		private bool _ignoreHitRange;

		// Token: 0x04010D0E RID: 68878
		[Token(Token = "0x4010D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD7")]
		[SerializeField]
		private bool _checkUnitType;

		// Token: 0x04010D0F RID: 68879
		[Token(Token = "0x4010D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UnitTypeMask _unitTypeMask;

		// Token: 0x04010D10 RID: 68880
		[Token(Token = "0x4010D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private bool _abilityInputTargetAsSortSource;

		// Token: 0x04010D11 RID: 68881
		[Token(Token = "0x4010D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int m_maxTargetNum;

		// Token: 0x04010D12 RID: 68882
		[Token(Token = "0x4010D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ListSet<Entity> m_excludeTargetList;

		// Token: 0x04010D13 RID: 68883
		[Token(Token = "0x4010D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitTargetNum;

		// Token: 0x04010D14 RID: 68884
		[Token(Token = "0x4010D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010D15 RID: 68885
		[Token(Token = "0x4010D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010D16 RID: 68886
		[Token(Token = "0x4010D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010D17 RID: 68887
		[Token(Token = "0x4010D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxTargetNum;

		// Token: 0x04010D18 RID: 68888
		[Token(Token = "0x4010D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010D19 RID: 68889
		[Token(Token = "0x4010D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ignoreAllyTargetFree;

		// Token: 0x04010D1A RID: 68890
		[Token(Token = "0x4010D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_ignoreHealFree;

		// Token: 0x04010D1B RID: 68891
		[Token(Token = "0x4010D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_forceIgnoreCamouflage;

		// Token: 0x04010D1C RID: 68892
		[Token(Token = "0x4010D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_ignoreHitRange;

		// Token: 0x04010D1D RID: 68893
		[Token(Token = "0x4010D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_onlyIgnoreSomeOfTargetFreeCase;

		// Token: 0x04010D1E RID: 68894
		[Token(Token = "0x4010D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_needProfessionMask;

		// Token: 0x04010D1F RID: 68895
		[Token(Token = "0x4010D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_abnormalFlag;

		// Token: 0x04010D20 RID: 68896
		[Token(Token = "0x4010D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_abnormalCombo;

		// Token: 0x04010D21 RID: 68897
		[Token(Token = "0x4010D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_professionMask;

		// Token: 0x04010D22 RID: 68898
		[Token(Token = "0x4010D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_filterTypeAllAndLimitTargetNum;

		// Token: 0x04010D23 RID: 68899
		[Token(Token = "0x4010D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isAlly;

		// Token: 0x04010D24 RID: 68900
		[Token(Token = "0x4010D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_dontExcludeOwner;

		// Token: 0x04010D25 RID: 68901
		[Token(Token = "0x4010D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_checkUnitType;

		// Token: 0x04010D26 RID: 68902
		[Token(Token = "0x4010D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_unitTypeMask;

		// Token: 0x04010D27 RID: 68903
		[Token(Token = "0x4010D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010D28 RID: 68904
		[Token(Token = "0x4010D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010D29 RID: 68905
		[Token(Token = "0x4010D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D2A RID: 68906
		[Token(Token = "0x4010D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010D2B RID: 68907
		[Token(Token = "0x4010D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04010D2C RID: 68908
		[Token(Token = "0x4010D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010D2D RID: 68909
		[Token(Token = "0x4010D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckAbilityInputTargetValid;

		// Token: 0x04010D2E RID: 68910
		[Token(Token = "0x4010D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_AddExcludeTarget;

		// Token: 0x04010D2F RID: 68911
		[Token(Token = "0x4010D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ClearExcludeTarget;

		// Token: 0x04010D30 RID: 68912
		[Token(Token = "0x4010D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
