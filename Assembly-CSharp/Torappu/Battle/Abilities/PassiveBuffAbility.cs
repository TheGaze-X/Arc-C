using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B46 RID: 11078
	[Token(Token = "0x2002B46")]
	public class PassiveBuffAbility : AbilityStandard
	{
		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06012990 RID: 76176 RVA: 0x00071E50 File Offset: 0x00070050
		[Token(Token = "0x170028F9")]
		public override FP cooldown
		{
			[Token(Token = "0x6012990")]
			[Address(RVA = "0xAA25C0", Offset = "0xAA11C0", VA = "0x180AA25C0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x06012991 RID: 76177 RVA: 0x00071E68 File Offset: 0x00070068
		[Token(Token = "0x170028FA")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012991")]
			[Address(RVA = "0xAA2560", Offset = "0xAA1160", VA = "0x180AA2560", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x06012992 RID: 76178 RVA: 0x00071E80 File Offset: 0x00070080
		[Token(Token = "0x170028FB")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012992")]
			[Address(RVA = "0xAA2640", Offset = "0xAA1240", VA = "0x180AA2640", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x06012993 RID: 76179 RVA: 0x00071E98 File Offset: 0x00070098
		[Token(Token = "0x170028FC")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012993")]
			[Address(RVA = "0xAA2500", Offset = "0xAA1100", VA = "0x180AA2500", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012994 RID: 76180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012994")]
		[Address(RVA = "0xAA21F0", Offset = "0xAA0DF0", VA = "0x180AA21F0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012995 RID: 76181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012995")]
		[Address(RVA = "0xAA22C0", Offset = "0xAA0EC0", VA = "0x180AA22C0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012996 RID: 76182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012996")]
		[Address(RVA = "0xAA2260", Offset = "0xAA0E60", VA = "0x180AA2260", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012997 RID: 76183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012997")]
		[Address(RVA = "0xAA2190", Offset = "0xAA0D90", VA = "0x180AA2190", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012998 RID: 76184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012998")]
		[Address(RVA = "0xAA23E0", Offset = "0xAA0FE0", VA = "0x180AA23E0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012999 RID: 76185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012999")]
		[Address(RVA = "0xAA2350", Offset = "0xAA0F50", VA = "0x180AA2350", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x0601299A RID: 76186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601299A")]
		[Address(RVA = "0xAA2470", Offset = "0xAA1070", VA = "0x180AA2470")]
		public PassiveBuffAbility()
		{
		}

		// Token: 0x0401501F RID: 86047
		[Token(Token = "0x401501F")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x04015020 RID: 86048
		[Token(Token = "0x4015020")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04015021 RID: 86049
		[Token(Token = "0x4015021")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04015022 RID: 86050
		[Token(Token = "0x4015022")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04015023 RID: 86051
		[Token(Token = "0x4015023")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04015024 RID: 86052
		[Token(Token = "0x4015024")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015025 RID: 86053
		[Token(Token = "0x4015025")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015026 RID: 86054
		[Token(Token = "0x4015026")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015027 RID: 86055
		[Token(Token = "0x4015027")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04015028 RID: 86056
		[Token(Token = "0x4015028")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04015029 RID: 86057
		[Token(Token = "0x4015029")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x0401502A RID: 86058
		[Token(Token = "0x401502A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
