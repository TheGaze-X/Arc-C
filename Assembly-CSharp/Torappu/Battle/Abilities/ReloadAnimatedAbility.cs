using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BB2 RID: 11186
	[Token(Token = "0x2002BB2")]
	public class ReloadAnimatedAbility : AbstractAnimatedAbility
	{
		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x06012DE4 RID: 77284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029A1")]
		private Ability traitAbiliy
		{
			[Token(Token = "0x6012DE4")]
			[Address(RVA = "0xACBC80", Offset = "0xACA880", VA = "0x180ACBC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x06012DE5 RID: 77285 RVA: 0x00073908 File Offset: 0x00071B08
		[Token(Token = "0x170029A2")]
		public override FP cooldown
		{
			[Token(Token = "0x6012DE5")]
			[Address(RVA = "0xACBC20", Offset = "0xACA820", VA = "0x180ACBC20", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06012DE6 RID: 77286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DE6")]
		[Address(RVA = "0xACB4D0", Offset = "0xACA0D0", VA = "0x180ACB4D0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012DE7 RID: 77287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DE7")]
		[Address(RVA = "0xACB560", Offset = "0xACA160", VA = "0x180ACB560", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012DE8 RID: 77288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DE8")]
		[Address(RVA = "0xACB840", Offset = "0xACA440", VA = "0x180ACB840", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012DE9 RID: 77289 RVA: 0x00073920 File Offset: 0x00071B20
		[Token(Token = "0x6012DE9")]
		[Address(RVA = "0xACB8C0", Offset = "0xACA4C0", VA = "0x180ACB8C0", Slot = "88")]
		protected override bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float animSpeed)
		{
			return default(bool);
		}

		// Token: 0x06012DEA RID: 77290 RVA: 0x00073938 File Offset: 0x00071B38
		[Token(Token = "0x6012DEA")]
		[Address(RVA = "0xACBA00", Offset = "0xACA600", VA = "0x180ACBA00")]
		private FP _CalculateCooldown()
		{
			return default(FP);
		}

		// Token: 0x06012DEB RID: 77291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DEB")]
		[Address(RVA = "0xACB7B0", Offset = "0xACA3B0", VA = "0x180ACB7B0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012DEC RID: 77292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DEC")]
		[Address(RVA = "0xACB740", Offset = "0xACA340", VA = "0x180ACB740", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012DED RID: 77293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DED")]
		[Address(RVA = "0xACBBC0", Offset = "0xACA7C0", VA = "0x180ACBBC0")]
		public ReloadAnimatedAbility()
		{
		}

		// Token: 0x06012DEE RID: 77294 RVA: 0x00073950 File Offset: 0x00071B50
		[Token(Token = "0x6012DEE")]
		[Address(RVA = "0xA1FD80", Offset = "0xA1E980", VA = "0x180A1FD80")]
		private FP <>xLuaBaseProxy_get_cooldown()
		{
			return default(FP);
		}

		// Token: 0x06012DEF RID: 77295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DEF")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012DF0 RID: 77296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DF0")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012DF1 RID: 77297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DF1")]
		[Address(RVA = "0xA1E530", Offset = "0xA1D130", VA = "0x180A1E530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012DF2 RID: 77298 RVA: 0x00073968 File Offset: 0x00071B68
		[Token(Token = "0x6012DF2")]
		[Address(RVA = "0xACB8B0", Offset = "0xACA4B0", VA = "0x180ACB8B0")]
		private bool <>xLuaBaseProxy_UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x040154B0 RID: 87216
		[Token(Token = "0x40154B0")]
		[FieldOffset(Offset = "0x1C8")]
		private Ability m_traitAbility;

		// Token: 0x040154B1 RID: 87217
		[Token(Token = "0x40154B1")]
		[FieldOffset(Offset = "0x1D0")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Reload")]
		private FP m_reloadCooldown;

		// Token: 0x040154B2 RID: 87218
		[Token(Token = "0x40154B2")]
		[FieldOffset(Offset = "0x1D8")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Reload")]
		private FP m_defaultBaseAttackTime;

		// Token: 0x040154B3 RID: 87219
		[Token(Token = "0x40154B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_traitAbiliy;

		// Token: 0x040154B4 RID: 87220
		[Token(Token = "0x40154B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040154B5 RID: 87221
		[Token(Token = "0x40154B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040154B6 RID: 87222
		[Token(Token = "0x40154B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040154B7 RID: 87223
		[Token(Token = "0x40154B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040154B8 RID: 87224
		[Token(Token = "0x40154B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x040154B9 RID: 87225
		[Token(Token = "0x40154B9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalculateCooldown;

		// Token: 0x040154BA RID: 87226
		[Token(Token = "0x40154BA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040154BB RID: 87227
		[Token(Token = "0x40154BB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x040154BC RID: 87228
		[Token(Token = "0x40154BC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
