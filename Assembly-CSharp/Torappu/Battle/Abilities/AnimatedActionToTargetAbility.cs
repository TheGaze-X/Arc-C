using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A90 RID: 10896
	[Token(Token = "0x2002A90")]
	public class AnimatedActionToTargetAbility : AbstractAnimatedAbility
	{
		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x06012164 RID: 74084 RVA: 0x0006EB38 File Offset: 0x0006CD38
		[Token(Token = "0x170027B2")]
		protected override Modifier.SourceAttackType attackType
		{
			[Token(Token = "0x6012164")]
			[Address(RVA = "0xA1F120", Offset = "0xA1DD20", VA = "0x180A1F120", Slot = "99")]
			get
			{
				return Modifier.SourceAttackType.NONE;
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x06012165 RID: 74085 RVA: 0x0006EB50 File Offset: 0x0006CD50
		[Token(Token = "0x170027B3")]
		protected override bool useDynamicAttackType
		{
			[Token(Token = "0x6012165")]
			[Address(RVA = "0xA1F180", Offset = "0xA1DD80", VA = "0x180A1F180", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012166 RID: 74086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012166")]
		[Address(RVA = "0xA1EFE0", Offset = "0xA1DBE0", VA = "0x180A1EFE0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012167 RID: 74087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012167")]
		[Address(RVA = "0xA1EF50", Offset = "0xA1DB50", VA = "0x180A1EF50", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012168 RID: 74088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012168")]
		[Address(RVA = "0xA1EEB0", Offset = "0xA1DAB0", VA = "0x180A1EEB0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012169 RID: 74089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012169")]
		[Address(RVA = "0xA1F070", Offset = "0xA1DC70", VA = "0x180A1F070")]
		public AnimatedActionToTargetAbility()
		{
		}

		// Token: 0x0601216A RID: 74090 RVA: 0x0006EB68 File Offset: 0x0006CD68
		[Token(Token = "0x601216A")]
		[Address(RVA = "0xA1E540", Offset = "0xA1D140", VA = "0x180A1E540")]
		private Modifier.SourceAttackType <>xLuaBaseProxy_get_attackType()
		{
			return Modifier.SourceAttackType.NONE;
		}

		// Token: 0x0601216B RID: 74091 RVA: 0x0006EB80 File Offset: 0x0006CD80
		[Token(Token = "0x601216B")]
		[Address(RVA = "0xA1E550", Offset = "0xA1D150", VA = "0x180A1E550")]
		private bool <>xLuaBaseProxy_get_useDynamicAttackType()
		{
			return default(bool);
		}

		// Token: 0x0601216C RID: 74092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601216C")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0401478E RID: 83854
		[Token(Token = "0x401478E")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x0401478F RID: 83855
		[Token(Token = "0x401478F")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private Modifier.SourceAttackType _attackType;

		// Token: 0x04014790 RID: 83856
		[Token(Token = "0x4014790")]
		[FieldOffset(Offset = "0x1D4")]
		[SerializeField]
		private bool _useDynamicAttackType;

		// Token: 0x04014791 RID: 83857
		[Token(Token = "0x4014791")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attackType;

		// Token: 0x04014792 RID: 83858
		[Token(Token = "0x4014792")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useDynamicAttackType;

		// Token: 0x04014793 RID: 83859
		[Token(Token = "0x4014793")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014794 RID: 83860
		[Token(Token = "0x4014794")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014795 RID: 83861
		[Token(Token = "0x4014795")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04014796 RID: 83862
		[Token(Token = "0x4014796")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
