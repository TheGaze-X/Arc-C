using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B43 RID: 11075
	[Token(Token = "0x2002B43")]
	public class GlobalUniqueBuffToTargetsBySelectorAbility : AbstractAnimatedAbility, IBuffSource
	{
		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x06012965 RID: 76133 RVA: 0x00071D90 File Offset: 0x0006FF90
		[Token(Token = "0x170028F6")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012965")]
			[Address(RVA = "0xA88AE0", Offset = "0xA876E0", VA = "0x180A88AE0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x06012966 RID: 76134 RVA: 0x00071DA8 File Offset: 0x0006FFA8
		[Token(Token = "0x170028F7")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012966")]
			[Address(RVA = "0xA88A80", Offset = "0xA87680", VA = "0x180A88A80", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012967 RID: 76135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012967")]
		[Address(RVA = "0xA87900", Offset = "0xA86500", VA = "0x180A87900", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012968 RID: 76136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012968")]
		[Address(RVA = "0xA879D0", Offset = "0xA865D0", VA = "0x180A879D0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012969 RID: 76137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012969")]
		[Address(RVA = "0xA87970", Offset = "0xA86570", VA = "0x180A87970", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0601296A RID: 76138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601296A")]
		[Address(RVA = "0xA878A0", Offset = "0xA864A0", VA = "0x180A878A0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601296B RID: 76139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601296B")]
		[Address(RVA = "0xA877F0", Offset = "0xA863F0", VA = "0x180A877F0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0601296C RID: 76140 RVA: 0x00071DC0 File Offset: 0x0006FFC0
		[Token(Token = "0x601296C")]
		[Address(RVA = "0xA87B60", Offset = "0xA86760", VA = "0x180A87B60", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x0601296D RID: 76141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601296D")]
		[Address(RVA = "0xA87C70", Offset = "0xA86870", VA = "0x180A87C70", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x0601296E RID: 76142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601296E")]
		[Address(RVA = "0xA87AF0", Offset = "0xA866F0", VA = "0x180A87AF0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x0601296F RID: 76143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601296F")]
		[Address(RVA = "0xA87A60", Offset = "0xA86660", VA = "0x180A87A60", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012970 RID: 76144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012970")]
		[Address(RVA = "0xA87BE0", Offset = "0xA867E0", VA = "0x180A87BE0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012971 RID: 76145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012971")]
		[Address(RVA = "0xA88260", Offset = "0xA86E60", VA = "0x180A88260")]
		private void _DoUpdateTarget()
		{
		}

		// Token: 0x06012972 RID: 76146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012972")]
		[Address(RVA = "0xA87D30", Offset = "0xA86930", VA = "0x180A87D30")]
		private void _DoAddBuff(Entity target)
		{
		}

		// Token: 0x06012973 RID: 76147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012973")]
		[Address(RVA = "0xA87F90", Offset = "0xA86B90", VA = "0x180A87F90")]
		private void _DoRemoveAllBuffs()
		{
		}

		// Token: 0x06012974 RID: 76148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012974")]
		[Address(RVA = "0xA88990", Offset = "0xA87590", VA = "0x180A88990")]
		public GlobalUniqueBuffToTargetsBySelectorAbility()
		{
		}

		// Token: 0x06012975 RID: 76149 RVA: 0x00071DD8 File Offset: 0x0006FFD8
		[Token(Token = "0x6012975")]
		[Address(RVA = "0xA87D20", Offset = "0xA86920", VA = "0x180A87D20")]
		private AbilityStandard.SelectTargetSource <>xLuaBaseProxy_get_selectTargetSource()
		{
			return AbilityStandard.SelectTargetSource.NONE;
		}

		// Token: 0x06012976 RID: 76150 RVA: 0x00071DF0 File Offset: 0x0006FFF0
		[Token(Token = "0x6012976")]
		[Address(RVA = "0xA5C1A0", Offset = "0xA5ADA0", VA = "0x180A5C1A0")]
		private bool <>xLuaBaseProxy_get_alwaysIncludeTarget()
		{
			return default(bool);
		}

		// Token: 0x06012977 RID: 76151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012977")]
		[Address(RVA = "0xA56970", Offset = "0xA55570", VA = "0x180A56970")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012978 RID: 76152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012978")]
		[Address(RVA = "0xA275B0", Offset = "0xA261B0", VA = "0x180A275B0")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012979 RID: 76153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012979")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0601297A RID: 76154 RVA: 0x00071E08 File Offset: 0x00070008
		[Token(Token = "0x601297A")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x0601297B RID: 76155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601297B")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x0601297C RID: 76156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601297C")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x0601297D RID: 76157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601297D")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x0601297E RID: 76158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601297E")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014FF4 RID: 86004
		[Token(Token = "0x4014FF4")]
		private const string ABILITY_MARK_STRING = ".global_unibuff_mark";

		// Token: 0x04014FF5 RID: 86005
		[Token(Token = "0x4014FF5")]
		private const string ABILITY_MARK_ON_STRING = ".global_unibuff_mark_on";

		// Token: 0x04014FF6 RID: 86006
		[Token(Token = "0x4014FF6")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		protected BuffData _uniqueBuff;

		// Token: 0x04014FF7 RID: 86007
		[Token(Token = "0x4014FF7")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		protected bool _removeBuffWhenCastEnd;

		// Token: 0x04014FF8 RID: 86008
		[Token(Token = "0x4014FF8")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private string _markOnTargetSignal;

		// Token: 0x04014FF9 RID: 86009
		[Token(Token = "0x4014FF9")]
		[FieldOffset(Offset = "0x1E0")]
		private ListDict<ObjectPtr<Entity>, ObjectPtr<Buff>> m_targets;

		// Token: 0x04014FFA RID: 86010
		[Token(Token = "0x4014FFA")]
		[FieldOffset(Offset = "0x1E8")]
		private bool m_startCheck;

		// Token: 0x04014FFB RID: 86011
		[Token(Token = "0x4014FFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014FFC RID: 86012
		[Token(Token = "0x4014FFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014FFD RID: 86013
		[Token(Token = "0x4014FFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014FFE RID: 86014
		[Token(Token = "0x4014FFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014FFF RID: 86015
		[Token(Token = "0x4014FFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015000 RID: 86016
		[Token(Token = "0x4015000")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04015001 RID: 86017
		[Token(Token = "0x4015001")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015002 RID: 86018
		[Token(Token = "0x4015002")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x04015003 RID: 86019
		[Token(Token = "0x4015003")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015004 RID: 86020
		[Token(Token = "0x4015004")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015005 RID: 86021
		[Token(Token = "0x4015005")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04015006 RID: 86022
		[Token(Token = "0x4015006")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015007 RID: 86023
		[Token(Token = "0x4015007")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoUpdateTarget;

		// Token: 0x04015008 RID: 86024
		[Token(Token = "0x4015008")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoAddBuff;

		// Token: 0x04015009 RID: 86025
		[Token(Token = "0x4015009")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoRemoveAllBuffs;

		// Token: 0x0401500A RID: 86026
		[Token(Token = "0x401500A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
