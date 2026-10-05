using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B3A RID: 11066
	[Token(Token = "0x2002B3A")]
	public class ProjectileAuraAbility : AbilityStandard
	{
		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x060128E0 RID: 76000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170028E6")]
		public HashSet<ObjectPtr<Projectile>> projectiles
		{
			[Token(Token = "0x60128E0")]
			[Address(RVA = "0xA8DBC0", Offset = "0xA8C7C0", VA = "0x180A8DBC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x060128E1 RID: 76001 RVA: 0x00071BC8 File Offset: 0x0006FDC8
		[Token(Token = "0x170028E7")]
		public override FP cooldown
		{
			[Token(Token = "0x60128E1")]
			[Address(RVA = "0xA8DB40", Offset = "0xA8C740", VA = "0x180A8DB40", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x060128E2 RID: 76002 RVA: 0x00071BE0 File Offset: 0x0006FDE0
		[Token(Token = "0x170028E8")]
		public override Ability.Category category
		{
			[Token(Token = "0x60128E2")]
			[Address(RVA = "0xA8DAE0", Offset = "0xA8C6E0", VA = "0x180A8DAE0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x060128E3 RID: 76003 RVA: 0x00071BF8 File Offset: 0x0006FDF8
		[Token(Token = "0x170028E9")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x60128E3")]
			[Address(RVA = "0xA8DCA0", Offset = "0xA8C8A0", VA = "0x180A8DCA0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x060128E4 RID: 76004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170028EA")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x60128E4")]
			[Address(RVA = "0xA8DC20", Offset = "0xA8C820", VA = "0x180A8DC20", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x060128E5 RID: 76005 RVA: 0x00071C10 File Offset: 0x0006FE10
		[Token(Token = "0x170028EB")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x60128E5")]
			[Address(RVA = "0xA8DA80", Offset = "0xA8C680", VA = "0x180A8DA80", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060128E6 RID: 76006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128E6")]
		[Address(RVA = "0xA8C7D0", Offset = "0xA8B3D0", VA = "0x180A8C7D0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060128E7 RID: 76007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128E7")]
		[Address(RVA = "0xA8C8A0", Offset = "0xA8B4A0", VA = "0x180A8C8A0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060128E8 RID: 76008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128E8")]
		[Address(RVA = "0xA8C840", Offset = "0xA8B440", VA = "0x180A8C840", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x060128E9 RID: 76009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128E9")]
		[Address(RVA = "0xA8C770", Offset = "0xA8B370", VA = "0x180A8C770", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x060128EA RID: 76010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128EA")]
		[Address(RVA = "0xA8CB90", Offset = "0xA8B790", VA = "0x180A8CB90", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x060128EB RID: 76011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128EB")]
		[Address(RVA = "0xA8CB00", Offset = "0xA8B700", VA = "0x180A8CB00", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x060128EC RID: 76012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128EC")]
		[Address(RVA = "0xA8CC20", Offset = "0xA8B820", VA = "0x180A8CC20", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060128ED RID: 76013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128ED")]
		[Address(RVA = "0xA8C470", Offset = "0xA8B070", VA = "0x180A8C470", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060128EE RID: 76014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128EE")]
		[Address(RVA = "0xA8BFF0", Offset = "0xA8ABF0", VA = "0x180A8BFF0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060128EF RID: 76015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128EF")]
		[Address(RVA = "0xA8C280", Offset = "0xA8AE80", VA = "0x180A8C280", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060128F0 RID: 76016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F0")]
		[Address(RVA = "0xA8C6C0", Offset = "0xA8B2C0", VA = "0x180A8C6C0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060128F1 RID: 76017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F1")]
		[Address(RVA = "0xA8BF60", Offset = "0xA8AB60", VA = "0x180A8BF60", Slot = "95")]
		protected override void Awake()
		{
		}

		// Token: 0x060128F2 RID: 76018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F2")]
		[Address(RVA = "0xA8C930", Offset = "0xA8B530", VA = "0x180A8C930", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060128F3 RID: 76019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F3")]
		[Address(RVA = "0xA8D400", Offset = "0xA8C000", VA = "0x180A8D400")]
		private void _ClearEffects()
		{
		}

		// Token: 0x060128F4 RID: 76020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F4")]
		[Address(RVA = "0xA8D020", Offset = "0xA8BC20", VA = "0x180A8D020")]
		private void _CheckProjectilesInAura()
		{
		}

		// Token: 0x060128F5 RID: 76021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F5")]
		[Address(RVA = "0xA8CCB0", Offset = "0xA8B8B0", VA = "0x180A8CCB0")]
		private void _CheckProjectileValid()
		{
		}

		// Token: 0x060128F6 RID: 76022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F6")]
		[Address(RVA = "0xA8D5B0", Offset = "0xA8C1B0", VA = "0x180A8D5B0")]
		private void _DoProjectileEnter(Projectile projectile)
		{
		}

		// Token: 0x060128F7 RID: 76023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F7")]
		[Address(RVA = "0xA8D790", Offset = "0xA8C390", VA = "0x180A8D790")]
		private void _DoProjectileExit(Projectile projectile)
		{
		}

		// Token: 0x060128F8 RID: 76024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128F8")]
		[Address(RVA = "0xA8D970", Offset = "0xA8C570", VA = "0x180A8D970")]
		public ProjectileAuraAbility()
		{
		}

		// Token: 0x060128F9 RID: 76025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128F9")]
		[Address(RVA = "0xA6F370", Offset = "0xA6DF70", VA = "0x180A6F370")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x060128FA RID: 76026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128FA")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060128FB RID: 76027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128FB")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060128FC RID: 76028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128FC")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060128FD RID: 76029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128FD")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x060128FE RID: 76030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128FE")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x060128FF RID: 76031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128FF")]
		[Address(RVA = "0xA4FF40", Offset = "0xA4EB40", VA = "0x180A4FF40")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x06012900 RID: 76032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012900")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014F71 RID: 85873
		[Token(Token = "0x4014F71")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x04014F72 RID: 85874
		[Token(Token = "0x4014F72")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ProjectileValidator _projectileValidator;

		// Token: 0x04014F73 RID: 85875
		[Token(Token = "0x4014F73")]
		[FieldOffset(Offset = "0x120")]
		private HashSet<ObjectPtr<Projectile>> m_projectiles;

		// Token: 0x04014F74 RID: 85876
		[Token(Token = "0x4014F74")]
		[FieldOffset(Offset = "0x128")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04014F75 RID: 85877
		[Token(Token = "0x4014F75")]
		[FieldOffset(Offset = "0x130")]
		private List<ObjectPtr<Projectile>> m_invalidProjectiles;

		// Token: 0x04014F76 RID: 85878
		[Token(Token = "0x4014F76")]
		[FieldOffset(Offset = "0x138")]
		private Range m_range;

		// Token: 0x04014F77 RID: 85879
		[Token(Token = "0x4014F77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_projectiles;

		// Token: 0x04014F78 RID: 85880
		[Token(Token = "0x4014F78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014F79 RID: 85881
		[Token(Token = "0x4014F79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014F7A RID: 85882
		[Token(Token = "0x4014F7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014F7B RID: 85883
		[Token(Token = "0x4014F7B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x04014F7C RID: 85884
		[Token(Token = "0x4014F7C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014F7D RID: 85885
		[Token(Token = "0x4014F7D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014F7E RID: 85886
		[Token(Token = "0x4014F7E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014F7F RID: 85887
		[Token(Token = "0x4014F7F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014F80 RID: 85888
		[Token(Token = "0x4014F80")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014F81 RID: 85889
		[Token(Token = "0x4014F81")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014F82 RID: 85890
		[Token(Token = "0x4014F82")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014F83 RID: 85891
		[Token(Token = "0x4014F83")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014F84 RID: 85892
		[Token(Token = "0x4014F84")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014F85 RID: 85893
		[Token(Token = "0x4014F85")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014F86 RID: 85894
		[Token(Token = "0x4014F86")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014F87 RID: 85895
		[Token(Token = "0x4014F87")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014F88 RID: 85896
		[Token(Token = "0x4014F88")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04014F89 RID: 85897
		[Token(Token = "0x4014F89")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014F8A RID: 85898
		[Token(Token = "0x4014F8A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x04014F8B RID: 85899
		[Token(Token = "0x4014F8B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckProjectilesInAura;

		// Token: 0x04014F8C RID: 85900
		[Token(Token = "0x4014F8C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckProjectileValid;

		// Token: 0x04014F8D RID: 85901
		[Token(Token = "0x4014F8D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__DoProjectileEnter;

		// Token: 0x04014F8E RID: 85902
		[Token(Token = "0x4014F8E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__DoProjectileExit;

		// Token: 0x04014F8F RID: 85903
		[Token(Token = "0x4014F8F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B3B RID: 11067
		[Token(Token = "0x2002B3B")]
		public class ProjectileAuraBehaviour : AbilityStandard.Behaviour
		{
			// Token: 0x06012901 RID: 76033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012901")]
			[Address(RVA = "0xA8DDC0", Offset = "0xA8C9C0", VA = "0x180A8DDC0", Slot = "16")]
			public new virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06012902 RID: 76034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012902")]
			[Address(RVA = "0xA8DD00", Offset = "0xA8C900", VA = "0x180A8DD00", Slot = "17")]
			public virtual void OnProjectileEnter(Projectile projectile)
			{
			}

			// Token: 0x06012903 RID: 76035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012903")]
			[Address(RVA = "0xA8DD60", Offset = "0xA8C960", VA = "0x180A8DD60", Slot = "18")]
			public virtual void OnProjectileExit(Projectile projectile)
			{
			}

			// Token: 0x06012904 RID: 76036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012904")]
			[Address(RVA = "0xA8DE20", Offset = "0xA8CA20", VA = "0x180A8DE20")]
			public ProjectileAuraBehaviour()
			{
			}

			// Token: 0x04014F90 RID: 85904
			[Token(Token = "0x4014F90")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04014F91 RID: 85905
			[Token(Token = "0x4014F91")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnProjectileEnter;

			// Token: 0x04014F92 RID: 85906
			[Token(Token = "0x4014F92")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnProjectileExit;

			// Token: 0x04014F93 RID: 85907
			[Token(Token = "0x4014F93")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
