using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B8C RID: 11148
	[Token(Token = "0x2002B8C")]
	public class BsnakeScreenAttack : AbstractBasicAttack
	{
		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x06012C17 RID: 76823 RVA: 0x00072DB0 File Offset: 0x00070FB0
		[Token(Token = "0x17002959")]
		protected override DamageType damageType
		{
			[Token(Token = "0x6012C17")]
			[Address(RVA = "0xAB28B0", Offset = "0xAB14B0", VA = "0x180AB28B0", Slot = "108")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x06012C18 RID: 76824 RVA: 0x00072DC8 File Offset: 0x00070FC8
		[Token(Token = "0x1700295A")]
		protected override DamageType extraDamageType
		{
			[Token(Token = "0x6012C18")]
			[Address(RVA = "0xAB2910", Offset = "0xAB1510", VA = "0x180AB2910", Slot = "109")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x06012C19 RID: 76825 RVA: 0x00072DE0 File Offset: 0x00070FE0
		[Token(Token = "0x1700295B")]
		public override SourceApplyWay applyWay
		{
			[Token(Token = "0x6012C19")]
			[Address(RVA = "0xAB2850", Offset = "0xAB1450", VA = "0x180AB2850", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x06012C1A RID: 76826 RVA: 0x00072DF8 File Offset: 0x00070FF8
		[Token(Token = "0x6012C1A")]
		[Address(RVA = "0xAB1FD0", Offset = "0xAB0BD0", VA = "0x180AB1FD0", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x06012C1B RID: 76827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C1B")]
		[Address(RVA = "0xAB26F0", Offset = "0xAB12F0", VA = "0x180AB26F0", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012C1C RID: 76828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C1C")]
		[Address(RVA = "0xAB2410", Offset = "0xAB1010", VA = "0x180AB2410", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012C1D RID: 76829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C1D")]
		[Address(RVA = "0xAB2480", Offset = "0xAB1080", VA = "0x180AB2480", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012C1E RID: 76830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C1E")]
		[Address(RVA = "0xAB2350", Offset = "0xAB0F50", VA = "0x180AB2350", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x06012C1F RID: 76831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C1F")]
		[Address(RVA = "0xAB2550", Offset = "0xAB1150", VA = "0x180AB2550", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x06012C20 RID: 76832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C20")]
		[Address(RVA = "0xAB2790", Offset = "0xAB1390", VA = "0x180AB2790")]
		public BsnakeScreenAttack()
		{
		}

		// Token: 0x06012C21 RID: 76833 RVA: 0x00072E10 File Offset: 0x00071010
		[Token(Token = "0x6012C21")]
		[Address(RVA = "0xA25D40", Offset = "0xA24940", VA = "0x180A25D40")]
		private SourceApplyWay <>xLuaBaseProxy_get_applyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x06012C22 RID: 76834 RVA: 0x00072E28 File Offset: 0x00071028
		[Token(Token = "0x6012C22")]
		[Address(RVA = "0xA25730", Offset = "0xA24330", VA = "0x180A25730")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x06012C23 RID: 76835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C23")]
		[Address(RVA = "0xA1FD50", Offset = "0xA1E950", VA = "0x180A1FD50")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012C24 RID: 76836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C24")]
		[Address(RVA = "0xA4B080", Offset = "0xA49C80", VA = "0x180A4B080")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x06012C25 RID: 76837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C25")]
		[Address(RVA = "0xA4B0A0", Offset = "0xA49CA0", VA = "0x180A4B0A0")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x0401530C RID: 86796
		[Token(Token = "0x401530C")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Group("BsnakeScreenAttack")]
		private string _projectileKey;

		// Token: 0x0401530D RID: 86797
		[Token(Token = "0x401530D")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("BsnakeScreenAttack")]
		private DamageType _damageType;

		// Token: 0x0401530E RID: 86798
		[Token(Token = "0x401530E")]
		[FieldOffset(Offset = "0x214")]
		[SerializeField]
		[Group("BsnakeScreenAttack")]
		private int _borderToPeel;

		// Token: 0x0401530F RID: 86799
		[Token(Token = "0x401530F")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Group("BsnakeScreenAttack")]
		private float _heightOverHighland;

		// Token: 0x04015310 RID: 86800
		[Token(Token = "0x4015310")]
		[FieldOffset(Offset = "0x220")]
		protected List<ObjectPtr<Projectile>> m_projectiles;

		// Token: 0x04015311 RID: 86801
		[Token(Token = "0x4015311")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_damageType;

		// Token: 0x04015312 RID: 86802
		[Token(Token = "0x4015312")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_extraDamageType;

		// Token: 0x04015313 RID: 86803
		[Token(Token = "0x4015313")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x04015314 RID: 86804
		[Token(Token = "0x4015314")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x04015315 RID: 86805
		[Token(Token = "0x4015315")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015316 RID: 86806
		[Token(Token = "0x4015316")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015317 RID: 86807
		[Token(Token = "0x4015317")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015318 RID: 86808
		[Token(Token = "0x4015318")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04015319 RID: 86809
		[Token(Token = "0x4015319")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x0401531A RID: 86810
		[Token(Token = "0x401531A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
