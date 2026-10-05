using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002616 RID: 9750
	[Token(Token = "0x2002616")]
	[SelectionBase]
	public class Trap : Token
	{
		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x0600FE5A RID: 65114 RVA: 0x000608D0 File Offset: 0x0005EAD0
		[Token(Token = "0x1700226B")]
		protected bool isGiantTrap
		{
			[Token(Token = "0x600FE5A")]
			[Address(RVA = "0x766AC0", Offset = "0x7656C0", VA = "0x180766AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x0600FE5B RID: 65115 RVA: 0x000608E8 File Offset: 0x0005EAE8
		[Token(Token = "0x1700226C")]
		public bool syncSpViaTiles
		{
			[Token(Token = "0x600FE5B")]
			[Address(RVA = "0x766C70", Offset = "0x765870", VA = "0x180766C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x0600FE5C RID: 65116 RVA: 0x00060900 File Offset: 0x0005EB00
		[Token(Token = "0x1700226D")]
		public bool hideSpBarWhenEmpty
		{
			[Token(Token = "0x600FE5C")]
			[Address(RVA = "0x766560", Offset = "0x765160", VA = "0x180766560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x0600FE5D RID: 65117 RVA: 0x00060918 File Offset: 0x0005EB18
		[Token(Token = "0x1700226E")]
		public bool hideSpBarWhenFull
		{
			[Token(Token = "0x600FE5D")]
			[Address(RVA = "0x7665C0", Offset = "0x7651C0", VA = "0x1807665C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x0600FE5E RID: 65118 RVA: 0x00060930 File Offset: 0x0005EB30
		[Token(Token = "0x1700226F")]
		public bool hideSpBarWhenSkill
		{
			[Token(Token = "0x600FE5E")]
			[Address(RVA = "0x766680", Offset = "0x765280", VA = "0x180766680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x0600FE5F RID: 65119 RVA: 0x00060948 File Offset: 0x0005EB48
		[Token(Token = "0x17002270")]
		public bool hideSpBarWhenNotHaveSkill
		{
			[Token(Token = "0x600FE5F")]
			[Address(RVA = "0x766620", Offset = "0x765220", VA = "0x180766620")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x0600FE60 RID: 65120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002271")]
		public override string hitRangeId
		{
			[Token(Token = "0x600FE60")]
			[Address(RVA = "0x7666E0", Offset = "0x7652E0", VA = "0x1807666E0", Slot = "187")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x0600FE61 RID: 65121 RVA: 0x00060960 File Offset: 0x0005EB60
		[Token(Token = "0x17002272")]
		public override bool alwaysBlockFree
		{
			[Token(Token = "0x600FE61")]
			[Address(RVA = "0x7663A0", Offset = "0x764FA0", VA = "0x1807663A0", Slot = "210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FE62 RID: 65122 RVA: 0x00060978 File Offset: 0x0005EB78
		[Token(Token = "0x600FE62")]
		[Address(RVA = "0x765AA0", Offset = "0x7646A0", VA = "0x180765AA0", Slot = "109")]
		protected override bool SetSpInternal(FP value, bool force)
		{
			return default(bool);
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x0600FE63 RID: 65123 RVA: 0x00060990 File Offset: 0x0005EB90
		[Token(Token = "0x17002273")]
		protected override SideType initSideType
		{
			[Token(Token = "0x600FE63")]
			[Address(RVA = "0x766A20", Offset = "0x765620", VA = "0x180766A20", Slot = "193")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x0600FE64 RID: 65124 RVA: 0x000609A8 File Offset: 0x0005EBA8
		[Token(Token = "0x17002274")]
		public bool disableUIHub
		{
			[Token(Token = "0x600FE64")]
			[Address(RVA = "0x766460", Offset = "0x765060", VA = "0x180766460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x0600FE65 RID: 65125 RVA: 0x000609C0 File Offset: 0x0005EBC0
		[Token(Token = "0x17002275")]
		public override bool showShield
		{
			[Token(Token = "0x600FE65")]
			[Address(RVA = "0x766BB0", Offset = "0x7657B0", VA = "0x180766BB0", Slot = "197")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x0600FE66 RID: 65126 RVA: 0x000609D8 File Offset: 0x0005EBD8
		// (set) Token: 0x0600FE67 RID: 65127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002276")]
		public bool fogHideUIFlag
		{
			[Token(Token = "0x600FE66")]
			[Address(RVA = "0x766500", Offset = "0x765100", VA = "0x180766500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FE67")]
			[Address(RVA = "0x766D50", Offset = "0x765950", VA = "0x180766D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x0600FE68 RID: 65128 RVA: 0x000609F0 File Offset: 0x0005EBF0
		[Token(Token = "0x17002277")]
		public override bool withdrawable
		{
			[Token(Token = "0x600FE68")]
			[Address(RVA = "0x766CD0", Offset = "0x7658D0", VA = "0x180766CD0", Slot = "203")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x0600FE69 RID: 65129 RVA: 0x00060A08 File Offset: 0x0005EC08
		[Token(Token = "0x17002278")]
		public override float blockRadiusSquare
		{
			[Token(Token = "0x600FE69")]
			[Address(RVA = "0x757A90", Offset = "0x756690", VA = "0x180757A90", Slot = "204")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x0600FE6A RID: 65130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002279")]
		protected override string startEffect
		{
			[Token(Token = "0x600FE6A")]
			[Address(RVA = "0x766C10", Offset = "0x765810", VA = "0x180766C10", Slot = "208")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x0600FE6B RID: 65131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700227A")]
		protected override string deadEffect
		{
			[Token(Token = "0x600FE6B")]
			[Address(RVA = "0x766400", Offset = "0x765000", VA = "0x180766400", Slot = "209")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600FE6C RID: 65132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE6C")]
		[Address(RVA = "0x7654A0", Offset = "0x7640A0", VA = "0x1807654A0", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600FE6D RID: 65133 RVA: 0x00060A20 File Offset: 0x0005EC20
		[Token(Token = "0x600FE6D")]
		[Address(RVA = "0x765200", Offset = "0x763E00", VA = "0x180765200", Slot = "97")]
		public override bool CheckHasFilterTag(string unitTag)
		{
			return default(bool);
		}

		// Token: 0x0600FE6E RID: 65134 RVA: 0x00060A38 File Offset: 0x0005EC38
		[Token(Token = "0x600FE6E")]
		[Address(RVA = "0x7653D0", Offset = "0x763FD0", VA = "0x1807653D0", Slot = "92")]
		public override bool IsStayStill()
		{
			return default(bool);
		}

		// Token: 0x0600FE6F RID: 65135 RVA: 0x00060A50 File Offset: 0x0005EC50
		[Token(Token = "0x600FE6F")]
		[Address(RVA = "0x7652A0", Offset = "0x763EA0", VA = "0x1807652A0", Slot = "131")]
		public override bool IsInHitRange(Entity.HitRangeOption options)
		{
			return default(bool);
		}

		// Token: 0x0600FE70 RID: 65136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE70")]
		[Address(RVA = "0x765EE0", Offset = "0x764AE0", VA = "0x180765EE0")]
		private void _ResetHitRangeGrids()
		{
		}

		// Token: 0x0600FE71 RID: 65137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE71")]
		[Address(RVA = "0x765CF0", Offset = "0x7648F0", VA = "0x180765CF0", Slot = "96")]
		public override void SwitchSide(SideType newSide)
		{
		}

		// Token: 0x0600FE72 RID: 65138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE72")]
		[Address(RVA = "0x765430", Offset = "0x764030", VA = "0x180765430", Slot = "125")]
		public override void OnDirectionChanged()
		{
		}

		// Token: 0x0600FE73 RID: 65139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE73")]
		[Address(RVA = "0x7659C0", Offset = "0x7645C0", VA = "0x1807659C0", Slot = "12")]
		public override void SetHeight(float height, bool isInit = false)
		{
		}

		// Token: 0x0600FE74 RID: 65140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE74")]
		[Address(RVA = "0x765900", Offset = "0x764500", VA = "0x180765900", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0600FE75 RID: 65141 RVA: 0x00060A68 File Offset: 0x0005EC68
		[Token(Token = "0x1700227B")]
		public override HudPluginMask hudPluginMask
		{
			[Token(Token = "0x600FE75")]
			[Address(RVA = "0x766740", Offset = "0x765340", VA = "0x180766740", Slot = "166")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x0600FE76 RID: 65142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE76")]
		[Address(RVA = "0x7662A0", Offset = "0x764EA0", VA = "0x1807662A0")]
		public Trap()
		{
		}

		// Token: 0x0600FE77 RID: 65143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FE77")]
		[Address(RVA = "0x765E20", Offset = "0x764A20", VA = "0x180765E20")]
		private string <>xLuaBaseProxy_get_hitRangeId()
		{
			return null;
		}

		// Token: 0x0600FE78 RID: 65144 RVA: 0x00060A80 File Offset: 0x0005EC80
		[Token(Token = "0x600FE78")]
		[Address(RVA = "0x765DF0", Offset = "0x7649F0", VA = "0x180765DF0")]
		private bool <>xLuaBaseProxy_get_alwaysBlockFree()
		{
			return default(bool);
		}

		// Token: 0x0600FE79 RID: 65145 RVA: 0x00060A98 File Offset: 0x0005EC98
		[Token(Token = "0x600FE79")]
		[Address(RVA = "0x765DD0", Offset = "0x7649D0", VA = "0x180765DD0")]
		private bool <>xLuaBaseProxy_SetSpInternal(FP P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600FE7A RID: 65146 RVA: 0x00060AB0 File Offset: 0x0005ECB0
		[Token(Token = "0x600FE7A")]
		[Address(RVA = "0x763300", Offset = "0x761F00", VA = "0x180763300")]
		private SideType <>xLuaBaseProxy_get_initSideType()
		{
			return SideType.NONE;
		}

		// Token: 0x0600FE7B RID: 65147 RVA: 0x00060AC8 File Offset: 0x0005ECC8
		[Token(Token = "0x600FE7B")]
		[Address(RVA = "0x765EB0", Offset = "0x764AB0", VA = "0x180765EB0")]
		private bool <>xLuaBaseProxy_get_showShield()
		{
			return default(bool);
		}

		// Token: 0x0600FE7C RID: 65148 RVA: 0x00060AE0 File Offset: 0x0005ECE0
		[Token(Token = "0x600FE7C")]
		[Address(RVA = "0x765ED0", Offset = "0x764AD0", VA = "0x180765ED0")]
		private bool <>xLuaBaseProxy_get_withdrawable()
		{
			return default(bool);
		}

		// Token: 0x0600FE7D RID: 65149 RVA: 0x00060AF8 File Offset: 0x0005ECF8
		[Token(Token = "0x600FE7D")]
		[Address(RVA = "0x765E00", Offset = "0x764A00", VA = "0x180765E00")]
		private float <>xLuaBaseProxy_get_blockRadiusSquare()
		{
			return 0f;
		}

		// Token: 0x0600FE7E RID: 65150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FE7E")]
		[Address(RVA = "0x765EC0", Offset = "0x764AC0", VA = "0x180765EC0")]
		private string <>xLuaBaseProxy_get_startEffect()
		{
			return null;
		}

		// Token: 0x0600FE7F RID: 65151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FE7F")]
		[Address(RVA = "0x765E10", Offset = "0x764A10", VA = "0x180765E10")]
		private string <>xLuaBaseProxy_get_deadEffect()
		{
			return null;
		}

		// Token: 0x0600FE80 RID: 65152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE80")]
		[Address(RVA = "0x75D610", Offset = "0x75C210", VA = "0x18075D610")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600FE81 RID: 65153 RVA: 0x00060B10 File Offset: 0x0005ED10
		[Token(Token = "0x600FE81")]
		[Address(RVA = "0x765D70", Offset = "0x764970", VA = "0x180765D70")]
		private bool <>xLuaBaseProxy_CheckHasFilterTag(string P0)
		{
			return default(bool);
		}

		// Token: 0x0600FE82 RID: 65154 RVA: 0x00060B28 File Offset: 0x0005ED28
		[Token(Token = "0x600FE82")]
		[Address(RVA = "0x72B7A0", Offset = "0x72A3A0", VA = "0x18072B7A0")]
		private bool <>xLuaBaseProxy_IsStayStill()
		{
			return default(bool);
		}

		// Token: 0x0600FE83 RID: 65155 RVA: 0x00060B40 File Offset: 0x0005ED40
		[Token(Token = "0x600FE83")]
		[Address(RVA = "0x765D80", Offset = "0x764980", VA = "0x180765D80")]
		private bool <>xLuaBaseProxy_IsInHitRange(Entity.HitRangeOption P0)
		{
			return default(bool);
		}

		// Token: 0x0600FE84 RID: 65156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE84")]
		[Address(RVA = "0x765DE0", Offset = "0x7649E0", VA = "0x180765DE0")]
		private void <>xLuaBaseProxy_SwitchSide(SideType P0)
		{
		}

		// Token: 0x0600FE85 RID: 65157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE85")]
		[Address(RVA = "0x765DC0", Offset = "0x7649C0", VA = "0x180765DC0")]
		private void <>xLuaBaseProxy_OnDirectionChanged()
		{
		}

		// Token: 0x0600FE86 RID: 65158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE86")]
		[Address(RVA = "0x72B810", Offset = "0x72A410", VA = "0x18072B810")]
		private void <>xLuaBaseProxy_SetHeight(float P0, bool P1)
		{
		}

		// Token: 0x0600FE87 RID: 65159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE87")]
		[Address(RVA = "0x75D620", Offset = "0x75C220", VA = "0x18075D620")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600FE88 RID: 65160 RVA: 0x00060B58 File Offset: 0x0005ED58
		[Token(Token = "0x600FE88")]
		[Address(RVA = "0x765EA0", Offset = "0x764AA0", VA = "0x180765EA0")]
		private HudPluginMask <>xLuaBaseProxy_get_hudPluginMask()
		{
			return HudPluginMask.NONE;
		}

		// Token: 0x04011AAA RID: 72362
		[Token(Token = "0x4011AAA")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		private bool _withdrawable;

		// Token: 0x04011AAB RID: 72363
		[Token(Token = "0x4011AAB")]
		[FieldOffset(Offset = "0x531")]
		[SerializeField]
		private bool _ignoreParentWithdrawable;

		// Token: 0x04011AAC RID: 72364
		[Token(Token = "0x4011AAC")]
		[FieldOffset(Offset = "0x534")]
		[SerializeField]
		private float _blockRadiusSquare;

		// Token: 0x04011AAD RID: 72365
		[Token(Token = "0x4011AAD")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		private string[] _filterTag;

		// Token: 0x04011AAE RID: 72366
		[Token(Token = "0x4011AAE")]
		[FieldOffset(Offset = "0x540")]
		[SerializeField]
		private bool _hideSpBarWhenEmpty;

		// Token: 0x04011AAF RID: 72367
		[Token(Token = "0x4011AAF")]
		[FieldOffset(Offset = "0x541")]
		[SerializeField]
		private bool _hideSpBarWhenFull;

		// Token: 0x04011AB0 RID: 72368
		[Token(Token = "0x4011AB0")]
		[FieldOffset(Offset = "0x542")]
		[SerializeField]
		private bool _hideSpBarWhenSkill;

		// Token: 0x04011AB1 RID: 72369
		[Token(Token = "0x4011AB1")]
		[FieldOffset(Offset = "0x543")]
		[SerializeField]
		private bool _hideSpBarWhenNotHaveSkill;

		// Token: 0x04011AB2 RID: 72370
		[Token(Token = "0x4011AB2")]
		[FieldOffset(Offset = "0x544")]
		[SerializeField]
		public bool _syncSpViaTiles;

		// Token: 0x04011AB3 RID: 72371
		[Token(Token = "0x4011AB3")]
		[FieldOffset(Offset = "0x545")]
		[SerializeField]
		private bool _disableUIHub;

		// Token: 0x04011AB4 RID: 72372
		[Token(Token = "0x4011AB4")]
		[FieldOffset(Offset = "0x548")]
		[SerializeField]
		private string _hitRangeId;

		// Token: 0x04011AB5 RID: 72373
		[Token(Token = "0x4011AB5")]
		[FieldOffset(Offset = "0x550")]
		[SerializeField]
		private bool _alwaysBlockFreeOptimize;

		// Token: 0x04011AB6 RID: 72374
		[Token(Token = "0x4011AB6")]
		[FieldOffset(Offset = "0x558")]
		private List<GridPosition> m_hitRangeGrids;

		// Token: 0x04011AB7 RID: 72375
		[Token(Token = "0x4011AB7")]
		[FieldOffset(Offset = "0x560")]
		private SideType m_sideType;

		// Token: 0x04011AB8 RID: 72376
		[Token(Token = "0x4011AB8")]
		[FieldOffset(Offset = "0x568")]
		private ListSet<Entity> m_syncSpList;

		// Token: 0x04011ABA RID: 72378
		[Token(Token = "0x4011ABA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isGiantTrap;

		// Token: 0x04011ABB RID: 72379
		[Token(Token = "0x4011ABB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_syncSpViaTiles;

		// Token: 0x04011ABC RID: 72380
		[Token(Token = "0x4011ABC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hideSpBarWhenEmpty;

		// Token: 0x04011ABD RID: 72381
		[Token(Token = "0x4011ABD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hideSpBarWhenFull;

		// Token: 0x04011ABE RID: 72382
		[Token(Token = "0x4011ABE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hideSpBarWhenSkill;

		// Token: 0x04011ABF RID: 72383
		[Token(Token = "0x4011ABF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_hideSpBarWhenNotHaveSkill;

		// Token: 0x04011AC0 RID: 72384
		[Token(Token = "0x4011AC0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hitRangeId;

		// Token: 0x04011AC1 RID: 72385
		[Token(Token = "0x4011AC1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_alwaysBlockFree;

		// Token: 0x04011AC2 RID: 72386
		[Token(Token = "0x4011AC2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetSpInternal;

		// Token: 0x04011AC3 RID: 72387
		[Token(Token = "0x4011AC3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_initSideType;

		// Token: 0x04011AC4 RID: 72388
		[Token(Token = "0x4011AC4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_disableUIHub;

		// Token: 0x04011AC5 RID: 72389
		[Token(Token = "0x4011AC5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_showShield;

		// Token: 0x04011AC6 RID: 72390
		[Token(Token = "0x4011AC6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_fogHideUIFlag;

		// Token: 0x04011AC7 RID: 72391
		[Token(Token = "0x4011AC7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_fogHideUIFlag;

		// Token: 0x04011AC8 RID: 72392
		[Token(Token = "0x4011AC8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_withdrawable;

		// Token: 0x04011AC9 RID: 72393
		[Token(Token = "0x4011AC9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_blockRadiusSquare;

		// Token: 0x04011ACA RID: 72394
		[Token(Token = "0x4011ACA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_startEffect;

		// Token: 0x04011ACB RID: 72395
		[Token(Token = "0x4011ACB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_deadEffect;

		// Token: 0x04011ACC RID: 72396
		[Token(Token = "0x4011ACC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011ACD RID: 72397
		[Token(Token = "0x4011ACD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckHasFilterTag;

		// Token: 0x04011ACE RID: 72398
		[Token(Token = "0x4011ACE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsStayStill;

		// Token: 0x04011ACF RID: 72399
		[Token(Token = "0x4011ACF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsInHitRange;

		// Token: 0x04011AD0 RID: 72400
		[Token(Token = "0x4011AD0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ResetHitRangeGrids;

		// Token: 0x04011AD1 RID: 72401
		[Token(Token = "0x4011AD1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SwitchSide;

		// Token: 0x04011AD2 RID: 72402
		[Token(Token = "0x4011AD2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnDirectionChanged;

		// Token: 0x04011AD3 RID: 72403
		[Token(Token = "0x4011AD3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SetHeight;

		// Token: 0x04011AD4 RID: 72404
		[Token(Token = "0x4011AD4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011AD5 RID: 72405
		[Token(Token = "0x4011AD5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_hudPluginMask;

		// Token: 0x04011AD6 RID: 72406
		[Token(Token = "0x4011AD6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
