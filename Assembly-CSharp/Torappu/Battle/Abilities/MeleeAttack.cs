using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A9D RID: 10909
	[Token(Token = "0x2002A9D")]
	public class MeleeAttack : AbstractBasicAttack
	{
		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x060121D8 RID: 74200 RVA: 0x0006EFA0 File Offset: 0x0006D1A0
		[Token(Token = "0x170027C9")]
		public override SourceApplyWay applyWay
		{
			[Token(Token = "0x60121D8")]
			[Address(RVA = "0xA26130", Offset = "0xA24D30", VA = "0x180A26130", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x060121D9 RID: 74201 RVA: 0x0006EFB8 File Offset: 0x0006D1B8
		[Token(Token = "0x170027CA")]
		protected override DamageType damageType
		{
			[Token(Token = "0x60121D9")]
			[Address(RVA = "0xA26190", Offset = "0xA24D90", VA = "0x180A26190", Slot = "108")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x060121DA RID: 74202 RVA: 0x0006EFD0 File Offset: 0x0006D1D0
		[Token(Token = "0x170027CB")]
		protected override DamageType extraDamageType
		{
			[Token(Token = "0x60121DA")]
			[Address(RVA = "0xA261F0", Offset = "0xA24DF0", VA = "0x180A261F0", Slot = "109")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x060121DB RID: 74203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121DB")]
		[Address(RVA = "0xA25BE0", Offset = "0xA247E0", VA = "0x180A25BE0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060121DC RID: 74204 RVA: 0x0006EFE8 File Offset: 0x0006D1E8
		[Token(Token = "0x60121DC")]
		[Address(RVA = "0xA25970", Offset = "0xA24570", VA = "0x180A25970", Slot = "84")]
		protected override bool CheckActiveBuffs(Entity target, IList<BuffData> buffs)
		{
			return default(bool);
		}

		// Token: 0x060121DD RID: 74205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121DD")]
		[Address(RVA = "0xA25C60", Offset = "0xA24860", VA = "0x180A25C60", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060121DE RID: 74206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121DE")]
		[Address(RVA = "0xA25AD0", Offset = "0xA246D0", VA = "0x180A25AD0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060121DF RID: 74207 RVA: 0x0006F000 File Offset: 0x0006D200
		[Token(Token = "0x60121DF")]
		[Address(RVA = "0xA25D50", Offset = "0xA24950", VA = "0x180A25D50", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x060121E0 RID: 74208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121E0")]
		[Address(RVA = "0xA25FA0", Offset = "0xA24BA0", VA = "0x180A25FA0")]
		public MeleeAttack()
		{
		}

		// Token: 0x060121E1 RID: 74209 RVA: 0x0006F018 File Offset: 0x0006D218
		[Token(Token = "0x60121E1")]
		[Address(RVA = "0xA25D40", Offset = "0xA24940", VA = "0x180A25D40")]
		private SourceApplyWay <>xLuaBaseProxy_get_applyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x060121E2 RID: 74210 RVA: 0x0006F030 File Offset: 0x0006D230
		[Token(Token = "0x60121E2")]
		[Address(RVA = "0xA25CF0", Offset = "0xA248F0", VA = "0x180A25CF0")]
		private bool <>xLuaBaseProxy_CheckActiveBuffs(Entity P0, IList<BuffData> P1)
		{
			return default(bool);
		}

		// Token: 0x060121E3 RID: 74211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121E3")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060121E4 RID: 74212 RVA: 0x0006F048 File Offset: 0x0006D248
		[Token(Token = "0x60121E4")]
		[Address(RVA = "0xA25D30", Offset = "0xA24930", VA = "0x180A25D30")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x040147FB RID: 83963
		[Token(Token = "0x40147FB")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private DamageType _damageType;

		// Token: 0x040147FC RID: 83964
		[Token(Token = "0x40147FC")]
		[FieldOffset(Offset = "0x20C")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private DamageType _extraDamageType;

		// Token: 0x040147FD RID: 83965
		[Token(Token = "0x40147FD")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Inspect("alwaysIncludeTarget")]
		private bool _alwaysPutIncludeTargetFirst;

		// Token: 0x040147FE RID: 83966
		[Token(Token = "0x40147FE")]
		[FieldOffset(Offset = "0x214")]
		private float m_buffProb;

		// Token: 0x040147FF RID: 83967
		[Token(Token = "0x40147FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x04014800 RID: 83968
		[Token(Token = "0x4014800")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_damageType;

		// Token: 0x04014801 RID: 83969
		[Token(Token = "0x4014801")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_extraDamageType;

		// Token: 0x04014802 RID: 83970
		[Token(Token = "0x4014802")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014803 RID: 83971
		[Token(Token = "0x4014803")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckActiveBuffs;

		// Token: 0x04014804 RID: 83972
		[Token(Token = "0x4014804")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014805 RID: 83973
		[Token(Token = "0x4014805")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014806 RID: 83974
		[Token(Token = "0x4014806")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04014807 RID: 83975
		[Token(Token = "0x4014807")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
