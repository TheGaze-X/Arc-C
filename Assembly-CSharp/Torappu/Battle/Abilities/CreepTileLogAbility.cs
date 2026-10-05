using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B94 RID: 11156
	[Token(Token = "0x2002B94")]
	public class CreepTileLogAbility : AbilityStandard
	{
		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x06012C7D RID: 76925 RVA: 0x00072F90 File Offset: 0x00071190
		[Token(Token = "0x17002965")]
		public override FP cooldown
		{
			[Token(Token = "0x6012C7D")]
			[Address(RVA = "0xAB7370", Offset = "0xAB5F70", VA = "0x180AB7370", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x06012C7E RID: 76926 RVA: 0x00072FA8 File Offset: 0x000711A8
		[Token(Token = "0x17002966")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012C7E")]
			[Address(RVA = "0xAB7310", Offset = "0xAB5F10", VA = "0x180AB7310", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x06012C7F RID: 76927 RVA: 0x00072FC0 File Offset: 0x000711C0
		[Token(Token = "0x17002967")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012C7F")]
			[Address(RVA = "0xAB73F0", Offset = "0xAB5FF0", VA = "0x180AB73F0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x06012C80 RID: 76928 RVA: 0x00072FD8 File Offset: 0x000711D8
		[Token(Token = "0x17002968")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012C80")]
			[Address(RVA = "0xAB72B0", Offset = "0xAB5EB0", VA = "0x180AB72B0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012C81 RID: 76929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C81")]
		[Address(RVA = "0xAB6AC0", Offset = "0xAB56C0", VA = "0x180AB6AC0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012C82 RID: 76930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C82")]
		[Address(RVA = "0xAB6B90", Offset = "0xAB5790", VA = "0x180AB6B90", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012C83 RID: 76931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C83")]
		[Address(RVA = "0xAB6B30", Offset = "0xAB5730", VA = "0x180AB6B30", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012C84 RID: 76932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C84")]
		[Address(RVA = "0xAB6A60", Offset = "0xAB5660", VA = "0x180AB6A60", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012C85 RID: 76933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C85")]
		[Address(RVA = "0xAB6ED0", Offset = "0xAB5AD0", VA = "0x180AB6ED0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012C86 RID: 76934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C86")]
		[Address(RVA = "0xAB6E40", Offset = "0xAB5A40", VA = "0x180AB6E40", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012C87 RID: 76935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C87")]
		[Address(RVA = "0xAB6C20", Offset = "0xAB5820", VA = "0x180AB6C20", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012C88 RID: 76936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C88")]
		[Address(RVA = "0xAB6D30", Offset = "0xAB5930", VA = "0x180AB6D30", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012C89 RID: 76937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C89")]
		[Address(RVA = "0xAB6F60", Offset = "0xAB5B60", VA = "0x180AB6F60")]
		private void _LogOnGameOver(object arg)
		{
		}

		// Token: 0x06012C8A RID: 76938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C8A")]
		[Address(RVA = "0xAB7250", Offset = "0xAB5E50", VA = "0x180AB7250")]
		public CreepTileLogAbility()
		{
		}

		// Token: 0x06012C8B RID: 76939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C8B")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012C8C RID: 76940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C8C")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x04015372 RID: 86898
		[Token(Token = "0x4015372")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private int _tileMode;

		// Token: 0x04015373 RID: 86899
		[Token(Token = "0x4015373")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04015374 RID: 86900
		[Token(Token = "0x4015374")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04015375 RID: 86901
		[Token(Token = "0x4015375")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04015376 RID: 86902
		[Token(Token = "0x4015376")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04015377 RID: 86903
		[Token(Token = "0x4015377")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015378 RID: 86904
		[Token(Token = "0x4015378")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015379 RID: 86905
		[Token(Token = "0x4015379")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x0401537A RID: 86906
		[Token(Token = "0x401537A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x0401537B RID: 86907
		[Token(Token = "0x401537B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x0401537C RID: 86908
		[Token(Token = "0x401537C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x0401537D RID: 86909
		[Token(Token = "0x401537D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x0401537E RID: 86910
		[Token(Token = "0x401537E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x0401537F RID: 86911
		[Token(Token = "0x401537F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LogOnGameOver;

		// Token: 0x04015380 RID: 86912
		[Token(Token = "0x4015380")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
