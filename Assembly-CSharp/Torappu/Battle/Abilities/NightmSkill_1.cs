using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BAB RID: 11179
	[Token(Token = "0x2002BAB")]
	public class NightmSkill_1 : AbstractBasicAttack
	{
		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x06012DA4 RID: 77220 RVA: 0x000736F8 File Offset: 0x000718F8
		[Token(Token = "0x17002999")]
		public override SourceApplyWay applyWay
		{
			[Token(Token = "0x6012DA4")]
			[Address(RVA = "0xAC8550", Offset = "0xAC7150", VA = "0x180AC8550", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x06012DA5 RID: 77221 RVA: 0x00073710 File Offset: 0x00071910
		[Token(Token = "0x1700299A")]
		protected override DamageType damageType
		{
			[Token(Token = "0x6012DA5")]
			[Address(RVA = "0xAC85B0", Offset = "0xAC71B0", VA = "0x180AC85B0", Slot = "108")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x06012DA6 RID: 77222 RVA: 0x00073728 File Offset: 0x00071928
		[Token(Token = "0x1700299B")]
		protected override DamageType extraDamageType
		{
			[Token(Token = "0x6012DA6")]
			[Address(RVA = "0xAC8620", Offset = "0xAC7220", VA = "0x180AC8620", Slot = "109")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x06012DA7 RID: 77223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DA7")]
		[Address(RVA = "0xAC7E40", Offset = "0xAC6A40", VA = "0x180AC7E40", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012DA8 RID: 77224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DA8")]
		[Address(RVA = "0xAC7EC0", Offset = "0xAC6AC0", VA = "0x180AC7EC0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012DA9 RID: 77225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DA9")]
		[Address(RVA = "0xAC7B60", Offset = "0xAC6760", VA = "0x180AC7B60", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012DAA RID: 77226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DAA")]
		[Address(RVA = "0xAC8050", Offset = "0xAC6C50", VA = "0x180AC8050", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012DAB RID: 77227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DAB")]
		[Address(RVA = "0xAC7F90", Offset = "0xAC6B90", VA = "0x180AC7F90", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012DAC RID: 77228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DAC")]
		[Address(RVA = "0xAC8140", Offset = "0xAC6D40", VA = "0x180AC8140")]
		private void _OnHitPrimaryTarget(Entity primaryTarget)
		{
		}

		// Token: 0x06012DAD RID: 77229 RVA: 0x00073740 File Offset: 0x00071940
		[Token(Token = "0x6012DAD")]
		[Address(RVA = "0xAC7DE0", Offset = "0xAC69E0", VA = "0x180AC7DE0", Slot = "90")]
		protected override ActionPurposeMask GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x06012DAE RID: 77230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DAE")]
		[Address(RVA = "0xAC8400", Offset = "0xAC7000", VA = "0x180AC8400")]
		public NightmSkill_1()
		{
		}

		// Token: 0x06012DAF RID: 77231 RVA: 0x00073758 File Offset: 0x00071958
		[Token(Token = "0x6012DAF")]
		[Address(RVA = "0xA25D40", Offset = "0xA24940", VA = "0x180A25D40")]
		private SourceApplyWay <>xLuaBaseProxy_get_applyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x06012DB0 RID: 77232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DB0")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012DB1 RID: 77233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DB1")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012DB2 RID: 77234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DB2")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012DB3 RID: 77235 RVA: 0x00073770 File Offset: 0x00071970
		[Token(Token = "0x6012DB3")]
		[Address(RVA = "0xAC8130", Offset = "0xAC6D30", VA = "0x180AC8130")]
		private ActionPurposeMask <>xLuaBaseProxy_GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x04015469 RID: 87145
		[Token(Token = "0x4015469")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private NightmSkill_1.ProjectileOptions _primaryOptions;

		// Token: 0x0401546A RID: 87146
		[Token(Token = "0x401546A")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private NightmSkill_1.ProjectileOptions _secondaryOptions;

		// Token: 0x0401546B RID: 87147
		[Token(Token = "0x401546B")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private TargetSelector _secondarySelector;

		// Token: 0x0401546C RID: 87148
		[Token(Token = "0x401546C")]
		[FieldOffset(Offset = "0x220")]
		private List<ActionNode> m_secondaryActions;

		// Token: 0x0401546D RID: 87149
		[Token(Token = "0x401546D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x0401546E RID: 87150
		[Token(Token = "0x401546E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_damageType;

		// Token: 0x0401546F RID: 87151
		[Token(Token = "0x401546F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_extraDamageType;

		// Token: 0x04015470 RID: 87152
		[Token(Token = "0x4015470")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015471 RID: 87153
		[Token(Token = "0x4015471")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015472 RID: 87154
		[Token(Token = "0x4015472")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015473 RID: 87155
		[Token(Token = "0x4015473")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015474 RID: 87156
		[Token(Token = "0x4015474")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04015475 RID: 87157
		[Token(Token = "0x4015475")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnHitPrimaryTarget;

		// Token: 0x04015476 RID: 87158
		[Token(Token = "0x4015476")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GeneratePurposeMask;

		// Token: 0x04015477 RID: 87159
		[Token(Token = "0x4015477")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BAC RID: 11180
		[Token(Token = "0x2002BAC")]
		[Serializable]
		public class ProjectileOptions
		{
			// Token: 0x1700299C RID: 10652
			// (get) Token: 0x06012DB4 RID: 77236 RVA: 0x00073788 File Offset: 0x00071988
			[Token(Token = "0x1700299C")]
			public bool isValid
			{
				[Token(Token = "0x6012DB4")]
				[Address(RVA = "0xAC8CE0", Offset = "0xAC78E0", VA = "0x180AC8CE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06012DB5 RID: 77237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012DB5")]
			[Address(RVA = "0xAC8CC0", Offset = "0xAC78C0", VA = "0x180AC8CC0")]
			public ProjectileOptions()
			{
			}

			// Token: 0x04015478 RID: 87160
			[Token(Token = "0x4015478")]
			[FieldOffset(Offset = "0x10")]
			public string projectileKey;

			// Token: 0x04015479 RID: 87161
			[Token(Token = "0x4015479")]
			[FieldOffset(Offset = "0x18")]
			public Entity.MountPointType mountPointType;

			// Token: 0x0401547A RID: 87162
			[Token(Token = "0x401547A")]
			[FieldOffset(Offset = "0x1C")]
			public DamageType damageType;
		}
	}
}
