using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020DB RID: 8411
	[Token(Token = "0x20020DB")]
	public class EmptyAbility : AbilityStandard
	{
		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x0600CDC8 RID: 52680 RVA: 0x0004A3D0 File Offset: 0x000485D0
		[Token(Token = "0x1700184C")]
		public override FP cooldown
		{
			[Token(Token = "0x600CDC8")]
			[Address(RVA = "0x34FE3B0", Offset = "0x34FCFB0", VA = "0x1834FE3B0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x0600CDC9 RID: 52681 RVA: 0x0004A3E8 File Offset: 0x000485E8
		[Token(Token = "0x1700184D")]
		public override Ability.Category category
		{
			[Token(Token = "0x600CDC9")]
			[Address(RVA = "0x34FE350", Offset = "0x34FCF50", VA = "0x1834FE350", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x0600CDCA RID: 52682 RVA: 0x0004A400 File Offset: 0x00048600
		[Token(Token = "0x1700184E")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x600CDCA")]
			[Address(RVA = "0x34FE490", Offset = "0x34FD090", VA = "0x1834FE490", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x0600CDCB RID: 52683 RVA: 0x0004A418 File Offset: 0x00048618
		[Token(Token = "0x1700184F")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x600CDCB")]
			[Address(RVA = "0x34FE2F0", Offset = "0x34FCEF0", VA = "0x1834FE2F0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x0600CDCC RID: 52684 RVA: 0x0004A430 File Offset: 0x00048630
		[Token(Token = "0x17001850")]
		public override bool ignorePalsyInterrupt
		{
			[Token(Token = "0x600CDCC")]
			[Address(RVA = "0x34FE430", Offset = "0x34FD030", VA = "0x1834FE430", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CDCD RID: 52685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CDCD")]
		[Address(RVA = "0x34FDE90", Offset = "0x34FCA90", VA = "0x1834FDE90", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0600CDCE RID: 52686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CDCE")]
		[Address(RVA = "0x34FDF60", Offset = "0x34FCB60", VA = "0x1834FDF60", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0600CDCF RID: 52687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CDCF")]
		[Address(RVA = "0x34FDF00", Offset = "0x34FCB00", VA = "0x1834FDF00", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0600CDD0 RID: 52688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CDD0")]
		[Address(RVA = "0x34FDE30", Offset = "0x34FCA30", VA = "0x1834FDE30", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0600CDD1 RID: 52689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CDD1")]
		[Address(RVA = "0x34FE080", Offset = "0x34FCC80", VA = "0x1834FE080", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CDD2")]
		[Address(RVA = "0x34FDFF0", Offset = "0x34FCBF0", VA = "0x1834FDFF0", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDD3")]
		[Address(RVA = "0x34FE110", Offset = "0x34FCD10", VA = "0x1834FE110")]
		public EmptyAbility()
		{
		}

		// Token: 0x0600CDD4 RID: 52692 RVA: 0x0004A448 File Offset: 0x00048648
		[Token(Token = "0x600CDD4")]
		[Address(RVA = "0x34F6B40", Offset = "0x34F5740", VA = "0x1834F6B40")]
		private bool <>xLuaBaseProxy_get_ignorePalsyInterrupt()
		{
			return default(bool);
		}

		// Token: 0x0400DB3A RID: 56122
		[Token(Token = "0x400DB3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x0400DB3B RID: 56123
		[Token(Token = "0x400DB3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x0400DB3C RID: 56124
		[Token(Token = "0x400DB3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x0400DB3D RID: 56125
		[Token(Token = "0x400DB3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x0400DB3E RID: 56126
		[Token(Token = "0x400DB3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignorePalsyInterrupt;

		// Token: 0x0400DB3F RID: 56127
		[Token(Token = "0x400DB3F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x0400DB40 RID: 56128
		[Token(Token = "0x400DB40")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x0400DB41 RID: 56129
		[Token(Token = "0x400DB41")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x0400DB42 RID: 56130
		[Token(Token = "0x400DB42")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x0400DB43 RID: 56131
		[Token(Token = "0x400DB43")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x0400DB44 RID: 56132
		[Token(Token = "0x400DB44")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x0400DB45 RID: 56133
		[Token(Token = "0x400DB45")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
