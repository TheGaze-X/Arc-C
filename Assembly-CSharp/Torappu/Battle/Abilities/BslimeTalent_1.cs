using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B89 RID: 11145
	[Token(Token = "0x2002B89")]
	public class BslimeTalent_1 : AbilityStandard, IActionNodeSource, IBuffSource
	{
		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x06012BFB RID: 76795 RVA: 0x00072D20 File Offset: 0x00070F20
		[Token(Token = "0x17002951")]
		public override FP cooldown
		{
			[Token(Token = "0x6012BFB")]
			[Address(RVA = "0xAB1EF0", Offset = "0xAB0AF0", VA = "0x180AB1EF0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x06012BFC RID: 76796 RVA: 0x00072D38 File Offset: 0x00070F38
		[Token(Token = "0x17002952")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012BFC")]
			[Address(RVA = "0xAB1E90", Offset = "0xAB0A90", VA = "0x180AB1E90", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x06012BFD RID: 76797 RVA: 0x00072D50 File Offset: 0x00070F50
		[Token(Token = "0x17002953")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012BFD")]
			[Address(RVA = "0xAB1F70", Offset = "0xAB0B70", VA = "0x180AB1F70", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x06012BFE RID: 76798 RVA: 0x00072D68 File Offset: 0x00070F68
		[Token(Token = "0x17002954")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012BFE")]
			[Address(RVA = "0xAB1E30", Offset = "0xAB0A30", VA = "0x180AB1E30", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012BFF RID: 76799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BFF")]
		[Address(RVA = "0xAB15F0", Offset = "0xAB01F0", VA = "0x180AB15F0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012C00 RID: 76800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C00")]
		[Address(RVA = "0xAB1A30", Offset = "0xAB0630", VA = "0x180AB1A30", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012C01 RID: 76801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C01")]
		[Address(RVA = "0xAB1B00", Offset = "0xAB0700", VA = "0x180AB1B00", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012C02 RID: 76802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C02")]
		[Address(RVA = "0xAB1AA0", Offset = "0xAB06A0", VA = "0x180AB1AA0", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012C03 RID: 76803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C03")]
		[Address(RVA = "0xAB19D0", Offset = "0xAB05D0", VA = "0x180AB19D0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012C04 RID: 76804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C04")]
		[Address(RVA = "0xAB1CD0", Offset = "0xAB08D0", VA = "0x180AB1CD0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012C05 RID: 76805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C05")]
		[Address(RVA = "0xAB1C40", Offset = "0xAB0840", VA = "0x180AB1C40", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012C06 RID: 76806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C06")]
		[Address(RVA = "0xAB1930", Offset = "0xAB0530", VA = "0x180AB1930", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x06012C07 RID: 76807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C07")]
		[Address(RVA = "0xAB1690", Offset = "0xAB0290", VA = "0x180AB1690")]
		private void GatherProjectileFromBuffs(BuffData[] buffs, List<string> projectiles)
		{
		}

		// Token: 0x06012C08 RID: 76808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C08")]
		[Address(RVA = "0xAB1D60", Offset = "0xAB0960", VA = "0x180AB1D60")]
		public BslimeTalent_1()
		{
		}

		// Token: 0x06012C09 RID: 76809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C09")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x06012C0A RID: 76810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C0A")]
		[Address(RVA = "0xA4B080", Offset = "0xA49C80", VA = "0x180A4B080")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x040152F6 RID: 86774
		[Token(Token = "0x40152F6")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x040152F7 RID: 86775
		[Token(Token = "0x40152F7")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected ActionArray _projectileActions;

		// Token: 0x040152F8 RID: 86776
		[Token(Token = "0x40152F8")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected BuffData[] _projectileBuffs;

		// Token: 0x040152F9 RID: 86777
		[Token(Token = "0x40152F9")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Projectile.Event[] _ignoredProjectileEvents;

		// Token: 0x040152FA RID: 86778
		[Token(Token = "0x40152FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040152FB RID: 86779
		[Token(Token = "0x40152FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040152FC RID: 86780
		[Token(Token = "0x40152FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x040152FD RID: 86781
		[Token(Token = "0x40152FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x040152FE RID: 86782
		[Token(Token = "0x40152FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x040152FF RID: 86783
		[Token(Token = "0x40152FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015300 RID: 86784
		[Token(Token = "0x4015300")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015301 RID: 86785
		[Token(Token = "0x4015301")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015302 RID: 86786
		[Token(Token = "0x4015302")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04015303 RID: 86787
		[Token(Token = "0x4015303")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04015304 RID: 86788
		[Token(Token = "0x4015304")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04015305 RID: 86789
		[Token(Token = "0x4015305")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04015306 RID: 86790
		[Token(Token = "0x4015306")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GatherProjectileFromBuffs;

		// Token: 0x04015307 RID: 86791
		[Token(Token = "0x4015307")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
